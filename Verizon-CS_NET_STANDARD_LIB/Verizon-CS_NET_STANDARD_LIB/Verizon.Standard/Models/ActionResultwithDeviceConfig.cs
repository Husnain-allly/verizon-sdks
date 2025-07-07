// <copyright file="ActionResultwithDeviceConfig.cs" company="APIMatic">
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
    /// ActionResultwithDeviceConfig.
    /// </summary>
    public class ActionResultwithDeviceConfig
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
        /// Initializes a new instance of the <see cref="ActionResultwithDeviceConfig"/> class.
        /// </summary>
        public ActionResultwithDeviceConfig()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionResultwithDeviceConfig"/> class.
        /// </summary>
        /// <param name="createdon">createdon.</param>
        /// <param name="description">description.</param>
        /// <param name="deviceid">deviceid.</param>
        /// <param name="errmsg">errmsg.</param>
        /// <param name="fields">fields.</param>
        /// <param name="foreignid">foreignid.</param>
        /// <param name="id">id.</param>
        /// <param name="lastupdated">lastupdated.</param>
        /// <param name="state">state.</param>
        /// <param name="transactionid">transactionid.</param>
        /// <param name="version">version.</param>
        /// <param name="versionid">versionid.</param>
        public ActionResultwithDeviceConfig(
            DateTime? createdon = null,
            string description = null,
            string deviceid = null,
            string errmsg = null,
            Models.DtoDeviceActionSetConfiguration fields = null,
            string foreignid = null,
            string id = null,
            DateTime? lastupdated = null,
            string state = null,
            string transactionid = null,
            string version = null,
            string versionid = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Createdon = createdon;
            this.Description = description;
            this.Deviceid = deviceid;
            this.Errmsg = errmsg;
            this.Fields = fields;
            this.Foreignid = foreignid;
            this.Id = id;
            this.Lastupdated = lastupdated;
            this.State = state;
            this.Transactionid = transactionid;
            this.Version = version;
            this.Versionid = versionid;
        }

        /// <summary>
        /// Timestamp of the record
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdon", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Createdon { get; set; }

        /// <summary>
        /// Gets or sets Description.
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
        /// Gets or sets Fields.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DtoDeviceActionSetConfiguration Fields { get; set; }

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
        /// The current status of the device or transaction and will be `success` or `failed`
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("versionid", NullValueHandling = NullValueHandling.Ignore)]
        public string Versionid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ActionResultwithDeviceConfig : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ActionResultwithDeviceConfig other &&
                (this.Createdon == null && other.Createdon == null ||
                 this.Createdon?.Equals(other.Createdon) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Deviceid == null && other.Deviceid == null ||
                 this.Deviceid?.Equals(other.Deviceid) == true) &&
                (this.Errmsg == null && other.Errmsg == null ||
                 this.Errmsg?.Equals(other.Errmsg) == true) &&
                (this.Fields == null && other.Fields == null ||
                 this.Fields?.Equals(other.Fields) == true) &&
                (this.Foreignid == null && other.Foreignid == null ||
                 this.Foreignid?.Equals(other.Foreignid) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Lastupdated == null && other.Lastupdated == null ||
                 this.Lastupdated?.Equals(other.Lastupdated) == true) &&
                (this.State == null && other.State == null ||
                 this.State?.Equals(other.State) == true) &&
                (this.Transactionid == null && other.Transactionid == null ||
                 this.Transactionid?.Equals(other.Transactionid) == true) &&
                (this.Version == null && other.Version == null ||
                 this.Version?.Equals(other.Version) == true) &&
                (this.Versionid == null && other.Versionid == null ||
                 this.Versionid?.Equals(other.Versionid) == true) &&
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
            toStringOutput.Add($"Createdon = {(this.Createdon == null ? "null" : this.Createdon.ToString())}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Deviceid = {this.Deviceid ?? "null"}");
            toStringOutput.Add($"Errmsg = {this.Errmsg ?? "null"}");
            toStringOutput.Add($"Fields = {(this.Fields == null ? "null" : this.Fields.ToString())}");
            toStringOutput.Add($"Foreignid = {this.Foreignid ?? "null"}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Lastupdated = {(this.Lastupdated == null ? "null" : this.Lastupdated.ToString())}");
            toStringOutput.Add($"State = {this.State ?? "null"}");
            toStringOutput.Add($"Transactionid = {this.Transactionid ?? "null"}");
            toStringOutput.Add($"Version = {this.Version ?? "null"}");
            toStringOutput.Add($"Versionid = {this.Versionid ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}