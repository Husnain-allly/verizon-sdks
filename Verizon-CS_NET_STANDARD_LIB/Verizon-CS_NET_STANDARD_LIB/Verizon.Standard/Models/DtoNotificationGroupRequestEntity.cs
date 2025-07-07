// <copyright file="DtoNotificationGroupRequestEntity.cs" company="APIMatic">
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
    /// DtoNotificationGroupRequestEntity.
    /// </summary>
    public class DtoNotificationGroupRequestEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoNotificationGroupRequestEntity"/> class.
        /// </summary>
        public DtoNotificationGroupRequestEntity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoNotificationGroupRequestEntity"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="groupemail">groupemail.</param>
        /// <param name="name">name.</param>
        public DtoNotificationGroupRequestEntity(
            string description = null,
            string groupemail = null,
            string name = null)
        {
            this.Description = description;
            this.Groupemail = groupemail;
            this.Name = name;
        }

        /// <summary>
        /// a short description
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Contact email for the group
        /// </summary>
        [JsonProperty("groupemail", NullValueHandling = NullValueHandling.Ignore)]
        public string Groupemail { get; set; }

        /// <summary>
        /// User defined name of the record
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoNotificationGroupRequestEntity : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoNotificationGroupRequestEntity other &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Groupemail == null && other.Groupemail == null ||
                 this.Groupemail?.Equals(other.Groupemail) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Groupemail = {this.Groupemail ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
        }
    }
}