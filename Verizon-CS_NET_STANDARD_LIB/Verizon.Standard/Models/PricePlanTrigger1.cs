// <copyright file="PricePlanTrigger1.cs" company="APIMatic">
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
    /// PricePlanTrigger1.
    /// </summary>
    public class PricePlanTrigger1
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
        /// Initializes a new instance of the <see cref="PricePlanTrigger1"/> class.
        /// </summary>
        public PricePlanTrigger1()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricePlanTrigger1"/> class.
        /// </summary>
        /// <param name="accountGroupShare">accountGroupShare.</param>
        /// <param name="accountShare">accountShare.</param>
        /// <param name="condition">condition.</param>
        /// <param name="changePlan">changePlan.</param>
        /// <param name="changePlanDetails">changePlanDetails.</param>
        /// <param name="payAsYouGo">payAsYouGo.</param>
        /// <param name="action">action.</param>
        /// <param name="standAlone">standAlone.</param>
        public PricePlanTrigger1(
            Models.AccountGroupShareIndividual1 accountGroupShare = null,
            Models.AccountShareFilterCriteria accountShare = null,
            Models.Rateplantype2Condition condition = null,
            bool? changePlan = null,
            Models.ChangePlanDetails changePlanDetails = null,
            Models.PayAsYouGoFilterCriteria payAsYouGo = null,
            Models.Actionobject action = null,
            Models.FiltercriteriaObjectCall standAlone = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountGroupShare = accountGroupShare;
            this.AccountShare = accountShare;
            this.Condition = condition;
            this.ChangePlan = changePlan;
            this.ChangePlanDetails = changePlanDetails;
            this.PayAsYouGo = payAsYouGo;
            this.Action = action;
            this.StandAlone = standAlone;
        }

        /// <summary>
        /// Gets or sets AccountGroupShare.
        /// </summary>
        [JsonProperty("accountGroupShare", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountGroupShareIndividual1 AccountGroupShare { get; set; }

        /// <summary>
        /// Gets or sets AccountShare.
        /// </summary>
        [JsonProperty("accountShare", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountShareFilterCriteria AccountShare { get; set; }

        /// <summary>
        /// Gets or sets Condition.
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Rateplantype2Condition Condition { get; set; }

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

        /// <summary>
        /// Gets or sets PayAsYouGo.
        /// </summary>
        [JsonProperty("payAsYouGo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayAsYouGoFilterCriteria PayAsYouGo { get; set; }

        /// <summary>
        /// Gets or sets Action.
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Actionobject Action { get; set; }

        /// <summary>
        /// Gets or sets StandAlone.
        /// </summary>
        [JsonProperty("standAlone", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FiltercriteriaObjectCall StandAlone { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PricePlanTrigger1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PricePlanTrigger1 other &&
                (this.AccountGroupShare == null && other.AccountGroupShare == null ||
                 this.AccountGroupShare?.Equals(other.AccountGroupShare) == true) &&
                (this.AccountShare == null && other.AccountShare == null ||
                 this.AccountShare?.Equals(other.AccountShare) == true) &&
                (this.Condition == null && other.Condition == null ||
                 this.Condition?.Equals(other.Condition) == true) &&
                (this.ChangePlan == null && other.ChangePlan == null ||
                 this.ChangePlan?.Equals(other.ChangePlan) == true) &&
                (this.ChangePlanDetails == null && other.ChangePlanDetails == null ||
                 this.ChangePlanDetails?.Equals(other.ChangePlanDetails) == true) &&
                (this.PayAsYouGo == null && other.PayAsYouGo == null ||
                 this.PayAsYouGo?.Equals(other.PayAsYouGo) == true) &&
                (this.Action == null && other.Action == null ||
                 this.Action?.Equals(other.Action) == true) &&
                (this.StandAlone == null && other.StandAlone == null ||
                 this.StandAlone?.Equals(other.StandAlone) == true) &&
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
            toStringOutput.Add($"AccountGroupShare = {(this.AccountGroupShare == null ? "null" : this.AccountGroupShare.ToString())}");
            toStringOutput.Add($"AccountShare = {(this.AccountShare == null ? "null" : this.AccountShare.ToString())}");
            toStringOutput.Add($"Condition = {(this.Condition == null ? "null" : this.Condition.ToString())}");
            toStringOutput.Add($"ChangePlan = {(this.ChangePlan == null ? "null" : this.ChangePlan.ToString())}");
            toStringOutput.Add($"ChangePlanDetails = {(this.ChangePlanDetails == null ? "null" : this.ChangePlanDetails.ToString())}");
            toStringOutput.Add($"PayAsYouGo = {(this.PayAsYouGo == null ? "null" : this.PayAsYouGo.ToString())}");
            toStringOutput.Add($"Action = {(this.Action == null ? "null" : this.Action.ToString())}");
            toStringOutput.Add($"StandAlone = {(this.StandAlone == null ? "null" : this.StandAlone.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}