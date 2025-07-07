// <copyright file="AccountLevelUpdateTriggerRequest.cs" company="APIMatic">
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
    /// AccountLevelUpdateTriggerRequest.
    /// </summary>
    public class AccountLevelUpdateTriggerRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLevelUpdateTriggerRequest"/> class.
        /// </summary>
        public AccountLevelUpdateTriggerRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLevelUpdateTriggerRequest"/> class.
        /// </summary>
        /// <param name="triggerId">triggerId.</param>
        /// <param name="triggerName">triggerName.</param>
        /// <param name="ecpdId">ecpdId.</param>
        /// <param name="triggerCategory">triggerCategory.</param>
        /// <param name="dataTrigger">dataTrigger.</param>
        /// <param name="notification">notification.</param>
        /// <param name="notificationType">notificationType.</param>
        /// <param name="callback">callback.</param>
        /// <param name="emailNotification">emailNotification.</param>
        /// <param name="notificationGroupName">notificationGroupName.</param>
        /// <param name="notificationFrequencyFactor">notificationFrequencyFactor.</param>
        /// <param name="notificationFrequencyInterval">notificationFrequencyInterval.</param>
        /// <param name="externalEmailRecipients">externalEmailRecipients.</param>
        /// <param name="smsNotification">smsNotification.</param>
        /// <param name="smsNumbers">smsNumbers.</param>
        /// <param name="reminder">reminder.</param>
        /// <param name="severity">severity.</param>
        /// <param name="active">active.</param>
        public AccountLevelUpdateTriggerRequest(
            string triggerId = null,
            string triggerName = null,
            string ecpdId = null,
            Models.TriggerCategory? triggerCategory = null,
            Models.DataTrigger1 dataTrigger = null,
            Models.Notificationarray notification = null,
            string notificationType = null,
            bool? callback = null,
            bool? emailNotification = null,
            string notificationGroupName = null,
            int? notificationFrequencyFactor = null,
            string notificationFrequencyInterval = null,
            string externalEmailRecipients = null,
            bool? smsNotification = null,
            List<Models.Cellphonenumber> smsNumbers = null,
            bool? reminder = null,
            string severity = null,
            Models.Active? active = null)
        {
            this.TriggerId = triggerId;
            this.TriggerName = triggerName;
            this.EcpdId = ecpdId;
            this.TriggerCategory = triggerCategory;
            this.DataTrigger = dataTrigger;
            this.Notification = notification;
            this.NotificationType = notificationType;
            this.Callback = callback;
            this.EmailNotification = emailNotification;
            this.NotificationGroupName = notificationGroupName;
            this.NotificationFrequencyFactor = notificationFrequencyFactor;
            this.NotificationFrequencyInterval = notificationFrequencyInterval;
            this.ExternalEmailRecipients = externalEmailRecipients;
            this.SmsNotification = smsNotification;
            this.SmsNumbers = smsNumbers;
            this.Reminder = reminder;
            this.Severity = severity;
            this.Active = active;
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

        /// <summary>
        /// Gets or sets NotificationType.
        /// </summary>
        [JsonProperty("notificationType", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationType { get; set; }

        /// <summary>
        /// Gets or sets Callback.
        /// </summary>
        [JsonProperty("callback", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Callback { get; set; }

        /// <summary>
        /// Gets or sets EmailNotification.
        /// </summary>
        [JsonProperty("emailNotification", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EmailNotification { get; set; }

        /// <summary>
        /// Gets or sets NotificationGroupName.
        /// </summary>
        [JsonProperty("notificationGroupName", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationGroupName { get; set; }

        /// <summary>
        /// Gets or sets NotificationFrequencyFactor.
        /// </summary>
        [JsonProperty("notificationFrequencyFactor", NullValueHandling = NullValueHandling.Ignore)]
        public int? NotificationFrequencyFactor { get; set; }

        /// <summary>
        /// Gets or sets NotificationFrequencyInterval.
        /// </summary>
        [JsonProperty("notificationFrequencyInterval", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationFrequencyInterval { get; set; }

        /// <summary>
        /// Gets or sets ExternalEmailRecipients.
        /// </summary>
        [JsonProperty("externalEmailRecipients", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalEmailRecipients { get; set; }

        /// <summary>
        /// Gets or sets SmsNotification.
        /// </summary>
        [JsonProperty("smsNotification", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SmsNotification { get; set; }

        /// <summary>
        /// Gets or sets SmsNumbers.
        /// </summary>
        [JsonProperty("smsNumbers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Cellphonenumber> SmsNumbers { get; set; }

        /// <summary>
        /// Gets or sets Reminder.
        /// </summary>
        [JsonProperty("reminder", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reminder { get; set; }

        /// <summary>
        /// Gets or sets Severity.
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public string Severity { get; set; }

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
            return $"AccountLevelUpdateTriggerRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AccountLevelUpdateTriggerRequest other &&
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
                 this.Notification?.Equals(other.Notification) == true) &&
                (this.NotificationType == null && other.NotificationType == null ||
                 this.NotificationType?.Equals(other.NotificationType) == true) &&
                (this.Callback == null && other.Callback == null ||
                 this.Callback?.Equals(other.Callback) == true) &&
                (this.EmailNotification == null && other.EmailNotification == null ||
                 this.EmailNotification?.Equals(other.EmailNotification) == true) &&
                (this.NotificationGroupName == null && other.NotificationGroupName == null ||
                 this.NotificationGroupName?.Equals(other.NotificationGroupName) == true) &&
                (this.NotificationFrequencyFactor == null && other.NotificationFrequencyFactor == null ||
                 this.NotificationFrequencyFactor?.Equals(other.NotificationFrequencyFactor) == true) &&
                (this.NotificationFrequencyInterval == null && other.NotificationFrequencyInterval == null ||
                 this.NotificationFrequencyInterval?.Equals(other.NotificationFrequencyInterval) == true) &&
                (this.ExternalEmailRecipients == null && other.ExternalEmailRecipients == null ||
                 this.ExternalEmailRecipients?.Equals(other.ExternalEmailRecipients) == true) &&
                (this.SmsNotification == null && other.SmsNotification == null ||
                 this.SmsNotification?.Equals(other.SmsNotification) == true) &&
                (this.SmsNumbers == null && other.SmsNumbers == null ||
                 this.SmsNumbers?.Equals(other.SmsNumbers) == true) &&
                (this.Reminder == null && other.Reminder == null ||
                 this.Reminder?.Equals(other.Reminder) == true) &&
                (this.Severity == null && other.Severity == null ||
                 this.Severity?.Equals(other.Severity) == true) &&
                (this.Active == null && other.Active == null ||
                 this.Active?.Equals(other.Active) == true);
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
            toStringOutput.Add($"NotificationType = {this.NotificationType ?? "null"}");
            toStringOutput.Add($"Callback = {(this.Callback == null ? "null" : this.Callback.ToString())}");
            toStringOutput.Add($"EmailNotification = {(this.EmailNotification == null ? "null" : this.EmailNotification.ToString())}");
            toStringOutput.Add($"NotificationGroupName = {this.NotificationGroupName ?? "null"}");
            toStringOutput.Add($"NotificationFrequencyFactor = {(this.NotificationFrequencyFactor == null ? "null" : this.NotificationFrequencyFactor.ToString())}");
            toStringOutput.Add($"NotificationFrequencyInterval = {this.NotificationFrequencyInterval ?? "null"}");
            toStringOutput.Add($"ExternalEmailRecipients = {this.ExternalEmailRecipients ?? "null"}");
            toStringOutput.Add($"SmsNotification = {(this.SmsNotification == null ? "null" : this.SmsNotification.ToString())}");
            toStringOutput.Add($"SmsNumbers = {(this.SmsNumbers == null ? "null" : $"[{string.Join(", ", this.SmsNumbers)} ]")}");
            toStringOutput.Add($"Reminder = {(this.Reminder == null ? "null" : this.Reminder.ToString())}");
            toStringOutput.Add($"Severity = {this.Severity ?? "null"}");
            toStringOutput.Add($"Active = {(this.Active == null ? "null" : this.Active.ToString())}");
        }
    }
}