// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The rule type of the governance rule, defines the source of the rule e.g. Integrated. </summary>
    public readonly partial struct GovernanceRuleType : IEquatable<GovernanceRuleType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GovernanceRuleType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GovernanceRuleType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IntegratedValue = "Integrated";
        private const string ServiceNowValue = "ServiceNow";

        /// <summary> The source of the rule type definition is integrated. </summary>
        public static GovernanceRuleType Integrated { get; } = new GovernanceRuleType(IntegratedValue);
        /// <summary> The source of the rule type definition is ServiceNow. </summary>
        public static GovernanceRuleType ServiceNow { get; } = new GovernanceRuleType(ServiceNowValue);
        /// <summary> Determines if two <see cref="GovernanceRuleType"/> values are the same. </summary>
        public static bool operator ==(GovernanceRuleType left, GovernanceRuleType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GovernanceRuleType"/> values are not the same. </summary>
        public static bool operator !=(GovernanceRuleType left, GovernanceRuleType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="GovernanceRuleType"/>. </summary>
        public static implicit operator GovernanceRuleType(string value) => new GovernanceRuleType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GovernanceRuleType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GovernanceRuleType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
