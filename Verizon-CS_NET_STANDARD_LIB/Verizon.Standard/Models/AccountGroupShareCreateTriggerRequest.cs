// <copyright file="AccountGroupShareCreateTriggerRequest.cs" company="APIMatic">
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
    /// AccountGroupShareCreateTriggerRequest.
    /// </summary>
    public class AccountGroupShareCreateTriggerRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGroupShareCreateTriggerRequest"/> class.
        /// </summary>
        public AccountGroupShareCreateTriggerRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGroupShareCreateTriggerRequest"/> class.
        /// </summary>
        /// <param name="triggerName">triggerName.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="triggerCategory">triggerCategory.</param>
        /// <param name="pricePlanTrigger">pricePlanTrigger.</param>
        /// <param name="notification">notification.</param>
        /// <param name="active">active.</param>
        public AccountGroupShareCreateTriggerRequest(
            string triggerName = null,
            string accountName = null,
            Models.TriggerCategory? triggerCategory = null,
            Models.AccountGroupShareObject pricePlanTrigger = null,
            Models.Notificationarray notification = null,
            Models.Active? active = null)
        {
            this.TriggerName = triggerName;
            this.AccountName = accountName;
            this.TriggerCategory = triggerCategory;
            this.PricePlanTrigger = pricePlanTrigger;
            this.Notification = notification;
            this.Active = active;
        }

        /// <summary>
        /// The user defined name of the trigger
        /// </summary>
        [JsonProperty("triggerName", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerName { get; set; }

        /// <summary>
        /// The numeric name of the account and must include leading zeroes
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The type of trigger being created or modified
        /// </summary>
        [JsonProperty("triggerCategory", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TriggerCategory? TriggerCategory { get; set; }

        /// <summary>
        /// Gets or sets PricePlanTrigger.
        /// </summary>
        [JsonProperty("pricePlanTrigger", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountGroupShareObject PricePlanTrigger { get; set; }

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
            return $"AccountGroupShareCreateTriggerRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AccountGroupShareCreateTriggerRequest other &&
                (this.TriggerName == null && other.TriggerName == null ||
                 this.TriggerName?.Equals(other.TriggerName) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.TriggerCategory == null && other.TriggerCategory == null ||
                 this.TriggerCategory?.Equals(other.TriggerCategory) == true) &&
                (this.PricePlanTrigger == null && other.PricePlanTrigger == null ||
                 this.PricePlanTrigger?.Equals(other.PricePlanTrigger) == true) &&
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
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"TriggerCategory = {(this.TriggerCategory == null ? "null" : this.TriggerCategory.ToString())}");
            toStringOutput.Add($"PricePlanTrigger = {(this.PricePlanTrigger == null ? "null" : this.PricePlanTrigger.ToString())}");
            toStringOutput.Add($"Notification = {(this.Notification == null ? "null" : this.Notification.ToString())}");
            toStringOutput.Add($"Active = {(this.Active == null ? "null" : this.Active.ToString())}");
        }
    }
}