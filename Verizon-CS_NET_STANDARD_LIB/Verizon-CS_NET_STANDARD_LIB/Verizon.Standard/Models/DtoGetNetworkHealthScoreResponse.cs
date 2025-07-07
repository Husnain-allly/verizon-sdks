// <copyright file="DtoGetNetworkHealthScoreResponse.cs" company="APIMatic">
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
    /// DtoGetNetworkHealthScoreResponse.
    /// </summary>
    public class DtoGetNetworkHealthScoreResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoGetNetworkHealthScoreResponse"/> class.
        /// </summary>
        public DtoGetNetworkHealthScoreResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoGetNetworkHealthScoreResponse"/> class.
        /// </summary>
        /// <param name="networksummary">networksummary.</param>
        /// <param name="overallsummary">overallsummary.</param>
        public DtoGetNetworkHealthScoreResponse(
            List<Models.DtoHealthScoreMetric> networksummary = null,
            List<Models.DtoHealthScoreMetric> overallsummary = null)
        {
            this.Networksummary = networksummary;
            this.Overallsummary = overallsummary;
        }

        /// <summary>
        /// Gets or sets Networksummary.
        /// </summary>
        [JsonProperty("networksummary", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DtoHealthScoreMetric> Networksummary { get; set; }

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
            return $"DtoGetNetworkHealthScoreResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoGetNetworkHealthScoreResponse other &&
                (this.Networksummary == null && other.Networksummary == null ||
                 this.Networksummary?.Equals(other.Networksummary) == true) &&
                (this.Overallsummary == null && other.Overallsummary == null ||
                 this.Overallsummary?.Equals(other.Overallsummary) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Networksummary = {(this.Networksummary == null ? "null" : $"[{string.Join(", ", this.Networksummary)} ]")}");
            toStringOutput.Add($"Overallsummary = {(this.Overallsummary == null ? "null" : $"[{string.Join(", ", this.Overallsummary)} ]")}");
        }
    }
}