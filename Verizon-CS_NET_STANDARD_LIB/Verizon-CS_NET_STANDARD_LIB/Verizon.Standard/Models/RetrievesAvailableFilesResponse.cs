// <copyright file="RetrievesAvailableFilesResponse.cs" company="APIMatic">
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
    /// RetrievesAvailableFilesResponse.
    /// </summary>
    public class RetrievesAvailableFilesResponse
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
        /// Initializes a new instance of the <see cref="RetrievesAvailableFilesResponse"/> class.
        /// </summary>
        public RetrievesAvailableFilesResponse()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievesAvailableFilesResponse"/> class.
        /// </summary>
        /// <param name="fileName">fileName.</param>
        /// <param name="fileVersion">fileVersion.</param>
        /// <param name="releaseNote">releaseNote.</param>
        /// <param name="make">make.</param>
        /// <param name="model">model.</param>
        /// <param name="localTargetPath">localTargetPath.</param>
        /// <param name="distributionType">distributionType.</param>
        /// <param name="devicePlatformId">devicePlatformId.</param>
        public RetrievesAvailableFilesResponse(
            string fileName = null,
            string fileVersion = null,
            string releaseNote = null,
            string make = null,
            string model = null,
            string localTargetPath = null,
            string distributionType = null,
            string devicePlatformId = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.FileName = fileName;
            this.FileVersion = fileVersion;
            this.ReleaseNote = releaseNote;
            this.Make = make;
            this.Model = model;
            this.LocalTargetPath = localTargetPath;
            this.DistributionType = distributionType;
            this.DevicePlatformId = devicePlatformId;
        }

        /// <summary>
        /// ThingSpace-generated name of the file. You will use this name when listing or scheduling campaigns for the file.
        /// </summary>
        [JsonProperty("fileName", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// Version of the file.
        /// </summary>
        [JsonProperty("fileVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string FileVersion { get; set; }

        /// <summary>
        /// Software release note.
        /// </summary>
        [JsonProperty("releaseNote", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseNote { get; set; }

        /// <summary>
        /// The software-applicable device make.
        /// </summary>
        [JsonProperty("make", NullValueHandling = NullValueHandling.Ignore)]
        public string Make { get; set; }

        /// <summary>
        /// The software-applicable device model.
        /// </summary>
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        /// <summary>
        /// Local target path on the device.
        /// </summary>
        [JsonProperty("localTargetPath", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalTargetPath { get; set; }

        /// <summary>
        /// Valid values
        /// </summary>
        [JsonProperty("distributionType", NullValueHandling = NullValueHandling.Ignore)]
        public string DistributionType { get; set; }

        /// <summary>
        /// The platform (Android, iOS, etc.,) that the software can be applied to.
        /// </summary>
        [JsonProperty("devicePlatformId", NullValueHandling = NullValueHandling.Ignore)]
        public string DevicePlatformId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RetrievesAvailableFilesResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RetrievesAvailableFilesResponse other &&
                (this.FileName == null && other.FileName == null ||
                 this.FileName?.Equals(other.FileName) == true) &&
                (this.FileVersion == null && other.FileVersion == null ||
                 this.FileVersion?.Equals(other.FileVersion) == true) &&
                (this.ReleaseNote == null && other.ReleaseNote == null ||
                 this.ReleaseNote?.Equals(other.ReleaseNote) == true) &&
                (this.Make == null && other.Make == null ||
                 this.Make?.Equals(other.Make) == true) &&
                (this.Model == null && other.Model == null ||
                 this.Model?.Equals(other.Model) == true) &&
                (this.LocalTargetPath == null && other.LocalTargetPath == null ||
                 this.LocalTargetPath?.Equals(other.LocalTargetPath) == true) &&
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
            toStringOutput.Add($"FileName = {this.FileName ?? "null"}");
            toStringOutput.Add($"FileVersion = {this.FileVersion ?? "null"}");
            toStringOutput.Add($"ReleaseNote = {this.ReleaseNote ?? "null"}");
            toStringOutput.Add($"Make = {this.Make ?? "null"}");
            toStringOutput.Add($"Model = {this.Model ?? "null"}");
            toStringOutput.Add($"LocalTargetPath = {this.LocalTargetPath ?? "null"}");
            toStringOutput.Add($"DistributionType = {this.DistributionType ?? "null"}");
            toStringOutput.Add($"DevicePlatformId = {this.DevicePlatformId ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}