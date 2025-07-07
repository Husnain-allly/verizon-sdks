// <copyright file="NodeOffsetPointLl.cs" company="APIMatic">
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
    /// NodeOffsetPointLl.
    /// </summary>
    public class NodeOffsetPointLl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeOffsetPointLl"/> class.
        /// </summary>
        public NodeOffsetPointLl()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeOffsetPointLl"/> class.
        /// </summary>
        /// <param name="nodeLatLon">nodeLatLon.</param>
        public NodeOffsetPointLl(
            Models.NodeLLmD64B nodeLatLon)
        {
            this.NodeLatLon = nodeLatLon;
        }

        /// <summary>
        /// A 64-bit node type with lat-long values expressed in standard SAE 1/10th of a microdegree.
        /// </summary>
        [JsonProperty("nodeLatLon")]
        public Models.NodeLLmD64B NodeLatLon { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NodeOffsetPointLl : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NodeOffsetPointLl other &&
                (this.NodeLatLon == null && other.NodeLatLon == null ||
                 this.NodeLatLon?.Equals(other.NodeLatLon) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"NodeLatLon = {(this.NodeLatLon == null ? "null" : this.NodeLatLon.ToString())}");
        }
    }
}