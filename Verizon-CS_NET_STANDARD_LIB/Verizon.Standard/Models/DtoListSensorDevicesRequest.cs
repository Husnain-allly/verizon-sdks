// <copyright file="DtoListSensorDevicesRequest.cs" company="APIMatic">
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
    /// DtoListSensorDevicesRequest.
    /// </summary>
    public class DtoListSensorDevicesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoListSensorDevicesRequest"/> class.
        /// </summary>
        public DtoListSensorDevicesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoListSensorDevicesRequest"/> class.
        /// </summary>
        /// <param name="accountname">accountname.</param>
        /// <param name="filter">filter.</param>
        /// <param name="resourceidentifier">resourceidentifier.</param>
        public DtoListSensorDevicesRequest(
            string accountname = null,
            Models.DtoFilter filter = null,
            Models.DtoDeviceResourceIdentifier resourceidentifier = null)
        {
            this.Accountname = accountname;
            this.Filter = filter;
            this.Resourceidentifier = resourceidentifier;
        }

        /// <summary>
        /// The numeric account name, which must include leading zeros
        /// </summary>
        [JsonProperty("accountname", NullValueHandling = NullValueHandling.Ignore)]
        public string Accountname { get; set; }

        /// <summary>
        /// Gets or sets Filter.
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DtoFilter Filter { get; set; }

        /// <summary>
        /// Device identifiers, one or more are required
        /// </summary>
        [JsonProperty("resourceidentifier", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DtoDeviceResourceIdentifier Resourceidentifier { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoListSensorDevicesRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoListSensorDevicesRequest other &&
                (this.Accountname == null && other.Accountname == null ||
                 this.Accountname?.Equals(other.Accountname) == true) &&
                (this.Filter == null && other.Filter == null ||
                 this.Filter?.Equals(other.Filter) == true) &&
                (this.Resourceidentifier == null && other.Resourceidentifier == null ||
                 this.Resourceidentifier?.Equals(other.Resourceidentifier) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Accountname = {this.Accountname ?? "null"}");
            toStringOutput.Add($"Filter = {(this.Filter == null ? "null" : this.Filter.ToString())}");
            toStringOutput.Add($"Resourceidentifier = {(this.Resourceidentifier == null ? "null" : this.Resourceidentifier.ToString())}");
        }
    }
}