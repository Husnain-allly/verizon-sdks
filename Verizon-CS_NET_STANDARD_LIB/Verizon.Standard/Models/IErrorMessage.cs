// <copyright file="IErrorMessage.cs" company="APIMatic">
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
    /// IErrorMessage.
    /// </summary>
    public class IErrorMessage
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
        /// Initializes a new instance of the <see cref="IErrorMessage"/> class.
        /// </summary>
        public IErrorMessage()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IErrorMessage"/> class.
        /// </summary>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        /// <param name="detailErrorMessage">detailErrorMessage.</param>
        public IErrorMessage(
            Models.ErrorResponseCode? errorCode = null,
            string errorMessage = null,
            Models.HttpStatusCode? httpStatusCode = null,
            string detailErrorMessage = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.HttpStatusCode = httpStatusCode;
            this.DetailErrorMessage = detailErrorMessage;
        }

        /// <summary>
        /// Error Code.
        /// </summary>
        [JsonProperty("errorCode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorResponseCode? ErrorCode { get; set; }

        /// <summary>
        /// Details and additional information about the error code.
        /// </summary>
        [JsonProperty("errorMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// HTML error code and description.
        /// </summary>
        [JsonProperty("httpStatusCode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.HttpStatusCode? HttpStatusCode { get; set; }

        /// <summary>
        /// More detail and information about the HTML error code.
        /// </summary>
        [JsonProperty("detailErrorMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string DetailErrorMessage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"IErrorMessage : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is IErrorMessage other &&
                (this.ErrorCode == null && other.ErrorCode == null ||
                 this.ErrorCode?.Equals(other.ErrorCode) == true) &&
                (this.ErrorMessage == null && other.ErrorMessage == null ||
                 this.ErrorMessage?.Equals(other.ErrorMessage) == true) &&
                (this.HttpStatusCode == null && other.HttpStatusCode == null ||
                 this.HttpStatusCode?.Equals(other.HttpStatusCode) == true) &&
                (this.DetailErrorMessage == null && other.DetailErrorMessage == null ||
                 this.DetailErrorMessage?.Equals(other.DetailErrorMessage) == true) &&
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
            toStringOutput.Add($"ErrorCode = {(this.ErrorCode == null ? "null" : this.ErrorCode.ToString())}");
            toStringOutput.Add($"ErrorMessage = {this.ErrorMessage ?? "null"}");
            toStringOutput.Add($"HttpStatusCode = {(this.HttpStatusCode == null ? "null" : this.HttpStatusCode.ToString())}");
            toStringOutput.Add($"DetailErrorMessage = {this.DetailErrorMessage ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}