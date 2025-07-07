// <copyright file="DtoDeleteNotificationGroupRequest.cs" company="APIMatic">
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
    /// DtoDeleteNotificationGroupRequest.
    /// </summary>
    public class DtoDeleteNotificationGroupRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoDeleteNotificationGroupRequest"/> class.
        /// </summary>
        public DtoDeleteNotificationGroupRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoDeleteNotificationGroupRequest"/> class.
        /// </summary>
        /// <param name="accountname">accountname.</param>
        /// <param name="force">force.</param>
        /// <param name="id">id.</param>
        public DtoDeleteNotificationGroupRequest(
            string accountname = null,
            bool? force = null,
            string id = null)
        {
            this.Accountname = accountname;
            this.Force = force;
            this.Id = id;
        }

        /// <summary>
        /// The numeric account name, which must include leading zeros
        /// </summary>
        [JsonProperty("accountname", NullValueHandling = NullValueHandling.Ignore)]
        public string Accountname { get; set; }

        /// <summary>
        /// Gets or sets Force.
        /// </summary>
        [JsonProperty("force", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force { get; set; }

        /// <summary>
        /// UUID of the user record, assigned at creation
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoDeleteNotificationGroupRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoDeleteNotificationGroupRequest other &&
                (this.Accountname == null && other.Accountname == null ||
                 this.Accountname?.Equals(other.Accountname) == true) &&
                (this.Force == null && other.Force == null ||
                 this.Force?.Equals(other.Force) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Accountname = {this.Accountname ?? "null"}");
            toStringOutput.Add($"Force = {(this.Force == null ? "null" : this.Force.ToString())}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
        }
    }
}