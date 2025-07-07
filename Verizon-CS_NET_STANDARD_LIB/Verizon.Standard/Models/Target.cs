// <copyright file="Target.cs" company="APIMatic">
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
    /// Target.
    /// </summary>
    public class Target
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
        /// Initializes a new instance of the <see cref="Target"/> class.
        /// </summary>
        public Target()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Target"/> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="addressscheme">addressscheme.</param>
        /// <param name="billingaccountid">billingaccountid.</param>
        /// <param name="createdon">createdon.</param>
        /// <param name="externalid">externalid.</param>
        /// <param name="id">id.</param>
        /// <param name="kind">kind.</param>
        /// <param name="lastupdated">lastupdated.</param>
        /// <param name="name">name.</param>
        /// <param name="region">region.</param>
        /// <param name="version">version.</param>
        /// <param name="versionid">versionid.</param>
        /// <param name="description">description.</param>
        public Target(
            string address = null,
            string addressscheme = null,
            string billingaccountid = null,
            string createdon = null,
            string externalid = null,
            string id = null,
            string kind = null,
            string lastupdated = null,
            string name = null,
            string region = null,
            string version = null,
            string versionid = null,
            string description = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Address = address;
            this.Addressscheme = addressscheme;
            this.Billingaccountid = billingaccountid;
            this.Createdon = createdon;
            this.Externalid = externalid;
            this.Id = id;
            this.Kind = kind;
            this.Lastupdated = lastupdated;
            this.Name = name;
            this.Region = region;
            this.Version = version;
            this.Versionid = versionid;
            this.Description = description;
        }

        /// <summary>
        /// The endpoint for data streams.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// The transport format.
        /// </summary>
        [JsonProperty("addressscheme", NullValueHandling = NullValueHandling.Ignore)]
        public string Addressscheme { get; set; }

        /// <summary>
        /// The billing account ID.
        /// </summary>
        [JsonProperty("billingaccountid", NullValueHandling = NullValueHandling.Ignore)]
        public string Billingaccountid { get; set; }

        /// <summary>
        /// The date the resource was created.
        /// </summary>
        [JsonProperty("createdon", NullValueHandling = NullValueHandling.Ignore)]
        public string Createdon { get; set; }

        /// <summary>
        /// Security identification string.
        /// </summary>
        [JsonProperty("externalid", NullValueHandling = NullValueHandling.Ignore)]
        public string Externalid { get; set; }

        /// <summary>
        /// ThingSpace unique ID for the target that was created.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Identifies the resource kind. Targets are ts.target.
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// The date the resource was last updated.
        /// </summary>
        [JsonProperty("lastupdated", NullValueHandling = NullValueHandling.Ignore)]
        public string Lastupdated { get; set; }

        /// <summary>
        /// Name of the target.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// AWS region value.
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// Version of the underlying schema resource.
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// The version of the resource.
        /// </summary>
        [JsonProperty("versionid", NullValueHandling = NullValueHandling.Ignore)]
        public string Versionid { get; set; }

        /// <summary>
        /// Description of the target.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Target : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Target other &&
                (this.Address == null && other.Address == null ||
                 this.Address?.Equals(other.Address) == true) &&
                (this.Addressscheme == null && other.Addressscheme == null ||
                 this.Addressscheme?.Equals(other.Addressscheme) == true) &&
                (this.Billingaccountid == null && other.Billingaccountid == null ||
                 this.Billingaccountid?.Equals(other.Billingaccountid) == true) &&
                (this.Createdon == null && other.Createdon == null ||
                 this.Createdon?.Equals(other.Createdon) == true) &&
                (this.Externalid == null && other.Externalid == null ||
                 this.Externalid?.Equals(other.Externalid) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Kind == null && other.Kind == null ||
                 this.Kind?.Equals(other.Kind) == true) &&
                (this.Lastupdated == null && other.Lastupdated == null ||
                 this.Lastupdated?.Equals(other.Lastupdated) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Region == null && other.Region == null ||
                 this.Region?.Equals(other.Region) == true) &&
                (this.Version == null && other.Version == null ||
                 this.Version?.Equals(other.Version) == true) &&
                (this.Versionid == null && other.Versionid == null ||
                 this.Versionid?.Equals(other.Versionid) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
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
            toStringOutput.Add($"Address = {this.Address ?? "null"}");
            toStringOutput.Add($"Addressscheme = {this.Addressscheme ?? "null"}");
            toStringOutput.Add($"Billingaccountid = {this.Billingaccountid ?? "null"}");
            toStringOutput.Add($"Createdon = {this.Createdon ?? "null"}");
            toStringOutput.Add($"Externalid = {this.Externalid ?? "null"}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Kind = {this.Kind ?? "null"}");
            toStringOutput.Add($"Lastupdated = {this.Lastupdated ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Region = {this.Region ?? "null"}");
            toStringOutput.Add($"Version = {this.Version ?? "null"}");
            toStringOutput.Add($"Versionid = {this.Versionid ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}