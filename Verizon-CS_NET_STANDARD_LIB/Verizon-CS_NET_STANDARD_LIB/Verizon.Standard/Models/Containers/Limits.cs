// <copyright file="Limits.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<Limits>),
        new Type[] {
            typeof(SpeedItemCase),
            typeof(HeadingItemCase)
        },
        true
    )]
    public abstract class Limits
    {
        /// <summary>
        /// This is SpeedItem case.
        /// </summary>
        /// <returns>
        /// The Limits instance, wrapping the provided SpeedItem value.
        /// </returns>
        public static Limits FromSpeedItem(SpeedItem speedItem)
        {
            return new SpeedItemCase().Set(speedItem);
        }

        /// <summary>
        /// This is HeadingItem case.
        /// </summary>
        /// <returns>
        /// The Limits instance, wrapping the provided HeadingItem value.
        /// </returns>
        public static Limits FromHeadingItem(HeadingItem headingItem)
        {
            return new HeadingItemCase().Set(headingItem);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<SpeedItem, T> speedItem, Func<HeadingItem, T> headingItem);

        [JsonConverter(typeof(UnionTypeCaseConverter<SpeedItemCase, SpeedItem>))]
        private sealed class SpeedItemCase : Limits, ICaseValue<SpeedItemCase, SpeedItem>
        {
            public SpeedItem _value;

            public override T Match<T>(Func<SpeedItem, T> speedItem, Func<HeadingItem, T> headingItem)
            {
                return speedItem(_value);
            }

            public SpeedItemCase Set(SpeedItem value)
            {
                _value = value;
                return this;
            }

            public SpeedItem Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is SpeedItemCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<HeadingItemCase, HeadingItem>))]
        private sealed class HeadingItemCase : Limits, ICaseValue<HeadingItemCase, HeadingItem>
        {
            public HeadingItem _value;

            public override T Match<T>(Func<SpeedItem, T> speedItem, Func<HeadingItem, T> headingItem)
            {
                return headingItem(_value);
            }

            public HeadingItemCase Set(HeadingItem value)
            {
                _value = value;
                return this;
            }

            public HeadingItem Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is HeadingItemCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}