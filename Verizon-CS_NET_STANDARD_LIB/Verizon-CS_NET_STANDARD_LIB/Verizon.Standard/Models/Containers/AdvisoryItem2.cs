// <copyright file="AdvisoryItem2.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace Verizon.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<AdvisoryItem2>),
        new Type[] {
            typeof(AdvisoryItemCase),
            typeof(AdvisoryItem1Case)
        },
        true
    )]
    public abstract class AdvisoryItem2
    {
        /// <summary>
        /// This is AdvisoryItem case.
        /// </summary>
        /// <returns>
        /// The AdvisoryItem2 instance, wrapping the provided AdvisoryItem value.
        /// </returns>
        public static AdvisoryItem2 FromAdvisoryItem(AdvisoryItem advisoryItem)
        {
            return new AdvisoryItemCase().Set(advisoryItem);
        }

        /// <summary>
        /// This is AdvisoryItem1 case.
        /// </summary>
        /// <returns>
        /// The AdvisoryItem2 instance, wrapping the provided AdvisoryItem1 value.
        /// </returns>
        public static AdvisoryItem2 FromAdvisoryItem1(AdvisoryItem1 advisoryItem1)
        {
            return new AdvisoryItem1Case().Set(advisoryItem1);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<AdvisoryItem, T> advisoryItem, Func<AdvisoryItem1, T> advisoryItem1);

        [JsonConverter(typeof(UnionTypeCaseConverter<AdvisoryItemCase, AdvisoryItem>))]
        private sealed class AdvisoryItemCase : AdvisoryItem2, ICaseValue<AdvisoryItemCase, AdvisoryItem>
        {
            public AdvisoryItem _value;

            public override T Match<T>(Func<AdvisoryItem, T> advisoryItem, Func<AdvisoryItem1, T> advisoryItem1)
            {
                return advisoryItem(_value);
            }

            public AdvisoryItemCase Set(AdvisoryItem value)
            {
                _value = value;
                return this;
            }

            public AdvisoryItem Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is AdvisoryItemCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<AdvisoryItem1Case, AdvisoryItem1>))]
        private sealed class AdvisoryItem1Case : AdvisoryItem2, ICaseValue<AdvisoryItem1Case, AdvisoryItem1>
        {
            public AdvisoryItem1 _value;

            public override T Match<T>(Func<AdvisoryItem, T> advisoryItem, Func<AdvisoryItem1, T> advisoryItem1)
            {
                return advisoryItem1(_value);
            }

            public AdvisoryItem1Case Set(AdvisoryItem1 value)
            {
                _value = value;
                return this;
            }

            public AdvisoryItem1 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is AdvisoryItem1Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}