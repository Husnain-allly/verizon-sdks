// <copyright file="CreateTriggerRequestOptions.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<CreateTriggerRequestOptions>),
        new Type[] {
            typeof(TriggerType1Case),
            typeof(ActiveAnomalyIndicatorCase),
            typeof(ActiveTriggerIndicatorCase)
        },
        false
    )]
    public abstract class CreateTriggerRequestOptions
    {
        /// <summary>
        /// This is TriggerType1 case.
        /// </summary>
        /// <returns>
        /// The CreateTriggerRequestOptions instance, wrapping the provided TriggerType1 value.
        /// </returns>
        public static CreateTriggerRequestOptions FromTriggerType1(TriggerType1 triggerType1)
        {
            return new TriggerType1Case().Set(triggerType1);
        }

        /// <summary>
        /// This is ActiveAnomalyIndicator case.
        /// </summary>
        /// <returns>
        /// The CreateTriggerRequestOptions instance, wrapping the provided ActiveAnomalyIndicator value.
        /// </returns>
        public static CreateTriggerRequestOptions FromActiveAnomalyIndicator(ActiveAnomalyIndicator activeAnomalyIndicator)
        {
            return new ActiveAnomalyIndicatorCase().Set(activeAnomalyIndicator);
        }

        /// <summary>
        /// This is ActiveTriggerIndicator case.
        /// </summary>
        /// <returns>
        /// The CreateTriggerRequestOptions instance, wrapping the provided ActiveTriggerIndicator value.
        /// </returns>
        public static CreateTriggerRequestOptions FromActiveTriggerIndicator(ActiveTriggerIndicator activeTriggerIndicator)
        {
            return new ActiveTriggerIndicatorCase().Set(activeTriggerIndicator);
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
            Func<TriggerType1, T> triggerType1,
            Func<ActiveAnomalyIndicator, T> activeAnomalyIndicator,
            Func<ActiveTriggerIndicator, T> activeTriggerIndicator);

        [JsonConverter(typeof(UnionTypeCaseConverter<TriggerType1Case, TriggerType1>))]
        private sealed class TriggerType1Case : CreateTriggerRequestOptions, ICaseValue<TriggerType1Case, TriggerType1>
        {
            public TriggerType1 _value;

            public override T Match<T>(
                Func<TriggerType1, T> triggerType1,
                Func<ActiveAnomalyIndicator, T> activeAnomalyIndicator,
                Func<ActiveTriggerIndicator, T> activeTriggerIndicator)
            {
                return triggerType1(_value);
            }

            public TriggerType1Case Set(TriggerType1 value)
            {
                _value = value;
                return this;
            }

            public TriggerType1 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is TriggerType1Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ActiveAnomalyIndicatorCase, ActiveAnomalyIndicator>))]
        private sealed class ActiveAnomalyIndicatorCase : CreateTriggerRequestOptions, ICaseValue<ActiveAnomalyIndicatorCase, ActiveAnomalyIndicator>
        {
            public ActiveAnomalyIndicator _value;

            public override T Match<T>(
                Func<TriggerType1, T> triggerType1,
                Func<ActiveAnomalyIndicator, T> activeAnomalyIndicator,
                Func<ActiveTriggerIndicator, T> activeTriggerIndicator)
            {
                return activeAnomalyIndicator(_value);
            }

            public ActiveAnomalyIndicatorCase Set(ActiveAnomalyIndicator value)
            {
                _value = value;
                return this;
            }

            public ActiveAnomalyIndicator Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ActiveAnomalyIndicatorCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ActiveTriggerIndicatorCase, ActiveTriggerIndicator>))]
        private sealed class ActiveTriggerIndicatorCase : CreateTriggerRequestOptions, ICaseValue<ActiveTriggerIndicatorCase, ActiveTriggerIndicator>
        {
            public ActiveTriggerIndicator _value;

            public override T Match<T>(
                Func<TriggerType1, T> triggerType1,
                Func<ActiveAnomalyIndicator, T> activeAnomalyIndicator,
                Func<ActiveTriggerIndicator, T> activeTriggerIndicator)
            {
                return activeTriggerIndicator(_value);
            }

            public ActiveTriggerIndicatorCase Set(ActiveTriggerIndicator value)
            {
                _value = value;
                return this;
            }

            public ActiveTriggerIndicator Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ActiveTriggerIndicatorCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}