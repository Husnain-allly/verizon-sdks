// <copyright file="DeviceAggregateUsageListRequest.cs" company="APIMatic">
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
    /// DeviceAggregateUsageListRequest.
    /// </summary>
    public class DeviceAggregateUsageListRequest
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
        /// Initializes a new instance of the <see cref="DeviceAggregateUsageListRequest"/> class.
        /// </summary>
        public DeviceAggregateUsageListRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceAggregateUsageListRequest"/> class.
        /// </summary>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="deviceIds">deviceIds.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="label">label.</param>
        public DeviceAggregateUsageListRequest(
            string startTime,
            string endTime,
            List<Models.DeviceId> deviceIds = null,
            string accountName = null,
            string groupName = null,
            List<Models.Label> label = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.DeviceIds = deviceIds;
            this.AccountName = accountName;
            this.GroupName = groupName;
            this.Label = label;
        }

        /// <summary>
        /// The beginning of the reporting period. The startTime cannot be more than 6 months before the current date.
        /// </summary>
        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// The end of the reporting period. The endTime date must be within on month of the startTime date.
        /// </summary>
        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// One or more devices for which you want aggregate data, specified by device ID.
        /// </summary>
        [JsonProperty("deviceIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceId> DeviceIds { get; set; }

        /// <summary>
        /// The name of a billing account.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The name of a device group, if you want to only include devices in that group.
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or sets Label.
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Label> Label { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeviceAggregateUsageListRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeviceAggregateUsageListRequest other &&
                (this.StartTime == null && other.StartTime == null ||
                 this.StartTime?.Equals(other.StartTime) == true) &&
                (this.EndTime == null && other.EndTime == null ||
                 this.EndTime?.Equals(other.EndTime) == true) &&
                (this.DeviceIds == null && other.DeviceIds == null ||
                 this.DeviceIds?.Equals(other.DeviceIds) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.GroupName == null && other.GroupName == null ||
                 this.GroupName?.Equals(other.GroupName) == true) &&
                (this.Label == null && other.Label == null ||
                 this.Label?.Equals(other.Label) == true) &&
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
            toStringOutput.Add($"StartTime = {this.StartTime ?? "null"}");
            toStringOutput.Add($"EndTime = {this.EndTime ?? "null"}");
            toStringOutput.Add($"DeviceIds = {(this.DeviceIds == null ? "null" : $"[{string.Join(", ", this.DeviceIds)} ]")}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"GroupName = {this.GroupName ?? "null"}");
            toStringOutput.Add($"Label = {(this.Label == null ? "null" : $"[{string.Join(", ", this.Label)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}