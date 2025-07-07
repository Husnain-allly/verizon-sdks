// <copyright file="AccountLevelUpdateTriggerRequestSmsNumbers.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<AccountLevelUpdateTriggerRequestSmsNumbers>),
        new Type[] {
            typeof(CellphonenumberCase)
        },
        false
    )]
    public abstract class AccountLevelUpdateTriggerRequestSmsNumbers
    {
        /// <summary>
        /// This is cellphonenumber case.
        /// </summary>
        /// <returns>
        /// The AccountLevelUpdateTriggerRequestSmsNumbers instance, wrapping the provided Cellphonenumber value.
        /// </returns>
        public static AccountLevelUpdateTriggerRequestSmsNumbers FromCellphonenumber(Cellphonenumber cellphonenumber)
        {
            return new CellphonenumberCase().Set(cellphonenumber);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<Cellphonenumber, T> cellphonenumber);

        [JsonConverter(typeof(UnionTypeCaseConverter<CellphonenumberCase, Cellphonenumber>))]
        private sealed class CellphonenumberCase : AccountLevelUpdateTriggerRequestSmsNumbers, ICaseValue<CellphonenumberCase, Cellphonenumber>
        {
            public Cellphonenumber _value;

            public override T Match<T>(Func<Cellphonenumber, T> cellphonenumber)
            {
                return cellphonenumber(_value);
            }

            public CellphonenumberCase Set(Cellphonenumber value)
            {
                _value = value;
                return this;
            }

            public Cellphonenumber Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is CellphonenumberCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}