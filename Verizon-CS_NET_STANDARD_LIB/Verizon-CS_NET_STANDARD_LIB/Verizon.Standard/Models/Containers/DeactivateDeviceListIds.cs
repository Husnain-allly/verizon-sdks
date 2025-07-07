// <copyright file="DeactivateDeviceListIds.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<DeactivateDeviceListIds>),
        new Type[] {
            typeof(DeviceIdCase),
            typeof(PropertyDeviceIdCase)
        },
        false
    )]
    public abstract class DeactivateDeviceListIds
    {
        /// <summary>
        /// This is DeviceId case.
        /// </summary>
        /// <returns>
        /// The DeactivateDeviceListIds instance, wrapping the provided DeviceId value.
        /// </returns>
        public static DeactivateDeviceListIds FromDeviceId(DeviceId deviceId)
        {
            return new DeviceIdCase().Set(deviceId);
        }

        /// <summary>
        /// This is PropertyDeviceId case.
        /// </summary>
        /// <returns>
        /// The DeactivateDeviceListIds instance, wrapping the provided PropertyDeviceId value.
        /// </returns>
        public static DeactivateDeviceListIds FromPropertyDeviceId(PropertyDeviceId propertyDeviceId)
        {
            return new PropertyDeviceIdCase().Set(propertyDeviceId);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<DeviceId, T> deviceId, Func<PropertyDeviceId, T> propertyDeviceId);

        [JsonConverter(typeof(UnionTypeCaseConverter<DeviceIdCase, DeviceId>))]
        private sealed class DeviceIdCase : DeactivateDeviceListIds, ICaseValue<DeviceIdCase, DeviceId>
        {
            public DeviceId _value;

            public override T Match<T>(Func<DeviceId, T> deviceId, Func<PropertyDeviceId, T> propertyDeviceId)
            {
                return deviceId(_value);
            }

            public DeviceIdCase Set(DeviceId value)
            {
                _value = value;
                return this;
            }

            public DeviceId Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is DeviceIdCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PropertyDeviceIdCase, PropertyDeviceId>))]
        private sealed class PropertyDeviceIdCase : DeactivateDeviceListIds, ICaseValue<PropertyDeviceIdCase, PropertyDeviceId>
        {
            public PropertyDeviceId _value;

            public override T Match<T>(Func<DeviceId, T> deviceId, Func<PropertyDeviceId, T> propertyDeviceId)
            {
                return propertyDeviceId(_value);
            }

            public PropertyDeviceIdCase Set(PropertyDeviceId value)
            {
                _value = value;
                return this;
            }

            public PropertyDeviceId Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PropertyDeviceIdCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}