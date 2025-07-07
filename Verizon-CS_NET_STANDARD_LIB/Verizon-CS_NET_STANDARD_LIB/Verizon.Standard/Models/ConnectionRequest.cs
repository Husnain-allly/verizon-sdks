// <copyright file="ConnectionRequest.cs" company="APIMatic">
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
    /// ConnectionRequest.
    /// </summary>
    public class ConnectionRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionRequest"/> class.
        /// </summary>
        public ConnectionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionRequest"/> class.
        /// </summary>
        /// <param name="deviceId">DeviceID.</param>
        /// <param name="geolocation">Geolocation.</param>
        /// <param name="networkType">NetworkType.</param>
        public ConnectionRequest(
            Guid deviceId,
            Models.Geolocation geolocation,
            Models.EtxNetworkType networkType)
        {
            this.DeviceId = deviceId;
            this.Geolocation = geolocation;
            this.NetworkType = networkType;
        }

        /// <summary>
        /// The generated ID (UUID v4) for the device. It can be used as:
        ///   - the MQTT Client ID when connecting to the Message Exchange system
        ///   - a parameter when asking for the connection endpoint
        ///   - a parameter when finishing the device registration
        ///   - a parameter when unregistering the device
        /// </summary>
        [JsonProperty("DeviceID")]
        public Guid DeviceId { get; set; }

        /// <summary>
        /// Geolocation of the device at the time of the connection request in GPS coordinates.
        /// </summary>
        [JsonProperty("Geolocation")]
        public Models.Geolocation Geolocation { get; set; }

        /// <summary>
        /// The type of the device's network connection at the time of the request. If the device is on the Verizon cellular network it should use the "VZ" value otherwise the "non-VZ" value.
        /// Devices on the Verizon network can directly access the ETX Message Exchange on the MEC (Mobile Edge Compute server)
        /// </summary>
        [JsonProperty("NetworkType")]
        public Models.EtxNetworkType NetworkType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ConnectionRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ConnectionRequest other &&
                (this.DeviceId.Equals(other.DeviceId)) &&
                (this.Geolocation == null && other.Geolocation == null ||
                 this.Geolocation?.Equals(other.Geolocation) == true) &&
                (this.NetworkType.Equals(other.NetworkType));
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DeviceId = {this.DeviceId}");
            toStringOutput.Add($"Geolocation = {(this.Geolocation == null ? "null" : this.Geolocation.ToString())}");
            toStringOutput.Add($"NetworkType = {this.NetworkType}");
        }
    }
}