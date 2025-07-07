// <copyright file="FotaV3Subscription.cs" company="APIMatic">
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
    /// FotaV3Subscription.
    /// </summary>
    public class FotaV3Subscription
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
        /// Initializes a new instance of the <see cref="FotaV3Subscription"/> class.
        /// </summary>
        public FotaV3Subscription()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FotaV3Subscription"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="purchaseType">purchaseType.</param>
        /// <param name="licenseCount">licenseCount.</param>
        /// <param name="licenseUsedCount">licenseUsedCount.</param>
        /// <param name="updateTime">updateTime.</param>
        public FotaV3Subscription(
            string accountName = null,
            string purchaseType = null,
            int? licenseCount = null,
            int? licenseUsedCount = null,
            string updateTime = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountName = accountName;
            this.PurchaseType = purchaseType;
            this.LicenseCount = licenseCount;
            this.LicenseUsedCount = licenseUsedCount;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// Account identifier in "##########-#####".
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Subscription models used by the account.
        /// </summary>
        [JsonProperty("purchaseType", NullValueHandling = NullValueHandling.Ignore)]
        public string PurchaseType { get; set; }

        /// <summary>
        /// Number of monthly licenses in an MRC subscription.
        /// </summary>
        [JsonProperty("licenseCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? LicenseCount { get; set; }

        /// <summary>
        /// Number of licenses currently assigned to devices.
        /// </summary>
        [JsonProperty("licenseUsedCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? LicenseUsedCount { get; set; }

        /// <summary>
        /// The date and time of when the subscription was last updated.
        /// </summary>
        [JsonProperty("updateTime", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FotaV3Subscription : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FotaV3Subscription other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.PurchaseType == null && other.PurchaseType == null ||
                 this.PurchaseType?.Equals(other.PurchaseType) == true) &&
                (this.LicenseCount == null && other.LicenseCount == null ||
                 this.LicenseCount?.Equals(other.LicenseCount) == true) &&
                (this.LicenseUsedCount == null && other.LicenseUsedCount == null ||
                 this.LicenseUsedCount?.Equals(other.LicenseUsedCount) == true) &&
                (this.UpdateTime == null && other.UpdateTime == null ||
                 this.UpdateTime?.Equals(other.UpdateTime) == true) &&
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
            toStringOutput.Add($"PurchaseType = {this.PurchaseType ?? "null"}");
            toStringOutput.Add($"LicenseCount = {(this.LicenseCount == null ? "null" : this.LicenseCount.ToString())}");
            toStringOutput.Add($"LicenseUsedCount = {(this.LicenseUsedCount == null ? "null" : this.LicenseUsedCount.ToString())}");
            toStringOutput.Add($"UpdateTime = {this.UpdateTime ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}