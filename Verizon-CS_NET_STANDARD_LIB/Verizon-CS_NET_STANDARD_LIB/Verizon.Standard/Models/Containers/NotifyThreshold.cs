// <copyright file="NotifyThreshold.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<NotifyThreshold>),
        new Type[] {
            typeof(Carriercode1Case)
        },
        false
    )]
    public abstract class NotifyThreshold
    {
        /// <summary>
        /// This is carriercode1 case.
        /// </summary>
        /// <returns>
        /// The NotifyThreshold instance, wrapping the provided Carriercode1 value.
        /// </returns>
        public static NotifyThreshold FromCarriercode1(Carriercode1 carriercode1)
        {
            return new Carriercode1Case().Set(carriercode1);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<Carriercode1, T> carriercode1);

        [JsonConverter(typeof(UnionTypeCaseConverter<Carriercode1Case, Carriercode1>))]
        private sealed class Carriercode1Case : NotifyThreshold, ICaseValue<Carriercode1Case, Carriercode1>
        {
            public Carriercode1 _value;

            public override T Match<T>(Func<Carriercode1, T> carriercode1)
            {
                return carriercode1(_value);
            }

            public Carriercode1Case Set(Carriercode1 value)
            {
                _value = value;
                return this;
            }

            public Carriercode1 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is Carriercode1Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}