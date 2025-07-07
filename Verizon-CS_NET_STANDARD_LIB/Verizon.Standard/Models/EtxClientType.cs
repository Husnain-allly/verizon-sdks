// <copyright file="EtxClientType.cs" company="APIMatic">
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
    /// EtxClientType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EtxClientType
    {
        /// <summary>
        /// Vehicle.
        /// </summary>
        [EnumMember(Value = "Vehicle")]
        Vehicle,

        /// <summary>
        /// VulnerableRoadUser.
        /// </summary>
        [EnumMember(Value = "VulnerableRoadUser")]
        VulnerableRoadUser,

        /// <summary>
        /// TrafficLightController.
        /// </summary>
        [EnumMember(Value = "TrafficLightController")]
        TrafficLightController,

        /// <summary>
        /// InfrastructureSensor.
        /// </summary>
        [EnumMember(Value = "InfrastructureSensor")]
        InfrastructureSensor,

        /// <summary>
        /// OnboardSensor.
        /// </summary>
        [EnumMember(Value = "OnboardSensor")]
        OnboardSensor,

        /// <summary>
        /// Software.
        /// </summary>
        [EnumMember(Value = "Software")]
        Software
    }
}