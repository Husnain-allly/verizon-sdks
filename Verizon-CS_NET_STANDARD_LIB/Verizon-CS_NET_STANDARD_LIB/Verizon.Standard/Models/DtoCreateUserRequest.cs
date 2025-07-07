// <copyright file="DtoCreateUserRequest.cs" company="APIMatic">
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
    /// DtoCreateUserRequest.
    /// </summary>
    public class DtoCreateUserRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoCreateUserRequest"/> class.
        /// </summary>
        public DtoCreateUserRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoCreateUserRequest"/> class.
        /// </summary>
        /// <param name="accountname">accountname.</param>
        /// <param name="user">user.</param>
        public DtoCreateUserRequest(
            string accountname = null,
            Models.DtoUserDto user = null)
        {
            this.Accountname = accountname;
            this.User = user;
        }

        /// <summary>
        /// The numeric account name, which must include leading zeros
        /// </summary>
        [JsonProperty("accountname", NullValueHandling = NullValueHandling.Ignore)]
        public string Accountname { get; set; }

        /// <summary>
        /// Gets or sets User.
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DtoUserDto User { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoCreateUserRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoCreateUserRequest other &&
                (this.Accountname == null && other.Accountname == null ||
                 this.Accountname?.Equals(other.Accountname) == true) &&
                (this.User == null && other.User == null ||
                 this.User?.Equals(other.User) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Accountname = {this.Accountname ?? "null"}");
            toStringOutput.Add($"User = {(this.User == null ? "null" : this.User.ToString())}");
        }
    }
}