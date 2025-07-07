// <copyright file="SmsTriggerRequest.cs" company="APIMatic">
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
using Verizon.Standard;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
{
    /// <summary>
    /// SmsTriggerRequest.
    /// </summary>
    public class SmsTriggerRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsTriggerRequest"/> class.
        /// </summary>
        public SmsTriggerRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsTriggerRequest"/> class.
        /// </summary>
        /// <param name="comparator">comparator.</param>
        /// <param name="smsType">smsType.</param>
        /// <param name="threshold">threshold.</param>
        public SmsTriggerRequest(
            string comparator = null,
            string smsType = null,
            int? threshold = null)
        {
            this.Comparator = comparator;
            this.SmsType = smsType;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Gets or sets Comparator.
        /// </summary>
        [JsonProperty("comparator", NullValueHandling = NullValueHandling.Ignore)]
        public string Comparator { get; set; }

        /// <summary>
        /// Gets or sets SmsType.
        /// </summary>
        [JsonProperty("smsType", NullValueHandling = NullValueHandling.Ignore)]
        public string SmsType { get; set; }

        /// <summary>
        /// Gets or sets Threshold.
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? Threshold { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SmsTriggerRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SmsTriggerRequest other &&
                (this.Comparator == null && other.Comparator == null ||
                 this.Comparator?.Equals(other.Comparator) == true) &&
                (this.SmsType == null && other.SmsType == null ||
                 this.SmsType?.Equals(other.SmsType) == true) &&
                (this.Threshold == null && other.Threshold == null ||
                 this.Threshold?.Equals(other.Threshold) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Comparator = {this.Comparator ?? "null"}");
            toStringOutput.Add($"SmsType = {this.SmsType ?? "null"}");
            toStringOutput.Add($"Threshold = {(this.Threshold == null ? "null" : this.Threshold.ToString())}");
        }
    }
}