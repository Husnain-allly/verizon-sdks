// <copyright file="UserDeviceExperienceHistory.cs" company="APIMatic">
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
    /// UserDeviceExperienceHistory.
    /// </summary>
    public class UserDeviceExperienceHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDeviceExperienceHistory"/> class.
        /// </summary>
        public UserDeviceExperienceHistory()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDeviceExperienceHistory"/> class.
        /// </summary>
        /// <param name="billingaccountid">billingaccountid.</param>
        /// <param name="createdon">createdon.</param>
        /// <param name="date">date.</param>
        /// <param name="devicesbad">devicesbad.</param>
        /// <param name="devicesfair">devicesfair.</param>
        /// <param name="devicesgood">devicesgood.</param>
        /// <param name="devicestotal">devicestotal.</param>
        /// <param name="foreignid">foreignid.</param>
        /// <param name="id">id.</param>
        /// <param name="lastupdated">lastupdated.</param>
        /// <param name="version">version.</param>
        /// <param name="versionid">versionid.</param>
        public UserDeviceExperienceHistory(
            string billingaccountid = null,
            DateTime? createdon = null,
            DateTime? date = null,
            int? devicesbad = null,
            int? devicesfair = null,
            int? devicesgood = null,
            int? devicestotal = null,
            string foreignid = null,
            string id = null,
            DateTime? lastupdated = null,
            string version = null,
            string versionid = null)
        {
            this.Billingaccountid = billingaccountid;
            this.Createdon = createdon;
            this.Date = date;
            this.Devicesbad = devicesbad;
            this.Devicesfair = devicesfair;
            this.Devicesgood = devicesgood;
            this.Devicestotal = devicestotal;
            this.Foreignid = foreignid;
            this.Id = id;
            this.Lastupdated = lastupdated;
            this.Version = version;
            this.Versionid = versionid;
        }

        /// <summary>
        /// The billing account ID. This is the same value as the Account ID
        /// </summary>
        [JsonProperty("billingaccountid", NullValueHandling = NullValueHandling.Ignore)]
        public string Billingaccountid { get; set; }

        /// <summary>
        /// Timestamp of the record
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdon", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Createdon { get; set; }

        /// <summary>
        /// Timestamp of the record
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// This is a score based on combination of network coverage and network outage affecting the device's ability to connect to the network. This is a count of devices that have failed
        /// </summary>
        [JsonProperty("devicesbad", NullValueHandling = NullValueHandling.Ignore)]
        public int? Devicesbad { get; set; }

        /// <summary>
        /// This is a score based on combination of network coverage and network outage affecting the device's ability to connect to the network. This is a count of devices that are impaired
        /// </summary>
        [JsonProperty("devicesfair", NullValueHandling = NullValueHandling.Ignore)]
        public int? Devicesfair { get; set; }

        /// <summary>
        /// This is a score based on combination of network coverage and network outage affecting the device's ability to connect to the network. This is a count of devices that have no issues
        /// </summary>
        [JsonProperty("devicesgood", NullValueHandling = NullValueHandling.Ignore)]
        public int? Devicesgood { get; set; }

        /// <summary>
        /// A count of all devices
        /// </summary>
        [JsonProperty("devicestotal", NullValueHandling = NullValueHandling.Ignore)]
        public int? Devicestotal { get; set; }

        /// <summary>
        /// UUID of the ECPD account the user belongs to
        /// </summary>
        [JsonProperty("foreignid", NullValueHandling = NullValueHandling.Ignore)]
        public string Foreignid { get; set; }

        /// <summary>
        /// UUID of the user record, assigned at creation
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Timestamp of the record
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastupdated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Lastupdated { get; set; }

        /// <summary>
        /// The resource version
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// The UUID of the resource version
        /// </summary>
        [JsonProperty("versionid", NullValueHandling = NullValueHandling.Ignore)]
        public string Versionid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UserDeviceExperienceHistory : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UserDeviceExperienceHistory other &&
                (this.Billingaccountid == null && other.Billingaccountid == null ||
                 this.Billingaccountid?.Equals(other.Billingaccountid) == true) &&
                (this.Createdon == null && other.Createdon == null ||
                 this.Createdon?.Equals(other.Createdon) == true) &&
                (this.Date == null && other.Date == null ||
                 this.Date?.Equals(other.Date) == true) &&
                (this.Devicesbad == null && other.Devicesbad == null ||
                 this.Devicesbad?.Equals(other.Devicesbad) == true) &&
                (this.Devicesfair == null && other.Devicesfair == null ||
                 this.Devicesfair?.Equals(other.Devicesfair) == true) &&
                (this.Devicesgood == null && other.Devicesgood == null ||
                 this.Devicesgood?.Equals(other.Devicesgood) == true) &&
                (this.Devicestotal == null && other.Devicestotal == null ||
                 this.Devicestotal?.Equals(other.Devicestotal) == true) &&
                (this.Foreignid == null && other.Foreignid == null ||
                 this.Foreignid?.Equals(other.Foreignid) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Lastupdated == null && other.Lastupdated == null ||
                 this.Lastupdated?.Equals(other.Lastupdated) == true) &&
                (this.Version == null && other.Version == null ||
                 this.Version?.Equals(other.Version) == true) &&
                (this.Versionid == null && other.Versionid == null ||
                 this.Versionid?.Equals(other.Versionid) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Billingaccountid = {this.Billingaccountid ?? "null"}");
            toStringOutput.Add($"Createdon = {(this.Createdon == null ? "null" : this.Createdon.ToString())}");
            toStringOutput.Add($"Date = {(this.Date == null ? "null" : this.Date.ToString())}");
            toStringOutput.Add($"Devicesbad = {(this.Devicesbad == null ? "null" : this.Devicesbad.ToString())}");
            toStringOutput.Add($"Devicesfair = {(this.Devicesfair == null ? "null" : this.Devicesfair.ToString())}");
            toStringOutput.Add($"Devicesgood = {(this.Devicesgood == null ? "null" : this.Devicesgood.ToString())}");
            toStringOutput.Add($"Devicestotal = {(this.Devicestotal == null ? "null" : this.Devicestotal.ToString())}");
            toStringOutput.Add($"Foreignid = {this.Foreignid ?? "null"}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Lastupdated = {(this.Lastupdated == null ? "null" : this.Lastupdated.ToString())}");
            toStringOutput.Add($"Version = {this.Version ?? "null"}");
            toStringOutput.Add($"Versionid = {this.Versionid ?? "null"}");
        }
    }
}