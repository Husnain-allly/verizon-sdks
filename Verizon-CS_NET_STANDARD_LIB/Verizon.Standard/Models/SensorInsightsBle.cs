// <copyright file="SensorInsightsBle.cs" company="APIMatic">
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
    /// SensorInsightsBle.
    /// </summary>
    public class SensorInsightsBle
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
        /// Initializes a new instance of the <see cref="SensorInsightsBle"/> class.
        /// </summary>
        public SensorInsightsBle()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SensorInsightsBle"/> class.
        /// </summary>
        /// <param name="dataMode">dataMode.</param>
        /// <param name="manufacturerId">manufacturerId.</param>
        /// <param name="maxNumScan">maxNumScan.</param>
        /// <param name="minSigStr">minSigStr.</param>
        /// <param name="monitorPeriod">monitorPeriod.</param>
        /// <param name="moreManufId">moreManufId.</param>
        /// <param name="opMode">opMode.</param>
        /// <param name="reportOffset">reportOffset.</param>
        /// <param name="reportPeriod">reportPeriod.</param>
        /// <param name="reportType">reportType.</param>
        /// <param name="scanDuration">scanDuration.</param>
        public SensorInsightsBle(
            int? dataMode = null,
            int? manufacturerId = null,
            int? maxNumScan = null,
            int? minSigStr = null,
            int? monitorPeriod = null,
            object moreManufId = null,
            int? opMode = null,
            int? reportOffset = null,
            int? reportPeriod = null,
            int? reportType = null,
            int? scanDuration = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.DataMode = dataMode;
            this.ManufacturerId = manufacturerId;
            this.MaxNumScan = maxNumScan;
            this.MinSigStr = minSigStr;
            this.MonitorPeriod = monitorPeriod;
            this.MoreManufId = moreManufId;
            this.OpMode = opMode;
            this.ReportOffset = reportOffset;
            this.ReportPeriod = reportPeriod;
            this.ReportType = reportType;
            this.ScanDuration = scanDuration;
        }

        /// <summary>
        /// The data mode the sensor is using
        /// </summary>
        [JsonProperty("dataMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? DataMode { get; set; }

        /// <summary>
        /// The numeric manufacturer ID
        /// </summary>
        [JsonProperty("manufacturerId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ManufacturerId { get; set; }

        /// <summary>
        /// How frequently the device can be scanned
        /// </summary>
        [JsonProperty("maxNumScan", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxNumScan { get; set; }

        /// <summary>
        /// The minimum signal strength needed for the sensor to transmit (in Decibels or dB)
        /// </summary>
        [JsonProperty("minSigStr", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinSigStr { get; set; }

        /// <summary>
        /// The ammount of time to monitor the sensor and varies by device
        /// </summary>
        [JsonProperty("monitorPeriod", NullValueHandling = NullValueHandling.Ignore)]
        public int? MonitorPeriod { get; set; }

        /// <summary>
        /// Values for the manufacturer and these vary by device
        /// </summary>
        [JsonProperty("moreManufId", NullValueHandling = NullValueHandling.Ignore)]
        public object MoreManufId { get; set; }

        /// <summary>
        /// The operation mode
        /// </summary>
        [JsonProperty("opMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? OpMode { get; set; }

        /// <summary>
        /// The ammount of time between sensor readings and reports
        /// </summary>
        [JsonProperty("reportOffset", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReportOffset { get; set; }

        /// <summary>
        /// The ammount of time between reports
        /// </summary>
        [JsonProperty("reportPeriod", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReportPeriod { get; set; }

        /// <summary>
        /// The report type
        /// </summary>
        [JsonProperty("reportType", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReportType { get; set; }

        /// <summary>
        /// The ammount of time the sensor is queried for data
        /// </summary>
        [JsonProperty("scanDuration", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScanDuration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SensorInsightsBle : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SensorInsightsBle other &&
                (this.DataMode == null && other.DataMode == null ||
                 this.DataMode?.Equals(other.DataMode) == true) &&
                (this.ManufacturerId == null && other.ManufacturerId == null ||
                 this.ManufacturerId?.Equals(other.ManufacturerId) == true) &&
                (this.MaxNumScan == null && other.MaxNumScan == null ||
                 this.MaxNumScan?.Equals(other.MaxNumScan) == true) &&
                (this.MinSigStr == null && other.MinSigStr == null ||
                 this.MinSigStr?.Equals(other.MinSigStr) == true) &&
                (this.MonitorPeriod == null && other.MonitorPeriod == null ||
                 this.MonitorPeriod?.Equals(other.MonitorPeriod) == true) &&
                (this.MoreManufId == null && other.MoreManufId == null ||
                 this.MoreManufId?.Equals(other.MoreManufId) == true) &&
                (this.OpMode == null && other.OpMode == null ||
                 this.OpMode?.Equals(other.OpMode) == true) &&
                (this.ReportOffset == null && other.ReportOffset == null ||
                 this.ReportOffset?.Equals(other.ReportOffset) == true) &&
                (this.ReportPeriod == null && other.ReportPeriod == null ||
                 this.ReportPeriod?.Equals(other.ReportPeriod) == true) &&
                (this.ReportType == null && other.ReportType == null ||
                 this.ReportType?.Equals(other.ReportType) == true) &&
                (this.ScanDuration == null && other.ScanDuration == null ||
                 this.ScanDuration?.Equals(other.ScanDuration) == true) &&
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
            toStringOutput.Add($"DataMode = {(this.DataMode == null ? "null" : this.DataMode.ToString())}");
            toStringOutput.Add($"ManufacturerId = {(this.ManufacturerId == null ? "null" : this.ManufacturerId.ToString())}");
            toStringOutput.Add($"MaxNumScan = {(this.MaxNumScan == null ? "null" : this.MaxNumScan.ToString())}");
            toStringOutput.Add($"MinSigStr = {(this.MinSigStr == null ? "null" : this.MinSigStr.ToString())}");
            toStringOutput.Add($"MonitorPeriod = {(this.MonitorPeriod == null ? "null" : this.MonitorPeriod.ToString())}");
            toStringOutput.Add($"MoreManufId = {(this.MoreManufId == null ? "null" : this.MoreManufId.ToString())}");
            toStringOutput.Add($"OpMode = {(this.OpMode == null ? "null" : this.OpMode.ToString())}");
            toStringOutput.Add($"ReportOffset = {(this.ReportOffset == null ? "null" : this.ReportOffset.ToString())}");
            toStringOutput.Add($"ReportPeriod = {(this.ReportPeriod == null ? "null" : this.ReportPeriod.ToString())}");
            toStringOutput.Add($"ReportType = {(this.ReportType == null ? "null" : this.ReportType.ToString())}");
            toStringOutput.Add($"ScanDuration = {(this.ScanDuration == null ? "null" : this.ScanDuration.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}