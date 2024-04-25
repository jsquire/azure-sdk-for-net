// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;

namespace Microsoft.Messaging.Prototype
{
    public struct StreamCloudEventPosition : IEquatable<StreamCloudEventPosition>
    {
        public static StreamCloudEventPosition Earliest { get; }

        public static StreamCloudEventPosition Latest { get; }

        public static StreamCloudEventPosition FromEnqueuedTime(DateTimeOffset enqueuedTime) =>
            throw new NotImplementedException();

        public static StreamCloudEventPosition FromSequenceNumber(long sequenceNumber, bool isInclusive = true) =>
            throw new NotImplementedException();

        public static StreamCloudEventPosition FromSequenceNumber(long sequenceNumber, long? replicationSegment = null, bool isInclusive = true) =>
            throw new NotImplementedException();

        public long? SequenceNumber { get; }

        public long? ReplicationSegment { get; }

        public DateTimeOffset? EnqueuedTime { get; }

        public bool IsInclusive { get; }

        public override string ToString()=>
            throw new NotImplementedException();

        public bool Equals(StreamCloudEventPosition other)=>
            throw new NotImplementedException();

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) =>
            throw new NotImplementedException();

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() =>
            throw new NotImplementedException();

        public static bool operator ==(StreamCloudEventPosition left, StreamCloudEventPosition right)=>
            throw new NotImplementedException();

        public static bool operator !=(StreamCloudEventPosition left, StreamCloudEventPosition right)=>
            throw new NotImplementedException();
    }
}
