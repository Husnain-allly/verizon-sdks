// <copyright file="CampaignMetaInfoProtocol.cs" company="APIMatic">
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
    /// CampaignMetaInfoProtocol.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CampaignMetaInfoProtocol
    {
        /// <summary>
        /// LwM2M.
        /// </summary>
        [EnumMember(Value = "LWM2M")]
        LwM2M,

        /// <summary>
        /// Omddm.
        /// </summary>
        [EnumMember(Value = "OMD-DM")]
        Omddm
    }
}