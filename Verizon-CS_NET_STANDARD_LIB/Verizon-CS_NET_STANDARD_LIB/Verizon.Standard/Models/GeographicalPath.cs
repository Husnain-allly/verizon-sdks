// <copyright file="GeographicalPath.cs" company="APIMatic">
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
    /// GeographicalPath.
    /// </summary>
    public class GeographicalPath
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeographicalPath"/> class.
        /// </summary>
        public GeographicalPath()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeographicalPath"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="direction">direction.</param>
        public GeographicalPath(
            Models.GeographicalPathDescription description = null,
            string direction = null)
        {
            this.Description = description;
            this.Direction = direction;
        }

        /// <summary>
        /// This data frame can describe a complex path of arbitrary size using node offset method (LL offsets).
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GeographicalPathDescription Description { get; set; }

        /// <summary>
        /// Gets or sets Direction.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GeographicalPath : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GeographicalPath other &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Direction == null && other.Direction == null ||
                 this.Direction?.Equals(other.Direction) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Description = {(this.Description == null ? "null" : this.Description.ToString())}");
            toStringOutput.Add($"Direction = {this.Direction ?? "null"}");
        }
    }
}