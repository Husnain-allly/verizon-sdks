// <copyright file="RateplantypeObject.cs" company="APIMatic">
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
    /// RateplantypeObject.
    /// </summary>
    public class RateplantypeObject
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
        /// Initializes a new instance of the <see cref="RateplantypeObject"/> class.
        /// </summary>
        public RateplantypeObject()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateplantypeObject"/> class.
        /// </summary>
        /// <param name="ratePlanGroupDescription">ratePlanGroupDescription.</param>
        /// <param name="ratePlanType">ratePlanType.</param>
        /// <param name="ratePlan">ratePlan.</param>
        public RateplantypeObject(
            string ratePlanGroupDescription = null,
            string ratePlanType = null,
            List<Models.Rateplantype2> ratePlan = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.RatePlanGroupDescription = ratePlanGroupDescription;
            this.RatePlanType = ratePlanType;
            this.RatePlan = ratePlan;
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
        public string RatePlanType { get; set; }

        /// <summary>
        /// An array of rateplan names
        /// </summary>
        [JsonProperty("ratePlan", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Rateplantype2> RatePlan { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RateplantypeObject : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RateplantypeObject other &&
                (this.RatePlanGroupDescription == null && other.RatePlanGroupDescription == null ||
                 this.RatePlanGroupDescription?.Equals(other.RatePlanGroupDescription) == true) &&
                (this.RatePlanType == null && other.RatePlanType == null ||
                 this.RatePlanType?.Equals(other.RatePlanType) == true) &&
                (this.RatePlan == null && other.RatePlan == null ||
                 this.RatePlan?.Equals(other.RatePlan) == true) &&
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
            toStringOutput.Add($"RatePlanType = {this.RatePlanType ?? "null"}");
            toStringOutput.Add($"RatePlan = {(this.RatePlan == null ? "null" : $"[{string.Join(", ", this.RatePlan)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}