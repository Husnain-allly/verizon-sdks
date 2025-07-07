// <copyright file="SaeInfo.cs" company="APIMatic">
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
    /// SaeInfo.
    /// </summary>
    public class SaeInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaeInfo"/> class.
        /// </summary>
        public SaeInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaeInfo"/> class.
        /// </summary>
        /// <param name="dataFrames">dataFrames.</param>
        public SaeInfo(
            List<Models.DataFrame> dataFrames)
        {
            this.DataFrames = dataFrames;
        }

        /// <summary>
        /// List of data frames.
        /// </summary>
        [JsonProperty("dataFrames")]
        public List<Models.DataFrame> DataFrames { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SaeInfo : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SaeInfo other &&
                (this.DataFrames == null && other.DataFrames == null ||
                 this.DataFrames?.Equals(other.DataFrames) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DataFrames = {(this.DataFrames == null ? "null" : $"[{string.Join(", ", this.DataFrames)} ]")}");
        }
    }
}