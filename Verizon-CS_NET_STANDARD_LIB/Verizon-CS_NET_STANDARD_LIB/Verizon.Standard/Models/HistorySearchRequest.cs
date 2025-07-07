// <copyright file="HistorySearchRequest.cs" company="APIMatic">
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
    /// HistorySearchRequest.
    /// </summary>
    public class HistorySearchRequest
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
        /// Initializes a new instance of the <see cref="HistorySearchRequest"/> class.
        /// </summary>
        public HistorySearchRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistorySearchRequest"/> class.
        /// </summary>
        /// <param name="mFilter">$filter.</param>
        /// <param name="mLimitNumber">$limitNumber.</param>
        /// <param name="mLimitTime">$limitTime.</param>
        /// <param name="mPage">$page.</param>
        public HistorySearchRequest(
            Models.HistorySearchFilter mFilter,
            int? mLimitNumber = null,
            Models.HistorySearchLimitTime mLimitTime = null,
            string mPage = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.MFilter = mFilter;
            this.MLimitNumber = mLimitNumber;
            this.MLimitTime = mLimitTime;
            this.MPage = mPage;
        }

        /// <summary>
        /// The selected device and attributes for which a request should retrieve data.
        /// </summary>
        [JsonProperty("$filter")]
        public Models.HistorySearchFilter MFilter { get; set; }

        /// <summary>
        /// The maximum number of historical attributes to include in the response. If the request matches more than this number of attributes, the response will contain an X-Next value in the header that can be used as the page value in the next request to retrieve the next page of events.
        /// </summary>
        [JsonProperty("$limitNumber", NullValueHandling = NullValueHandling.Ignore)]
        public int? MLimitNumber { get; set; }

        /// <summary>
        /// The time period for which a request should retrieve data, beginning with the limitTime.startOn and proceeding with the limitTime.duration.
        /// </summary>
        [JsonProperty("$limitTime", NullValueHandling = NullValueHandling.Ignore)]
        public Models.HistorySearchLimitTime MLimitTime { get; set; }

        /// <summary>
        /// Page number for pagination purposes.
        /// </summary>
        [JsonProperty("$page", NullValueHandling = NullValueHandling.Ignore)]
        public string MPage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"HistorySearchRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is HistorySearchRequest other &&
                (this.MFilter == null && other.MFilter == null ||
                 this.MFilter?.Equals(other.MFilter) == true) &&
                (this.MLimitNumber == null && other.MLimitNumber == null ||
                 this.MLimitNumber?.Equals(other.MLimitNumber) == true) &&
                (this.MLimitTime == null && other.MLimitTime == null ||
                 this.MLimitTime?.Equals(other.MLimitTime) == true) &&
                (this.MPage == null && other.MPage == null ||
                 this.MPage?.Equals(other.MPage) == true) &&
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
            toStringOutput.Add($"MFilter = {(this.MFilter == null ? "null" : this.MFilter.ToString())}");
            toStringOutput.Add($"MLimitNumber = {(this.MLimitNumber == null ? "null" : this.MLimitNumber.ToString())}");
            toStringOutput.Add($"MLimitTime = {(this.MLimitTime == null ? "null" : this.MLimitTime.ToString())}");
            toStringOutput.Add($"MPage = {this.MPage ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}