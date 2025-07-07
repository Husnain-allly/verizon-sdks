// <copyright file="OffsetSystem.cs" company="APIMatic">
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
    /// OffsetSystem.
    /// </summary>
    public class OffsetSystem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OffsetSystem"/> class.
        /// </summary>
        public OffsetSystem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OffsetSystem"/> class.
        /// </summary>
        /// <param name="offset">offset.</param>
        public OffsetSystem(
            Models.Offset offset)
        {
            this.Offset = offset;
        }

        /// <summary>
        /// The sequence of node offsets then describes a path or polygon in the Lat-Long system.
        /// </summary>
        [JsonProperty("offset")]
        public Models.Offset Offset { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OffsetSystem : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OffsetSystem other &&
                (this.Offset == null && other.Offset == null ||
                 this.Offset?.Equals(other.Offset) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Offset = {(this.Offset == null ? "null" : this.Offset.ToString())}");
        }
    }
}