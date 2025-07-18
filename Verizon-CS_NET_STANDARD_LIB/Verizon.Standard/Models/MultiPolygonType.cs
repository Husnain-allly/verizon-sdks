// <copyright file="MultiPolygonType.cs" company="APIMatic">
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
    /// MultiPolygonType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MultiPolygonType
    {
        /// <summary>
        /// MultiPolygon.
        /// </summary>
        [EnumMember(Value = "MultiPolygon")]
        MultiPolygon
    }
}