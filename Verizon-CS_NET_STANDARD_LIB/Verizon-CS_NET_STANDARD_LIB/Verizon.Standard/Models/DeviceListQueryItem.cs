// <copyright file="DeviceListQueryItem.cs" company="APIMatic">
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
    /// DeviceListQueryItem.
    /// </summary>
    public class DeviceListQueryItem
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
        /// Initializes a new instance of the <see cref="DeviceListQueryItem"/> class.
        /// </summary>
        public DeviceListQueryItem()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceListQueryItem"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="mdn">mdn.</param>
        /// <param name="model">model.</param>
        /// <param name="make">make.</param>
        /// <param name="firmware">firmware.</param>
        /// <param name="fotaEligible">fotaEligible.</param>
        /// <param name="licenseAssigned">licenseAssigned.</param>
        /// <param name="upgradeTime">upgradeTime.</param>
        public DeviceListQueryItem(
            string deviceId = null,
            string mdn = null,
            string model = null,
            string make = null,
            string firmware = null,
            bool? fotaEligible = null,
            bool? licenseAssigned = null,
            string upgradeTime = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.DeviceId = deviceId;
            this.Mdn = mdn;
            this.Model = model;
            this.Make = make;
            this.Firmware = firmware;
            this.FotaEligible = fotaEligible;
            this.LicenseAssigned = licenseAssigned;
            this.UpgradeTime = upgradeTime;
        }

        /// <summary>
        /// Device IMEI.
        /// </summary>
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// The MDN (phone number) of the device.
        /// </summary>
        [JsonProperty("mdn", NullValueHandling = NullValueHandling.Ignore)]
        public string Mdn { get; set; }

        /// <summary>
        /// The device model name.
        /// </summary>
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        /// <summary>
        /// The device make.
        /// </summary>
        [JsonProperty("make", NullValueHandling = NullValueHandling.Ignore)]
        public string Make { get; set; }

        /// <summary>
        /// The name of the firmware image currently installed on the device.
        /// </summary>
        [JsonProperty("firmware", NullValueHandling = NullValueHandling.Ignore)]
        public string Firmware { get; set; }

        /// <summary>
        /// True if the device firmware can be upgraded over the air using the Software Management Services API.
        /// </summary>
        [JsonProperty("fotaEligible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FotaEligible { get; set; }

        /// <summary>
        /// True if an MRC license has been assigned to this device.
        /// </summary>
        [JsonProperty("licenseAssigned", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LicenseAssigned { get; set; }

        /// <summary>
        /// The date and time that the device firmware was last upgraded. If a device has never been upgraded, the upgradeTime will be 01/01/1900 0:0:0.
        /// </summary>
        [JsonProperty("upgradeTime", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeviceListQueryItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeviceListQueryItem other &&
                (this.DeviceId == null && other.DeviceId == null ||
                 this.DeviceId?.Equals(other.DeviceId) == true) &&
                (this.Mdn == null && other.Mdn == null ||
                 this.Mdn?.Equals(other.Mdn) == true) &&
                (this.Model == null && other.Model == null ||
                 this.Model?.Equals(other.Model) == true) &&
                (this.Make == null && other.Make == null ||
                 this.Make?.Equals(other.Make) == true) &&
                (this.Firmware == null && other.Firmware == null ||
                 this.Firmware?.Equals(other.Firmware) == true) &&
                (this.FotaEligible == null && other.FotaEligible == null ||
                 this.FotaEligible?.Equals(other.FotaEligible) == true) &&
                (this.LicenseAssigned == null && other.LicenseAssigned == null ||
                 this.LicenseAssigned?.Equals(other.LicenseAssigned) == true) &&
                (this.UpgradeTime == null && other.UpgradeTime == null ||
                 this.UpgradeTime?.Equals(other.UpgradeTime) == true) &&
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
            toStringOutput.Add($"Mdn = {this.Mdn ?? "null"}");
            toStringOutput.Add($"Model = {this.Model ?? "null"}");
            toStringOutput.Add($"Make = {this.Make ?? "null"}");
            toStringOutput.Add($"Firmware = {this.Firmware ?? "null"}");
            toStringOutput.Add($"FotaEligible = {(this.FotaEligible == null ? "null" : this.FotaEligible.ToString())}");
            toStringOutput.Add($"LicenseAssigned = {(this.LicenseAssigned == null ? "null" : this.LicenseAssigned.ToString())}");
            toStringOutput.Add($"UpgradeTime = {this.UpgradeTime ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}