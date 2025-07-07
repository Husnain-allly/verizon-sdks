// <copyright file="DtoPatchSmartAlertRequest.cs" company="APIMatic">
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
    /// DtoPatchSmartAlertRequest.
    /// </summary>
    public class DtoPatchSmartAlertRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoPatchSmartAlertRequest"/> class.
        /// </summary>
        public DtoPatchSmartAlertRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoPatchSmartAlertRequest"/> class.
        /// </summary>
        /// <param name="accountname">accountname.</param>
        /// <param name="resourceidentifier">resourceidentifier.</param>
        /// <param name="smartalert">smartalert.</param>
        public DtoPatchSmartAlertRequest(
            string accountname = null,
            Models.DtoResourceidentifier resourceidentifier = null,
            Models.UserSmartAlert smartalert = null)
        {
            this.Accountname = accountname;
            this.Resourceidentifier = resourceidentifier;
            this.Smartalert = smartalert;
        }

        /// <summary>
        /// The numeric account name, which must include leading zeros
        /// </summary>
        [JsonProperty("accountname", NullValueHandling = NullValueHandling.Ignore)]
        public string Accountname { get; set; }

        /// <summary>
        /// Gets or sets Resourceidentifier.
        /// </summary>
        [JsonProperty("resourceidentifier", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DtoResourceidentifier Resourceidentifier { get; set; }

        /// <summary>
        /// Gets or sets Smartalert.
        /// </summary>
        [JsonProperty("smartalert", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UserSmartAlert Smartalert { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoPatchSmartAlertRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoPatchSmartAlertRequest other &&
                (this.Accountname == null && other.Accountname == null ||
                 this.Accountname?.Equals(other.Accountname) == true) &&
                (this.Resourceidentifier == null && other.Resourceidentifier == null ||
                 this.Resourceidentifier?.Equals(other.Resourceidentifier) == true) &&
                (this.Smartalert == null && other.Smartalert == null ||
                 this.Smartalert?.Equals(other.Smartalert) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Accountname = {this.Accountname ?? "null"}");
            toStringOutput.Add($"Resourceidentifier = {(this.Resourceidentifier == null ? "null" : this.Resourceidentifier.ToString())}");
            toStringOutput.Add($"Smartalert = {(this.Smartalert == null ? "null" : this.Smartalert.ToString())}");
        }
    }
}