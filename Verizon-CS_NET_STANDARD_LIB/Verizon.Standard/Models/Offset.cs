// <copyright file="Offset.cs" company="APIMatic">
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
    /// Offset.
    /// </summary>
    public class Offset
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Offset"/> class.
        /// </summary>
        public Offset()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Offset"/> class.
        /// </summary>
        /// <param name="ll">ll.</param>
        public Offset(
            Models.NodeListLl ll)
        {
            this.Ll = ll;
        }

        /// <summary>
        /// The NodeListLL data structure provides the sequence of signed offset node point values for determining the latitude and longitude. Each LL point is referred to as a node point.
        /// </summary>
        [JsonProperty("ll")]
        public Models.NodeListLl Ll { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Offset : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Offset other &&
                (this.Ll == null && other.Ll == null ||
                 this.Ll?.Equals(other.Ll) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Ll = {(this.Ll == null ? "null" : this.Ll.ToString())}");
        }
    }
}