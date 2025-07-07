// <copyright file="DevicesProtocol.cs" company="APIMatic">
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
    /// DevicesProtocol.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DevicesProtocol
    {
        /// <summary>
        /// LwM2M.
        /// </summary>
        [EnumMember(Value = "LWM2M")]
        LwM2M,

        /// <summary>
        /// Omdadm.
        /// </summary>
        [EnumMember(Value = "OMDADM")]
        Omdadm,

        /// <summary>
        /// Http.
        /// </summary>
        [EnumMember(Value = "HTTP")]
        Http
    }
}