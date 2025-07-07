// <copyright file="Mode.cs" company="APIMatic">
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
    /// Mode.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Mode
    {
        /// <summary>
        /// ReportOnChange.
        /// </summary>
        [EnumMember(Value = "reportOnChange")]
        ReportOnChange
    }
}