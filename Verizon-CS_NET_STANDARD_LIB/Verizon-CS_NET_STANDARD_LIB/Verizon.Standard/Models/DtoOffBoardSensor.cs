// <copyright file="DtoOffBoardSensor.cs" company="APIMatic">
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
    /// DtoOffBoardSensor.
    /// </summary>
    public class DtoOffBoardSensor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoOffBoardSensor"/> class.
        /// </summary>
        public DtoOffBoardSensor()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoOffBoardSensor"/> class.
        /// </summary>
        /// <param name="deveui">deveui.</param>
        public DtoOffBoardSensor(
            string deveui = null)
        {
            this.Deveui = deveui;
        }

        /// <summary>
        /// the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer
        /// </summary>
        [JsonProperty("deveui", NullValueHandling = NullValueHandling.Ignore)]
        public string Deveui { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoOffBoardSensor : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoOffBoardSensor other &&
                (this.Deveui == null && other.Deveui == null ||
                 this.Deveui?.Equals(other.Deveui) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Deveui = {this.Deveui ?? "null"}");
        }
    }
}