// <copyright file="TriggerAttributesOptions.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<TriggerAttributesOptions>),
        new Type[] {
            typeof(NotificationGroupNameTriggerAttributeCase),
            typeof(ServicePlanTriggerAttributeCase),
            typeof(DataPercentage50TriggerAttributeCase),
            typeof(DataPercentage75TriggerAttributeCase),
            typeof(DataPercentage90TriggerAttributeCase),
            typeof(DataPercentage100TriggerAttributeCase)
        },
        false
    )]
    public abstract class TriggerAttributesOptions
    {
        /// <summary>
        /// This is NotificationGroupNameTriggerAttribute case.
        /// </summary>
        /// <returns>
        /// The TriggerAttributesOptions instance, wrapping the provided NotificationGroupNameTriggerAttribute value.
        /// </returns>
        public static TriggerAttributesOptions FromNotificationGroupNameTriggerAttribute(NotificationGroupNameTriggerAttribute notificationGroupNameTriggerAttribute)
        {
            return new NotificationGroupNameTriggerAttributeCase().Set(notificationGroupNameTriggerAttribute);
        }

        /// <summary>
        /// This is ServicePlanTriggerAttribute case.
        /// </summary>
        /// <returns>
        /// The TriggerAttributesOptions instance, wrapping the provided ServicePlanTriggerAttribute value.
        /// </returns>
        public static TriggerAttributesOptions FromServicePlanTriggerAttribute(ServicePlanTriggerAttribute servicePlanTriggerAttribute)
        {
            return new ServicePlanTriggerAttributeCase().Set(servicePlanTriggerAttribute);
        }

        /// <summary>
        /// This is DataPercentage50TriggerAttribute case.
        /// </summary>
        /// <returns>
        /// The TriggerAttributesOptions instance, wrapping the provided DataPercentage50TriggerAttribute value.
        /// </returns>
        public static TriggerAttributesOptions FromDataPercentage50TriggerAttribute(DataPercentage50TriggerAttribute dataPercentage50TriggerAttribute)
        {
            return new DataPercentage50TriggerAttributeCase().Set(dataPercentage50TriggerAttribute);
        }

        /// <summary>
        /// This is DataPercentage75TriggerAttribute case.
        /// </summary>
        /// <returns>
        /// The TriggerAttributesOptions instance, wrapping the provided DataPercentage75TriggerAttribute value.
        /// </returns>
        public static TriggerAttributesOptions FromDataPercentage75TriggerAttribute(DataPercentage75TriggerAttribute dataPercentage75TriggerAttribute)
        {
            return new DataPercentage75TriggerAttributeCase().Set(dataPercentage75TriggerAttribute);
        }

        /// <summary>
        /// This is DataPercentage90TriggerAttribute case.
        /// </summary>
        /// <returns>
        /// The TriggerAttributesOptions instance, wrapping the provided DataPercentage90TriggerAttribute value.
        /// </returns>
        public static TriggerAttributesOptions FromDataPercentage90TriggerAttribute(DataPercentage90TriggerAttribute dataPercentage90TriggerAttribute)
        {
            return new DataPercentage90TriggerAttributeCase().Set(dataPercentage90TriggerAttribute);
        }

        /// <summary>
        /// This is DataPercentage100TriggerAttribute case.
        /// </summary>
        /// <returns>
        /// The TriggerAttributesOptions instance, wrapping the provided DataPercentage100TriggerAttribute value.
        /// </returns>
        public static TriggerAttributesOptions FromDataPercentage100TriggerAttribute(DataPercentage100TriggerAttribute dataPercentage100TriggerAttribute)
        {
            return new DataPercentage100TriggerAttributeCase().Set(dataPercentage100TriggerAttribute);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<NotificationGroupNameTriggerAttribute, T> notificationGroupNameTriggerAttribute,
            Func<ServicePlanTriggerAttribute, T> servicePlanTriggerAttribute,
            Func<DataPercentage50TriggerAttribute, T> dataPercentage50TriggerAttribute,
            Func<DataPercentage75TriggerAttribute, T> dataPercentage75TriggerAttribute,
            Func<DataPercentage90TriggerAttribute, T> dataPercentage90TriggerAttribute,
            Func<DataPercentage100TriggerAttribute, T> dataPercentage100TriggerAttribute);

        [JsonConverter(typeof(UnionTypeCaseConverter<NotificationGroupNameTriggerAttributeCase, NotificationGroupNameTriggerAttribute>))]
        private sealed class NotificationGroupNameTriggerAttributeCase : TriggerAttributesOptions, ICaseValue<NotificationGroupNameTriggerAttributeCase, NotificationGroupNameTriggerAttribute>
        {
            public NotificationGroupNameTriggerAttribute _value;

            public override T Match<T>(
                Func<NotificationGroupNameTriggerAttribute, T> notificationGroupNameTriggerAttribute,
                Func<ServicePlanTriggerAttribute, T> servicePlanTriggerAttribute,
                Func<DataPercentage50TriggerAttribute, T> dataPercentage50TriggerAttribute,
                Func<DataPercentage75TriggerAttribute, T> dataPercentage75TriggerAttribute,
                Func<DataPercentage90TriggerAttribute, T> dataPercentage90TriggerAttribute,
                Func<DataPercentage100TriggerAttribute, T> dataPercentage100TriggerAttribute)
            {
                return notificationGroupNameTriggerAttribute(_value);
            }

            public NotificationGroupNameTriggerAttributeCase Set(NotificationGroupNameTriggerAttribute value)
            {
                _value = value;
                return this;
            }

            public NotificationGroupNameTriggerAttribute Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is NotificationGroupNameTriggerAttributeCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ServicePlanTriggerAttributeCase, ServicePlanTriggerAttribute>))]
        private sealed class ServicePlanTriggerAttributeCase : TriggerAttributesOptions, ICaseValue<ServicePlanTriggerAttributeCase, ServicePlanTriggerAttribute>
        {
            public ServicePlanTriggerAttribute _value;

            public override T Match<T>(
                Func<NotificationGroupNameTriggerAttribute, T> notificationGroupNameTriggerAttribute,
                Func<ServicePlanTriggerAttribute, T> servicePlanTriggerAttribute,
                Func<DataPercentage50TriggerAttribute, T> dataPercentage50TriggerAttribute,
                Func<DataPercentage75TriggerAttribute, T> dataPercentage75TriggerAttribute,
                Func<DataPercentage90TriggerAttribute, T> dataPercentage90TriggerAttribute,
                Func<DataPercentage100TriggerAttribute, T> dataPercentage100TriggerAttribute)
            {
                return servicePlanTriggerAttribute(_value);
            }

            public ServicePlanTriggerAttributeCase Set(ServicePlanTriggerAttribute value)
            {
                _value = value;
                return this;
            }

            public ServicePlanTriggerAttribute Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ServicePlanTriggerAttributeCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DataPercentage50TriggerAttributeCase, DataPercentage50TriggerAttribute>))]
        private sealed class DataPercentage50TriggerAttributeCase : TriggerAttributesOptions, ICaseValue<DataPercentage50TriggerAttributeCase, DataPercentage50TriggerAttribute>
        {
            public DataPercentage50TriggerAttribute _value;

            public override T Match<T>(
                Func<NotificationGroupNameTriggerAttribute, T> notificationGroupNameTriggerAttribute,
                Func<ServicePlanTriggerAttribute, T> servicePlanTriggerAttribute,
                Func<DataPercentage50TriggerAttribute, T> dataPercentage50TriggerAttribute,
                Func<DataPercentage75TriggerAttribute, T> dataPercentage75TriggerAttribute,
                Func<DataPercentage90TriggerAttribute, T> dataPercentage90TriggerAttribute,
                Func<DataPercentage100TriggerAttribute, T> dataPercentage100TriggerAttribute)
            {
                return dataPercentage50TriggerAttribute(_value);
            }

            public DataPercentage50TriggerAttributeCase Set(DataPercentage50TriggerAttribute value)
            {
                _value = value;
                return this;
            }

            public DataPercentage50TriggerAttribute Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is DataPercentage50TriggerAttributeCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DataPercentage75TriggerAttributeCase, DataPercentage75TriggerAttribute>))]
        private sealed class DataPercentage75TriggerAttributeCase : TriggerAttributesOptions, ICaseValue<DataPercentage75TriggerAttributeCase, DataPercentage75TriggerAttribute>
        {
            public DataPercentage75TriggerAttribute _value;

            public override T Match<T>(
                Func<NotificationGroupNameTriggerAttribute, T> notificationGroupNameTriggerAttribute,
                Func<ServicePlanTriggerAttribute, T> servicePlanTriggerAttribute,
                Func<DataPercentage50TriggerAttribute, T> dataPercentage50TriggerAttribute,
                Func<DataPercentage75TriggerAttribute, T> dataPercentage75TriggerAttribute,
                Func<DataPercentage90TriggerAttribute, T> dataPercentage90TriggerAttribute,
                Func<DataPercentage100TriggerAttribute, T> dataPercentage100TriggerAttribute)
            {
                return dataPercentage75TriggerAttribute(_value);
            }

            public DataPercentage75TriggerAttributeCase Set(DataPercentage75TriggerAttribute value)
            {
                _value = value;
                return this;
            }

            public DataPercentage75TriggerAttribute Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is DataPercentage75TriggerAttributeCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DataPercentage90TriggerAttributeCase, DataPercentage90TriggerAttribute>))]
        private sealed class DataPercentage90TriggerAttributeCase : TriggerAttributesOptions, ICaseValue<DataPercentage90TriggerAttributeCase, DataPercentage90TriggerAttribute>
        {
            public DataPercentage90TriggerAttribute _value;

            public override T Match<T>(
                Func<NotificationGroupNameTriggerAttribute, T> notificationGroupNameTriggerAttribute,
                Func<ServicePlanTriggerAttribute, T> servicePlanTriggerAttribute,
                Func<DataPercentage50TriggerAttribute, T> dataPercentage50TriggerAttribute,
                Func<DataPercentage75TriggerAttribute, T> dataPercentage75TriggerAttribute,
                Func<DataPercentage90TriggerAttribute, T> dataPercentage90TriggerAttribute,
                Func<DataPercentage100TriggerAttribute, T> dataPercentage100TriggerAttribute)
            {
                return dataPercentage90TriggerAttribute(_value);
            }

            public DataPercentage90TriggerAttributeCase Set(DataPercentage90TriggerAttribute value)
            {
                _value = value;
                return this;
            }

            public DataPercentage90TriggerAttribute Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is DataPercentage90TriggerAttributeCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DataPercentage100TriggerAttributeCase, DataPercentage100TriggerAttribute>))]
        private sealed class DataPercentage100TriggerAttributeCase : TriggerAttributesOptions, ICaseValue<DataPercentage100TriggerAttributeCase, DataPercentage100TriggerAttribute>
        {
            public DataPercentage100TriggerAttribute _value;

            public override T Match<T>(
                Func<NotificationGroupNameTriggerAttribute, T> notificationGroupNameTriggerAttribute,
                Func<ServicePlanTriggerAttribute, T> servicePlanTriggerAttribute,
                Func<DataPercentage50TriggerAttribute, T> dataPercentage50TriggerAttribute,
                Func<DataPercentage75TriggerAttribute, T> dataPercentage75TriggerAttribute,
                Func<DataPercentage90TriggerAttribute, T> dataPercentage90TriggerAttribute,
                Func<DataPercentage100TriggerAttribute, T> dataPercentage100TriggerAttribute)
            {
                return dataPercentage100TriggerAttribute(_value);
            }

            public DataPercentage100TriggerAttributeCase Set(DataPercentage100TriggerAttribute value)
            {
                _value = value;
                return this;
            }

            public DataPercentage100TriggerAttribute Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is DataPercentage100TriggerAttributeCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}