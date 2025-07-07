// <copyright file="DistributionSchedule.cs" company="APIMatic">
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
    /// DistributionSchedule.
    /// </summary>
    public class DistributionSchedule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionSchedule"/> class.
        /// </summary>
        public DistributionSchedule()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionSchedule"/> class.
        /// </summary>
        /// <param name="repeatPeriod">repeatPeriod.</param>
        /// <param name="duration">duration.</param>
        /// <param name="startTime">startTime.</param>
        public DistributionSchedule(
            int repeatPeriod,
            int duration,
            DateTime? startTime = null)
        {
            this.RepeatPeriod = repeatPeriod;
            this.Duration = duration;
            this.StartTime = startTime;
        }

        /// <summary>
        /// The period (in seconds) that the message needs to be repeatedly send out.
        /// </summary>
        [JsonProperty("repeatPeriod")]
        public int RepeatPeriod { get; set; }

        /// <summary>
        /// The amount of time (in minutes) while the messages needs to be sent out.
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// The time (in UTC) when the message transmission should be started.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DistributionSchedule : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DistributionSchedule other &&
                (this.RepeatPeriod.Equals(other.RepeatPeriod)) &&
                (this.Duration.Equals(other.Duration)) &&
                (this.StartTime == null && other.StartTime == null ||
                 this.StartTime?.Equals(other.StartTime) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RepeatPeriod = {this.RepeatPeriod}");
            toStringOutput.Add($"Duration = {this.Duration}");
            toStringOutput.Add($"StartTime = {(this.StartTime == null ? "null" : this.StartTime.ToString())}");
        }
    }
}