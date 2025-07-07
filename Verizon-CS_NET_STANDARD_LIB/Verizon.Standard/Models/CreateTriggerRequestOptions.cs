// <copyright file="CreateTriggerRequestOptions.cs" company="APIMatic">
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
    /// CreateTriggerRequestOptions.
    /// </summary>
    public class CreateTriggerRequestOptions
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
        /// Initializes a new instance of the <see cref="CreateTriggerRequestOptions"/> class.
        /// </summary>
        public CreateTriggerRequestOptions()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTriggerRequestOptions"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="triggerCategory">triggerCategory.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="anomalyTriggerRequest">anomalyTriggerRequest.</param>
        /// <param name="notification">notification.</param>
        /// <param name="active">active.</param>
        public CreateTriggerRequestOptions(
            string name = null,
            string triggerCategory = null,
            string accountName = null,
            Models.AnomalyTriggerRequest anomalyTriggerRequest = null,
            Models.TriggerNotification notification = null,
            bool? active = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Name = name;
            this.TriggerCategory = triggerCategory;
            this.AccountName = accountName;
            this.AnomalyTriggerRequest = anomalyTriggerRequest;
            this.Notification = notification;
            this.Active = active;
        }

        /// <summary>
        /// Trigger name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// This is the value to use in the request body to detect anomalous behaivior. The values in this table will only be relevant when this parameter is set to this value.
        /// </summary>
        [JsonProperty("triggerCategory", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerCategory { get; set; }

        /// <summary>
        /// Account name.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The details of the UsageAnomaly trigger.
        /// </summary>
        [JsonProperty("anomalyTriggerRequest", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AnomalyTriggerRequest AnomalyTriggerRequest { get; set; }

        /// <summary>
        /// The notification details of the trigger.
        /// </summary>
        [JsonProperty("notification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TriggerNotification Notification { get; set; }

        /// <summary>
        /// Indicates anomaly detection is active<br />True - Anomaly detection is active.<br />False - Anomaly detection is not active.
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateTriggerRequestOptions : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateTriggerRequestOptions other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.TriggerCategory == null && other.TriggerCategory == null ||
                 this.TriggerCategory?.Equals(other.TriggerCategory) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.AnomalyTriggerRequest == null && other.AnomalyTriggerRequest == null ||
                 this.AnomalyTriggerRequest?.Equals(other.AnomalyTriggerRequest) == true) &&
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
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"TriggerCategory = {this.TriggerCategory ?? "null"}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"AnomalyTriggerRequest = {(this.AnomalyTriggerRequest == null ? "null" : this.AnomalyTriggerRequest.ToString())}");
            toStringOutput.Add($"Notification = {(this.Notification == null ? "null" : this.Notification.ToString())}");
            toStringOutput.Add($"Active = {(this.Active == null ? "null" : this.Active.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}