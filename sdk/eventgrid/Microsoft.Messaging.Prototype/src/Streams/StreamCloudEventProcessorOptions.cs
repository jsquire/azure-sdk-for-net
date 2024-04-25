// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;

namespace Microsoft.Messaging.Prototype
{
    public class StreamCloudEventProcessorOptions
    {
        public int PrefetchCount { get; set; }

        public int MaxConcurrentCalls { get; set; } = 1;

        public TimeSpan? MaxWaitTime { get; set; }

        public string Identifier { get; set; }

        public StreamCloudEventPosition DefaultStartingPosition { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => base.Equals(obj);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => base.ToString();
    }
}
