// <copyright file="ResourceRule.cs" company="APIMatic">
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
    /// ResourceRule.
    /// </summary>
    public class ResourceRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceRule"/> class.
        /// </summary>
        public ResourceRule()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceRule"/> class.
        /// </summary>
        /// <param name="createdon">createdon.</param>
        /// <param name="foreignid">foreignid.</param>
        /// <param name="lastupdated">lastupdated.</param>
        /// <param name="rulechain">rulechain.</param>
        /// <param name="versionid">versionid.</param>
        /// <param name="accountclientid">accountclientid.</param>
        /// <param name="billingaccountid">billingaccountid.</param>
        /// <param name="description">description.</param>
        /// <param name="deviceid">deviceid.</param>
        /// <param name="disabled">disabled.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="rulesyntax">rulesyntax.</param>
        /// <param name="version">version.</param>
        public ResourceRule(
            DateTime createdon,
            string foreignid,
            DateTime lastupdated,
            object rulechain,
            string versionid,
            string accountclientid = null,
            string billingaccountid = null,
            string description = null,
            string deviceid = null,
            bool? disabled = null,
            string id = null,
            string name = null,
            string rulesyntax = null,
            string version = null)
        {
            this.Accountclientid = accountclientid;
            this.Billingaccountid = billingaccountid;
            this.Createdon = createdon;
            this.Description = description;
            this.Deviceid = deviceid;
            this.Disabled = disabled;
            this.Foreignid = foreignid;
            this.Id = id;
            this.Lastupdated = lastupdated;
            this.Name = name;
            this.Rulechain = rulechain;
            this.Rulesyntax = rulesyntax;
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
        /// Gets or sets Disabled.
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }

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
        /// User defined name of the record
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Rulechain.
        /// </summary>
        [JsonProperty("rulechain")]
        public object Rulechain { get; set; }

        /// <summary>
        /// The syntax of the rule and supports camel and json style syntaxes
        /// </summary>
        [JsonProperty("rulesyntax", NullValueHandling = NullValueHandling.Ignore)]
        public string Rulesyntax { get; set; }

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
            return $"ResourceRule : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ResourceRule other &&
                (this.Accountclientid == null && other.Accountclientid == null ||
                 this.Accountclientid?.Equals(other.Accountclientid) == true) &&
                (this.Billingaccountid == null && other.Billingaccountid == null ||
                 this.Billingaccountid?.Equals(other.Billingaccountid) == true) &&
                (this.Createdon.Equals(other.Createdon)) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Deviceid == null && other.Deviceid == null ||
                 this.Deviceid?.Equals(other.Deviceid) == true) &&
                (this.Disabled == null && other.Disabled == null ||
                 this.Disabled?.Equals(other.Disabled) == true) &&
                (this.Foreignid == null && other.Foreignid == null ||
                 this.Foreignid?.Equals(other.Foreignid) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Lastupdated.Equals(other.Lastupdated)) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Rulechain == null && other.Rulechain == null ||
                 this.Rulechain?.Equals(other.Rulechain) == true) &&
                (this.Rulesyntax == null && other.Rulesyntax == null ||
                 this.Rulesyntax?.Equals(other.Rulesyntax) == true) &&
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
            toStringOutput.Add($"Createdon = {this.Createdon}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Deviceid = {this.Deviceid ?? "null"}");
            toStringOutput.Add($"Disabled = {(this.Disabled == null ? "null" : this.Disabled.ToString())}");
            toStringOutput.Add($"Foreignid = {this.Foreignid ?? "null"}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Lastupdated = {this.Lastupdated}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Rulechain = {(this.Rulechain == null ? "null" : this.Rulechain.ToString())}");
            toStringOutput.Add($"Rulesyntax = {this.Rulesyntax ?? "null"}");
            toStringOutput.Add($"Version = {this.Version ?? "null"}");
            toStringOutput.Add($"Versionid = {this.Versionid ?? "null"}");
        }
    }
}