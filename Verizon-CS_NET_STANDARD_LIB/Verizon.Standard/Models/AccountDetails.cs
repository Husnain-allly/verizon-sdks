// <copyright file="AccountDetails.cs" company="APIMatic">
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
    /// AccountDetails.
    /// </summary>
    public class AccountDetails
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
        /// Initializes a new instance of the <see cref="AccountDetails"/> class.
        /// </summary>
        public AccountDetails()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetails"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="organizationName">organizationName.</param>
        /// <param name="isProvisioningAllowed">isProvisioningAllowed.</param>
        /// <param name="carriers">carriers.</param>
        /// <param name="features">features.</param>
        /// <param name="servicePlans">servicePlans.</param>
        public AccountDetails(
            string accountName = null,
            string accountNumber = null,
            string organizationName = null,
            bool? isProvisioningAllowed = null,
            List<Models.Carrier> carriers = null,
            List<Models.Feature> features = null,
            List<Models.CarrierServicePlan> servicePlans = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountName = accountName;
            this.AccountNumber = accountNumber;
            this.OrganizationName = organizationName;
            this.IsProvisioningAllowed = isProvisioningAllowed;
            this.Carriers = carriers;
            this.Features = features;
            this.ServicePlans = servicePlans;
        }

        /// <summary>
        /// The numeric name of the account, in the format "0000123456-00001". Leading zeros must be included.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The numeric name of the account, in the format "0000123456-00001". Leading zeros must be included.
        /// </summary>
        [JsonProperty("accountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// user defined name of organization
        /// </summary>
        [JsonProperty("organizationName", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Flag set to indicate if account details can be edited or not. Default is "true".
        /// </summary>
        [JsonProperty("isProvisioningAllowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsProvisioningAllowed { get; set; }

        /// <summary>
        /// Gets or sets Carriers.
        /// </summary>
        [JsonProperty("carriers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Carrier> Carriers { get; set; }

        /// <summary>
        /// Gets or sets Features.
        /// </summary>
        [JsonProperty("features", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Feature> Features { get; set; }

        /// <summary>
        /// Gets or sets ServicePlans.
        /// </summary>
        [JsonProperty("servicePlans", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CarrierServicePlan> ServicePlans { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AccountDetails : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AccountDetails other &&
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
            toStringOutput.Add($"ServicePlans = {(this.ServicePlans == null ? "null" : $"[{string.Join(", ", this.ServicePlans)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}