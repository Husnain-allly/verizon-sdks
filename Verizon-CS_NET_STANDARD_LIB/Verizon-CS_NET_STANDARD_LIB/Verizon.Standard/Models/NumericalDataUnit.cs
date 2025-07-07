// <copyright file="NumericalDataUnit.cs" company="APIMatic">
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
    /// NumericalDataUnit.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum NumericalDataUnit
    {
        /// <summary>
        /// Second.
        /// </summary>
        [EnumMember(Value = "SECOND")]
        Second,

        /// <summary>
        /// Minute.
        /// </summary>
        [EnumMember(Value = "MINUTE")]
        Minute,

        /// <summary>
        /// Hour.
        /// </summary>
        [EnumMember(Value = "HOUR")]
        Hour,

        /// <summary>
        /// Day.
        /// </summary>
        [EnumMember(Value = "DAY")]
        Day
    }
}