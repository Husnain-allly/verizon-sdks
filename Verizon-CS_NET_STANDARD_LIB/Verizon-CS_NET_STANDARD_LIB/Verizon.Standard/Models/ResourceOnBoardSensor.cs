// <copyright file="ResourceOnBoardSensor.cs" company="APIMatic">
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
    /// ResourceOnBoardSensor.
    /// </summary>
    public class ResourceOnBoardSensor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceOnBoardSensor"/> class.
        /// </summary>
        public ResourceOnBoardSensor()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceOnBoardSensor"/> class.
        /// </summary>
        /// <param name="deveui">deveui.</param>
        /// <param name="appeui">appeui.</param>
        /// <param name="appkey">appkey.</param>
        /// <param name="mClass">class.</param>
        /// <param name="kind">kind.</param>
        /// <param name="description">description.</param>
        /// <param name="name">name.</param>
        /// <param name="customdata">customdata.</param>
        public ResourceOnBoardSensor(
            string deveui,
            string appeui,
            string appkey,
            string mClass,
            string kind,
            string description,
            string name,
            object customdata = null)
        {
            this.Deveui = deveui;
            this.Appeui = appeui;
            this.Appkey = appkey;
            this.MClass = mClass;
            this.Kind = kind;
            this.Description = description;
            this.Name = name;
            this.Customdata = customdata;
        }

        /// <summary>
        /// the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer
        /// </summary>
        [JsonProperty("deveui")]
        public string Deveui { get; set; }

        /// <summary>
        /// global application ID in IEEE EUI64 address space that uniquely identifies the entity able to process the JoinReq frame
        /// </summary>
        [JsonProperty("appeui")]
        public string Appeui { get; set; }

        /// <summary>
        /// an encryption key used for messages during every over the air activation
        /// </summary>
        [JsonProperty("appkey")]
        public string Appkey { get; set; }

        /// <summary>
        /// Class of the sensor device. Valid values are Class A (A), Class B (B), and Class C (C). All LoRaWAN devices must implement Class A
        /// </summary>
        [JsonProperty("class")]
        public string MClass { get; set; }

        /// <summary>
        /// The kind of sensor device
        /// </summary>
        [JsonProperty("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action.
        /// </summary>
        [JsonProperty("customdata", NullValueHandling = NullValueHandling.Ignore)]
        public object Customdata { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ResourceOnBoardSensor : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ResourceOnBoardSensor other &&
                (this.Deveui == null && other.Deveui == null ||
                 this.Deveui?.Equals(other.Deveui) == true) &&
                (this.Appeui == null && other.Appeui == null ||
                 this.Appeui?.Equals(other.Appeui) == true) &&
                (this.Appkey == null && other.Appkey == null ||
                 this.Appkey?.Equals(other.Appkey) == true) &&
                (this.MClass == null && other.MClass == null ||
                 this.MClass?.Equals(other.MClass) == true) &&
                (this.Kind == null && other.Kind == null ||
                 this.Kind?.Equals(other.Kind) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Customdata == null && other.Customdata == null ||
                 this.Customdata?.Equals(other.Customdata) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Deveui = {this.Deveui ?? "null"}");
            toStringOutput.Add($"Appeui = {this.Appeui ?? "null"}");
            toStringOutput.Add($"Appkey = {this.Appkey ?? "null"}");
            toStringOutput.Add($"MClass = {this.MClass ?? "null"}");
            toStringOutput.Add($"Kind = {this.Kind ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Customdata = {(this.Customdata == null ? "null" : this.Customdata.ToString())}");
        }
    }
}