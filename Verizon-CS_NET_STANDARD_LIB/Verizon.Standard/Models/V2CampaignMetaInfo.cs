// <copyright file="V2CampaignMetaInfo.cs" company="APIMatic">
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
    /// V2CampaignMetaInfo.
    /// </summary>
    public class V2CampaignMetaInfo
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
        /// Initializes a new instance of the <see cref="V2CampaignMetaInfo"/> class.
        /// </summary>
        public V2CampaignMetaInfo()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2CampaignMetaInfo"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="id">id.</param>
        /// <param name="softwareName">softwareName.</param>
        /// <param name="distributionType">distributionType.</param>
        /// <param name="softwareFrom">softwareFrom.</param>
        /// <param name="softwareTo">softwareTo.</param>
        /// <param name="make">make.</param>
        /// <param name="model">model.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="status">status.</param>
        /// <param name="campaignName">campaignName.</param>
        /// <param name="downloadAfterDate">downloadAfterDate.</param>
        /// <param name="downloadTimeWindowList">downloadTimeWindowList.</param>
        /// <param name="installAfterDate">installAfterDate.</param>
        /// <param name="installTimeWindowList">installTimeWindowList.</param>
        public V2CampaignMetaInfo(
            string accountName,
            string id,
            string softwareName,
            string distributionType,
            string softwareFrom,
            string softwareTo,
            string make,
            string model,
            DateTime startDate,
            DateTime endDate,
            string status,
            string campaignName = null,
            DateTime? downloadAfterDate = null,
            List<Models.V2TimeWindow> downloadTimeWindowList = null,
            DateTime? installAfterDate = null,
            List<Models.V2TimeWindow> installTimeWindowList = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountName = accountName;
            this.Id = id;
            this.CampaignName = campaignName;
            this.SoftwareName = softwareName;
            this.DistributionType = distributionType;
            this.SoftwareFrom = softwareFrom;
            this.SoftwareTo = softwareTo;
            this.Make = make;
            this.Model = model;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.DownloadAfterDate = downloadAfterDate;
            this.DownloadTimeWindowList = downloadTimeWindowList;
            this.InstallAfterDate = installAfterDate;
            this.InstallTimeWindowList = installTimeWindowList;
            this.Status = status;
        }

        /// <summary>
        /// Account identifier.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Campaign identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Campaign name.
        /// </summary>
        [JsonProperty("campaignName", NullValueHandling = NullValueHandling.Ignore)]
        public string CampaignName { get; set; }

        /// <summary>
        /// Software name.
        /// </summary>
        [JsonProperty("softwareName")]
        public string SoftwareName { get; set; }

        /// <summary>
        /// LWM2M, OMD-DM or HTTP.
        /// </summary>
        [JsonProperty("distributionType")]
        public string DistributionType { get; set; }

        /// <summary>
        /// Old software name.
        /// </summary>
        [JsonProperty("softwareFrom")]
        public string SoftwareFrom { get; set; }

        /// <summary>
        /// New software name.
        /// </summary>
        [JsonProperty("softwareTo")]
        public string SoftwareTo { get; set; }

        /// <summary>
        /// Applicable make.
        /// </summary>
        [JsonProperty("make")]
        public string Make { get; set; }

        /// <summary>
        /// Applicable model.
        /// </summary>
        [JsonProperty("model")]
        public string Model { get; set; }

        /// <summary>
        /// Campaign start date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Campaign end date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Specifies starting date client should download package. If null, client will download as soon as possible.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("downloadAfterDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DownloadAfterDate { get; set; }

        /// <summary>
        /// List of allowed download time windows.
        /// </summary>
        [JsonProperty("downloadTimeWindowList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.V2TimeWindow> DownloadTimeWindowList { get; set; }

        /// <summary>
        /// Client will install package after date. If null, client will install as soon as possible.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("installAfterDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? InstallAfterDate { get; set; }

        /// <summary>
        /// List of allowed install time windows.
        /// </summary>
        [JsonProperty("installTimeWindowList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.V2TimeWindow> InstallTimeWindowList { get; set; }

        /// <summary>
        /// Software upgrade status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"V2CampaignMetaInfo : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is V2CampaignMetaInfo other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.CampaignName == null && other.CampaignName == null ||
                 this.CampaignName?.Equals(other.CampaignName) == true) &&
                (this.SoftwareName == null && other.SoftwareName == null ||
                 this.SoftwareName?.Equals(other.SoftwareName) == true) &&
                (this.DistributionType == null && other.DistributionType == null ||
                 this.DistributionType?.Equals(other.DistributionType) == true) &&
                (this.SoftwareFrom == null && other.SoftwareFrom == null ||
                 this.SoftwareFrom?.Equals(other.SoftwareFrom) == true) &&
                (this.SoftwareTo == null && other.SoftwareTo == null ||
                 this.SoftwareTo?.Equals(other.SoftwareTo) == true) &&
                (this.Make == null && other.Make == null ||
                 this.Make?.Equals(other.Make) == true) &&
                (this.Model == null && other.Model == null ||
                 this.Model?.Equals(other.Model) == true) &&
                (this.StartDate.Equals(other.StartDate)) &&
                (this.EndDate.Equals(other.EndDate)) &&
                (this.DownloadAfterDate == null && other.DownloadAfterDate == null ||
                 this.DownloadAfterDate?.Equals(other.DownloadAfterDate) == true) &&
                (this.DownloadTimeWindowList == null && other.DownloadTimeWindowList == null ||
                 this.DownloadTimeWindowList?.Equals(other.DownloadTimeWindowList) == true) &&
                (this.InstallAfterDate == null && other.InstallAfterDate == null ||
                 this.InstallAfterDate?.Equals(other.InstallAfterDate) == true) &&
                (this.InstallTimeWindowList == null && other.InstallTimeWindowList == null ||
                 this.InstallTimeWindowList?.Equals(other.InstallTimeWindowList) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
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
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"CampaignName = {this.CampaignName ?? "null"}");
            toStringOutput.Add($"SoftwareName = {this.SoftwareName ?? "null"}");
            toStringOutput.Add($"DistributionType = {this.DistributionType ?? "null"}");
            toStringOutput.Add($"SoftwareFrom = {this.SoftwareFrom ?? "null"}");
            toStringOutput.Add($"SoftwareTo = {this.SoftwareTo ?? "null"}");
            toStringOutput.Add($"Make = {this.Make ?? "null"}");
            toStringOutput.Add($"Model = {this.Model ?? "null"}");
            toStringOutput.Add($"StartDate = {this.StartDate}");
            toStringOutput.Add($"EndDate = {this.EndDate}");
            toStringOutput.Add($"DownloadAfterDate = {(this.DownloadAfterDate == null ? "null" : this.DownloadAfterDate.ToString())}");
            toStringOutput.Add($"DownloadTimeWindowList = {(this.DownloadTimeWindowList == null ? "null" : $"[{string.Join(", ", this.DownloadTimeWindowList)} ]")}");
            toStringOutput.Add($"InstallAfterDate = {(this.InstallAfterDate == null ? "null" : this.InstallAfterDate.ToString())}");
            toStringOutput.Add($"InstallTimeWindowList = {(this.InstallTimeWindowList == null ? "null" : $"[{string.Join(", ", this.InstallTimeWindowList)} ]")}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}