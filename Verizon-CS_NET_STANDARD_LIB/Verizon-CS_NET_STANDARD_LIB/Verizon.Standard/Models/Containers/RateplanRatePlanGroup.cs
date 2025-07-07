// <copyright file="RateplanRatePlanGroup.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<RateplanRatePlanGroup>),
        new Type[] {
            typeof(RateplantypeObjectCase),
            typeof(Rateplantype2Case)
        },
        false
    )]
    public abstract class RateplanRatePlanGroup
    {
        /// <summary>
        /// This is rateplantypeObject case.
        /// </summary>
        /// <returns>
        /// The RateplanRatePlanGroup instance, wrapping the provided RateplantypeObject value.
        /// </returns>
        public static RateplanRatePlanGroup FromRateplantypeObject(RateplantypeObject rateplantypeObject)
        {
            return new RateplantypeObjectCase().Set(rateplantypeObject);
        }

        /// <summary>
        /// This is rateplantype2 case.
        /// </summary>
        /// <returns>
        /// The RateplanRatePlanGroup instance, wrapping the provided Rateplantype2 value.
        /// </returns>
        public static RateplanRatePlanGroup FromRateplantype2(Rateplantype2 rateplantype2)
        {
            return new Rateplantype2Case().Set(rateplantype2);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<RateplantypeObject, T> rateplantypeObject, Func<Rateplantype2, T> rateplantype2);

        [JsonConverter(typeof(UnionTypeCaseConverter<RateplantypeObjectCase, RateplantypeObject>))]
        private sealed class RateplantypeObjectCase : RateplanRatePlanGroup, ICaseValue<RateplantypeObjectCase, RateplantypeObject>
        {
            public RateplantypeObject _value;

            public override T Match<T>(Func<RateplantypeObject, T> rateplantypeObject, Func<Rateplantype2, T> rateplantype2)
            {
                return rateplantypeObject(_value);
            }

            public RateplantypeObjectCase Set(RateplantypeObject value)
            {
                _value = value;
                return this;
            }

            public RateplantypeObject Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is RateplantypeObjectCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<Rateplantype2Case, Rateplantype2>))]
        private sealed class Rateplantype2Case : RateplanRatePlanGroup, ICaseValue<Rateplantype2Case, Rateplantype2>
        {
            public Rateplantype2 _value;

            public override T Match<T>(Func<RateplantypeObject, T> rateplantypeObject, Func<Rateplantype2, T> rateplantype2)
            {
                return rateplantype2(_value);
            }

            public Rateplantype2Case Set(Rateplantype2 value)
            {
                _value = value;
                return this;
            }

            public Rateplantype2 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is Rateplantype2Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}