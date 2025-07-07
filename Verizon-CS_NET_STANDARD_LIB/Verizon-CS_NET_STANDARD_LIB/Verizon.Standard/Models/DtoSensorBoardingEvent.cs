// <copyright file="DtoSensorBoardingEvent.cs" company="APIMatic">
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
    /// DtoSensorBoardingEvent.
    /// </summary>
    public class DtoSensorBoardingEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoSensorBoardingEvent"/> class.
        /// </summary>
        public DtoSensorBoardingEvent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoSensorBoardingEvent"/> class.
        /// </summary>
        /// <param name="createdon">createdon.</param>
        /// <param name="errmsg">errmsg.</param>
        /// <param name="fields">fields.</param>
        /// <param name="state">state.</param>
        /// <param name="transactionid">transactionid.</param>
        public DtoSensorBoardingEvent(
            DateTime? createdon = null,
            string errmsg = null,
            Models.DtoFields fields = null,
            string state = null,
            string transactionid = null)
        {
            this.Createdon = createdon;
            this.Errmsg = errmsg;
            this.Fields = fields;
            this.State = state;
            this.Transactionid = transactionid;
        }

        /// <summary>
        /// Timestamp of the record
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdon", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Createdon { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty("errmsg", NullValueHandling = NullValueHandling.Ignore)]
        public string Errmsg { get; set; }

        /// <summary>
        /// Fields to return needed by search
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DtoFields Fields { get; set; }

        /// <summary>
        /// The current status of the device or transaction and will be `success` or `failed`
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// The system-generated UUID of the transaction
        /// </summary>
        [JsonProperty("transactionid", NullValueHandling = NullValueHandling.Ignore)]
        public string Transactionid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoSensorBoardingEvent : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoSensorBoardingEvent other &&
                (this.Createdon == null && other.Createdon == null ||
                 this.Createdon?.Equals(other.Createdon) == true) &&
                (this.Errmsg == null && other.Errmsg == null ||
                 this.Errmsg?.Equals(other.Errmsg) == true) &&
                (this.Fields == null && other.Fields == null ||
                 this.Fields?.Equals(other.Fields) == true) &&
                (this.State == null && other.State == null ||
                 this.State?.Equals(other.State) == true) &&
                (this.Transactionid == null && other.Transactionid == null ||
                 this.Transactionid?.Equals(other.Transactionid) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Createdon = {(this.Createdon == null ? "null" : this.Createdon.ToString())}");
            toStringOutput.Add($"Errmsg = {this.Errmsg ?? "null"}");
            toStringOutput.Add($"Fields = {(this.Fields == null ? "null" : this.Fields.ToString())}");
            toStringOutput.Add($"State = {this.State ?? "null"}");
            toStringOutput.Add($"Transactionid = {this.Transactionid ?? "null"}");
        }
    }
}