// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Specifies the OS SKU used by the agent pool. The default is CBLMariner if OSType is Linux. The default is Windows2019 when OSType is Windows. </summary>
    public readonly partial struct HybridContainerServiceOSSku : IEquatable<HybridContainerServiceOSSku>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HybridContainerServiceOSSku"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HybridContainerServiceOSSku(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CBLMarinerValue = "CBLMariner";
        private const string Windows2019Value = "Windows2019";
        private const string Windows2022Value = "Windows2022";

        /// <summary> Use Mariner as the OS for node images. </summary>
        public static HybridContainerServiceOSSku CBLMariner { get; } = new HybridContainerServiceOSSku(CBLMarinerValue);
        /// <summary> Use Windows2019 as the OS for node images. </summary>
        public static HybridContainerServiceOSSku Windows2019 { get; } = new HybridContainerServiceOSSku(Windows2019Value);
        /// <summary> Use Windows2022 as the OS for node images. </summary>
        public static HybridContainerServiceOSSku Windows2022 { get; } = new HybridContainerServiceOSSku(Windows2022Value);
        /// <summary> Determines if two <see cref="HybridContainerServiceOSSku"/> values are the same. </summary>
        public static bool operator ==(HybridContainerServiceOSSku left, HybridContainerServiceOSSku right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HybridContainerServiceOSSku"/> values are not the same. </summary>
        public static bool operator !=(HybridContainerServiceOSSku left, HybridContainerServiceOSSku right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HybridContainerServiceOSSku"/>. </summary>
        public static implicit operator HybridContainerServiceOSSku(string value) => new HybridContainerServiceOSSku(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HybridContainerServiceOSSku other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HybridContainerServiceOSSku other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
