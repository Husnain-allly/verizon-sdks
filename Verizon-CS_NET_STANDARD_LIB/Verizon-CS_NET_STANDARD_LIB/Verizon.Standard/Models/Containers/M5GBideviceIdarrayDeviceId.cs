// <copyright file="M5GBideviceIdarrayDeviceId.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace Verizon.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for any-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<M5GBideviceIdarrayDeviceId>),
        new Type[] {
            typeof(M5GBideviceId1Case)
        },
        false
    )]
    public abstract class M5GBideviceIdarrayDeviceId
    {
        /// <summary>
        /// This is 5gbideviceId1 case.
        /// </summary>
        /// <returns>
        /// The M5GBideviceIdarrayDeviceId instance, wrapping the provided M5GBideviceId1 value.
        /// </returns>
        public static M5GBideviceIdarrayDeviceId From5gbideviceId1(M5GBideviceId1 m5GBideviceId1)
        {
            return new M5GBideviceId1Case().Set(m5GBideviceId1);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<M5GBideviceId1, T> m5GBideviceId1);

        [JsonConverter(typeof(UnionTypeCaseConverter<M5GBideviceId1Case, M5GBideviceId1>))]
        private sealed class M5GBideviceId1Case : M5GBideviceIdarrayDeviceId, ICaseValue<M5GBideviceId1Case, M5GBideviceId1>
        {
            public M5GBideviceId1 _value;

            public override T Match<T>(Func<M5GBideviceId1, T> m5GBideviceId1)
            {
                return m5GBideviceId1(_value);
            }

            public M5GBideviceId1Case Set(M5GBideviceId1 value)
            {
                _value = value;
                return this;
            }

            public M5GBideviceId1 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is M5GBideviceId1Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}