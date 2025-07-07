// <copyright file="ListMecPlatformsResult.cs" company="APIMatic">
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
    /// ListMecPlatformsResult.
    /// </summary>
    public class ListMecPlatformsResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListMecPlatformsResult"/> class.
        /// </summary>
        public ListMecPlatformsResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMecPlatformsResult"/> class.
        /// </summary>
        /// <param name="mecPlatforms">MECPlatforms.</param>
        public ListMecPlatformsResult(
            List<Models.MecPlatformResource> mecPlatforms = null)
        {
            this.MecPlatforms = mecPlatforms;
        }

        /// <summary>
        /// A list of optimal MEC Platforms where you can register your deployed application.
        /// </summary>
        [JsonProperty("MECPlatforms", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.MecPlatformResource> MecPlatforms { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListMecPlatformsResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListMecPlatformsResult other &&
                (this.MecPlatforms == null && other.MecPlatforms == null ||
                 this.MecPlatforms?.Equals(other.MecPlatforms) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MecPlatforms = {(this.MecPlatforms == null ? "null" : $"[{string.Join(", ", this.MecPlatforms)} ]")}");
        }
    }
}