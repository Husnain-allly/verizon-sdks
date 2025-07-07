// <copyright file="DtoUserDto.cs" company="APIMatic">
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
    /// DtoUserDto.
    /// </summary>
    public class DtoUserDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoUserDto"/> class.
        /// </summary>
        public DtoUserDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoUserDto"/> class.
        /// </summary>
        /// <param name="email">email.</param>
        /// <param name="firstname">firstname.</param>
        /// <param name="lastname">lastname.</param>
        /// <param name="mdn">mdn.</param>
        /// <param name="customdata">customdata.</param>
        public DtoUserDto(
            string email = null,
            string firstname = null,
            string lastname = null,
            string mdn = null,
            object customdata = null)
        {
            this.Email = email;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Mdn = mdn;
            this.Customdata = customdata;
        }

        /// <summary>
        /// Contact email for the group
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// The first name in the user record
        /// </summary>
        [JsonProperty("firstname", NullValueHandling = NullValueHandling.Ignore)]
        public string Firstname { get; set; }

        /// <summary>
        /// The last name in the user record
        /// </summary>
        [JsonProperty("lastname", NullValueHandling = NullValueHandling.Ignore)]
        public string Lastname { get; set; }

        /// <summary>
        /// The Mobile Directory Number
        /// </summary>
        [JsonProperty("mdn", NullValueHandling = NullValueHandling.Ignore)]
        public string Mdn { get; set; }

        /// <summary>
        /// Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action.
        /// </summary>
        [JsonProperty("customdata", NullValueHandling = NullValueHandling.Ignore)]
        public object Customdata { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoUserDto : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoUserDto other &&
                (this.Email == null && other.Email == null ||
                 this.Email?.Equals(other.Email) == true) &&
                (this.Firstname == null && other.Firstname == null ||
                 this.Firstname?.Equals(other.Firstname) == true) &&
                (this.Lastname == null && other.Lastname == null ||
                 this.Lastname?.Equals(other.Lastname) == true) &&
                (this.Mdn == null && other.Mdn == null ||
                 this.Mdn?.Equals(other.Mdn) == true) &&
                (this.Customdata == null && other.Customdata == null ||
                 this.Customdata?.Equals(other.Customdata) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"Firstname = {this.Firstname ?? "null"}");
            toStringOutput.Add($"Lastname = {this.Lastname ?? "null"}");
            toStringOutput.Add($"Mdn = {this.Mdn ?? "null"}");
            toStringOutput.Add($"Customdata = {(this.Customdata == null ? "null" : this.Customdata.ToString())}");
        }
    }
}