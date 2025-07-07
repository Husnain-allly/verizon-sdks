// <copyright file="DailyUsage.cs" company="APIMatic">
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
    /// DailyUsage.
    /// </summary>
    public class DailyUsage
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
        /// Initializes a new instance of the <see cref="DailyUsage"/> class.
        /// </summary>
        public DailyUsage()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyUsage"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="earliest">earliest.</param>
        /// <param name="latest">latest.</param>
        public DailyUsage(
            Models.GioDeviceId deviceId = null,
            string earliest = null,
            string latest = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.DeviceId = deviceId;
            this.Earliest = earliest;
            this.Latest = latest;
        }

        /// <summary>
        /// Gets or sets DeviceId.
        /// </summary>
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GioDeviceId DeviceId { get; set; }

        /// <summary>
        /// The start date of the time period queried as "$datetime"
        /// </summary>
        [JsonProperty("earliest", NullValueHandling = NullValueHandling.Ignore)]
        public string Earliest { get; set; }

        /// <summary>
        /// The end date of the time period being queried as "$datetime"
        /// </summary>
        [JsonProperty("latest", NullValueHandling = NullValueHandling.Ignore)]
        public string Latest { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DailyUsage : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DailyUsage other &&
                (this.DeviceId == null && other.DeviceId == null ||
                 this.DeviceId?.Equals(other.DeviceId) == true) &&
                (this.Earliest == null && other.Earliest == null ||
                 this.Earliest?.Equals(other.Earliest) == true) &&
                (this.Latest == null && other.Latest == null ||
                 this.Latest?.Equals(other.Latest) == true) &&
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
            toStringOutput.Add($"DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId.ToString())}");
            toStringOutput.Add($"Earliest = {this.Earliest ?? "null"}");
            toStringOutput.Add($"Latest = {this.Latest ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}