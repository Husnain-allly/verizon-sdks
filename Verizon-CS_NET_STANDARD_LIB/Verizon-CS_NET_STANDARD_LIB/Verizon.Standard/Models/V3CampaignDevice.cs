// <copyright file="V3CampaignDevice.cs" company="APIMatic">
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
    /// V3CampaignDevice.
    /// </summary>
    public class V3CampaignDevice
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
        /// Initializes a new instance of the <see cref="V3CampaignDevice"/> class.
        /// </summary>
        public V3CampaignDevice()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3CampaignDevice"/> class.
        /// </summary>
        /// <param name="hasMoreData">hasMoreData.</param>
        /// <param name="maxPageSize">maxPageSize.</param>
        /// <param name="deviceList">deviceList.</param>
        /// <param name="totalDevice">totalDevice.</param>
        /// <param name="lastSeenDeviceId">lastSeenDeviceId.</param>
        public V3CampaignDevice(
            bool hasMoreData,
            int maxPageSize,
            List<Models.V3DeviceStatus> deviceList,
            int? totalDevice = null,
            string lastSeenDeviceId = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.TotalDevice = totalDevice;
            this.HasMoreData = hasMoreData;
            this.LastSeenDeviceId = lastSeenDeviceId;
            this.MaxPageSize = maxPageSize;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// Total device count.
        /// </summary>
        [JsonProperty("totalDevice", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalDevice { get; set; }

        /// <summary>
        /// Has more report flag.
        /// </summary>
        [JsonProperty("hasMoreData")]
        public bool HasMoreData { get; set; }

        /// <summary>
        /// Device identifier.
        /// </summary>
        [JsonProperty("lastSeenDeviceId", NullValueHandling = NullValueHandling.Ignore)]
        public string LastSeenDeviceId { get; set; }

        /// <summary>
        /// Maximum page size.
        /// </summary>
        [JsonProperty("maxPageSize")]
        public int MaxPageSize { get; set; }

        /// <summary>
        /// List of devices with id in IMEI.
        /// </summary>
        [JsonProperty("deviceList")]
        public List<Models.V3DeviceStatus> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"V3CampaignDevice : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is V3CampaignDevice other &&
                (this.TotalDevice == null && other.TotalDevice == null ||
                 this.TotalDevice?.Equals(other.TotalDevice) == true) &&
                (this.HasMoreData.Equals(other.HasMoreData)) &&
                (this.LastSeenDeviceId == null && other.LastSeenDeviceId == null ||
                 this.LastSeenDeviceId?.Equals(other.LastSeenDeviceId) == true) &&
                (this.MaxPageSize.Equals(other.MaxPageSize)) &&
                (this.DeviceList == null && other.DeviceList == null ||
                 this.DeviceList?.Equals(other.DeviceList) == true) &&
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
            toStringOutput.Add($"TotalDevice = {(this.TotalDevice == null ? "null" : this.TotalDevice.ToString())}");
            toStringOutput.Add($"HasMoreData = {this.HasMoreData}");
            toStringOutput.Add($"LastSeenDeviceId = {this.LastSeenDeviceId ?? "null"}");
            toStringOutput.Add($"MaxPageSize = {this.MaxPageSize}");
            toStringOutput.Add($"DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}