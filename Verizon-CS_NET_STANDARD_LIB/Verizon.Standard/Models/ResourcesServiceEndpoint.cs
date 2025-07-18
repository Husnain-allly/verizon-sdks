// <copyright file="ResourcesServiceEndpoint.cs" company="APIMatic">
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
    /// ResourcesServiceEndpoint.
    /// </summary>
    public class ResourcesServiceEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesServiceEndpoint"/> class.
        /// </summary>
        public ResourcesServiceEndpoint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesServiceEndpoint"/> class.
        /// </summary>
        /// <param name="uri">URI.</param>
        /// <param name="fqdn">FQDN.</param>
        /// <param name="iPv4Address">IPv4Address.</param>
        /// <param name="iPv6Address">IPv6Address.</param>
        /// <param name="port">port.</param>
        public ResourcesServiceEndpoint(
            string uri = null,
            string fqdn = null,
            string iPv4Address = null,
            string iPv6Address = null,
            int? port = null)
        {
            this.Uri = uri;
            this.Fqdn = fqdn;
            this.IPv4Address = iPv4Address;
            this.IPv6Address = iPv6Address;
            this.Port = port;
        }

        /// <summary>
        /// URI of Service Endpoint if available.
        /// </summary>
        [JsonProperty("URI", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// FQDN of Service Endpoint if available.
        /// </summary>
        [JsonProperty("FQDN", NullValueHandling = NullValueHandling.Ignore)]
        public string Fqdn { get; set; }

        /// <summary>
        /// IPv4 Address of Service Endpoint if available.
        /// </summary>
        [JsonProperty("IPv4Address", NullValueHandling = NullValueHandling.Ignore)]
        public string IPv4Address { get; set; }

        /// <summary>
        /// IPv6 Address of Service Endpoint if available.
        /// </summary>
        [JsonProperty("IPv6Address", NullValueHandling = NullValueHandling.Ignore)]
        public string IPv6Address { get; set; }

        /// <summary>
        /// Port information of Service Endpoint if IPv4 or IPv6 is mentioned.
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ResourcesServiceEndpoint : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ResourcesServiceEndpoint other &&
                (this.Uri == null && other.Uri == null ||
                 this.Uri?.Equals(other.Uri) == true) &&
                (this.Fqdn == null && other.Fqdn == null ||
                 this.Fqdn?.Equals(other.Fqdn) == true) &&
                (this.IPv4Address == null && other.IPv4Address == null ||
                 this.IPv4Address?.Equals(other.IPv4Address) == true) &&
                (this.IPv6Address == null && other.IPv6Address == null ||
                 this.IPv6Address?.Equals(other.IPv6Address) == true) &&
                (this.Port == null && other.Port == null ||
                 this.Port?.Equals(other.Port) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Uri = {this.Uri ?? "null"}");
            toStringOutput.Add($"Fqdn = {this.Fqdn ?? "null"}");
            toStringOutput.Add($"IPv4Address = {this.IPv4Address ?? "null"}");
            toStringOutput.Add($"IPv6Address = {this.IPv6Address ?? "null"}");
            toStringOutput.Add($"Port = {(this.Port == null ? "null" : this.Port.ToString())}");
        }
    }
}