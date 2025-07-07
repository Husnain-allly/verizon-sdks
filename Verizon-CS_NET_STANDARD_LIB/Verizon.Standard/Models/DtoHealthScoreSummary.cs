// <copyright file="DtoHealthScoreSummary.cs" company="APIMatic">
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
    /// DtoHealthScoreSummary.
    /// </summary>
    public class DtoHealthScoreSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoHealthScoreSummary"/> class.
        /// </summary>
        public DtoHealthScoreSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoHealthScoreSummary"/> class.
        /// </summary>
        /// <param name="overallsummary">overallsummary.</param>
        public DtoHealthScoreSummary(
            List<Models.DtoHealthScoreMetric> overallsummary = null)
        {
            this.Overallsummary = overallsummary;
        }

        /// <summary>
        /// Gets or sets Overallsummary.
        /// </summary>
        [JsonProperty("overallsummary", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DtoHealthScoreMetric> Overallsummary { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoHealthScoreSummary : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoHealthScoreSummary other &&
                (this.Overallsummary == null && other.Overallsummary == null ||
                 this.Overallsummary?.Equals(other.Overallsummary) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Overallsummary = {(this.Overallsummary == null ? "null" : $"[{string.Join(", ", this.Overallsummary)} ]")}");
        }
    }
}