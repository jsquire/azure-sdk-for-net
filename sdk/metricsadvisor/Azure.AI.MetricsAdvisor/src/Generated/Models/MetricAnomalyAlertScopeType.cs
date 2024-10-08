// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> Anomaly scope. </summary>
    public readonly partial struct MetricAnomalyAlertScopeType : IEquatable<MetricAnomalyAlertScopeType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MetricAnomalyAlertScopeType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MetricAnomalyAlertScopeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WholeSeriesValue = "All";
        private const string SeriesGroupValue = "Dimension";
        private const string TopNValue = "TopN";
        /// <summary> Determines if two <see cref="MetricAnomalyAlertScopeType"/> values are the same. </summary>
        public static bool operator ==(MetricAnomalyAlertScopeType left, MetricAnomalyAlertScopeType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MetricAnomalyAlertScopeType"/> values are not the same. </summary>
        public static bool operator !=(MetricAnomalyAlertScopeType left, MetricAnomalyAlertScopeType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MetricAnomalyAlertScopeType"/>. </summary>
        public static implicit operator MetricAnomalyAlertScopeType(string value) => new MetricAnomalyAlertScopeType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MetricAnomalyAlertScopeType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MetricAnomalyAlertScopeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
