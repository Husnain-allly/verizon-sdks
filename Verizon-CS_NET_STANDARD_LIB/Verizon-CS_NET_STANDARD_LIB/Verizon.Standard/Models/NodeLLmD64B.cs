// <copyright file="NodeLLmD64B.cs" company="APIMatic">
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
    /// NodeLLmD64B.
    /// </summary>
    public class NodeLLmD64B
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeLLmD64B"/> class.
        /// </summary>
        public NodeLLmD64B()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeLLmD64B"/> class.
        /// </summary>
        /// <param name="lon">lon.</param>
        /// <param name="lat">lat.</param>
        public NodeLLmD64B(
            int lon,
            int lat)
        {
            this.Lon = lon;
            this.Lat = lat;
        }

        /// <summary>
        /// The geographic longitude of an object, expressed in 1/10th integer microdegrees, as a 32-bit value, and with reference to the horizontal datum then in use. The value 1800000001 shall be used when unavailable.
        /// </summary>
        [JsonProperty("lon")]
        public int Lon { get; set; }

        /// <summary>
        /// The geographic latitude of an object, expressed in 1/10th integer microdegrees, as a 31 bit value, and with reference to the horizontal datum then in use. The value 900000001 shall be used when unavailable.
        /// </summary>
        [JsonProperty("lat")]
        public int Lat { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NodeLLmD64B : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NodeLLmD64B other &&
                (this.Lon.Equals(other.Lon)) &&
                (this.Lat.Equals(other.Lat));
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Lon = {this.Lon}");
            toStringOutput.Add($"Lat = {this.Lat}");
        }
    }
}