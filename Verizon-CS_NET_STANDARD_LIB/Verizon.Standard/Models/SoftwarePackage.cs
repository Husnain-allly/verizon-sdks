// <copyright file="SoftwarePackage.cs" company="APIMatic">
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
using Newtonsoft.Json.Linq;
using System.Runtime.CompilerServices;
using Verizon.Standard;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
{
    /// <summary>
    /// SoftwarePackage.
    /// </summary>
    public class SoftwarePackage
    {
        [JsonExtensionData]
        private readonly IDictionary<string, JToken> additionalProperties;

        private readonly IEnumerable<string> propertyName;

        /// <summary>
        /// Get or set the value associated with the specified key in the AdditionalProperties dictionary.
        /// </summary>
        /// <param name="key">The key of the value to get or set. This must be a valid key that is not reserved for internal properties.</param>
        /// <returns>The object value associated with the specified key in the AdditionalProperties dictionary.</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="key"/> is null or an empty string.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when the specified <paramref name="key"/> conflicts with an internal property of the object.
        /// </exception>
        /// <exception cref="KeyNotFoundException">
        /// Thrown when the specified <paramref name="key"/> does not exist in the AdditionalProperties dictionary.
        /// </exception>
        [IndexerName("AdditionalPropertiesIndexer")]
        public object this[string key]
        {
            get => additionalProperties.GetValue<object>(key);
            set => additionalProperties.SetValue(key, value, propertyName);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwarePackage"/> class.
        /// </summary>
        public SoftwarePackage()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwarePackage"/> class.
        /// </summary>
        /// <param name="softwareName">softwareName.</param>
        /// <param name="launchDate">launchDate.</param>
        /// <param name="model">model.</param>
        /// <param name="make">make.</param>
        /// <param name="distributionType">distributionType.</param>
        /// <param name="devicePlatformId">devicePlatformId.</param>
        /// <param name="releaseNote">releaseNote.</param>
        public SoftwarePackage(
            string softwareName,
            DateTime launchDate,
            string model,
            string make,
            string distributionType,
            string devicePlatformId,
            string releaseNote = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.SoftwareName = softwareName;
            this.LaunchDate = launchDate;
            this.ReleaseNote = releaseNote;
            this.Model = model;
            this.Make = make;
            this.DistributionType = distributionType;
            this.DevicePlatformId = devicePlatformId;
        }

        /// <summary>
        /// Software name.
        /// </summary>
        [JsonProperty("softwareName")]
        public string SoftwareName { get; set; }

        /// <summary>
        /// Software launch date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("launchDate")]
        public DateTime LaunchDate { get; set; }

        /// <summary>
        /// Software release note reserved for future use.
        /// </summary>
        [JsonProperty("releaseNote", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseNote { get; set; }

        /// <summary>
        /// Software applicable device model.
        /// </summary>
        [JsonProperty("model")]
        public string Model { get; set; }

        /// <summary>
        /// Software applicable device make.
        /// </summary>
        [JsonProperty("make")]
        public string Make { get; set; }

        /// <summary>
        /// LWM2M, OMD-DM or HTTP.
        /// </summary>
        [JsonProperty("distributionType")]
        public string DistributionType { get; set; }

        /// <summary>
        /// The platform (Android, iOS, etc.) that the software can be applied to.
        /// </summary>
        [JsonProperty("devicePlatformId")]
        public string DevicePlatformId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SoftwarePackage : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SoftwarePackage other &&
                (this.SoftwareName == null && other.SoftwareName == null ||
                 this.SoftwareName?.Equals(other.SoftwareName) == true) &&
                (this.LaunchDate.Equals(other.LaunchDate)) &&
                (this.ReleaseNote == null && other.ReleaseNote == null ||
                 this.ReleaseNote?.Equals(other.ReleaseNote) == true) &&
                (this.Model == null && other.Model == null ||
                 this.Model?.Equals(other.Model) == true) &&
                (this.Make == null && other.Make == null ||
                 this.Make?.Equals(other.Make) == true) &&
                (this.DistributionType == null && other.DistributionType == null ||
                 this.DistributionType?.Equals(other.DistributionType) == true) &&
                (this.DevicePlatformId == null && other.DevicePlatformId == null ||
                 this.DevicePlatformId?.Equals(other.DevicePlatformId) == true) &&
                (this.additionalProperties == null && other.additionalProperties == null ||
                 this.additionalProperties?.Count == other.additionalProperties?.Count &&
                 this.additionalProperties?.All(kv =>
                     other.additionalProperties.TryGetValue(kv.Key, out var value) &&
                     JToken.DeepEquals(kv.Value, value)) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SoftwareName = {this.SoftwareName ?? "null"}");
            toStringOutput.Add($"LaunchDate = {this.LaunchDate}");
            toStringOutput.Add($"ReleaseNote = {this.ReleaseNote ?? "null"}");
            toStringOutput.Add($"Model = {this.Model ?? "null"}");
            toStringOutput.Add($"Make = {this.Make ?? "null"}");
            toStringOutput.Add($"DistributionType = {this.DistributionType ?? "null"}");
            toStringOutput.Add($"DevicePlatformId = {this.DevicePlatformId ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}