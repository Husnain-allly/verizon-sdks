// <copyright file="SensorInsightsDeviceActionSetRequestBody.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<SensorInsightsDeviceActionSetRequestBody>),
        new Type[] {
            typeof(DtoDeviceActionSetRequestCase),
            typeof(DtoDeviceCommandCase)
        },
        false
    )]
    public abstract class SensorInsightsDeviceActionSetRequestBody
    {
        /// <summary>
        /// This is dto.DeviceActionSetRequest case.
        /// </summary>
        /// <returns>
        /// The SensorInsightsDeviceActionSetRequestBody instance, wrapping the provided DtoDeviceActionSetRequest value.
        /// </returns>
        public static SensorInsightsDeviceActionSetRequestBody FromDtoDeviceActionSetRequest(DtoDeviceActionSetRequest dtoDeviceActionSetRequest)
        {
            return new DtoDeviceActionSetRequestCase().Set(dtoDeviceActionSetRequest);
        }

        /// <summary>
        /// This is dto.deviceCommand case.
        /// </summary>
        /// <returns>
        /// The SensorInsightsDeviceActionSetRequestBody instance, wrapping the provided DtoDeviceCommand value.
        /// </returns>
        public static SensorInsightsDeviceActionSetRequestBody FromDtoDeviceCommand(DtoDeviceCommand dtoDeviceCommand)
        {
            return new DtoDeviceCommandCase().Set(dtoDeviceCommand);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<DtoDeviceActionSetRequest, T> dtoDeviceActionSetRequest, Func<DtoDeviceCommand, T> dtoDeviceCommand);

        [JsonConverter(typeof(UnionTypeCaseConverter<DtoDeviceActionSetRequestCase, DtoDeviceActionSetRequest>))]
        private sealed class DtoDeviceActionSetRequestCase : SensorInsightsDeviceActionSetRequestBody, ICaseValue<DtoDeviceActionSetRequestCase, DtoDeviceActionSetRequest>
        {
            public DtoDeviceActionSetRequest _value;

            public override T Match<T>(Func<DtoDeviceActionSetRequest, T> dtoDeviceActionSetRequest, Func<DtoDeviceCommand, T> dtoDeviceCommand)
            {
                return dtoDeviceActionSetRequest(_value);
            }

            public DtoDeviceActionSetRequestCase Set(DtoDeviceActionSetRequest value)
            {
                _value = value;
                return this;
            }

            public DtoDeviceActionSetRequest Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is DtoDeviceActionSetRequestCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DtoDeviceCommandCase, DtoDeviceCommand>))]
        private sealed class DtoDeviceCommandCase : SensorInsightsDeviceActionSetRequestBody, ICaseValue<DtoDeviceCommandCase, DtoDeviceCommand>
        {
            public DtoDeviceCommand _value;

            public override T Match<T>(Func<DtoDeviceActionSetRequest, T> dtoDeviceActionSetRequest, Func<DtoDeviceCommand, T> dtoDeviceCommand)
            {
                return dtoDeviceCommand(_value);
            }

            public DtoDeviceCommandCase Set(DtoDeviceCommand value)
            {
                _value = value;
                return this;
            }

            public DtoDeviceCommand Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is DtoDeviceCommandCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}