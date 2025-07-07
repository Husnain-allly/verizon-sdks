// <copyright file="DeviceLocationSubscription.cs" company="APIMatic">
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
    /// DeviceLocationSubscription.
    /// </summary>
    public class DeviceLocationSubscription
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
        /// Initializes a new instance of the <see cref="DeviceLocationSubscription"/> class.
        /// </summary>
        public DeviceLocationSubscription()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceLocationSubscription"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="locType">locType.</param>
        /// <param name="maxAllowance">maxAllowance.</param>
        /// <param name="purchaseTime">purchaseTime.</param>
        public DeviceLocationSubscription(
            string accountName = null,
            string locType = null,
            string maxAllowance = null,
            string purchaseTime = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountName = accountName;
            this.LocType = locType;
            this.MaxAllowance = maxAllowance;
            this.PurchaseTime = purchaseTime;
        }

        /// <summary>
        /// Account identifier in "##########-#####".
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Location service license type.
        /// </summary>
        [JsonProperty("locType", NullValueHandling = NullValueHandling.Ignore)]
        public string LocType { get; set; }

        /// <summary>
        /// The number of billable location requests allowed per billing cycle.
        /// </summary>
        [JsonProperty("maxAllowance", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxAllowance { get; set; }

        /// <summary>
        /// Location service purchase time.
        /// </summary>
        [JsonProperty("purchaseTime", NullValueHandling = NullValueHandling.Ignore)]
        public string PurchaseTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeviceLocationSubscription : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeviceLocationSubscription other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.LocType == null && other.LocType == null ||
                 this.LocType?.Equals(other.LocType) == true) &&
                (this.MaxAllowance == null && other.MaxAllowance == null ||
                 this.MaxAllowance?.Equals(other.MaxAllowance) == true) &&
                (this.PurchaseTime == null && other.PurchaseTime == null ||
                 this.PurchaseTime?.Equals(other.PurchaseTime) == true) &&
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
            toStringOutput.Add($"LocType = {this.LocType ?? "null"}");
            toStringOutput.Add($"MaxAllowance = {this.MaxAllowance ?? "null"}");
            toStringOutput.Add($"PurchaseTime = {this.PurchaseTime ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}