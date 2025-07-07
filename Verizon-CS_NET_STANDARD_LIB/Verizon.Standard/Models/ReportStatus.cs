// <copyright file="ReportStatus.cs" company="APIMatic">
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
    /// ReportStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReportStatus
    {
        /// <summary>
        /// Queued.
        /// </summary>
        [EnumMember(Value = "QUEUED")]
        Queued,

        /// <summary>
        /// Inprogress.
        /// </summary>
        [EnumMember(Value = "INPROGRESS")]
        Inprogress,

        /// <summary>
        /// Completed.
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        Completed
    }
}