// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Messaging.Prototype
{
    public class QueueCloudEventProcessor
    {
        public event Func<QueueProcessEventArgs, Task> ProcessCloudEventAsync;
        public event Func<ProcessErrorEventArgs, Task> ProcessErrorAsync;

        public virtual string FullyQualifiedNamespace { get; }

        public virtual string Topic { get; }

        public virtual string Subscription { get; }

        public virtual string Identifier { get; }

        public virtual int MaxConcurrentCalls { get; }

        public virtual TimeSpan? MaxWaitTime { get; }

        public virtual bool AutoAcknowledgeCloudEvents { get; }

        public virtual TimeSpan MaxAutoLockRenewalDuration { get; }

        public virtual CloudEventProcessorStatus Status { get; }

        public virtual bool IsDisposed { get; private set; }

        protected QueueCloudEventProcessor(string fullyQualifiedNamespace, string topicName, string subscriptionName, string identifier, QueueCloudEventProcessorOptions options) { }

        protected QueueCloudEventProcessor() { }

        protected virtual ValueTask DisposeAsyncCore() => default;

        protected virtual Task OnProcessCloudEventAsync(QueueProcessEventArgs args) =>
            ProcessCloudEventAsync(args);

        protected virtual Task OnProcessErrorAsync(ProcessErrorEventArgs args) =>
            ProcessErrorAsync(args);

        public virtual Task StartProcessingAsync(CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        public virtual Task StopProcessingAsync(CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        public async ValueTask DisposeAsync()
        {
            await DisposeAsyncCore().ConfigureAwait(false);
            IsDisposed = true;

            GC.SuppressFinalize(this);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => base.Equals(obj);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => base.ToString();
    }
}
