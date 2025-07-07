// <copyright file="AccountDeviceListRequest.cs" company="APIMatic">
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
    /// AccountDeviceListRequest.
    /// </summary>
    public class AccountDeviceListRequest
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
        /// Initializes a new instance of the <see cref="AccountDeviceListRequest"/> class.
        /// </summary>
        public AccountDeviceListRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDeviceListRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="filter">filter.</param>
        /// <param name="currentState">currentState.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="earliest">earliest.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="latest">latest.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="maxNumberOfDevices">maxNumberOfDevices.</param>
        /// <param name="largestDeviceIdSeen">largestDeviceIdSeen.</param>
        public AccountDeviceListRequest(
            string accountName = null,
            Models.DeviceId deviceId = null,
            Models.AccountDeviceListFilter filter = null,
            string currentState = null,
            List<Models.CustomFields> customFields = null,
            string earliest = null,
            string groupName = null,
            string latest = null,
            string servicePlan = null,
            int? maxNumberOfDevices = null,
            long? largestDeviceIdSeen = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountName = accountName;
            this.DeviceId = deviceId;
            this.Filter = filter;
            this.CurrentState = currentState;
            this.CustomFields = customFields;
            this.Earliest = earliest;
            this.GroupName = groupName;
            this.Latest = latest;
            this.ServicePlan = servicePlan;
            this.MaxNumberOfDevices = maxNumberOfDevices;
            this.LargestDeviceIdSeen = largestDeviceIdSeen;
        }

        /// <summary>
        /// The billing account for which a list of devices is returned. If you don't specify an accountName, the list includes all devices to which you have access.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// An identifier for a single device.
        /// </summary>
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeviceId DeviceId { get; set; }

        /// <summary>
        /// Filter for a list of devices.
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountDeviceListFilter Filter { get; set; }

        /// <summary>
        /// The name of a device state, to only include devices in that state.
        /// </summary>
        [JsonProperty("currentState", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentState { get; set; }

        /// <summary>
        /// Custom field names and values, if you want to only include devices that have matching values.
        /// </summary>
        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> CustomFields { get; set; }

        /// <summary>
        /// Only include devices that were added after this date and time.
        /// </summary>
        [JsonProperty("earliest", NullValueHandling = NullValueHandling.Ignore)]
        public string Earliest { get; set; }

        /// <summary>
        /// Only include devices that are in this device group.
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// Only include devices that were added before this date and time.
        /// </summary>
        [JsonProperty("latest", NullValueHandling = NullValueHandling.Ignore)]
        public string Latest { get; set; }

        /// <summary>
        /// Only include devices that have this service plan.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <summary>
        /// Gets or sets MaxNumberOfDevices.
        /// </summary>
        [JsonProperty("maxNumberOfDevices", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxNumberOfDevices { get; set; }

        /// <summary>
        /// Gets or sets LargestDeviceIdSeen.
        /// </summary>
        [JsonProperty("largestDeviceIdSeen", NullValueHandling = NullValueHandling.Ignore)]
        public long? LargestDeviceIdSeen { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AccountDeviceListRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AccountDeviceListRequest other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.DeviceId == null && other.DeviceId == null ||
                 this.DeviceId?.Equals(other.DeviceId) == true) &&
                (this.Filter == null && other.Filter == null ||
                 this.Filter?.Equals(other.Filter) == true) &&
                (this.CurrentState == null && other.CurrentState == null ||
                 this.CurrentState?.Equals(other.CurrentState) == true) &&
                (this.CustomFields == null && other.CustomFields == null ||
                 this.CustomFields?.Equals(other.CustomFields) == true) &&
                (this.Earliest == null && other.Earliest == null ||
                 this.Earliest?.Equals(other.Earliest) == true) &&
                (this.GroupName == null && other.GroupName == null ||
                 this.GroupName?.Equals(other.GroupName) == true) &&
                (this.Latest == null && other.Latest == null ||
                 this.Latest?.Equals(other.Latest) == true) &&
                (this.ServicePlan == null && other.ServicePlan == null ||
                 this.ServicePlan?.Equals(other.ServicePlan) == true) &&
                (this.MaxNumberOfDevices == null && other.MaxNumberOfDevices == null ||
                 this.MaxNumberOfDevices?.Equals(other.MaxNumberOfDevices) == true) &&
                (this.LargestDeviceIdSeen == null && other.LargestDeviceIdSeen == null ||
                 this.LargestDeviceIdSeen?.Equals(other.LargestDeviceIdSeen) == true) &&
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
            toStringOutput.Add($"DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId.ToString())}");
            toStringOutput.Add($"Filter = {(this.Filter == null ? "null" : this.Filter.ToString())}");
            toStringOutput.Add($"CurrentState = {this.CurrentState ?? "null"}");
            toStringOutput.Add($"CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"Earliest = {this.Earliest ?? "null"}");
            toStringOutput.Add($"GroupName = {this.GroupName ?? "null"}");
            toStringOutput.Add($"Latest = {this.Latest ?? "null"}");
            toStringOutput.Add($"ServicePlan = {this.ServicePlan ?? "null"}");
            toStringOutput.Add($"MaxNumberOfDevices = {(this.MaxNumberOfDevices == null ? "null" : this.MaxNumberOfDevices.ToString())}");
            toStringOutput.Add($"LargestDeviceIdSeen = {(this.LargestDeviceIdSeen == null ? "null" : this.LargestDeviceIdSeen.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}