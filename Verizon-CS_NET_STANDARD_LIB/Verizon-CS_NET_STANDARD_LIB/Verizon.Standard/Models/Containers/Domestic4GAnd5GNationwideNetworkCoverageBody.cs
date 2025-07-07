// <copyright file="Domestic4GAnd5GNationwideNetworkCoverageBody.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<Domestic4GAnd5GNationwideNetworkCoverageBody>),
        new Type[] {
            typeof(GetWirelessCoverageRequestCase),
            typeof(GetWirelessCoverageRequestFwaCase)
        },
        false
    )]
    public abstract class Domestic4GAnd5GNationwideNetworkCoverageBody
    {
        /// <summary>
        /// This is GetWirelessCoverageRequest case.
        /// </summary>
        /// <returns>
        /// The Domestic4GAnd5GNationwideNetworkCoverageBody instance, wrapping the provided GetWirelessCoverageRequest value.
        /// </returns>
        public static Domestic4GAnd5GNationwideNetworkCoverageBody FromGetWirelessCoverageRequest(GetWirelessCoverageRequest getWirelessCoverageRequest)
        {
            return new GetWirelessCoverageRequestCase().Set(getWirelessCoverageRequest);
        }

        /// <summary>
        /// This is GetWirelessCoverageRequestFWA case.
        /// </summary>
        /// <returns>
        /// The Domestic4GAnd5GNationwideNetworkCoverageBody instance, wrapping the provided GetWirelessCoverageRequestFwa value.
        /// </returns>
        public static Domestic4GAnd5GNationwideNetworkCoverageBody FromGetWirelessCoverageRequestFWA(GetWirelessCoverageRequestFwa getWirelessCoverageRequestFwa)
        {
            return new GetWirelessCoverageRequestFwaCase().Set(getWirelessCoverageRequestFwa);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<GetWirelessCoverageRequest, T> getWirelessCoverageRequest, Func<GetWirelessCoverageRequestFwa, T> getWirelessCoverageRequestFwa);

        [JsonConverter(typeof(UnionTypeCaseConverter<GetWirelessCoverageRequestCase, GetWirelessCoverageRequest>))]
        private sealed class GetWirelessCoverageRequestCase : Domestic4GAnd5GNationwideNetworkCoverageBody, ICaseValue<GetWirelessCoverageRequestCase, GetWirelessCoverageRequest>
        {
            public GetWirelessCoverageRequest _value;

            public override T Match<T>(Func<GetWirelessCoverageRequest, T> getWirelessCoverageRequest, Func<GetWirelessCoverageRequestFwa, T> getWirelessCoverageRequestFwa)
            {
                return getWirelessCoverageRequest(_value);
            }

            public GetWirelessCoverageRequestCase Set(GetWirelessCoverageRequest value)
            {
                _value = value;
                return this;
            }

            public GetWirelessCoverageRequest Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is GetWirelessCoverageRequestCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<GetWirelessCoverageRequestFwaCase, GetWirelessCoverageRequestFwa>))]
        private sealed class GetWirelessCoverageRequestFwaCase : Domestic4GAnd5GNationwideNetworkCoverageBody, ICaseValue<GetWirelessCoverageRequestFwaCase, GetWirelessCoverageRequestFwa>
        {
            public GetWirelessCoverageRequestFwa _value;

            public override T Match<T>(Func<GetWirelessCoverageRequest, T> getWirelessCoverageRequest, Func<GetWirelessCoverageRequestFwa, T> getWirelessCoverageRequestFwa)
            {
                return getWirelessCoverageRequestFwa(_value);
            }

            public GetWirelessCoverageRequestFwaCase Set(GetWirelessCoverageRequestFwa value)
            {
                _value = value;
                return this;
            }

            public GetWirelessCoverageRequestFwa Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is GetWirelessCoverageRequestFwaCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}