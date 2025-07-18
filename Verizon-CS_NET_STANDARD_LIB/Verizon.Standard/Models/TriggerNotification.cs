// <copyright file="TriggerNotification.cs" company="APIMatic">
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
    /// TriggerNotification.
    /// </summary>
    public class TriggerNotification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNotification"/> class.
        /// </summary>
        public TriggerNotification()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNotification"/> class.
        /// </summary>
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
        public TriggerNotification(
            string notificationType = null,
            bool? callback = null,
            bool? emailNotification = null,
            string notificationGroupName = null,
            int? notificationFrequencyFactor = null,
            string notificationFrequencyInterval = null,
            string externalEmailRecipients = null,
            bool? smsNotification = null,
            List<Models.SmsNumber> smsNumbers = null,
            bool? reminder = null,
            string severity = null)
        {
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
        }

        /// <summary>
        /// The type of notification, i.e. 'DailySummary'.
        /// </summary>
        [JsonProperty("notificationType", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationType { get; set; }

        /// <summary>
        /// Whether or not the notification should be sent via callback.<br />true<br />false.
        /// </summary>
        [JsonProperty("callback", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Callback { get; set; }

        /// <summary>
        /// Whether or not the notification should be sent via e-mail.<br />true<br />false.
        /// </summary>
        [JsonProperty("emailNotification", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EmailNotification { get; set; }

        /// <summary>
        /// Name for the notification group.
        /// </summary>
        [JsonProperty("notificationGroupName", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationGroupName { get; set; }

        /// <summary>
        /// Frequency factor for notification.
        /// </summary>
        [JsonProperty("notificationFrequencyFactor", NullValueHandling = NullValueHandling.Ignore)]
        public int? NotificationFrequencyFactor { get; set; }

        /// <summary>
        /// Frequency interval for notification.
        /// </summary>
        [JsonProperty("notificationFrequencyInterval", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationFrequencyInterval { get; set; }

        /// <summary>
        /// E-mail address(es) where the notification should be delivered.
        /// </summary>
        [JsonProperty("externalEmailRecipients", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalEmailRecipients { get; set; }

        /// <summary>
        /// SMS notification.
        /// </summary>
        [JsonProperty("smsNotification", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SmsNotification { get; set; }

        /// <summary>
        /// List of SMS numbers.
        /// </summary>
        [JsonProperty("smsNumbers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SmsNumber> SmsNumbers { get; set; }

        /// <summary>
        /// Gets or sets Reminder.
        /// </summary>
        [JsonProperty("reminder", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reminder { get; set; }

        /// <summary>
        /// Severity level associated with the notification. Examples would be:<br />Major<br />Minor<br />Critical<br />NotApplicable.
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public string Severity { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TriggerNotification : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is TriggerNotification other &&
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
                 this.Severity?.Equals(other.Severity) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
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
        }
    }
}