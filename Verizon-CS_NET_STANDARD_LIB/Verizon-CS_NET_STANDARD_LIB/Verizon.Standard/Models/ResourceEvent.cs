// <copyright file="ResourceEvent.cs" company="APIMatic">
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
    /// ResourceEvent.
    /// </summary>
    public class ResourceEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceEvent"/> class.
        /// </summary>
        public ResourceEvent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceEvent"/> class.
        /// </summary>
        /// <param name="createdon">createdon.</param>
        /// <param name="fieldid">fieldid.</param>
        /// <param name="foreignid">foreignid.</param>
        /// <param name="lastupdated">lastupdated.</param>
        /// <param name="state">state.</param>
        /// <param name="versionid">versionid.</param>
        /// <param name="accountclientid">accountclientid.</param>
        /// <param name="callbackurl">callbackurl.</param>
        /// <param name="description">description.</param>
        /// <param name="deviceid">deviceid.</param>
        /// <param name="errmsg">errmsg.</param>
        /// <param name="fields">fields.</param>
        /// <param name="fieldvalue">fieldvalue.</param>
        /// <param name="id">id.</param>
        /// <param name="modelid">modelid.</param>
        /// <param name="name">name.</param>
        /// <param name="sensordataaggregation">sensordataaggregation.</param>
        /// <param name="transactionid">transactionid.</param>
        /// <param name="version">version.</param>
        public ResourceEvent(
            DateTime createdon,
            string fieldid,
            string foreignid,
            DateTime lastupdated,
            string state,
            string versionid,
            string accountclientid = null,
            string callbackurl = null,
            string description = null,
            string deviceid = null,
            string errmsg = null,
            Models.DtoFields fields = null,
            List<int> fieldvalue = null,
            string id = null,
            string modelid = null,
            string name = null,
            bool? sensordataaggregation = null,
            string transactionid = null,
            string version = null)
        {
            this.Accountclientid = accountclientid;
            this.Callbackurl = callbackurl;
            this.Createdon = createdon;
            this.Description = description;
            this.Deviceid = deviceid;
            this.Errmsg = errmsg;
            this.Fieldid = fieldid;
            this.Fields = fields;
            this.Fieldvalue = fieldvalue;
            this.Foreignid = foreignid;
            this.Id = id;
            this.Lastupdated = lastupdated;
            this.Modelid = modelid;
            this.Name = name;
            this.Sensordataaggregation = sensordataaggregation;
            this.State = state;
            this.Transactionid = transactionid;
            this.Version = version;
            this.Versionid = versionid;
        }

        /// <summary>
        /// Not used in this release, future functionality
        /// </summary>
        [JsonProperty("accountclientid", NullValueHandling = NullValueHandling.Ignore)]
        public string Accountclientid { get; set; }

        /// <summary>
        /// The URL of the callback listener
        /// </summary>
        [JsonProperty("callbackurl", NullValueHandling = NullValueHandling.Ignore)]
        public string Callbackurl { get; set; }

        /// <summary>
        /// Timestamp of the record
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdon")]
        public DateTime Createdon { get; set; }

        /// <summary>
        /// a short description
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// This is a UUID value of the device created when the device is onboarded
        /// </summary>
        [JsonProperty("deviceid", NullValueHandling = NullValueHandling.Ignore)]
        public string Deviceid { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty("errmsg", NullValueHandling = NullValueHandling.Ignore)]
        public string Errmsg { get; set; }

        /// <summary>
        /// Gets or sets Fieldid.
        /// </summary>
        [JsonProperty("fieldid")]
        public string Fieldid { get; set; }

        /// <summary>
        /// Fields to return needed by search
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DtoFields Fields { get; set; }

        /// <summary>
        /// Gets or sets Fieldvalue.
        /// </summary>
        [JsonProperty("fieldvalue", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> Fieldvalue { get; set; }

        /// <summary>
        /// UUID of the ECPD account the user belongs to
        /// </summary>
        [JsonProperty("foreignid")]
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
        [JsonProperty("lastupdated")]
        public DateTime Lastupdated { get; set; }

        /// <summary>
        /// The model ID of the device
        /// </summary>
        [JsonProperty("modelid", NullValueHandling = NullValueHandling.Ignore)]
        public string Modelid { get; set; }

        /// <summary>
        /// User defined name of the record
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// A flag to indicate if sensor data is to be aggregated (true) or not
        /// </summary>
        [JsonProperty("sensordataaggregation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sensordataaggregation { get; set; }

        /// <summary>
        /// The current status of the device or transaction and will be `success` or `failed`
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The system-generated UUID of the transaction
        /// </summary>
        [JsonProperty("transactionid", NullValueHandling = NullValueHandling.Ignore)]
        public string Transactionid { get; set; }

        /// <summary>
        /// The resource version
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// The UUID of the resource version
        /// </summary>
        [JsonProperty("versionid")]
        public string Versionid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ResourceEvent : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ResourceEvent other &&
                (this.Accountclientid == null && other.Accountclientid == null ||
                 this.Accountclientid?.Equals(other.Accountclientid) == true) &&
                (this.Callbackurl == null && other.Callbackurl == null ||
                 this.Callbackurl?.Equals(other.Callbackurl) == true) &&
                (this.Createdon.Equals(other.Createdon)) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Deviceid == null && other.Deviceid == null ||
                 this.Deviceid?.Equals(other.Deviceid) == true) &&
                (this.Errmsg == null && other.Errmsg == null ||
                 this.Errmsg?.Equals(other.Errmsg) == true) &&
                (this.Fieldid == null && other.Fieldid == null ||
                 this.Fieldid?.Equals(other.Fieldid) == true) &&
                (this.Fields == null && other.Fields == null ||
                 this.Fields?.Equals(other.Fields) == true) &&
                (this.Fieldvalue == null && other.Fieldvalue == null ||
                 this.Fieldvalue?.Equals(other.Fieldvalue) == true) &&
                (this.Foreignid == null && other.Foreignid == null ||
                 this.Foreignid?.Equals(other.Foreignid) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Lastupdated.Equals(other.Lastupdated)) &&
                (this.Modelid == null && other.Modelid == null ||
                 this.Modelid?.Equals(other.Modelid) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Sensordataaggregation == null && other.Sensordataaggregation == null ||
                 this.Sensordataaggregation?.Equals(other.Sensordataaggregation) == true) &&
                (this.State == null && other.State == null ||
                 this.State?.Equals(other.State) == true) &&
                (this.Transactionid == null && other.Transactionid == null ||
                 this.Transactionid?.Equals(other.Transactionid) == true) &&
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
            toStringOutput.Add($"Accountclientid = {this.Accountclientid ?? "null"}");
            toStringOutput.Add($"Callbackurl = {this.Callbackurl ?? "null"}");
            toStringOutput.Add($"Createdon = {this.Createdon}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Deviceid = {this.Deviceid ?? "null"}");
            toStringOutput.Add($"Errmsg = {this.Errmsg ?? "null"}");
            toStringOutput.Add($"Fieldid = {this.Fieldid ?? "null"}");
            toStringOutput.Add($"Fields = {(this.Fields == null ? "null" : this.Fields.ToString())}");
            toStringOutput.Add($"Fieldvalue = {(this.Fieldvalue == null ? "null" : $"[{string.Join(", ", this.Fieldvalue)} ]")}");
            toStringOutput.Add($"Foreignid = {this.Foreignid ?? "null"}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Lastupdated = {this.Lastupdated}");
            toStringOutput.Add($"Modelid = {this.Modelid ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Sensordataaggregation = {(this.Sensordataaggregation == null ? "null" : this.Sensordataaggregation.ToString())}");
            toStringOutput.Add($"State = {this.State ?? "null"}");
            toStringOutput.Add($"Transactionid = {this.Transactionid ?? "null"}");
            toStringOutput.Add($"Version = {this.Version ?? "null"}");
            toStringOutput.Add($"Versionid = {this.Versionid ?? "null"}");
        }
    }
}