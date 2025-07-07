// <copyright file="ProvisioningHistory.cs" company="APIMatic">
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
    /// ProvisioningHistory.
    /// </summary>
    public class ProvisioningHistory
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
        /// Initializes a new instance of the <see cref="ProvisioningHistory"/> class.
        /// </summary>
        public ProvisioningHistory()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisioningHistory"/> class.
        /// </summary>
        /// <param name="occurredAt">occurredAt.</param>
        /// <param name="status">status.</param>
        /// <param name="eventBy">eventBy.</param>
        /// <param name="eventType">eventType.</param>
        /// <param name="mdn">mdn.</param>
        /// <param name="msisdn">msisdn.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="extendedAttributes">extendedAttributes.</param>
        public ProvisioningHistory(
            string occurredAt = null,
            string status = null,
            string eventBy = null,
            string eventType = null,
            string mdn = null,
            string msisdn = null,
            string servicePlan = null,
            List<Models.CustomFields> extendedAttributes = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.OccurredAt = occurredAt;
            this.Status = status;
            this.EventBy = eventBy;
            this.EventType = eventType;
            this.Mdn = mdn;
            this.Msisdn = msisdn;
            this.ServicePlan = servicePlan;
            this.ExtendedAttributes = extendedAttributes;
        }

        /// <summary>
        /// The date and time when the provisioning event occured.
        /// </summary>
        [JsonProperty("occurredAt", NullValueHandling = NullValueHandling.Ignore)]
        public string OccurredAt { get; set; }

        /// <summary>
        /// The success or failure of the provisioning event.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// The user who performed the provisioning event.
        /// </summary>
        [JsonProperty("eventBy", NullValueHandling = NullValueHandling.Ignore)]
        public string EventBy { get; set; }

        /// <summary>
        /// The provisioning action:Activate,Suspend,Restore,Deactivate,Device Move.
        /// </summary>
        [JsonProperty("eventType", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// The MDN assigned to the device after the provisioning event.
        /// </summary>
        [JsonProperty("mdn", NullValueHandling = NullValueHandling.Ignore)]
        public string Mdn { get; set; }

        /// <summary>
        /// The MSISDN assigned to the device after the provisioning event.
        /// </summary>
        [JsonProperty("msisdn", NullValueHandling = NullValueHandling.Ignore)]
        public string Msisdn { get; set; }

        /// <summary>
        /// The service plan of the device after the provisioning event occurred.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <summary>
        /// Any extended attributes for the event, as Key and Value pairs.
        /// </summary>
        [JsonProperty("extendedAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> ExtendedAttributes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ProvisioningHistory : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ProvisioningHistory other &&
                (this.OccurredAt == null && other.OccurredAt == null ||
                 this.OccurredAt?.Equals(other.OccurredAt) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.EventBy == null && other.EventBy == null ||
                 this.EventBy?.Equals(other.EventBy) == true) &&
                (this.EventType == null && other.EventType == null ||
                 this.EventType?.Equals(other.EventType) == true) &&
                (this.Mdn == null && other.Mdn == null ||
                 this.Mdn?.Equals(other.Mdn) == true) &&
                (this.Msisdn == null && other.Msisdn == null ||
                 this.Msisdn?.Equals(other.Msisdn) == true) &&
                (this.ServicePlan == null && other.ServicePlan == null ||
                 this.ServicePlan?.Equals(other.ServicePlan) == true) &&
                (this.ExtendedAttributes == null && other.ExtendedAttributes == null ||
                 this.ExtendedAttributes?.Equals(other.ExtendedAttributes) == true) &&
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
            toStringOutput.Add($"OccurredAt = {this.OccurredAt ?? "null"}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"EventBy = {this.EventBy ?? "null"}");
            toStringOutput.Add($"EventType = {this.EventType ?? "null"}");
            toStringOutput.Add($"Mdn = {this.Mdn ?? "null"}");
            toStringOutput.Add($"Msisdn = {this.Msisdn ?? "null"}");
            toStringOutput.Add($"ServicePlan = {this.ServicePlan ?? "null"}");
            toStringOutput.Add($"ExtendedAttributes = {(this.ExtendedAttributes == null ? "null" : $"[{string.Join(", ", this.ExtendedAttributes)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}