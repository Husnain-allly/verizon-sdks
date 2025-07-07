// <copyright file="ConnectionResponse.cs" company="APIMatic">
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
    /// ConnectionResponse.
    /// </summary>
    public class ConnectionResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionResponse"/> class.
        /// </summary>
        public ConnectionResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionResponse"/> class.
        /// </summary>
        /// <param name="mqttUrl">MqttURL.</param>
        public ConnectionResponse(
            string mqttUrl)
        {
            this.MqttUrl = mqttUrl;
        }

        /// <summary>
        /// Gets or sets MqttUrl.
        /// </summary>
        [JsonProperty("MqttURL")]
        public string MqttUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ConnectionResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ConnectionResponse other &&
                (this.MqttUrl == null && other.MqttUrl == null ||
                 this.MqttUrl?.Equals(other.MqttUrl) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MqttUrl = {this.MqttUrl ?? "null"}");
        }
    }
}