// <copyright file="SmsOptionsSendRequest.cs" company="APIMatic">
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
    /// SmsOptionsSendRequest.
    /// </summary>
    public class SmsOptionsSendRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsOptionsSendRequest"/> class.
        /// </summary>
        public SmsOptionsSendRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsOptionsSendRequest"/> class.
        /// </summary>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="smsMessage">smsMessage.</param>
        public SmsOptionsSendRequest(
            string servicePlan = null,
            string smsMessage = null)
        {
            this.ServicePlan = servicePlan;
            this.SmsMessage = smsMessage;
        }

        /// <summary>
        /// Gets or sets ServicePlan.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <summary>
        /// Gets or sets SmsMessage.
        /// </summary>
        [JsonProperty("smsMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string SmsMessage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SmsOptionsSendRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SmsOptionsSendRequest other &&
                (this.ServicePlan == null && other.ServicePlan == null ||
                 this.ServicePlan?.Equals(other.ServicePlan) == true) &&
                (this.SmsMessage == null && other.SmsMessage == null ||
                 this.SmsMessage?.Equals(other.SmsMessage) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ServicePlan = {this.ServicePlan ?? "null"}");
            toStringOutput.Add($"SmsMessage = {this.SmsMessage ?? "null"}");
        }
    }
}