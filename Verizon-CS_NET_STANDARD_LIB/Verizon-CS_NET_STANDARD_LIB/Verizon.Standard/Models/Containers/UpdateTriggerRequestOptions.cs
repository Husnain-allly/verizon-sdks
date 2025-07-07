// <copyright file="UpdateTriggerRequestOptions.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<UpdateTriggerRequestOptions>),
        new Type[] {
            typeof(TriggerType3Case),
            typeof(ActiveAnomalyIndicatorCase)
        },
        false
    )]
    public abstract class UpdateTriggerRequestOptions
    {
        /// <summary>
        /// This is TriggerType3 case.
        /// </summary>
        /// <returns>
        /// The UpdateTriggerRequestOptions instance, wrapping the provided TriggerType3 value.
        /// </returns>
        public static UpdateTriggerRequestOptions FromTriggerType3(TriggerType3 triggerType3)
        {
            return new TriggerType3Case().Set(triggerType3);
        }

        /// <summary>
        /// This is ActiveAnomalyIndicator case.
        /// </summary>
        /// <returns>
        /// The UpdateTriggerRequestOptions instance, wrapping the provided ActiveAnomalyIndicator value.
        /// </returns>
        public static UpdateTriggerRequestOptions FromActiveAnomalyIndicator(ActiveAnomalyIndicator activeAnomalyIndicator)
        {
            return new ActiveAnomalyIndicatorCase().Set(activeAnomalyIndicator);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<TriggerType3, T> triggerType3, Func<ActiveAnomalyIndicator, T> activeAnomalyIndicator);

        [JsonConverter(typeof(UnionTypeCaseConverter<TriggerType3Case, TriggerType3>))]
        private sealed class TriggerType3Case : UpdateTriggerRequestOptions, ICaseValue<TriggerType3Case, TriggerType3>
        {
            public TriggerType3 _value;

            public override T Match<T>(Func<TriggerType3, T> triggerType3, Func<ActiveAnomalyIndicator, T> activeAnomalyIndicator)
            {
                return triggerType3(_value);
            }

            public TriggerType3Case Set(TriggerType3 value)
            {
                _value = value;
                return this;
            }

            public TriggerType3 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is TriggerType3Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ActiveAnomalyIndicatorCase, ActiveAnomalyIndicator>))]
        private sealed class ActiveAnomalyIndicatorCase : UpdateTriggerRequestOptions, ICaseValue<ActiveAnomalyIndicatorCase, ActiveAnomalyIndicator>
        {
            public ActiveAnomalyIndicator _value;

            public override T Match<T>(Func<TriggerType3, T> triggerType3, Func<ActiveAnomalyIndicator, T> activeAnomalyIndicator)
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
    }
}