// <copyright file="ClientSubtype.cs" company="APIMatic">
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
    /// ClientSubtype.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClientSubtype
    {
        /// <summary>
        /// PassengerCar.
        /// </summary>
        [EnumMember(Value = "PassengerCar")]
        PassengerCar,

        /// <summary>
        /// Truck.
        /// </summary>
        [EnumMember(Value = "Truck")]
        Truck,

        /// <summary>
        /// Bus.
        /// </summary>
        [EnumMember(Value = "Bus")]
        Bus,

        /// <summary>
        /// EmergencyVehicle.
        /// </summary>
        [EnumMember(Value = "EmergencyVehicle")]
        EmergencyVehicle,

        /// <summary>
        /// SchoolBus.
        /// </summary>
        [EnumMember(Value = "SchoolBus")]
        SchoolBus,

        /// <summary>
        /// MaintenanceVehicle.
        /// </summary>
        [EnumMember(Value = "MaintenanceVehicle")]
        MaintenanceVehicle,

        /// <summary>
        /// Pedestrian.
        /// </summary>
        [EnumMember(Value = "Pedestrian")]
        Pedestrian,

        /// <summary>
        /// Bicycle.
        /// </summary>
        [EnumMember(Value = "Bicycle")]
        Bicycle,

        /// <summary>
        /// Scooter.
        /// </summary>
        [EnumMember(Value = "Scooter")]
        Scooter,

        /// <summary>
        /// Motorcycle.
        /// </summary>
        [EnumMember(Value = "Motorcycle")]
        Motorcycle,

        /// <summary>
        /// RoadSideUnit.
        /// </summary>
        [EnumMember(Value = "RoadSideUnit")]
        RoadSideUnit,

        /// <summary>
        /// Camera.
        /// </summary>
        [EnumMember(Value = "Camera")]
        Camera,

        /// <summary>
        /// Lidar.
        /// </summary>
        [EnumMember(Value = "Lidar")]
        Lidar,

        /// <summary>
        /// Radar.
        /// </summary>
        [EnumMember(Value = "Radar")]
        Radar,

        /// <summary>
        /// InductiveLoop.
        /// </summary>
        [EnumMember(Value = "InductiveLoop")]
        InductiveLoop,

        /// <summary>
        /// MagneticSensor.
        /// </summary>
        [EnumMember(Value = "MagneticSensor")]
        MagneticSensor,

        /// <summary>
        /// Platform.
        /// </summary>
        [EnumMember(Value = "Platform")]
        Platform,

        /// <summary>
        /// Application.
        /// </summary>
        [EnumMember(Value = "Application")]
        Application,

        /// <summary>
        /// Na.
        /// </summary>
        [EnumMember(Value = "NA")]
        Na
    }
}