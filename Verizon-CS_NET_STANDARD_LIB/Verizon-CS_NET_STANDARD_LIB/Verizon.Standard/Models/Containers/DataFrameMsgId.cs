// <copyright file="DataFrameMsgId.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<DataFrameMsgId>),
        new Type[] {
            typeof(MsgIdCase),
            typeof(MsgId1Case)
        },
        true
    )]
    public abstract class DataFrameMsgId
    {
        /// <summary>
        /// This is MsgId case.
        /// </summary>
        /// <returns>
        /// The DataFrameMsgId instance, wrapping the provided MsgId value.
        /// </returns>
        public static DataFrameMsgId FromMsgId(MsgId msgId)
        {
            return new MsgIdCase().Set(msgId);
        }

        /// <summary>
        /// This is MsgId1 case.
        /// </summary>
        /// <returns>
        /// The DataFrameMsgId instance, wrapping the provided MsgId1 value.
        /// </returns>
        public static DataFrameMsgId FromMsgId1(MsgId1 msgId1)
        {
            return new MsgId1Case().Set(msgId1);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<MsgId, T> msgId, Func<MsgId1, T> msgId1);

        [JsonConverter(typeof(UnionTypeCaseConverter<MsgIdCase, MsgId>))]
        private sealed class MsgIdCase : DataFrameMsgId, ICaseValue<MsgIdCase, MsgId>
        {
            public MsgId _value;

            public override T Match<T>(Func<MsgId, T> msgId, Func<MsgId1, T> msgId1)
            {
                return msgId(_value);
            }

            public MsgIdCase Set(MsgId value)
            {
                _value = value;
                return this;
            }

            public MsgId Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is MsgIdCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<MsgId1Case, MsgId1>))]
        private sealed class MsgId1Case : DataFrameMsgId, ICaseValue<MsgId1Case, MsgId1>
        {
            public MsgId1 _value;

            public override T Match<T>(Func<MsgId, T> msgId, Func<MsgId1, T> msgId1)
            {
                return msgId1(_value);
            }

            public MsgId1Case Set(MsgId1 value)
            {
                _value = value;
                return this;
            }

            public MsgId1 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is MsgId1Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}