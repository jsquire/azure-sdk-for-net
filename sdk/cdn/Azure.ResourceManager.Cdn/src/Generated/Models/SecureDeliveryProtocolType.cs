// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// Defines the TLS extension protocol that is used for secure delivery.
    /// Serialized Name: ProtocolType
    /// </summary>
    public readonly partial struct SecureDeliveryProtocolType : IEquatable<SecureDeliveryProtocolType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecureDeliveryProtocolType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecureDeliveryProtocolType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServerNameIndicationValue = "ServerNameIndication";
        private const string IPBasedValue = "IPBased";

        /// <summary>
        /// ServerNameIndication
        /// Serialized Name: ProtocolType.ServerNameIndication
        /// </summary>
        public static SecureDeliveryProtocolType ServerNameIndication { get; } = new SecureDeliveryProtocolType(ServerNameIndicationValue);
        /// <summary>
        /// IPBased
        /// Serialized Name: ProtocolType.IPBased
        /// </summary>
        public static SecureDeliveryProtocolType IPBased { get; } = new SecureDeliveryProtocolType(IPBasedValue);
        /// <summary> Determines if two <see cref="SecureDeliveryProtocolType"/> values are the same. </summary>
        public static bool operator ==(SecureDeliveryProtocolType left, SecureDeliveryProtocolType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecureDeliveryProtocolType"/> values are not the same. </summary>
        public static bool operator !=(SecureDeliveryProtocolType left, SecureDeliveryProtocolType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SecureDeliveryProtocolType"/>. </summary>
        public static implicit operator SecureDeliveryProtocolType(string value) => new SecureDeliveryProtocolType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecureDeliveryProtocolType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecureDeliveryProtocolType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
