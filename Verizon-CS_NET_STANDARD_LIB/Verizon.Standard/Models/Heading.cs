// <copyright file="Heading.cs" company="APIMatic">
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
    /// Heading.
    /// </summary>
    public class Heading
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Heading"/> class.
        /// </summary>
        public Heading()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Heading"/> class.
        /// </summary>
        /// <param name="min">min.</param>
        /// <param name="max">max.</param>
        public Heading(
            double min,
            double max)
        {
            this.Min = min;
            this.Max = max;
        }

        /// <summary>
        /// The minimum value of heading in unit of degrees.
        /// </summary>
        [JsonProperty("min")]
        public double Min { get; set; }

        /// <summary>
        /// The maximum value of heading in unit of degrees.
        /// </summary>
        [JsonProperty("max")]
        public double Max { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Heading : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Heading other &&
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