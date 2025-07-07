// <copyright file="AttributeSetting.cs" company="APIMatic">
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
    /// AttributeSetting.
    /// </summary>
    public class AttributeSetting
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
        /// Initializes a new instance of the <see cref="AttributeSetting"/> class.
        /// </summary>
        public AttributeSetting()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeSetting"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="mValue">value.</param>
        /// <param name="createdOn">createdOn.</param>
        /// <param name="isObservable">isObservable.</param>
        /// <param name="isObserving">isObserving.</param>
        /// <param name="frequency">frequency.</param>
        public AttributeSetting(
            Models.AttributeIdentifier? name = null,
            string mValue = null,
            DateTime? createdOn = null,
            bool? isObservable = null,
            bool? isObserving = null,
            Models.NumericalData frequency = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Name = name;
            this.MValue = mValue;
            this.CreatedOn = createdOn;
            this.IsObservable = isObservable;
            this.IsObserving = isObserving;
            this.Frequency = frequency;
        }

        /// <summary>
        /// Attribute identifier.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AttributeIdentifier? Name { get; set; }

        /// <summary>
        /// Attribute value.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string MValue { get; set; }

        /// <summary>
        /// Date and time request was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdOn", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Is the attribute observable?
        /// </summary>
        [JsonProperty("isObservable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsObservable { get; set; }

        /// <summary>
        /// Is the attribute being observed?
        /// </summary>
        [JsonProperty("isObserving", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsObserving { get; set; }

        /// <summary>
        /// Describes value and unit of time.
        /// </summary>
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NumericalData Frequency { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AttributeSetting : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AttributeSetting other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.MValue == null && other.MValue == null ||
                 this.MValue?.Equals(other.MValue) == true) &&
                (this.CreatedOn == null && other.CreatedOn == null ||
                 this.CreatedOn?.Equals(other.CreatedOn) == true) &&
                (this.IsObservable == null && other.IsObservable == null ||
                 this.IsObservable?.Equals(other.IsObservable) == true) &&
                (this.IsObserving == null && other.IsObserving == null ||
                 this.IsObserving?.Equals(other.IsObserving) == true) &&
                (this.Frequency == null && other.Frequency == null ||
                 this.Frequency?.Equals(other.Frequency) == true) &&
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
            toStringOutput.Add($"Name = {(this.Name == null ? "null" : this.Name.ToString())}");
            toStringOutput.Add($"MValue = {this.MValue ?? "null"}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");
            toStringOutput.Add($"IsObservable = {(this.IsObservable == null ? "null" : this.IsObservable.ToString())}");
            toStringOutput.Add($"IsObserving = {(this.IsObserving == null ? "null" : this.IsObserving.ToString())}");
            toStringOutput.Add($"Frequency = {(this.Frequency == null ? "null" : this.Frequency.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}