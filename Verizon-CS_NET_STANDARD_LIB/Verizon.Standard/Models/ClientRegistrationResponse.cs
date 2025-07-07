// <copyright file="ClientRegistrationResponse.cs" company="APIMatic">
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
    /// ClientRegistrationResponse.
    /// </summary>
    public class ClientRegistrationResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRegistrationResponse"/> class.
        /// </summary>
        public ClientRegistrationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRegistrationResponse"/> class.
        /// </summary>
        /// <param name="deviceId">DeviceID.</param>
        /// <param name="certificate">Certificate.</param>
        public ClientRegistrationResponse(
            Guid deviceId,
            Models.Certificate certificate)
        {
            this.DeviceId = deviceId;
            this.Certificate = certificate;
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
        /// Structure for the credentials required to connect to the ETX MQTT Message Exchange.
        /// </summary>
        [JsonProperty("Certificate")]
        public Models.Certificate Certificate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ClientRegistrationResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ClientRegistrationResponse other &&
                (this.DeviceId.Equals(other.DeviceId)) &&
                (this.Certificate == null && other.Certificate == null ||
                 this.Certificate?.Equals(other.Certificate) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DeviceId = {this.DeviceId}");
            toStringOutput.Add($"Certificate = {(this.Certificate == null ? "null" : this.Certificate.ToString())}");
        }
    }
}