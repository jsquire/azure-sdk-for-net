// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Value to use for hierarchy node sorting. When it is set to 'CumulativeInstanceCount', the returned hierarchies are sorted based on the total instances belonging to the hierarchy node and its child hierarchy nodes. When it is set to 'Name', the returned hierarchies are sorted based on the hierarchy name. Optional, default is 'CumulativeInstanceCount'. </summary>
    internal readonly partial struct HierarchiesSortBy : IEquatable<HierarchiesSortBy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HierarchiesSortBy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HierarchiesSortBy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CumulativeInstanceCountValue = "CumulativeInstanceCount";
        private const string NameValue = "Name";

        /// <summary> CumulativeInstanceCount. </summary>
        public static HierarchiesSortBy CumulativeInstanceCount { get; } = new HierarchiesSortBy(CumulativeInstanceCountValue);
        /// <summary> Name. </summary>
        public static HierarchiesSortBy Name { get; } = new HierarchiesSortBy(NameValue);
        /// <summary> Determines if two <see cref="HierarchiesSortBy"/> values are the same. </summary>
        public static bool operator ==(HierarchiesSortBy left, HierarchiesSortBy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HierarchiesSortBy"/> values are not the same. </summary>
        public static bool operator !=(HierarchiesSortBy left, HierarchiesSortBy right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HierarchiesSortBy"/>. </summary>
        public static implicit operator HierarchiesSortBy(string value) => new HierarchiesSortBy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HierarchiesSortBy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HierarchiesSortBy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
