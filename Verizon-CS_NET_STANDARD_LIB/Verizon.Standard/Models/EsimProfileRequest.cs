// <copyright file="EsimProfileRequest.cs" company="APIMatic">
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
    /// EsimProfileRequest.
    /// </summary>
    public class EsimProfileRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EsimProfileRequest"/> class.
        /// </summary>
        public EsimProfileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EsimProfileRequest"/> class.
        /// </summary>
        /// <param name="devices">devices.</param>
        /// <param name="carrierName">carrierName.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="mdnZipCode">mdnZipCode.</param>
        public EsimProfileRequest(
            List<Models.EsimDeviceList> devices = null,
            string carrierName = null,
            string accountName = null,
            string servicePlan = null,
            string mdnZipCode = null)
        {
            this.Devices = devices;
            this.CarrierName = carrierName;
            this.AccountName = accountName;
            this.ServicePlan = servicePlan;
            this.MdnZipCode = mdnZipCode;
        }

        /// <summary>
        /// Gets or sets Devices.
        /// </summary>
        [JsonProperty("devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.EsimDeviceList> Devices { get; set; }

        /// <summary>
        /// Gets or sets CarrierName.
        /// </summary>
        [JsonProperty("carrierName", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierName { get; set; }

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
        /// Gets or sets MdnZipCode.
        /// </summary>
        [JsonProperty("mdnZipCode", NullValueHandling = NullValueHandling.Ignore)]
        public string MdnZipCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"EsimProfileRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is EsimProfileRequest other &&
                (this.Devices == null && other.Devices == null ||
                 this.Devices?.Equals(other.Devices) == true) &&
                (this.CarrierName == null && other.CarrierName == null ||
                 this.CarrierName?.Equals(other.CarrierName) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.ServicePlan == null && other.ServicePlan == null ||
                 this.ServicePlan?.Equals(other.ServicePlan) == true) &&
                (this.MdnZipCode == null && other.MdnZipCode == null ||
                 this.MdnZipCode?.Equals(other.MdnZipCode) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"CarrierName = {this.CarrierName ?? "null"}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"ServicePlan = {this.ServicePlan ?? "null"}");
            toStringOutput.Add($"MdnZipCode = {this.MdnZipCode ?? "null"}");
        }
    }
}