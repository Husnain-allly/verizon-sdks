// <copyright file="SessionTokenManager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Verizon.Standard.Http.Request;
using APIMatic.Core.Authentication;

namespace Verizon.Standard.Authentication
{
    /// <summary>
    /// SessionTokenManager Class.
    /// </summary>
    internal class SessionTokenManager : AuthManager, ISessionTokenCredentials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionTokenManager"/> class.
        /// </summary>
        /// <param name="sessionToken">SessionToken.</param>
        public SessionTokenManager(SessionTokenModel sessionTokenModel)
        {
            SessionToken = sessionTokenModel?.SessionToken;
            Parameters(paramBuilder => paramBuilder
                .Header(header => header.Setup("SessionToken", SessionToken).Required())
            );
        }

        /// <summary>
        /// Gets string value for sessionToken.
        /// </summary>
        public string SessionToken { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="sessionToken"> The string value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string sessionToken)
        {
            return sessionToken.Equals(this.SessionToken);
        }
    }

    public sealed class SessionTokenModel
    {
        internal SessionTokenModel()
        {
        }

        internal string SessionToken { get; set; }

        /// <summary>
        /// Creates an object of the SessionTokenModel using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            return new Builder(SessionToken);
        }

        /// <summary>
        /// Builder class for SessionTokenModel.
        /// </summary>
        public class Builder
        {
            private string sessionToken;

            public Builder(string sessionToken)
            {
                this.sessionToken = sessionToken ?? throw new ArgumentNullException(nameof(sessionToken));
            }

            /// <summary>
            /// Sets SessionToken.
            /// </summary>
            /// <param name="sessionToken">SessionToken.</param>
            /// <returns>Builder.</returns>
            public Builder SessionToken(string sessionToken)
            {
                this.sessionToken = sessionToken ?? throw new ArgumentNullException(nameof(sessionToken));
                return this;
            }

            /// <summary>
            /// Creates an object of the SessionTokenModel using the values provided for the builder.
            /// </summary>
            /// <returns>SessionTokenModel.</returns>
            public SessionTokenModel Build()
            {
                return new SessionTokenModel()
                {
                    SessionToken = this.sessionToken
                };
            }
        }
    }
    
}