// <copyright file="KpiInfo.cs" company="APIMatic">
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
    /// KpiInfo.
    /// </summary>
    public class KpiInfo
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
        /// Initializes a new instance of the <see cref="KpiInfo"/> class.
        /// </summary>
        public KpiInfo()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KpiInfo"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="mValue">value.</param>
        /// <param name="nodeName">nodeName.</param>
        /// <param name="nodeType">nodeType.</param>
        /// <param name="description">description.</param>
        /// <param name="unit">unit.</param>
        /// <param name="category">category.</param>
        /// <param name="timeOfLastUpdate">timeOfLastUpdate.</param>
        public KpiInfo(
            string name = null,
            string mValue = null,
            string nodeName = null,
            string nodeType = null,
            string description = null,
            string unit = null,
            string category = null,
            string timeOfLastUpdate = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Name = name;
            this.MValue = mValue;
            this.NodeName = nodeName;
            this.NodeType = nodeType;
            this.Description = description;
            this.Unit = unit;
            this.Category = category;
            this.TimeOfLastUpdate = timeOfLastUpdate;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string MValue { get; set; }

        /// <summary>
        /// Gets or sets NodeName.
        /// </summary>
        [JsonProperty("nodeName", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeName { get; set; }

        /// <summary>
        /// Gets or sets NodeType.
        /// </summary>
        [JsonProperty("nodeType", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeType { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Unit.
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets Category.
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets TimeOfLastUpdate.
        /// </summary>
        [JsonProperty("timeOfLastUpdate", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeOfLastUpdate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"KpiInfo : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is KpiInfo other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.MValue == null && other.MValue == null ||
                 this.MValue?.Equals(other.MValue) == true) &&
                (this.NodeName == null && other.NodeName == null ||
                 this.NodeName?.Equals(other.NodeName) == true) &&
                (this.NodeType == null && other.NodeType == null ||
                 this.NodeType?.Equals(other.NodeType) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Unit == null && other.Unit == null ||
                 this.Unit?.Equals(other.Unit) == true) &&
                (this.Category == null && other.Category == null ||
                 this.Category?.Equals(other.Category) == true) &&
                (this.TimeOfLastUpdate == null && other.TimeOfLastUpdate == null ||
                 this.TimeOfLastUpdate?.Equals(other.TimeOfLastUpdate) == true) &&
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
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"MValue = {this.MValue ?? "null"}");
            toStringOutput.Add($"NodeName = {this.NodeName ?? "null"}");
            toStringOutput.Add($"NodeType = {this.NodeType ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Unit = {this.Unit ?? "null"}");
            toStringOutput.Add($"Category = {this.Category ?? "null"}");
            toStringOutput.Add($"TimeOfLastUpdate = {this.TimeOfLastUpdate ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}