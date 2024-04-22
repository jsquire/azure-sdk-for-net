// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Messaging;

namespace Microsoft.Messaging.Prototype
{
    public class MessagingTopicClient : IAsyncDisposable
    {
        public string FullyQualifiedNamespace { get; }

        public string Topic { get; }

        public string Identifier { get; }

        public virtual bool IsDisposed { get; private set; }

        public MessagingTopicClient(string connectionString) : this(connectionString, null, null)
        {
        }

        public MessagingTopicClient(string connectionString,
                                    MessagingTopicClientOptions clientOptions) : this(connectionString, null, clientOptions)
        {
        }

        public MessagingTopicClient(string connectionString,
                                    string topicName) : this(connectionString, topicName, null)
        {
        }

        public MessagingTopicClient(string connectionString,
                                    string topicName,
                                    MessagingTopicClientOptions clientOptions)
        {
        }

         public MessagingTopicClient(string fullyQualifiedNamespace,
                                     string topicName,
                                     AzureNamedKeyCredential credential,
                                     MessagingTopicClientOptions clientOptions = default)
        {
        }

        public MessagingTopicClient(string fullyQualifiedNamespace,
                                    string topicName,
                                    AzureSasCredential credential,
                                    MessagingTopicClientOptions clientOptions = default)
        {
        }

        public MessagingTopicClient(string fullyQualifiedNamespace,
                                    string topicName,
                                    TokenCredential credential,
                                    MessagingTopicClientOptions clientOptions = default)
        {
        }

        protected MessagingTopicClient()
        {
        }

        protected virtual ValueTask DisposeAsyncCore() => default;

        public async ValueTask DisposeAsync()
        {
            await DisposeAsyncCore().ConfigureAwait(false);
            IsDisposed = true;

            GC.SuppressFinalize(this);
        }

        public virtual Task PublishCloudEventAsync(CloudEvent cloudEvent, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        public virtual Task PublishCloudEventsAsync(IEnumerable<CloudEvent> cloudEvents, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        public virtual Task PublishCloudEventsAsync(CloudEventBatch cloudEvents, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        public virtual ValueTask<CloudEventBatch> CreateCloudEventBatchAsync(CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        public virtual ValueTask<CloudEventBatch> CreateCloudEventBatchAsync(CreateCloudEventBatchOptions options, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        //public virtual Queue
    }
}
