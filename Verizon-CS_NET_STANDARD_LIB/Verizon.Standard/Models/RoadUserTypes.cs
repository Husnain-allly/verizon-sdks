// <copyright file="RoadUserTypes.cs" company="APIMatic">
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
    /// RoadUserTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RoadUserTypes
    {
        /// <summary>
        /// VulnerableRoadUser.
        /// </summary>
        [EnumMember(Value = "VulnerableRoadUser")]
        VulnerableRoadUser,

        /// <summary>
        /// Vehicle.
        /// </summary>
        [EnumMember(Value = "Vehicle")]
        Vehicle
    }
}