// <copyright file="Item2.cs" company="APIMatic">
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
    /// Item2.
    /// </summary>
    public class Item2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item2"/> class.
        /// </summary>
        public Item2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Item2"/> class.
        /// </summary>
        /// <param name="text">text.</param>
        public Item2(
            string text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Text phrase provides very short sections of text interspersed between the ITIS codes to create phrases. In general, this is used for expressing proper nouns, such as street names reflecting local expressions that do not appear in the ITIS tables.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Item2 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Item2 other &&
                (this.Text == null && other.Text == null ||
                 this.Text?.Equals(other.Text) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Text = {this.Text ?? "null"}");
        }
    }
}