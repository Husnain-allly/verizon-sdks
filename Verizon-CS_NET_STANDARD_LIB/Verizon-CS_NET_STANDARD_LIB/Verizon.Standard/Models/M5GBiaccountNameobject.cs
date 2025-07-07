// <copyright file="M5GBiaccountNameobject.cs" company="APIMatic">
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
    /// M5GBiaccountNameobject.
    /// </summary>
    public class M5GBiaccountNameobject
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
        /// Initializes a new instance of the <see cref="M5GBiaccountNameobject"/> class.
        /// </summary>
        public M5GBiaccountNameobject()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="M5GBiaccountNameobject"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="billingCycleEndDate">billingCycleEndDate.</param>
        /// <param name="carrierInformation">carrierInformation.</param>
        /// <param name="connected">connected.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="deviceIds">deviceIds.</param>
        /// <param name="extendedAttributes">extendedAttributes.</param>
        /// <param name="groupNames">groupNames.</param>
        /// <param name="ipaddress">ipAddress.</param>
        /// <param name="lastActivationBy">lastActivationBy.</param>
        /// <param name="lastActivationDate">lastActivationDate.</param>
        public M5GBiaccountNameobject(
            string accountName = null,
            string billingCycleEndDate = null,
            List<Models.M5GBiCarrierInformation> carrierInformation = null,
            bool? connected = null,
            string createdAt = null,
            List<M5GBiaccountNameobjectCustomFields> customFields = null,
            List<M5GBiaccountNameobjectDeviceIds> deviceIds = null,
            List<M5GBiaccountNameobjectExtendedAttributes> extendedAttributes = null,
            List<Models.GroupName> groupNames = null,
            string ipaddress = null,
            string lastActivationBy = null,
            string lastActivationDate = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountName = accountName;
            this.BillingCycleEndDate = billingCycleEndDate;
            this.CarrierInformation = carrierInformation;
            this.Connected = connected;
            this.CreatedAt = createdAt;
            this.CustomFields = customFields;
            this.DeviceIds = deviceIds;
            this.ExtendedAttributes = extendedAttributes;
            this.GroupNames = groupNames;
            this.Ipaddress = ipaddress;
            this.LastActivationBy = lastActivationBy;
            this.LastActivationDate = lastActivationDate;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets BillingCycleEndDate.
        /// </summary>
        [JsonProperty("billingCycleEndDate", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingCycleEndDate { get; set; }

        /// <summary>
        /// Gets or sets CarrierInformation.
        /// </summary>
        [JsonProperty("carrierInformation", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.M5GBiCarrierInformation> CarrierInformation { get; set; }

        /// <summary>
        /// Gets or sets Connected.
        /// </summary>
        [JsonProperty("connected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Connected { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets CustomFields.
        /// </summary>
        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<M5GBiaccountNameobjectCustomFields> CustomFields { get; set; }

        /// <summary>
        /// Gets or sets DeviceIds.
        /// </summary>
        [JsonProperty("deviceIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<M5GBiaccountNameobjectDeviceIds> DeviceIds { get; set; }

        /// <summary>
        /// Gets or sets ExtendedAttributes.
        /// </summary>
        [JsonProperty("extendedAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<M5GBiaccountNameobjectExtendedAttributes> ExtendedAttributes { get; set; }

        /// <summary>
        /// Gets or sets GroupNames.
        /// </summary>
        [JsonProperty("groupNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.GroupName> GroupNames { get; set; }

        /// <summary>
        /// Gets or sets Ipaddress.
        /// </summary>
        [JsonProperty("ipAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipaddress { get; set; }

        /// <summary>
        /// Gets or sets LastActivationBy.
        /// </summary>
        [JsonProperty("lastActivationBy", NullValueHandling = NullValueHandling.Ignore)]
        public string LastActivationBy { get; set; }

        /// <summary>
        /// Gets or sets LastActivationDate.
        /// </summary>
        [JsonProperty("lastActivationDate", NullValueHandling = NullValueHandling.Ignore)]
        public string LastActivationDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"M5GBiaccountNameobject : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is M5GBiaccountNameobject other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.BillingCycleEndDate == null && other.BillingCycleEndDate == null ||
                 this.BillingCycleEndDate?.Equals(other.BillingCycleEndDate) == true) &&
                (this.CarrierInformation == null && other.CarrierInformation == null ||
                 this.CarrierInformation?.Equals(other.CarrierInformation) == true) &&
                (this.Connected == null && other.Connected == null ||
                 this.Connected?.Equals(other.Connected) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.CustomFields == null && other.CustomFields == null ||
                 this.CustomFields?.Equals(other.CustomFields) == true) &&
                (this.DeviceIds == null && other.DeviceIds == null ||
                 this.DeviceIds?.Equals(other.DeviceIds) == true) &&
                (this.ExtendedAttributes == null && other.ExtendedAttributes == null ||
                 this.ExtendedAttributes?.Equals(other.ExtendedAttributes) == true) &&
                (this.GroupNames == null && other.GroupNames == null ||
                 this.GroupNames?.Equals(other.GroupNames) == true) &&
                (this.Ipaddress == null && other.Ipaddress == null ||
                 this.Ipaddress?.Equals(other.Ipaddress) == true) &&
                (this.LastActivationBy == null && other.LastActivationBy == null ||
                 this.LastActivationBy?.Equals(other.LastActivationBy) == true) &&
                (this.LastActivationDate == null && other.LastActivationDate == null ||
                 this.LastActivationDate?.Equals(other.LastActivationDate) == true) &&
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
            toStringOutput.Add($"BillingCycleEndDate = {this.BillingCycleEndDate ?? "null"}");
            toStringOutput.Add($"CarrierInformation = {(this.CarrierInformation == null ? "null" : $"[{string.Join(", ", this.CarrierInformation)} ]")}");
            toStringOutput.Add($"Connected = {(this.Connected == null ? "null" : this.Connected.ToString())}");
            toStringOutput.Add($"CreatedAt = {this.CreatedAt ?? "null"}");
            toStringOutput.Add($"CustomFields = {(this.CustomFields == null ? "null" : this.CustomFields.ToString())}");
            toStringOutput.Add($"DeviceIds = {(this.DeviceIds == null ? "null" : this.DeviceIds.ToString())}");
            toStringOutput.Add($"ExtendedAttributes = {(this.ExtendedAttributes == null ? "null" : this.ExtendedAttributes.ToString())}");
            toStringOutput.Add($"GroupNames = {(this.GroupNames == null ? "null" : $"[{string.Join(", ", this.GroupNames)} ]")}");
            toStringOutput.Add($"Ipaddress = {this.Ipaddress ?? "null"}");
            toStringOutput.Add($"LastActivationBy = {this.LastActivationBy ?? "null"}");
            toStringOutput.Add($"LastActivationDate = {this.LastActivationDate ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}