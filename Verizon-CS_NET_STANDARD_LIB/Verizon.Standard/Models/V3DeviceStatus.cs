// <copyright file="V3DeviceStatus.cs" company="APIMatic">
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
    /// V3DeviceStatus.
    /// </summary>
    public class V3DeviceStatus
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
        /// Initializes a new instance of the <see cref="V3DeviceStatus"/> class.
        /// </summary>
        public V3DeviceStatus()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3DeviceStatus"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="status">status.</param>
        /// <param name="resultReason">resultReason.</param>
        /// <param name="updatedTime">updatedTime.</param>
        /// <param name="recentAttemptTime">recentAttemptTime.</param>
        /// <param name="nextAttemptTime">nextAttemptTime.</param>
        public V3DeviceStatus(
            string deviceId,
            string status,
            string resultReason = null,
            DateTime? updatedTime = null,
            DateTime? recentAttemptTime = null,
            DateTime? nextAttemptTime = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.DeviceId = deviceId;
            this.Status = status;
            this.ResultReason = resultReason;
            this.UpdatedTime = updatedTime;
            this.RecentAttemptTime = recentAttemptTime;
            this.NextAttemptTime = nextAttemptTime;
        }

        /// <summary>
        /// Device IMEI.
        /// </summary>
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Success or failure.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Result reason.
        /// </summary>
        [JsonProperty("resultReason", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultReason { get; set; }

        /// <summary>
        /// Updated Time.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updatedTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// The most recent attempt time.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("recentAttemptTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? RecentAttemptTime { get; set; }

        /// <summary>
        /// Next attempt time.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("nextAttemptTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? NextAttemptTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"V3DeviceStatus : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is V3DeviceStatus other &&
                (this.DeviceId == null && other.DeviceId == null ||
                 this.DeviceId?.Equals(other.DeviceId) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.ResultReason == null && other.ResultReason == null ||
                 this.ResultReason?.Equals(other.ResultReason) == true) &&
                (this.UpdatedTime == null && other.UpdatedTime == null ||
                 this.UpdatedTime?.Equals(other.UpdatedTime) == true) &&
                (this.RecentAttemptTime == null && other.RecentAttemptTime == null ||
                 this.RecentAttemptTime?.Equals(other.RecentAttemptTime) == true) &&
                (this.NextAttemptTime == null && other.NextAttemptTime == null ||
                 this.NextAttemptTime?.Equals(other.NextAttemptTime) == true) &&
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
            toStringOutput.Add($"DeviceId = {this.DeviceId ?? "null"}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"ResultReason = {this.ResultReason ?? "null"}");
            toStringOutput.Add($"UpdatedTime = {(this.UpdatedTime == null ? "null" : this.UpdatedTime.ToString())}");
            toStringOutput.Add($"RecentAttemptTime = {(this.RecentAttemptTime == null ? "null" : this.RecentAttemptTime.ToString())}");
            toStringOutput.Add($"NextAttemptTime = {(this.NextAttemptTime == null ? "null" : this.NextAttemptTime.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}