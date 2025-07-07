// <copyright file="EtxNetworkType.cs" company="APIMatic">
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
    /// EtxNetworkType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EtxNetworkType
    {
        /// <summary>
        /// Vz.
        /// </summary>
        [EnumMember(Value = "VZ")]
        Vz,

        /// <summary>
        /// NonVz.
        /// </summary>
        [EnumMember(Value = "non-VZ")]
        NonVz
    }
}