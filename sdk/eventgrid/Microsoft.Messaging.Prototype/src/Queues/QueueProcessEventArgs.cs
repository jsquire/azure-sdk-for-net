// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Messaging;

namespace Microsoft.Messaging.Prototype
{
    public class QueueProcessEventArgs : EventArgs
    {
        public event Func<CloudEventLockLostEventArgs, Task> CloudEventLockLostAsync;

        public string FullyQualifiedNamespace { get; }

        public string Topic { get; }

        public string Subscription { get; }

        public string Identifier { get; }

        public CloudEvent CloudEvent { get; }

        public CancellationToken CancellationToken { get; }

        public QueueProcessEventArgs(string fullyQualifiedNamespace, string topicName, string subscriptionName, string identifier, CloudEvent cloudEvent, CancellationToken cancellationToken = default)
        {
        }

        public virtual Task AcceptCloudEventAsync(CloudEvent cloudEvent, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        public virtual Task RejectCloudEventAsync(CloudEvent cloudEvent, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        public virtual Task ReleaseCloudEventAsync(CloudEvent cloudEvent, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        public virtual Task<DateTimeOffset> RenewCloudEventLockAsync(CloudEvent cloudEvent, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        protected virtual Task OnCloudEventLockLockLostAsync(CloudEventLockLostEventArgs args) =>
            CloudEventLockLostAsync(args);
    }
}
