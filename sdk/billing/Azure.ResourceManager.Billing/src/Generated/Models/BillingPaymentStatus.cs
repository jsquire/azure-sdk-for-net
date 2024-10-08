// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Describes whether the payment is completed, failed, pending, cancelled or scheduled in the future. </summary>
    public readonly partial struct BillingPaymentStatus : IEquatable<BillingPaymentStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BillingPaymentStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BillingPaymentStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string ScheduledValue = "Scheduled";
        private const string CancelledValue = "Cancelled";
        private const string CompletedValue = "Completed";
        private const string PendingValue = "Pending";

        /// <summary> Succeeded. </summary>
        public static BillingPaymentStatus Succeeded { get; } = new BillingPaymentStatus(SucceededValue);
        /// <summary> Failed. </summary>
        public static BillingPaymentStatus Failed { get; } = new BillingPaymentStatus(FailedValue);
        /// <summary> Scheduled. </summary>
        public static BillingPaymentStatus Scheduled { get; } = new BillingPaymentStatus(ScheduledValue);
        /// <summary> Cancelled. </summary>
        public static BillingPaymentStatus Cancelled { get; } = new BillingPaymentStatus(CancelledValue);
        /// <summary> Completed. </summary>
        public static BillingPaymentStatus Completed { get; } = new BillingPaymentStatus(CompletedValue);
        /// <summary> Pending. </summary>
        public static BillingPaymentStatus Pending { get; } = new BillingPaymentStatus(PendingValue);
        /// <summary> Determines if two <see cref="BillingPaymentStatus"/> values are the same. </summary>
        public static bool operator ==(BillingPaymentStatus left, BillingPaymentStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BillingPaymentStatus"/> values are not the same. </summary>
        public static bool operator !=(BillingPaymentStatus left, BillingPaymentStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BillingPaymentStatus"/>. </summary>
        public static implicit operator BillingPaymentStatus(string value) => new BillingPaymentStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BillingPaymentStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BillingPaymentStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
