// <copyright file="NodeListLl.cs" company="APIMatic">
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
    /// NodeListLl.
    /// </summary>
    public class NodeListLl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeListLl"/> class.
        /// </summary>
        public NodeListLl()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeListLl"/> class.
        /// </summary>
        /// <param name="nodes">nodes.</param>
        public NodeListLl(
            List<Models.NodeLl> nodes)
        {
            this.Nodes = nodes;
        }

        /// <summary>
        /// The NodeSetLL data frame consists of a list of NodeLL entries using LL offsets.
        /// </summary>
        [JsonProperty("nodes")]
        public List<Models.NodeLl> Nodes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NodeListLl : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NodeListLl other &&
                (this.Nodes == null && other.Nodes == null ||
                 this.Nodes?.Equals(other.Nodes) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Nodes = {(this.Nodes == null ? "null" : $"[{string.Join(", ", this.Nodes)} ]")}");
        }
    }
}