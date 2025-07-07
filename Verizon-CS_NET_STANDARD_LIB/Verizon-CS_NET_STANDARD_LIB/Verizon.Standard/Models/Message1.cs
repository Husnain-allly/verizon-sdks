// <copyright file="Message1.cs" company="APIMatic">
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
    /// Message1.
    /// </summary>
    public class Message1
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
        /// Initializes a new instance of the <see cref="Message1"/> class.
        /// </summary>
        public Message1()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message1"/> class.
        /// </summary>
        /// <param name="isPrivate">isPrivate.</param>
        /// <param name="roadUserType">roadUserType.</param>
        /// <param name="triggerConditions">triggerConditions.</param>
        /// <param name="saeAlert">saeAlert.</param>
        /// <param name="limits">limits.</param>
        /// <param name="distributionType">distributionType.</param>
        /// <param name="distributionSchedule">distributionSchedule.</param>
        public Message1(
            bool isPrivate,
            List<Models.RoadUserTypes> roadUserType,
            List<Models.TriggerCondition> triggerConditions,
            Models.SaeAlert saeAlert,
            List<Limits> limits = null,
            List<Models.DistributionTypes> distributionType = null,
            Models.DistributionSchedule distributionSchedule = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.IsPrivate = isPrivate;
            this.RoadUserType = roadUserType;
            this.TriggerConditions = triggerConditions;
            this.Limits = limits;
            this.DistributionType = distributionType;
            this.DistributionSchedule = distributionSchedule;
            this.SaeAlert = saeAlert;
        }

        /// <summary>
        /// Defines whether the message is private or public.
        /// Private messages are published under the Vendor ID defined in the configuration and only visible to devices of selected vendors.
        /// Public messages are published under the Public vendor and are visible to all the users.
        /// </summary>
        [JsonProperty("isPrivate")]
        [JsonRequired]
        public bool IsPrivate { get; set; }

        /// <summary>
        /// Type of the Road User.
        /// </summary>
        [JsonProperty("roadUserType")]
        [JsonRequired]
        public List<Models.RoadUserTypes> RoadUserType { get; set; }

        /// <summary>
        /// Trigger conditions that define on which road user action the message will be sent. If multiple Trigger Conditions are defined any of them will trigger the message.
        /// </summary>
        [JsonProperty("triggerConditions")]
        [JsonRequired]
        public List<Models.TriggerCondition> TriggerConditions { get; set; }

        /// <summary>
        /// List of limitations. These limitations can be used for making the trigger condition more precise by defining speed and motion direction requirements to be met before the messages are sent out.
        /// </summary>
        [JsonProperty("limits", NullValueHandling = NullValueHandling.Ignore)]
        public List<Limits> Limits { get; set; }

        /// <summary>
        /// Type of the distribution.
        /// </summary>
        [JsonProperty("distributionType", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DistributionTypes> DistributionType { get; set; }

        /// <summary>
        /// The distribution schedule parameters for broadcast messages.
        /// </summary>
        [JsonProperty("distributionSchedule", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DistributionSchedule DistributionSchedule { get; set; }

        /// <summary>
        /// Gets or sets SaeAlert.
        /// </summary>
        [JsonProperty("saeAlert")]
        [JsonRequired]
        public Models.SaeAlert SaeAlert { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Message1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Message1 other &&
                (this.IsPrivate.Equals(other.IsPrivate)) &&
                (this.RoadUserType == null && other.RoadUserType == null ||
                 this.RoadUserType?.Equals(other.RoadUserType) == true) &&
                (this.TriggerConditions == null && other.TriggerConditions == null ||
                 this.TriggerConditions?.Equals(other.TriggerConditions) == true) &&
                (this.Limits == null && other.Limits == null ||
                 this.Limits?.Equals(other.Limits) == true) &&
                (this.DistributionType == null && other.DistributionType == null ||
                 this.DistributionType?.Equals(other.DistributionType) == true) &&
                (this.DistributionSchedule == null && other.DistributionSchedule == null ||
                 this.DistributionSchedule?.Equals(other.DistributionSchedule) == true) &&
                (this.SaeAlert == null && other.SaeAlert == null ||
                 this.SaeAlert?.Equals(other.SaeAlert) == true) &&
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
            toStringOutput.Add($"IsPrivate = {this.IsPrivate}");
            toStringOutput.Add($"RoadUserType = {(this.RoadUserType == null ? "null" : $"[{string.Join(", ", this.RoadUserType)} ]")}");
            toStringOutput.Add($"TriggerConditions = {(this.TriggerConditions == null ? "null" : $"[{string.Join(", ", this.TriggerConditions)} ]")}");
            toStringOutput.Add($"Limits = {(this.Limits == null ? "null" : this.Limits.ToString())}");
            toStringOutput.Add($"DistributionType = {(this.DistributionType == null ? "null" : $"[{string.Join(", ", this.DistributionType)} ]")}");
            toStringOutput.Add($"DistributionSchedule = {(this.DistributionSchedule == null ? "null" : this.DistributionSchedule.ToString())}");
            toStringOutput.Add($"SaeAlert = {(this.SaeAlert == null ? "null" : this.SaeAlert.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}