// <copyright file="Suspenddetailsobject.cs" company="APIMatic">
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
    /// Suspenddetailsobject.
    /// </summary>
    public class Suspenddetailsobject
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
        /// Initializes a new instance of the <see cref="Suspenddetailsobject"/> class.
        /// </summary>
        public Suspenddetailsobject()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Suspenddetailsobject"/> class.
        /// </summary>
        /// <param name="suspendFromAccounts">suspendFromAccounts.</param>
        /// <param name="suspendDuration">suspendDuration.</param>
        /// <param name="suspendOption">suspendOption.</param>
        /// <param name="threshold">threshold.</param>
        /// <param name="thresholdUnit">thresholdUnit.</param>
        public Suspenddetailsobject(
            List<string> suspendFromAccounts = null,
            int? suspendDuration = null,
            string suspendOption = null,
            int? threshold = null,
            Models.ThresholdUnit? thresholdUnit = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.SuspendFromAccounts = suspendFromAccounts;
            this.SuspendDuration = suspendDuration;
            this.SuspendOption = suspendOption;
            this.Threshold = threshold;
            this.ThresholdUnit = thresholdUnit;
        }

        /// <summary>
        /// Gets or sets SuspendFromAccounts.
        /// </summary>
        [JsonProperty("suspendFromAccounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SuspendFromAccounts { get; set; }

        /// <summary>
        /// Gets or sets SuspendDuration.
        /// </summary>
        [JsonProperty("suspendDuration", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuspendDuration { get; set; }

        /// <summary>
        /// Gets or sets SuspendOption.
        /// </summary>
        [JsonProperty("suspendOption", NullValueHandling = NullValueHandling.Ignore)]
        public string SuspendOption { get; set; }

        /// <summary>
        /// The threshold value the trigger monitors for
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? Threshold { get; set; }

        /// <summary>
        /// The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits
        /// </summary>
        [JsonProperty("thresholdUnit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThresholdUnit? ThresholdUnit { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Suspenddetailsobject : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Suspenddetailsobject other &&
                (this.SuspendFromAccounts == null && other.SuspendFromAccounts == null ||
                 this.SuspendFromAccounts?.Equals(other.SuspendFromAccounts) == true) &&
                (this.SuspendDuration == null && other.SuspendDuration == null ||
                 this.SuspendDuration?.Equals(other.SuspendDuration) == true) &&
                (this.SuspendOption == null && other.SuspendOption == null ||
                 this.SuspendOption?.Equals(other.SuspendOption) == true) &&
                (this.Threshold == null && other.Threshold == null ||
                 this.Threshold?.Equals(other.Threshold) == true) &&
                (this.ThresholdUnit == null && other.ThresholdUnit == null ||
                 this.ThresholdUnit?.Equals(other.ThresholdUnit) == true) &&
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
            toStringOutput.Add($"SuspendFromAccounts = {(this.SuspendFromAccounts == null ? "null" : $"[{string.Join(", ", this.SuspendFromAccounts)} ]")}");
            toStringOutput.Add($"SuspendDuration = {(this.SuspendDuration == null ? "null" : this.SuspendDuration.ToString())}");
            toStringOutput.Add($"SuspendOption = {this.SuspendOption ?? "null"}");
            toStringOutput.Add($"Threshold = {(this.Threshold == null ? "null" : this.Threshold.ToString())}");
            toStringOutput.Add($"ThresholdUnit = {(this.ThresholdUnit == null ? "null" : this.ThresholdUnit.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}