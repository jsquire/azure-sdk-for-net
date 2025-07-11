// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Fault simulation status. </summary>
    public readonly partial struct FaultSimulationStatus : IEquatable<FaultSimulationStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FaultSimulationStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FaultSimulationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StartingValue = "Starting";
        private const string ActiveValue = "Active";
        private const string StoppingValue = "Stopping";
        private const string DoneValue = "Done";
        private const string StartFailedValue = "StartFailed";
        private const string StopFailedValue = "StopFailed";

        /// <summary> Indicates the fault simulation is starting. The simulation will have this status while the start operation is in progress. </summary>
        public static FaultSimulationStatus Starting { get; } = new FaultSimulationStatus(StartingValue);
        /// <summary> Indicates the fault simulation is active. The simulation will have this status after the start operation has completed successfully. </summary>
        public static FaultSimulationStatus Active { get; } = new FaultSimulationStatus(ActiveValue);
        /// <summary> Indicates the fault simulation is stopping. The simulation will have this status while the stop operation is in progress. </summary>
        public static FaultSimulationStatus Stopping { get; } = new FaultSimulationStatus(StoppingValue);
        /// <summary> Indicates the fault simulation is done. The simulation will have this status after the stop operation has completed successfully. </summary>
        public static FaultSimulationStatus Done { get; } = new FaultSimulationStatus(DoneValue);
        /// <summary> Indicates the fault simulation has failed on start. The simulation will have this status after the start operation fails. </summary>
        public static FaultSimulationStatus StartFailed { get; } = new FaultSimulationStatus(StartFailedValue);
        /// <summary> Indicates the fault simulation has failed on stop. The simulation will have this status after the stop operation fails. </summary>
        public static FaultSimulationStatus StopFailed { get; } = new FaultSimulationStatus(StopFailedValue);
        /// <summary> Determines if two <see cref="FaultSimulationStatus"/> values are the same. </summary>
        public static bool operator ==(FaultSimulationStatus left, FaultSimulationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FaultSimulationStatus"/> values are not the same. </summary>
        public static bool operator !=(FaultSimulationStatus left, FaultSimulationStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="FaultSimulationStatus"/>. </summary>
        public static implicit operator FaultSimulationStatus(string value) => new FaultSimulationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FaultSimulationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FaultSimulationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
