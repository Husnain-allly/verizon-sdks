// <copyright file="CarrierDeactivateRequest.cs" company="APIMatic">
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
    /// CarrierDeactivateRequest.
    /// </summary>
    public class CarrierDeactivateRequest
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
        /// Initializes a new instance of the <see cref="CarrierDeactivateRequest"/> class.
        /// </summary>
        public CarrierDeactivateRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierDeactivateRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="devices">devices.</param>
        /// <param name="reasonCode">reasonCode.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="etfWaiver">etfWaiver.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="deleteAfterDeactivation">deleteAfterDeactivation.</param>
        public CarrierDeactivateRequest(
            string accountName,
            List<Models.AccountDeviceList> devices,
            string reasonCode,
            List<Models.CustomFields> customFields = null,
            bool? etfWaiver = null,
            string groupName = null,
            string servicePlan = null,
            bool? deleteAfterDeactivation = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountName = accountName;
            this.Devices = devices;
            this.ReasonCode = reasonCode;
            this.CustomFields = customFields;
            this.EtfWaiver = etfWaiver;
            this.GroupName = groupName;
            this.ServicePlan = servicePlan;
            this.DeleteAfterDeactivation = deleteAfterDeactivation;
        }

        /// <summary>
        /// The name of a billing account.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// The devices for which you want to deactivate service, specified by device identifier.
        /// </summary>
        [JsonProperty("devices")]
        public List<Models.AccountDeviceList> Devices { get; set; }

        /// <summary>
        /// Code identifying the reason for the deactivation. Currently the only valid reason code is “FF”, which corresponds to General Admin/Maintenance.
        /// </summary>
        [JsonProperty("reasonCode")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Custom field names and values, if you want to only include devices that have matching values.
        /// </summary>
        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> CustomFields { get; set; }

        /// <summary>
        /// Fees may be assessed for deactivating Verizon Wireless devices, depending on the account contract. The etfWaiver parameter waives the Early Termination Fee (ETF), if applicable.
        /// </summary>
        [JsonProperty("etfWaiver", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EtfWaiver { get; set; }

        /// <summary>
        /// The name of a device group, if you want to deactivate all devices in that group.
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// The name of a service plan, if you want to only include devices that have that service plan.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <summary>
        /// Gets or sets DeleteAfterDeactivation.
        /// </summary>
        [JsonProperty("deleteAfterDeactivation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteAfterDeactivation { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CarrierDeactivateRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CarrierDeactivateRequest other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.Devices == null && other.Devices == null ||
                 this.Devices?.Equals(other.Devices) == true) &&
                (this.ReasonCode == null && other.ReasonCode == null ||
                 this.ReasonCode?.Equals(other.ReasonCode) == true) &&
                (this.CustomFields == null && other.CustomFields == null ||
                 this.CustomFields?.Equals(other.CustomFields) == true) &&
                (this.EtfWaiver == null && other.EtfWaiver == null ||
                 this.EtfWaiver?.Equals(other.EtfWaiver) == true) &&
                (this.GroupName == null && other.GroupName == null ||
                 this.GroupName?.Equals(other.GroupName) == true) &&
                (this.ServicePlan == null && other.ServicePlan == null ||
                 this.ServicePlan?.Equals(other.ServicePlan) == true) &&
                (this.DeleteAfterDeactivation == null && other.DeleteAfterDeactivation == null ||
                 this.DeleteAfterDeactivation?.Equals(other.DeleteAfterDeactivation) == true) &&
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
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"ReasonCode = {this.ReasonCode ?? "null"}");
            toStringOutput.Add($"CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"EtfWaiver = {(this.EtfWaiver == null ? "null" : this.EtfWaiver.ToString())}");
            toStringOutput.Add($"GroupName = {this.GroupName ?? "null"}");
            toStringOutput.Add($"ServicePlan = {this.ServicePlan ?? "null"}");
            toStringOutput.Add($"DeleteAfterDeactivation = {(this.DeleteAfterDeactivation == null ? "null" : this.DeleteAfterDeactivation.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}