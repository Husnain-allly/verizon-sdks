// <copyright file="EsimGlobalDeviceListDeviceFilter.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<EsimGlobalDeviceListDeviceFilter>),
        new Type[] {
            typeof(EsimDeviceIdCase),
            typeof(DeviceId2Case)
        },
        false
    )]
    public abstract class EsimGlobalDeviceListDeviceFilter
    {
        /// <summary>
        /// This is eSIMDeviceId case.
        /// </summary>
        /// <returns>
        /// The EsimGlobalDeviceListDeviceFilter instance, wrapping the provided EsimDeviceId value.
        /// </returns>
        public static EsimGlobalDeviceListDeviceFilter FromESIMDeviceId(EsimDeviceId esimDeviceId)
        {
            return new EsimDeviceIdCase().Set(esimDeviceId);
        }

        /// <summary>
        /// This is DeviceId2 case.
        /// </summary>
        /// <returns>
        /// The EsimGlobalDeviceListDeviceFilter instance, wrapping the provided DeviceId2 value.
        /// </returns>
        public static EsimGlobalDeviceListDeviceFilter FromDeviceId2(DeviceId2 deviceId2)
        {
            return new DeviceId2Case().Set(deviceId2);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<EsimDeviceId, T> esimDeviceId, Func<DeviceId2, T> deviceId2);

        [JsonConverter(typeof(UnionTypeCaseConverter<EsimDeviceIdCase, EsimDeviceId>))]
        private sealed class EsimDeviceIdCase : EsimGlobalDeviceListDeviceFilter, ICaseValue<EsimDeviceIdCase, EsimDeviceId>
        {
            public EsimDeviceId _value;

            public override T Match<T>(Func<EsimDeviceId, T> esimDeviceId, Func<DeviceId2, T> deviceId2)
            {
                return esimDeviceId(_value);
            }

            public EsimDeviceIdCase Set(EsimDeviceId value)
            {
                _value = value;
                return this;
            }

            public EsimDeviceId Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is EsimDeviceIdCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DeviceId2Case, DeviceId2>))]
        private sealed class DeviceId2Case : EsimGlobalDeviceListDeviceFilter, ICaseValue<DeviceId2Case, DeviceId2>
        {
            public DeviceId2 _value;

            public override T Match<T>(Func<EsimDeviceId, T> esimDeviceId, Func<DeviceId2, T> deviceId2)
            {
                return deviceId2(_value);
            }

            public DeviceId2Case Set(DeviceId2 value)
            {
                _value = value;
                return this;
            }

            public DeviceId2 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is DeviceId2Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}