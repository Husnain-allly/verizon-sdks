// <copyright file="NotificationReportRequest.cs" company="APIMatic">
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
    /// NotificationReportRequest.
    /// </summary>
    public class NotificationReportRequest
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
        /// Initializes a new instance of the <see cref="NotificationReportRequest"/> class.
        /// </summary>
        public NotificationReportRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationReportRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="requestType">requestType.</param>
        /// <param name="devices">devices.</param>
        /// <param name="monitorExpirationTime">monitorExpirationTime.</param>
        public NotificationReportRequest(
            string accountName,
            string requestType,
            List<Models.DeviceList> devices,
            string monitorExpirationTime)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountName = accountName;
            this.RequestType = requestType;
            this.Devices = devices;
            this.MonitorExpirationTime = monitorExpirationTime;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets RequestType.
        /// </summary>
        [JsonProperty("requestType")]
        public string RequestType { get; set; }

        /// <summary>
        /// Gets or sets Devices.
        /// </summary>
        [JsonProperty("devices")]
        public List<Models.DeviceList> Devices { get; set; }

        /// <summary>
        /// Gets or sets MonitorExpirationTime.
        /// </summary>
        [JsonProperty("monitorExpirationTime")]
        public string MonitorExpirationTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NotificationReportRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NotificationReportRequest other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.RequestType == null && other.RequestType == null ||
                 this.RequestType?.Equals(other.RequestType) == true) &&
                (this.Devices == null && other.Devices == null ||
                 this.Devices?.Equals(other.Devices) == true) &&
                (this.MonitorExpirationTime == null && other.MonitorExpirationTime == null ||
                 this.MonitorExpirationTime?.Equals(other.MonitorExpirationTime) == true) &&
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
            toStringOutput.Add($"RequestType = {this.RequestType ?? "null"}");
            toStringOutput.Add($"Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"MonitorExpirationTime = {this.MonitorExpirationTime ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}