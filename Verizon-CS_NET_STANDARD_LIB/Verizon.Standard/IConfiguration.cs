// <copyright file="IConfiguration.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Net;
using Verizon.Standard.Authentication;
using Verizon.Standard.Models;

namespace Verizon.Standard
{
    /// <summary>
    /// IConfiguration.
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Gets Current API environment.
        /// </summary>
        Environment Environment { get; }

        /// <summary>
        /// Gets the credentials to use with ThingspaceOauth.
        /// </summary>
        IThingspaceOauthCredentials ThingspaceOauthCredentials { get; }

        /// <summary>
        /// Gets the credentials model to use with ThingspaceOauth.
        /// </summary>
        ThingspaceOauthModel ThingspaceOauthModel { get; }

        /// <summary>
        /// Gets the credentials to use with VzM2MToken.
        /// </summary>
        IVzM2MTokenCredentials VzM2MTokenCredentials { get; }

        /// <summary>
        /// Gets the credentials model to use with VzM2MToken.
        /// </summary>
        VzM2MTokenModel VzM2MTokenModel { get; }

        /// <summary>
        /// Gets the credentials to use with ThingspaceOauth1.
        /// </summary>
        IThingspaceOauth1Credentials ThingspaceOauth1Credentials { get; }

        /// <summary>
        /// Gets the credentials model to use with ThingspaceOauth1.
        /// </summary>
        ThingspaceOauth1Model ThingspaceOauth1Model { get; }

        /// <summary>
        /// Gets the credentials to use with SessionToken.
        /// </summary>
        ISessionTokenCredentials SessionTokenCredentials { get; }

        /// <summary>
        /// Gets the credentials model to use with SessionToken.
        /// </summary>
        SessionTokenModel SessionTokenModel { get; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:EDGE DISCOVERY.</param>
        /// <returns>Returns the baseurl.</returns>
        string GetBaseUri(Server alias = Server.EdgeDiscovery);
    }
}