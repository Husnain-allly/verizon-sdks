// <copyright file="KeysChunk.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<KeysChunk>),
        new Type[] {
            typeof(KeyServicePlanCase),
            typeof(KeyDataPercentage50Case),
            typeof(KeysmsPercentage50Case),
            typeof(NoOfDaysB4PromoExpCase),
            typeof(EnablePromoExpCase)
        },
        false
    )]
    public abstract class KeysChunk
    {
        /// <summary>
        /// This is keyServicePlan case.
        /// </summary>
        /// <returns>
        /// The KeysChunk instance, wrapping the provided KeyServicePlan value.
        /// </returns>
        public static KeysChunk FromKeyServicePlan(KeyServicePlan keyServicePlan)
        {
            return new KeyServicePlanCase().Set(keyServicePlan);
        }

        /// <summary>
        /// This is keyDataPercentage50 case.
        /// </summary>
        /// <returns>
        /// The KeysChunk instance, wrapping the provided KeyDataPercentage50 value.
        /// </returns>
        public static KeysChunk FromKeyDataPercentage50(KeyDataPercentage50 keyDataPercentage50)
        {
            return new KeyDataPercentage50Case().Set(keyDataPercentage50);
        }

        /// <summary>
        /// This is keysmsPercentage50 case.
        /// </summary>
        /// <returns>
        /// The KeysChunk instance, wrapping the provided KeysmsPercentage50 value.
        /// </returns>
        public static KeysChunk FromKeysmsPercentage50(KeysmsPercentage50 keysmsPercentage50)
        {
            return new KeysmsPercentage50Case().Set(keysmsPercentage50);
        }

        /// <summary>
        /// This is NoOfDaysB4PromoExp case.
        /// </summary>
        /// <returns>
        /// The KeysChunk instance, wrapping the provided NoOfDaysB4PromoExp value.
        /// </returns>
        public static KeysChunk FromNoOfDaysB4PromoExp(NoOfDaysB4PromoExp noOfDaysB4PromoExp)
        {
            return new NoOfDaysB4PromoExpCase().Set(noOfDaysB4PromoExp);
        }

        /// <summary>
        /// This is EnablePromoExp case.
        /// </summary>
        /// <returns>
        /// The KeysChunk instance, wrapping the provided EnablePromoExp value.
        /// </returns>
        public static KeysChunk FromEnablePromoExp(EnablePromoExp enablePromoExp)
        {
            return new EnablePromoExpCase().Set(enablePromoExp);
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
            Func<KeyServicePlan, T> keyServicePlan,
            Func<KeyDataPercentage50, T> keyDataPercentage50,
            Func<KeysmsPercentage50, T> keysmsPercentage50,
            Func<NoOfDaysB4PromoExp, T> noOfDaysB4PromoExp,
            Func<EnablePromoExp, T> enablePromoExp);

        [JsonConverter(typeof(UnionTypeCaseConverter<KeyServicePlanCase, KeyServicePlan>))]
        private sealed class KeyServicePlanCase : KeysChunk, ICaseValue<KeyServicePlanCase, KeyServicePlan>
        {
            public KeyServicePlan _value;

            public override T Match<T>(
                Func<KeyServicePlan, T> keyServicePlan,
                Func<KeyDataPercentage50, T> keyDataPercentage50,
                Func<KeysmsPercentage50, T> keysmsPercentage50,
                Func<NoOfDaysB4PromoExp, T> noOfDaysB4PromoExp,
                Func<EnablePromoExp, T> enablePromoExp)
            {
                return keyServicePlan(_value);
            }

            public KeyServicePlanCase Set(KeyServicePlan value)
            {
                _value = value;
                return this;
            }

            public KeyServicePlan Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is KeyServicePlanCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<KeyDataPercentage50Case, KeyDataPercentage50>))]
        private sealed class KeyDataPercentage50Case : KeysChunk, ICaseValue<KeyDataPercentage50Case, KeyDataPercentage50>
        {
            public KeyDataPercentage50 _value;

            public override T Match<T>(
                Func<KeyServicePlan, T> keyServicePlan,
                Func<KeyDataPercentage50, T> keyDataPercentage50,
                Func<KeysmsPercentage50, T> keysmsPercentage50,
                Func<NoOfDaysB4PromoExp, T> noOfDaysB4PromoExp,
                Func<EnablePromoExp, T> enablePromoExp)
            {
                return keyDataPercentage50(_value);
            }

            public KeyDataPercentage50Case Set(KeyDataPercentage50 value)
            {
                _value = value;
                return this;
            }

            public KeyDataPercentage50 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is KeyDataPercentage50Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<KeysmsPercentage50Case, KeysmsPercentage50>))]
        private sealed class KeysmsPercentage50Case : KeysChunk, ICaseValue<KeysmsPercentage50Case, KeysmsPercentage50>
        {
            public KeysmsPercentage50 _value;

            public override T Match<T>(
                Func<KeyServicePlan, T> keyServicePlan,
                Func<KeyDataPercentage50, T> keyDataPercentage50,
                Func<KeysmsPercentage50, T> keysmsPercentage50,
                Func<NoOfDaysB4PromoExp, T> noOfDaysB4PromoExp,
                Func<EnablePromoExp, T> enablePromoExp)
            {
                return keysmsPercentage50(_value);
            }

            public KeysmsPercentage50Case Set(KeysmsPercentage50 value)
            {
                _value = value;
                return this;
            }

            public KeysmsPercentage50 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is KeysmsPercentage50Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<NoOfDaysB4PromoExpCase, NoOfDaysB4PromoExp>))]
        private sealed class NoOfDaysB4PromoExpCase : KeysChunk, ICaseValue<NoOfDaysB4PromoExpCase, NoOfDaysB4PromoExp>
        {
            public NoOfDaysB4PromoExp _value;

            public override T Match<T>(
                Func<KeyServicePlan, T> keyServicePlan,
                Func<KeyDataPercentage50, T> keyDataPercentage50,
                Func<KeysmsPercentage50, T> keysmsPercentage50,
                Func<NoOfDaysB4PromoExp, T> noOfDaysB4PromoExp,
                Func<EnablePromoExp, T> enablePromoExp)
            {
                return noOfDaysB4PromoExp(_value);
            }

            public NoOfDaysB4PromoExpCase Set(NoOfDaysB4PromoExp value)
            {
                _value = value;
                return this;
            }

            public NoOfDaysB4PromoExp Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is NoOfDaysB4PromoExpCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<EnablePromoExpCase, EnablePromoExp>))]
        private sealed class EnablePromoExpCase : KeysChunk, ICaseValue<EnablePromoExpCase, EnablePromoExp>
        {
            public EnablePromoExp _value;

            public override T Match<T>(
                Func<KeyServicePlan, T> keyServicePlan,
                Func<KeyDataPercentage50, T> keyDataPercentage50,
                Func<KeysmsPercentage50, T> keysmsPercentage50,
                Func<NoOfDaysB4PromoExp, T> noOfDaysB4PromoExp,
                Func<EnablePromoExp, T> enablePromoExp)
            {
                return enablePromoExp(_value);
            }

            public EnablePromoExpCase Set(EnablePromoExp value)
            {
                _value = value;
                return this;
            }

            public EnablePromoExp Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is EnablePromoExpCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}