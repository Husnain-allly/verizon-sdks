// <copyright file="RoadSignId.cs" company="APIMatic">
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
    /// RoadSignId.
    /// </summary>
    public class RoadSignId
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoadSignId"/> class.
        /// </summary>
        public RoadSignId()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoadSignId"/> class.
        /// </summary>
        /// <param name="position">position.</param>
        /// <param name="viewAngle">viewAngle.</param>
        public RoadSignId(
            Models.Position position,
            string viewAngle)
        {
            this.Position = position;
            this.ViewAngle = viewAngle;
        }

        /// <summary>
        /// It provides a precise location in the WGS-84 coordinate system, from which short offsets may be used to create additional data using a flat earth projection centered on this location.
        /// </summary>
        [JsonProperty("position")]
        public Models.Position Position { get; set; }

        /// <summary>
        /// Gets or sets ViewAngle.
        /// </summary>
        [JsonProperty("viewAngle")]
        public string ViewAngle { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RoadSignId : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RoadSignId other &&
                (this.Position == null && other.Position == null ||
                 this.Position?.Equals(other.Position) == true) &&
                (this.ViewAngle == null && other.ViewAngle == null ||
                 this.ViewAngle?.Equals(other.ViewAngle) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Position = {(this.Position == null ? "null" : this.Position.ToString())}");
            toStringOutput.Add($"ViewAngle = {this.ViewAngle ?? "null"}");
        }
    }
}