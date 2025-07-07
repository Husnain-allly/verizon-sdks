// <copyright file="DtoSensorOnBoardingStatusResponse.cs" company="APIMatic">
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
    /// DtoSensorOnBoardingStatusResponse.
    /// </summary>
    public class DtoSensorOnBoardingStatusResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoSensorOnBoardingStatusResponse"/> class.
        /// </summary>
        public DtoSensorOnBoardingStatusResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoSensorOnBoardingStatusResponse"/> class.
        /// </summary>
        /// <param name="events">events.</param>
        public DtoSensorOnBoardingStatusResponse(
            List<Models.DtoSensorBoardingEvent> events = null)
        {
            this.Events = events;
        }

        /// <summary>
        /// Gets or sets Events.
        /// </summary>
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DtoSensorBoardingEvent> Events { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoSensorOnBoardingStatusResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoSensorOnBoardingStatusResponse other &&
                (this.Events == null && other.Events == null ||
                 this.Events?.Equals(other.Events) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Events = {(this.Events == null ? "null" : $"[{string.Join(", ", this.Events)} ]")}");
        }
    }
}