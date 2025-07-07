// <copyright file="ConditionType.cs" company="APIMatic">
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
    /// ConditionType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConditionType
    {
        /// <summary>
        /// Individual.
        /// </summary>
        [EnumMember(Value = "Individual")]
        Individual,

        /// <summary>
        /// Aging.
        /// </summary>
        [EnumMember(Value = "Aging")]
        Aging,

        /// <summary>
        /// UsageAllowance.
        /// </summary>
        [EnumMember(Value = "UsageAllowance")]
        UsageAllowance
    }
}