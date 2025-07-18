// <copyright file="DeviceUpgradeHistory.cs" company="APIMatic">
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
    /// DeviceUpgradeHistory.
    /// </summary>
    public class DeviceUpgradeHistory
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
        /// Initializes a new instance of the <see cref="DeviceUpgradeHistory"/> class.
        /// </summary>
        public DeviceUpgradeHistory()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceUpgradeHistory"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="id">id.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="firmwareFrom">firmwareFrom.</param>
        /// <param name="firmwareTo">firmwareTo.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="upgradeStartTime">upgradeStartTime.</param>
        /// <param name="status">status.</param>
        /// <param name="reason">reason.</param>
        public DeviceUpgradeHistory(
            string deviceId = null,
            string id = null,
            string accountName = null,
            string firmwareFrom = null,
            string firmwareTo = null,
            string startDate = null,
            string upgradeStartTime = null,
            string status = null,
            string reason = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.DeviceId = deviceId;
            this.Id = id;
            this.AccountName = accountName;
            this.FirmwareFrom = firmwareFrom;
            this.FirmwareTo = firmwareTo;
            this.StartDate = startDate;
            this.UpgradeStartTime = upgradeStartTime;
            this.Status = status;
            this.Reason = reason;
        }

        /// <summary>
        /// Device IMEI.
        /// </summary>
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// The unique identifier for the upgrade.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The name (number) of the billing account that the device belongs to.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The firmware version that was on the device before the upgrade.
        /// </summary>
        [JsonProperty("firmwareFrom", NullValueHandling = NullValueHandling.Ignore)]
        public string FirmwareFrom { get; set; }

        /// <summary>
        /// The name of the firmware version that was on the device after the upgrade.
        /// </summary>
        [JsonProperty("firmwareTo", NullValueHandling = NullValueHandling.Ignore)]
        public string FirmwareTo { get; set; }

        /// <summary>
        /// The date of the upgrade.
        /// </summary>
        [JsonProperty("startDate", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// The date and time that the upgrade actually started for this device.
        /// </summary>
        [JsonProperty("upgradeStartTime", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeStartTime { get; set; }

        /// <summary>
        /// The status of the upgrade for this device.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// More information about the status.
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeviceUpgradeHistory : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeviceUpgradeHistory other &&
                (this.DeviceId == null && other.DeviceId == null ||
                 this.DeviceId?.Equals(other.DeviceId) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.FirmwareFrom == null && other.FirmwareFrom == null ||
                 this.FirmwareFrom?.Equals(other.FirmwareFrom) == true) &&
                (this.FirmwareTo == null && other.FirmwareTo == null ||
                 this.FirmwareTo?.Equals(other.FirmwareTo) == true) &&
                (this.StartDate == null && other.StartDate == null ||
                 this.StartDate?.Equals(other.StartDate) == true) &&
                (this.UpgradeStartTime == null && other.UpgradeStartTime == null ||
                 this.UpgradeStartTime?.Equals(other.UpgradeStartTime) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Reason == null && other.Reason == null ||
                 this.Reason?.Equals(other.Reason) == true) &&
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
            toStringOutput.Add($"DeviceId = {this.DeviceId ?? "null"}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"FirmwareFrom = {this.FirmwareFrom ?? "null"}");
            toStringOutput.Add($"FirmwareTo = {this.FirmwareTo ?? "null"}");
            toStringOutput.Add($"StartDate = {this.StartDate ?? "null"}");
            toStringOutput.Add($"UpgradeStartTime = {this.UpgradeStartTime ?? "null"}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"Reason = {this.Reason ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}