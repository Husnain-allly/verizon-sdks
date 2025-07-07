// <copyright file="EtxGeofence.cs" company="APIMatic">
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
    /// EtxGeofence.
    /// </summary>
    public class EtxGeofence
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EtxGeofence"/> class.
        /// </summary>
        public EtxGeofence()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EtxGeofence"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="features">features.</param>
        public EtxGeofence(
            Models.FeatureCollectionType type,
            List<Models.GeoFeature> features)
        {
            this.Type = type;
            this.Features = features;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public Models.FeatureCollectionType Type { get; set; }

        /// <summary>
        /// Gets or sets Features.
        /// </summary>
        [JsonProperty("features")]
        public List<Models.GeoFeature> Features { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"EtxGeofence : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is EtxGeofence other &&
                (this.Type.Equals(other.Type)) &&
                (this.Features == null && other.Features == null ||
                 this.Features?.Equals(other.Features) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {this.Type}");
            toStringOutput.Add($"Features = {(this.Features == null ? "null" : $"[{string.Join(", ", this.Features)} ]")}");
        }
    }
}