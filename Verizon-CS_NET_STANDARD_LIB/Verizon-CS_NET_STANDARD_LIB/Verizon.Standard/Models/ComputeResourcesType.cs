// <copyright file="ComputeResourcesType.cs" company="APIMatic">
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
    /// ComputeResourcesType.
    /// </summary>
    public class ComputeResourcesType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComputeResourcesType"/> class.
        /// </summary>
        public ComputeResourcesType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputeResourcesType"/> class.
        /// </summary>
        /// <param name="gpu">GPU.</param>
        /// <param name="minRamgb">minRAMGB.</param>
        /// <param name="minStorageGb">minStorageGB.</param>
        public ComputeResourcesType(
            Models.Gpu gpu = null,
            int? minRamgb = null,
            int? minStorageGb = null)
        {
            this.Gpu = gpu;
            this.MinRamgb = minRamgb;
            this.MinStorageGb = minStorageGb;
        }

        /// <summary>
        /// GPU resources of a service profile.
        /// </summary>
        [JsonProperty("GPU", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Gpu Gpu { get; set; }

        /// <summary>
        /// Minimum RAM required in Gigabytes.
        /// </summary>
        [JsonProperty("minRAMGB", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinRamgb { get; set; }

        /// <summary>
        /// Minimum storage requirement in Gigabytes.
        /// </summary>
        [JsonProperty("minStorageGB", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinStorageGb { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ComputeResourcesType : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ComputeResourcesType other &&
                (this.Gpu == null && other.Gpu == null ||
                 this.Gpu?.Equals(other.Gpu) == true) &&
                (this.MinRamgb == null && other.MinRamgb == null ||
                 this.MinRamgb?.Equals(other.MinRamgb) == true) &&
                (this.MinStorageGb == null && other.MinStorageGb == null ||
                 this.MinStorageGb?.Equals(other.MinStorageGb) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Gpu = {(this.Gpu == null ? "null" : this.Gpu.ToString())}");
            toStringOutput.Add($"MinRamgb = {(this.MinRamgb == null ? "null" : this.MinRamgb.ToString())}");
            toStringOutput.Add($"MinStorageGb = {(this.MinStorageGb == null ? "null" : this.MinStorageGb.ToString())}");
        }
    }
}