// <copyright file="MecPlatformsAdditionalSupportInfo.cs" company="APIMatic">
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
    /// MecPlatformsAdditionalSupportInfo.
    /// </summary>
    public class MecPlatformsAdditionalSupportInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MecPlatformsAdditionalSupportInfo"/> class.
        /// </summary>
        public MecPlatformsAdditionalSupportInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MecPlatformsAdditionalSupportInfo"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="data">data.</param>
        public MecPlatformsAdditionalSupportInfo(
            string type = null,
            Models.MecPlatformsAdditionalSupportInfoData data = null)
        {
            this.Type = type;
            this.Data = data;
        }

        /// <summary>
        /// Type of additional service support information for the MEC platform.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Data about additional service support information for the MEC platform.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MecPlatformsAdditionalSupportInfoData Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MecPlatformsAdditionalSupportInfo : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is MecPlatformsAdditionalSupportInfo other &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.Data == null && other.Data == null ||
                 this.Data?.Equals(other.Data) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}