// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.Messaging;

namespace Microsoft.Messaging.Prototype
{
    public class StreamProcessEventArgs : EventArgs
    {
        public string FullyQualifiedNamespace { get; }

        public string Topic { get; }

        public string Subscription { get; }

        public string Identifier { get; }

        public IReadOnlyList<CloudEvent> CloudEvents { get; }

        public CancellationToken CancellationToken { get; }

        public StreamProcessEventArgs(string fullyQualifiedNamespace, string topicName, string subscriptionName, string identifier, IReadOnlyList<CloudEvent> cloudEvents, CancellationToken cancellationToken = default)
        {
        }

        public Task UpdateCheckpointAsync(CloudEvent cloudEvent, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();
    }
}
