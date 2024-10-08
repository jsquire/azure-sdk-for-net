// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> The provisioning state. </summary>
    public readonly partial struct HealthcareApisProvisioningState : IEquatable<HealthcareApisProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HealthcareApisProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HealthcareApisProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string CreatingValue = "Creating";
        private const string AcceptedValue = "Accepted";
        private const string VerifyingValue = "Verifying";
        private const string UpdatingValue = "Updating";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string DeprovisionedValue = "Deprovisioned";
        private const string MovingValue = "Moving";
        private const string SuspendedValue = "Suspended";
        private const string WarnedValue = "Warned";
        private const string SystemMaintenanceValue = "SystemMaintenance";

        /// <summary> Deleting. </summary>
        public static HealthcareApisProvisioningState Deleting { get; } = new HealthcareApisProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static HealthcareApisProvisioningState Succeeded { get; } = new HealthcareApisProvisioningState(SucceededValue);
        /// <summary> Creating. </summary>
        public static HealthcareApisProvisioningState Creating { get; } = new HealthcareApisProvisioningState(CreatingValue);
        /// <summary> Accepted. </summary>
        public static HealthcareApisProvisioningState Accepted { get; } = new HealthcareApisProvisioningState(AcceptedValue);
        /// <summary> Verifying. </summary>
        public static HealthcareApisProvisioningState Verifying { get; } = new HealthcareApisProvisioningState(VerifyingValue);
        /// <summary> Updating. </summary>
        public static HealthcareApisProvisioningState Updating { get; } = new HealthcareApisProvisioningState(UpdatingValue);
        /// <summary> Failed. </summary>
        public static HealthcareApisProvisioningState Failed { get; } = new HealthcareApisProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static HealthcareApisProvisioningState Canceled { get; } = new HealthcareApisProvisioningState(CanceledValue);
        /// <summary> Deprovisioned. </summary>
        public static HealthcareApisProvisioningState Deprovisioned { get; } = new HealthcareApisProvisioningState(DeprovisionedValue);
        /// <summary> Moving. </summary>
        public static HealthcareApisProvisioningState Moving { get; } = new HealthcareApisProvisioningState(MovingValue);
        /// <summary> Suspended. </summary>
        public static HealthcareApisProvisioningState Suspended { get; } = new HealthcareApisProvisioningState(SuspendedValue);
        /// <summary> Warned. </summary>
        public static HealthcareApisProvisioningState Warned { get; } = new HealthcareApisProvisioningState(WarnedValue);
        /// <summary> SystemMaintenance. </summary>
        public static HealthcareApisProvisioningState SystemMaintenance { get; } = new HealthcareApisProvisioningState(SystemMaintenanceValue);
        /// <summary> Determines if two <see cref="HealthcareApisProvisioningState"/> values are the same. </summary>
        public static bool operator ==(HealthcareApisProvisioningState left, HealthcareApisProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HealthcareApisProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(HealthcareApisProvisioningState left, HealthcareApisProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HealthcareApisProvisioningState"/>. </summary>
        public static implicit operator HealthcareApisProvisioningState(string value) => new HealthcareApisProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HealthcareApisProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HealthcareApisProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
