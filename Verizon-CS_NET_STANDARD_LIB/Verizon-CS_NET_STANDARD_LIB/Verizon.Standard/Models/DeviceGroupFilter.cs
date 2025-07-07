// <copyright file="DeviceGroupFilter.cs" company="APIMatic">
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
    /// DeviceGroupFilter.
    /// </summary>
    public class DeviceGroupFilter
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
        /// Initializes a new instance of the <see cref="DeviceGroupFilter"/> class.
        /// </summary>
        public DeviceGroupFilter()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceGroupFilter"/> class.
        /// </summary>
        /// <param name="deviceGroupName">deviceGroupName.</param>
        /// <param name="individualOrCombined">IndividualOrCombined.</param>
        /// <param name="accountName">accountName.</param>
        public DeviceGroupFilter(
            string deviceGroupName = null,
            string individualOrCombined = null,
            string accountName = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.DeviceGroupName = deviceGroupName;
            this.IndividualOrCombined = individualOrCombined;
            this.AccountName = accountName;
        }

        /// <summary>
        /// Gets or sets DeviceGroupName.
        /// </summary>
        [JsonProperty("deviceGroupName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceGroupName { get; set; }

        /// <summary>
        /// Gets or sets IndividualOrCombined.
        /// </summary>
        [JsonProperty("IndividualOrCombined", NullValueHandling = NullValueHandling.Ignore)]
        public string IndividualOrCombined { get; set; }

        /// <summary>
        /// The numeric name of the account and must include leading zeroes
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeviceGroupFilter : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeviceGroupFilter other &&
                (this.DeviceGroupName == null && other.DeviceGroupName == null ||
                 this.DeviceGroupName?.Equals(other.DeviceGroupName) == true) &&
                (this.IndividualOrCombined == null && other.IndividualOrCombined == null ||
                 this.IndividualOrCombined?.Equals(other.IndividualOrCombined) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
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
            toStringOutput.Add($"DeviceGroupName = {this.DeviceGroupName ?? "null"}");
            toStringOutput.Add($"IndividualOrCombined = {this.IndividualOrCombined ?? "null"}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}