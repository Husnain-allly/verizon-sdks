// <copyright file="ResourcesServiceProfileWithId.cs" company="APIMatic">
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
    /// ResourcesServiceProfileWithId.
    /// </summary>
    public class ResourcesServiceProfileWithId
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesServiceProfileWithId"/> class.
        /// </summary>
        public ResourcesServiceProfileWithId()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesServiceProfileWithId"/> class.
        /// </summary>
        /// <param name="clientType">clientType.</param>
        /// <param name="serviceProfileId">serviceProfileId.</param>
        /// <param name="ecspFilter">ecspFilter.</param>
        /// <param name="clientSchedule">clientSchedule.</param>
        /// <param name="clientServiceArea">clientServiceArea.</param>
        /// <param name="networkResources">networkResources.</param>
        /// <param name="computeResources">computeResources.</param>
        /// <param name="properties">properties.</param>
        public ResourcesServiceProfileWithId(
            Models.ClientType clientType,
            string serviceProfileId = null,
            string ecspFilter = null,
            string clientSchedule = null,
            string clientServiceArea = null,
            Models.NetworkResourcesType networkResources = null,
            Models.ComputeResourcesType computeResources = null,
            Models.MecPlatformsAdditionalSupportInfo properties = null)
        {
            this.ServiceProfileId = serviceProfileId;
            this.ClientType = clientType;
            this.EcspFilter = ecspFilter;
            this.ClientSchedule = clientSchedule;
            this.ClientServiceArea = clientServiceArea;
            this.NetworkResources = networkResources;
            this.ComputeResources = computeResources;
            this.Properties = properties;
        }

        /// <summary>
        /// Unique identifier for a service profile.
        /// </summary>
        [JsonProperty("serviceProfileId", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceProfileId { get; set; }

        /// <summary>
        /// The category of application client.
        /// </summary>
        [JsonProperty("clientType")]
        public Models.ClientType ClientType { get; set; }

        /// <summary>
        /// Identity of the preferred Edge Computing Service Provider.
        /// </summary>
        [JsonProperty("ecspFilter", NullValueHandling = NullValueHandling.Ignore)]
        public string EcspFilter { get; set; }

        /// <summary>
        /// The expected operation schedule of the application client (e.g. time windows).
        /// </summary>
        [JsonProperty("clientSchedule", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientSchedule { get; set; }

        /// <summary>
        /// The expected location(s) (e.g. route) of the hosting UE during the Client's operation schedule.
        /// </summary>
        [JsonProperty("clientServiceArea", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientServiceArea { get; set; }

        /// <summary>
        /// Network resources of a service profile.
        /// </summary>
        [JsonProperty("networkResources", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NetworkResourcesType NetworkResources { get; set; }

        /// <summary>
        /// Compute resources of a service profile.
        /// </summary>
        [JsonProperty("computeResources", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ComputeResourcesType ComputeResources { get; set; }

        /// <summary>
        /// Additional service support information for the MEC platform.
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MecPlatformsAdditionalSupportInfo Properties { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ResourcesServiceProfileWithId : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ResourcesServiceProfileWithId other &&
                (this.ServiceProfileId == null && other.ServiceProfileId == null ||
                 this.ServiceProfileId?.Equals(other.ServiceProfileId) == true) &&
                (this.ClientType.Equals(other.ClientType)) &&
                (this.EcspFilter == null && other.EcspFilter == null ||
                 this.EcspFilter?.Equals(other.EcspFilter) == true) &&
                (this.ClientSchedule == null && other.ClientSchedule == null ||
                 this.ClientSchedule?.Equals(other.ClientSchedule) == true) &&
                (this.ClientServiceArea == null && other.ClientServiceArea == null ||
                 this.ClientServiceArea?.Equals(other.ClientServiceArea) == true) &&
                (this.NetworkResources == null && other.NetworkResources == null ||
                 this.NetworkResources?.Equals(other.NetworkResources) == true) &&
                (this.ComputeResources == null && other.ComputeResources == null ||
                 this.ComputeResources?.Equals(other.ComputeResources) == true) &&
                (this.Properties == null && other.Properties == null ||
                 this.Properties?.Equals(other.Properties) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ServiceProfileId = {this.ServiceProfileId ?? "null"}");
            toStringOutput.Add($"ClientType = {this.ClientType}");
            toStringOutput.Add($"EcspFilter = {this.EcspFilter ?? "null"}");
            toStringOutput.Add($"ClientSchedule = {this.ClientSchedule ?? "null"}");
            toStringOutput.Add($"ClientServiceArea = {this.ClientServiceArea ?? "null"}");
            toStringOutput.Add($"NetworkResources = {(this.NetworkResources == null ? "null" : this.NetworkResources.ToString())}");
            toStringOutput.Add($"ComputeResources = {(this.ComputeResources == null ? "null" : this.ComputeResources.ToString())}");
            toStringOutput.Add($"Properties = {(this.Properties == null ? "null" : this.Properties.ToString())}");
        }
    }
}