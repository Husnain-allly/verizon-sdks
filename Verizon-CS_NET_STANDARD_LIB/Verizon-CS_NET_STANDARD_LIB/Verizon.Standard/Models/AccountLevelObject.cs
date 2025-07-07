// <copyright file="AccountLevelObject.cs" company="APIMatic">
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
    /// AccountLevelObject.
    /// </summary>
    public class AccountLevelObject
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
        /// Initializes a new instance of the <see cref="AccountLevelObject"/> class.
        /// </summary>
        public AccountLevelObject()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLevelObject"/> class.
        /// </summary>
        /// <param name="filterCriteria">filterCriteria.</param>
        /// <param name="condition">condition.</param>
        /// <param name="action">action.</param>
        public AccountLevelObject(
            Models.AccountLevelFilter filterCriteria = null,
            AccountLevelObjectCondition condition = null,
            Models.AccountLevelAction? action = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.FilterCriteria = filterCriteria;
            this.Condition = condition;
            this.Action = action;
        }

        /// <summary>
        /// Gets or sets FilterCriteria.
        /// </summary>
        [JsonProperty("filterCriteria", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountLevelFilter FilterCriteria { get; set; }

        /// <summary>
        /// Gets or sets Condition.
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public AccountLevelObjectCondition Condition { get; set; }

        /// <summary>
        /// The action taken when trigger conditions are met
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountLevelAction? Action { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AccountLevelObject : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AccountLevelObject other &&
                (this.FilterCriteria == null && other.FilterCriteria == null ||
                 this.FilterCriteria?.Equals(other.FilterCriteria) == true) &&
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
            toStringOutput.Add($"FilterCriteria = {(this.FilterCriteria == null ? "null" : this.FilterCriteria.ToString())}");
            toStringOutput.Add($"Condition = {(this.Condition == null ? "null" : this.Condition.ToString())}");
            toStringOutput.Add($"Action = {(this.Action == null ? "null" : this.Action.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}