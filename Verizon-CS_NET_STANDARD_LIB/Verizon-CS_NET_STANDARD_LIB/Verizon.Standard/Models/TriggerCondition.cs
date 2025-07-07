// <copyright file="TriggerCondition.cs" company="APIMatic">
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
    /// TriggerCondition.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TriggerCondition
    {
        /// <summary>
        /// Enter.
        /// </summary>
        [EnumMember(Value = "enter")]
        Enter,

        /// <summary>
        /// Leave.
        /// </summary>
        [EnumMember(Value = "leave")]
        Leave,

        /// <summary>
        /// Inside.
        /// </summary>
        [EnumMember(Value = "inside")]
        Inside,

        /// <summary>
        /// Crossing.
        /// </summary>
        [EnumMember(Value = "crossing")]
        Crossing
    }
}