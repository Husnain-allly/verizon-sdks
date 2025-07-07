// <copyright file="ResourceResourceQuery.cs" company="APIMatic">
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
    /// ResourceResourceQuery.
    /// </summary>
    public class ResourceResourceQuery
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceResourceQuery"/> class.
        /// </summary>
        public ResourceResourceQuery()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceResourceQuery"/> class.
        /// </summary>
        /// <param name="filter">filter.</param>
        public ResourceResourceQuery(
            Models.Devicepropertyfilter filter = null)
        {
            this.Filter = filter;
        }

        /// <summary>
        /// Gets or sets Filter.
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Devicepropertyfilter Filter { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ResourceResourceQuery : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ResourceResourceQuery other &&
                (this.Filter == null && other.Filter == null ||
                 this.Filter?.Equals(other.Filter) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Filter = {(this.Filter == null ? "null" : this.Filter.ToString())}");
        }
    }
}