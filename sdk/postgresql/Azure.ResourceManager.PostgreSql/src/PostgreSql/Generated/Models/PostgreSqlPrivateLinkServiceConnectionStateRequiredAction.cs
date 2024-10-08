// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> The actions required for private link service connection. </summary>
    public readonly partial struct PostgreSqlPrivateLinkServiceConnectionStateRequiredAction : IEquatable<PostgreSqlPrivateLinkServiceConnectionStateRequiredAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlPrivateLinkServiceConnectionStateRequiredAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlPrivateLinkServiceConnectionStateRequiredAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";

        /// <summary> None. </summary>
        public static PostgreSqlPrivateLinkServiceConnectionStateRequiredAction None { get; } = new PostgreSqlPrivateLinkServiceConnectionStateRequiredAction(NoneValue);
        /// <summary> Determines if two <see cref="PostgreSqlPrivateLinkServiceConnectionStateRequiredAction"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlPrivateLinkServiceConnectionStateRequiredAction left, PostgreSqlPrivateLinkServiceConnectionStateRequiredAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlPrivateLinkServiceConnectionStateRequiredAction"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlPrivateLinkServiceConnectionStateRequiredAction left, PostgreSqlPrivateLinkServiceConnectionStateRequiredAction right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PostgreSqlPrivateLinkServiceConnectionStateRequiredAction"/>. </summary>
        public static implicit operator PostgreSqlPrivateLinkServiceConnectionStateRequiredAction(string value) => new PostgreSqlPrivateLinkServiceConnectionStateRequiredAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlPrivateLinkServiceConnectionStateRequiredAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlPrivateLinkServiceConnectionStateRequiredAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
