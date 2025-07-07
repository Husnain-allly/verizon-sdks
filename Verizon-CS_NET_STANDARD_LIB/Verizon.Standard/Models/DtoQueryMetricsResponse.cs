// <copyright file="DtoQueryMetricsResponse.cs" company="APIMatic">
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
    /// DtoQueryMetricsResponse.
    /// </summary>
    public class DtoQueryMetricsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoQueryMetricsResponse"/> class.
        /// </summary>
        public DtoQueryMetricsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoQueryMetricsResponse"/> class.
        /// </summary>
        /// <param name="critical">critical.</param>
        /// <param name="major">major.</param>
        /// <param name="minor">minor.</param>
        /// <param name="noalert">noalert.</param>
        /// <param name="total">total.</param>
        /// <param name="deltacritical">deltacritical.</param>
        /// <param name="deltamajor">deltamajor.</param>
        /// <param name="deltaminor">deltaminor.</param>
        /// <param name="deltanoalert">deltanoalert.</param>
        public DtoQueryMetricsResponse(
            int? critical = null,
            int? major = null,
            int? minor = null,
            int? noalert = null,
            int? total = null,
            int? deltacritical = null,
            int? deltamajor = null,
            int? deltaminor = null,
            int? deltanoalert = null)
        {
            this.Critical = critical;
            this.Major = major;
            this.Minor = minor;
            this.Noalert = noalert;
            this.Total = total;
            this.Deltacritical = deltacritical;
            this.Deltamajor = deltamajor;
            this.Deltaminor = deltaminor;
            this.Deltanoalert = deltanoalert;
        }

        /// <summary>
        /// The number of critical alerts in the queried time period
        /// </summary>
        [JsonProperty("critical", NullValueHandling = NullValueHandling.Ignore)]
        public int? Critical { get; set; }

        /// <summary>
        /// The number of major alerts in the queried time period
        /// </summary>
        [JsonProperty("major", NullValueHandling = NullValueHandling.Ignore)]
        public int? Major { get; set; }

        /// <summary>
        /// The number of minor alerts in the queried time period
        /// </summary>
        [JsonProperty("minor", NullValueHandling = NullValueHandling.Ignore)]
        public int? Minor { get; set; }

        /// <summary>
        /// The number of sensor reports containing no  alerts in the queried time period
        /// </summary>
        [JsonProperty("noalert", NullValueHandling = NullValueHandling.Ignore)]
        public int? Noalert { get; set; }

        /// <summary>
        /// The total number of alerts in the queried time period
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// The change in the number of critical alerts in the queried time period
        /// </summary>
        [JsonProperty("deltacritical", NullValueHandling = NullValueHandling.Ignore)]
        public int? Deltacritical { get; set; }

        /// <summary>
        /// The change in the number of major alerts in the queried time period
        /// </summary>
        [JsonProperty("deltamajor", NullValueHandling = NullValueHandling.Ignore)]
        public int? Deltamajor { get; set; }

        /// <summary>
        /// The change in the number of minor alerts in the queried time period
        /// </summary>
        [JsonProperty("deltaminor", NullValueHandling = NullValueHandling.Ignore)]
        public int? Deltaminor { get; set; }

        /// <summary>
        /// The change in the number of sensor reports containing no alerts in the queried time period
        /// </summary>
        [JsonProperty("deltanoalert", NullValueHandling = NullValueHandling.Ignore)]
        public int? Deltanoalert { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoQueryMetricsResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoQueryMetricsResponse other &&
                (this.Critical == null && other.Critical == null ||
                 this.Critical?.Equals(other.Critical) == true) &&
                (this.Major == null && other.Major == null ||
                 this.Major?.Equals(other.Major) == true) &&
                (this.Minor == null && other.Minor == null ||
                 this.Minor?.Equals(other.Minor) == true) &&
                (this.Noalert == null && other.Noalert == null ||
                 this.Noalert?.Equals(other.Noalert) == true) &&
                (this.Total == null && other.Total == null ||
                 this.Total?.Equals(other.Total) == true) &&
                (this.Deltacritical == null && other.Deltacritical == null ||
                 this.Deltacritical?.Equals(other.Deltacritical) == true) &&
                (this.Deltamajor == null && other.Deltamajor == null ||
                 this.Deltamajor?.Equals(other.Deltamajor) == true) &&
                (this.Deltaminor == null && other.Deltaminor == null ||
                 this.Deltaminor?.Equals(other.Deltaminor) == true) &&
                (this.Deltanoalert == null && other.Deltanoalert == null ||
                 this.Deltanoalert?.Equals(other.Deltanoalert) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Critical = {(this.Critical == null ? "null" : this.Critical.ToString())}");
            toStringOutput.Add($"Major = {(this.Major == null ? "null" : this.Major.ToString())}");
            toStringOutput.Add($"Minor = {(this.Minor == null ? "null" : this.Minor.ToString())}");
            toStringOutput.Add($"Noalert = {(this.Noalert == null ? "null" : this.Noalert.ToString())}");
            toStringOutput.Add($"Total = {(this.Total == null ? "null" : this.Total.ToString())}");
            toStringOutput.Add($"Deltacritical = {(this.Deltacritical == null ? "null" : this.Deltacritical.ToString())}");
            toStringOutput.Add($"Deltamajor = {(this.Deltamajor == null ? "null" : this.Deltamajor.ToString())}");
            toStringOutput.Add($"Deltaminor = {(this.Deltaminor == null ? "null" : this.Deltaminor.ToString())}");
            toStringOutput.Add($"Deltanoalert = {(this.Deltanoalert == null ? "null" : this.Deltanoalert.ToString())}");
        }
    }
}