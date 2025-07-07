// <copyright file="Engagement.cs" company="APIMatic">
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
    /// Engagement.
    /// </summary>
    public class Engagement
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
        /// Initializes a new instance of the <see cref="Engagement"/> class.
        /// </summary>
        public Engagement()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Engagement"/> class.
        /// </summary>
        /// <param name="engagementId">engagementId.</param>
        /// <param name="chargingGroup">chargingGroup.</param>
        /// <param name="services">services.</param>
        public Engagement(
            string engagementId = null,
            string chargingGroup = null,
            List<Models.AccountService> services = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.EngagementId = engagementId;
            this.ChargingGroup = chargingGroup;
            this.Services = services;
        }

        /// <summary>
        /// The engagement ID.
        /// </summary>
        [JsonProperty("engagementId", NullValueHandling = NullValueHandling.Ignore)]
        public string EngagementId { get; set; }

        /// <summary>
        /// The charging group name.
        /// </summary>
        [JsonProperty("chargingGroup", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargingGroup { get; set; }

        /// <summary>
        /// The services associated with the account.
        /// </summary>
        [JsonProperty("services", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AccountService> Services { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Engagement : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Engagement other &&
                (this.EngagementId == null && other.EngagementId == null ||
                 this.EngagementId?.Equals(other.EngagementId) == true) &&
                (this.ChargingGroup == null && other.ChargingGroup == null ||
                 this.ChargingGroup?.Equals(other.ChargingGroup) == true) &&
                (this.Services == null && other.Services == null ||
                 this.Services?.Equals(other.Services) == true) &&
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
            toStringOutput.Add($"EngagementId = {this.EngagementId ?? "null"}");
            toStringOutput.Add($"ChargingGroup = {this.ChargingGroup ?? "null"}");
            toStringOutput.Add($"Services = {(this.Services == null ? "null" : $"[{string.Join(", ", this.Services)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}