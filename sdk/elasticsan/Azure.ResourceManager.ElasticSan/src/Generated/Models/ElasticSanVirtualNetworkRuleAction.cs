// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> The action of virtual network rule. </summary>
    public readonly partial struct ElasticSanVirtualNetworkRuleAction : IEquatable<ElasticSanVirtualNetworkRuleAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ElasticSanVirtualNetworkRuleAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ElasticSanVirtualNetworkRuleAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";

        /// <summary> Allow. </summary>
        public static ElasticSanVirtualNetworkRuleAction Allow { get; } = new ElasticSanVirtualNetworkRuleAction(AllowValue);
        /// <summary> Determines if two <see cref="ElasticSanVirtualNetworkRuleAction"/> values are the same. </summary>
        public static bool operator ==(ElasticSanVirtualNetworkRuleAction left, ElasticSanVirtualNetworkRuleAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ElasticSanVirtualNetworkRuleAction"/> values are not the same. </summary>
        public static bool operator !=(ElasticSanVirtualNetworkRuleAction left, ElasticSanVirtualNetworkRuleAction right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ElasticSanVirtualNetworkRuleAction"/>. </summary>
        public static implicit operator ElasticSanVirtualNetworkRuleAction(string value) => new ElasticSanVirtualNetworkRuleAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ElasticSanVirtualNetworkRuleAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ElasticSanVirtualNetworkRuleAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
