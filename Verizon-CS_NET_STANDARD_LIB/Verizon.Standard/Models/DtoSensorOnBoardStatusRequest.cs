// <copyright file="DtoSensorOnBoardStatusRequest.cs" company="APIMatic">
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
    /// DtoSensorOnBoardStatusRequest.
    /// </summary>
    public class DtoSensorOnBoardStatusRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoSensorOnBoardStatusRequest"/> class.
        /// </summary>
        public DtoSensorOnBoardStatusRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoSensorOnBoardStatusRequest"/> class.
        /// </summary>
        /// <param name="accountname">accountname.</param>
        /// <param name="gatewayidentifier">gatewayidentifier.</param>
        /// <param name="onboarding">onboarding.</param>
        public DtoSensorOnBoardStatusRequest(
            string accountname = null,
            Models.Gatewayidentifier gatewayidentifier = null,
            Models.Onboarding onboarding = null)
        {
            this.Accountname = accountname;
            this.Gatewayidentifier = gatewayidentifier;
            this.Onboarding = onboarding;
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
        /// Gets or sets Onboarding.
        /// </summary>
        [JsonProperty("onboarding", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Onboarding Onboarding { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoSensorOnBoardStatusRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoSensorOnBoardStatusRequest other &&
                (this.Accountname == null && other.Accountname == null ||
                 this.Accountname?.Equals(other.Accountname) == true) &&
                (this.Gatewayidentifier == null && other.Gatewayidentifier == null ||
                 this.Gatewayidentifier?.Equals(other.Gatewayidentifier) == true) &&
                (this.Onboarding == null && other.Onboarding == null ||
                 this.Onboarding?.Equals(other.Onboarding) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Accountname = {this.Accountname ?? "null"}");
            toStringOutput.Add($"Gatewayidentifier = {(this.Gatewayidentifier == null ? "null" : this.Gatewayidentifier.ToString())}");
            toStringOutput.Add($"Onboarding = {(this.Onboarding == null ? "null" : this.Onboarding.ToString())}");
        }
    }
}