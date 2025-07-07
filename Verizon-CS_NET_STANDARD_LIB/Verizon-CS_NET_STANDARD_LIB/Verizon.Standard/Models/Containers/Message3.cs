// <copyright file="Message3.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<Message3>),
        new Type[] {
            typeof(MessageCase),
            typeof(Message1Case),
            typeof(Message2Case)
        },
        true
    )]
    public abstract class Message3
    {
        /// <summary>
        /// This is Message case.
        /// </summary>
        /// <returns>
        /// The Message3 instance, wrapping the provided Message value.
        /// </returns>
        public static Message3 FromMessage(Message message)
        {
            return new MessageCase().Set(message);
        }

        /// <summary>
        /// This is Message1 case.
        /// </summary>
        /// <returns>
        /// The Message3 instance, wrapping the provided Message1 value.
        /// </returns>
        public static Message3 FromMessage1(Message1 message1)
        {
            return new Message1Case().Set(message1);
        }

        /// <summary>
        /// This is Message2 case.
        /// </summary>
        /// <returns>
        /// The Message3 instance, wrapping the provided Message2 value.
        /// </returns>
        public static Message3 FromMessage2(Message2 message2)
        {
            return new Message2Case().Set(message2);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<Message, T> message,
            Func<Message1, T> message1,
            Func<Message2, T> message2);

        [JsonConverter(typeof(UnionTypeCaseConverter<MessageCase, Message>))]
        private sealed class MessageCase : Message3, ICaseValue<MessageCase, Message>
        {
            public Message _value;

            public override T Match<T>(
                Func<Message, T> message,
                Func<Message1, T> message1,
                Func<Message2, T> message2)
            {
                return message(_value);
            }

            public MessageCase Set(Message value)
            {
                _value = value;
                return this;
            }

            public Message Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is MessageCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<Message1Case, Message1>))]
        private sealed class Message1Case : Message3, ICaseValue<Message1Case, Message1>
        {
            public Message1 _value;

            public override T Match<T>(
                Func<Message, T> message,
                Func<Message1, T> message1,
                Func<Message2, T> message2)
            {
                return message1(_value);
            }

            public Message1Case Set(Message1 value)
            {
                _value = value;
                return this;
            }

            public Message1 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is Message1Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<Message2Case, Message2>))]
        private sealed class Message2Case : Message3, ICaseValue<Message2Case, Message2>
        {
            public Message2 _value;

            public override T Match<T>(
                Func<Message, T> message,
                Func<Message1, T> message1,
                Func<Message2, T> message2)
            {
                return message2(_value);
            }

            public Message2Case Set(Message2 value)
            {
                _value = value;
                return this;
            }

            public Message2 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is Message2Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}