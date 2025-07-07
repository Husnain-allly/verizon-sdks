// <copyright file="DtoSensorOffBoardStatusRequest.cs" company="APIMatic">
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
    /// DtoSensorOffBoardStatusRequest.
    /// </summary>
    public class DtoSensorOffBoardStatusRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoSensorOffBoardStatusRequest"/> class.
        /// </summary>
        public DtoSensorOffBoardStatusRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoSensorOffBoardStatusRequest"/> class.
        /// </summary>
        /// <param name="accountname">accountname.</param>
        /// <param name="gatewayidentifier">gatewayidentifier.</param>
        /// <param name="offboarding">offboarding.</param>
        public DtoSensorOffBoardStatusRequest(
            string accountname = null,
            Models.Gatewayidentifier gatewayidentifier = null,
            Models.Offboarding offboarding = null)
        {
            this.Accountname = accountname;
            this.Gatewayidentifier = gatewayidentifier;
            this.Offboarding = offboarding;
        }

        /// <summary>
        /// The numeric account name, which must include leading zeros
        /// </summary>
        [JsonProperty("accountname", NullValueHandling = NullValueHandling.Ignore)]
        public string Accountname { get; set; }

        /// <summary>
        /// Gets or sets Gatewayidentifier.
        /// </summary>
        [JsonProperty("gatewayidentifier", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Gatewayidentifier Gatewayidentifier { get; set; }

        /// <summary>
        /// Gets or sets Offboarding.
        /// </summary>
        [JsonProperty("offboarding", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Offboarding Offboarding { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoSensorOffBoardStatusRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoSensorOffBoardStatusRequest other &&
                (this.Accountname == null && other.Accountname == null ||
                 this.Accountname?.Equals(other.Accountname) == true) &&
                (this.Gatewayidentifier == null && other.Gatewayidentifier == null ||
                 this.Gatewayidentifier?.Equals(other.Gatewayidentifier) == true) &&
                (this.Offboarding == null && other.Offboarding == null ||
                 this.Offboarding?.Equals(other.Offboarding) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Accountname = {this.Accountname ?? "null"}");
            toStringOutput.Add($"Gatewayidentifier = {(this.Gatewayidentifier == null ? "null" : this.Gatewayidentifier.ToString())}");
            toStringOutput.Add($"Offboarding = {(this.Offboarding == null ? "null" : this.Offboarding.ToString())}");
        }
    }
}