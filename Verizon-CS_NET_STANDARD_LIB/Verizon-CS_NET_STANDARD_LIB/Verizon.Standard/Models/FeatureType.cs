// <copyright file="FeatureType.cs" company="APIMatic">
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
    /// FeatureType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FeatureType
    {
        /// <summary>
        /// Feature.
        /// </summary>
        [EnumMember(Value = "Feature")]
        Feature
    }
}