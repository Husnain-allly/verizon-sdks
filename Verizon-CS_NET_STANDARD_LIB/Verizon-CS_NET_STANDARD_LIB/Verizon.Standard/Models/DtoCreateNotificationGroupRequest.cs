// <copyright file="DtoCreateNotificationGroupRequest.cs" company="APIMatic">
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
    /// DtoCreateNotificationGroupRequest.
    /// </summary>
    public class DtoCreateNotificationGroupRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoCreateNotificationGroupRequest"/> class.
        /// </summary>
        public DtoCreateNotificationGroupRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoCreateNotificationGroupRequest"/> class.
        /// </summary>
        /// <param name="mGroup">group.</param>
        /// <param name="accountname">accountname.</param>
        /// <param name="userids">userids.</param>
        public DtoCreateNotificationGroupRequest(
            Models.DtoNotificationGroupRequestEntity mGroup,
            string accountname = null,
            List<string> userids = null)
        {
            this.Accountname = accountname;
            this.MGroup = mGroup;
            this.Userids = userids;
        }

        /// <summary>
        /// The numeric account name, which must include leading zeros
        /// </summary>
        [JsonProperty("accountname", NullValueHandling = NullValueHandling.Ignore)]
        public string Accountname { get; set; }

        /// <summary>
        /// Gets or sets MGroup.
        /// </summary>
        [JsonProperty("group")]
        public Models.DtoNotificationGroupRequestEntity MGroup { get; set; }

        /// <summary>
        /// Gets or sets Userids.
        /// </summary>
        [JsonProperty("userids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Userids { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoCreateNotificationGroupRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoCreateNotificationGroupRequest other &&
                (this.Accountname == null && other.Accountname == null ||
                 this.Accountname?.Equals(other.Accountname) == true) &&
                (this.MGroup == null && other.MGroup == null ||
                 this.MGroup?.Equals(other.MGroup) == true) &&
                (this.Userids == null && other.Userids == null ||
                 this.Userids?.Equals(other.Userids) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Accountname = {this.Accountname ?? "null"}");
            toStringOutput.Add($"MGroup = {(this.MGroup == null ? "null" : this.MGroup.ToString())}");
            toStringOutput.Add($"Userids = {(this.Userids == null ? "null" : $"[{string.Join(", ", this.Userids)} ]")}");
        }
    }
}