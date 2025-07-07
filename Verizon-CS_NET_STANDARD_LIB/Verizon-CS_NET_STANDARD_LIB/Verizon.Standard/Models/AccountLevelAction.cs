// <copyright file="AccountLevelAction.cs" company="APIMatic">
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
    /// AccountLevelAction.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountLevelAction
    {
        /// <summary>
        /// Notify.
        /// </summary>
        [EnumMember(Value = "notify")]
        Notify,

        /// <summary>
        /// Suspend.
        /// </summary>
        [EnumMember(Value = "suspend")]
        Suspend,

        /// <summary>
        /// ChangePricePlan.
        /// </summary>
        [EnumMember(Value = "changePricePlan")]
        ChangePricePlan
    }
}