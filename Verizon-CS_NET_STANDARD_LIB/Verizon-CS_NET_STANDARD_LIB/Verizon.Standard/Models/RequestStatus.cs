// <copyright file="RequestStatus.cs" company="APIMatic">
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
    /// RequestStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RequestStatus
    {
        /// <summary>
        /// Pending.
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Success.
        /// </summary>
        [EnumMember(Value = "Success")]
        Success,

        /// <summary>
        /// Failure.
        /// </summary>
        [EnumMember(Value = "Failure")]
        Failure
    }
}