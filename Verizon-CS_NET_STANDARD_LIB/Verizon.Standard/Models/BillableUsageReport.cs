// <copyright file="BillableUsageReport.cs" company="APIMatic">
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
    /// BillableUsageReport.
    /// </summary>
    public class BillableUsageReport
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
        /// Initializes a new instance of the <see cref="BillableUsageReport"/> class.
        /// </summary>
        public BillableUsageReport()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillableUsageReport"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="usageForAllAccounts">usageForAllAccounts.</param>
        /// <param name="skuName">skuName.</param>
        /// <param name="transactionsAllowed">transactionsAllowed.</param>
        /// <param name="totalTransactionCount">totalTransactionCount.</param>
        /// <param name="primaryAccount">PrimaryAccount.</param>
        /// <param name="managedAccounts">ManagedAccounts.</param>
        public BillableUsageReport(
            string accountName = null,
            bool? usageForAllAccounts = null,
            string skuName = null,
            string transactionsAllowed = null,
            string totalTransactionCount = null,
            Models.ServiceUsage primaryAccount = null,
            List<Models.ServiceUsage> managedAccounts = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountName = accountName;
            this.UsageForAllAccounts = usageForAllAccounts;
            this.SkuName = skuName;
            this.TransactionsAllowed = transactionsAllowed;
            this.TotalTransactionCount = totalTransactionCount;
            this.PrimaryAccount = primaryAccount;
            this.ManagedAccounts = managedAccounts;
        }

        /// <summary>
        /// Account identifier.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The usage is for a single or multiple accounts.
        /// </summary>
        [JsonProperty("usageForAllAccounts", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsageForAllAccounts { get; set; }

        /// <summary>
        /// SKU Name of the service subscription.
        /// </summary>
        [JsonProperty("skuName", NullValueHandling = NullValueHandling.Ignore)]
        public string SkuName { get; set; }

        /// <summary>
        /// The number of location requests included with the subscription type.
        /// </summary>
        [JsonProperty("transactionsAllowed", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionsAllowed { get; set; }

        /// <summary>
        /// The total number of billable device location requests during the reporting period from all included accounts.
        /// </summary>
        [JsonProperty("totalTransactionCount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalTransactionCount { get; set; }

        /// <summary>
        /// Gets or sets PrimaryAccount.
        /// </summary>
        [JsonProperty("PrimaryAccount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceUsage PrimaryAccount { get; set; }

        /// <summary>
        /// Zero or more managed accounts.
        /// </summary>
        [JsonProperty("ManagedAccounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ServiceUsage> ManagedAccounts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BillableUsageReport : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BillableUsageReport other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.UsageForAllAccounts == null && other.UsageForAllAccounts == null ||
                 this.UsageForAllAccounts?.Equals(other.UsageForAllAccounts) == true) &&
                (this.SkuName == null && other.SkuName == null ||
                 this.SkuName?.Equals(other.SkuName) == true) &&
                (this.TransactionsAllowed == null && other.TransactionsAllowed == null ||
                 this.TransactionsAllowed?.Equals(other.TransactionsAllowed) == true) &&
                (this.TotalTransactionCount == null && other.TotalTransactionCount == null ||
                 this.TotalTransactionCount?.Equals(other.TotalTransactionCount) == true) &&
                (this.PrimaryAccount == null && other.PrimaryAccount == null ||
                 this.PrimaryAccount?.Equals(other.PrimaryAccount) == true) &&
                (this.ManagedAccounts == null && other.ManagedAccounts == null ||
                 this.ManagedAccounts?.Equals(other.ManagedAccounts) == true) &&
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
            toStringOutput.Add($"UsageForAllAccounts = {(this.UsageForAllAccounts == null ? "null" : this.UsageForAllAccounts.ToString())}");
            toStringOutput.Add($"SkuName = {this.SkuName ?? "null"}");
            toStringOutput.Add($"TransactionsAllowed = {this.TransactionsAllowed ?? "null"}");
            toStringOutput.Add($"TotalTransactionCount = {this.TotalTransactionCount ?? "null"}");
            toStringOutput.Add($"PrimaryAccount = {(this.PrimaryAccount == null ? "null" : this.PrimaryAccount.ToString())}");
            toStringOutput.Add($"ManagedAccounts = {(this.ManagedAccounts == null ? "null" : $"[{string.Join(", ", this.ManagedAccounts)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}