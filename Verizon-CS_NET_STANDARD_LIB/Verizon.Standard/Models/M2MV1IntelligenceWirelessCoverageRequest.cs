// <copyright file="M2MV1IntelligenceWirelessCoverageRequest.cs" company="APIMatic">
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
    /// M2MV1IntelligenceWirelessCoverageRequest.
    /// </summary>
    public class M2MV1IntelligenceWirelessCoverageRequest
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
        /// Initializes a new instance of the <see cref="M2MV1IntelligenceWirelessCoverageRequest"/> class.
        /// </summary>
        public M2MV1IntelligenceWirelessCoverageRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="M2MV1IntelligenceWirelessCoverageRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="requestType">requestType.</param>
        /// <param name="locationType">locationType.</param>
        /// <param name="locations">locations.</param>
        /// <param name="networkTypesList">networkTypesList.</param>
        public M2MV1IntelligenceWirelessCoverageRequest(
            string accountName = null,
            string requestType = null,
            string locationType = null,
            Models.Locations1 locations = null,
            List<Models.NetworkTypeObject> networkTypesList = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountName = accountName;
            this.RequestType = requestType;
            this.LocationType = locationType;
            this.Locations = locations;
            this.NetworkTypesList = networkTypesList;
        }

        /// <summary>
        /// Account name.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Type of request made. FWA for address qualification and NW for Nationwide coverage.
        /// </summary>
        [JsonProperty("requestType", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestType { get; set; }

        /// <summary>
        /// Type of location detail.
        /// </summary>
        [JsonProperty("locationType", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationType { get; set; }

        /// <summary>
        /// Gets or sets Locations.
        /// </summary>
        [JsonProperty("locations", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Locations1 Locations { get; set; }

        /// <summary>
        /// Gets or sets NetworkTypesList.
        /// </summary>
        [JsonProperty("networkTypesList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.NetworkTypeObject> NetworkTypesList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"M2MV1IntelligenceWirelessCoverageRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is M2MV1IntelligenceWirelessCoverageRequest other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.RequestType == null && other.RequestType == null ||
                 this.RequestType?.Equals(other.RequestType) == true) &&
                (this.LocationType == null && other.LocationType == null ||
                 this.LocationType?.Equals(other.LocationType) == true) &&
                (this.Locations == null && other.Locations == null ||
                 this.Locations?.Equals(other.Locations) == true) &&
                (this.NetworkTypesList == null && other.NetworkTypesList == null ||
                 this.NetworkTypesList?.Equals(other.NetworkTypesList) == true) &&
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
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"RequestType = {this.RequestType ?? "null"}");
            toStringOutput.Add($"LocationType = {this.LocationType ?? "null"}");
            toStringOutput.Add($"Locations = {(this.Locations == null ? "null" : this.Locations.ToString())}");
            toStringOutput.Add($"NetworkTypesList = {(this.NetworkTypesList == null ? "null" : $"[{string.Join(", ", this.NetworkTypesList)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}