// <copyright file="DtoOverwriteRuleRequest.cs" company="APIMatic">
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
    /// DtoOverwriteRuleRequest.
    /// </summary>
    public class DtoOverwriteRuleRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoOverwriteRuleRequest"/> class.
        /// </summary>
        public DtoOverwriteRuleRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoOverwriteRuleRequest"/> class.
        /// </summary>
        /// <param name="accountname">accountname.</param>
        /// <param name="resourceidentifier">resourceidentifier.</param>
        /// <param name="rule">rule.</param>
        public DtoOverwriteRuleRequest(
            string accountname = null,
            Models.DtoResourceidentifier resourceidentifier = null,
            Models.ResourceRule rule = null)
        {
            this.Accountname = accountname;
            this.Resourceidentifier = resourceidentifier;
            this.Rule = rule;
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
        /// Gets or sets Rule.
        /// </summary>
        [JsonProperty("rule", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResourceRule Rule { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoOverwriteRuleRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoOverwriteRuleRequest other &&
                (this.Accountname == null && other.Accountname == null ||
                 this.Accountname?.Equals(other.Accountname) == true) &&
                (this.Resourceidentifier == null && other.Resourceidentifier == null ||
                 this.Resourceidentifier?.Equals(other.Resourceidentifier) == true) &&
                (this.Rule == null && other.Rule == null ||
                 this.Rule?.Equals(other.Rule) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Accountname = {this.Accountname ?? "null"}");
            toStringOutput.Add($"Resourceidentifier = {(this.Resourceidentifier == null ? "null" : this.Resourceidentifier.ToString())}");
            toStringOutput.Add($"Rule = {(this.Rule == null ? "null" : this.Rule.ToString())}");
        }
    }
}