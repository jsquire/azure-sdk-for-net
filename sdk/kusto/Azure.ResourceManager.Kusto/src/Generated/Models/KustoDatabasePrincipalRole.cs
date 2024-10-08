// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Database principal role. </summary>
    public readonly partial struct KustoDatabasePrincipalRole : IEquatable<KustoDatabasePrincipalRole>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KustoDatabasePrincipalRole"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KustoDatabasePrincipalRole(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AdminValue = "Admin";
        private const string IngestorValue = "Ingestor";
        private const string MonitorValue = "Monitor";
        private const string UserValue = "User";
        private const string UnrestrictedViewerValue = "UnrestrictedViewer";
        private const string ViewerValue = "Viewer";

        /// <summary> Admin. </summary>
        public static KustoDatabasePrincipalRole Admin { get; } = new KustoDatabasePrincipalRole(AdminValue);
        /// <summary> Ingestor. </summary>
        public static KustoDatabasePrincipalRole Ingestor { get; } = new KustoDatabasePrincipalRole(IngestorValue);
        /// <summary> Monitor. </summary>
        public static KustoDatabasePrincipalRole Monitor { get; } = new KustoDatabasePrincipalRole(MonitorValue);
        /// <summary> User. </summary>
        public static KustoDatabasePrincipalRole User { get; } = new KustoDatabasePrincipalRole(UserValue);
        /// <summary> UnrestrictedViewer. </summary>
        public static KustoDatabasePrincipalRole UnrestrictedViewer { get; } = new KustoDatabasePrincipalRole(UnrestrictedViewerValue);
        /// <summary> Viewer. </summary>
        public static KustoDatabasePrincipalRole Viewer { get; } = new KustoDatabasePrincipalRole(ViewerValue);
        /// <summary> Determines if two <see cref="KustoDatabasePrincipalRole"/> values are the same. </summary>
        public static bool operator ==(KustoDatabasePrincipalRole left, KustoDatabasePrincipalRole right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KustoDatabasePrincipalRole"/> values are not the same. </summary>
        public static bool operator !=(KustoDatabasePrincipalRole left, KustoDatabasePrincipalRole right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="KustoDatabasePrincipalRole"/>. </summary>
        public static implicit operator KustoDatabasePrincipalRole(string value) => new KustoDatabasePrincipalRole(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KustoDatabasePrincipalRole other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KustoDatabasePrincipalRole other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
