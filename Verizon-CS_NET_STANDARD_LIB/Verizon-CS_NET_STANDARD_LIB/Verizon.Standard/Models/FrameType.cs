// <copyright file="FrameType.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Verizon.Standard;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
{
    /// <summary>
    /// FrameType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FrameType
    {
        /// <summary>
        /// Unknown.
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,

        /// <summary>
        /// Advisory.
        /// </summary>
        [EnumMember(Value = "advisory")]
        Advisory,

        /// <summary>
        /// RoadSignage.
        /// </summary>
        [EnumMember(Value = "roadSignage")]
        RoadSignage,

        /// <summary>
        /// CommercialSignage.
        /// </summary>
        [EnumMember(Value = "commercialSignage")]
        CommercialSignage
    }
}