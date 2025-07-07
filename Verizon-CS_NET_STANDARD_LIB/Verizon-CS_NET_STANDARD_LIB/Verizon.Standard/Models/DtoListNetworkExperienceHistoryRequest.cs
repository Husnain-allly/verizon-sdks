// <copyright file="DtoListNetworkExperienceHistoryRequest.cs" company="APIMatic">
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
    /// DtoListNetworkExperienceHistoryRequest.
    /// </summary>
    public class DtoListNetworkExperienceHistoryRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoListNetworkExperienceHistoryRequest"/> class.
        /// </summary>
        public DtoListNetworkExperienceHistoryRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoListNetworkExperienceHistoryRequest"/> class.
        /// </summary>
        /// <param name="accountname">accountname.</param>
        /// <param name="filter">filter.</param>
        public DtoListNetworkExperienceHistoryRequest(
            string accountname = null,
            Models.DtoFilter filter = null)
        {
            this.Accountname = accountname;
            this.Filter = filter;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoListNetworkExperienceHistoryRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoListNetworkExperienceHistoryRequest other &&
                (this.Accountname == null && other.Accountname == null ||
                 this.Accountname?.Equals(other.Accountname) == true) &&
                (this.Filter == null && other.Filter == null ||
                 this.Filter?.Equals(other.Filter) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Accountname = {this.Accountname ?? "null"}");
            toStringOutput.Add($"Filter = {(this.Filter == null ? "null" : this.Filter.ToString())}");
        }
    }
}