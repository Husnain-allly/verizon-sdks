// <copyright file="RatePlanGroup.cs" company="APIMatic">
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
    /// RatePlanGroup.
    /// </summary>
    public class RatePlanGroup
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
        /// Initializes a new instance of the <see cref="RatePlanGroup"/> class.
        /// </summary>
        public RatePlanGroup()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RatePlanGroup"/> class.
        /// </summary>
        /// <param name="ratePlanGroupDescription">ratePlanGroupDescription.</param>
        /// <param name="ratePlanType">ratePlanType.</param>
        /// <param name="ratePlan">ratePlan.</param>
        /// <param name="description">description.</param>
        /// <param name="sizeKb">sizeKb.</param>
        /// <param name="carrierRatePlanCode">carrierRatePlanCode.</param>
        /// <param name="zeroDollarBilling">zeroDollarBilling.</param>
        /// <param name="promotionOffered">promotionOffered.</param>
        /// <param name="promotionDays">promotionDays.</param>
        /// <param name="account">account.</param>
        public RatePlanGroup(
            string ratePlanGroupDescription = null,
            object ratePlanType = null,
            List<Models.Rateplantype2> ratePlan = null,
            string description = null,
            string sizeKb = null,
            string carrierRatePlanCode = null,
            bool? zeroDollarBilling = null,
            bool? promotionOffered = null,
            int? promotionDays = null,
            List<Models.Accountid> account = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.RatePlanGroupDescription = ratePlanGroupDescription;
            this.RatePlanType = ratePlanType;
            this.RatePlan = ratePlan;
            this.Description = description;
            this.SizeKb = sizeKb;
            this.CarrierRatePlanCode = carrierRatePlanCode;
            this.ZeroDollarBilling = zeroDollarBilling;
            this.PromotionOffered = promotionOffered;
            this.PromotionDays = promotionDays;
            this.Account = account;
        }

        /// <summary>
        /// Gets or sets RatePlanGroupDescription.
        /// </summary>
        [JsonProperty("ratePlanGroupDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string RatePlanGroupDescription { get; set; }

        /// <summary>
        /// Gets or sets RatePlanType.
        /// </summary>
        [JsonProperty("ratePlanType", NullValueHandling = NullValueHandling.Ignore)]
        public object RatePlanType { get; set; }

        /// <summary>
        /// An array of rateplan names
        /// </summary>
        [JsonProperty("ratePlan", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Rateplantype2> RatePlan { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets SizeKb.
        /// </summary>
        [JsonProperty("sizeKb", NullValueHandling = NullValueHandling.Ignore)]
        public string SizeKb { get; set; }

        /// <summary>
        /// Gets or sets CarrierRatePlanCode.
        /// </summary>
        [JsonProperty("carrierRatePlanCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierRatePlanCode { get; set; }

        /// <summary>
        /// Gets or sets ZeroDollarBilling.
        /// </summary>
        [JsonProperty("zeroDollarBilling", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ZeroDollarBilling { get; set; }

        /// <summary>
        /// Gets or sets PromotionOffered.
        /// </summary>
        [JsonProperty("promotionOffered", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PromotionOffered { get; set; }

        /// <summary>
        /// Gets or sets PromotionDays.
        /// </summary>
        [JsonProperty("promotionDays", NullValueHandling = NullValueHandling.Ignore)]
        public int? PromotionDays { get; set; }

        /// <summary>
        /// Account information
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Accountid> Account { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RatePlanGroup : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RatePlanGroup other &&
                (this.RatePlanGroupDescription == null && other.RatePlanGroupDescription == null ||
                 this.RatePlanGroupDescription?.Equals(other.RatePlanGroupDescription) == true) &&
                (this.RatePlanType == null && other.RatePlanType == null ||
                 this.RatePlanType?.Equals(other.RatePlanType) == true) &&
                (this.RatePlan == null && other.RatePlan == null ||
                 this.RatePlan?.Equals(other.RatePlan) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.SizeKb == null && other.SizeKb == null ||
                 this.SizeKb?.Equals(other.SizeKb) == true) &&
                (this.CarrierRatePlanCode == null && other.CarrierRatePlanCode == null ||
                 this.CarrierRatePlanCode?.Equals(other.CarrierRatePlanCode) == true) &&
                (this.ZeroDollarBilling == null && other.ZeroDollarBilling == null ||
                 this.ZeroDollarBilling?.Equals(other.ZeroDollarBilling) == true) &&
                (this.PromotionOffered == null && other.PromotionOffered == null ||
                 this.PromotionOffered?.Equals(other.PromotionOffered) == true) &&
                (this.PromotionDays == null && other.PromotionDays == null ||
                 this.PromotionDays?.Equals(other.PromotionDays) == true) &&
                (this.Account == null && other.Account == null ||
                 this.Account?.Equals(other.Account) == true) &&
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
            toStringOutput.Add($"RatePlanGroupDescription = {this.RatePlanGroupDescription ?? "null"}");
            toStringOutput.Add($"RatePlanType = {(this.RatePlanType == null ? "null" : this.RatePlanType.ToString())}");
            toStringOutput.Add($"RatePlan = {(this.RatePlan == null ? "null" : $"[{string.Join(", ", this.RatePlan)} ]")}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"SizeKb = {this.SizeKb ?? "null"}");
            toStringOutput.Add($"CarrierRatePlanCode = {this.CarrierRatePlanCode ?? "null"}");
            toStringOutput.Add($"ZeroDollarBilling = {(this.ZeroDollarBilling == null ? "null" : this.ZeroDollarBilling.ToString())}");
            toStringOutput.Add($"PromotionOffered = {(this.PromotionOffered == null ? "null" : this.PromotionOffered.ToString())}");
            toStringOutput.Add($"PromotionDays = {(this.PromotionDays == null ? "null" : this.PromotionDays.ToString())}");
            toStringOutput.Add($"Account = {(this.Account == null ? "null" : $"[{string.Join(", ", this.Account)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}