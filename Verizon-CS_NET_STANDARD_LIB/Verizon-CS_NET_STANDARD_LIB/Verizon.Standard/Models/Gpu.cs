// <copyright file="Gpu.cs" company="APIMatic">
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
    /// Gpu.
    /// </summary>
    public class Gpu
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Gpu"/> class.
        /// </summary>
        public Gpu()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Gpu"/> class.
        /// </summary>
        /// <param name="minCoreClockMHz">minCoreClockMHz.</param>
        /// <param name="minMemoryClockMHz">minMemoryClockMHz.</param>
        /// <param name="minBandwidthGBs">minBandwidthGBs.</param>
        /// <param name="minTflops">minTFLOPS.</param>
        public Gpu(
            int? minCoreClockMHz = null,
            int? minMemoryClockMHz = null,
            int? minBandwidthGBs = null,
            int? minTflops = null)
        {
            this.MinCoreClockMHz = minCoreClockMHz;
            this.MinMemoryClockMHz = minMemoryClockMHz;
            this.MinBandwidthGBs = minBandwidthGBs;
            this.MinTflops = minTflops;
        }

        /// <summary>
        /// Minimum Core Clock value in megahertz.
        /// </summary>
        [JsonProperty("minCoreClockMHz", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinCoreClockMHz { get; set; }

        /// <summary>
        /// Minimum Memory Clock value in megahertz.
        /// </summary>
        [JsonProperty("minMemoryClockMHz", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinMemoryClockMHz { get; set; }

        /// <summary>
        /// Minimum GPU bandwidth in GB/s.
        /// </summary>
        [JsonProperty("minBandwidthGBs", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinBandwidthGBs { get; set; }

        /// <summary>
        /// Minimum Floating Point Operations Per Second in Teraflops.
        /// </summary>
        [JsonProperty("minTFLOPS", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinTflops { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Gpu : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Gpu other &&
                (this.MinCoreClockMHz == null && other.MinCoreClockMHz == null ||
                 this.MinCoreClockMHz?.Equals(other.MinCoreClockMHz) == true) &&
                (this.MinMemoryClockMHz == null && other.MinMemoryClockMHz == null ||
                 this.MinMemoryClockMHz?.Equals(other.MinMemoryClockMHz) == true) &&
                (this.MinBandwidthGBs == null && other.MinBandwidthGBs == null ||
                 this.MinBandwidthGBs?.Equals(other.MinBandwidthGBs) == true) &&
                (this.MinTflops == null && other.MinTflops == null ||
                 this.MinTflops?.Equals(other.MinTflops) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MinCoreClockMHz = {(this.MinCoreClockMHz == null ? "null" : this.MinCoreClockMHz.ToString())}");
            toStringOutput.Add($"MinMemoryClockMHz = {(this.MinMemoryClockMHz == null ? "null" : this.MinMemoryClockMHz.ToString())}");
            toStringOutput.Add($"MinBandwidthGBs = {(this.MinBandwidthGBs == null ? "null" : this.MinBandwidthGBs.ToString())}");
            toStringOutput.Add($"MinTflops = {(this.MinTflops == null ? "null" : this.MinTflops.ToString())}");
        }
    }
}