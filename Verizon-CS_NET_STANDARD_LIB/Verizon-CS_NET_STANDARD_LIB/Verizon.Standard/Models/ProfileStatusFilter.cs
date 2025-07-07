// <copyright file="ProfileStatusFilter.cs" company="APIMatic">
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
    /// ProfileStatusFilter.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProfileStatusFilter
    {
        /// <summary>
        /// Enable.
        /// </summary>
        [EnumMember(Value = "ENABLE")]
        Enable,

        /// <summary>
        /// Disable.
        /// </summary>
        [EnumMember(Value = "DISABLE")]
        Disable,

        /// <summary>
        /// DownloadDisable.
        /// </summary>
        [EnumMember(Value = "DOWNLOAD_DISABLE")]
        DownloadDisable,

        /// <summary>
        /// DownloadEnable.
        /// </summary>
        [EnumMember(Value = "DOWNLOAD_ENABLE")]
        DownloadEnable,

        /// <summary>
        /// NotDownloaded.
        /// </summary>
        [EnumMember(Value = "NOT_DOWNLOADED")]
        NotDownloaded,

        /// <summary>
        /// Unknown.
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Delete.
        /// </summary>
        [EnumMember(Value = "DELETE")]
        Delete
    }
}