// <copyright file="UsageHistory.cs" company="APIMatic">
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
    /// UsageHistory.
    /// </summary>
    public class UsageHistory
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
        /// Initializes a new instance of the <see cref="UsageHistory"/> class.
        /// </summary>
        public UsageHistory()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageHistory"/> class.
        /// </summary>
        /// <param name="bytesUsed">bytesUsed.</param>
        /// <param name="serviceplan">serviceplan.</param>
        /// <param name="smsUsed">smsUsed.</param>
        /// <param name="moSms">moSMS.</param>
        /// <param name="mtSms">mtSMS.</param>
        /// <param name="source">source.</param>
        /// <param name="eventDateTime">eventDateTime.</param>
        public UsageHistory(
            int? bytesUsed = null,
            string serviceplan = null,
            int? smsUsed = null,
            int? moSms = null,
            int? mtSms = null,
            string source = null,
            DateTime? eventDateTime = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.BytesUsed = bytesUsed;
            this.Serviceplan = serviceplan;
            this.SmsUsed = smsUsed;
            this.MoSms = moSms;
            this.MtSms = mtSms;
            this.Source = source;
            this.EventDateTime = eventDateTime;
        }

        /// <summary>
        /// Gets or sets BytesUsed.
        /// </summary>
        [JsonProperty("bytesUsed", NullValueHandling = NullValueHandling.Ignore)]
        public int? BytesUsed { get; set; }

        /// <summary>
        /// Gets or sets Serviceplan.
        /// </summary>
        [JsonProperty("serviceplan", NullValueHandling = NullValueHandling.Ignore)]
        public string Serviceplan { get; set; }

        /// <summary>
        /// Gets or sets SmsUsed.
        /// </summary>
        [JsonProperty("smsUsed", NullValueHandling = NullValueHandling.Ignore)]
        public int? SmsUsed { get; set; }

        /// <summary>
        /// Gets or sets MoSms.
        /// </summary>
        [JsonProperty("moSMS", NullValueHandling = NullValueHandling.Ignore)]
        public int? MoSms { get; set; }

        /// <summary>
        /// Gets or sets MtSms.
        /// </summary>
        [JsonProperty("mtSMS", NullValueHandling = NullValueHandling.Ignore)]
        public int? MtSms { get; set; }

        /// <summary>
        /// Gets or sets Source.
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets EventDateTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("eventDateTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EventDateTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UsageHistory : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UsageHistory other &&
                (this.BytesUsed == null && other.BytesUsed == null ||
                 this.BytesUsed?.Equals(other.BytesUsed) == true) &&
                (this.Serviceplan == null && other.Serviceplan == null ||
                 this.Serviceplan?.Equals(other.Serviceplan) == true) &&
                (this.SmsUsed == null && other.SmsUsed == null ||
                 this.SmsUsed?.Equals(other.SmsUsed) == true) &&
                (this.MoSms == null && other.MoSms == null ||
                 this.MoSms?.Equals(other.MoSms) == true) &&
                (this.MtSms == null && other.MtSms == null ||
                 this.MtSms?.Equals(other.MtSms) == true) &&
                (this.Source == null && other.Source == null ||
                 this.Source?.Equals(other.Source) == true) &&
                (this.EventDateTime == null && other.EventDateTime == null ||
                 this.EventDateTime?.Equals(other.EventDateTime) == true) &&
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
            toStringOutput.Add($"BytesUsed = {(this.BytesUsed == null ? "null" : this.BytesUsed.ToString())}");
            toStringOutput.Add($"Serviceplan = {this.Serviceplan ?? "null"}");
            toStringOutput.Add($"SmsUsed = {(this.SmsUsed == null ? "null" : this.SmsUsed.ToString())}");
            toStringOutput.Add($"MoSms = {(this.MoSms == null ? "null" : this.MoSms.ToString())}");
            toStringOutput.Add($"MtSms = {(this.MtSms == null ? "null" : this.MtSms.ToString())}");
            toStringOutput.Add($"Source = {this.Source ?? "null"}");
            toStringOutput.Add($"EventDateTime = {(this.EventDateTime == null ? "null" : this.EventDateTime.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}