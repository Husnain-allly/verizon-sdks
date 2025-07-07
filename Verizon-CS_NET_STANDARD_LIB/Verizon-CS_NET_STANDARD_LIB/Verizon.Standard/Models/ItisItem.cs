// <copyright file="ItisItem.cs" company="APIMatic">
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
    /// ItisItem.
    /// </summary>
    public class ItisItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItisItem"/> class.
        /// </summary>
        public ItisItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItisItem"/> class.
        /// </summary>
        /// <param name="itis">itis.</param>
        public ItisItem(
            int itis)
        {
            this.Itis = itis;
        }

        /// <summary>
        /// The ITIS Code that describes the alert/danger/hazard. All ITS standards use the same types here to explain the type of the alert/danger/hazard involved.
        /// The complete set of ITIS codes can be found in Volume Two of the SAE J2540 standard. This is a set of over 1000 items which are used to encode common events and list items in ITS.
        /// </summary>
        [JsonProperty("itis")]
        public int Itis { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ItisItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ItisItem other &&
                (this.Itis.Equals(other.Itis));
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Itis = {this.Itis}");
        }
    }
}