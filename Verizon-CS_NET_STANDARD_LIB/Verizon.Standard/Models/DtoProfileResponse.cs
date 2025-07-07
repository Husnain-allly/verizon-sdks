// <copyright file="DtoProfileResponse.cs" company="APIMatic">
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
    /// DtoProfileResponse.
    /// </summary>
    public class DtoProfileResponse
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
        /// Initializes a new instance of the <see cref="DtoProfileResponse"/> class.
        /// </summary>
        public DtoProfileResponse()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoProfileResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="kind">kind.</param>
        /// <param name="version">version.</param>
        /// <param name="versionid">versionid.</param>
        /// <param name="createdon">createdon.</param>
        /// <param name="lastupdated">lastupdated.</param>
        /// <param name="name">name.</param>
        /// <param name="foreignid">foreignid.</param>
        /// <param name="billingaccountid">billingaccountid.</param>
        /// <param name="modelid">modelid.</param>
        /// <param name="configuration">configuration.</param>
        public DtoProfileResponse(
            string id = null,
            string kind = null,
            string version = null,
            string versionid = null,
            DateTime? createdon = null,
            DateTime? lastupdated = null,
            string name = null,
            string foreignid = null,
            string billingaccountid = null,
            string modelid = null,
            object configuration = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Id = id;
            this.Kind = kind;
            this.Version = version;
            this.Versionid = versionid;
            this.Createdon = createdon;
            this.Lastupdated = lastupdated;
            this.Name = name;
            this.Foreignid = foreignid;
            this.Billingaccountid = billingaccountid;
            this.Modelid = modelid;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// the user defined profile kind
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// The resource version
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets Versionid.
        /// </summary>
        [JsonProperty("versionid", NullValueHandling = NullValueHandling.Ignore)]
        public string Versionid { get; set; }

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
        [JsonProperty("lastupdated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Lastupdated { get; set; }

        /// <summary>
        /// user defined profile name
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// UUID of the ECPD account the user belongs to
        /// </summary>
        [JsonProperty("foreignid", NullValueHandling = NullValueHandling.Ignore)]
        public string Foreignid { get; set; }

        /// <summary>
        /// The billing account ID. This is the same value as the Account ID
        /// </summary>
        [JsonProperty("billingaccountid", NullValueHandling = NullValueHandling.Ignore)]
        public string Billingaccountid { get; set; }

        /// <summary>
        /// device model id
        /// </summary>
        [JsonProperty("modelid", NullValueHandling = NullValueHandling.Ignore)]
        public string Modelid { get; set; }

        /// <summary>
        /// Gets or sets Configuration.
        /// </summary>
        [JsonProperty("configuration", NullValueHandling = NullValueHandling.Ignore)]
        public object Configuration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoProfileResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoProfileResponse other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Kind == null && other.Kind == null ||
                 this.Kind?.Equals(other.Kind) == true) &&
                (this.Version == null && other.Version == null ||
                 this.Version?.Equals(other.Version) == true) &&
                (this.Versionid == null && other.Versionid == null ||
                 this.Versionid?.Equals(other.Versionid) == true) &&
                (this.Createdon == null && other.Createdon == null ||
                 this.Createdon?.Equals(other.Createdon) == true) &&
                (this.Lastupdated == null && other.Lastupdated == null ||
                 this.Lastupdated?.Equals(other.Lastupdated) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Foreignid == null && other.Foreignid == null ||
                 this.Foreignid?.Equals(other.Foreignid) == true) &&
                (this.Billingaccountid == null && other.Billingaccountid == null ||
                 this.Billingaccountid?.Equals(other.Billingaccountid) == true) &&
                (this.Modelid == null && other.Modelid == null ||
                 this.Modelid?.Equals(other.Modelid) == true) &&
                (this.Configuration == null && other.Configuration == null ||
                 this.Configuration?.Equals(other.Configuration) == true) &&
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
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Kind = {this.Kind ?? "null"}");
            toStringOutput.Add($"Version = {this.Version ?? "null"}");
            toStringOutput.Add($"Versionid = {this.Versionid ?? "null"}");
            toStringOutput.Add($"Createdon = {(this.Createdon == null ? "null" : this.Createdon.ToString())}");
            toStringOutput.Add($"Lastupdated = {(this.Lastupdated == null ? "null" : this.Lastupdated.ToString())}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Foreignid = {this.Foreignid ?? "null"}");
            toStringOutput.Add($"Billingaccountid = {this.Billingaccountid ?? "null"}");
            toStringOutput.Add($"Modelid = {this.Modelid ?? "null"}");
            toStringOutput.Add($"Configuration = {(this.Configuration == null ? "null" : this.Configuration.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}