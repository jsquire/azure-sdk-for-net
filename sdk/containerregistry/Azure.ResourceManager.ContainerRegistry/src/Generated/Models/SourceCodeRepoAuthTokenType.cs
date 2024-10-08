// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The type of Auth token. </summary>
    public readonly partial struct SourceCodeRepoAuthTokenType : IEquatable<SourceCodeRepoAuthTokenType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SourceCodeRepoAuthTokenType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SourceCodeRepoAuthTokenType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PatValue = "PAT";
        private const string OAuthValue = "OAuth";

        /// <summary> PAT. </summary>
        public static SourceCodeRepoAuthTokenType Pat { get; } = new SourceCodeRepoAuthTokenType(PatValue);
        /// <summary> OAuth. </summary>
        public static SourceCodeRepoAuthTokenType OAuth { get; } = new SourceCodeRepoAuthTokenType(OAuthValue);
        /// <summary> Determines if two <see cref="SourceCodeRepoAuthTokenType"/> values are the same. </summary>
        public static bool operator ==(SourceCodeRepoAuthTokenType left, SourceCodeRepoAuthTokenType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SourceCodeRepoAuthTokenType"/> values are not the same. </summary>
        public static bool operator !=(SourceCodeRepoAuthTokenType left, SourceCodeRepoAuthTokenType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SourceCodeRepoAuthTokenType"/>. </summary>
        public static implicit operator SourceCodeRepoAuthTokenType(string value) => new SourceCodeRepoAuthTokenType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SourceCodeRepoAuthTokenType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SourceCodeRepoAuthTokenType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
