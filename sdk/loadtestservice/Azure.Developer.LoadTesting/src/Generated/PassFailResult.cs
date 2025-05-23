// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Developer.LoadTesting
{
    /// <summary> Pass/fail criteria result. </summary>
    public readonly partial struct PassFailResult : IEquatable<PassFailResult>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PassFailResult"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PassFailResult(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PassedValue = "passed";
        private const string UndeterminedValue = "undetermined";
        private const string FailedValue = "failed";

        /// <summary> Given pass fail criteria metric has passed. </summary>
        public static PassFailResult Passed { get; } = new PassFailResult(PassedValue);
        /// <summary> Given pass fail criteria metric couldn't determine. </summary>
        public static PassFailResult Undetermined { get; } = new PassFailResult(UndeterminedValue);
        /// <summary> Given pass fail criteria metric has failed. </summary>
        public static PassFailResult Failed { get; } = new PassFailResult(FailedValue);
        /// <summary> Determines if two <see cref="PassFailResult"/> values are the same. </summary>
        public static bool operator ==(PassFailResult left, PassFailResult right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PassFailResult"/> values are not the same. </summary>
        public static bool operator !=(PassFailResult left, PassFailResult right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PassFailResult"/>. </summary>
        public static implicit operator PassFailResult(string value) => new PassFailResult(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PassFailResult other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PassFailResult other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
