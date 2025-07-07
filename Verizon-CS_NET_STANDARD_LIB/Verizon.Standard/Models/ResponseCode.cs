// <copyright file="ResponseCode.cs" company="APIMatic">
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
    /// ResponseCode.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResponseCode
    {
        /// <summary>
        /// InvalidAccess.
        /// </summary>
        [EnumMember(Value = "INVALID_ACCESS")]
        InvalidAccess,

        /// <summary>
        /// InvalidParameter.
        /// </summary>
        [EnumMember(Value = "INVALID_PARAMETER")]
        InvalidParameter,

        /// <summary>
        /// InternalError.
        /// </summary>
        [EnumMember(Value = "INTERNAL_ERROR")]
        InternalError,

        /// <summary>
        /// Success.
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        Success
    }
}