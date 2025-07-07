// <copyright file="MismatchedDevice.cs" company="APIMatic">
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
    /// MismatchedDevice.
    /// </summary>
    public class MismatchedDevice
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
        /// Initializes a new instance of the <see cref="MismatchedDevice"/> class.
        /// </summary>
        public MismatchedDevice()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MismatchedDevice"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="mdn">mdn.</param>
        /// <param name="activationDate">activationDate.</param>
        /// <param name="iccid">iccid.</param>
        /// <param name="preImei">preImei.</param>
        /// <param name="postImei">postImei.</param>
        /// <param name="simOtaDate">simOtaDate.</param>
        public MismatchedDevice(
            string accountName = null,
            string mdn = null,
            string activationDate = null,
            string iccid = null,
            string preImei = null,
            string postImei = null,
            string simOtaDate = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountName = accountName;
            this.Mdn = mdn;
            this.ActivationDate = activationDate;
            this.Iccid = iccid;
            this.PreImei = preImei;
            this.PostImei = postImei;
            this.SimOtaDate = simOtaDate;
        }

        /// <summary>
        /// The account that the device is associated with.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The assigned phone number of the device.
        /// </summary>
        [JsonProperty("mdn", NullValueHandling = NullValueHandling.Ignore)]
        public string Mdn { get; set; }

        /// <summary>
        /// The date and time when the SIM was last activated.
        /// </summary>
        [JsonProperty("activationDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivationDate { get; set; }

        /// <summary>
        /// The ID of the SIM.
        /// </summary>
        [JsonProperty("iccid", NullValueHandling = NullValueHandling.Ignore)]
        public string Iccid { get; set; }

        /// <summary>
        /// The IMEI of the device prior to the SIM OTA activation on simOtaDate.
        /// </summary>
        [JsonProperty("preImei", NullValueHandling = NullValueHandling.Ignore)]
        public string PreImei { get; set; }

        /// <summary>
        /// The IMEI of the device after the SIM OTA activation on simOtaDate.
        /// </summary>
        [JsonProperty("postImei", NullValueHandling = NullValueHandling.Ignore)]
        public string PostImei { get; set; }

        /// <summary>
        /// The date and time of the SIM OTA activation.
        /// </summary>
        [JsonProperty("simOtaDate", NullValueHandling = NullValueHandling.Ignore)]
        public string SimOtaDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MismatchedDevice : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is MismatchedDevice other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.Mdn == null && other.Mdn == null ||
                 this.Mdn?.Equals(other.Mdn) == true) &&
                (this.ActivationDate == null && other.ActivationDate == null ||
                 this.ActivationDate?.Equals(other.ActivationDate) == true) &&
                (this.Iccid == null && other.Iccid == null ||
                 this.Iccid?.Equals(other.Iccid) == true) &&
                (this.PreImei == null && other.PreImei == null ||
                 this.PreImei?.Equals(other.PreImei) == true) &&
                (this.PostImei == null && other.PostImei == null ||
                 this.PostImei?.Equals(other.PostImei) == true) &&
                (this.SimOtaDate == null && other.SimOtaDate == null ||
                 this.SimOtaDate?.Equals(other.SimOtaDate) == true) &&
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
            toStringOutput.Add($"Mdn = {this.Mdn ?? "null"}");
            toStringOutput.Add($"ActivationDate = {this.ActivationDate ?? "null"}");
            toStringOutput.Add($"Iccid = {this.Iccid ?? "null"}");
            toStringOutput.Add($"PreImei = {this.PreImei ?? "null"}");
            toStringOutput.Add($"PostImei = {this.PostImei ?? "null"}");
            toStringOutput.Add($"SimOtaDate = {this.SimOtaDate ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}