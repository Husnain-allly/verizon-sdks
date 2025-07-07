// <copyright file="TriggerCategory.cs" company="APIMatic">
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
    /// TriggerCategory.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TriggerCategory
    {
        /// <summary>
        /// AccountUsage.
        /// </summary>
        [EnumMember(Value = "AccountUsage")]
        AccountUsage,

        /// <summary>
        /// DeviceGroupUsage.
        /// </summary>
        [EnumMember(Value = "DeviceGroupUsage")]
        DeviceGroupUsage,

        /// <summary>
        /// PricePlanDataUsage.
        /// </summary>
        [EnumMember(Value = "PricePlanDataUsage")]
        PricePlanDataUsage
    }
}