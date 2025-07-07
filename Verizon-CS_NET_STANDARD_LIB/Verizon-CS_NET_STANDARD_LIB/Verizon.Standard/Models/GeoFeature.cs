// <copyright file="GeoFeature.cs" company="APIMatic">
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
using Verizon.Standard.Models.Containers;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
{
    /// <summary>
    /// GeoFeature.
    /// </summary>
    public class GeoFeature
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoFeature"/> class.
        /// </summary>
        public GeoFeature()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoFeature"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="geometry">geometry.</param>
        /// <param name="properties">properties.</param>
        public GeoFeature(
            Models.FeatureType type,
            Geometry geometry,
            object properties)
        {
            this.Type = type;
            this.Geometry = geometry;
            this.Properties = properties;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public Models.FeatureType Type { get; set; }

        /// <summary>
        /// Gets or sets Geometry.
        /// </summary>
        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        /// <summary>
        /// Gets or sets Properties.
        /// </summary>
        [JsonProperty("properties")]
        public object Properties { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GeoFeature : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GeoFeature other &&
                (this.Type.Equals(other.Type)) &&
                (this.Geometry == null && other.Geometry == null ||
                 this.Geometry?.Equals(other.Geometry) == true) &&
                (this.Properties == null && other.Properties == null ||
                 this.Properties?.Equals(other.Properties) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {this.Type}");
            toStringOutput.Add($"Geometry = {(this.Geometry == null ? "null" : this.Geometry.ToString())}");
            toStringOutput.Add($"Properties = {(this.Properties == null ? "null" : this.Properties.ToString())}");
        }
    }
}