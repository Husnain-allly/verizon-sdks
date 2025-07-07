// <copyright file="Comparitor.cs" company="APIMatic">
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
    /// Comparitor.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Comparitor
    {
        /// <summary>
        /// Gt.
        /// </summary>
        [EnumMember(Value = "gt")]
        Gt,

        /// <summary>
        /// Lt.
        /// </summary>
        [EnumMember(Value = "lt")]
        Lt,

        /// <summary>
        /// Eq.
        /// </summary>
        [EnumMember(Value = "eq")]
        Eq
    }
}