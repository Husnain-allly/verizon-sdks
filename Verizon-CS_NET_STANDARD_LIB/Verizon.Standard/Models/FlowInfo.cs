// <copyright file="FlowInfo.cs" company="APIMatic">
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
    /// FlowInfo.
    /// </summary>
    public class FlowInfo
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
        /// Initializes a new instance of the <see cref="FlowInfo"/> class.
        /// </summary>
        public FlowInfo()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowInfo"/> class.
        /// </summary>
        /// <param name="flowServer">flowServer.</param>
        /// <param name="flowDevice">flowDevice.</param>
        /// <param name="flowDirection">flowDirection.</param>
        /// <param name="flowProtocol">flowProtocol.</param>
        /// <param name="qciOption">qciOption.</param>
        public FlowInfo(
            string flowServer = null,
            string flowDevice = null,
            string flowDirection = null,
            string flowProtocol = null,
            string qciOption = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.FlowServer = flowServer;
            this.FlowDevice = flowDevice;
            this.FlowDirection = flowDirection;
            this.FlowProtocol = flowProtocol;
            this.QciOption = qciOption;
        }

        /// <summary>
        /// Gets or sets FlowServer.
        /// </summary>
        [JsonProperty("flowServer", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowServer { get; set; }

        /// <summary>
        /// Gets or sets FlowDevice.
        /// </summary>
        [JsonProperty("flowDevice", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowDevice { get; set; }

        /// <summary>
        /// Gets or sets FlowDirection.
        /// </summary>
        [JsonProperty("flowDirection", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowDirection { get; set; }

        /// <summary>
        /// Gets or sets FlowProtocol.
        /// </summary>
        [JsonProperty("flowProtocol", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowProtocol { get; set; }

        /// <summary>
        /// Gets or sets QciOption.
        /// </summary>
        [JsonProperty("qciOption", NullValueHandling = NullValueHandling.Ignore)]
        public string QciOption { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FlowInfo : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FlowInfo other &&
                (this.FlowServer == null && other.FlowServer == null ||
                 this.FlowServer?.Equals(other.FlowServer) == true) &&
                (this.FlowDevice == null && other.FlowDevice == null ||
                 this.FlowDevice?.Equals(other.FlowDevice) == true) &&
                (this.FlowDirection == null && other.FlowDirection == null ||
                 this.FlowDirection?.Equals(other.FlowDirection) == true) &&
                (this.FlowProtocol == null && other.FlowProtocol == null ||
                 this.FlowProtocol?.Equals(other.FlowProtocol) == true) &&
                (this.QciOption == null && other.QciOption == null ||
                 this.QciOption?.Equals(other.QciOption) == true) &&
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
            toStringOutput.Add($"FlowServer = {this.FlowServer ?? "null"}");
            toStringOutput.Add($"FlowDevice = {this.FlowDevice ?? "null"}");
            toStringOutput.Add($"FlowDirection = {this.FlowDirection ?? "null"}");
            toStringOutput.Add($"FlowProtocol = {this.FlowProtocol ?? "null"}");
            toStringOutput.Add($"QciOption = {this.QciOption ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}