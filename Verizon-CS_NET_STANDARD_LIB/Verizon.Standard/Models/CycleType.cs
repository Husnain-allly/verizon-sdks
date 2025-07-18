// <copyright file="CycleType.cs" company="APIMatic">
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
    /// CycleType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CycleType
    {
        /// <summary>
        /// Cycleone.
        /// </summary>
        [EnumMember(Value = "cycleone")]
        Cycleone,

        /// <summary>
        /// Cycletwo.
        /// </summary>
        [EnumMember(Value = "cycletwo")]
        Cycletwo
    }
}