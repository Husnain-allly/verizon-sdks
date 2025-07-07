// <copyright file="GeographicalPathDescription.cs" company="APIMatic">
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
    /// GeographicalPathDescription.
    /// </summary>
    public class GeographicalPathDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeographicalPathDescription"/> class.
        /// </summary>
        public GeographicalPathDescription()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeographicalPathDescription"/> class.
        /// </summary>
        /// <param name="path">path.</param>
        public GeographicalPathDescription(
            Models.OffsetSystem path)
        {
            this.Path = path;
        }

        /// <summary>
        /// The OffsetSystem data frame selects a sequence of node offsets described in the Lat-Long offset method.
        /// </summary>
        [JsonProperty("path")]
        public Models.OffsetSystem Path { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GeographicalPathDescription : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GeographicalPathDescription other &&
                (this.Path == null && other.Path == null ||
                 this.Path?.Equals(other.Path) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Path = {(this.Path == null ? "null" : this.Path.ToString())}");
        }
    }
}