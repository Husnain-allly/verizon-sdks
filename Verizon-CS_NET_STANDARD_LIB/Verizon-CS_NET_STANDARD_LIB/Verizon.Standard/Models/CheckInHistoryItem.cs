// <copyright file="CheckInHistoryItem.cs" company="APIMatic">
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
    /// CheckInHistoryItem.
    /// </summary>
    public class CheckInHistoryItem
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
        /// Initializes a new instance of the <see cref="CheckInHistoryItem"/> class.
        /// </summary>
        public CheckInHistoryItem()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckInHistoryItem"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="clientType">clientType.</param>
        /// <param name="result">result.</param>
        /// <param name="failureType">failureType.</param>
        /// <param name="timeCompleted">timeCompleted.</param>
        public CheckInHistoryItem(
            string deviceId,
            string clientType,
            string result,
            string failureType,
            DateTime timeCompleted)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.DeviceId = deviceId;
            this.ClientType = clientType;
            this.Result = result;
            this.FailureType = failureType;
            this.TimeCompleted = timeCompleted;
        }

        /// <summary>
        /// Device IMEI.
        /// </summary>
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Type of client.
        /// </summary>
        [JsonProperty("clientType")]
        public string ClientType { get; set; }

        /// <summary>
        /// Gets or sets Result.
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }

        /// <summary>
        /// Gets or sets FailureType.
        /// </summary>
        [JsonProperty("failureType")]
        public string FailureType { get; set; }

        /// <summary>
        /// Gets or sets TimeCompleted.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("timeCompleted")]
        public DateTime TimeCompleted { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CheckInHistoryItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CheckInHistoryItem other &&
                (this.DeviceId == null && other.DeviceId == null ||
                 this.DeviceId?.Equals(other.DeviceId) == true) &&
                (this.ClientType == null && other.ClientType == null ||
                 this.ClientType?.Equals(other.ClientType) == true) &&
                (this.Result == null && other.Result == null ||
                 this.Result?.Equals(other.Result) == true) &&
                (this.FailureType == null && other.FailureType == null ||
                 this.FailureType?.Equals(other.FailureType) == true) &&
                (this.TimeCompleted.Equals(other.TimeCompleted)) &&
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
            toStringOutput.Add($"ClientType = {this.ClientType ?? "null"}");
            toStringOutput.Add($"Result = {this.Result ?? "null"}");
            toStringOutput.Add($"FailureType = {this.FailureType ?? "null"}");
            toStringOutput.Add($"TimeCompleted = {this.TimeCompleted}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}