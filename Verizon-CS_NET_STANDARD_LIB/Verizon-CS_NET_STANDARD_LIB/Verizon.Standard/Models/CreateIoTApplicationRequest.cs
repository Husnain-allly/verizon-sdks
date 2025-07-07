// <copyright file="CreateIoTApplicationRequest.cs" company="APIMatic">
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
    /// CreateIoTApplicationRequest.
    /// </summary>
    public class CreateIoTApplicationRequest
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
        /// Initializes a new instance of the <see cref="CreateIoTApplicationRequest"/> class.
        /// </summary>
        public CreateIoTApplicationRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIoTApplicationRequest"/> class.
        /// </summary>
        /// <param name="appName">appName.</param>
        /// <param name="billingAccountId">billingAccountID.</param>
        /// <param name="clientId">clientID.</param>
        /// <param name="clientSecret">clientSecret.</param>
        /// <param name="emailIDs">emailIDs.</param>
        /// <param name="resourcegroup">resourcegroup.</param>
        /// <param name="sampleIoTcApp">sampleIOTcApp.</param>
        /// <param name="subscriptionId">subscriptionID.</param>
        /// <param name="tenantId">tenantID.</param>
        public CreateIoTApplicationRequest(
            string appName = null,
            string billingAccountId = null,
            string clientId = null,
            string clientSecret = null,
            string emailIDs = null,
            string resourcegroup = null,
            string sampleIoTcApp = null,
            string subscriptionId = null,
            string tenantId = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AppName = appName;
            this.BillingAccountId = billingAccountId;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.EmailIDs = emailIDs;
            this.Resourcegroup = resourcegroup;
            this.SampleIoTcApp = sampleIoTcApp;
            this.SubscriptionId = subscriptionId;
            this.TenantId = tenantId;
        }

        /// <summary>
        /// A user defined name for the application being deployed in Azure IoT Central.
        /// </summary>
        [JsonProperty("appName", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// The ThingSpace ID of the authenticating billing account
        /// </summary>
        [JsonProperty("billingAccountID", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingAccountId { get; set; }

        /// <summary>
        /// The Azure ClientID of the associated Azure target account
        /// </summary>
        [JsonProperty("clientID", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        /// <summary>
        /// The Azure Client Secret of the associated Azure target account
        /// </summary>
        [JsonProperty("clientSecret", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The “email IDs” to be added to/sent to with this API.
        /// </summary>
        [JsonProperty("emailIDs", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailIDs { get; set; }

        /// <summary>
        /// The Azure Resource group of the associated Azure target account
        /// </summary>
        [JsonProperty("resourcegroup", NullValueHandling = NullValueHandling.Ignore)]
        public string Resourcegroup { get; set; }

        /// <summary>
        /// This is the reference Azure IoT Central application developed by Verizon.
        /// </summary>
        [JsonProperty("sampleIOTcApp", NullValueHandling = NullValueHandling.Ignore)]
        public string SampleIoTcApp { get; set; }

        /// <summary>
        /// The Azure Subscription ID of the associated Azure target account
        /// </summary>
        [JsonProperty("subscriptionID", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The Azure Tenant ID of the associated Azure target account
        /// </summary>
        [JsonProperty("tenantID", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateIoTApplicationRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateIoTApplicationRequest other &&
                (this.AppName == null && other.AppName == null ||
                 this.AppName?.Equals(other.AppName) == true) &&
                (this.BillingAccountId == null && other.BillingAccountId == null ||
                 this.BillingAccountId?.Equals(other.BillingAccountId) == true) &&
                (this.ClientId == null && other.ClientId == null ||
                 this.ClientId?.Equals(other.ClientId) == true) &&
                (this.ClientSecret == null && other.ClientSecret == null ||
                 this.ClientSecret?.Equals(other.ClientSecret) == true) &&
                (this.EmailIDs == null && other.EmailIDs == null ||
                 this.EmailIDs?.Equals(other.EmailIDs) == true) &&
                (this.Resourcegroup == null && other.Resourcegroup == null ||
                 this.Resourcegroup?.Equals(other.Resourcegroup) == true) &&
                (this.SampleIoTcApp == null && other.SampleIoTcApp == null ||
                 this.SampleIoTcApp?.Equals(other.SampleIoTcApp) == true) &&
                (this.SubscriptionId == null && other.SubscriptionId == null ||
                 this.SubscriptionId?.Equals(other.SubscriptionId) == true) &&
                (this.TenantId == null && other.TenantId == null ||
                 this.TenantId?.Equals(other.TenantId) == true) &&
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
            toStringOutput.Add($"AppName = {this.AppName ?? "null"}");
            toStringOutput.Add($"BillingAccountId = {this.BillingAccountId ?? "null"}");
            toStringOutput.Add($"ClientId = {this.ClientId ?? "null"}");
            toStringOutput.Add($"ClientSecret = {this.ClientSecret ?? "null"}");
            toStringOutput.Add($"EmailIDs = {this.EmailIDs ?? "null"}");
            toStringOutput.Add($"Resourcegroup = {this.Resourcegroup ?? "null"}");
            toStringOutput.Add($"SampleIoTcApp = {this.SampleIoTcApp ?? "null"}");
            toStringOutput.Add($"SubscriptionId = {this.SubscriptionId ?? "null"}");
            toStringOutput.Add($"TenantId = {this.TenantId ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}