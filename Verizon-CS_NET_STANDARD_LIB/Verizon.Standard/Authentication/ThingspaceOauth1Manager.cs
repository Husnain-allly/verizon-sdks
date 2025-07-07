// <copyright file="ThingspaceOauth1Manager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Standard.Apis;
using Verizon.Standard.Http.Response;using Verizon.Standard.Models;
using Verizon.Standard.Utilities;
using Verizon.Standard.Exceptions;
using APIMatic.Core.Authentication;
using APIMatic.Core.Request;
using APIMatic.Core;

namespace Verizon.Standard.Authentication
{
    /// <summary>
    /// ThingspaceOauth1Manager Class.
    /// </summary>
    public class ThingspaceOauth1Manager : AuthManager, IThingspaceOauth1Credentials
    {
        private readonly Func<OauthAuthorizationApi> getOAuthController;

        /// <summary>
        /// Initializes a new instance of the <see cref="ThingspaceOauth1Manager"/> class.
        /// </summary>
        /// <param name="thingspaceOauth1"> OAuth 2 Client Cridentials Model.</param>
        /// <param name="getOAuthController">A function that provides an instance of <see cref="OauthAuthorizationApi"/>.</param>
        internal ThingspaceOauth1Manager(ThingspaceOauth1Model thingspaceOauth1,
            Func<OauthAuthorizationApi> getOAuthController)
        {
            OauthClientId = thingspaceOauth1?.OauthClientId;
            OauthClientSecret = thingspaceOauth1?.OauthClientSecret;
            OauthToken = thingspaceOauth1?.OauthToken;
            this.getOAuthController = getOAuthController;
            OauthClockSkew = thingspaceOauth1?.OauthClockSkew;
            OauthTokenProvider = thingspaceOauth1?.OauthTokenProvider;
            OauthOnTokenUpdate = thingspaceOauth1?.OauthOnTokenUpdate;
            OauthTokenAutoRefresh = thingspaceOauth1?.OauthToken;
        }

        /// <summary>
        /// Gets string value for oauthClientId.
        /// </summary>
        public string OauthClientId { get; }

        /// <summary>
        /// Gets string value for oauthClientSecret.
        /// </summary>
        public string OauthClientSecret { get; }

        /// <summary>
        /// Gets Models.OauthToken value for oauthToken.
        /// </summary>
        public Models.OauthToken OauthToken { get; }

        /// <summary>
        /// Gets TimeSpan? value for oauthClockSkew.
        /// </summary>
        public TimeSpan? OauthClockSkew { get; }

        /// <summary>
        /// Gets Func of OauthToken value for oauthTokenProvider.
        /// </summary>
        public Func<ThingspaceOauth1Manager, OauthToken, Task<OauthToken>> OauthTokenProvider { get; }

        /// <summary>
        /// Gets Action of OauthToken value for oauthOnTokenUpdate.
        /// </summary>
        public Action<OauthToken> OauthOnTokenUpdate { get; }

        /// <summary>
        /// Gets OauthToken value for oauthTokenAutoRefresh.
        /// </summary>
        private OauthToken OauthTokenAutoRefresh { get; set; }

        private readonly SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1);


        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="oauthClientId"> The string value for credentials.</param>
        /// <param name="oauthClientSecret"> The string value for credentials.</param>
        /// <param name="oauthToken"> The Models.OauthToken value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string oauthClientId, string oauthClientSecret, Models.OauthToken oauthToken)
        {
            return oauthClientId.Equals(this.OauthClientId)
                    && oauthClientSecret.Equals(this.OauthClientSecret)
                    && ((oauthToken == null && this.OauthToken == null) || (oauthToken != null && this.OauthToken != null && oauthToken.Equals(this.OauthToken)));
        }

        /// <summary>
        /// Fetch the OAuth token.
        /// </summary>
        /// <param name="additionalParameters">Dictionary of additional parameters.</param>
        /// <returns>Models.OauthToken.</returns>
        public Models.OauthToken FetchToken(Dictionary<string, object> additionalParameters = null)
            => ApiHelper.RunTask(FetchTokenAsync(additionalParameters));
       

        /// <summary>
        /// Fetch the OAuth token asynchronously.
        /// </summary>
        /// <param name="additionalParameters">Dictionary of additional parameters.</param>
        /// <returns>Models.OauthToken.</returns>
        public async Task<Models.OauthToken> FetchTokenAsync(Dictionary<string, object> additionalParameters = null)
        {
            var token = await getOAuthController().RequestTokenThingspaceOauth1Async(BuildBasicAuthHeader(), fieldParameters: additionalParameters).ConfigureAwait(false);

            if (token.Data.ExpiresIn != null && token.Data.ExpiresIn != 0)
            {
                token.Data.Expiry = (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds + token.Data.ExpiresIn;
            }

            return token.Data;
        }
 
        /// <summary>
        /// Checks if token is expired.
        /// </summary>
        /// <returns> Returns true if token is expired.</returns>
        public bool IsTokenExpired()
        {
           if (this.OauthToken == null)
           {
               throw new InvalidOperationException("OAuth token is missing.");
           }
        
           return this.OauthToken.Expiry != null
               && this.OauthToken.Expiry < (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }

        /// <inheritdoc />
        public override async Task Apply(RequestBuilder requestBuilder)
        {
            var token = await FetchOrReturnToken().ConfigureAwait(false);
            Parameters(authParameter => authParameter
                .Header(headerParameter => headerParameter
                    .Setup("Authorization",
                        token?.AccessToken == null ? null : $"Bearer {token.AccessToken}"
                    ).Required()));
            await base.Apply(requestBuilder).ConfigureAwait(false);
        }

        private async Task<OauthToken> FetchOrReturnToken()
        {
            if (OauthTokenAutoRefresh != null && !OauthTokenAutoRefresh.IsTokenExpired(OauthClockSkew))
                return OauthTokenAutoRefresh;

            await semaphoreSlim.WaitAsync().ConfigureAwait(false);
            try
            {
                if (OauthTokenAutoRefresh != null && !OauthTokenAutoRefresh.IsTokenExpired(OauthClockSkew))
                    return OauthTokenAutoRefresh;
                OauthTokenAutoRefresh = OauthTokenProvider != null
                    ? await OauthTokenProvider(this, OauthTokenAutoRefresh).ConfigureAwait(false)
                    : await FetchTokenAsync().ConfigureAwait(false);
            }
            finally
            {
                semaphoreSlim.Release();
            }

            OauthOnTokenUpdate?.Invoke(OauthTokenAutoRefresh);

            if (OauthTokenAutoRefresh == null)
                throw new ApiException(
                    "Client is not authorized.An OAuth token is needed to make API calls.");

            if (OauthTokenAutoRefresh.IsTokenExpired(TimeSpan.Zero))
                throw new ApiException("OAuth token is expired. A valid token is needed to make API calls.");

            return OauthTokenAutoRefresh;
        }


        /// <summary>
        /// Build basic auth header.
        /// </summary>
        /// <returns> string. </returns>
        private string BuildBasicAuthHeader()
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(this.OauthClientId + ':' + this.OauthClientSecret);
            return "Basic " + Convert.ToBase64String(plainTextBytes);
        }
    }

    public sealed class ThingspaceOauth1Model
    {
        internal ThingspaceOauth1Model()
        {
        }

        internal string OauthClientId { get; set; }

        internal string OauthClientSecret { get; set; }

        internal Models.OauthToken OauthToken { get; set; }

        internal TimeSpan? OauthClockSkew { get; set; }

        internal Func<ThingspaceOauth1Manager, OauthToken, Task<OauthToken>> OauthTokenProvider { get; set; }

        internal Action<OauthToken> OauthOnTokenUpdate { get; set; }

        /// <summary>
        /// Creates an object of the ThingspaceOauth1Model using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            return new Builder(OauthClientId, OauthClientSecret)
                .OauthToken(OauthToken)
                .OauthClockSkew(OauthClockSkew)
                .OauthTokenProvider(OauthTokenProvider)
                .OauthOnTokenUpdate(OauthOnTokenUpdate);
        }

        /// <summary>
        /// Builder class for ThingspaceOauth1Model.
        /// </summary>
        public class Builder
        {
            private string oauthClientId;
            private string oauthClientSecret;
            private Models.OauthToken oauthToken;
            private TimeSpan? oauthClockSkew;
            private Func<ThingspaceOauth1Manager, OauthToken, Task<OauthToken>> oauthTokenProvider;
            private Action<OauthToken> oauthOnTokenUpdate;

            public Builder(string oauthClientId, string oauthClientSecret)
            {
                this.oauthClientId = oauthClientId ?? throw new ArgumentNullException(nameof(oauthClientId));
                this.oauthClientSecret = oauthClientSecret ?? throw new ArgumentNullException(nameof(oauthClientSecret));
            }

            /// <summary>
            /// Sets OauthClientId.
            /// </summary>
            /// <param name="oauthClientId">OauthClientId.</param>
            /// <returns>Builder.</returns>
            public Builder OauthClientId(string oauthClientId)
            {
                this.oauthClientId = oauthClientId ?? throw new ArgumentNullException(nameof(oauthClientId));
                return this;
            }

            /// <summary>
            /// Sets OauthClientSecret.
            /// </summary>
            /// <param name="oauthClientSecret">OauthClientSecret.</param>
            /// <returns>Builder.</returns>
            public Builder OauthClientSecret(string oauthClientSecret)
            {
                this.oauthClientSecret = oauthClientSecret ?? throw new ArgumentNullException(nameof(oauthClientSecret));
                return this;
            }

            /// <summary>
            /// Sets OauthToken.
            /// </summary>
            /// <param name="oauthToken">OauthToken.</param>
            /// <returns>Builder.</returns>
            public Builder OauthToken(Models.OauthToken oauthToken)
            {
                this.oauthToken = oauthToken;
                return this;
            }

            /// <summary>
            /// Sets OauthClockSkew.
            /// </summary>
            /// <param name="oauthClockSkew">oauthClockSkew.</param>
            /// <returns>Builder.</returns>
            public Builder OauthClockSkew(TimeSpan? oauthClockSkew)
            {
                this.oauthClockSkew = oauthClockSkew;
                return this;
            }

            /// <summary>
            /// Sets OauthTokenProvider.
            /// </summary>
            /// <param name="oauthTokenProvider">oauthTokenProvider.</param>
            /// <returns>Builder.</returns>
            public Builder OauthTokenProvider(Func<ThingspaceOauth1Manager, OauthToken, Task<OauthToken>> oauthTokenProvider)
            {
                this.oauthTokenProvider = oauthTokenProvider;
                return this;
            }

            /// <summary>
            /// Sets OauthOnTokenUpdate.
            /// </summary>
            /// <param name="oauthOnTokenUpdate">oauthOnTokenUpdate.</param>
            /// <returns>Builder.</returns>
            public Builder OauthOnTokenUpdate(Action<OauthToken> oauthOnTokenUpdate)
            {
                this.oauthOnTokenUpdate = oauthOnTokenUpdate;
                return this;
            }

            /// <summary>
            /// Creates an object of the ThingspaceOauth1Model using the values provided for the builder.
            /// </summary>
            /// <returns>ThingspaceOauth1Model.</returns>
            public ThingspaceOauth1Model Build()
            {
                return new ThingspaceOauth1Model()
                {
                    OauthClientId = this.oauthClientId,
                    OauthClientSecret = this.oauthClientSecret,
                    OauthToken = this.oauthToken,
                    OauthClockSkew = this.oauthClockSkew,
                    OauthTokenProvider = this.oauthTokenProvider,
                    OauthOnTokenUpdate = this.oauthOnTokenUpdate
                };
            }
        }
    }
}