// <copyright file="ConnectivityManagementCallback.cs" company="APIMatic">
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
    /// ConnectivityManagementCallback.
    /// </summary>
    public class ConnectivityManagementCallback
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
        /// Initializes a new instance of the <see cref="ConnectivityManagementCallback"/> class.
        /// </summary>
        public ConnectivityManagementCallback()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectivityManagementCallback"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="password">password.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="url">url.</param>
        /// <param name="username">username.</param>
        public ConnectivityManagementCallback(
            string accountName = null,
            string password = null,
            string serviceName = null,
            string url = null,
            string username = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountName = accountName;
            this.Password = password;
            this.ServiceName = serviceName;
            this.Url = url;
            this.Username = username;
        }

        /// <summary>
        /// The name of the billing account for which callback messages will be sent.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The password defined when a URL was registered for the callback service, or an empty string if no password was defined.
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL.
        /// </summary>
        [JsonProperty("serviceName", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// The address of the callback listening service where the ThingSpace Platform will send callback messages for the service type.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// The username defined when a URL was registered for the callback service, or an empty string if no username was defined.
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ConnectivityManagementCallback : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ConnectivityManagementCallback other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.Password == null && other.Password == null ||
                 this.Password?.Equals(other.Password) == true) &&
                (this.ServiceName == null && other.ServiceName == null ||
                 this.ServiceName?.Equals(other.ServiceName) == true) &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true) &&
                (this.Username == null && other.Username == null ||
                 this.Username?.Equals(other.Username) == true) &&
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
            toStringOutput.Add($"Password = {this.Password ?? "null"}");
            toStringOutput.Add($"ServiceName = {this.ServiceName ?? "null"}");
            toStringOutput.Add($"Url = {this.Url ?? "null"}");
            toStringOutput.Add($"Username = {this.Username ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}