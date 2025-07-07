// <copyright file="DtoFields.cs" company="APIMatic">
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
    /// DtoFields.
    /// </summary>
    public class DtoFields
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoFields"/> class.
        /// </summary>
        public DtoFields()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoFields"/> class.
        /// </summary>
        /// <param name="additionalProp1">additionalProp1.</param>
        /// <param name="additionalProp2">additionalProp2.</param>
        /// <param name="additionalProp3">additionalProp3.</param>
        public DtoFields(
            string additionalProp1 = null,
            string additionalProp2 = null,
            string additionalProp3 = null)
        {
            this.AdditionalProp1 = additionalProp1;
            this.AdditionalProp2 = additionalProp2;
            this.AdditionalProp3 = additionalProp3;
        }

        /// <summary>
        /// Gets or sets AdditionalProp1.
        /// </summary>
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProp1 { get; set; }

        /// <summary>
        /// Gets or sets AdditionalProp2.
        /// </summary>
        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProp2 { get; set; }

        /// <summary>
        /// Gets or sets AdditionalProp3.
        /// </summary>
        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProp3 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoFields : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoFields other &&
                (this.AdditionalProp1 == null && other.AdditionalProp1 == null ||
                 this.AdditionalProp1?.Equals(other.AdditionalProp1) == true) &&
                (this.AdditionalProp2 == null && other.AdditionalProp2 == null ||
                 this.AdditionalProp2?.Equals(other.AdditionalProp2) == true) &&
                (this.AdditionalProp3 == null && other.AdditionalProp3 == null ||
                 this.AdditionalProp3?.Equals(other.AdditionalProp3) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AdditionalProp1 = {this.AdditionalProp1 ?? "null"}");
            toStringOutput.Add($"AdditionalProp2 = {this.AdditionalProp2 ?? "null"}");
            toStringOutput.Add($"AdditionalProp3 = {this.AdditionalProp3 ?? "null"}");
        }
    }
}