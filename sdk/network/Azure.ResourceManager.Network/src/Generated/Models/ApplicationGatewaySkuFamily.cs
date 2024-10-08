// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Family of an application gateway SKU. </summary>
    public readonly partial struct ApplicationGatewaySkuFamily : IEquatable<ApplicationGatewaySkuFamily>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewaySkuFamily"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationGatewaySkuFamily(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Generation1Value = "Generation_1";
        private const string Generation2Value = "Generation_2";

        /// <summary> Generation_1. </summary>
        public static ApplicationGatewaySkuFamily Generation1 { get; } = new ApplicationGatewaySkuFamily(Generation1Value);
        /// <summary> Generation_2. </summary>
        public static ApplicationGatewaySkuFamily Generation2 { get; } = new ApplicationGatewaySkuFamily(Generation2Value);
        /// <summary> Determines if two <see cref="ApplicationGatewaySkuFamily"/> values are the same. </summary>
        public static bool operator ==(ApplicationGatewaySkuFamily left, ApplicationGatewaySkuFamily right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGatewaySkuFamily"/> values are not the same. </summary>
        public static bool operator !=(ApplicationGatewaySkuFamily left, ApplicationGatewaySkuFamily right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ApplicationGatewaySkuFamily"/>. </summary>
        public static implicit operator ApplicationGatewaySkuFamily(string value) => new ApplicationGatewaySkuFamily(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationGatewaySkuFamily other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationGatewaySkuFamily other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
