// <copyright file="GioRequestResponse.cs" company="APIMatic">
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
    /// GioRequestResponse.
    /// </summary>
    public class GioRequestResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GioRequestResponse"/> class.
        /// </summary>
        public GioRequestResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GioRequestResponse"/> class.
        /// </summary>
        /// <param name="requestId">requestId.</param>
        public GioRequestResponse(
            string requestId = null)
        {
            this.RequestId = requestId;
        }

        /// <summary>
        /// Gets or sets RequestId.
        /// </summary>
        [JsonProperty("requestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GioRequestResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GioRequestResponse other &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RequestId = {this.RequestId ?? "null"}");
        }
    }
}