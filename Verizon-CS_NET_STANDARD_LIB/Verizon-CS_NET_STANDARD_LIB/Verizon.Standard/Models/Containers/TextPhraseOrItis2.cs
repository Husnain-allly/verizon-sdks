// <copyright file="TextPhraseOrItis2.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<TextPhraseOrItis2>),
        new Type[] {
            typeof(TextPhraseOrItisCase),
            typeof(TextPhraseOrItis1Case)
        },
        true
    )]
    public abstract class TextPhraseOrItis2
    {
        /// <summary>
        /// This is TextPhraseOrITIS case.
        /// </summary>
        /// <returns>
        /// The TextPhraseOrItis2 instance, wrapping the provided TextPhraseOrItis value.
        /// </returns>
        public static TextPhraseOrItis2 FromTextPhraseOrITIS(TextPhraseOrItis textPhraseOrItis)
        {
            return new TextPhraseOrItisCase().Set(textPhraseOrItis);
        }

        /// <summary>
        /// This is TextPhraseOrITIS1 case.
        /// </summary>
        /// <returns>
        /// The TextPhraseOrItis2 instance, wrapping the provided TextPhraseOrItis1 value.
        /// </returns>
        public static TextPhraseOrItis2 FromTextPhraseOrITIS1(TextPhraseOrItis1 textPhraseOrItis1)
        {
            return new TextPhraseOrItis1Case().Set(textPhraseOrItis1);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<TextPhraseOrItis, T> textPhraseOrItis, Func<TextPhraseOrItis1, T> textPhraseOrItis1);

        [JsonConverter(typeof(UnionTypeCaseConverter<TextPhraseOrItisCase, TextPhraseOrItis>))]
        private sealed class TextPhraseOrItisCase : TextPhraseOrItis2, ICaseValue<TextPhraseOrItisCase, TextPhraseOrItis>
        {
            public TextPhraseOrItis _value;

            public override T Match<T>(Func<TextPhraseOrItis, T> textPhraseOrItis, Func<TextPhraseOrItis1, T> textPhraseOrItis1)
            {
                return textPhraseOrItis(_value);
            }

            public TextPhraseOrItisCase Set(TextPhraseOrItis value)
            {
                _value = value;
                return this;
            }

            public TextPhraseOrItis Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is TextPhraseOrItisCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<TextPhraseOrItis1Case, TextPhraseOrItis1>))]
        private sealed class TextPhraseOrItis1Case : TextPhraseOrItis2, ICaseValue<TextPhraseOrItis1Case, TextPhraseOrItis1>
        {
            public TextPhraseOrItis1 _value;

            public override T Match<T>(Func<TextPhraseOrItis, T> textPhraseOrItis, Func<TextPhraseOrItis1, T> textPhraseOrItis1)
            {
                return textPhraseOrItis1(_value);
            }

            public TextPhraseOrItis1Case Set(TextPhraseOrItis1 value)
            {
                _value = value;
                return this;
            }

            public TextPhraseOrItis1 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is TextPhraseOrItis1Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}