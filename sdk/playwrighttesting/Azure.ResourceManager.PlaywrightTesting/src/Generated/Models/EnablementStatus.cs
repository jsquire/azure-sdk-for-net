// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PlaywrightTesting.Models
{
    /// <summary> The enablement status of a feature. </summary>
    public readonly partial struct EnablementStatus : IEquatable<EnablementStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EnablementStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnablementStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> The feature is Enabled. </summary>
        public static EnablementStatus Enabled { get; } = new EnablementStatus(EnabledValue);
        /// <summary> The feature is Disabled. </summary>
        public static EnablementStatus Disabled { get; } = new EnablementStatus(DisabledValue);
        /// <summary> Determines if two <see cref="EnablementStatus"/> values are the same. </summary>
        public static bool operator ==(EnablementStatus left, EnablementStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnablementStatus"/> values are not the same. </summary>
        public static bool operator !=(EnablementStatus left, EnablementStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EnablementStatus"/>. </summary>
        public static implicit operator EnablementStatus(string value) => new EnablementStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnablementStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnablementStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
