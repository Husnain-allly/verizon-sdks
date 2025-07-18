// <copyright file="SessionReportRequest.cs" company="APIMatic">
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
    /// SessionReportRequest.
    /// </summary>
    public class SessionReportRequest
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

        private int? durationLow;
        private int? durationHigh;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "durationLow", false },
            { "durationHigh", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionReportRequest"/> class.
        /// </summary>
        public SessionReportRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionReportRequest"/> class.
        /// </summary>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="imei">imei.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="durationLow">durationLow.</param>
        /// <param name="durationHigh">durationHigh.</param>
        public SessionReportRequest(
            string accountNumber,
            string imei,
            string startDate = null,
            string endDate = null,
            int? durationLow = null,
            int? durationHigh = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountNumber = accountNumber;
            this.Imei = imei;
            this.StartDate = startDate;
            this.EndDate = endDate;

            if (durationLow != null)
            {
                this.DurationLow = durationLow;
            }

            if (durationHigh != null)
            {
                this.DurationHigh = durationHigh;
            }
        }

        /// <summary>
        /// Account Number.
        /// </summary>
        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Device ids.
        /// </summary>
        [JsonProperty("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// Start date of session to include. If not specified  information will be shown from the earliest available (180 days). Can be either date in ISO 8601 format or predefined constants.
        /// </summary>
        [JsonProperty("startDate", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// End date of session to include. If not specified  information will be shown to the latest available. Can be either date in ISO 8601 format or predefined constants.
        /// </summary>
        [JsonProperty("endDate", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// The Low value of session duration.
        /// </summary>
        [JsonProperty("durationLow")]
        public int? DurationLow
        {
            get
            {
                return this.durationLow;
            }

            set
            {
                this.shouldSerialize["durationLow"] = true;
                this.durationLow = value;
            }
        }

        /// <summary>
        /// The High value of session duration.
        /// </summary>
        [JsonProperty("durationHigh")]
        public int? DurationHigh
        {
            get
            {
                return this.durationHigh;
            }

            set
            {
                this.shouldSerialize["durationHigh"] = true;
                this.durationHigh = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SessionReportRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDurationLow()
        {
            this.shouldSerialize["durationLow"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDurationHigh()
        {
            this.shouldSerialize["durationHigh"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDurationLow()
        {
            return this.shouldSerialize["durationLow"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDurationHigh()
        {
            return this.shouldSerialize["durationHigh"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SessionReportRequest other &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.Imei == null && other.Imei == null ||
                 this.Imei?.Equals(other.Imei) == true) &&
                (this.StartDate == null && other.StartDate == null ||
                 this.StartDate?.Equals(other.StartDate) == true) &&
                (this.EndDate == null && other.EndDate == null ||
                 this.EndDate?.Equals(other.EndDate) == true) &&
                (this.DurationLow == null && other.DurationLow == null ||
                 this.DurationLow?.Equals(other.DurationLow) == true) &&
                (this.DurationHigh == null && other.DurationHigh == null ||
                 this.DurationHigh?.Equals(other.DurationHigh) == true) &&
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
            toStringOutput.Add($"AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"Imei = {this.Imei ?? "null"}");
            toStringOutput.Add($"StartDate = {this.StartDate ?? "null"}");
            toStringOutput.Add($"EndDate = {this.EndDate ?? "null"}");
            toStringOutput.Add($"DurationLow = {(this.DurationLow == null ? "null" : this.DurationLow.ToString())}");
            toStringOutput.Add($"DurationHigh = {(this.DurationHigh == null ? "null" : this.DurationHigh.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}