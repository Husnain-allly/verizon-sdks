// <copyright file="DeviceFirmwareVersion.cs" company="APIMatic">
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
    /// DeviceFirmwareVersion.
    /// </summary>
    public class DeviceFirmwareVersion
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
        /// Initializes a new instance of the <see cref="DeviceFirmwareVersion"/> class.
        /// </summary>
        public DeviceFirmwareVersion()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceFirmwareVersion"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="firmwareVersion">firmwareVersion.</param>
        /// <param name="status">status.</param>
        /// <param name="reason">reason.</param>
        /// <param name="firmwareVersionUpdateTime">firmwareVersionUpdateTime.</param>
        public DeviceFirmwareVersion(
            string deviceId,
            string firmwareVersion,
            string status = null,
            string reason = null,
            DateTime? firmwareVersionUpdateTime = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Status = status;
            this.Reason = reason;
            this.DeviceId = deviceId;
            this.FirmwareVersion = firmwareVersion;
            this.FirmwareVersionUpdateTime = firmwareVersionUpdateTime;
        }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Reason.
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// Device IMEI.
        /// </summary>
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Device Firmware Version.
        /// </summary>
        [JsonProperty("firmwareVersion")]
        public string FirmwareVersion { get; set; }

        /// <summary>
        /// Gets or sets FirmwareVersionUpdateTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("firmwareVersionUpdateTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FirmwareVersionUpdateTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeviceFirmwareVersion : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeviceFirmwareVersion other &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Reason == null && other.Reason == null ||
                 this.Reason?.Equals(other.Reason) == true) &&
                (this.DeviceId == null && other.DeviceId == null ||
                 this.DeviceId?.Equals(other.DeviceId) == true) &&
                (this.FirmwareVersion == null && other.FirmwareVersion == null ||
                 this.FirmwareVersion?.Equals(other.FirmwareVersion) == true) &&
                (this.FirmwareVersionUpdateTime == null && other.FirmwareVersionUpdateTime == null ||
                 this.FirmwareVersionUpdateTime?.Equals(other.FirmwareVersionUpdateTime) == true) &&
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
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"Reason = {this.Reason ?? "null"}");
            toStringOutput.Add($"DeviceId = {this.DeviceId ?? "null"}");
            toStringOutput.Add($"FirmwareVersion = {this.FirmwareVersion ?? "null"}");
            toStringOutput.Add($"FirmwareVersionUpdateTime = {(this.FirmwareVersionUpdateTime == null ? "null" : this.FirmwareVersionUpdateTime.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}