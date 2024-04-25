// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Azure.Messaging;

namespace Microsoft.Messaging.Prototype
{
    public class StreamCloudEventReceiver : IAsyncDisposable
    {
        public virtual string FullyQualifiedNamespace { get; }

        public virtual string Topic { get; }

        public virtual string Subscription { get; }

        public virtual string Identifier { get; }

        public virtual StreamCloudEventPosition StartingPosition { get; }

        public virtual bool IsDisposed { get; private set; }

        protected virtual ValueTask DisposeAsyncCore() => default;

        public async ValueTask DisposeAsync()
        {
            await DisposeAsyncCore().ConfigureAwait(false);
            IsDisposed = true;

            GC.SuppressFinalize(this);
        }

        protected StreamCloudEventReceiver(StreamCloudEventPosition streamPosition, string fullyQualifiedNamespace, string topicName, string subscriptionName, string identifier, QueueCloudEventReceiverOptions options) { }

        protected StreamCloudEventReceiver() { }

        public virtual Task<IReadOnlyList<CloudEvent>> ReceiveCloudEventsAsync(int maxEvents, TimeSpan? maxWaitTime = default, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => base.Equals(obj);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => base.ToString();
    }
}
