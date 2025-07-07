// <copyright file="EsimDeviceList.cs" company="APIMatic">
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
using Verizon.Standard.Models.Containers;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
{
    /// <summary>
    /// EsimDeviceList.
    /// </summary>
    public class EsimDeviceList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EsimDeviceList"/> class.
        /// </summary>
        public EsimDeviceList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EsimDeviceList"/> class.
        /// </summary>
        /// <param name="deviceIds">deviceIds.</param>
        public EsimDeviceList(
            List<EsimDeviceListDeviceIds> deviceIds = null)
        {
            this.DeviceIds = deviceIds;
        }

        /// <summary>
        /// Gets or sets DeviceIds.
        /// </summary>
        [JsonProperty("deviceIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<EsimDeviceListDeviceIds> DeviceIds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"EsimDeviceList : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is EsimDeviceList other &&
                (this.DeviceIds == null && other.DeviceIds == null ||
                 this.DeviceIds?.Equals(other.DeviceIds) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DeviceIds = {(this.DeviceIds == null ? "null" : this.DeviceIds.ToString())}");
        }
    }
}