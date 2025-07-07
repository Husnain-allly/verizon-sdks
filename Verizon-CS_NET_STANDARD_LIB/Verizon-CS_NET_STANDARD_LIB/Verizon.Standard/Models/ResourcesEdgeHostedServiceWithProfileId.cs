// <copyright file="ResourcesEdgeHostedServiceWithProfileId.cs" company="APIMatic">
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
    /// ResourcesEdgeHostedServiceWithProfileId.
    /// </summary>
    public class ResourcesEdgeHostedServiceWithProfileId
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
        /// Initializes a new instance of the <see cref="ResourcesEdgeHostedServiceWithProfileId"/> class.
        /// </summary>
        public ResourcesEdgeHostedServiceWithProfileId()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesEdgeHostedServiceWithProfileId"/> class.
        /// </summary>
        /// <param name="ern">ern.</param>
        /// <param name="serviceEndpoint">serviceEndpoint.</param>
        /// <param name="applicationServerProviderId">applicationServerProviderId.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="serviceDescription">serviceDescription.</param>
        /// <param name="serviceProfileId">serviceProfileID.</param>
        public ResourcesEdgeHostedServiceWithProfileId(
            string ern = null,
            Models.ResourcesServiceEndpoint serviceEndpoint = null,
            string applicationServerProviderId = null,
            string applicationId = null,
            string serviceDescription = null,
            string serviceProfileId = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Ern = ern;
            this.ServiceEndpoint = serviceEndpoint;
            this.ApplicationServerProviderId = applicationServerProviderId;
            this.ApplicationId = applicationId;
            this.ServiceDescription = serviceDescription;
            this.ServiceProfileId = serviceProfileId;
        }

        /// <summary>
        /// Edge Resource Name. A string identifier for a set of edge resources.
        /// </summary>
        [JsonProperty("ern", NullValueHandling = NullValueHandling.Ignore)]
        public string Ern { get; set; }

        /// <summary>
        /// Service Endpoint path, address, and port.
        /// </summary>
        [JsonProperty("serviceEndpoint", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResourcesServiceEndpoint ServiceEndpoint { get; set; }

        /// <summary>
        /// Unique ID representing the Edge Application Provider.
        /// </summary>
        [JsonProperty("applicationServerProviderId", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationServerProviderId { get; set; }

        /// <summary>
        /// Unique ID representing the Edge Application.
        /// </summary>
        [JsonProperty("applicationId", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets ServiceDescription.
        /// </summary>
        [JsonProperty("serviceDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceDescription { get; set; }

        /// <summary>
        /// The system assigned ID of the service profile.
        /// </summary>
        [JsonProperty("serviceProfileID", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceProfileId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ResourcesEdgeHostedServiceWithProfileId : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ResourcesEdgeHostedServiceWithProfileId other &&
                (this.Ern == null && other.Ern == null ||
                 this.Ern?.Equals(other.Ern) == true) &&
                (this.ServiceEndpoint == null && other.ServiceEndpoint == null ||
                 this.ServiceEndpoint?.Equals(other.ServiceEndpoint) == true) &&
                (this.ApplicationServerProviderId == null && other.ApplicationServerProviderId == null ||
                 this.ApplicationServerProviderId?.Equals(other.ApplicationServerProviderId) == true) &&
                (this.ApplicationId == null && other.ApplicationId == null ||
                 this.ApplicationId?.Equals(other.ApplicationId) == true) &&
                (this.ServiceDescription == null && other.ServiceDescription == null ||
                 this.ServiceDescription?.Equals(other.ServiceDescription) == true) &&
                (this.ServiceProfileId == null && other.ServiceProfileId == null ||
                 this.ServiceProfileId?.Equals(other.ServiceProfileId) == true) &&
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
            toStringOutput.Add($"Ern = {this.Ern ?? "null"}");
            toStringOutput.Add($"ServiceEndpoint = {(this.ServiceEndpoint == null ? "null" : this.ServiceEndpoint.ToString())}");
            toStringOutput.Add($"ApplicationServerProviderId = {this.ApplicationServerProviderId ?? "null"}");
            toStringOutput.Add($"ApplicationId = {this.ApplicationId ?? "null"}");
            toStringOutput.Add($"ServiceDescription = {this.ServiceDescription ?? "null"}");
            toStringOutput.Add($"ServiceProfileId = {this.ServiceProfileId ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}