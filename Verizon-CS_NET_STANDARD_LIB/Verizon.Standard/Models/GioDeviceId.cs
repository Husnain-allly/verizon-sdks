// <copyright file="GioDeviceId.cs" company="APIMatic">
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
    /// GioDeviceId.
    /// </summary>
    public class GioDeviceId
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GioDeviceId"/> class.
        /// </summary>
        public GioDeviceId()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GioDeviceId"/> class.
        /// </summary>
        /// <param name="kind">kind.</param>
        /// <param name="id">id.</param>
        public GioDeviceId(
            string kind,
            string id)
        {
            this.Kind = kind;
            this.Id = id;
        }

        /// <summary>
        /// Gets or sets Kind.
        /// </summary>
        [JsonProperty("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GioDeviceId : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GioDeviceId other &&
                (this.Kind == null && other.Kind == null ||
                 this.Kind?.Equals(other.Kind) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Kind = {this.Kind ?? "null"}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
        }
    }
}