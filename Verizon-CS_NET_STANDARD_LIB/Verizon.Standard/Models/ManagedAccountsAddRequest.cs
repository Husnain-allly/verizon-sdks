// <copyright file="ManagedAccountsAddRequest.cs" company="APIMatic">
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
    /// ManagedAccountsAddRequest.
    /// </summary>
    public class ManagedAccountsAddRequest
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
        /// Initializes a new instance of the <see cref="ManagedAccountsAddRequest"/> class.
        /// </summary>
        public ManagedAccountsAddRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAccountsAddRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="type">type.</param>
        /// <param name="managedAccList">managedAccList.</param>
        public ManagedAccountsAddRequest(
            string accountName,
            Models.ServiceName serviceName,
            string type,
            List<string> managedAccList)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountName = accountName;
            this.ServiceName = serviceName;
            this.Type = type;
            this.ManagedAccList = managedAccList;
        }

        /// <summary>
        /// Account identifier
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Service name
        /// </summary>
        [JsonProperty("serviceName")]
        public Models.ServiceName ServiceName { get; set; }

        /// <summary>
        /// SKU name
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// managed account list
        /// </summary>
        [JsonProperty("managedAccList")]
        public List<string> ManagedAccList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ManagedAccountsAddRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ManagedAccountsAddRequest other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.ServiceName.Equals(other.ServiceName)) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.ManagedAccList == null && other.ManagedAccList == null ||
                 this.ManagedAccList?.Equals(other.ManagedAccList) == true) &&
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
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"ServiceName = {this.ServiceName}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"ManagedAccList = {(this.ManagedAccList == null ? "null" : $"[{string.Join(", ", this.ManagedAccList)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}