// <copyright file="BulkUpdateSmartalert.cs" company="APIMatic">
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
    /// BulkUpdateSmartalert.
    /// </summary>
    public class BulkUpdateSmartalert
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateSmartalert"/> class.
        /// </summary>
        public BulkUpdateSmartalert()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateSmartalert"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        public BulkUpdateSmartalert(
            string name = null)
        {
            this.Name = name;
        }

        /// <summary>
        /// User defined name of the record
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BulkUpdateSmartalert : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BulkUpdateSmartalert other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
        }
    }
}