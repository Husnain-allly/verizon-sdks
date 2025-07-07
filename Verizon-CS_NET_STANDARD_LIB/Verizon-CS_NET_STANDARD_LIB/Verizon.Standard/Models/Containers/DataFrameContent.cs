// <copyright file="DataFrameContent.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<DataFrameContent>),
        new Type[] {
            typeof(ContentCase),
            typeof(Content1Case),
            typeof(Content2Case),
            typeof(Content3Case),
            typeof(Content4Case)
        },
        true
    )]
    public abstract class DataFrameContent
    {
        /// <summary>
        /// This is Content case.
        /// </summary>
        /// <returns>
        /// The DataFrameContent instance, wrapping the provided Content value.
        /// </returns>
        public static DataFrameContent FromContent(Content content)
        {
            return new ContentCase().Set(content);
        }

        /// <summary>
        /// This is Content1 case.
        /// </summary>
        /// <returns>
        /// The DataFrameContent instance, wrapping the provided Content1 value.
        /// </returns>
        public static DataFrameContent FromContent1(Content1 content1)
        {
            return new Content1Case().Set(content1);
        }

        /// <summary>
        /// This is Content2 case.
        /// </summary>
        /// <returns>
        /// The DataFrameContent instance, wrapping the provided Content2 value.
        /// </returns>
        public static DataFrameContent FromContent2(Content2 content2)
        {
            return new Content2Case().Set(content2);
        }

        /// <summary>
        /// This is Content3 case.
        /// </summary>
        /// <returns>
        /// The DataFrameContent instance, wrapping the provided Content3 value.
        /// </returns>
        public static DataFrameContent FromContent3(Content3 content3)
        {
            return new Content3Case().Set(content3);
        }

        /// <summary>
        /// This is Content4 case.
        /// </summary>
        /// <returns>
        /// The DataFrameContent instance, wrapping the provided Content4 value.
        /// </returns>
        public static DataFrameContent FromContent4(Content4 content4)
        {
            return new Content4Case().Set(content4);
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
            Func<Content, T> content,
            Func<Content1, T> content1,
            Func<Content2, T> content2,
            Func<Content3, T> content3,
            Func<Content4, T> content4);

        [JsonConverter(typeof(UnionTypeCaseConverter<ContentCase, Content>))]
        private sealed class ContentCase : DataFrameContent, ICaseValue<ContentCase, Content>
        {
            public Content _value;

            public override T Match<T>(
                Func<Content, T> content,
                Func<Content1, T> content1,
                Func<Content2, T> content2,
                Func<Content3, T> content3,
                Func<Content4, T> content4)
            {
                return content(_value);
            }

            public ContentCase Set(Content value)
            {
                _value = value;
                return this;
            }

            public Content Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ContentCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<Content1Case, Content1>))]
        private sealed class Content1Case : DataFrameContent, ICaseValue<Content1Case, Content1>
        {
            public Content1 _value;

            public override T Match<T>(
                Func<Content, T> content,
                Func<Content1, T> content1,
                Func<Content2, T> content2,
                Func<Content3, T> content3,
                Func<Content4, T> content4)
            {
                return content1(_value);
            }

            public Content1Case Set(Content1 value)
            {
                _value = value;
                return this;
            }

            public Content1 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is Content1Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<Content2Case, Content2>))]
        private sealed class Content2Case : DataFrameContent, ICaseValue<Content2Case, Content2>
        {
            public Content2 _value;

            public override T Match<T>(
                Func<Content, T> content,
                Func<Content1, T> content1,
                Func<Content2, T> content2,
                Func<Content3, T> content3,
                Func<Content4, T> content4)
            {
                return content2(_value);
            }

            public Content2Case Set(Content2 value)
            {
                _value = value;
                return this;
            }

            public Content2 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is Content2Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<Content3Case, Content3>))]
        private sealed class Content3Case : DataFrameContent, ICaseValue<Content3Case, Content3>
        {
            public Content3 _value;

            public override T Match<T>(
                Func<Content, T> content,
                Func<Content1, T> content1,
                Func<Content2, T> content2,
                Func<Content3, T> content3,
                Func<Content4, T> content4)
            {
                return content3(_value);
            }

            public Content3Case Set(Content3 value)
            {
                _value = value;
                return this;
            }

            public Content3 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is Content3Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<Content4Case, Content4>))]
        private sealed class Content4Case : DataFrameContent, ICaseValue<Content4Case, Content4>
        {
            public Content4 _value;

            public override T Match<T>(
                Func<Content, T> content,
                Func<Content1, T> content1,
                Func<Content2, T> content2,
                Func<Content3, T> content3,
                Func<Content4, T> content4)
            {
                return content4(_value);
            }

            public Content4Case Set(Content4 value)
            {
                _value = value;
                return this;
            }

            public Content4 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is Content4Case other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}