// <copyright file="UpgradeListQueryResult.cs" company="APIMatic">
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
    /// UpgradeListQueryResult.
    /// </summary>
    public class UpgradeListQueryResult
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

        private List<Models.FirmwareUpgrade> reportList;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "reportList", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeListQueryResult"/> class.
        /// </summary>
        public UpgradeListQueryResult()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeListQueryResult"/> class.
        /// </summary>
        /// <param name="hasMoreFlag">hasMoreFlag.</param>
        /// <param name="lastSeenUpgradeId">lastSeenUpgradeId.</param>
        /// <param name="reportList">reportList.</param>
        public UpgradeListQueryResult(
            bool? hasMoreFlag = null,
            int? lastSeenUpgradeId = null,
            List<Models.FirmwareUpgrade> reportList = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.HasMoreFlag = hasMoreFlag;
            this.LastSeenUpgradeId = lastSeenUpgradeId;

            if (reportList != null)
            {
                this.ReportList = reportList;
            }
        }

        /// <summary>
        /// True if there are more devices to retrieve.
        /// </summary>
        [JsonProperty("hasMoreFlag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMoreFlag { get; set; }

        /// <summary>
        /// If hasMoreData=true, the startIndex to use for the next request. 0 if hasMoreData=false.
        /// </summary>
        [JsonProperty("lastSeenUpgradeId", NullValueHandling = NullValueHandling.Ignore)]
        public int? LastSeenUpgradeId { get; set; }

        /// <summary>
        /// Array of upgrade objects with the specified status.
        /// </summary>
        [JsonProperty("reportList")]
        public List<Models.FirmwareUpgrade> ReportList
        {
            get
            {
                return this.reportList;
            }

            set
            {
                this.shouldSerialize["reportList"] = true;
                this.reportList = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpgradeListQueryResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetReportList()
        {
            this.shouldSerialize["reportList"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReportList()
        {
            return this.shouldSerialize["reportList"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpgradeListQueryResult other &&
                (this.HasMoreFlag == null && other.HasMoreFlag == null ||
                 this.HasMoreFlag?.Equals(other.HasMoreFlag) == true) &&
                (this.LastSeenUpgradeId == null && other.LastSeenUpgradeId == null ||
                 this.LastSeenUpgradeId?.Equals(other.LastSeenUpgradeId) == true) &&
                (this.ReportList == null && other.ReportList == null ||
                 this.ReportList?.Equals(other.ReportList) == true) &&
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
            toStringOutput.Add($"HasMoreFlag = {(this.HasMoreFlag == null ? "null" : this.HasMoreFlag.ToString())}");
            toStringOutput.Add($"LastSeenUpgradeId = {(this.LastSeenUpgradeId == null ? "null" : this.LastSeenUpgradeId.ToString())}");
            toStringOutput.Add($"ReportList = {(this.ReportList == null ? "null" : $"[{string.Join(", ", this.ReportList)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}