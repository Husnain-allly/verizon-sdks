// <copyright file="OauthScopeThingspaceOauth.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Reflection;
using Verizon.Standard;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
{
    /// <summary>
    /// OauthScopeThingspaceOauth.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum OauthScopeThingspaceOauth
    {
        /// <summary>
        ///Grant read-only access to discovery data
        /// Discoveryread.
        /// </summary>
        [EnumMember(Value = "discovery:read")]
        Discoveryread,

        /// <summary>
        ///Grant read-only access to service profile data
        /// Serviceprofileread.
        /// </summary>
        [EnumMember(Value = "serviceprofile:read")]
        Serviceprofileread,

        /// <summary>
        ///Grant write access to service profile data
        /// Serviceprofilewrite.
        /// </summary>
        [EnumMember(Value = "serviceprofile:write")]
        Serviceprofilewrite,

        /// <summary>
        ///Grant read-only access to Service registry data
        /// Serviceregistryread.
        /// </summary>
        [EnumMember(Value = "serviceregistry:read")]
        Serviceregistryread,

        /// <summary>
        ///Grant write access to Service registry data
        /// Serviceregistrywrite.
        /// </summary>
        [EnumMember(Value = "serviceregistry:write")]
        Serviceregistrywrite,

        /// <summary>
        ///Full access for /serviceprofiles and /serviceendpoints.
        /// TsMecFullaccess.
        /// </summary>
        [EnumMember(Value = "ts.mec.fullaccess")]
        TsMecFullaccess,

        /// <summary>
        ///Limited access. Will not allow use of /serviceprofiles and /serviceendpoints but will allow discovery.
        /// TsMecLimitaccess.
        /// </summary>
        [EnumMember(Value = "ts.mec.limitaccess")]
        TsMecLimitaccess,

        /// <summary>
        /// TsApplicationRo.
        /// </summary>
        [EnumMember(Value = "ts.application.ro")]
        TsApplicationRo,

        /// <summary>
        ///Read access to the discovery service
        /// Edgediscoveryread.
        /// </summary>
        [EnumMember(Value = "edge:discovery:read")]
        Edgediscoveryread,

        /// <summary>
        ///Read access to the service profile service
        /// Edgeserviceprofileread.
        /// </summary>
        [EnumMember(Value = "edge:serviceprofile:read")]
        Edgeserviceprofileread,

        /// <summary>
        ///Write access to the service profile service
        /// Edgeserviceprofilewrite.
        /// </summary>
        [EnumMember(Value = "edge:serviceprofile:write")]
        Edgeserviceprofilewrite,

        /// <summary>
        ///Read access to the service registry service
        /// Edgeserviceregistryread.
        /// </summary>
        [EnumMember(Value = "edge:serviceregistry:read")]
        Edgeserviceregistryread,

        /// <summary>
        ///Write access to the service registry service
        /// Edgeserviceregistrywrite.
        /// </summary>
        [EnumMember(Value = "edge:serviceregistry:write")]
        Edgeserviceregistrywrite,

        /// <summary>
        ///read access
        /// Read.
        /// </summary>
        [EnumMember(Value = "read")]
        Read,

        /// <summary>
        ///read/write access
        /// Write.
        /// </summary>
        [EnumMember(Value = "write")]
        Write
    }

    static class OauthScopeThingspaceOauthExtention
    {
        internal static string GetValues(this IEnumerable<OauthScopeThingspaceOauth> values)
        {
            return values != null ? string.Join(" ", values.Select(s => s.GetValue()).Where(s => !string.IsNullOrEmpty(s)).ToArray()) : null;
        }

        private static string GetValue(this Enum value)
        {
            return value.GetType()
                .GetTypeInfo()
                .DeclaredMembers
                .SingleOrDefault(x => x.Name == value.ToString())
                ?.GetCustomAttribute<EnumMemberAttribute>(false)
                ?.Value;
        }
    }
}