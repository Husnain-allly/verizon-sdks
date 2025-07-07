// <copyright file="DataFrame.cs" company="APIMatic">
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
using Verizon.Standard.Models.Containers;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
{
    /// <summary>
    /// DataFrame.
    /// </summary>
    public class DataFrame
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataFrame"/> class.
        /// </summary>
        public DataFrame()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataFrame"/> class.
        /// </summary>
        /// <param name="notUsed">notUsed.</param>
        /// <param name="frameType">frameType.</param>
        /// <param name="msgId">msgId.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="durationTime">durationTime.</param>
        /// <param name="priority">priority.</param>
        /// <param name="notUsed1">notUsed1.</param>
        /// <param name="regions">regions.</param>
        /// <param name="notUsed2">notUsed2.</param>
        /// <param name="notUsed3">notUsed3.</param>
        /// <param name="content">content.</param>
        /// <param name="startYear">startYear.</param>
        public DataFrame(
            int notUsed,
            Models.FrameType frameType,
            DataFrameMsgId msgId,
            int startTime,
            int durationTime,
            int priority,
            int notUsed1,
            List<Models.GeographicalPath> regions,
            int notUsed2,
            int notUsed3,
            DataFrameContent content,
            int? startYear = null)
        {
            this.NotUsed = notUsed;
            this.FrameType = frameType;
            this.MsgId = msgId;
            this.StartYear = startYear;
            this.StartTime = startTime;
            this.DurationTime = durationTime;
            this.Priority = priority;
            this.NotUsed1 = notUsed1;
            this.Regions = regions;
            this.NotUsed2 = notUsed2;
            this.NotUsed3 = notUsed3;
            this.Content = content;
        }

        /// <summary>
        /// Always set to 0 and carries no meaning. Legacy field maintained for backward compatibility.
        /// </summary>
        [JsonProperty("notUsed")]
        public int NotUsed { get; set; }

        /// <summary>
        /// The frameType data element provides the type of message to follow in the rest of the message frame structure. The following frame types are supported:
        ///  - unknown
        ///  - advisory
        ///  - roadSignage
        ///  - commercialSignage
        /// </summary>
        [JsonProperty("frameType")]
        public Models.FrameType FrameType { get; set; }

        /// <summary>
        /// Gets or sets MsgId.
        /// </summary>
        [JsonProperty("msgId")]
        public DataFrameMsgId MsgId { get; set; }

        /// <summary>
        /// The V2X year consists of integer values from zero to 4095 representing the year according to the Gregorian calendar date system. The value of zero shall represent an unknown value.
        /// </summary>
        [JsonProperty("startYear", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartYear { get; set; }

        /// <summary>
        /// Start time expresses the number of elapsed minutes of the current year in the time system being used (typically UTC time). The value 527040 shall be used for invalid.
        /// </summary>
        [JsonProperty("startTime")]
        public int StartTime { get; set; }

        /// <summary>
        /// The duration, in units of whole minutes, that a object persists for. A value of 32000 means that the object persists forever. The range 0..32000 provides for about 22.2 days of maximum duration.
        /// </summary>
        [JsonProperty("durationTime")]
        public int DurationTime { get; set; }

        /// <summary>
        /// The relative importance of the sign, on a scale from zero (least important) to seven (most important).
        /// </summary>
        [JsonProperty("priority")]
        public int Priority { get; set; }

        /// <summary>
        /// Always set to 0 and carries no meaning. Legacy field maintained for backward compatibility.
        /// </summary>
        [JsonProperty("notUsed1")]
        public int NotUsed1 { get; set; }

        /// <summary>
        /// The data frame is used to support the cross-cutting need in many V2X messages to describe arbitrary spatial areas (polygons, boundary lines, and other basic shapes) required by various message types in a small message size. This data frame can describe a complex path or region of arbitrary size using either one of the two supported node offset methods (XY offsets or LL offsets) or using simple geometric projections.
        /// </summary>
        [JsonProperty("regions")]
        public List<Models.GeographicalPath> Regions { get; set; }

        /// <summary>
        /// Always set to 0 and carries no meaning. Legacy field maintained for backward compatibility.
        /// </summary>
        [JsonProperty("notUsed2")]
        public int NotUsed2 { get; set; }

        /// <summary>
        /// Always set to 0 and carries no meaning. Legacy field maintained for backward compatibility.
        /// </summary>
        [JsonProperty("notUsed3")]
        public int NotUsed3 { get; set; }

        /// <summary>
        /// Gets or sets Content.
        /// </summary>
        [JsonProperty("content")]
        public DataFrameContent Content { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DataFrame : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DataFrame other &&
                (this.NotUsed.Equals(other.NotUsed)) &&
                (this.FrameType.Equals(other.FrameType)) &&
                (this.MsgId == null && other.MsgId == null ||
                 this.MsgId?.Equals(other.MsgId) == true) &&
                (this.StartYear == null && other.StartYear == null ||
                 this.StartYear?.Equals(other.StartYear) == true) &&
                (this.StartTime.Equals(other.StartTime)) &&
                (this.DurationTime.Equals(other.DurationTime)) &&
                (this.Priority.Equals(other.Priority)) &&
                (this.NotUsed1.Equals(other.NotUsed1)) &&
                (this.Regions == null && other.Regions == null ||
                 this.Regions?.Equals(other.Regions) == true) &&
                (this.NotUsed2.Equals(other.NotUsed2)) &&
                (this.NotUsed3.Equals(other.NotUsed3)) &&
                (this.Content == null && other.Content == null ||
                 this.Content?.Equals(other.Content) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"NotUsed = {this.NotUsed}");
            toStringOutput.Add($"FrameType = {this.FrameType}");
            toStringOutput.Add($"MsgId = {(this.MsgId == null ? "null" : this.MsgId.ToString())}");
            toStringOutput.Add($"StartYear = {(this.StartYear == null ? "null" : this.StartYear.ToString())}");
            toStringOutput.Add($"StartTime = {this.StartTime}");
            toStringOutput.Add($"DurationTime = {this.DurationTime}");
            toStringOutput.Add($"Priority = {this.Priority}");
            toStringOutput.Add($"NotUsed1 = {this.NotUsed1}");
            toStringOutput.Add($"Regions = {(this.Regions == null ? "null" : $"[{string.Join(", ", this.Regions)} ]")}");
            toStringOutput.Add($"NotUsed2 = {this.NotUsed2}");
            toStringOutput.Add($"NotUsed3 = {this.NotUsed3}");
            toStringOutput.Add($"Content = {(this.Content == null ? "null" : this.Content.ToString())}");
        }
    }
}