// <copyright file="DistributionTypes.cs" company="APIMatic">
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
    /// DistributionTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DistributionTypes
    {
        /// <summary>
        /// Targeted.
        /// </summary>
        [EnumMember(Value = "Targeted")]
        Targeted,

        /// <summary>
        /// Broadcast.
        /// </summary>
        [EnumMember(Value = "Broadcast")]
        Broadcast
    }
}