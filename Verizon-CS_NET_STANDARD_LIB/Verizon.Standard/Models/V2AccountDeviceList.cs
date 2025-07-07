// <copyright file="V2AccountDeviceList.cs" company="APIMatic">
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
    /// V2AccountDeviceList.
    /// </summary>
    public class V2AccountDeviceList
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
        /// Initializes a new instance of the <see cref="V2AccountDeviceList"/> class.
        /// </summary>
        public V2AccountDeviceList()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2AccountDeviceList"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="hasMoreData">hasMoreData.</param>
        /// <param name="maxPageSize">maxPageSize.</param>
        /// <param name="deviceList">deviceList.</param>
        /// <param name="lastSeenDeviceId">lastSeenDeviceId.</param>
        public V2AccountDeviceList(
            string accountName,
            bool hasMoreData,
            int maxPageSize,
            List<Models.V2AccountDevice> deviceList,
            string lastSeenDeviceId = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountName = accountName;
            this.HasMoreData = hasMoreData;
            this.LastSeenDeviceId = lastSeenDeviceId;
            this.MaxPageSize = maxPageSize;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// Account name.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Has more device flag?
        /// </summary>
        [JsonProperty("hasMoreData")]
        public bool HasMoreData { get; set; }

        /// <summary>
        /// Last seen device identifier.
        /// </summary>
        [JsonProperty("lastSeenDeviceId", NullValueHandling = NullValueHandling.Ignore)]
        public string LastSeenDeviceId { get; set; }

        /// <summary>
        /// Maximum page size.
        /// </summary>
        [JsonProperty("maxPageSize")]
        public int MaxPageSize { get; set; }

        /// <summary>
        /// Account device list.
        /// </summary>
        [JsonProperty("deviceList")]
        public List<Models.V2AccountDevice> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"V2AccountDeviceList : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is V2AccountDeviceList other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
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
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
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