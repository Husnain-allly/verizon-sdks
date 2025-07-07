// <copyright file="ISessionTokenCredentials.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;

namespace Verizon.Standard.Authentication
{
    /// <summary>
    /// Authentication configuration interface for SessionToken.
    /// </summary>
    public interface ISessionTokenCredentials
    {
        /// <summary>
        /// Gets string value for sessionToken.
        /// </summary>
        string SessionToken { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        /// <param name="sessionToken"> The string value for credentials.</param>
        /// <returns>True if credentials matched.</returns>
        bool Equals(string sessionToken);
    }
}