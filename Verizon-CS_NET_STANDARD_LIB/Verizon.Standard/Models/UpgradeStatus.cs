// <copyright file="UpgradeStatus.cs" company="APIMatic">
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
    /// UpgradeStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UpgradeStatus
    {
        /// <summary>
        /// RequestPending.
        /// </summary>
        [EnumMember(Value = "RequestPending")]
        RequestPending,

        /// <summary>
        /// Queued.
        /// </summary>
        [EnumMember(Value = "Queued")]
        Queued,

        /// <summary>
        /// RequestFailed.
        /// </summary>
        [EnumMember(Value = "RequestFailed")]
        RequestFailed,

        /// <summary>
        /// InProgress.
        /// </summary>
        [EnumMember(Value = "InProgress")]
        InProgress,

        /// <summary>
        /// Finished.
        /// </summary>
        [EnumMember(Value = "Finished")]
        Finished,

        /// <summary>
        /// UpgradeFailed.
        /// </summary>
        [EnumMember(Value = "UpgradeFailed")]
        UpgradeFailed
    }
}