// <copyright file="GeoFenceConfigurationUpdateRequest.cs" company="APIMatic">
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
    /// GeoFenceConfigurationUpdateRequest.
    /// </summary>
    public class GeoFenceConfigurationUpdateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoFenceConfigurationUpdateRequest"/> class.
        /// </summary>
        public GeoFenceConfigurationUpdateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoFenceConfigurationUpdateRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="geoFence">geoFence.</param>
        /// <param name="messages">messages.</param>
        /// <param name="isActive">isActive.</param>
        public GeoFenceConfigurationUpdateRequest(
            string name = null,
            string description = null,
            Models.EtxGeofence geoFence = null,
            object messages = null,
            bool? isActive = null)
        {
            this.Name = name;
            this.Description = description;
            this.GeoFence = geoFence;
            this.Messages = messages;
            this.IsActive = isActive;
        }

        /// <summary>
        /// Name of the configuration.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the configuration.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The GeoJSON representation of geofence. Geofence supports the following geometry types: LineString, Polygon, MultiLineString, and MultiPolygon. The system only supports a single Feature in the FeatureCollection, so only one Line, Polygon, MultiLine or MultiPolygon can be defined within one Geofencing configuration.
        /// </summary>
        [JsonProperty("geoFence", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EtxGeofence GeoFence { get; set; }

        /// <summary>
        /// List of predefined messages that belongs to the geofence. These are the messages that are sent out by the system when the Trigger Condition for the message is met.
        /// </summary>
        [JsonProperty("messages", NullValueHandling = NullValueHandling.Ignore)]
        public object Messages { get; set; }

        /// <summary>
        /// Gets or sets IsActive.
        /// </summary>
        [JsonProperty("isActive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsActive { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GeoFenceConfigurationUpdateRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GeoFenceConfigurationUpdateRequest other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.GeoFence == null && other.GeoFence == null ||
                 this.GeoFence?.Equals(other.GeoFence) == true) &&
                (this.Messages == null && other.Messages == null ||
                 this.Messages?.Equals(other.Messages) == true) &&
                (this.IsActive == null && other.IsActive == null ||
                 this.IsActive?.Equals(other.IsActive) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"GeoFence = {(this.GeoFence == null ? "null" : this.GeoFence.ToString())}");
            toStringOutput.Add($"Messages = {(this.Messages == null ? "null" : this.Messages.ToString())}");
            toStringOutput.Add($"IsActive = {(this.IsActive == null ? "null" : this.IsActive.ToString())}");
        }
    }
}