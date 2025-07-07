// <copyright file="AccountLevelUpdateTrigger.cs" company="APIMatic">
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
    /// AccountLevelUpdateTrigger.
    /// </summary>
    public class AccountLevelUpdateTrigger
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLevelUpdateTrigger"/> class.
        /// </summary>
        public AccountLevelUpdateTrigger()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLevelUpdateTrigger"/> class.
        /// </summary>
        /// <param name="triggerId">triggerId.</param>
        /// <param name="triggerName">triggerName.</param>
        /// <param name="ecpdId">ecpdId.</param>
        /// <param name="triggerCategory">triggerCategory.</param>
        /// <param name="dataTrigger">dataTrigger.</param>
        /// <param name="notification">notification.</param>
        public AccountLevelUpdateTrigger(
            string triggerId = null,
            string triggerName = null,
            string ecpdId = null,
            Models.TriggerCategory? triggerCategory = null,
            Models.DataTrigger1 dataTrigger = null,
            Models.Notificationarray notification = null)
        {
            this.TriggerId = triggerId;
            this.TriggerName = triggerName;
            this.EcpdId = ecpdId;
            this.TriggerCategory = triggerCategory;
            this.DataTrigger = dataTrigger;
            this.Notification = notification;
        }

        /// <summary>
        /// The system assigned UUID of the trigger
        /// </summary>
        [JsonProperty("triggerId", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerId { get; set; }

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
        public Models.DataTrigger1 DataTrigger { get; set; }

        /// <summary>
        /// Gets or sets Notification.
        /// </summary>
        [JsonProperty("notification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Notificationarray Notification { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AccountLevelUpdateTrigger : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AccountLevelUpdateTrigger other &&
                (this.TriggerId == null && other.TriggerId == null ||
                 this.TriggerId?.Equals(other.TriggerId) == true) &&
                (this.TriggerName == null && other.TriggerName == null ||
                 this.TriggerName?.Equals(other.TriggerName) == true) &&
                (this.EcpdId == null && other.EcpdId == null ||
                 this.EcpdId?.Equals(other.EcpdId) == true) &&
                (this.TriggerCategory == null && other.TriggerCategory == null ||
                 this.TriggerCategory?.Equals(other.TriggerCategory) == true) &&
                (this.DataTrigger == null && other.DataTrigger == null ||
                 this.DataTrigger?.Equals(other.DataTrigger) == true) &&
                (this.Notification == null && other.Notification == null ||
                 this.Notification?.Equals(other.Notification) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TriggerId = {this.TriggerId ?? "null"}");
            toStringOutput.Add($"TriggerName = {this.TriggerName ?? "null"}");
            toStringOutput.Add($"EcpdId = {this.EcpdId ?? "null"}");
            toStringOutput.Add($"TriggerCategory = {(this.TriggerCategory == null ? "null" : this.TriggerCategory.ToString())}");
            toStringOutput.Add($"DataTrigger = {(this.DataTrigger == null ? "null" : this.DataTrigger.ToString())}");
            toStringOutput.Add($"Notification = {(this.Notification == null ? "null" : this.Notification.ToString())}");
        }
    }
}