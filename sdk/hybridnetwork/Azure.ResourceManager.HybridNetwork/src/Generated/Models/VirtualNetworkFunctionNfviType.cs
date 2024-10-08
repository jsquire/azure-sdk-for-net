// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The network function type. </summary>
    internal readonly partial struct VirtualNetworkFunctionNfviType : IEquatable<VirtualNetworkFunctionNfviType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkFunctionNfviType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VirtualNetworkFunctionNfviType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string AzureCoreValue = "AzureCore";
        private const string AzureOperatorNexusValue = "AzureOperatorNexus";

        /// <summary> Unknown. </summary>
        public static VirtualNetworkFunctionNfviType Unknown { get; } = new VirtualNetworkFunctionNfviType(UnknownValue);
        /// <summary> AzureCore. </summary>
        public static VirtualNetworkFunctionNfviType AzureCore { get; } = new VirtualNetworkFunctionNfviType(AzureCoreValue);
        /// <summary> AzureOperatorNexus. </summary>
        public static VirtualNetworkFunctionNfviType AzureOperatorNexus { get; } = new VirtualNetworkFunctionNfviType(AzureOperatorNexusValue);
        /// <summary> Determines if two <see cref="VirtualNetworkFunctionNfviType"/> values are the same. </summary>
        public static bool operator ==(VirtualNetworkFunctionNfviType left, VirtualNetworkFunctionNfviType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualNetworkFunctionNfviType"/> values are not the same. </summary>
        public static bool operator !=(VirtualNetworkFunctionNfviType left, VirtualNetworkFunctionNfviType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VirtualNetworkFunctionNfviType"/>. </summary>
        public static implicit operator VirtualNetworkFunctionNfviType(string value) => new VirtualNetworkFunctionNfviType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualNetworkFunctionNfviType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualNetworkFunctionNfviType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
