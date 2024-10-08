// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.TrustedSigning.Models
{
    /// <summary> Name of the sku. </summary>
    public readonly partial struct TrustedSigningSkuName : IEquatable<TrustedSigningSkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TrustedSigningSkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TrustedSigningSkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string PremiumValue = "Premium";

        /// <summary> Basic sku. </summary>
        public static TrustedSigningSkuName Basic { get; } = new TrustedSigningSkuName(BasicValue);
        /// <summary> Premium sku. </summary>
        public static TrustedSigningSkuName Premium { get; } = new TrustedSigningSkuName(PremiumValue);
        /// <summary> Determines if two <see cref="TrustedSigningSkuName"/> values are the same. </summary>
        public static bool operator ==(TrustedSigningSkuName left, TrustedSigningSkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TrustedSigningSkuName"/> values are not the same. </summary>
        public static bool operator !=(TrustedSigningSkuName left, TrustedSigningSkuName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TrustedSigningSkuName"/>. </summary>
        public static implicit operator TrustedSigningSkuName(string value) => new TrustedSigningSkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TrustedSigningSkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TrustedSigningSkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
