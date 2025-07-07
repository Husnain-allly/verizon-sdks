// <copyright file="UsageTriggerUpdateRequest.cs" company="APIMatic">
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
    /// UsageTriggerUpdateRequest.
    /// </summary>
    public class UsageTriggerUpdateRequest
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
        /// Initializes a new instance of the <see cref="UsageTriggerUpdateRequest"/> class.
        /// </summary>
        public UsageTriggerUpdateRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTriggerUpdateRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="triggerName">triggerName.</param>
        /// <param name="thresholdValue">thresholdValue.</param>
        /// <param name="smsPhoneNumbers">smsPhoneNumbers.</param>
        /// <param name="emailAddresses">emailAddresses.</param>
        public UsageTriggerUpdateRequest(
            string accountName,
            string triggerName = null,
            string thresholdValue = null,
            string smsPhoneNumbers = null,
            string emailAddresses = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.TriggerName = triggerName;
            this.AccountName = accountName;
            this.ThresholdValue = thresholdValue;
            this.SmsPhoneNumbers = smsPhoneNumbers;
            this.EmailAddresses = emailAddresses;
        }

        /// <summary>
        /// Usage trigger name
        /// </summary>
        [JsonProperty("triggerName", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerName { get; set; }

        /// <summary>
        /// Account name
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// The percent of subscribed usage required to activate the trigger, such as 90 or 100.
        /// </summary>
        [JsonProperty("thresholdValue", NullValueHandling = NullValueHandling.Ignore)]
        public string ThresholdValue { get; set; }

        /// <summary>
        /// Comma-separated list of phone numbers to send SMS alerts to. Digits only; no dashes or parentheses, etc.
        /// </summary>
        [JsonProperty("smsPhoneNumbers", NullValueHandling = NullValueHandling.Ignore)]
        public string SmsPhoneNumbers { get; set; }

        /// <summary>
        /// Comma-separated list of email addresses to send alerts to.
        /// </summary>
        [JsonProperty("emailAddresses", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddresses { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UsageTriggerUpdateRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UsageTriggerUpdateRequest other &&
                (this.TriggerName == null && other.TriggerName == null ||
                 this.TriggerName?.Equals(other.TriggerName) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.ThresholdValue == null && other.ThresholdValue == null ||
                 this.ThresholdValue?.Equals(other.ThresholdValue) == true) &&
                (this.SmsPhoneNumbers == null && other.SmsPhoneNumbers == null ||
                 this.SmsPhoneNumbers?.Equals(other.SmsPhoneNumbers) == true) &&
                (this.EmailAddresses == null && other.EmailAddresses == null ||
                 this.EmailAddresses?.Equals(other.EmailAddresses) == true) &&
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
            toStringOutput.Add($"TriggerName = {this.TriggerName ?? "null"}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"ThresholdValue = {this.ThresholdValue ?? "null"}");
            toStringOutput.Add($"SmsPhoneNumbers = {this.SmsPhoneNumbers ?? "null"}");
            toStringOutput.Add($"EmailAddresses = {this.EmailAddresses ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}