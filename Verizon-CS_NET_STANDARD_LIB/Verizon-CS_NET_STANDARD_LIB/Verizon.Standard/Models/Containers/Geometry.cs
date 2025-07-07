// <copyright file="Geometry.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<Geometry>),
        new Type[] {
            typeof(LineStringCase),
            typeof(PolygonCase),
            typeof(MultiLineStringCase),
            typeof(MultiPolygonCase)
        },
        new string[] {
            "LineString",
            "Polygon",
            "MultiLineString",
            "MultiPolygon"
        },
        "type",
        true
    )]
    public abstract class Geometry
    {
        /// <summary>
        /// This is LineString case.
        /// </summary>
        /// <returns>
        /// The Geometry instance, wrapping the provided LineString value.
        /// </returns>
        public static Geometry FromLineString(LineString lineString)
        {
            return new LineStringCase().Set(lineString);
        }

        /// <summary>
        /// This is Polygon case.
        /// </summary>
        /// <returns>
        /// The Geometry instance, wrapping the provided Polygon value.
        /// </returns>
        public static Geometry FromPolygon(Polygon polygon)
        {
            return new PolygonCase().Set(polygon);
        }

        /// <summary>
        /// This is MultiLineString case.
        /// </summary>
        /// <returns>
        /// The Geometry instance, wrapping the provided MultiLineString value.
        /// </returns>
        public static Geometry FromMultiLineString(MultiLineString multiLineString)
        {
            return new MultiLineStringCase().Set(multiLineString);
        }

        /// <summary>
        /// This is MultiPolygon case.
        /// </summary>
        /// <returns>
        /// The Geometry instance, wrapping the provided MultiPolygon value.
        /// </returns>
        public static Geometry FromMultiPolygon(MultiPolygon multiPolygon)
        {
            return new MultiPolygonCase().Set(multiPolygon);
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
            Func<LineString, T> lineString,
            Func<Polygon, T> polygon,
            Func<MultiLineString, T> multiLineString,
            Func<MultiPolygon, T> multiPolygon);

        [JsonConverter(typeof(UnionTypeCaseConverter<LineStringCase, LineString>))]
        private sealed class LineStringCase : Geometry, ICaseValue<LineStringCase, LineString>
        {
            public LineString _value;

            public override T Match<T>(
                Func<LineString, T> lineString,
                Func<Polygon, T> polygon,
                Func<MultiLineString, T> multiLineString,
                Func<MultiPolygon, T> multiPolygon)
            {
                return lineString(_value);
            }

            public LineStringCase Set(LineString value)
            {
                _value = value;
                return this;
            }

            public LineString Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is LineStringCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PolygonCase, Polygon>))]
        private sealed class PolygonCase : Geometry, ICaseValue<PolygonCase, Polygon>
        {
            public Polygon _value;

            public override T Match<T>(
                Func<LineString, T> lineString,
                Func<Polygon, T> polygon,
                Func<MultiLineString, T> multiLineString,
                Func<MultiPolygon, T> multiPolygon)
            {
                return polygon(_value);
            }

            public PolygonCase Set(Polygon value)
            {
                _value = value;
                return this;
            }

            public Polygon Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PolygonCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<MultiLineStringCase, MultiLineString>))]
        private sealed class MultiLineStringCase : Geometry, ICaseValue<MultiLineStringCase, MultiLineString>
        {
            public MultiLineString _value;

            public override T Match<T>(
                Func<LineString, T> lineString,
                Func<Polygon, T> polygon,
                Func<MultiLineString, T> multiLineString,
                Func<MultiPolygon, T> multiPolygon)
            {
                return multiLineString(_value);
            }

            public MultiLineStringCase Set(MultiLineString value)
            {
                _value = value;
                return this;
            }

            public MultiLineString Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is MultiLineStringCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<MultiPolygonCase, MultiPolygon>))]
        private sealed class MultiPolygonCase : Geometry, ICaseValue<MultiPolygonCase, MultiPolygon>
        {
            public MultiPolygon _value;

            public override T Match<T>(
                Func<LineString, T> lineString,
                Func<Polygon, T> polygon,
                Func<MultiLineString, T> multiLineString,
                Func<MultiPolygon, T> multiPolygon)
            {
                return multiPolygon(_value);
            }

            public MultiPolygonCase Set(MultiPolygon value)
            {
                _value = value;
                return this;
            }

            public MultiPolygon Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is MultiPolygonCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}