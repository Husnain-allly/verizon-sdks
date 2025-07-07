// <copyright file="DtoDeleteUserRequest.cs" company="APIMatic">
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
    /// DtoDeleteUserRequest.
    /// </summary>
    public class DtoDeleteUserRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoDeleteUserRequest"/> class.
        /// </summary>
        public DtoDeleteUserRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoDeleteUserRequest"/> class.
        /// </summary>
        /// <param name="accountname">accountname.</param>
        /// <param name="id">id.</param>
        public DtoDeleteUserRequest(
            string accountname = null,
            string id = null)
        {
            this.Accountname = accountname;
            this.Id = id;
        }

        /// <summary>
        /// The numeric account name, which must include leading zeros
        /// </summary>
        [JsonProperty("accountname", NullValueHandling = NullValueHandling.Ignore)]
        public string Accountname { get; set; }

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
            return $"DtoDeleteUserRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoDeleteUserRequest other &&
                (this.Accountname == null && other.Accountname == null ||
                 this.Accountname?.Equals(other.Accountname) == true) &&
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
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
        }
    }
}