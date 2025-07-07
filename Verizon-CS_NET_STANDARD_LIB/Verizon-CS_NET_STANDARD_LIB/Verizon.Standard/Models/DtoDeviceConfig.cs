// <copyright file="DtoDeviceConfig.cs" company="APIMatic">
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
    /// DtoDeviceConfig.
    /// </summary>
    public class DtoDeviceConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoDeviceConfig"/> class.
        /// </summary>
        public DtoDeviceConfig()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoDeviceConfig"/> class.
        /// </summary>
        /// <param name="ble">ble.</param>
        public DtoDeviceConfig(
            Models.SensorInsightsBle ble = null)
        {
            this.Ble = ble;
        }

        /// <summary>
        /// Property objects for Bluetooth Low-Energy (BLE) devices
        /// </summary>
        [JsonProperty("ble", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SensorInsightsBle Ble { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoDeviceConfig : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoDeviceConfig other &&
                (this.Ble == null && other.Ble == null ||
                 this.Ble?.Equals(other.Ble) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Ble = {(this.Ble == null ? "null" : this.Ble.ToString())}");
        }
    }
}