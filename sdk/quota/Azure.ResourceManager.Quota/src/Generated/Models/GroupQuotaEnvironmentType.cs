// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> Environment name. </summary>
    public readonly partial struct GroupQuotaEnvironmentType : IEquatable<GroupQuotaEnvironmentType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GroupQuotaEnvironmentType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GroupQuotaEnvironmentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NonProductionValue = "NonProduction";
        private const string ProductionValue = "Production";

        /// <summary> NonProduction. </summary>
        public static GroupQuotaEnvironmentType NonProduction { get; } = new GroupQuotaEnvironmentType(NonProductionValue);
        /// <summary> Production. </summary>
        public static GroupQuotaEnvironmentType Production { get; } = new GroupQuotaEnvironmentType(ProductionValue);
        /// <summary> Determines if two <see cref="GroupQuotaEnvironmentType"/> values are the same. </summary>
        public static bool operator ==(GroupQuotaEnvironmentType left, GroupQuotaEnvironmentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GroupQuotaEnvironmentType"/> values are not the same. </summary>
        public static bool operator !=(GroupQuotaEnvironmentType left, GroupQuotaEnvironmentType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="GroupQuotaEnvironmentType"/>. </summary>
        public static implicit operator GroupQuotaEnvironmentType(string value) => new GroupQuotaEnvironmentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GroupQuotaEnvironmentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GroupQuotaEnvironmentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
