// <copyright file="ProvisioningStatusFilter.cs" company="APIMatic">
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
    /// ProvisioningStatusFilter.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProvisioningStatusFilter
    {
        /// <summary>
        /// Unknown.
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Deactivated.
        /// </summary>
        [EnumMember(Value = "DEACTIVATED")]
        Deactivated,

        /// <summary>
        /// Activated.
        /// </summary>
        [EnumMember(Value = "ACTIVATED")]
        Activated,

        /// <summary>
        /// Deactive.
        /// </summary>
        [EnumMember(Value = "DEACTIVE")]
        Deactive,

        /// <summary>
        /// Active.
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        Active,

        /// <summary>
        /// Suspend.
        /// </summary>
        [EnumMember(Value = "SUSPEND")]
        Suspend,

        /// <summary>
        /// PendingActivation.
        /// </summary>
        [EnumMember(Value = "PENDING_ACTIVATION")]
        PendingActivation,

        /// <summary>
        /// PendingDeactivation.
        /// </summary>
        [EnumMember(Value = "PENDING_DEACTIVATION")]
        PendingDeactivation,

        /// <summary>
        /// PreActive.
        /// </summary>
        [EnumMember(Value = "PRE_ACTIVE")]
        PreActive,

        /// <summary>
        /// ActivationReady.
        /// </summary>
        [EnumMember(Value = "ACTIVATION_READY")]
        ActivationReady,

        /// <summary>
        /// Inventory.
        /// </summary>
        [EnumMember(Value = "INVENTORY")]
        Inventory,

        /// <summary>
        /// Purged.
        /// </summary>
        [EnumMember(Value = "PURGED")]
        Purged,

        /// <summary>
        /// Replaced.
        /// </summary>
        [EnumMember(Value = "REPLACED")]
        Replaced,

        /// <summary>
        /// Retired.
        /// </summary>
        [EnumMember(Value = "RETIRED")]
        Retired,

        /// <summary>
        /// TestReady.
        /// </summary>
        [EnumMember(Value = "TEST_READY")]
        TestReady
    }
}