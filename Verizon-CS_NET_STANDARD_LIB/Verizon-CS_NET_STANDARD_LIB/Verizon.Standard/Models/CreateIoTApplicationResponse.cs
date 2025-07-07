// <copyright file="CreateIoTApplicationResponse.cs" company="APIMatic">
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
    /// CreateIoTApplicationResponse.
    /// </summary>
    public class CreateIoTApplicationResponse
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
        /// Initializes a new instance of the <see cref="CreateIoTApplicationResponse"/> class.
        /// </summary>
        public CreateIoTApplicationResponse()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIoTApplicationResponse"/> class.
        /// </summary>
        /// <param name="appName">appName.</param>
        /// <param name="sharedSecret">sharedSecret.</param>
        /// <param name="url">url.</param>
        public CreateIoTApplicationResponse(
            string appName = null,
            string sharedSecret = null,
            string url = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AppName = appName;
            this.SharedSecret = sharedSecret;
            this.Url = url;
        }

        /// <summary>
        /// An application will be created under the user's Azure subscription with this name and of type IOT central.
        /// </summary>
        [JsonProperty("appName", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// Part of the user credentials (from Azure) the user needs to use for calling further TS Core APIs for setting up Azure cloud connector.
        /// </summary>
        [JsonProperty("sharedSecret", NullValueHandling = NullValueHandling.Ignore)]
        public string SharedSecret { get; set; }

        /// <summary>
        /// An IOT central endpoint the user can use to see the data that is being streamed.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateIoTApplicationResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateIoTApplicationResponse other &&
                (this.AppName == null && other.AppName == null ||
                 this.AppName?.Equals(other.AppName) == true) &&
                (this.SharedSecret == null && other.SharedSecret == null ||
                 this.SharedSecret?.Equals(other.SharedSecret) == true) &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true) &&
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
            toStringOutput.Add($"AppName = {this.AppName ?? "null"}");
            toStringOutput.Add($"SharedSecret = {this.SharedSecret ?? "null"}");
            toStringOutput.Add($"Url = {this.Url ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}