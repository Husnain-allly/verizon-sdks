// <copyright file="M5GBiactivateRequestDeviceListWithServiceAddress.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<M5GBiactivateRequestDeviceListWithServiceAddress>),
        new Type[] {
            typeof(M5GBideviceIdarrayCase),
            typeof(M5GBiaddressAndcustomerinfoCase)
        },
        false
    )]
    public abstract class M5GBiactivateRequestDeviceListWithServiceAddress
    {
        /// <summary>
        /// This is 5gbideviceIdarray case.
        /// </summary>
        /// <returns>
        /// The M5GBiactivateRequestDeviceListWithServiceAddress instance, wrapping the provided M5GBideviceIdarray value.
        /// </returns>
        public static M5GBiactivateRequestDeviceListWithServiceAddress From5gbideviceIdarray(M5GBideviceIdarray m5GBideviceIdarray)
        {
            return new M5GBideviceIdarrayCase().Set(m5GBideviceIdarray);
        }

        /// <summary>
        /// This is 5gbiaddressAndcustomerinfo case.
        /// </summary>
        /// <returns>
        /// The M5GBiactivateRequestDeviceListWithServiceAddress instance, wrapping the provided M5GBiaddressAndcustomerinfo value.
        /// </returns>
        public static M5GBiactivateRequestDeviceListWithServiceAddress From5gbiaddressAndcustomerinfo(M5GBiaddressAndcustomerinfo m5GBiaddressAndcustomerinfo)
        {
            return new M5GBiaddressAndcustomerinfoCase().Set(m5GBiaddressAndcustomerinfo);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<M5GBideviceIdarray, T> m5GBideviceIdarray, Func<M5GBiaddressAndcustomerinfo, T> m5GBiaddressAndcustomerinfo);

        [JsonConverter(typeof(UnionTypeCaseConverter<M5GBideviceIdarrayCase, M5GBideviceIdarray>))]
        private sealed class M5GBideviceIdarrayCase : M5GBiactivateRequestDeviceListWithServiceAddress, ICaseValue<M5GBideviceIdarrayCase, M5GBideviceIdarray>
        {
            public M5GBideviceIdarray _value;

            public override T Match<T>(Func<M5GBideviceIdarray, T> m5GBideviceIdarray, Func<M5GBiaddressAndcustomerinfo, T> m5GBiaddressAndcustomerinfo)
            {
                return m5GBideviceIdarray(_value);
            }

            public M5GBideviceIdarrayCase Set(M5GBideviceIdarray value)
            {
                _value = value;
                return this;
            }

            public M5GBideviceIdarray Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is M5GBideviceIdarrayCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<M5GBiaddressAndcustomerinfoCase, M5GBiaddressAndcustomerinfo>))]
        private sealed class M5GBiaddressAndcustomerinfoCase : M5GBiactivateRequestDeviceListWithServiceAddress, ICaseValue<M5GBiaddressAndcustomerinfoCase, M5GBiaddressAndcustomerinfo>
        {
            public M5GBiaddressAndcustomerinfo _value;

            public override T Match<T>(Func<M5GBideviceIdarray, T> m5GBideviceIdarray, Func<M5GBiaddressAndcustomerinfo, T> m5GBiaddressAndcustomerinfo)
            {
                return m5GBiaddressAndcustomerinfo(_value);
            }

            public M5GBiaddressAndcustomerinfoCase Set(M5GBiaddressAndcustomerinfo value)
            {
                _value = value;
                return this;
            }

            public M5GBiaddressAndcustomerinfo Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is M5GBiaddressAndcustomerinfoCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}