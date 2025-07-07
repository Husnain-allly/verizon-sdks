// <copyright file="SaeAlert.cs" company="APIMatic">
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
    /// SaeAlert.
    /// </summary>
    public class SaeAlert
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaeAlert"/> class.
        /// </summary>
        public SaeAlert()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaeAlert"/> class.
        /// </summary>
        /// <param name="typeEvent">typeEvent.</param>
        /// <param name="description">description.</param>
        public SaeAlert(
            int typeEvent,
            List<int> description = null)
        {
            this.TypeEvent = typeEvent;
            this.Description = description;
        }

        /// <summary>
        /// The ITIS Code that describes the alert/danger/hazard. All ITS standards use the same types here to explain the type of the alert/danger/hazard involved.
        /// The complete set of ITIS codes can be found in Volume Two of the SAE J2540 standard. This is a set of over 1000 items which are used to encode common events and list items in ITS.
        /// </summary>
        [JsonProperty("typeEvent")]
        public int TypeEvent { get; set; }

        /// <summary>
        /// ITIS code set entries to further describe the event, give advice, or any other ITIS codes related to the event/danger/hazard.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SaeAlert : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SaeAlert other &&
                (this.TypeEvent.Equals(other.TypeEvent)) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TypeEvent = {this.TypeEvent}");
            toStringOutput.Add($"Description = {(this.Description == null ? "null" : $"[{string.Join(", ", this.Description)} ]")}");
        }
    }
}