// <copyright file="TriggersListOptions.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<TriggersListOptions>),
        new Type[] {
            typeof(AnomalyTriggerValueCase),
            typeof(TriggerType2Case)
        },
        false
    )]
    public abstract class TriggersListOptions
    {
        /// <summary>
        /// This is AnomalyTriggerValue case.
        /// </summary>
        /// <returns>
        /// The TriggersListOptions instance, wrapping the provided AnomalyTriggerValue value.
        /// </returns>
        public static TriggersListOptions FromAnomalyTriggerValue(AnomalyTriggerValue anomalyTriggerValue)
        {
            return new AnomalyTriggerValueCase().Set(anomalyTriggerValue);
        }

        /// <summary>
        /// This is TriggerType2 case.
        /// </summary>
        /// <returns>
        /// The TriggersListOptions instance, wrapping the provided TriggerType2 value.
        /// </returns>
        public static TriggersListOptions FromTriggerType2(TriggerType2 triggerType2)
        {
            return new TriggerType2Case().Set(triggerType2);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<AnomalyTriggerValue, T> anomalyTriggerValue, Func<TriggerType2, T> triggerType2);

        [JsonConverter(typeof(UnionTypeCaseConverter<AnomalyTriggerValueCase, AnomalyTriggerValue>))]
        private sealed class AnomalyTriggerValueCase : TriggersListOptions, ICaseValue<AnomalyTriggerValueCase, AnomalyTriggerValue>
        {
            public AnomalyTriggerValue _value;

            public override T Match<T>(Func<AnomalyTriggerValue, T> anomalyTriggerValue, Func<TriggerType2, T> triggerType2)
            {
                return anomalyTriggerValue(_value);
            }

            public AnomalyTriggerValueCase Set(AnomalyTriggerValue value)
            {
                _value = value;
                return this;
            }

            public AnomalyTriggerValue Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is AnomalyTriggerValueCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<TriggerType2Case, TriggerType2>))]
        private sealed class TriggerType2Case : TriggersListOptions, ICaseValue<TriggerType2Case, TriggerType2>
        {
            public TriggerType2 _value;

            public override T Match<T>(Func<AnomalyTriggerValue, T> anomalyTriggerValue, Func<TriggerType2, T> triggerType2)
            {
                return triggerType2(_value);
            }

            public TriggerType2Case Set(TriggerType2 value)
            {
                _value = value;
                return this;
            }

            public TriggerType2 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is TriggerType2Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}