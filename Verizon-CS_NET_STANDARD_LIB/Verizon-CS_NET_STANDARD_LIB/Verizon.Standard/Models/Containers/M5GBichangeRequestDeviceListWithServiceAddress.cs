// <copyright file="M5GBichangeRequestDeviceListWithServiceAddress.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<M5GBichangeRequestDeviceListWithServiceAddress>),
        new Type[] {
            typeof(M5GBideviceIdarray2Case),
            typeof(M5GBiaddressAndcustomerinfo2Case)
        },
        false
    )]
    public abstract class M5GBichangeRequestDeviceListWithServiceAddress
    {
        /// <summary>
        /// This is 5gbideviceIdarray2 case.
        /// </summary>
        /// <returns>
        /// The M5GBichangeRequestDeviceListWithServiceAddress instance, wrapping the provided M5GBideviceIdarray2 value.
        /// </returns>
        public static M5GBichangeRequestDeviceListWithServiceAddress From5gbideviceIdarray2(M5GBideviceIdarray2 m5GBideviceIdarray2)
        {
            return new M5GBideviceIdarray2Case().Set(m5GBideviceIdarray2);
        }

        /// <summary>
        /// This is 5gbiaddressAndcustomerinfo2 case.
        /// </summary>
        /// <returns>
        /// The M5GBichangeRequestDeviceListWithServiceAddress instance, wrapping the provided M5GBiaddressAndcustomerinfo2 value.
        /// </returns>
        public static M5GBichangeRequestDeviceListWithServiceAddress From5gbiaddressAndcustomerinfo2(M5GBiaddressAndcustomerinfo2 m5GBiaddressAndcustomerinfo2)
        {
            return new M5GBiaddressAndcustomerinfo2Case().Set(m5GBiaddressAndcustomerinfo2);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<M5GBideviceIdarray2, T> m5GBideviceIdarray2, Func<M5GBiaddressAndcustomerinfo2, T> m5GBiaddressAndcustomerinfo2);

        [JsonConverter(typeof(UnionTypeCaseConverter<M5GBideviceIdarray2Case, M5GBideviceIdarray2>))]
        private sealed class M5GBideviceIdarray2Case : M5GBichangeRequestDeviceListWithServiceAddress, ICaseValue<M5GBideviceIdarray2Case, M5GBideviceIdarray2>
        {
            public M5GBideviceIdarray2 _value;

            public override T Match<T>(Func<M5GBideviceIdarray2, T> m5GBideviceIdarray2, Func<M5GBiaddressAndcustomerinfo2, T> m5GBiaddressAndcustomerinfo2)
            {
                return m5GBideviceIdarray2(_value);
            }

            public M5GBideviceIdarray2Case Set(M5GBideviceIdarray2 value)
            {
                _value = value;
                return this;
            }

            public M5GBideviceIdarray2 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is M5GBideviceIdarray2Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<M5GBiaddressAndcustomerinfo2Case, M5GBiaddressAndcustomerinfo2>))]
        private sealed class M5GBiaddressAndcustomerinfo2Case : M5GBichangeRequestDeviceListWithServiceAddress, ICaseValue<M5GBiaddressAndcustomerinfo2Case, M5GBiaddressAndcustomerinfo2>
        {
            public M5GBiaddressAndcustomerinfo2 _value;

            public override T Match<T>(Func<M5GBideviceIdarray2, T> m5GBideviceIdarray2, Func<M5GBiaddressAndcustomerinfo2, T> m5GBiaddressAndcustomerinfo2)
            {
                return m5GBiaddressAndcustomerinfo2(_value);
            }

            public M5GBiaddressAndcustomerinfo2Case Set(M5GBiaddressAndcustomerinfo2 value)
            {
                _value = value;
                return this;
            }

            public M5GBiaddressAndcustomerinfo2 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is M5GBiaddressAndcustomerinfo2Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}