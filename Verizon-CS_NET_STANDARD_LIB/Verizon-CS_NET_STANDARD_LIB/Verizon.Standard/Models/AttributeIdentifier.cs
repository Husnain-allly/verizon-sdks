// <copyright file="AttributeIdentifier.cs" company="APIMatic">
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
    /// AttributeIdentifier.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttributeIdentifier
    {
        /// <summary>
        /// NetworkBearer.
        /// </summary>
        [EnumMember(Value = "NETWORK_BEARER")]
        NetworkBearer,

        /// <summary>
        /// RadioSignalStrength.
        /// </summary>
        [EnumMember(Value = "RADIO_SIGNAL_STRENGTH")]
        RadioSignalStrength,

        /// <summary>
        /// LinkQuality.
        /// </summary>
        [EnumMember(Value = "LINK_QUALITY")]
        LinkQuality,

        /// <summary>
        /// CellId.
        /// </summary>
        [EnumMember(Value = "CELL_ID")]
        CellId,

        /// <summary>
        /// Manufacturer.
        /// </summary>
        [EnumMember(Value = "MANUFACTURER")]
        Manufacturer
    }
}