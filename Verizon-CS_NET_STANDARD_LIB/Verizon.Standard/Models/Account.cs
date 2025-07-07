// <copyright file="Account.cs" company="APIMatic">
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
    /// Account.
    /// </summary>
    public class Account
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
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        public Account()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="organizationName">organizationName.</param>
        /// <param name="isProvisioningAllowed">isProvisioningAllowed.</param>
        /// <param name="carriers">carriers.</param>
        /// <param name="features">features.</param>
        /// <param name="ipPools">iPPools.</param>
        /// <param name="servicePlans">servicePlans.</param>
        public Account(
            string accountName = null,
            string accountNumber = null,
            string organizationName = null,
            bool? isProvisioningAllowed = null,
            List<string> carriers = null,
            List<string> features = null,
            List<Models.IpPool> ipPools = null,
            List<Models.ServicePlan> servicePlans = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountName = accountName;
            this.AccountNumber = accountNumber;
            this.OrganizationName = organizationName;
            this.IsProvisioningAllowed = isProvisioningAllowed;
            this.Carriers = carriers;
            this.Features = features;
            this.IpPools = ipPools;
            this.ServicePlans = servicePlans;
        }

        /// <summary>
        /// The name of the account.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The billing number of the account.
        /// </summary>
        [JsonProperty("accountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The name of the organization that the account is part of.
        /// </summary>
        [JsonProperty("organizationName", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// True if devices can be added to the account and activated with a single request. False if devices must be added to the account before they can be activated.
        /// </summary>
        [JsonProperty("isProvisioningAllowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsProvisioningAllowed { get; set; }

        /// <summary>
        /// The names of all carriers for the account.
        /// </summary>
        [JsonProperty("carriers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Carriers { get; set; }

        /// <summary>
        /// The names of features that are enabled for the account.
        /// </summary>
        [JsonProperty("features", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Features { get; set; }

        /// <summary>
        /// Array of IP pools that are available to the account.
        /// </summary>
        [JsonProperty("iPPools", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.IpPool> IpPools { get; set; }

        /// <summary>
        /// Array of service plans that are available to the account.
        /// </summary>
        [JsonProperty("servicePlans", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ServicePlan> ServicePlans { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Account : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Account other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.OrganizationName == null && other.OrganizationName == null ||
                 this.OrganizationName?.Equals(other.OrganizationName) == true) &&
                (this.IsProvisioningAllowed == null && other.IsProvisioningAllowed == null ||
                 this.IsProvisioningAllowed?.Equals(other.IsProvisioningAllowed) == true) &&
                (this.Carriers == null && other.Carriers == null ||
                 this.Carriers?.Equals(other.Carriers) == true) &&
                (this.Features == null && other.Features == null ||
                 this.Features?.Equals(other.Features) == true) &&
                (this.IpPools == null && other.IpPools == null ||
                 this.IpPools?.Equals(other.IpPools) == true) &&
                (this.ServicePlans == null && other.ServicePlans == null ||
                 this.ServicePlans?.Equals(other.ServicePlans) == true) &&
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
            toStringOutput.Add($"AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"OrganizationName = {this.OrganizationName ?? "null"}");
            toStringOutput.Add($"IsProvisioningAllowed = {(this.IsProvisioningAllowed == null ? "null" : this.IsProvisioningAllowed.ToString())}");
            toStringOutput.Add($"Carriers = {(this.Carriers == null ? "null" : $"[{string.Join(", ", this.Carriers)} ]")}");
            toStringOutput.Add($"Features = {(this.Features == null ? "null" : $"[{string.Join(", ", this.Features)} ]")}");
            toStringOutput.Add($"IpPools = {(this.IpPools == null ? "null" : $"[{string.Join(", ", this.IpPools)} ]")}");
            toStringOutput.Add($"ServicePlans = {(this.ServicePlans == null ? "null" : $"[{string.Join(", ", this.ServicePlans)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}