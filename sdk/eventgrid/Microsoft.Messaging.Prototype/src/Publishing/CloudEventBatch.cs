// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Messaging;

namespace Microsoft.Messaging.Prototype
{
    public sealed class CloudEventBatch : IDisposable
    {
        public long MaximumSizeInBytes { get; }

        public long SizeInBytes { get; }

        public int Count { get; }

        public bool TryAdd(CloudEvent cloudEvent) =>
            throw new NotImplementedException();

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
        }
    }
}
