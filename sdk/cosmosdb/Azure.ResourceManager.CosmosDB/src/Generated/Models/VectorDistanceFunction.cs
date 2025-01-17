// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The distance function to use for distance calculation in between vectors. </summary>
    public readonly partial struct VectorDistanceFunction : IEquatable<VectorDistanceFunction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VectorDistanceFunction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VectorDistanceFunction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EuclideanValue = "euclidean";
        private const string CosineValue = "cosine";
        private const string DotproductValue = "dotproduct";

        /// <summary> euclidean. </summary>
        public static VectorDistanceFunction Euclidean { get; } = new VectorDistanceFunction(EuclideanValue);
        /// <summary> cosine. </summary>
        public static VectorDistanceFunction Cosine { get; } = new VectorDistanceFunction(CosineValue);
        /// <summary> dotproduct. </summary>
        public static VectorDistanceFunction Dotproduct { get; } = new VectorDistanceFunction(DotproductValue);
        /// <summary> Determines if two <see cref="VectorDistanceFunction"/> values are the same. </summary>
        public static bool operator ==(VectorDistanceFunction left, VectorDistanceFunction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VectorDistanceFunction"/> values are not the same. </summary>
        public static bool operator !=(VectorDistanceFunction left, VectorDistanceFunction right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VectorDistanceFunction"/>. </summary>
        public static implicit operator VectorDistanceFunction(string value) => new VectorDistanceFunction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VectorDistanceFunction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VectorDistanceFunction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
