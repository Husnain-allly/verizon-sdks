// <copyright file="DevicesConsentResult.cs" company="APIMatic">
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
    /// DevicesConsentResult.
    /// </summary>
    public class DevicesConsentResult
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
        /// Initializes a new instance of the <see cref="DevicesConsentResult"/> class.
        /// </summary>
        public DevicesConsentResult()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DevicesConsentResult"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="allDevice">allDevice.</param>
        /// <param name="hasMoreData">hasMoreData.</param>
        /// <param name="totalCount">totalCount.</param>
        /// <param name="updateTime">updateTime.</param>
        /// <param name="exclusion">exclusion.</param>
        public DevicesConsentResult(
            string accountName = null,
            bool? allDevice = null,
            bool? hasMoreData = null,
            int? totalCount = null,
            string updateTime = null,
            List<string> exclusion = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountName = accountName;
            this.AllDevice = allDevice;
            this.HasMoreData = hasMoreData;
            this.TotalCount = totalCount;
            this.UpdateTime = updateTime;
            this.Exclusion = exclusion;
        }

        /// <summary>
        /// Account identifier in "##########-#####".
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Exclude all devices or not?
        /// </summary>
        [JsonProperty("allDevice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllDevice { get; set; }

        /// <summary>
        /// Are there more devices to retrieve or not?
        /// </summary>
        [JsonProperty("hasMoreData", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMoreData { get; set; }

        /// <summary>
        /// Total number of excluded devices in the account.
        /// </summary>
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Last update time.
        /// </summary>
        [JsonProperty("updateTime", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// Device ID list.
        /// </summary>
        [JsonProperty("exclusion", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Exclusion { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DevicesConsentResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DevicesConsentResult other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.AllDevice == null && other.AllDevice == null ||
                 this.AllDevice?.Equals(other.AllDevice) == true) &&
                (this.HasMoreData == null && other.HasMoreData == null ||
                 this.HasMoreData?.Equals(other.HasMoreData) == true) &&
                (this.TotalCount == null && other.TotalCount == null ||
                 this.TotalCount?.Equals(other.TotalCount) == true) &&
                (this.UpdateTime == null && other.UpdateTime == null ||
                 this.UpdateTime?.Equals(other.UpdateTime) == true) &&
                (this.Exclusion == null && other.Exclusion == null ||
                 this.Exclusion?.Equals(other.Exclusion) == true) &&
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
            toStringOutput.Add($"AllDevice = {(this.AllDevice == null ? "null" : this.AllDevice.ToString())}");
            toStringOutput.Add($"HasMoreData = {(this.HasMoreData == null ? "null" : this.HasMoreData.ToString())}");
            toStringOutput.Add($"TotalCount = {(this.TotalCount == null ? "null" : this.TotalCount.ToString())}");
            toStringOutput.Add($"UpdateTime = {this.UpdateTime ?? "null"}");
            toStringOutput.Add($"Exclusion = {(this.Exclusion == null ? "null" : $"[{string.Join(", ", this.Exclusion)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}