// <copyright file="UpdateTriggerRulesBody.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<UpdateTriggerRulesBody>),
        new Type[] {
            typeof(AccountLevelUpdateTriggerRequestCase),
            typeof(DeviceLevelUpdateTriggerRequestCase),
            typeof(AccountGroupShareUpdateTriggerRequestCase),
            typeof(AccountShareUpdateTriggerRequestCase),
            typeof(PayAsYouGoUpdateTriggerRequestCase),
            typeof(UpdatetriggerchunkCase)
        },
        false
    )]
    public abstract class UpdateTriggerRulesBody
    {
        /// <summary>
        /// This is accountLevelUpdateTriggerRequest case.
        /// </summary>
        /// <returns>
        /// The UpdateTriggerRulesBody instance, wrapping the provided AccountLevelUpdateTriggerRequest value.
        /// </returns>
        public static UpdateTriggerRulesBody FromAccountLevelUpdateTriggerRequest(AccountLevelUpdateTriggerRequest accountLevelUpdateTriggerRequest)
        {
            return new AccountLevelUpdateTriggerRequestCase().Set(accountLevelUpdateTriggerRequest);
        }

        /// <summary>
        /// This is deviceLevelUpdateTriggerRequest case.
        /// </summary>
        /// <returns>
        /// The UpdateTriggerRulesBody instance, wrapping the provided DeviceLevelUpdateTriggerRequest value.
        /// </returns>
        public static UpdateTriggerRulesBody FromDeviceLevelUpdateTriggerRequest(DeviceLevelUpdateTriggerRequest deviceLevelUpdateTriggerRequest)
        {
            return new DeviceLevelUpdateTriggerRequestCase().Set(deviceLevelUpdateTriggerRequest);
        }

        /// <summary>
        /// This is accountGroupShareUpdateTriggerRequest case.
        /// </summary>
        /// <returns>
        /// The UpdateTriggerRulesBody instance, wrapping the provided AccountGroupShareUpdateTriggerRequest value.
        /// </returns>
        public static UpdateTriggerRulesBody FromAccountGroupShareUpdateTriggerRequest(AccountGroupShareUpdateTriggerRequest accountGroupShareUpdateTriggerRequest)
        {
            return new AccountGroupShareUpdateTriggerRequestCase().Set(accountGroupShareUpdateTriggerRequest);
        }

        /// <summary>
        /// This is accountShareUpdateTriggerRequest case.
        /// </summary>
        /// <returns>
        /// The UpdateTriggerRulesBody instance, wrapping the provided AccountShareUpdateTriggerRequest value.
        /// </returns>
        public static UpdateTriggerRulesBody FromAccountShareUpdateTriggerRequest(AccountShareUpdateTriggerRequest accountShareUpdateTriggerRequest)
        {
            return new AccountShareUpdateTriggerRequestCase().Set(accountShareUpdateTriggerRequest);
        }

        /// <summary>
        /// This is payAsYouGoUpdateTriggerRequest case.
        /// </summary>
        /// <returns>
        /// The UpdateTriggerRulesBody instance, wrapping the provided PayAsYouGoUpdateTriggerRequest value.
        /// </returns>
        public static UpdateTriggerRulesBody FromPayAsYouGoUpdateTriggerRequest(PayAsYouGoUpdateTriggerRequest payAsYouGoUpdateTriggerRequest)
        {
            return new PayAsYouGoUpdateTriggerRequestCase().Set(payAsYouGoUpdateTriggerRequest);
        }

        /// <summary>
        /// This is updatetriggerchunk case.
        /// </summary>
        /// <returns>
        /// The UpdateTriggerRulesBody instance, wrapping the provided Updatetriggerchunk value.
        /// </returns>
        public static UpdateTriggerRulesBody FromUpdatetriggerchunk(Updatetriggerchunk updatetriggerchunk)
        {
            return new UpdatetriggerchunkCase().Set(updatetriggerchunk);
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
            Func<AccountLevelUpdateTriggerRequest, T> accountLevelUpdateTriggerRequest,
            Func<DeviceLevelUpdateTriggerRequest, T> deviceLevelUpdateTriggerRequest,
            Func<AccountGroupShareUpdateTriggerRequest, T> accountGroupShareUpdateTriggerRequest,
            Func<AccountShareUpdateTriggerRequest, T> accountShareUpdateTriggerRequest,
            Func<PayAsYouGoUpdateTriggerRequest, T> payAsYouGoUpdateTriggerRequest,
            Func<Updatetriggerchunk, T> updatetriggerchunk);

        [JsonConverter(typeof(UnionTypeCaseConverter<AccountLevelUpdateTriggerRequestCase, AccountLevelUpdateTriggerRequest>))]
        private sealed class AccountLevelUpdateTriggerRequestCase : UpdateTriggerRulesBody, ICaseValue<AccountLevelUpdateTriggerRequestCase, AccountLevelUpdateTriggerRequest>
        {
            public AccountLevelUpdateTriggerRequest _value;

            public override T Match<T>(
                Func<AccountLevelUpdateTriggerRequest, T> accountLevelUpdateTriggerRequest,
                Func<DeviceLevelUpdateTriggerRequest, T> deviceLevelUpdateTriggerRequest,
                Func<AccountGroupShareUpdateTriggerRequest, T> accountGroupShareUpdateTriggerRequest,
                Func<AccountShareUpdateTriggerRequest, T> accountShareUpdateTriggerRequest,
                Func<PayAsYouGoUpdateTriggerRequest, T> payAsYouGoUpdateTriggerRequest,
                Func<Updatetriggerchunk, T> updatetriggerchunk)
            {
                return accountLevelUpdateTriggerRequest(_value);
            }

            public AccountLevelUpdateTriggerRequestCase Set(AccountLevelUpdateTriggerRequest value)
            {
                _value = value;
                return this;
            }

            public AccountLevelUpdateTriggerRequest Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is AccountLevelUpdateTriggerRequestCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DeviceLevelUpdateTriggerRequestCase, DeviceLevelUpdateTriggerRequest>))]
        private sealed class DeviceLevelUpdateTriggerRequestCase : UpdateTriggerRulesBody, ICaseValue<DeviceLevelUpdateTriggerRequestCase, DeviceLevelUpdateTriggerRequest>
        {
            public DeviceLevelUpdateTriggerRequest _value;

            public override T Match<T>(
                Func<AccountLevelUpdateTriggerRequest, T> accountLevelUpdateTriggerRequest,
                Func<DeviceLevelUpdateTriggerRequest, T> deviceLevelUpdateTriggerRequest,
                Func<AccountGroupShareUpdateTriggerRequest, T> accountGroupShareUpdateTriggerRequest,
                Func<AccountShareUpdateTriggerRequest, T> accountShareUpdateTriggerRequest,
                Func<PayAsYouGoUpdateTriggerRequest, T> payAsYouGoUpdateTriggerRequest,
                Func<Updatetriggerchunk, T> updatetriggerchunk)
            {
                return deviceLevelUpdateTriggerRequest(_value);
            }

            public DeviceLevelUpdateTriggerRequestCase Set(DeviceLevelUpdateTriggerRequest value)
            {
                _value = value;
                return this;
            }

            public DeviceLevelUpdateTriggerRequest Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is DeviceLevelUpdateTriggerRequestCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<AccountGroupShareUpdateTriggerRequestCase, AccountGroupShareUpdateTriggerRequest>))]
        private sealed class AccountGroupShareUpdateTriggerRequestCase : UpdateTriggerRulesBody, ICaseValue<AccountGroupShareUpdateTriggerRequestCase, AccountGroupShareUpdateTriggerRequest>
        {
            public AccountGroupShareUpdateTriggerRequest _value;

            public override T Match<T>(
                Func<AccountLevelUpdateTriggerRequest, T> accountLevelUpdateTriggerRequest,
                Func<DeviceLevelUpdateTriggerRequest, T> deviceLevelUpdateTriggerRequest,
                Func<AccountGroupShareUpdateTriggerRequest, T> accountGroupShareUpdateTriggerRequest,
                Func<AccountShareUpdateTriggerRequest, T> accountShareUpdateTriggerRequest,
                Func<PayAsYouGoUpdateTriggerRequest, T> payAsYouGoUpdateTriggerRequest,
                Func<Updatetriggerchunk, T> updatetriggerchunk)
            {
                return accountGroupShareUpdateTriggerRequest(_value);
            }

            public AccountGroupShareUpdateTriggerRequestCase Set(AccountGroupShareUpdateTriggerRequest value)
            {
                _value = value;
                return this;
            }

            public AccountGroupShareUpdateTriggerRequest Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is AccountGroupShareUpdateTriggerRequestCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<AccountShareUpdateTriggerRequestCase, AccountShareUpdateTriggerRequest>))]
        private sealed class AccountShareUpdateTriggerRequestCase : UpdateTriggerRulesBody, ICaseValue<AccountShareUpdateTriggerRequestCase, AccountShareUpdateTriggerRequest>
        {
            public AccountShareUpdateTriggerRequest _value;

            public override T Match<T>(
                Func<AccountLevelUpdateTriggerRequest, T> accountLevelUpdateTriggerRequest,
                Func<DeviceLevelUpdateTriggerRequest, T> deviceLevelUpdateTriggerRequest,
                Func<AccountGroupShareUpdateTriggerRequest, T> accountGroupShareUpdateTriggerRequest,
                Func<AccountShareUpdateTriggerRequest, T> accountShareUpdateTriggerRequest,
                Func<PayAsYouGoUpdateTriggerRequest, T> payAsYouGoUpdateTriggerRequest,
                Func<Updatetriggerchunk, T> updatetriggerchunk)
            {
                return accountShareUpdateTriggerRequest(_value);
            }

            public AccountShareUpdateTriggerRequestCase Set(AccountShareUpdateTriggerRequest value)
            {
                _value = value;
                return this;
            }

            public AccountShareUpdateTriggerRequest Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is AccountShareUpdateTriggerRequestCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PayAsYouGoUpdateTriggerRequestCase, PayAsYouGoUpdateTriggerRequest>))]
        private sealed class PayAsYouGoUpdateTriggerRequestCase : UpdateTriggerRulesBody, ICaseValue<PayAsYouGoUpdateTriggerRequestCase, PayAsYouGoUpdateTriggerRequest>
        {
            public PayAsYouGoUpdateTriggerRequest _value;

            public override T Match<T>(
                Func<AccountLevelUpdateTriggerRequest, T> accountLevelUpdateTriggerRequest,
                Func<DeviceLevelUpdateTriggerRequest, T> deviceLevelUpdateTriggerRequest,
                Func<AccountGroupShareUpdateTriggerRequest, T> accountGroupShareUpdateTriggerRequest,
                Func<AccountShareUpdateTriggerRequest, T> accountShareUpdateTriggerRequest,
                Func<PayAsYouGoUpdateTriggerRequest, T> payAsYouGoUpdateTriggerRequest,
                Func<Updatetriggerchunk, T> updatetriggerchunk)
            {
                return payAsYouGoUpdateTriggerRequest(_value);
            }

            public PayAsYouGoUpdateTriggerRequestCase Set(PayAsYouGoUpdateTriggerRequest value)
            {
                _value = value;
                return this;
            }

            public PayAsYouGoUpdateTriggerRequest Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PayAsYouGoUpdateTriggerRequestCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<UpdatetriggerchunkCase, Updatetriggerchunk>))]
        private sealed class UpdatetriggerchunkCase : UpdateTriggerRulesBody, ICaseValue<UpdatetriggerchunkCase, Updatetriggerchunk>
        {
            public Updatetriggerchunk _value;

            public override T Match<T>(
                Func<AccountLevelUpdateTriggerRequest, T> accountLevelUpdateTriggerRequest,
                Func<DeviceLevelUpdateTriggerRequest, T> deviceLevelUpdateTriggerRequest,
                Func<AccountGroupShareUpdateTriggerRequest, T> accountGroupShareUpdateTriggerRequest,
                Func<AccountShareUpdateTriggerRequest, T> accountShareUpdateTriggerRequest,
                Func<PayAsYouGoUpdateTriggerRequest, T> payAsYouGoUpdateTriggerRequest,
                Func<Updatetriggerchunk, T> updatetriggerchunk)
            {
                return updatetriggerchunk(_value);
            }

            public UpdatetriggerchunkCase Set(Updatetriggerchunk value)
            {
                _value = value;
                return this;
            }

            public Updatetriggerchunk Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is UpdatetriggerchunkCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}