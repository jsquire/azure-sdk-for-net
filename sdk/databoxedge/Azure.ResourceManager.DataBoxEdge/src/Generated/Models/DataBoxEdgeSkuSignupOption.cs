// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Sku can be signed up by customer or not. </summary>
    public readonly partial struct DataBoxEdgeSkuSignupOption : IEquatable<DataBoxEdgeSkuSignupOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeSkuSignupOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataBoxEdgeSkuSignupOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string AvailableValue = "Available";

        /// <summary> None. </summary>
        public static DataBoxEdgeSkuSignupOption None { get; } = new DataBoxEdgeSkuSignupOption(NoneValue);
        /// <summary> Available. </summary>
        public static DataBoxEdgeSkuSignupOption Available { get; } = new DataBoxEdgeSkuSignupOption(AvailableValue);
        /// <summary> Determines if two <see cref="DataBoxEdgeSkuSignupOption"/> values are the same. </summary>
        public static bool operator ==(DataBoxEdgeSkuSignupOption left, DataBoxEdgeSkuSignupOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataBoxEdgeSkuSignupOption"/> values are not the same. </summary>
        public static bool operator !=(DataBoxEdgeSkuSignupOption left, DataBoxEdgeSkuSignupOption right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DataBoxEdgeSkuSignupOption"/>. </summary>
        public static implicit operator DataBoxEdgeSkuSignupOption(string value) => new DataBoxEdgeSkuSignupOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataBoxEdgeSkuSignupOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataBoxEdgeSkuSignupOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
