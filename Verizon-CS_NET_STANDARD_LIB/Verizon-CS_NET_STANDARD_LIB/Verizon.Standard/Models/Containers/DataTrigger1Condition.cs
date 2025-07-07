// <copyright file="DataTrigger1Condition.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<DataTrigger1Condition>),
        new Type[] {
            typeof(ConditionTypeCase),
            typeof(ConditionObjectCallCase)
        },
        false
    )]
    public abstract class DataTrigger1Condition
    {
        /// <summary>
        /// This is conditionType case.
        /// </summary>
        /// <returns>
        /// The DataTrigger1Condition instance, wrapping the provided ConditionType value.
        /// </returns>
        public static DataTrigger1Condition FromConditionType(ConditionType conditionType)
        {
            return new ConditionTypeCase().Set(conditionType);
        }

        /// <summary>
        /// This is conditionObjectCall case.
        /// </summary>
        /// <returns>
        /// The DataTrigger1Condition instance, wrapping the provided ConditionObjectCall value.
        /// </returns>
        public static DataTrigger1Condition FromConditionObjectCall(ConditionObjectCall conditionObjectCall)
        {
            return new ConditionObjectCallCase().Set(conditionObjectCall);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<ConditionType, T> conditionType, Func<ConditionObjectCall, T> conditionObjectCall);

        [JsonConverter(typeof(UnionTypeCaseConverter<ConditionTypeCase, ConditionType>))]
        private sealed class ConditionTypeCase : DataTrigger1Condition, ICaseValue<ConditionTypeCase, ConditionType>
        {
            public ConditionType _value;

            public override T Match<T>(Func<ConditionType, T> conditionType, Func<ConditionObjectCall, T> conditionObjectCall)
            {
                return conditionType(_value);
            }

            public ConditionTypeCase Set(ConditionType value)
            {
                _value = value;
                return this;
            }

            public ConditionType Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ConditionTypeCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value.Equals(other._value);
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ConditionObjectCallCase, ConditionObjectCall>))]
        private sealed class ConditionObjectCallCase : DataTrigger1Condition, ICaseValue<ConditionObjectCallCase, ConditionObjectCall>
        {
            public ConditionObjectCall _value;

            public override T Match<T>(Func<ConditionType, T> conditionType, Func<ConditionObjectCall, T> conditionObjectCall)
            {
                return conditionObjectCall(_value);
            }

            public ConditionObjectCallCase Set(ConditionObjectCall value)
            {
                _value = value;
                return this;
            }

            public ConditionObjectCall Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ConditionObjectCallCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}