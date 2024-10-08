// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The type of the policy. </summary>
    public readonly partial struct BillingPolicyType : IEquatable<BillingPolicyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BillingPolicyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BillingPolicyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OtherValue = "Other";
        private const string UserControlledValue = "UserControlled";
        private const string SystemControlledValue = "SystemControlled";

        /// <summary> Other. </summary>
        public static BillingPolicyType Other { get; } = new BillingPolicyType(OtherValue);
        /// <summary> UserControlled. </summary>
        public static BillingPolicyType UserControlled { get; } = new BillingPolicyType(UserControlledValue);
        /// <summary> SystemControlled. </summary>
        public static BillingPolicyType SystemControlled { get; } = new BillingPolicyType(SystemControlledValue);
        /// <summary> Determines if two <see cref="BillingPolicyType"/> values are the same. </summary>
        public static bool operator ==(BillingPolicyType left, BillingPolicyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BillingPolicyType"/> values are not the same. </summary>
        public static bool operator !=(BillingPolicyType left, BillingPolicyType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BillingPolicyType"/>. </summary>
        public static implicit operator BillingPolicyType(string value) => new BillingPolicyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BillingPolicyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BillingPolicyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
