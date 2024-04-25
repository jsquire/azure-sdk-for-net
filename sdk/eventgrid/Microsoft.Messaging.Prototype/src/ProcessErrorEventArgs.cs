// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;

namespace Microsoft.Messaging.Prototype
{
    public class ProcessErrorEventArgs
    {
        public string FullyQualifiedNamespace { get; }

        public string Topic { get; }

        public virtual string Subscription { get; }

        public string Identifier { get; }

        public string ActiveOperation { get; }

        public Exception Exception { get; }

        public CancellationToken CancellationToken { get; }

        public ProcessErrorEventArgs(string fullyQualifiedNamespaceName, string topicName, string subscriptionName, string identifier, string operation, Exception exception, CancellationToken cancellationToken = default)
        {
        }
    }
}
