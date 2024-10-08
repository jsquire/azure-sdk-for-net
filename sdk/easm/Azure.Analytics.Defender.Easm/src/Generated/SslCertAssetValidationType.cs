// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The validation type of a Ssl certificate. </summary>
    public readonly partial struct SslCertAssetValidationType : IEquatable<SslCertAssetValidationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SslCertAssetValidationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SslCertAssetValidationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DomainValidationValue = "domainValidation";
        private const string OrganizationValidationValue = "organizationValidation";
        private const string ExtendedValidationValue = "extendedValidation";

        /// <summary> domainValidation. </summary>
        public static SslCertAssetValidationType DomainValidation { get; } = new SslCertAssetValidationType(DomainValidationValue);
        /// <summary> organizationValidation. </summary>
        public static SslCertAssetValidationType OrganizationValidation { get; } = new SslCertAssetValidationType(OrganizationValidationValue);
        /// <summary> extendedValidation. </summary>
        public static SslCertAssetValidationType ExtendedValidation { get; } = new SslCertAssetValidationType(ExtendedValidationValue);
        /// <summary> Determines if two <see cref="SslCertAssetValidationType"/> values are the same. </summary>
        public static bool operator ==(SslCertAssetValidationType left, SslCertAssetValidationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SslCertAssetValidationType"/> values are not the same. </summary>
        public static bool operator !=(SslCertAssetValidationType left, SslCertAssetValidationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SslCertAssetValidationType"/>. </summary>
        public static implicit operator SslCertAssetValidationType(string value) => new SslCertAssetValidationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SslCertAssetValidationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SslCertAssetValidationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
