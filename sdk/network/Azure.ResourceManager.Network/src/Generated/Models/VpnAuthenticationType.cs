// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VPN authentication types enabled for the virtual network gateway. </summary>
    public readonly partial struct VpnAuthenticationType : IEquatable<VpnAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VpnAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VpnAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CertificateValue = "Certificate";
        private const string RadiusValue = "Radius";
        private const string AadValue = "AAD";

        /// <summary> Certificate. </summary>
        public static VpnAuthenticationType Certificate { get; } = new VpnAuthenticationType(CertificateValue);
        /// <summary> Radius. </summary>
        public static VpnAuthenticationType Radius { get; } = new VpnAuthenticationType(RadiusValue);
        /// <summary> AAD. </summary>
        public static VpnAuthenticationType Aad { get; } = new VpnAuthenticationType(AadValue);
        /// <summary> Determines if two <see cref="VpnAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(VpnAuthenticationType left, VpnAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VpnAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(VpnAuthenticationType left, VpnAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VpnAuthenticationType"/>. </summary>
        public static implicit operator VpnAuthenticationType(string value) => new VpnAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VpnAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VpnAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
