// <copyright file="RulesCycleType.cs" company="APIMatic">
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
    /// RulesCycleType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RulesCycleType
    {
        /// <summary>
        /// Daily.
        /// </summary>
        [EnumMember(Value = "Daily")]
        Daily,

        /// <summary>
        /// Weekly.
        /// </summary>
        [EnumMember(Value = "Weekly")]
        Weekly,

        /// <summary>
        /// Monthly.
        /// </summary>
        [EnumMember(Value = "Monthly")]
        Monthly
    }
}