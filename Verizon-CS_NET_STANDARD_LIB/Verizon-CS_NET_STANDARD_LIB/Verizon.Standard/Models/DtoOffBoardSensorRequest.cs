// <copyright file="DtoOffBoardSensorRequest.cs" company="APIMatic">
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
    /// DtoOffBoardSensorRequest.
    /// </summary>
    public class DtoOffBoardSensorRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoOffBoardSensorRequest"/> class.
        /// </summary>
        public DtoOffBoardSensorRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoOffBoardSensorRequest"/> class.
        /// </summary>
        /// <param name="accountname">accountname.</param>
        /// <param name="configuration">configuration.</param>
        public DtoOffBoardSensorRequest(
            string accountname = null,
            Models.Sensorinsightsconfig configuration = null)
        {
            this.Accountname = accountname;
            this.Configuration = configuration;
        }

        /// <summary>
        /// The numeric account name, which must include leading zeros
        /// </summary>
        [JsonProperty("accountname", NullValueHandling = NullValueHandling.Ignore)]
        public string Accountname { get; set; }

        /// <summary>
        /// The configuration of the remove request
        /// </summary>
        [JsonProperty("configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Sensorinsightsconfig Configuration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoOffBoardSensorRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoOffBoardSensorRequest other &&
                (this.Accountname == null && other.Accountname == null ||
                 this.Accountname?.Equals(other.Accountname) == true) &&
                (this.Configuration == null && other.Configuration == null ||
                 this.Configuration?.Equals(other.Configuration) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Accountname = {this.Accountname ?? "null"}");
            toStringOutput.Add($"Configuration = {(this.Configuration == null ? "null" : this.Configuration.ToString())}");
        }
    }
}