// <copyright file="UserSmartAlert.cs" company="APIMatic">
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
    /// UserSmartAlert.
    /// </summary>
    public class UserSmartAlert
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSmartAlert"/> class.
        /// </summary>
        public UserSmartAlert()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSmartAlert"/> class.
        /// </summary>
        /// <param name="createdon">createdon.</param>
        /// <param name="lastupdated">lastupdated.</param>
        /// <param name="versionid">versionid.</param>
        /// <param name="accountclientid">accountclientid.</param>
        /// <param name="billingaccountid">billingaccountid.</param>
        /// <param name="category">category.</param>
        /// <param name="condition">condition.</param>
        /// <param name="description">description.</param>
        /// <param name="deviceid">deviceid.</param>
        /// <param name="foreignid">foreignid.</param>
        /// <param name="id">id.</param>
        /// <param name="isacknowledged">isacknowledged.</param>
        /// <param name="iscleared">iscleared.</param>
        /// <param name="isdisabled">isdisabled.</param>
        /// <param name="name">name.</param>
        /// <param name="ruleid">ruleid.</param>
        /// <param name="severity">severity.</param>
        /// <param name="state">state.</param>
        /// <param name="template">template.</param>
        /// <param name="version">version.</param>
        public UserSmartAlert(
            DateTime createdon,
            DateTime lastupdated,
            string versionid,
            string accountclientid = null,
            string billingaccountid = null,
            string category = null,
            int? condition = null,
            string description = null,
            string deviceid = null,
            string foreignid = null,
            string id = null,
            bool? isacknowledged = null,
            bool? iscleared = null,
            bool? isdisabled = null,
            string name = null,
            string ruleid = null,
            string severity = null,
            string state = null,
            string template = null,
            string version = null)
        {
            this.Accountclientid = accountclientid;
            this.Billingaccountid = billingaccountid;
            this.Category = category;
            this.Condition = condition;
            this.Createdon = createdon;
            this.Description = description;
            this.Deviceid = deviceid;
            this.Foreignid = foreignid;
            this.Id = id;
            this.Isacknowledged = isacknowledged;
            this.Iscleared = iscleared;
            this.Isdisabled = isdisabled;
            this.Lastupdated = lastupdated;
            this.Name = name;
            this.Ruleid = ruleid;
            this.Severity = severity;
            this.State = state;
            this.Template = template;
            this.Version = version;
            this.Versionid = versionid;
        }

        /// <summary>
        /// Not used in this release, future functionality
        /// </summary>
        [JsonProperty("accountclientid", NullValueHandling = NullValueHandling.Ignore)]
        public string Accountclientid { get; set; }

        /// <summary>
        /// The billing account ID. This is the same value as the Account ID
        /// </summary>
        [JsonProperty("billingaccountid", NullValueHandling = NullValueHandling.Ignore)]
        public string Billingaccountid { get; set; }

        /// <summary>
        /// The type of alert and will be either `telemetry` or `infrastructure`
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// The condition or threshold for an alert
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public int? Condition { get; set; }

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
        /// A flag that indicates if the alarm has been acknowledged
        /// </summary>
        [JsonProperty("isacknowledged", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isacknowledged { get; set; }

        /// <summary>
        /// A flag that indicates if the alarm has been cleared
        /// </summary>
        [JsonProperty("iscleared", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Iscleared { get; set; }

        /// <summary>
        /// A flag that indicates if the alarm has been disabled
        /// </summary>
        [JsonProperty("isdisabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isdisabled { get; set; }

        /// <summary>
        /// Timestamp of the record
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastupdated")]
        public DateTime Lastupdated { get; set; }

        /// <summary>
        /// User defined name of the record
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The UUID of a rule for alerts
        /// </summary>
        [JsonProperty("ruleid", NullValueHandling = NullValueHandling.Ignore)]
        public string Ruleid { get; set; }

        /// <summary>
        /// The threshold value to trigger an alert and will be Critical, Major or Minor
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public string Severity { get; set; }

        /// <summary>
        /// The current status of the device or transaction and will be `success` or `failed`
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// template of the rule which triggered a given alert
        /// </summary>
        [JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
        public string Template { get; set; }

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
            return $"UserSmartAlert : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UserSmartAlert other &&
                (this.Accountclientid == null && other.Accountclientid == null ||
                 this.Accountclientid?.Equals(other.Accountclientid) == true) &&
                (this.Billingaccountid == null && other.Billingaccountid == null ||
                 this.Billingaccountid?.Equals(other.Billingaccountid) == true) &&
                (this.Category == null && other.Category == null ||
                 this.Category?.Equals(other.Category) == true) &&
                (this.Condition == null && other.Condition == null ||
                 this.Condition?.Equals(other.Condition) == true) &&
                (this.Createdon.Equals(other.Createdon)) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Deviceid == null && other.Deviceid == null ||
                 this.Deviceid?.Equals(other.Deviceid) == true) &&
                (this.Foreignid == null && other.Foreignid == null ||
                 this.Foreignid?.Equals(other.Foreignid) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Isacknowledged == null && other.Isacknowledged == null ||
                 this.Isacknowledged?.Equals(other.Isacknowledged) == true) &&
                (this.Iscleared == null && other.Iscleared == null ||
                 this.Iscleared?.Equals(other.Iscleared) == true) &&
                (this.Isdisabled == null && other.Isdisabled == null ||
                 this.Isdisabled?.Equals(other.Isdisabled) == true) &&
                (this.Lastupdated.Equals(other.Lastupdated)) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Ruleid == null && other.Ruleid == null ||
                 this.Ruleid?.Equals(other.Ruleid) == true) &&
                (this.Severity == null && other.Severity == null ||
                 this.Severity?.Equals(other.Severity) == true) &&
                (this.State == null && other.State == null ||
                 this.State?.Equals(other.State) == true) &&
                (this.Template == null && other.Template == null ||
                 this.Template?.Equals(other.Template) == true) &&
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
            toStringOutput.Add($"Billingaccountid = {this.Billingaccountid ?? "null"}");
            toStringOutput.Add($"Category = {this.Category ?? "null"}");
            toStringOutput.Add($"Condition = {(this.Condition == null ? "null" : this.Condition.ToString())}");
            toStringOutput.Add($"Createdon = {this.Createdon}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Deviceid = {this.Deviceid ?? "null"}");
            toStringOutput.Add($"Foreignid = {this.Foreignid ?? "null"}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Isacknowledged = {(this.Isacknowledged == null ? "null" : this.Isacknowledged.ToString())}");
            toStringOutput.Add($"Iscleared = {(this.Iscleared == null ? "null" : this.Iscleared.ToString())}");
            toStringOutput.Add($"Isdisabled = {(this.Isdisabled == null ? "null" : this.Isdisabled.ToString())}");
            toStringOutput.Add($"Lastupdated = {this.Lastupdated}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Ruleid = {this.Ruleid ?? "null"}");
            toStringOutput.Add($"Severity = {this.Severity ?? "null"}");
            toStringOutput.Add($"State = {this.State ?? "null"}");
            toStringOutput.Add($"Template = {this.Template ?? "null"}");
            toStringOutput.Add($"Version = {this.Version ?? "null"}");
            toStringOutput.Add($"Versionid = {this.Versionid ?? "null"}");
        }
    }
}