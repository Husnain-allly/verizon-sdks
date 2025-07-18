// <copyright file="Subscription.cs" company="APIMatic">
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
    /// Subscription.
    /// </summary>
    public class Subscription
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
        /// Initializes a new instance of the <see cref="Subscription"/> class.
        /// </summary>
        public Subscription()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription"/> class.
        /// </summary>
        /// <param name="configurationfailures">configurationfailures.</param>
        /// <param name="createdon">createdon.</param>
        /// <param name="delegateid">delegateid.</param>
        /// <param name="description">description.</param>
        /// <param name="disabled">disabled.</param>
        /// <param name="email">email.</param>
        /// <param name="filter">filter.</param>
        /// <param name="id">id.</param>
        /// <param name="kind">kind.</param>
        /// <param name="laststreamingstatus">laststreamingstatus.</param>
        /// <param name="laststreamingtime">laststreamingtime.</param>
        /// <param name="lastupdated">lastupdated.</param>
        /// <param name="name">name.</param>
        /// <param name="networkfailures">networkfailures.</param>
        /// <param name="streamfailures">streamfailures.</param>
        /// <param name="streamkind">streamkind.</param>
        /// <param name="targetid">targetid.</param>
        /// <param name="targettype">targettype.</param>
        /// <param name="version">version.</param>
        /// <param name="versionid">versionid.</param>
        public Subscription(
            int? configurationfailures = null,
            string createdon = null,
            string delegateid = null,
            string description = null,
            bool? disabled = null,
            string email = null,
            string filter = null,
            string id = null,
            string kind = null,
            string laststreamingstatus = null,
            string laststreamingtime = null,
            string lastupdated = null,
            string name = null,
            int? networkfailures = null,
            int? streamfailures = null,
            string streamkind = null,
            string targetid = null,
            string targettype = null,
            string version = null,
            string versionid = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Configurationfailures = configurationfailures;
            this.Createdon = createdon;
            this.Delegateid = delegateid;
            this.Description = description;
            this.Disabled = disabled;
            this.Email = email;
            this.Filter = filter;
            this.Id = id;
            this.Kind = kind;
            this.Laststreamingstatus = laststreamingstatus;
            this.Laststreamingtime = laststreamingtime;
            this.Lastupdated = lastupdated;
            this.Name = name;
            this.Networkfailures = networkfailures;
            this.Streamfailures = streamfailures;
            this.Streamkind = streamkind;
            this.Targetid = targetid;
            this.Targettype = targettype;
            this.Version = version;
            this.Versionid = versionid;
        }

        /// <summary>
        /// The number of streaming failures due to faulty configuration.
        /// </summary>
        [JsonProperty("configurationfailures", NullValueHandling = NullValueHandling.Ignore)]
        public int? Configurationfailures { get; set; }

        /// <summary>
        /// The number of streaming failures due to faulty configuration.
        /// </summary>
        [JsonProperty("createdon", NullValueHandling = NullValueHandling.Ignore)]
        public string Createdon { get; set; }

        /// <summary>
        /// Not currently used.
        /// </summary>
        [JsonProperty("delegateid", NullValueHandling = NullValueHandling.Ignore)]
        public string Delegateid { get; set; }

        /// <summary>
        /// Description of the subscription.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Whether the subscription is currently sending data.
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// The address to which any error reports should be delivered.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// Filter for events.
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public string Filter { get; set; }

        /// <summary>
        /// ThingSpace unique ID for the subscription that was created.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Identifies the resource kind.
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// Possible values: success or fail.
        /// </summary>
        [JsonProperty("laststreamingstatus", NullValueHandling = NullValueHandling.Ignore)]
        public string Laststreamingstatus { get; set; }

        /// <summary>
        /// The date and time that the last stream send was attempted.
        /// </summary>
        [JsonProperty("laststreamingtime", NullValueHandling = NullValueHandling.Ignore)]
        public string Laststreamingtime { get; set; }

        /// <summary>
        /// The date the resource was last updated.
        /// </summary>
        [JsonProperty("lastupdated", NullValueHandling = NullValueHandling.Ignore)]
        public string Lastupdated { get; set; }

        /// <summary>
        /// Name of the subscription.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The number of failures due to network problems.
        /// </summary>
        [JsonProperty("networkfailures", NullValueHandling = NullValueHandling.Ignore)]
        public int? Networkfailures { get; set; }

        /// <summary>
        /// Gets or sets Streamfailures.
        /// </summary>
        [JsonProperty("streamfailures", NullValueHandling = NullValueHandling.Ignore)]
        public int? Streamfailures { get; set; }

        /// <summary>
        /// The event type that will be sent in the data stream.
        /// </summary>
        [JsonProperty("streamkind", NullValueHandling = NullValueHandling.Ignore)]
        public string Streamkind { get; set; }

        /// <summary>
        /// Target to be used for dispatching events.
        /// </summary>
        [JsonProperty("targetid", NullValueHandling = NullValueHandling.Ignore)]
        public string Targetid { get; set; }

        /// <summary>
        /// Gets or sets Targettype.
        /// </summary>
        [JsonProperty("targettype", NullValueHandling = NullValueHandling.Ignore)]
        public string Targettype { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Subscription : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Subscription other &&
                (this.Configurationfailures == null && other.Configurationfailures == null ||
                 this.Configurationfailures?.Equals(other.Configurationfailures) == true) &&
                (this.Createdon == null && other.Createdon == null ||
                 this.Createdon?.Equals(other.Createdon) == true) &&
                (this.Delegateid == null && other.Delegateid == null ||
                 this.Delegateid?.Equals(other.Delegateid) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Disabled == null && other.Disabled == null ||
                 this.Disabled?.Equals(other.Disabled) == true) &&
                (this.Email == null && other.Email == null ||
                 this.Email?.Equals(other.Email) == true) &&
                (this.Filter == null && other.Filter == null ||
                 this.Filter?.Equals(other.Filter) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Kind == null && other.Kind == null ||
                 this.Kind?.Equals(other.Kind) == true) &&
                (this.Laststreamingstatus == null && other.Laststreamingstatus == null ||
                 this.Laststreamingstatus?.Equals(other.Laststreamingstatus) == true) &&
                (this.Laststreamingtime == null && other.Laststreamingtime == null ||
                 this.Laststreamingtime?.Equals(other.Laststreamingtime) == true) &&
                (this.Lastupdated == null && other.Lastupdated == null ||
                 this.Lastupdated?.Equals(other.Lastupdated) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Networkfailures == null && other.Networkfailures == null ||
                 this.Networkfailures?.Equals(other.Networkfailures) == true) &&
                (this.Streamfailures == null && other.Streamfailures == null ||
                 this.Streamfailures?.Equals(other.Streamfailures) == true) &&
                (this.Streamkind == null && other.Streamkind == null ||
                 this.Streamkind?.Equals(other.Streamkind) == true) &&
                (this.Targetid == null && other.Targetid == null ||
                 this.Targetid?.Equals(other.Targetid) == true) &&
                (this.Targettype == null && other.Targettype == null ||
                 this.Targettype?.Equals(other.Targettype) == true) &&
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
            toStringOutput.Add($"Configurationfailures = {(this.Configurationfailures == null ? "null" : this.Configurationfailures.ToString())}");
            toStringOutput.Add($"Createdon = {this.Createdon ?? "null"}");
            toStringOutput.Add($"Delegateid = {this.Delegateid ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Disabled = {(this.Disabled == null ? "null" : this.Disabled.ToString())}");
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"Filter = {this.Filter ?? "null"}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Kind = {this.Kind ?? "null"}");
            toStringOutput.Add($"Laststreamingstatus = {this.Laststreamingstatus ?? "null"}");
            toStringOutput.Add($"Laststreamingtime = {this.Laststreamingtime ?? "null"}");
            toStringOutput.Add($"Lastupdated = {this.Lastupdated ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Networkfailures = {(this.Networkfailures == null ? "null" : this.Networkfailures.ToString())}");
            toStringOutput.Add($"Streamfailures = {(this.Streamfailures == null ? "null" : this.Streamfailures.ToString())}");
            toStringOutput.Add($"Streamkind = {this.Streamkind ?? "null"}");
            toStringOutput.Add($"Targetid = {this.Targetid ?? "null"}");
            toStringOutput.Add($"Targettype = {this.Targettype ?? "null"}");
            toStringOutput.Add($"Version = {this.Version ?? "null"}");
            toStringOutput.Add($"Versionid = {this.Versionid ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}