// <copyright file="M5GBiaccountNameobjectCustomFields.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<M5GBiaccountNameobjectCustomFields>),
        new Type[] {
            typeof(M5GBikeyValue1Case)
        },
        false
    )]
    public abstract class M5GBiaccountNameobjectCustomFields
    {
        /// <summary>
        /// This is 5gbikeyValue1 case.
        /// </summary>
        /// <returns>
        /// The M5GBiaccountNameobjectCustomFields instance, wrapping the provided M5GBikeyValue1 value.
        /// </returns>
        public static M5GBiaccountNameobjectCustomFields From5gbikeyValue1(M5GBikeyValue1 m5GBikeyValue1)
        {
            return new M5GBikeyValue1Case().Set(m5GBikeyValue1);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<M5GBikeyValue1, T> m5GBikeyValue1);

        [JsonConverter(typeof(UnionTypeCaseConverter<M5GBikeyValue1Case, M5GBikeyValue1>))]
        private sealed class M5GBikeyValue1Case : M5GBiaccountNameobjectCustomFields, ICaseValue<M5GBikeyValue1Case, M5GBikeyValue1>
        {
            public M5GBikeyValue1 _value;

            public override T Match<T>(Func<M5GBikeyValue1, T> m5GBikeyValue1)
            {
                return m5GBikeyValue1(_value);
            }

            public M5GBikeyValue1Case Set(M5GBikeyValue1 value)
            {
                _value = value;
                return this;
            }

            public M5GBikeyValue1 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is M5GBikeyValue1Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}