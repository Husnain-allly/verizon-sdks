// <copyright file="DtoHealthScoreMetric.cs" company="APIMatic">
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
    /// DtoHealthScoreMetric.
    /// </summary>
    public class DtoHealthScoreMetric
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoHealthScoreMetric"/> class.
        /// </summary>
        public DtoHealthScoreMetric()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoHealthScoreMetric"/> class.
        /// </summary>
        /// <param name="metrictype">metrictype.</param>
        /// <param name="metricvalue">metricvalue.</param>
        public DtoHealthScoreMetric(
            string metrictype = null,
            string metricvalue = null)
        {
            this.Metrictype = metrictype;
            this.Metricvalue = metricvalue;
        }

        /// <summary>
        /// The type of measurement and can be overallscore, networkscore, gatewayscore, sensorscore, networkstatus, averagesignalstrength or networkavailabilitylast30
        /// </summary>
        [JsonProperty("metrictype", NullValueHandling = NullValueHandling.Ignore)]
        public string Metrictype { get; set; }

        /// <summary>
        /// the value of the `metrictype` as a percentage
        /// </summary>
        [JsonProperty("metricvalue", NullValueHandling = NullValueHandling.Ignore)]
        public string Metricvalue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoHealthScoreMetric : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoHealthScoreMetric other &&
                (this.Metrictype == null && other.Metrictype == null ||
                 this.Metrictype?.Equals(other.Metrictype) == true) &&
                (this.Metricvalue == null && other.Metricvalue == null ||
                 this.Metricvalue?.Equals(other.Metricvalue) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Metrictype = {this.Metrictype ?? "null"}");
            toStringOutput.Add($"Metricvalue = {this.Metricvalue ?? "null"}");
        }
    }
}