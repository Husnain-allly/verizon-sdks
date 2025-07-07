// <copyright file="NodeLl.cs" company="APIMatic">
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
    /// NodeLl.
    /// </summary>
    public class NodeLl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeLl"/> class.
        /// </summary>
        public NodeLl()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeLl"/> class.
        /// </summary>
        /// <param name="delta">delta.</param>
        public NodeLl(
            Models.NodeOffsetPointLl delta)
        {
            this.Delta = delta;
        }

        /// <summary>
        /// The NodeOffsetPointLL data frame presents a structure to hold 64 bits sized data frames for a single node geometry path. Nodes are described in terms of latitude and longitude.
        /// </summary>
        [JsonProperty("delta")]
        public Models.NodeOffsetPointLl Delta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NodeLl : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NodeLl other &&
                (this.Delta == null && other.Delta == null ||
                 this.Delta?.Equals(other.Delta) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Delta = {(this.Delta == null ? "null" : this.Delta.ToString())}");
        }
    }
}