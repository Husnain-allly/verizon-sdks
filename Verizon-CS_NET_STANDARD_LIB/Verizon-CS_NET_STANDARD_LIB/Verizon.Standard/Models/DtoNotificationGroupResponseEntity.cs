// <copyright file="DtoNotificationGroupResponseEntity.cs" company="APIMatic">
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
    /// DtoNotificationGroupResponseEntity.
    /// </summary>
    public class DtoNotificationGroupResponseEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoNotificationGroupResponseEntity"/> class.
        /// </summary>
        public DtoNotificationGroupResponseEntity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoNotificationGroupResponseEntity"/> class.
        /// </summary>
        /// <param name="createdon">createdon.</param>
        /// <param name="description">description.</param>
        /// <param name="foreignid">foreignid.</param>
        /// <param name="groupemail">groupemail.</param>
        /// <param name="id">id.</param>
        /// <param name="lastupdated">lastupdated.</param>
        /// <param name="name">name.</param>
        /// <param name="users">users.</param>
        /// <param name="version">version.</param>
        /// <param name="versionid">versionid.</param>
        public DtoNotificationGroupResponseEntity(
            DateTime? createdon = null,
            string description = null,
            string foreignid = null,
            string groupemail = null,
            string id = null,
            DateTime? lastupdated = null,
            string name = null,
            List<Models.DtoUserDto> users = null,
            string version = null,
            string versionid = null)
        {
            this.Createdon = createdon;
            this.Description = description;
            this.Foreignid = foreignid;
            this.Groupemail = groupemail;
            this.Id = id;
            this.Lastupdated = lastupdated;
            this.Name = name;
            this.Users = users;
            this.Version = version;
            this.Versionid = versionid;
        }

        /// <summary>
        /// Timestamp of the record
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdon", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Createdon { get; set; }

        /// <summary>
        /// a short description
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// UUID of the ECPD account the user belongs to
        /// </summary>
        [JsonProperty("foreignid", NullValueHandling = NullValueHandling.Ignore)]
        public string Foreignid { get; set; }

        /// <summary>
        /// Contact email for the group
        /// </summary>
        [JsonProperty("groupemail", NullValueHandling = NullValueHandling.Ignore)]
        public string Groupemail { get; set; }

        /// <summary>
        /// UUID of the user record, assigned at creation
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Timestamp of the record
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastupdated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Lastupdated { get; set; }

        /// <summary>
        /// User defined name of the record
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Users.
        /// </summary>
        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DtoUserDto> Users { get; set; }

        /// <summary>
        /// The resource version
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// The UUID of the resource version
        /// </summary>
        [JsonProperty("versionid", NullValueHandling = NullValueHandling.Ignore)]
        public string Versionid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoNotificationGroupResponseEntity : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoNotificationGroupResponseEntity other &&
                (this.Createdon == null && other.Createdon == null ||
                 this.Createdon?.Equals(other.Createdon) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Foreignid == null && other.Foreignid == null ||
                 this.Foreignid?.Equals(other.Foreignid) == true) &&
                (this.Groupemail == null && other.Groupemail == null ||
                 this.Groupemail?.Equals(other.Groupemail) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Lastupdated == null && other.Lastupdated == null ||
                 this.Lastupdated?.Equals(other.Lastupdated) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Users == null && other.Users == null ||
                 this.Users?.Equals(other.Users) == true) &&
                (this.Version == null && other.Version == null ||
                 this.Version?.Equals(other.Version) == true) &&
                (this.Versionid == null && other.Versionid == null ||
                 this.Versionid?.Equals(other.Versionid) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Createdon = {(this.Createdon == null ? "null" : this.Createdon.ToString())}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Foreignid = {this.Foreignid ?? "null"}");
            toStringOutput.Add($"Groupemail = {this.Groupemail ?? "null"}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Lastupdated = {(this.Lastupdated == null ? "null" : this.Lastupdated.ToString())}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Users = {(this.Users == null ? "null" : $"[{string.Join(", ", this.Users)} ]")}");
            toStringOutput.Add($"Version = {this.Version ?? "null"}");
            toStringOutput.Add($"Versionid = {this.Versionid ?? "null"}");
        }
    }
}