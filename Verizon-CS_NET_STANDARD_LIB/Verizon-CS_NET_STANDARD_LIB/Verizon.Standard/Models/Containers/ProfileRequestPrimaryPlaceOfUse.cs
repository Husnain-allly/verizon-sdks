// <copyright file="ProfileRequestPrimaryPlaceOfUse.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<ProfileRequestPrimaryPlaceOfUse>),
        new Type[] {
            typeof(CustomernamequeryCase),
            typeof(AddressqueryCase)
        },
        false
    )]
    public abstract class ProfileRequestPrimaryPlaceOfUse
    {
        /// <summary>
        /// This is customernamequery case.
        /// </summary>
        /// <returns>
        /// The ProfileRequestPrimaryPlaceOfUse instance, wrapping the provided Customernamequery value.
        /// </returns>
        public static ProfileRequestPrimaryPlaceOfUse FromCustomernamequery(Customernamequery customernamequery)
        {
            return new CustomernamequeryCase().Set(customernamequery);
        }

        /// <summary>
        /// This is addressquery case.
        /// </summary>
        /// <returns>
        /// The ProfileRequestPrimaryPlaceOfUse instance, wrapping the provided Addressquery value.
        /// </returns>
        public static ProfileRequestPrimaryPlaceOfUse FromAddressquery(Addressquery addressquery)
        {
            return new AddressqueryCase().Set(addressquery);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<Customernamequery, T> customernamequery, Func<Addressquery, T> addressquery);

        [JsonConverter(typeof(UnionTypeCaseConverter<CustomernamequeryCase, Customernamequery>))]
        private sealed class CustomernamequeryCase : ProfileRequestPrimaryPlaceOfUse, ICaseValue<CustomernamequeryCase, Customernamequery>
        {
            public Customernamequery _value;

            public override T Match<T>(Func<Customernamequery, T> customernamequery, Func<Addressquery, T> addressquery)
            {
                return customernamequery(_value);
            }

            public CustomernamequeryCase Set(Customernamequery value)
            {
                _value = value;
                return this;
            }

            public Customernamequery Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is CustomernamequeryCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<AddressqueryCase, Addressquery>))]
        private sealed class AddressqueryCase : ProfileRequestPrimaryPlaceOfUse, ICaseValue<AddressqueryCase, Addressquery>
        {
            public Addressquery _value;

            public override T Match<T>(Func<Customernamequery, T> customernamequery, Func<Addressquery, T> addressquery)
            {
                return addressquery(_value);
            }

            public AddressqueryCase Set(Addressquery value)
            {
                _value = value;
                return this;
            }

            public Addressquery Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is AddressqueryCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}