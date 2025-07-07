// <copyright file="VzM2MTokenManager.cs" company="APIMatic">
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
    /// VzM2MTokenManager Class.
    /// </summary>
    internal class VzM2MTokenManager : AuthManager, IVzM2MTokenCredentials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VzM2MTokenManager"/> class.
        /// </summary>
        /// <param name="vzM2MToken">VzM2MToken.</param>
        public VzM2MTokenManager(VzM2MTokenModel vzM2MTokenModel)
        {
            VzM2MToken = vzM2MTokenModel?.VzM2MToken;
            Parameters(paramBuilder => paramBuilder
                .Header(header => header.Setup("VZ-M2M-Token", VzM2MToken).Required())
            );
        }

        /// <summary>
        /// Gets string value for vzM2MToken.
        /// </summary>
        public string VzM2MToken { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="vzM2MToken"> The string value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string vzM2MToken)
        {
            return vzM2MToken.Equals(this.VzM2MToken);
        }
    }

    public sealed class VzM2MTokenModel
    {
        internal VzM2MTokenModel()
        {
        }

        internal string VzM2MToken { get; set; }

        /// <summary>
        /// Creates an object of the VzM2MTokenModel using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            return new Builder(VzM2MToken);
        }

        /// <summary>
        /// Builder class for VzM2MTokenModel.
        /// </summary>
        public class Builder
        {
            private string vzM2MToken;

            public Builder(string vzM2MToken)
            {
                this.vzM2MToken = vzM2MToken ?? throw new ArgumentNullException(nameof(vzM2MToken));
            }

            /// <summary>
            /// Sets VzM2MToken.
            /// </summary>
            /// <param name="vzM2MToken">VzM2MToken.</param>
            /// <returns>Builder.</returns>
            public Builder VzM2MToken(string vzM2MToken)
            {
                this.vzM2MToken = vzM2MToken ?? throw new ArgumentNullException(nameof(vzM2MToken));
                return this;
            }

            /// <summary>
            /// Creates an object of the VzM2MTokenModel using the values provided for the builder.
            /// </summary>
            /// <returns>VzM2MTokenModel.</returns>
            public VzM2MTokenModel Build()
            {
                return new VzM2MTokenModel()
                {
                    VzM2MToken = this.vzM2MToken
                };
            }
        }
    }
    
}