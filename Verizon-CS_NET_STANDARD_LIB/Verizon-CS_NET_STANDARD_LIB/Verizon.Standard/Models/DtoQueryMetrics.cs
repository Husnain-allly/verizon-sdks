// <copyright file="DtoQueryMetrics.cs" company="APIMatic">
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
    /// DtoQueryMetrics.
    /// </summary>
    public class DtoQueryMetrics
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoQueryMetrics"/> class.
        /// </summary>
        public DtoQueryMetrics()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoQueryMetrics"/> class.
        /// </summary>
        /// <param name="days">days.</param>
        public DtoQueryMetrics(
            int? days = null)
        {
            this.Days = days;
        }

        /// <summary>
        /// The number of days in a recent period to query
        /// </summary>
        [JsonProperty("days", NullValueHandling = NullValueHandling.Ignore)]
        public int? Days { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoQueryMetrics : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoQueryMetrics other &&
                (this.Days == null && other.Days == null ||
                 this.Days?.Equals(other.Days) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Days = {(this.Days == null ? "null" : this.Days.ToString())}");
        }
    }
}