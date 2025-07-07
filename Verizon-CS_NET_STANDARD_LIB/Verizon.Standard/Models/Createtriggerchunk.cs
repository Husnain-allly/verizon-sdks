// <copyright file="Createtriggerchunk.cs" company="APIMatic">
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
    /// Createtriggerchunk.
    /// </summary>
    public class Createtriggerchunk
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
        /// Initializes a new instance of the <see cref="Createtriggerchunk"/> class.
        /// </summary>
        public Createtriggerchunk()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Createtriggerchunk"/> class.
        /// </summary>
        /// <param name="triggerName">triggerName.</param>
        /// <param name="ecpdId">ecpdId.</param>
        /// <param name="triggerCategory">triggerCategory.</param>
        /// <param name="pricePlanTrigger">pricePlanTrigger.</param>
        /// <param name="notification">notification.</param>
        /// <param name="active">active.</param>
        public Createtriggerchunk(
            string triggerName = null,
            string ecpdId = null,
            Models.TriggerCategory? triggerCategory = null,
            Models.PricePlanTrigger pricePlanTrigger = null,
            Models.Notificationarray notification = null,
            Models.Active? active = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.TriggerName = triggerName;
            this.EcpdId = ecpdId;
            this.TriggerCategory = triggerCategory;
            this.PricePlanTrigger = pricePlanTrigger;
            this.Notification = notification;
            this.Active = active;
        }

        /// <summary>
        /// The user defined name of the trigger
        /// </summary>
        [JsonProperty("triggerName", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerName { get; set; }

        /// <summary>
        /// The Enterprise Customer Profile Database ID
        /// </summary>
        [JsonProperty("ecpdId", NullValueHandling = NullValueHandling.Ignore)]
        public string EcpdId { get; set; }

        /// <summary>
        /// The type of trigger being created or modified
        /// </summary>
        [JsonProperty("triggerCategory", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TriggerCategory? TriggerCategory { get; set; }

        /// <summary>
        /// Gets or sets PricePlanTrigger.
        /// </summary>
        [JsonProperty("pricePlanTrigger", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PricePlanTrigger PricePlanTrigger { get; set; }

        /// <summary>
        /// Gets or sets Notification.
        /// </summary>
        [JsonProperty("notification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Notificationarray Notification { get; set; }

        /// <summary>
        /// A flag to indicate of the trigger is active, true, or not, false
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Active? Active { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Createtriggerchunk : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Createtriggerchunk other &&
                (this.TriggerName == null && other.TriggerName == null ||
                 this.TriggerName?.Equals(other.TriggerName) == true) &&
                (this.EcpdId == null && other.EcpdId == null ||
                 this.EcpdId?.Equals(other.EcpdId) == true) &&
                (this.TriggerCategory == null && other.TriggerCategory == null ||
                 this.TriggerCategory?.Equals(other.TriggerCategory) == true) &&
                (this.PricePlanTrigger == null && other.PricePlanTrigger == null ||
                 this.PricePlanTrigger?.Equals(other.PricePlanTrigger) == true) &&
                (this.Notification == null && other.Notification == null ||
                 this.Notification?.Equals(other.Notification) == true) &&
                (this.Active == null && other.Active == null ||
                 this.Active?.Equals(other.Active) == true) &&
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
            toStringOutput.Add($"TriggerName = {this.TriggerName ?? "null"}");
            toStringOutput.Add($"EcpdId = {this.EcpdId ?? "null"}");
            toStringOutput.Add($"TriggerCategory = {(this.TriggerCategory == null ? "null" : this.TriggerCategory.ToString())}");
            toStringOutput.Add($"PricePlanTrigger = {(this.PricePlanTrigger == null ? "null" : this.PricePlanTrigger.ToString())}");
            toStringOutput.Add($"Notification = {(this.Notification == null ? "null" : this.Notification.ToString())}");
            toStringOutput.Add($"Active = {(this.Active == null ? "null" : this.Active.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}