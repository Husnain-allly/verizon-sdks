// <copyright file="AggregateSessionReportRequest.cs" company="APIMatic">
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
    /// AggregateSessionReportRequest.
    /// </summary>
    public class AggregateSessionReportRequest
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

        private string deviceGroup;
        private string deviceLabel;
        private string dataPlan;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "deviceGroup", false },
            { "deviceLabel", false },
            { "dataPlan", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateSessionReportRequest"/> class.
        /// </summary>
        public AggregateSessionReportRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateSessionReportRequest"/> class.
        /// </summary>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="imei">imei.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="deviceGroup">deviceGroup.</param>
        /// <param name="deviceLabel">deviceLabel.</param>
        /// <param name="dataPlan">dataPlan.</param>
        /// <param name="noSessionFlag">noSessionFlag.</param>
        public AggregateSessionReportRequest(
            string accountNumber,
            List<string> imei,
            string startDate = null,
            string endDate = null,
            string deviceGroup = null,
            string deviceLabel = null,
            string dataPlan = null,
            string noSessionFlag = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.AccountNumber = accountNumber;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Imei = imei;

            if (deviceGroup != null)
            {
                this.DeviceGroup = deviceGroup;
            }

            if (deviceLabel != null)
            {
                this.DeviceLabel = deviceLabel;
            }

            if (dataPlan != null)
            {
                this.DataPlan = dataPlan;
            }
            this.NoSessionFlag = noSessionFlag;
        }

        /// <summary>
        /// The unique identifier for the account.
        /// </summary>
        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Start date of session to include. If not specified  information will be shown from the earliest available (180 days). Can be either date in ISO 8601 format or predefined constants.
        /// </summary>
        [JsonProperty("startDate", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// End date of session to include. If not specified  information will be shown to the latest available. Can be either date in ISO 8601 format or predefined constants.
        /// </summary>
        [JsonProperty("endDate", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// Devices for which return usage info. Could be 0, 1 or more. In case of 0 will return all devices belonging to customer (except of filtered by other parameters).
        /// </summary>
        [JsonProperty("imei")]
        public List<string> Imei { get; set; }

        /// <summary>
        /// User defined group name the devices are a member of.
        /// </summary>
        [JsonProperty("deviceGroup")]
        public string DeviceGroup
        {
            get
            {
                return this.deviceGroup;
            }

            set
            {
                this.shouldSerialize["deviceGroup"] = true;
                this.deviceGroup = value;
            }
        }

        /// <summary>
        /// Optional filter parameter.
        /// </summary>
        [JsonProperty("deviceLabel")]
        public string DeviceLabel
        {
            get
            {
                return this.deviceLabel;
            }

            set
            {
                this.shouldSerialize["deviceLabel"] = true;
                this.deviceLabel = value;
            }
        }

        /// <summary>
        /// The data plan the devices beign queried belong to.
        /// </summary>
        [JsonProperty("dataPlan")]
        public string DataPlan
        {
            get
            {
                return this.dataPlan;
            }

            set
            {
                this.shouldSerialize["dataPlan"] = true;
                this.dataPlan = value;
            }
        }

        /// <summary>
        /// Optional filter parameter which return only devices with no sessions.
        /// </summary>
        [JsonProperty("noSessionFlag", NullValueHandling = NullValueHandling.Ignore)]
        public string NoSessionFlag { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AggregateSessionReportRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDeviceGroup()
        {
            this.shouldSerialize["deviceGroup"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDeviceLabel()
        {
            this.shouldSerialize["deviceLabel"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDataPlan()
        {
            this.shouldSerialize["dataPlan"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeviceGroup()
        {
            return this.shouldSerialize["deviceGroup"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeviceLabel()
        {
            return this.shouldSerialize["deviceLabel"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDataPlan()
        {
            return this.shouldSerialize["dataPlan"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AggregateSessionReportRequest other &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.StartDate == null && other.StartDate == null ||
                 this.StartDate?.Equals(other.StartDate) == true) &&
                (this.EndDate == null && other.EndDate == null ||
                 this.EndDate?.Equals(other.EndDate) == true) &&
                (this.Imei == null && other.Imei == null ||
                 this.Imei?.Equals(other.Imei) == true) &&
                (this.DeviceGroup == null && other.DeviceGroup == null ||
                 this.DeviceGroup?.Equals(other.DeviceGroup) == true) &&
                (this.DeviceLabel == null && other.DeviceLabel == null ||
                 this.DeviceLabel?.Equals(other.DeviceLabel) == true) &&
                (this.DataPlan == null && other.DataPlan == null ||
                 this.DataPlan?.Equals(other.DataPlan) == true) &&
                (this.NoSessionFlag == null && other.NoSessionFlag == null ||
                 this.NoSessionFlag?.Equals(other.NoSessionFlag) == true) &&
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
            toStringOutput.Add($"AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"StartDate = {this.StartDate ?? "null"}");
            toStringOutput.Add($"EndDate = {this.EndDate ?? "null"}");
            toStringOutput.Add($"Imei = {(this.Imei == null ? "null" : $"[{string.Join(", ", this.Imei)} ]")}");
            toStringOutput.Add($"DeviceGroup = {this.DeviceGroup ?? "null"}");
            toStringOutput.Add($"DeviceLabel = {this.DeviceLabel ?? "null"}");
            toStringOutput.Add($"DataPlan = {this.DataPlan ?? "null"}");
            toStringOutput.Add($"NoSessionFlag = {this.NoSessionFlag ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}