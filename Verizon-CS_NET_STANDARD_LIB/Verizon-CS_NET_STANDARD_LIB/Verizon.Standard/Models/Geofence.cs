// <copyright file="Geofence.cs" company="APIMatic">
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
    /// Geofence.
    /// </summary>
    public class Geofence
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Geofence"/> class.
        /// </summary>
        public Geofence()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Geofence"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="coordinates">coordinates.</param>
        public Geofence(
            string type,
            List<List<double>> coordinates)
        {
            this.Type = type;
            this.Coordinates = coordinates;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Coordinates.
        /// </summary>
        [JsonProperty("coordinates")]
        public List<List<double>> Coordinates { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Geofence : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Geofence other &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.Coordinates == null && other.Coordinates == null ||
                 this.Coordinates?.Equals(other.Coordinates) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"Coordinates = {(this.Coordinates == null ? "null" : $"[{string.Join(", ", this.Coordinates)} ]")}");
        }
    }
}