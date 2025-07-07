// <copyright file="DtoSensorOffBoardingStatusResponse.cs" company="APIMatic">
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
    /// DtoSensorOffBoardingStatusResponse.
    /// </summary>
    public class DtoSensorOffBoardingStatusResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoSensorOffBoardingStatusResponse"/> class.
        /// </summary>
        public DtoSensorOffBoardingStatusResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoSensorOffBoardingStatusResponse"/> class.
        /// </summary>
        /// <param name="events">events.</param>
        /// <param name="isstillregistered">isstillregistered.</param>
        public DtoSensorOffBoardingStatusResponse(
            List<Models.DtoSensorBoardingEvent> events = null,
            bool? isstillregistered = null)
        {
            this.Events = events;
            this.Isstillregistered = isstillregistered;
        }

        /// <summary>
        /// Gets or sets Events.
        /// </summary>
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DtoSensorBoardingEvent> Events { get; set; }

        /// <summary>
        /// Gets or sets Isstillregistered.
        /// </summary>
        [JsonProperty("isstillregistered", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isstillregistered { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoSensorOffBoardingStatusResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoSensorOffBoardingStatusResponse other &&
                (this.Events == null && other.Events == null ||
                 this.Events?.Equals(other.Events) == true) &&
                (this.Isstillregistered == null && other.Isstillregistered == null ||
                 this.Isstillregistered?.Equals(other.Isstillregistered) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Events = {(this.Events == null ? "null" : $"[{string.Join(", ", this.Events)} ]")}");
            toStringOutput.Add($"Isstillregistered = {(this.Isstillregistered == null ? "null" : this.Isstillregistered.ToString())}");
        }
    }
}