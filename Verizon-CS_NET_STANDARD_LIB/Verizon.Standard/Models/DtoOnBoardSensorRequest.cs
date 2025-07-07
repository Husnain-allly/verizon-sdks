// <copyright file="DtoOnBoardSensorRequest.cs" company="APIMatic">
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
    /// DtoOnBoardSensorRequest.
    /// </summary>
    public class DtoOnBoardSensorRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoOnBoardSensorRequest"/> class.
        /// </summary>
        public DtoOnBoardSensorRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoOnBoardSensorRequest"/> class.
        /// </summary>
        /// <param name="accountname">accountname.</param>
        /// <param name="payload">payload.</param>
        public DtoOnBoardSensorRequest(
            string accountname = null,
            Models.Payload payload = null)
        {
            this.Accountname = accountname;
            this.Payload = payload;
        }

        /// <summary>
        /// The numeric account name, which must include leading zeros
        /// </summary>
        [JsonProperty("accountname", NullValueHandling = NullValueHandling.Ignore)]
        public string Accountname { get; set; }

        /// <summary>
        /// Gets or sets Payload.
        /// </summary>
        [JsonProperty("payload", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Payload Payload { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoOnBoardSensorRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoOnBoardSensorRequest other &&
                (this.Accountname == null && other.Accountname == null ||
                 this.Accountname?.Equals(other.Accountname) == true) &&
                (this.Payload == null && other.Payload == null ||
                 this.Payload?.Equals(other.Payload) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Accountname = {this.Accountname ?? "null"}");
            toStringOutput.Add($"Payload = {(this.Payload == null ? "null" : this.Payload.ToString())}");
        }
    }
}