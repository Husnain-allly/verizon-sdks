// <copyright file="Generic.cs" company="APIMatic">
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
    /// Generic.
    /// </summary>
    public class Generic
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Generic"/> class.
        /// </summary>
        public Generic()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Generic"/> class.
        /// </summary>
        /// <param name="messageType">messageType.</param>
        /// <param name="messageFormat">messageFormat.</param>
        /// <param name="payload">payload.</param>
        public Generic(
            string messageType,
            string messageFormat,
            string payload)
        {
            this.MessageType = messageType;
            this.MessageFormat = messageFormat;
            this.Payload = payload;
        }

        /// <summary>
        /// The type of message. This can be any of the standard V2X messages specified in the SAE J2735 standard (e.g. BSM, PSM, RSA, TIM, MAP, SPAT, etc.), or it can be a vendor specific message type that is not defined by the standard.
        /// </summary>
        [JsonProperty("messageType")]
        public string MessageType { get; set; }

        /// <summary>
        /// The encoding of the message (e.g. j2735, protobuf, json, Avro, etc.). If the message is encapsulated within a GeoRoutedMsg protocol buffer wrapper, append _gr to the message format (e.g. j2735 => j2735_gr).
        /// **Note:** ETX prefers the j2735 or the j2735_gr encoding and only vendor specific message types are allowed to be published in different message formats.
        /// </summary>
        [JsonProperty("messageFormat")]
        public string MessageFormat { get; set; }

        /// <summary>
        /// The base64 encoded message.
        /// </summary>
        [JsonProperty("payload")]
        public string Payload { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Generic : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Generic other &&
                (this.MessageType == null && other.MessageType == null ||
                 this.MessageType?.Equals(other.MessageType) == true) &&
                (this.MessageFormat == null && other.MessageFormat == null ||
                 this.MessageFormat?.Equals(other.MessageFormat) == true) &&
                (this.Payload == null && other.Payload == null ||
                 this.Payload?.Equals(other.Payload) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MessageType = {this.MessageType ?? "null"}");
            toStringOutput.Add($"MessageFormat = {this.MessageFormat ?? "null"}");
            toStringOutput.Add($"Payload = {this.Payload ?? "null"}");
        }
    }
}