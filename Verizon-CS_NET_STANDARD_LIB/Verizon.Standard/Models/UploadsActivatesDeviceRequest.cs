// <copyright file="UploadsActivatesDeviceRequest.cs" company="APIMatic">
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
    /// UploadsActivatesDeviceRequest.
    /// </summary>
    public class UploadsActivatesDeviceRequest
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
        /// Initializes a new instance of the <see cref="UploadsActivatesDeviceRequest"/> class.
        /// </summary>
        public UploadsActivatesDeviceRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadsActivatesDeviceRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="emailAddress">emailAddress.</param>
        /// <param name="deviceSku">deviceSku.</param>
        /// <param name="uploadType">uploadType.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="mdnZipCode">mdnZipCode.</param>
        /// <param name="devices">devices.</param>
        /// <param name="carrierIpPoolName">carrierIpPoolName.</param>
        public UploadsActivatesDeviceRequest(
            string accountName,
            string emailAddress,
            string deviceSku,
            string uploadType,
            string servicePlan,
            string mdnZipCode,
            List<Models.DeviceList> devices,
            string carrierIpPoolName = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountName = accountName;
            this.EmailAddress = emailAddress;
            this.DeviceSku = deviceSku;
            this.UploadType = uploadType;
            this.ServicePlan = servicePlan;
            this.CarrierIpPoolName = carrierIpPoolName;
            this.MdnZipCode = mdnZipCode;
            this.Devices = devices;
        }

        /// <summary>
        /// The name of a billing account. An account name is usually numeric, and must include any leading zeros.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// The email address that the report should be sent to when the upload is complete.
        /// </summary>
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The stock keeping unit that identifies the type of devices in the upload and activation.
        /// </summary>
        [JsonProperty("deviceSku")]
        public string DeviceSku { get; set; }

        /// <summary>
        /// The format of the device identifiers in the upload and activation.
        /// </summary>
        [JsonProperty("uploadType")]
        public string UploadType { get; set; }

        /// <summary>
        /// The service plan code that you want to assign to all specified devices.
        /// </summary>
        [JsonProperty("servicePlan")]
        public string ServicePlan { get; set; }

        /// <summary>
        /// The pool from which your device IP addresses is derived.
        /// </summary>
        [JsonProperty("carrierIpPoolName", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierIpPoolName { get; set; }

        /// <summary>
        /// The Zip code of the location where the line of service is primarily used, or a Zip code that you have been told to use with these devices.
        /// </summary>
        [JsonProperty("mdnZipCode")]
        public string MdnZipCode { get; set; }

        /// <summary>
        /// The devices to upload, specified by device IDs in a format matching uploadType.
        /// </summary>
        [JsonProperty("devices")]
        public List<Models.DeviceList> Devices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UploadsActivatesDeviceRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UploadsActivatesDeviceRequest other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.EmailAddress == null && other.EmailAddress == null ||
                 this.EmailAddress?.Equals(other.EmailAddress) == true) &&
                (this.DeviceSku == null && other.DeviceSku == null ||
                 this.DeviceSku?.Equals(other.DeviceSku) == true) &&
                (this.UploadType == null && other.UploadType == null ||
                 this.UploadType?.Equals(other.UploadType) == true) &&
                (this.ServicePlan == null && other.ServicePlan == null ||
                 this.ServicePlan?.Equals(other.ServicePlan) == true) &&
                (this.CarrierIpPoolName == null && other.CarrierIpPoolName == null ||
                 this.CarrierIpPoolName?.Equals(other.CarrierIpPoolName) == true) &&
                (this.MdnZipCode == null && other.MdnZipCode == null ||
                 this.MdnZipCode?.Equals(other.MdnZipCode) == true) &&
                (this.Devices == null && other.Devices == null ||
                 this.Devices?.Equals(other.Devices) == true) &&
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
            toStringOutput.Add($"EmailAddress = {this.EmailAddress ?? "null"}");
            toStringOutput.Add($"DeviceSku = {this.DeviceSku ?? "null"}");
            toStringOutput.Add($"UploadType = {this.UploadType ?? "null"}");
            toStringOutput.Add($"ServicePlan = {this.ServicePlan ?? "null"}");
            toStringOutput.Add($"CarrierIpPoolName = {this.CarrierIpPoolName ?? "null"}");
            toStringOutput.Add($"MdnZipCode = {this.MdnZipCode ?? "null"}");
            toStringOutput.Add($"Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}