// <copyright file="DtoBulkUpdate.cs" company="APIMatic">
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
    /// DtoBulkUpdate.
    /// </summary>
    public class DtoBulkUpdate
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
        /// Initializes a new instance of the <see cref="DtoBulkUpdate"/> class.
        /// </summary>
        public DtoBulkUpdate()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoBulkUpdate"/> class.
        /// </summary>
        /// <param name="accountname">accountname.</param>
        /// <param name="resourceidentifiers">resourceidentifiers.</param>
        /// <param name="smartalert">smartalert.</param>
        public DtoBulkUpdate(
            string accountname = null,
            List<Models.TheIDresourceandDeviceId> resourceidentifiers = null,
            Models.BulkUpdateSmartalert smartalert = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Accountname = accountname;
            this.Resourceidentifiers = resourceidentifiers;
            this.Smartalert = smartalert;
        }

        /// <summary>
        /// The numeric account name, which must include leading zeros
        /// </summary>
        [JsonProperty("accountname", NullValueHandling = NullValueHandling.Ignore)]
        public string Accountname { get; set; }

        /// <summary>
        /// Gets or sets Resourceidentifiers.
        /// </summary>
        [JsonProperty("resourceidentifiers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.TheIDresourceandDeviceId> Resourceidentifiers { get; set; }

        /// <summary>
        /// Gets or sets Smartalert.
        /// </summary>
        [JsonProperty("smartalert", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BulkUpdateSmartalert Smartalert { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoBulkUpdate : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoBulkUpdate other &&
                (this.Accountname == null && other.Accountname == null ||
                 this.Accountname?.Equals(other.Accountname) == true) &&
                (this.Resourceidentifiers == null && other.Resourceidentifiers == null ||
                 this.Resourceidentifiers?.Equals(other.Resourceidentifiers) == true) &&
                (this.Smartalert == null && other.Smartalert == null ||
                 this.Smartalert?.Equals(other.Smartalert) == true) &&
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
            toStringOutput.Add($"Accountname = {this.Accountname ?? "null"}");
            toStringOutput.Add($"Resourceidentifiers = {(this.Resourceidentifiers == null ? "null" : $"[{string.Join(", ", this.Resourceidentifiers)} ]")}");
            toStringOutput.Add($"Smartalert = {(this.Smartalert == null ? "null" : this.Smartalert.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}