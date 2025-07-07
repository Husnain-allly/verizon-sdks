// <copyright file="IVzM2MTokenCredentials.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;

namespace Verizon.Standard.Authentication
{
    /// <summary>
    /// Authentication configuration interface for VzM2MToken.
    /// </summary>
    public interface IVzM2MTokenCredentials
    {
        /// <summary>
        /// Gets string value for vzM2MToken.
        /// </summary>
        string VzM2MToken { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        /// <param name="vzM2MToken"> The string value for credentials.</param>
        /// <returns>True if credentials matched.</returns>
        bool Equals(string vzM2MToken);
    }
}