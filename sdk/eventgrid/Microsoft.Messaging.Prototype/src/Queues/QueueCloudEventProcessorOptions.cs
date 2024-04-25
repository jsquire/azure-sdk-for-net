// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;

namespace Microsoft.Messaging.Prototype
{
    public class QueueCloudEventProcessorOptions
    {
        public int PrefetchCount { get; set; }

        public QueueReceiveMode ReceiveMode { get; set; } = QueueReceiveMode.PeekLock;

        public bool AutoAcknowledgeCloudEvents { get; set; } = true;

        public TimeSpan MaxAutoLockRenewalDuration { get; set; } = TimeSpan.FromMinutes(5);

        public int MaxConcurrentCalls { get; set; } = 1;

        public TimeSpan? MaxWaitTime { get; set; }

        public string Identifier { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => base.Equals(obj);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => base.ToString();
    }
}
