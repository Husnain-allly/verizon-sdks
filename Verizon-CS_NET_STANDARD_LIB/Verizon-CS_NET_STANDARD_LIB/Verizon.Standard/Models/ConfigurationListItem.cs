// <copyright file="ConfigurationListItem.cs" company="APIMatic">
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
    /// ConfigurationListItem.
    /// </summary>
    public class ConfigurationListItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationListItem"/> class.
        /// </summary>
        public ConfigurationListItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationListItem"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        public ConfigurationListItem(
            string id,
            bool isActive,
            string name = null,
            string description = null)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.IsActive = isActive;
        }

        /// <summary>
        /// The generated ID (UUID v4) for the configuration. It has to be used when asking for changing any of the configuration parameters.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the configuration.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the configuration.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets IsActive.
        /// </summary>
        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ConfigurationListItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ConfigurationListItem other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.IsActive.Equals(other.IsActive));
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"IsActive = {this.IsActive}");
        }
    }
}