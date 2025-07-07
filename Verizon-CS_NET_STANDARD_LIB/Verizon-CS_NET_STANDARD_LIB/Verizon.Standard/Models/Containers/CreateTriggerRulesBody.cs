// <copyright file="CreateTriggerRulesBody.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<CreateTriggerRulesBody>),
        new Type[] {
            typeof(AccountLevelCreateTriggerRequestCase),
            typeof(AccountLevelObjectCase),
            typeof(DeviceLevelCreateTriggerRequestCase),
            typeof(AccountGroupShareCreateTriggerRequestCase),
            typeof(AccountShareCreateTriggerRequestCase),
            typeof(PayAsYouGoCreateTriggerRequestCase),
            typeof(CreatetriggerchunkCase)
        },
        false
    )]
    public abstract class CreateTriggerRulesBody
    {
        /// <summary>
        /// This is accountLevelCreateTriggerRequest case.
        /// </summary>
        /// <returns>
        /// The CreateTriggerRulesBody instance, wrapping the provided AccountLevelCreateTriggerRequest value.
        /// </returns>
        public static CreateTriggerRulesBody FromAccountLevelCreateTriggerRequest(AccountLevelCreateTriggerRequest accountLevelCreateTriggerRequest)
        {
            return new AccountLevelCreateTriggerRequestCase().Set(accountLevelCreateTriggerRequest);
        }

        /// <summary>
        /// This is accountLevelObject case.
        /// </summary>
        /// <returns>
        /// The CreateTriggerRulesBody instance, wrapping the provided AccountLevelObject value.
        /// </returns>
        public static CreateTriggerRulesBody FromAccountLevelObject(AccountLevelObject accountLevelObject)
        {
            return new AccountLevelObjectCase().Set(accountLevelObject);
        }

        /// <summary>
        /// This is deviceLevelCreateTriggerRequest case.
        /// </summary>
        /// <returns>
        /// The CreateTriggerRulesBody instance, wrapping the provided DeviceLevelCreateTriggerRequest value.
        /// </returns>
        public static CreateTriggerRulesBody FromDeviceLevelCreateTriggerRequest(DeviceLevelCreateTriggerRequest deviceLevelCreateTriggerRequest)
        {
            return new DeviceLevelCreateTriggerRequestCase().Set(deviceLevelCreateTriggerRequest);
        }

        /// <summary>
        /// This is accountGroupShareCreateTriggerRequest case.
        /// </summary>
        /// <returns>
        /// The CreateTriggerRulesBody instance, wrapping the provided AccountGroupShareCreateTriggerRequest value.
        /// </returns>
        public static CreateTriggerRulesBody FromAccountGroupShareCreateTriggerRequest(AccountGroupShareCreateTriggerRequest accountGroupShareCreateTriggerRequest)
        {
            return new AccountGroupShareCreateTriggerRequestCase().Set(accountGroupShareCreateTriggerRequest);
        }

        /// <summary>
        /// This is accountShareCreateTriggerRequest case.
        /// </summary>
        /// <returns>
        /// The CreateTriggerRulesBody instance, wrapping the provided AccountShareCreateTriggerRequest value.
        /// </returns>
        public static CreateTriggerRulesBody FromAccountShareCreateTriggerRequest(AccountShareCreateTriggerRequest accountShareCreateTriggerRequest)
        {
            return new AccountShareCreateTriggerRequestCase().Set(accountShareCreateTriggerRequest);
        }

        /// <summary>
        /// This is payAsYouGoCreateTriggerRequest case.
        /// </summary>
        /// <returns>
        /// The CreateTriggerRulesBody instance, wrapping the provided PayAsYouGoCreateTriggerRequest value.
        /// </returns>
        public static CreateTriggerRulesBody FromPayAsYouGoCreateTriggerRequest(PayAsYouGoCreateTriggerRequest payAsYouGoCreateTriggerRequest)
        {
            return new PayAsYouGoCreateTriggerRequestCase().Set(payAsYouGoCreateTriggerRequest);
        }

        /// <summary>
        /// This is createtriggerchunk case.
        /// </summary>
        /// <returns>
        /// The CreateTriggerRulesBody instance, wrapping the provided Createtriggerchunk value.
        /// </returns>
        public static CreateTriggerRulesBody FromCreatetriggerchunk(Createtriggerchunk createtriggerchunk)
        {
            return new CreatetriggerchunkCase().Set(createtriggerchunk);
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
            Func<AccountLevelCreateTriggerRequest, T> accountLevelCreateTriggerRequest,
            Func<AccountLevelObject, T> accountLevelObject,
            Func<DeviceLevelCreateTriggerRequest, T> deviceLevelCreateTriggerRequest,
            Func<AccountGroupShareCreateTriggerRequest, T> accountGroupShareCreateTriggerRequest,
            Func<AccountShareCreateTriggerRequest, T> accountShareCreateTriggerRequest,
            Func<PayAsYouGoCreateTriggerRequest, T> payAsYouGoCreateTriggerRequest,
            Func<Createtriggerchunk, T> createtriggerchunk);

        [JsonConverter(typeof(UnionTypeCaseConverter<AccountLevelCreateTriggerRequestCase, AccountLevelCreateTriggerRequest>))]
        private sealed class AccountLevelCreateTriggerRequestCase : CreateTriggerRulesBody, ICaseValue<AccountLevelCreateTriggerRequestCase, AccountLevelCreateTriggerRequest>
        {
            public AccountLevelCreateTriggerRequest _value;

            public override T Match<T>(
                Func<AccountLevelCreateTriggerRequest, T> accountLevelCreateTriggerRequest,
                Func<AccountLevelObject, T> accountLevelObject,
                Func<DeviceLevelCreateTriggerRequest, T> deviceLevelCreateTriggerRequest,
                Func<AccountGroupShareCreateTriggerRequest, T> accountGroupShareCreateTriggerRequest,
                Func<AccountShareCreateTriggerRequest, T> accountShareCreateTriggerRequest,
                Func<PayAsYouGoCreateTriggerRequest, T> payAsYouGoCreateTriggerRequest,
                Func<Createtriggerchunk, T> createtriggerchunk)
            {
                return accountLevelCreateTriggerRequest(_value);
            }

            public AccountLevelCreateTriggerRequestCase Set(AccountLevelCreateTriggerRequest value)
            {
                _value = value;
                return this;
            }

            public AccountLevelCreateTriggerRequest Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is AccountLevelCreateTriggerRequestCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<AccountLevelObjectCase, AccountLevelObject>))]
        private sealed class AccountLevelObjectCase : CreateTriggerRulesBody, ICaseValue<AccountLevelObjectCase, AccountLevelObject>
        {
            public AccountLevelObject _value;

            public override T Match<T>(
                Func<AccountLevelCreateTriggerRequest, T> accountLevelCreateTriggerRequest,
                Func<AccountLevelObject, T> accountLevelObject,
                Func<DeviceLevelCreateTriggerRequest, T> deviceLevelCreateTriggerRequest,
                Func<AccountGroupShareCreateTriggerRequest, T> accountGroupShareCreateTriggerRequest,
                Func<AccountShareCreateTriggerRequest, T> accountShareCreateTriggerRequest,
                Func<PayAsYouGoCreateTriggerRequest, T> payAsYouGoCreateTriggerRequest,
                Func<Createtriggerchunk, T> createtriggerchunk)
            {
                return accountLevelObject(_value);
            }

            public AccountLevelObjectCase Set(AccountLevelObject value)
            {
                _value = value;
                return this;
            }

            public AccountLevelObject Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is AccountLevelObjectCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DeviceLevelCreateTriggerRequestCase, DeviceLevelCreateTriggerRequest>))]
        private sealed class DeviceLevelCreateTriggerRequestCase : CreateTriggerRulesBody, ICaseValue<DeviceLevelCreateTriggerRequestCase, DeviceLevelCreateTriggerRequest>
        {
            public DeviceLevelCreateTriggerRequest _value;

            public override T Match<T>(
                Func<AccountLevelCreateTriggerRequest, T> accountLevelCreateTriggerRequest,
                Func<AccountLevelObject, T> accountLevelObject,
                Func<DeviceLevelCreateTriggerRequest, T> deviceLevelCreateTriggerRequest,
                Func<AccountGroupShareCreateTriggerRequest, T> accountGroupShareCreateTriggerRequest,
                Func<AccountShareCreateTriggerRequest, T> accountShareCreateTriggerRequest,
                Func<PayAsYouGoCreateTriggerRequest, T> payAsYouGoCreateTriggerRequest,
                Func<Createtriggerchunk, T> createtriggerchunk)
            {
                return deviceLevelCreateTriggerRequest(_value);
            }

            public DeviceLevelCreateTriggerRequestCase Set(DeviceLevelCreateTriggerRequest value)
            {
                _value = value;
                return this;
            }

            public DeviceLevelCreateTriggerRequest Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is DeviceLevelCreateTriggerRequestCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<AccountGroupShareCreateTriggerRequestCase, AccountGroupShareCreateTriggerRequest>))]
        private sealed class AccountGroupShareCreateTriggerRequestCase : CreateTriggerRulesBody, ICaseValue<AccountGroupShareCreateTriggerRequestCase, AccountGroupShareCreateTriggerRequest>
        {
            public AccountGroupShareCreateTriggerRequest _value;

            public override T Match<T>(
                Func<AccountLevelCreateTriggerRequest, T> accountLevelCreateTriggerRequest,
                Func<AccountLevelObject, T> accountLevelObject,
                Func<DeviceLevelCreateTriggerRequest, T> deviceLevelCreateTriggerRequest,
                Func<AccountGroupShareCreateTriggerRequest, T> accountGroupShareCreateTriggerRequest,
                Func<AccountShareCreateTriggerRequest, T> accountShareCreateTriggerRequest,
                Func<PayAsYouGoCreateTriggerRequest, T> payAsYouGoCreateTriggerRequest,
                Func<Createtriggerchunk, T> createtriggerchunk)
            {
                return accountGroupShareCreateTriggerRequest(_value);
            }

            public AccountGroupShareCreateTriggerRequestCase Set(AccountGroupShareCreateTriggerRequest value)
            {
                _value = value;
                return this;
            }

            public AccountGroupShareCreateTriggerRequest Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is AccountGroupShareCreateTriggerRequestCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<AccountShareCreateTriggerRequestCase, AccountShareCreateTriggerRequest>))]
        private sealed class AccountShareCreateTriggerRequestCase : CreateTriggerRulesBody, ICaseValue<AccountShareCreateTriggerRequestCase, AccountShareCreateTriggerRequest>
        {
            public AccountShareCreateTriggerRequest _value;

            public override T Match<T>(
                Func<AccountLevelCreateTriggerRequest, T> accountLevelCreateTriggerRequest,
                Func<AccountLevelObject, T> accountLevelObject,
                Func<DeviceLevelCreateTriggerRequest, T> deviceLevelCreateTriggerRequest,
                Func<AccountGroupShareCreateTriggerRequest, T> accountGroupShareCreateTriggerRequest,
                Func<AccountShareCreateTriggerRequest, T> accountShareCreateTriggerRequest,
                Func<PayAsYouGoCreateTriggerRequest, T> payAsYouGoCreateTriggerRequest,
                Func<Createtriggerchunk, T> createtriggerchunk)
            {
                return accountShareCreateTriggerRequest(_value);
            }

            public AccountShareCreateTriggerRequestCase Set(AccountShareCreateTriggerRequest value)
            {
                _value = value;
                return this;
            }

            public AccountShareCreateTriggerRequest Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is AccountShareCreateTriggerRequestCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PayAsYouGoCreateTriggerRequestCase, PayAsYouGoCreateTriggerRequest>))]
        private sealed class PayAsYouGoCreateTriggerRequestCase : CreateTriggerRulesBody, ICaseValue<PayAsYouGoCreateTriggerRequestCase, PayAsYouGoCreateTriggerRequest>
        {
            public PayAsYouGoCreateTriggerRequest _value;

            public override T Match<T>(
                Func<AccountLevelCreateTriggerRequest, T> accountLevelCreateTriggerRequest,
                Func<AccountLevelObject, T> accountLevelObject,
                Func<DeviceLevelCreateTriggerRequest, T> deviceLevelCreateTriggerRequest,
                Func<AccountGroupShareCreateTriggerRequest, T> accountGroupShareCreateTriggerRequest,
                Func<AccountShareCreateTriggerRequest, T> accountShareCreateTriggerRequest,
                Func<PayAsYouGoCreateTriggerRequest, T> payAsYouGoCreateTriggerRequest,
                Func<Createtriggerchunk, T> createtriggerchunk)
            {
                return payAsYouGoCreateTriggerRequest(_value);
            }

            public PayAsYouGoCreateTriggerRequestCase Set(PayAsYouGoCreateTriggerRequest value)
            {
                _value = value;
                return this;
            }

            public PayAsYouGoCreateTriggerRequest Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PayAsYouGoCreateTriggerRequestCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CreatetriggerchunkCase, Createtriggerchunk>))]
        private sealed class CreatetriggerchunkCase : CreateTriggerRulesBody, ICaseValue<CreatetriggerchunkCase, Createtriggerchunk>
        {
            public Createtriggerchunk _value;

            public override T Match<T>(
                Func<AccountLevelCreateTriggerRequest, T> accountLevelCreateTriggerRequest,
                Func<AccountLevelObject, T> accountLevelObject,
                Func<DeviceLevelCreateTriggerRequest, T> deviceLevelCreateTriggerRequest,
                Func<AccountGroupShareCreateTriggerRequest, T> accountGroupShareCreateTriggerRequest,
                Func<AccountShareCreateTriggerRequest, T> accountShareCreateTriggerRequest,
                Func<PayAsYouGoCreateTriggerRequest, T> payAsYouGoCreateTriggerRequest,
                Func<Createtriggerchunk, T> createtriggerchunk)
            {
                return createtriggerchunk(_value);
            }

            public CreatetriggerchunkCase Set(Createtriggerchunk value)
            {
                _value = value;
                return this;
            }

            public Createtriggerchunk Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is CreatetriggerchunkCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}