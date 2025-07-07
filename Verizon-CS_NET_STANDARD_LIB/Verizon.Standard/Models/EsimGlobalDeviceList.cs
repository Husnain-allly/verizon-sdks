// <copyright file="EsimGlobalDeviceList.cs" company="APIMatic">
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
    /// EsimGlobalDeviceList.
    /// </summary>
    public class EsimGlobalDeviceList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EsimGlobalDeviceList"/> class.
        /// </summary>
        public EsimGlobalDeviceList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EsimGlobalDeviceList"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="provisioningStatusFilter">provisioningStatusFilter.</param>
        /// <param name="profileStatusFilter">profileStatusFilter.</param>
        /// <param name="carrierNameFilter">carrierNameFilter.</param>
        /// <param name="deviceFilter">deviceFilter.</param>
        public EsimGlobalDeviceList(
            string accountName = null,
            Models.ProvisioningStatusFilter? provisioningStatusFilter = null,
            Models.ProfileStatusFilter? profileStatusFilter = null,
            string carrierNameFilter = null,
            List<Models.DeviceId2> deviceFilter = null)
        {
            this.AccountName = accountName;
            this.ProvisioningStatusFilter = provisioningStatusFilter;
            this.ProfileStatusFilter = profileStatusFilter;
            this.CarrierNameFilter = carrierNameFilter;
            this.DeviceFilter = deviceFilter;
        }

        /// <summary>
        /// The numeric name of the account.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The last status of the device as a list filter.
        /// </summary>
        [JsonProperty("provisioningStatusFilter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProvisioningStatusFilter? ProvisioningStatusFilter { get; set; }

        /// <summary>
        /// The last status of the device's profile as a filter.
        /// </summary>
        [JsonProperty("profileStatusFilter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProfileStatusFilter? ProfileStatusFilter { get; set; }

        /// <summary>
        /// The cellular service provider.
        /// </summary>
        [JsonProperty("carrierNameFilter", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierNameFilter { get; set; }

        /// <summary>
        /// An array of device identifiers to filter the list.
        /// </summary>
        [JsonProperty("deviceFilter", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceId2> DeviceFilter { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"EsimGlobalDeviceList : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is EsimGlobalDeviceList other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.ProvisioningStatusFilter == null && other.ProvisioningStatusFilter == null ||
                 this.ProvisioningStatusFilter?.Equals(other.ProvisioningStatusFilter) == true) &&
                (this.ProfileStatusFilter == null && other.ProfileStatusFilter == null ||
                 this.ProfileStatusFilter?.Equals(other.ProfileStatusFilter) == true) &&
                (this.CarrierNameFilter == null && other.CarrierNameFilter == null ||
                 this.CarrierNameFilter?.Equals(other.CarrierNameFilter) == true) &&
                (this.DeviceFilter == null && other.DeviceFilter == null ||
                 this.DeviceFilter?.Equals(other.DeviceFilter) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"ProvisioningStatusFilter = {(this.ProvisioningStatusFilter == null ? "null" : this.ProvisioningStatusFilter.ToString())}");
            toStringOutput.Add($"ProfileStatusFilter = {(this.ProfileStatusFilter == null ? "null" : this.ProfileStatusFilter.ToString())}");
            toStringOutput.Add($"CarrierNameFilter = {this.CarrierNameFilter ?? "null"}");
            toStringOutput.Add($"DeviceFilter = {(this.DeviceFilter == null ? "null" : $"[{string.Join(", ", this.DeviceFilter)} ]")}");
        }
    }
}