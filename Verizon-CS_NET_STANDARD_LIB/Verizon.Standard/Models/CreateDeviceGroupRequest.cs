// <copyright file="CreateDeviceGroupRequest.cs" company="APIMatic">
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
    /// CreateDeviceGroupRequest.
    /// </summary>
    public class CreateDeviceGroupRequest
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
        /// Initializes a new instance of the <see cref="CreateDeviceGroupRequest"/> class.
        /// </summary>
        public CreateDeviceGroupRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeviceGroupRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="groupDescription">groupDescription.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="devicesToAdd">devicesToAdd.</param>
        public CreateDeviceGroupRequest(
            string accountName,
            string groupDescription,
            string groupName,
            List<Models.DeviceId> devicesToAdd = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountName = accountName;
            this.GroupDescription = groupDescription;
            this.GroupName = groupName;
            this.DevicesToAdd = devicesToAdd;
        }

        /// <summary>
        /// The Verizon billing account that the device group will belong to. An account name is usually numeric, and must include any leading zeros.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// A description for the device group.
        /// </summary>
        [JsonProperty("groupDescription")]
        public string GroupDescription { get; set; }

        /// <summary>
        /// The name for the new device group. This name must be unique within the specified account.
        /// </summary>
        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        /// <summary>
        /// Zero or more devices to add to the device group. You can use POST /devices/actions/list to get a list of all devices in the account.
        /// </summary>
        [JsonProperty("devicesToAdd", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceId> DevicesToAdd { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateDeviceGroupRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateDeviceGroupRequest other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.GroupDescription == null && other.GroupDescription == null ||
                 this.GroupDescription?.Equals(other.GroupDescription) == true) &&
                (this.GroupName == null && other.GroupName == null ||
                 this.GroupName?.Equals(other.GroupName) == true) &&
                (this.DevicesToAdd == null && other.DevicesToAdd == null ||
                 this.DevicesToAdd?.Equals(other.DevicesToAdd) == true) &&
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
            toStringOutput.Add($"GroupDescription = {this.GroupDescription ?? "null"}");
            toStringOutput.Add($"GroupName = {this.GroupName ?? "null"}");
            toStringOutput.Add($"DevicesToAdd = {(this.DevicesToAdd == null ? "null" : $"[{string.Join(", ", this.DevicesToAdd)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}