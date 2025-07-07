// <copyright file="PeriodicReporting.cs" company="APIMatic">
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
    /// PeriodicReporting.
    /// </summary>
    public class PeriodicReporting
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
        /// Initializes a new instance of the <see cref="PeriodicReporting"/> class.
        /// </summary>
        public PeriodicReporting()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeriodicReporting"/> class.
        /// </summary>
        /// <param name="unit">unit.</param>
        /// <param name="hours">hours.</param>
        /// <param name="minutes">minutes.</param>
        public PeriodicReporting(
            Models.Unit? unit = null,
            int? hours = null,
            int? minutes = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Unit = unit;
            this.Hours = hours;
            this.Minutes = minutes;
        }

        /// <summary>
        /// Gets or sets Unit.
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Unit? Unit { get; set; }

        /// <summary>
        /// whole numbers from 0 to 24
        /// </summary>
        [JsonProperty("hours", NullValueHandling = NullValueHandling.Ignore)]
        public int? Hours { get; set; }

        /// <summary>
        /// whole numbers from 0 to 59
        /// </summary>
        [JsonProperty("minutes", NullValueHandling = NullValueHandling.Ignore)]
        public int? Minutes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PeriodicReporting : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PeriodicReporting other &&
                (this.Unit == null && other.Unit == null ||
                 this.Unit?.Equals(other.Unit) == true) &&
                (this.Hours == null && other.Hours == null ||
                 this.Hours?.Equals(other.Hours) == true) &&
                (this.Minutes == null && other.Minutes == null ||
                 this.Minutes?.Equals(other.Minutes) == true) &&
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
            toStringOutput.Add($"Unit = {(this.Unit == null ? "null" : this.Unit.ToString())}");
            toStringOutput.Add($"Hours = {(this.Hours == null ? "null" : this.Hours.ToString())}");
            toStringOutput.Add($"Minutes = {(this.Minutes == null ? "null" : this.Minutes.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}