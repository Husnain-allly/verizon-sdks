// <copyright file="CarrierServicePlan.cs" company="APIMatic">
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
    /// CarrierServicePlan.
    /// </summary>
    public class CarrierServicePlan
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
        /// Initializes a new instance of the <see cref="CarrierServicePlan"/> class.
        /// </summary>
        public CarrierServicePlan()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierServicePlan"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="code">code.</param>
        /// <param name="sizeKb">sizeKb.</param>
        /// <param name="carrierServicePlanCode">carrierServicePlanCode.</param>
        public CarrierServicePlan(
            string name = null,
            string code = null,
            string sizeKb = null,
            string carrierServicePlanCode = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Name = name;
            this.Code = code;
            this.SizeKb = sizeKb;
            this.CarrierServicePlanCode = carrierServicePlanCode;
        }

        /// <summary>
        /// The name of the service plan
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The inventory name or system name of the service plan
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// The ammount of space the service plan will occupy on the Subscriber Information Module (SIM)
        /// </summary>
        [JsonProperty("sizeKb", NullValueHandling = NullValueHandling.Ignore)]
        public string SizeKb { get; set; }

        /// <summary>
        /// The billing record ID. This can be numeric, alpha or alphanumeric.
        /// </summary>
        [JsonProperty("carrierServicePlanCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierServicePlanCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CarrierServicePlan : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CarrierServicePlan other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.SizeKb == null && other.SizeKb == null ||
                 this.SizeKb?.Equals(other.SizeKb) == true) &&
                (this.CarrierServicePlanCode == null && other.CarrierServicePlanCode == null ||
                 this.CarrierServicePlanCode?.Equals(other.CarrierServicePlanCode) == true) &&
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
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"SizeKb = {this.SizeKb ?? "null"}");
            toStringOutput.Add($"CarrierServicePlanCode = {this.CarrierServicePlanCode ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}