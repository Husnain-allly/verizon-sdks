// <copyright file="PayAsYouGoPricePlanTrigger.cs" company="APIMatic">
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
    /// PayAsYouGoPricePlanTrigger.
    /// </summary>
    public class PayAsYouGoPricePlanTrigger
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
        /// Initializes a new instance of the <see cref="PayAsYouGoPricePlanTrigger"/> class.
        /// </summary>
        public PayAsYouGoPricePlanTrigger()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayAsYouGoPricePlanTrigger"/> class.
        /// </summary>
        /// <param name="payAsYouGo">payAsYouGo.</param>
        /// <param name="condition">condition.</param>
        /// <param name="action">action.</param>
        public PayAsYouGoPricePlanTrigger(
            Models.PayAsYouGoFilterCriteria payAsYouGo = null,
            Models.Rateplantype2Condition condition = null,
            Models.Actionobject action = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.PayAsYouGo = payAsYouGo;
            this.Condition = condition;
            this.Action = action;
        }

        /// <summary>
        /// Gets or sets PayAsYouGo.
        /// </summary>
        [JsonProperty("payAsYouGo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayAsYouGoFilterCriteria PayAsYouGo { get; set; }

        /// <summary>
        /// Gets or sets Condition.
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Rateplantype2Condition Condition { get; set; }

        /// <summary>
        /// Gets or sets Action.
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Actionobject Action { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PayAsYouGoPricePlanTrigger : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PayAsYouGoPricePlanTrigger other &&
                (this.PayAsYouGo == null && other.PayAsYouGo == null ||
                 this.PayAsYouGo?.Equals(other.PayAsYouGo) == true) &&
                (this.Condition == null && other.Condition == null ||
                 this.Condition?.Equals(other.Condition) == true) &&
                (this.Action == null && other.Action == null ||
                 this.Action?.Equals(other.Action) == true) &&
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
            toStringOutput.Add($"PayAsYouGo = {(this.PayAsYouGo == null ? "null" : this.PayAsYouGo.ToString())}");
            toStringOutput.Add($"Condition = {(this.Condition == null ? "null" : this.Condition.ToString())}");
            toStringOutput.Add($"Action = {(this.Action == null ? "null" : this.Action.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}