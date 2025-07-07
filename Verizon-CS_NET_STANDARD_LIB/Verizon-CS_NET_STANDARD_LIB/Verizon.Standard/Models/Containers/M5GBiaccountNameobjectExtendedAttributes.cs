// <copyright file="M5GBiaccountNameobjectExtendedAttributes.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<M5GBiaccountNameobjectExtendedAttributes>),
        new Type[] {
            typeof(M5GBiattribute1Case),
            typeof(M5GBiattribute2Case)
        },
        false
    )]
    public abstract class M5GBiaccountNameobjectExtendedAttributes
    {
        /// <summary>
        /// This is 5gbiattribute1 case.
        /// </summary>
        /// <returns>
        /// The M5GBiaccountNameobjectExtendedAttributes instance, wrapping the provided M5GBiattribute1 value.
        /// </returns>
        public static M5GBiaccountNameobjectExtendedAttributes From5gbiattribute1(M5GBiattribute1 m5GBiattribute1)
        {
            return new M5GBiattribute1Case().Set(m5GBiattribute1);
        }

        /// <summary>
        /// This is 5gbiattribute2 case.
        /// </summary>
        /// <returns>
        /// The M5GBiaccountNameobjectExtendedAttributes instance, wrapping the provided M5GBiattribute2 value.
        /// </returns>
        public static M5GBiaccountNameobjectExtendedAttributes From5gbiattribute2(M5GBiattribute2 m5GBiattribute2)
        {
            return new M5GBiattribute2Case().Set(m5GBiattribute2);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<M5GBiattribute1, T> m5GBiattribute1, Func<M5GBiattribute2, T> m5GBiattribute2);

        [JsonConverter(typeof(UnionTypeCaseConverter<M5GBiattribute1Case, M5GBiattribute1>))]
        private sealed class M5GBiattribute1Case : M5GBiaccountNameobjectExtendedAttributes, ICaseValue<M5GBiattribute1Case, M5GBiattribute1>
        {
            public M5GBiattribute1 _value;

            public override T Match<T>(Func<M5GBiattribute1, T> m5GBiattribute1, Func<M5GBiattribute2, T> m5GBiattribute2)
            {
                return m5GBiattribute1(_value);
            }

            public M5GBiattribute1Case Set(M5GBiattribute1 value)
            {
                _value = value;
                return this;
            }

            public M5GBiattribute1 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is M5GBiattribute1Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<M5GBiattribute2Case, M5GBiattribute2>))]
        private sealed class M5GBiattribute2Case : M5GBiaccountNameobjectExtendedAttributes, ICaseValue<M5GBiattribute2Case, M5GBiattribute2>
        {
            public M5GBiattribute2 _value;

            public override T Match<T>(Func<M5GBiattribute1, T> m5GBiattribute1, Func<M5GBiattribute2, T> m5GBiattribute2)
            {
                return m5GBiattribute2(_value);
            }

            public M5GBiattribute2Case Set(M5GBiattribute2 value)
            {
                _value = value;
                return this;
            }

            public M5GBiattribute2 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is M5GBiattribute2Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}