// <copyright file="MecPlatformResourceProperties.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Verizon.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<MecPlatformResourceProperties>),
        new Type[] {
            typeof(ListOfMecPlatformsAdditionalSupportInfoCase),
            typeof(MecPlatformsAdditionalSupportInfoCase)
        },
        true
    )]
    public abstract class MecPlatformResourceProperties
    {
        /// <summary>
        /// This is List of MECPlatformsAdditionalSupportInfo case.
        /// </summary>
        /// <returns>
        /// The MecPlatformResourceProperties instance, wrapping the provided List&lt;MecPlatformsAdditionalSupportInfo&gt; value.
        /// </returns>
        public static MecPlatformResourceProperties FromListOfMECPlatformsAdditionalSupportInfo(List<MecPlatformsAdditionalSupportInfo> listOfMecPlatformsAdditionalSupportInfo)
        {
            return new ListOfMecPlatformsAdditionalSupportInfoCase().Set(listOfMecPlatformsAdditionalSupportInfo);
        }

        /// <summary>
        /// This is MECPlatformsAdditionalSupportInfo case.
        /// </summary>
        /// <returns>
        /// The MecPlatformResourceProperties instance, wrapping the provided MecPlatformsAdditionalSupportInfo value.
        /// </returns>
        public static MecPlatformResourceProperties FromMECPlatformsAdditionalSupportInfo(MecPlatformsAdditionalSupportInfo mecPlatformsAdditionalSupportInfo)
        {
            return new MecPlatformsAdditionalSupportInfoCase().Set(mecPlatformsAdditionalSupportInfo);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<List<MecPlatformsAdditionalSupportInfo>, T> listOfMecPlatformsAdditionalSupportInfo, Func<MecPlatformsAdditionalSupportInfo, T> mecPlatformsAdditionalSupportInfo);

        [JsonConverter(typeof(UnionTypeCaseConverter<ListOfMecPlatformsAdditionalSupportInfoCase, List<MecPlatformsAdditionalSupportInfo>>))]
        private sealed class ListOfMecPlatformsAdditionalSupportInfoCase : MecPlatformResourceProperties, ICaseValue<ListOfMecPlatformsAdditionalSupportInfoCase, List<MecPlatformsAdditionalSupportInfo>>
        {
            public List<MecPlatformsAdditionalSupportInfo> _value;

            public override T Match<T>(Func<List<MecPlatformsAdditionalSupportInfo>, T> listOfMecPlatformsAdditionalSupportInfo, Func<MecPlatformsAdditionalSupportInfo, T> mecPlatformsAdditionalSupportInfo)
            {
                return listOfMecPlatformsAdditionalSupportInfo(_value);
            }

            public ListOfMecPlatformsAdditionalSupportInfoCase Set(List<MecPlatformsAdditionalSupportInfo> value)
            {
                _value = value;
                return this;
            }

            public List<MecPlatformsAdditionalSupportInfo> Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ListOfMecPlatformsAdditionalSupportInfoCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<MecPlatformsAdditionalSupportInfoCase, MecPlatformsAdditionalSupportInfo>))]
        private sealed class MecPlatformsAdditionalSupportInfoCase : MecPlatformResourceProperties, ICaseValue<MecPlatformsAdditionalSupportInfoCase, MecPlatformsAdditionalSupportInfo>
        {
            public MecPlatformsAdditionalSupportInfo _value;

            public override T Match<T>(Func<List<MecPlatformsAdditionalSupportInfo>, T> listOfMecPlatformsAdditionalSupportInfo, Func<MecPlatformsAdditionalSupportInfo, T> mecPlatformsAdditionalSupportInfo)
            {
                return mecPlatformsAdditionalSupportInfo(_value);
            }

            public MecPlatformsAdditionalSupportInfoCase Set(MecPlatformsAdditionalSupportInfo value)
            {
                _value = value;
                return this;
            }

            public MecPlatformsAdditionalSupportInfo Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is MecPlatformsAdditionalSupportInfoCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}