// <copyright file="RbsHighPrecisionTiltConfig.cs" company="APIMatic">
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
    /// RbsHighPrecisionTiltConfig.
    /// </summary>
    public class RbsHighPrecisionTiltConfig
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
        /// Initializes a new instance of the <see cref="RbsHighPrecisionTiltConfig"/> class.
        /// </summary>
        public RbsHighPrecisionTiltConfig()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RbsHighPrecisionTiltConfig"/> class.
        /// </summary>
        /// <param name="mode">mode.</param>
        /// <param name="periodicReporting">periodic-reporting.</param>
        /// <param name="holdTime">hold-time.</param>
        /// <param name="angleAway">angle-away.</param>
        /// <param name="angleToward">angle-toward.</param>
        /// <param name="tscore">tscore.</param>
        public RbsHighPrecisionTiltConfig(
            Models.Mode? mode = null,
            Models.PeriodicReporting periodicReporting = null,
            int? holdTime = null,
            int? angleAway = null,
            int? angleToward = null,
            Models.Tscore tscore = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Mode = mode;
            this.PeriodicReporting = periodicReporting;
            this.HoldTime = holdTime;
            this.AngleAway = angleAway;
            this.AngleToward = angleToward;
            this.Tscore = tscore;
        }

        /// <summary>
        /// the reporting mode of the tilt sensor
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Mode? Mode { get; set; }

        /// <summary>
        /// The units and values of the time interval for the sensor to send a report
        /// </summary>
        [JsonProperty("periodic-reporting", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PeriodicReporting PeriodicReporting { get; set; }

        /// <summary>
        /// The time the threshold condition exists, in milliseconds, to recognize an event
        /// </summary>
        [JsonProperty("hold-time", NullValueHandling = NullValueHandling.Ignore)]
        public int? HoldTime { get; set; }

        /// <summary>
        /// the threshold value, from verticle, to recognize an event
        /// </summary>
        [JsonProperty("angle-away", NullValueHandling = NullValueHandling.Ignore)]
        public int? AngleAway { get; set; }

        /// <summary>
        /// the threshold value, moving towards  verticle, to recognize an event
        /// </summary>
        [JsonProperty("angle-toward", NullValueHandling = NullValueHandling.Ignore)]
        public int? AngleToward { get; set; }

        /// <summary>
        /// Gets or sets Tscore.
        /// </summary>
        [JsonProperty("tscore", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Tscore Tscore { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RbsHighPrecisionTiltConfig : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RbsHighPrecisionTiltConfig other &&
                (this.Mode == null && other.Mode == null ||
                 this.Mode?.Equals(other.Mode) == true) &&
                (this.PeriodicReporting == null && other.PeriodicReporting == null ||
                 this.PeriodicReporting?.Equals(other.PeriodicReporting) == true) &&
                (this.HoldTime == null && other.HoldTime == null ||
                 this.HoldTime?.Equals(other.HoldTime) == true) &&
                (this.AngleAway == null && other.AngleAway == null ||
                 this.AngleAway?.Equals(other.AngleAway) == true) &&
                (this.AngleToward == null && other.AngleToward == null ||
                 this.AngleToward?.Equals(other.AngleToward) == true) &&
                (this.Tscore == null && other.Tscore == null ||
                 this.Tscore?.Equals(other.Tscore) == true) &&
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
            toStringOutput.Add($"Mode = {(this.Mode == null ? "null" : this.Mode.ToString())}");
            toStringOutput.Add($"PeriodicReporting = {(this.PeriodicReporting == null ? "null" : this.PeriodicReporting.ToString())}");
            toStringOutput.Add($"HoldTime = {(this.HoldTime == null ? "null" : this.HoldTime.ToString())}");
            toStringOutput.Add($"AngleAway = {(this.AngleAway == null ? "null" : this.AngleAway.ToString())}");
            toStringOutput.Add($"AngleToward = {(this.AngleToward == null ? "null" : this.AngleToward.ToString())}");
            toStringOutput.Add($"Tscore = {(this.Tscore == null ? "null" : this.Tscore.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}