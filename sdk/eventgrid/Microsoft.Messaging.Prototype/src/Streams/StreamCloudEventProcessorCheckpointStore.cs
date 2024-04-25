// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Messaging.Prototype
{
    public abstract class StreamCloudEventProcessorCheckpointStore
    {
        public string FullyQualifiedNamespace { get; }

        public string Topic { get; }

        public string Subscription { get; }

        protected StreamCloudEventProcessorCheckpointStore(string fullyQualifiedNamespace, string topicName, string subscriptionName)
        {
            FullyQualifiedNamespace = fullyQualifiedNamespace;
            Topic = topicName;
            Subscription = subscriptionName;
        }

        protected abstract Task<StreamCloudEventPosition> GetCheckpointAsync(CancellationToken cancellationToken = default);

        protected abstract Task UpdateCheckpointAsync(StreamCloudEventPosition streamPosition, CancellationToken cancellationToken = default);
    }
}
