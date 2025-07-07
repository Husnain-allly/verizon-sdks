// <copyright file="DataTrigger2.cs" company="APIMatic">
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
    /// DataTrigger2.
    /// </summary>
    public class DataTrigger2
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
        /// Initializes a new instance of the <see cref="DataTrigger2"/> class.
        /// </summary>
        public DataTrigger2()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataTrigger2"/> class.
        /// </summary>
        /// <param name="deviceGroup">deviceGroup.</param>
        /// <param name="conditionType">conditionType.</param>
        /// <param name="comparitor">comparitor.</param>
        /// <param name="threshold">threshold.</param>
        /// <param name="thresholdUnit">thresholdUnit.</param>
        /// <param name="cycleType">cycleType.</param>
        /// <param name="allowanceThreshold">allowanceThreshold.</param>
        /// <param name="action">action.</param>
        public DataTrigger2(
            Models.DeviceGroupFilterCriteria deviceGroup = null,
            Models.ConditionType? conditionType = null,
            Models.Comparitor? comparitor = null,
            int? threshold = null,
            Models.ThresholdUnit? thresholdUnit = null,
            Models.RulesCycleType? cycleType = null,
            Models.AllowanceThreshold allowanceThreshold = null,
            Models.Actionobject action = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.DeviceGroup = deviceGroup;
            this.ConditionType = conditionType;
            this.Comparitor = comparitor;
            this.Threshold = threshold;
            this.ThresholdUnit = thresholdUnit;
            this.CycleType = cycleType;
            this.AllowanceThreshold = allowanceThreshold;
            this.Action = action;
        }

        /// <summary>
        /// Gets or sets DeviceGroup.
        /// </summary>
        [JsonProperty("deviceGroup", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeviceGroupFilterCriteria DeviceGroup { get; set; }

        /// <summary>
        /// The condition type being monitored
        /// </summary>
        [JsonProperty("conditionType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ConditionType? ConditionType { get; set; }

        /// <summary>
        /// The boolean of the comparison. `gt` is Greater Than, `lt` is Less Than and `eq` is Equal To
        /// </summary>
        [JsonProperty("comparitor", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Comparitor? Comparitor { get; set; }

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

        /// <summary>
        /// The interval to monitor for the threshold. This can be Daily, Weekly or Monthly
        /// </summary>
        [JsonProperty("cycleType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RulesCycleType? CycleType { get; set; }

        /// <summary>
        /// Gets or sets AllowanceThreshold.
        /// </summary>
        [JsonProperty("allowanceThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AllowanceThreshold AllowanceThreshold { get; set; }

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
            return $"DataTrigger2 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DataTrigger2 other &&
                (this.DeviceGroup == null && other.DeviceGroup == null ||
                 this.DeviceGroup?.Equals(other.DeviceGroup) == true) &&
                (this.ConditionType == null && other.ConditionType == null ||
                 this.ConditionType?.Equals(other.ConditionType) == true) &&
                (this.Comparitor == null && other.Comparitor == null ||
                 this.Comparitor?.Equals(other.Comparitor) == true) &&
                (this.Threshold == null && other.Threshold == null ||
                 this.Threshold?.Equals(other.Threshold) == true) &&
                (this.ThresholdUnit == null && other.ThresholdUnit == null ||
                 this.ThresholdUnit?.Equals(other.ThresholdUnit) == true) &&
                (this.CycleType == null && other.CycleType == null ||
                 this.CycleType?.Equals(other.CycleType) == true) &&
                (this.AllowanceThreshold == null && other.AllowanceThreshold == null ||
                 this.AllowanceThreshold?.Equals(other.AllowanceThreshold) == true) &&
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
            toStringOutput.Add($"DeviceGroup = {(this.DeviceGroup == null ? "null" : this.DeviceGroup.ToString())}");
            toStringOutput.Add($"ConditionType = {(this.ConditionType == null ? "null" : this.ConditionType.ToString())}");
            toStringOutput.Add($"Comparitor = {(this.Comparitor == null ? "null" : this.Comparitor.ToString())}");
            toStringOutput.Add($"Threshold = {(this.Threshold == null ? "null" : this.Threshold.ToString())}");
            toStringOutput.Add($"ThresholdUnit = {(this.ThresholdUnit == null ? "null" : this.ThresholdUnit.ToString())}");
            toStringOutput.Add($"CycleType = {(this.CycleType == null ? "null" : this.CycleType.ToString())}");
            toStringOutput.Add($"AllowanceThreshold = {(this.AllowanceThreshold == null ? "null" : this.AllowanceThreshold.ToString())}");
            toStringOutput.Add($"Action = {(this.Action == null ? "null" : this.Action.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}