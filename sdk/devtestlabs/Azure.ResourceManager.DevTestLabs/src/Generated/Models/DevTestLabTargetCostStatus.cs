// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Target cost status. </summary>
    public readonly partial struct DevTestLabTargetCostStatus : IEquatable<DevTestLabTargetCostStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevTestLabTargetCostStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevTestLabTargetCostStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static DevTestLabTargetCostStatus Enabled { get; } = new DevTestLabTargetCostStatus(EnabledValue);
        /// <summary> Disabled. </summary>
        public static DevTestLabTargetCostStatus Disabled { get; } = new DevTestLabTargetCostStatus(DisabledValue);
        /// <summary> Determines if two <see cref="DevTestLabTargetCostStatus"/> values are the same. </summary>
        public static bool operator ==(DevTestLabTargetCostStatus left, DevTestLabTargetCostStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevTestLabTargetCostStatus"/> values are not the same. </summary>
        public static bool operator !=(DevTestLabTargetCostStatus left, DevTestLabTargetCostStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DevTestLabTargetCostStatus"/>. </summary>
        public static implicit operator DevTestLabTargetCostStatus(string value) => new DevTestLabTargetCostStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevTestLabTargetCostStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevTestLabTargetCostStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
