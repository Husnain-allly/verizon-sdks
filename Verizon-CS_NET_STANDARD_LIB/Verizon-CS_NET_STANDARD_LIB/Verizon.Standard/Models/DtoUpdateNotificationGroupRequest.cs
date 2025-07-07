// <copyright file="DtoUpdateNotificationGroupRequest.cs" company="APIMatic">
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
    /// DtoUpdateNotificationGroupRequest.
    /// </summary>
    public class DtoUpdateNotificationGroupRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoUpdateNotificationGroupRequest"/> class.
        /// </summary>
        public DtoUpdateNotificationGroupRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoUpdateNotificationGroupRequest"/> class.
        /// </summary>
        /// <param name="mGroup">group.</param>
        /// <param name="accountname">accountname.</param>
        /// <param name="id">id.</param>
        /// <param name="userids">userids.</param>
        public DtoUpdateNotificationGroupRequest(
            Models.DtoNotificationGroupRequestEntity mGroup,
            string accountname = null,
            string id = null,
            List<string> userids = null)
        {
            this.Accountname = accountname;
            this.MGroup = mGroup;
            this.Id = id;
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
        /// UUID of the user record, assigned at creation
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

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
            return $"DtoUpdateNotificationGroupRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoUpdateNotificationGroupRequest other &&
                (this.Accountname == null && other.Accountname == null ||
                 this.Accountname?.Equals(other.Accountname) == true) &&
                (this.MGroup == null && other.MGroup == null ||
                 this.MGroup?.Equals(other.MGroup) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
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
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Userids = {(this.Userids == null ? "null" : $"[{string.Join(", ", this.Userids)} ]")}");
        }
    }
}