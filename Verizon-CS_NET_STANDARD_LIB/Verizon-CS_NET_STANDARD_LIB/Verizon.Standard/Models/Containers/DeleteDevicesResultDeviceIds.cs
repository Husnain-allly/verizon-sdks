// <copyright file="DeleteDevicesResultDeviceIds.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<DeleteDevicesResultDeviceIds>),
        new Type[] {
            typeof(ListOfDeviceIdCase),
            typeof(DeviceIdCase)
        },
        true
    )]
    public abstract class DeleteDevicesResultDeviceIds
    {
        /// <summary>
        /// This is List of DeviceId case.
        /// </summary>
        /// <returns>
        /// The DeleteDevicesResultDeviceIds instance, wrapping the provided List&lt;DeviceId&gt; value.
        /// </returns>
        public static DeleteDevicesResultDeviceIds FromListOfDeviceId(List<DeviceId> listOfDeviceId)
        {
            return new ListOfDeviceIdCase().Set(listOfDeviceId);
        }

        /// <summary>
        /// This is DeviceId case.
        /// </summary>
        /// <returns>
        /// The DeleteDevicesResultDeviceIds instance, wrapping the provided DeviceId value.
        /// </returns>
        public static DeleteDevicesResultDeviceIds FromDeviceId(DeviceId deviceId)
        {
            return new DeviceIdCase().Set(deviceId);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<List<DeviceId>, T> listOfDeviceId, Func<DeviceId, T> deviceId);

        [JsonConverter(typeof(UnionTypeCaseConverter<ListOfDeviceIdCase, List<DeviceId>>))]
        private sealed class ListOfDeviceIdCase : DeleteDevicesResultDeviceIds, ICaseValue<ListOfDeviceIdCase, List<DeviceId>>
        {
            public List<DeviceId> _value;

            public override T Match<T>(Func<List<DeviceId>, T> listOfDeviceId, Func<DeviceId, T> deviceId)
            {
                return listOfDeviceId(_value);
            }

            public ListOfDeviceIdCase Set(List<DeviceId> value)
            {
                _value = value;
                return this;
            }

            public List<DeviceId> Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ListOfDeviceIdCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DeviceIdCase, DeviceId>))]
        private sealed class DeviceIdCase : DeleteDevicesResultDeviceIds, ICaseValue<DeviceIdCase, DeviceId>
        {
            public DeviceId _value;

            public override T Match<T>(Func<List<DeviceId>, T> listOfDeviceId, Func<DeviceId, T> deviceId)
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
    }
}