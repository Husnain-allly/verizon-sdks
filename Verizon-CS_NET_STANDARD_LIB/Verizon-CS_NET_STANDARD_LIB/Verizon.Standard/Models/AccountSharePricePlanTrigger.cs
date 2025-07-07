// <copyright file="AccountSharePricePlanTrigger.cs" company="APIMatic">
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
using Verizon.Standard.Models.Containers;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
{
    /// <summary>
    /// AccountSharePricePlanTrigger.
    /// </summary>
    public class AccountSharePricePlanTrigger
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
        /// Initializes a new instance of the <see cref="AccountSharePricePlanTrigger"/> class.
        /// </summary>
        public AccountSharePricePlanTrigger()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountSharePricePlanTrigger"/> class.
        /// </summary>
        /// <param name="accountShare">accountShare.</param>
        /// <param name="condition">condition.</param>
        /// <param name="changePlan">changePlan.</param>
        /// <param name="changePlanDetails">changePlanDetails.</param>
        public AccountSharePricePlanTrigger(
            Models.AccountShareFilterCriteria accountShare = null,
            AccountSharePricePlanTriggerCondition condition = null,
            bool? changePlan = null,
            Models.ChangePlanDetails changePlanDetails = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountShare = accountShare;
            this.Condition = condition;
            this.ChangePlan = changePlan;
            this.ChangePlanDetails = changePlanDetails;
        }

        /// <summary>
        /// Gets or sets AccountShare.
        /// </summary>
        [JsonProperty("accountShare", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountShareFilterCriteria AccountShare { get; set; }

        /// <summary>
        /// Gets or sets Condition.
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public AccountSharePricePlanTriggerCondition Condition { get; set; }

        /// <summary>
        /// a flag to set if the trigger changes service plans, true, or not, false
        /// </summary>
        [JsonProperty("changePlan", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChangePlan { get; set; }

        /// <summary>
        /// The service plan code to switch to
        /// </summary>
        [JsonProperty("changePlanDetails", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChangePlanDetails ChangePlanDetails { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AccountSharePricePlanTrigger : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AccountSharePricePlanTrigger other &&
                (this.AccountShare == null && other.AccountShare == null ||
                 this.AccountShare?.Equals(other.AccountShare) == true) &&
                (this.Condition == null && other.Condition == null ||
                 this.Condition?.Equals(other.Condition) == true) &&
                (this.ChangePlan == null && other.ChangePlan == null ||
                 this.ChangePlan?.Equals(other.ChangePlan) == true) &&
                (this.ChangePlanDetails == null && other.ChangePlanDetails == null ||
                 this.ChangePlanDetails?.Equals(other.ChangePlanDetails) == true) &&
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
            toStringOutput.Add($"AccountShare = {(this.AccountShare == null ? "null" : this.AccountShare.ToString())}");
            toStringOutput.Add($"Condition = {(this.Condition == null ? "null" : this.Condition.ToString())}");
            toStringOutput.Add($"ChangePlan = {(this.ChangePlan == null ? "null" : this.ChangePlan.ToString())}");
            toStringOutput.Add($"ChangePlanDetails = {(this.ChangePlanDetails == null ? "null" : this.ChangePlanDetails.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}