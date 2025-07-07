// <copyright file="V3Device.cs" company="APIMatic">
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
    /// V3Device.
    /// </summary>
    public class V3Device
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
        /// Initializes a new instance of the <see cref="V3Device"/> class.
        /// </summary>
        public V3Device()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3Device"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="requestStatus">requestStatus.</param>
        /// <param name="resultReason">resultReason.</param>
        /// <param name="mdn">mdn.</param>
        /// <param name="model">model.</param>
        /// <param name="make">make.</param>
        /// <param name="firmware">firmware.</param>
        /// <param name="fotaEligible">fotaEligible.</param>
        /// <param name="status">status.</param>
        /// <param name="licenseAssigned">licenseAssigned.</param>
        /// <param name="protocol">protocol.</param>
        /// <param name="softwareList">softwareList.</param>
        /// <param name="fileList">fileList.</param>
        /// <param name="createTime">createTime.</param>
        /// <param name="statusTime">statusTime.</param>
        /// <param name="updateTime">updateTime.</param>
        /// <param name="refreshTime">refreshTime.</param>
        /// <param name="lastConnectionTime">lastConnectionTime.</param>
        public V3Device(
            string deviceId,
            string requestStatus = null,
            string resultReason = null,
            string mdn = null,
            string model = null,
            string make = null,
            string firmware = null,
            bool? fotaEligible = null,
            string status = null,
            bool? licenseAssigned = null,
            string protocol = null,
            List<Models.V3SoftwareInfo> softwareList = null,
            List<Models.V3SoftwareInfo> fileList = null,
            string createTime = null,
            string statusTime = null,
            string updateTime = null,
            string refreshTime = null,
            DateTime? lastConnectionTime = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.DeviceId = deviceId;
            this.RequestStatus = requestStatus;
            this.ResultReason = resultReason;
            this.Mdn = mdn;
            this.Model = model;
            this.Make = make;
            this.Firmware = firmware;
            this.FotaEligible = fotaEligible;
            this.Status = status;
            this.LicenseAssigned = licenseAssigned;
            this.Protocol = protocol;
            this.SoftwareList = softwareList;
            this.FileList = fileList;
            this.CreateTime = createTime;
            this.StatusTime = statusTime;
            this.UpdateTime = updateTime;
            this.RefreshTime = refreshTime;
            this.LastConnectionTime = lastConnectionTime;
        }

        /// <summary>
        /// Device IMEI.
        /// </summary>
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Success or failure.
        /// </summary>
        [JsonProperty("requestStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestStatus { get; set; }

        /// <summary>
        /// Gets or sets ResultReason.
        /// </summary>
        [JsonProperty("resultReason", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultReason { get; set; }

        /// <summary>
        /// MDN.
        /// </summary>
        [JsonProperty("mdn", NullValueHandling = NullValueHandling.Ignore)]
        public string Mdn { get; set; }

        /// <summary>
        /// Device model.
        /// </summary>
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        /// <summary>
        /// Device make.
        /// </summary>
        [JsonProperty("make", NullValueHandling = NullValueHandling.Ignore)]
        public string Make { get; set; }

        /// <summary>
        /// Device firmware version.
        /// </summary>
        [JsonProperty("firmware", NullValueHandling = NullValueHandling.Ignore)]
        public string Firmware { get; set; }

        /// <summary>
        /// Value=true if the device software can be upgraded over the air using the Software Management Services API.
        /// </summary>
        [JsonProperty("fotaEligible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FotaEligible { get; set; }

        /// <summary>
        /// Device status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// License assigned device.
        /// </summary>
        [JsonProperty("licenseAssigned", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LicenseAssigned { get; set; }

        /// <summary>
        /// Firmware protocol. Valid values include: LWM2M, OMADM, HTTP or NONE.
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// List of sofware.
        /// </summary>
        [JsonProperty("softwareList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.V3SoftwareInfo> SoftwareList { get; set; }

        /// <summary>
        /// List of files.
        /// </summary>
        [JsonProperty("fileList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.V3SoftwareInfo> FileList { get; set; }

        /// <summary>
        /// The date and time of when the device is created.
        /// </summary>
        [JsonProperty("createTime", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The date and time of when the device firmware or software is updated.
        /// </summary>
        [JsonProperty("statusTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusTime { get; set; }

        /// <summary>
        /// The date and time of when the device is updated.
        /// </summary>
        [JsonProperty("updateTime", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// The date and time of when the device is refreshed.
        /// </summary>
        [JsonProperty("refreshTime", NullValueHandling = NullValueHandling.Ignore)]
        public string RefreshTime { get; set; }

        /// <summary>
        /// The date and time of when the device reachability is checked.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastConnectionTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastConnectionTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"V3Device : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is V3Device other &&
                (this.DeviceId == null && other.DeviceId == null ||
                 this.DeviceId?.Equals(other.DeviceId) == true) &&
                (this.RequestStatus == null && other.RequestStatus == null ||
                 this.RequestStatus?.Equals(other.RequestStatus) == true) &&
                (this.ResultReason == null && other.ResultReason == null ||
                 this.ResultReason?.Equals(other.ResultReason) == true) &&
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
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.LicenseAssigned == null && other.LicenseAssigned == null ||
                 this.LicenseAssigned?.Equals(other.LicenseAssigned) == true) &&
                (this.Protocol == null && other.Protocol == null ||
                 this.Protocol?.Equals(other.Protocol) == true) &&
                (this.SoftwareList == null && other.SoftwareList == null ||
                 this.SoftwareList?.Equals(other.SoftwareList) == true) &&
                (this.FileList == null && other.FileList == null ||
                 this.FileList?.Equals(other.FileList) == true) &&
                (this.CreateTime == null && other.CreateTime == null ||
                 this.CreateTime?.Equals(other.CreateTime) == true) &&
                (this.StatusTime == null && other.StatusTime == null ||
                 this.StatusTime?.Equals(other.StatusTime) == true) &&
                (this.UpdateTime == null && other.UpdateTime == null ||
                 this.UpdateTime?.Equals(other.UpdateTime) == true) &&
                (this.RefreshTime == null && other.RefreshTime == null ||
                 this.RefreshTime?.Equals(other.RefreshTime) == true) &&
                (this.LastConnectionTime == null && other.LastConnectionTime == null ||
                 this.LastConnectionTime?.Equals(other.LastConnectionTime) == true) &&
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
            toStringOutput.Add($"RequestStatus = {this.RequestStatus ?? "null"}");
            toStringOutput.Add($"ResultReason = {this.ResultReason ?? "null"}");
            toStringOutput.Add($"Mdn = {this.Mdn ?? "null"}");
            toStringOutput.Add($"Model = {this.Model ?? "null"}");
            toStringOutput.Add($"Make = {this.Make ?? "null"}");
            toStringOutput.Add($"Firmware = {this.Firmware ?? "null"}");
            toStringOutput.Add($"FotaEligible = {(this.FotaEligible == null ? "null" : this.FotaEligible.ToString())}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"LicenseAssigned = {(this.LicenseAssigned == null ? "null" : this.LicenseAssigned.ToString())}");
            toStringOutput.Add($"Protocol = {this.Protocol ?? "null"}");
            toStringOutput.Add($"SoftwareList = {(this.SoftwareList == null ? "null" : $"[{string.Join(", ", this.SoftwareList)} ]")}");
            toStringOutput.Add($"FileList = {(this.FileList == null ? "null" : $"[{string.Join(", ", this.FileList)} ]")}");
            toStringOutput.Add($"CreateTime = {this.CreateTime ?? "null"}");
            toStringOutput.Add($"StatusTime = {this.StatusTime ?? "null"}");
            toStringOutput.Add($"UpdateTime = {this.UpdateTime ?? "null"}");
            toStringOutput.Add($"RefreshTime = {this.RefreshTime ?? "null"}");
            toStringOutput.Add($"LastConnectionTime = {(this.LastConnectionTime == null ? "null" : this.LastConnectionTime.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}