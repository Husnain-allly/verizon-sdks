// <copyright file="LineStringType.cs" company="APIMatic">
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
    /// LineStringType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum LineStringType
    {
        /// <summary>
        /// LineString.
        /// </summary>
        [EnumMember(Value = "LineString")]
        LineString
    }
}