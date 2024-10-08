// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Service-set extensible enum indicating the status of operation. </summary>
    public readonly partial struct PostgreSqlExecutionStatus : IEquatable<PostgreSqlExecutionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlExecutionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlExecutionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RunningValue = "Running";
        private const string CancelledValue = "Cancelled";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";

        /// <summary> Running. </summary>
        public static PostgreSqlExecutionStatus Running { get; } = new PostgreSqlExecutionStatus(RunningValue);
        /// <summary> Cancelled. </summary>
        public static PostgreSqlExecutionStatus Cancelled { get; } = new PostgreSqlExecutionStatus(CancelledValue);
        /// <summary> Failed. </summary>
        public static PostgreSqlExecutionStatus Failed { get; } = new PostgreSqlExecutionStatus(FailedValue);
        /// <summary> Succeeded. </summary>
        public static PostgreSqlExecutionStatus Succeeded { get; } = new PostgreSqlExecutionStatus(SucceededValue);
        /// <summary> Determines if two <see cref="PostgreSqlExecutionStatus"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlExecutionStatus left, PostgreSqlExecutionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlExecutionStatus"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlExecutionStatus left, PostgreSqlExecutionStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PostgreSqlExecutionStatus"/>. </summary>
        public static implicit operator PostgreSqlExecutionStatus(string value) => new PostgreSqlExecutionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlExecutionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlExecutionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
