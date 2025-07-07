// <copyright file="NetworkTypeObject.cs" company="APIMatic">
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
    /// NetworkTypeObject.
    /// </summary>
    public class NetworkTypeObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkTypeObject"/> class.
        /// </summary>
        public NetworkTypeObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkTypeObject"/> class.
        /// </summary>
        /// <param name="networkType">networkType.</param>
        public NetworkTypeObject(
            string networkType = null)
        {
            this.NetworkType = networkType;
        }

        /// <summary>
        /// Gets or sets NetworkType.
        /// </summary>
        [JsonProperty("networkType", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NetworkTypeObject : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NetworkTypeObject other &&
                (this.NetworkType == null && other.NetworkType == null ||
                 this.NetworkType?.Equals(other.NetworkType) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"NetworkType = {this.NetworkType ?? "null"}");
        }
    }
}