// <copyright file="ClientRegistrationPendingResponse.cs" company="APIMatic">
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
    /// ClientRegistrationPendingResponse.
    /// </summary>
    public class ClientRegistrationPendingResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRegistrationPendingResponse"/> class.
        /// </summary>
        public ClientRegistrationPendingResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRegistrationPendingResponse"/> class.
        /// </summary>
        /// <param name="deviceId">DeviceID.</param>
        /// <param name="message">Message.</param>
        public ClientRegistrationPendingResponse(
            Guid deviceId,
            string message)
        {
            this.DeviceId = deviceId;
            this.Message = message;
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
        /// The reason why the registration is in pending state
        /// </summary>
        [JsonProperty("Message")]
        public string Message { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ClientRegistrationPendingResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ClientRegistrationPendingResponse other &&
                (this.DeviceId.Equals(other.DeviceId)) &&
                (this.Message == null && other.Message == null ||
                 this.Message?.Equals(other.Message) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DeviceId = {this.DeviceId}");
            toStringOutput.Add($"Message = {this.Message ?? "null"}");
        }
    }
}