// <copyright file="GioProfileRequest.cs" company="APIMatic">
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
    /// GioProfileRequest.
    /// </summary>
    public class GioProfileRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GioProfileRequest"/> class.
        /// </summary>
        public GioProfileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GioProfileRequest"/> class.
        /// </summary>
        /// <param name="devices">devices.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="mdnZipCode">mdnZipCode.</param>
        /// <param name="servicePlan">servicePlan.</param>
        public GioProfileRequest(
            List<Models.GioDeviceList> devices,
            string accountName,
            string mdnZipCode = null,
            string servicePlan = null)
        {
            this.Devices = devices;
            this.AccountName = accountName;
            this.MdnZipCode = mdnZipCode;
            this.ServicePlan = servicePlan;
        }

        /// <summary>
        /// Gets or sets Devices.
        /// </summary>
        [JsonProperty("devices")]
        public List<Models.GioDeviceList> Devices { get; set; }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets MdnZipCode.
        /// </summary>
        [JsonProperty("mdnZipCode", NullValueHandling = NullValueHandling.Ignore)]
        public string MdnZipCode { get; set; }

        /// <summary>
        /// Gets or sets ServicePlan.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GioProfileRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GioProfileRequest other &&
                (this.Devices == null && other.Devices == null ||
                 this.Devices?.Equals(other.Devices) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.MdnZipCode == null && other.MdnZipCode == null ||
                 this.MdnZipCode?.Equals(other.MdnZipCode) == true) &&
                (this.ServicePlan == null && other.ServicePlan == null ||
                 this.ServicePlan?.Equals(other.ServicePlan) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"MdnZipCode = {this.MdnZipCode ?? "null"}");
            toStringOutput.Add($"ServicePlan = {this.ServicePlan ?? "null"}");
        }
    }
}