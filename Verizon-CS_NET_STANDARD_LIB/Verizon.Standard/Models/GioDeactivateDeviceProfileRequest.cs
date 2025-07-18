// <copyright file="GioDeactivateDeviceProfileRequest.cs" company="APIMatic">
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
using Verizon.Standard;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
{
    /// <summary>
    /// GioDeactivateDeviceProfileRequest.
    /// </summary>
    public class GioDeactivateDeviceProfileRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GioDeactivateDeviceProfileRequest"/> class.
        /// </summary>
        public GioDeactivateDeviceProfileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GioDeactivateDeviceProfileRequest"/> class.
        /// </summary>
        /// <param name="devices">devices.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="etfWaiver">etfWaiver.</param>
        /// <param name="reasonCode">reasonCode.</param>
        public GioDeactivateDeviceProfileRequest(
            List<Models.GioDeviceList> devices = null,
            string accountName = null,
            string servicePlan = null,
            bool? etfWaiver = false,
            string reasonCode = null)
        {
            this.Devices = devices;
            this.AccountName = accountName;
            this.ServicePlan = servicePlan;
            this.EtfWaiver = etfWaiver;
            this.ReasonCode = reasonCode;
        }

        /// <summary>
        /// Gets or sets Devices.
        /// </summary>
        [JsonProperty("devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.GioDeviceList> Devices { get; set; }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets ServicePlan.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <summary>
        /// Gets or sets EtfWaiver.
        /// </summary>
        [JsonProperty("etfWaiver", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EtfWaiver { get; set; }

        /// <summary>
        /// Gets or sets ReasonCode.
        /// </summary>
        [JsonProperty("reasonCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ReasonCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GioDeactivateDeviceProfileRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GioDeactivateDeviceProfileRequest other &&
                (this.Devices == null && other.Devices == null ||
                 this.Devices?.Equals(other.Devices) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.ServicePlan == null && other.ServicePlan == null ||
                 this.ServicePlan?.Equals(other.ServicePlan) == true) &&
                (this.EtfWaiver == null && other.EtfWaiver == null ||
                 this.EtfWaiver?.Equals(other.EtfWaiver) == true) &&
                (this.ReasonCode == null && other.ReasonCode == null ||
                 this.ReasonCode?.Equals(other.ReasonCode) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"ServicePlan = {this.ServicePlan ?? "null"}");
            toStringOutput.Add($"EtfWaiver = {(this.EtfWaiver == null ? "null" : this.EtfWaiver.ToString())}");
            toStringOutput.Add($"ReasonCode = {this.ReasonCode ?? "null"}");
        }
    }
}