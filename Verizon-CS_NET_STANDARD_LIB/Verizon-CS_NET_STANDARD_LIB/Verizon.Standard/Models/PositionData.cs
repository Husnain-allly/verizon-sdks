// <copyright file="PositionData.cs" company="APIMatic">
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
    /// PositionData.
    /// </summary>
    public class PositionData
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
        /// Initializes a new instance of the <see cref="PositionData"/> class.
        /// </summary>
        public PositionData()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionData"/> class.
        /// </summary>
        /// <param name="time">time.</param>
        /// <param name="utcoffset">utcoffset.</param>
        /// <param name="x">x.</param>
        /// <param name="y">y.</param>
        /// <param name="radius">radius.</param>
        /// <param name="qos">qos.</param>
        public PositionData(
            string time = null,
            string utcoffset = null,
            string x = null,
            string y = null,
            string radius = null,
            bool? qos = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Time = time;
            this.Utcoffset = utcoffset;
            this.X = x;
            this.Y = y;
            this.Radius = radius;
            this.Qos = qos;
        }

        /// <summary>
        /// Time location obtained.
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// UTC offset of time.
        /// </summary>
        [JsonProperty("utcoffset", NullValueHandling = NullValueHandling.Ignore)]
        public string Utcoffset { get; set; }

        /// <summary>
        /// X coordinate of location.
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public string X { get; set; }

        /// <summary>
        /// Y coordinate of location.
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public string Y { get; set; }

        /// <summary>
        /// Radius of the location in meters.
        /// </summary>
        [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
        public string Radius { get; set; }

        /// <summary>
        /// Whether requested accurary is met or not.
        /// </summary>
        [JsonProperty("qos", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Qos { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PositionData : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PositionData other &&
                (this.Time == null && other.Time == null ||
                 this.Time?.Equals(other.Time) == true) &&
                (this.Utcoffset == null && other.Utcoffset == null ||
                 this.Utcoffset?.Equals(other.Utcoffset) == true) &&
                (this.X == null && other.X == null ||
                 this.X?.Equals(other.X) == true) &&
                (this.Y == null && other.Y == null ||
                 this.Y?.Equals(other.Y) == true) &&
                (this.Radius == null && other.Radius == null ||
                 this.Radius?.Equals(other.Radius) == true) &&
                (this.Qos == null && other.Qos == null ||
                 this.Qos?.Equals(other.Qos) == true) &&
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
            toStringOutput.Add($"Time = {this.Time ?? "null"}");
            toStringOutput.Add($"Utcoffset = {this.Utcoffset ?? "null"}");
            toStringOutput.Add($"X = {this.X ?? "null"}");
            toStringOutput.Add($"Y = {this.Y ?? "null"}");
            toStringOutput.Add($"Radius = {this.Radius ?? "null"}");
            toStringOutput.Add($"Qos = {(this.Qos == null ? "null" : this.Qos.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}