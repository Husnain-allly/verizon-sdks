// <copyright file="Geolocation.cs" company="APIMatic">
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
    /// Geolocation.
    /// </summary>
    public class Geolocation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Geolocation"/> class.
        /// </summary>
        public Geolocation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Geolocation"/> class.
        /// </summary>
        /// <param name="latitude">Latitude.</param>
        /// <param name="longitude">Longitude.</param>
        public Geolocation(
            double latitude,
            double longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        /// <summary>
        /// The GPS Latitude value
        /// </summary>
        [JsonProperty("Latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// The GPS Longitude value
        /// </summary>
        [JsonProperty("Longitude")]
        public double Longitude { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Geolocation : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Geolocation other &&
                (this.Latitude.Equals(other.Latitude)) &&
                (this.Longitude.Equals(other.Longitude));
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Latitude = {this.Latitude}");
            toStringOutput.Add($"Longitude = {this.Longitude}");
        }
    }
}