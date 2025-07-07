// <copyright file="ResponseToUsageQuery.cs" company="APIMatic">
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
    /// ResponseToUsageQuery.
    /// </summary>
    public class ResponseToUsageQuery
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
        /// Initializes a new instance of the <see cref="ResponseToUsageQuery"/> class.
        /// </summary>
        public ResponseToUsageQuery()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseToUsageQuery"/> class.
        /// </summary>
        /// <param name="hasmoredata">hasmoredata.</param>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="usageHistory">usageHistory.</param>
        public ResponseToUsageQuery(
            bool? hasmoredata = null,
            Models.ReadySimDeviceId deviceId = null,
            List<Models.UsageHistory> usageHistory = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Hasmoredata = hasmoredata;
            this.DeviceId = deviceId;
            this.UsageHistory = usageHistory;
        }

        /// <summary>
        /// Gets or sets Hasmoredata.
        /// </summary>
        [JsonProperty("hasmoredata", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hasmoredata { get; set; }

        /// <summary>
        /// Gets or sets DeviceId.
        /// </summary>
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReadySimDeviceId DeviceId { get; set; }

        /// <summary>
        /// Gets or sets UsageHistory.
        /// </summary>
        [JsonProperty("usageHistory", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UsageHistory> UsageHistory { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ResponseToUsageQuery : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ResponseToUsageQuery other &&
                (this.Hasmoredata == null && other.Hasmoredata == null ||
                 this.Hasmoredata?.Equals(other.Hasmoredata) == true) &&
                (this.DeviceId == null && other.DeviceId == null ||
                 this.DeviceId?.Equals(other.DeviceId) == true) &&
                (this.UsageHistory == null && other.UsageHistory == null ||
                 this.UsageHistory?.Equals(other.UsageHistory) == true) &&
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
            toStringOutput.Add($"Hasmoredata = {(this.Hasmoredata == null ? "null" : this.Hasmoredata.ToString())}");
            toStringOutput.Add($"DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId.ToString())}");
            toStringOutput.Add($"UsageHistory = {(this.UsageHistory == null ? "null" : $"[{string.Join(", ", this.UsageHistory)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}