// <copyright file="TargetAuthenticationBody.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Runtime.CompilerServices;
using Verizon.Standard;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
{
    /// <summary>
    /// TargetAuthenticationBody.
    /// </summary>
    public class TargetAuthenticationBody
    {
        [JsonExtensionData]
        private readonly IDictionary<string, JToken> additionalProperties;

        private readonly IEnumerable<string> propertyName;

        /// <summary>
        /// Get or set the value associated with the specified key in the AdditionalProperties dictionary.
        /// </summary>
        /// <param name="key">The key of the value to get or set. This must be a valid key that is not reserved for internal properties.</param>
        /// <returns>The object value associated with the specified key in the AdditionalProperties dictionary.</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="key"/> is null or an empty string.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when the specified <paramref name="key"/> conflicts with an internal property of the object.
        /// </exception>
        /// <exception cref="KeyNotFoundException">
        /// Thrown when the specified <paramref name="key"/> does not exist in the AdditionalProperties dictionary.
        /// </exception>
        [IndexerName("AdditionalPropertiesIndexer")]
        public object this[string key]
        {
            get => additionalProperties.GetValue<object>(key);
            set => additionalProperties.SetValue(key, value, propertyName);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TargetAuthenticationBody"/> class.
        /// </summary>
        public TargetAuthenticationBody()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TargetAuthenticationBody"/> class.
        /// </summary>
        /// <param name="grantType">grant_type.</param>
        /// <param name="refreshToken">refresh_token.</param>
        /// <param name="scope">scope.</param>
        /// <param name="headers">headers.</param>
        /// <param name="host">host.</param>
        public TargetAuthenticationBody(
            string grantType = null,
            string refreshToken = null,
            string scope = null,
            Models.TargetAuthenticationBodyHeaders headers = null,
            Models.TargetAuthenticationBodyHost host = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.GrantType = grantType;
            this.RefreshToken = refreshToken;
            this.Scope = scope;
            this.Headers = headers;
            this.Host = host;
        }

        /// <summary>
        /// Authentication grant type.
        /// </summary>
        [JsonProperty("grant_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GrantType { get; set; }

        /// <summary>
        /// Refresh token.
        /// </summary>
        [JsonProperty("refresh_token", NullValueHandling = NullValueHandling.Ignore)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Authentication scopes.
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        /// <summary>
        /// Authentication headers.
        /// </summary>
        [JsonProperty("headers", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TargetAuthenticationBodyHeaders Headers { get; set; }

        /// <summary>
        /// Host information.
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TargetAuthenticationBodyHost Host { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TargetAuthenticationBody : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is TargetAuthenticationBody other &&
                (this.GrantType == null && other.GrantType == null ||
                 this.GrantType?.Equals(other.GrantType) == true) &&
                (this.RefreshToken == null && other.RefreshToken == null ||
                 this.RefreshToken?.Equals(other.RefreshToken) == true) &&
                (this.Scope == null && other.Scope == null ||
                 this.Scope?.Equals(other.Scope) == true) &&
                (this.Headers == null && other.Headers == null ||
                 this.Headers?.Equals(other.Headers) == true) &&
                (this.Host == null && other.Host == null ||
                 this.Host?.Equals(other.Host) == true) &&
                (this.additionalProperties == null && other.additionalProperties == null ||
                 this.additionalProperties?.Count == other.additionalProperties?.Count &&
                 this.additionalProperties?.All(kv =>
                     other.additionalProperties.TryGetValue(kv.Key, out var value) &&
                     JToken.DeepEquals(kv.Value, value)) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"GrantType = {this.GrantType ?? "null"}");
            toStringOutput.Add($"RefreshToken = {this.RefreshToken ?? "null"}");
            toStringOutput.Add($"Scope = {this.Scope ?? "null"}");
            toStringOutput.Add($"Headers = {(this.Headers == null ? "null" : this.Headers.ToString())}");
            toStringOutput.Add($"Host = {(this.Host == null ? "null" : this.Host.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}