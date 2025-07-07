// <copyright file="Certificate.cs" company="APIMatic">
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
    /// Certificate.
    /// </summary>
    public class Certificate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Certificate"/> class.
        /// </summary>
        public Certificate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Certificate"/> class.
        /// </summary>
        /// <param name="certPem">cert.pem.</param>
        /// <param name="keyPem">key.pem.</param>
        /// <param name="caPem">ca.pem.</param>
        /// <param name="expirationTime">ExpirationTime.</param>
        public Certificate(
            string certPem,
            string keyPem,
            string caPem,
            DateTime expirationTime)
        {
            this.CertPem = certPem;
            this.KeyPem = keyPem;
            this.CaPem = caPem;
            this.ExpirationTime = expirationTime;
        }

        /// <summary>
        /// The string containing the certificate
        /// </summary>
        [JsonProperty("cert.pem")]
        public string CertPem { get; set; }

        /// <summary>
        /// The string containing the private key
        /// </summary>
        [JsonProperty("key.pem")]
        public string KeyPem { get; set; }

        /// <summary>
        /// The string containing the CA certificate
        /// </summary>
        [JsonProperty("ca.pem")]
        public string CaPem { get; set; }

        /// <summary>
        /// The string describing the expiration timestamp of the certificate
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ExpirationTime")]
        public DateTime ExpirationTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Certificate : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Certificate other &&
                (this.CertPem == null && other.CertPem == null ||
                 this.CertPem?.Equals(other.CertPem) == true) &&
                (this.KeyPem == null && other.KeyPem == null ||
                 this.KeyPem?.Equals(other.KeyPem) == true) &&
                (this.CaPem == null && other.CaPem == null ||
                 this.CaPem?.Equals(other.CaPem) == true) &&
                (this.ExpirationTime.Equals(other.ExpirationTime));
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CertPem = {this.CertPem ?? "null"}");
            toStringOutput.Add($"KeyPem = {this.KeyPem ?? "null"}");
            toStringOutput.Add($"CaPem = {this.CaPem ?? "null"}");
            toStringOutput.Add($"ExpirationTime = {this.ExpirationTime}");
        }
    }
}