// <copyright file="DeviceGroupUpdateRequest.cs" company="APIMatic">
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
    /// DeviceGroupUpdateRequest.
    /// </summary>
    public class DeviceGroupUpdateRequest
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
        /// Initializes a new instance of the <see cref="DeviceGroupUpdateRequest"/> class.
        /// </summary>
        public DeviceGroupUpdateRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceGroupUpdateRequest"/> class.
        /// </summary>
        /// <param name="devicesToAdd">devicesToAdd.</param>
        /// <param name="devicesToRemove">devicesToRemove.</param>
        /// <param name="newGroupDescription">newGroupDescription.</param>
        /// <param name="newGroupName">newGroupName.</param>
        public DeviceGroupUpdateRequest(
            List<Models.DeviceId> devicesToAdd = null,
            List<Models.DeviceId> devicesToRemove = null,
            string newGroupDescription = null,
            string newGroupName = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.DevicesToAdd = devicesToAdd;
            this.DevicesToRemove = devicesToRemove;
            this.NewGroupDescription = newGroupDescription;
            this.NewGroupName = newGroupName;
        }

        /// <summary>
        /// Zero or more devices to add to the device group, specified by device ID. The devices will be removed from their current device groups. You can use POST /devices/actions/list to get a list of all devices in the account.
        /// </summary>
        [JsonProperty("devicesToAdd", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceId> DevicesToAdd { get; set; }

        /// <summary>
        /// Zero or more devices to remove from the device group, specified by device ID. The devices will be added to the default device group.
        /// </summary>
        [JsonProperty("devicesToRemove", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceId> DevicesToRemove { get; set; }

        /// <summary>
        /// A new description for the device group. Do not include this parameter to leave the group description unchanged.
        /// </summary>
        [JsonProperty("newGroupDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string NewGroupDescription { get; set; }

        /// <summary>
        /// A new name for the device group. Do not include this parameter if you want to leave the group name unchanged.
        /// </summary>
        [JsonProperty("newGroupName", NullValueHandling = NullValueHandling.Ignore)]
        public string NewGroupName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeviceGroupUpdateRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeviceGroupUpdateRequest other &&
                (this.DevicesToAdd == null && other.DevicesToAdd == null ||
                 this.DevicesToAdd?.Equals(other.DevicesToAdd) == true) &&
                (this.DevicesToRemove == null && other.DevicesToRemove == null ||
                 this.DevicesToRemove?.Equals(other.DevicesToRemove) == true) &&
                (this.NewGroupDescription == null && other.NewGroupDescription == null ||
                 this.NewGroupDescription?.Equals(other.NewGroupDescription) == true) &&
                (this.NewGroupName == null && other.NewGroupName == null ||
                 this.NewGroupName?.Equals(other.NewGroupName) == true) &&
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
            toStringOutput.Add($"DevicesToAdd = {(this.DevicesToAdd == null ? "null" : $"[{string.Join(", ", this.DevicesToAdd)} ]")}");
            toStringOutput.Add($"DevicesToRemove = {(this.DevicesToRemove == null ? "null" : $"[{string.Join(", ", this.DevicesToRemove)} ]")}");
            toStringOutput.Add($"NewGroupDescription = {this.NewGroupDescription ?? "null"}");
            toStringOutput.Add($"NewGroupName = {this.NewGroupName ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}