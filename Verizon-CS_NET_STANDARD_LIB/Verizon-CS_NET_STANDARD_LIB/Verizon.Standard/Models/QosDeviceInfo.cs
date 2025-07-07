// <copyright file="QosDeviceInfo.cs" company="APIMatic">
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
    /// QosDeviceInfo.
    /// </summary>
    public class QosDeviceInfo
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
        /// Initializes a new instance of the <see cref="QosDeviceInfo"/> class.
        /// </summary>
        public QosDeviceInfo()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QosDeviceInfo"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="flowInfo">flowInfo.</param>
        /// <param name="deviceIPv6Addr">deviceIPv6Addr.</param>
        public QosDeviceInfo(
            Models.QosDeviceId deviceId,
            List<Models.FlowInfo> flowInfo,
            string deviceIPv6Addr = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.DeviceId = deviceId;
            this.DeviceIPv6Addr = deviceIPv6Addr;
            this.FlowInfo = flowInfo;
        }

        /// <summary>
        /// Gets or sets DeviceId.
        /// </summary>
        [JsonProperty("deviceId")]
        public Models.QosDeviceId DeviceId { get; set; }

        /// <summary>
        /// Gets or sets DeviceIPv6Addr.
        /// </summary>
        [JsonProperty("deviceIPv6Addr", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceIPv6Addr { get; set; }

        /// <summary>
        /// Gets or sets FlowInfo.
        /// </summary>
        [JsonProperty("flowInfo")]
        public List<Models.FlowInfo> FlowInfo { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"QosDeviceInfo : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is QosDeviceInfo other &&
                (this.DeviceId == null && other.DeviceId == null ||
                 this.DeviceId?.Equals(other.DeviceId) == true) &&
                (this.DeviceIPv6Addr == null && other.DeviceIPv6Addr == null ||
                 this.DeviceIPv6Addr?.Equals(other.DeviceIPv6Addr) == true) &&
                (this.FlowInfo == null && other.FlowInfo == null ||
                 this.FlowInfo?.Equals(other.FlowInfo) == true) &&
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
            toStringOutput.Add($"DeviceIPv6Addr = {this.DeviceIPv6Addr ?? "null"}");
            toStringOutput.Add($"FlowInfo = {(this.FlowInfo == null ? "null" : $"[{string.Join(", ", this.FlowInfo)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}