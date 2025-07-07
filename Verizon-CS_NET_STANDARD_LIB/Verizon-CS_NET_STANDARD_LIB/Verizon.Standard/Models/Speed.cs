// <copyright file="Speed.cs" company="APIMatic">
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
    /// Speed.
    /// </summary>
    public class Speed
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Speed"/> class.
        /// </summary>
        public Speed()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Speed"/> class.
        /// </summary>
        /// <param name="min">min.</param>
        /// <param name="max">max.</param>
        public Speed(
            double min,
            double max)
        {
            this.Min = min;
            this.Max = max;
        }

        /// <summary>
        /// The minimum required speed in m/s.
        /// </summary>
        [JsonProperty("min")]
        public double Min { get; set; }

        /// <summary>
        /// The maximum acceptable speed in m/s
        /// </summary>
        [JsonProperty("max")]
        public double Max { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Speed : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Speed other &&
                (this.Min.Equals(other.Min)) &&
                (this.Max.Equals(other.Max));
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Min = {this.Min}");
            toStringOutput.Add($"Max = {this.Max}");
        }
    }
}