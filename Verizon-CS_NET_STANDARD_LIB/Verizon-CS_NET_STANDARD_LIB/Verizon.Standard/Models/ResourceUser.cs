// <copyright file="ResourceUser.cs" company="APIMatic">
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
    /// ResourceUser.
    /// </summary>
    public class ResourceUser
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceUser"/> class.
        /// </summary>
        public ResourceUser()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceUser"/> class.
        /// </summary>
        /// <param name="createdon">createdon.</param>
        /// <param name="credentialstype">credentialstype.</param>
        /// <param name="foreignid">foreignid.</param>
        /// <param name="lastupdated">lastupdated.</param>
        /// <param name="versionid">versionid.</param>
        /// <param name="accountclientid">accountclientid.</param>
        /// <param name="ackterms">ackterms.</param>
        /// <param name="acktermson">acktermson.</param>
        /// <param name="billingaccountid">billingaccountid.</param>
        /// <param name="credentialsid">credentialsid.</param>
        /// <param name="customdata">customdata.</param>
        /// <param name="description">description.</param>
        /// <param name="displayname">displayname.</param>
        /// <param name="email">email.</param>
        /// <param name="firstname">firstname.</param>
        /// <param name="id">id.</param>
        /// <param name="lastname">lastname.</param>
        /// <param name="mdn">mdn.</param>
        /// <param name="middlename">middlename.</param>
        /// <param name="name">name.</param>
        /// <param name="secondarybillingaccountids">secondarybillingaccountids.</param>
        /// <param name="state">state.</param>
        /// <param name="version">version.</param>
        public ResourceUser(
            DateTime createdon,
            string credentialstype,
            string foreignid,
            DateTime lastupdated,
            string versionid,
            string accountclientid = null,
            bool? ackterms = null,
            DateTime? acktermson = null,
            string billingaccountid = null,
            string credentialsid = null,
            object customdata = null,
            string description = null,
            string displayname = null,
            string email = null,
            string firstname = null,
            string id = null,
            string lastname = null,
            string mdn = null,
            string middlename = null,
            string name = null,
            List<string> secondarybillingaccountids = null,
            string state = null,
            string version = null)
        {
            this.Accountclientid = accountclientid;
            this.Ackterms = ackterms;
            this.Acktermson = acktermson;
            this.Billingaccountid = billingaccountid;
            this.Createdon = createdon;
            this.Credentialsid = credentialsid;
            this.Credentialstype = credentialstype;
            this.Customdata = customdata;
            this.Description = description;
            this.Displayname = displayname;
            this.Email = email;
            this.Firstname = firstname;
            this.Foreignid = foreignid;
            this.Id = id;
            this.Lastname = lastname;
            this.Lastupdated = lastupdated;
            this.Mdn = mdn;
            this.Middlename = middlename;
            this.Name = name;
            this.Secondarybillingaccountids = secondarybillingaccountids;
            this.State = state;
            this.Version = version;
            this.Versionid = versionid;
        }

        /// <summary>
        /// Not used in this release, future functionality
        /// </summary>
        [JsonProperty("accountclientid", NullValueHandling = NullValueHandling.Ignore)]
        public string Accountclientid { get; set; }

        /// <summary>
        /// Indicates if terms are agreed to (true) or not
        /// </summary>
        [JsonProperty("ackterms", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ackterms { get; set; }

        /// <summary>
        /// Gets or sets Acktermson.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("acktermson", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Acktermson { get; set; }

        /// <summary>
        /// The billing account ID. This is the same value as the Account ID
        /// </summary>
        [JsonProperty("billingaccountid", NullValueHandling = NullValueHandling.Ignore)]
        public string Billingaccountid { get; set; }

        /// <summary>
        /// Timestamp of the record
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdon")]
        public DateTime Createdon { get; set; }

        /// <summary>
        /// User credentials. The only valid value is an email address
        /// </summary>
        [JsonProperty("credentialsid", NullValueHandling = NullValueHandling.Ignore)]
        public string Credentialsid { get; set; }

        /// <summary>
        /// The type of credential represented by the ID. The only valid value is `email`
        /// </summary>
        [JsonProperty("credentialstype")]
        public string Credentialstype { get; set; }

        /// <summary>
        /// Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action.
        /// </summary>
        [JsonProperty("customdata", NullValueHandling = NullValueHandling.Ignore)]
        public object Customdata { get; set; }

        /// <summary>
        /// a short description
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// the user name value to display
        /// </summary>
        [JsonProperty("displayname", NullValueHandling = NullValueHandling.Ignore)]
        public string Displayname { get; set; }

        /// <summary>
        /// Contact email for the group
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// The first name in the user record
        /// </summary>
        [JsonProperty("firstname", NullValueHandling = NullValueHandling.Ignore)]
        public string Firstname { get; set; }

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
        /// The last name in the user record
        /// </summary>
        [JsonProperty("lastname", NullValueHandling = NullValueHandling.Ignore)]
        public string Lastname { get; set; }

        /// <summary>
        /// Timestamp of the record
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastupdated")]
        public DateTime Lastupdated { get; set; }

        /// <summary>
        /// The Mobile Directory Number
        /// </summary>
        [JsonProperty("mdn", NullValueHandling = NullValueHandling.Ignore)]
        public string Mdn { get; set; }

        /// <summary>
        /// optional field for middle name or initial
        /// </summary>
        [JsonProperty("middlename", NullValueHandling = NullValueHandling.Ignore)]
        public string Middlename { get; set; }

        /// <summary>
        /// User defined name of the record
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Virtual field; will not be used in this implementation
        /// </summary>
        [JsonProperty("secondarybillingaccountids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Secondarybillingaccountids { get; set; }

        /// <summary>
        /// The current status of the device or transaction and will be `success` or `failed`
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

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
            return $"ResourceUser : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ResourceUser other &&
                (this.Accountclientid == null && other.Accountclientid == null ||
                 this.Accountclientid?.Equals(other.Accountclientid) == true) &&
                (this.Ackterms == null && other.Ackterms == null ||
                 this.Ackterms?.Equals(other.Ackterms) == true) &&
                (this.Acktermson == null && other.Acktermson == null ||
                 this.Acktermson?.Equals(other.Acktermson) == true) &&
                (this.Billingaccountid == null && other.Billingaccountid == null ||
                 this.Billingaccountid?.Equals(other.Billingaccountid) == true) &&
                (this.Createdon.Equals(other.Createdon)) &&
                (this.Credentialsid == null && other.Credentialsid == null ||
                 this.Credentialsid?.Equals(other.Credentialsid) == true) &&
                (this.Credentialstype == null && other.Credentialstype == null ||
                 this.Credentialstype?.Equals(other.Credentialstype) == true) &&
                (this.Customdata == null && other.Customdata == null ||
                 this.Customdata?.Equals(other.Customdata) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Displayname == null && other.Displayname == null ||
                 this.Displayname?.Equals(other.Displayname) == true) &&
                (this.Email == null && other.Email == null ||
                 this.Email?.Equals(other.Email) == true) &&
                (this.Firstname == null && other.Firstname == null ||
                 this.Firstname?.Equals(other.Firstname) == true) &&
                (this.Foreignid == null && other.Foreignid == null ||
                 this.Foreignid?.Equals(other.Foreignid) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Lastname == null && other.Lastname == null ||
                 this.Lastname?.Equals(other.Lastname) == true) &&
                (this.Lastupdated.Equals(other.Lastupdated)) &&
                (this.Mdn == null && other.Mdn == null ||
                 this.Mdn?.Equals(other.Mdn) == true) &&
                (this.Middlename == null && other.Middlename == null ||
                 this.Middlename?.Equals(other.Middlename) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Secondarybillingaccountids == null && other.Secondarybillingaccountids == null ||
                 this.Secondarybillingaccountids?.Equals(other.Secondarybillingaccountids) == true) &&
                (this.State == null && other.State == null ||
                 this.State?.Equals(other.State) == true) &&
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
            toStringOutput.Add($"Ackterms = {(this.Ackterms == null ? "null" : this.Ackterms.ToString())}");
            toStringOutput.Add($"Acktermson = {(this.Acktermson == null ? "null" : this.Acktermson.ToString())}");
            toStringOutput.Add($"Billingaccountid = {this.Billingaccountid ?? "null"}");
            toStringOutput.Add($"Createdon = {this.Createdon}");
            toStringOutput.Add($"Credentialsid = {this.Credentialsid ?? "null"}");
            toStringOutput.Add($"Credentialstype = {this.Credentialstype ?? "null"}");
            toStringOutput.Add($"Customdata = {(this.Customdata == null ? "null" : this.Customdata.ToString())}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Displayname = {this.Displayname ?? "null"}");
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"Firstname = {this.Firstname ?? "null"}");
            toStringOutput.Add($"Foreignid = {this.Foreignid ?? "null"}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Lastname = {this.Lastname ?? "null"}");
            toStringOutput.Add($"Lastupdated = {this.Lastupdated}");
            toStringOutput.Add($"Mdn = {this.Mdn ?? "null"}");
            toStringOutput.Add($"Middlename = {this.Middlename ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Secondarybillingaccountids = {(this.Secondarybillingaccountids == null ? "null" : $"[{string.Join(", ", this.Secondarybillingaccountids)} ]")}");
            toStringOutput.Add($"State = {this.State ?? "null"}");
            toStringOutput.Add($"Version = {this.Version ?? "null"}");
            toStringOutput.Add($"Versionid = {this.Versionid ?? "null"}");
        }
    }
}