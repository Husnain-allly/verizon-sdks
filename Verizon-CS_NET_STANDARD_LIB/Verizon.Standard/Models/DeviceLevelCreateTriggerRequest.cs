// <copyright file="DeviceLevelCreateTriggerRequest.cs" company="APIMatic">
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
    /// DeviceLevelCreateTriggerRequest.
    /// </summary>
    public class DeviceLevelCreateTriggerRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceLevelCreateTriggerRequest"/> class.
        /// </summary>
        public DeviceLevelCreateTriggerRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceLevelCreateTriggerRequest"/> class.
        /// </summary>
        /// <param name="triggerName">triggerName.</param>
        /// <param name="ecpdId">ecpdId.</param>
        /// <param name="triggerCategory">triggerCategory.</param>
        /// <param name="dataTrigger">dataTrigger.</param>
        /// <param name="notification">notification.</param>
        /// <param name="active">active.</param>
        public DeviceLevelCreateTriggerRequest(
            string triggerName = null,
            string ecpdId = null,
            Models.TriggerCategory? triggerCategory = null,
            Models.DataTrigger2 dataTrigger = null,
            Models.Notificationarray notification = null,
            Models.Active? active = null)
        {
            this.TriggerName = triggerName;
            this.EcpdId = ecpdId;
            this.TriggerCategory = triggerCategory;
            this.DataTrigger = dataTrigger;
            this.Notification = notification;
            this.Active = active;
        }

        /// <summary>
        /// The user defined name of the trigger
        /// </summary>
        [JsonProperty("triggerName", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerName { get; set; }

        /// <summary>
        /// The Enterprise Customer Profile Database ID
        /// </summary>
        [JsonProperty("ecpdId", NullValueHandling = NullValueHandling.Ignore)]
        public string EcpdId { get; set; }

        /// <summary>
        /// The type of trigger being created or modified
        /// </summary>
        [JsonProperty("triggerCategory", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TriggerCategory? TriggerCategory { get; set; }

        /// <summary>
        /// Gets or sets DataTrigger.
        /// </summary>
        [JsonProperty("dataTrigger", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DataTrigger2 DataTrigger { get; set; }

        /// <summary>
        /// Gets or sets Notification.
        /// </summary>
        [JsonProperty("notification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Notificationarray Notification { get; set; }

        /// <summary>
        /// A flag to indicate of the trigger is active, true, or not, false
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Active? Active { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeviceLevelCreateTriggerRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeviceLevelCreateTriggerRequest other &&
                (this.TriggerName == null && other.TriggerName == null ||
                 this.TriggerName?.Equals(other.TriggerName) == true) &&
                (this.EcpdId == null && other.EcpdId == null ||
                 this.EcpdId?.Equals(other.EcpdId) == true) &&
                (this.TriggerCategory == null && other.TriggerCategory == null ||
                 this.TriggerCategory?.Equals(other.TriggerCategory) == true) &&
                (this.DataTrigger == null && other.DataTrigger == null ||
                 this.DataTrigger?.Equals(other.DataTrigger) == true) &&
                (this.Notification == null && other.Notification == null ||
                 this.Notification?.Equals(other.Notification) == true) &&
                (this.Active == null && other.Active == null ||
                 this.Active?.Equals(other.Active) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TriggerName = {this.TriggerName ?? "null"}");
            toStringOutput.Add($"EcpdId = {this.EcpdId ?? "null"}");
            toStringOutput.Add($"TriggerCategory = {(this.TriggerCategory == null ? "null" : this.TriggerCategory.ToString())}");
            toStringOutput.Add($"DataTrigger = {(this.DataTrigger == null ? "null" : this.DataTrigger.ToString())}");
            toStringOutput.Add($"Notification = {(this.Notification == null ? "null" : this.Notification.ToString())}");
            toStringOutput.Add($"Active = {(this.Active == null ? "null" : this.Active.ToString())}");
        }
    }
}