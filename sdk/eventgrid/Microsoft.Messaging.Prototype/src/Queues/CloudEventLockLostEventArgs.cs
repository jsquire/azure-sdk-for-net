// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Messaging;

namespace Microsoft.Messaging.Prototype
{
    public class CloudEventLockLostEventArgs
    {
        public CloudEvent CloudEvent { get; }

        public Exception Exception { get; }

        public CloudEventLockLostEventArgs(CloudEvent cloudEvent, Exception exception)
        {
            CloudEvent = cloudEvent;
            Exception = exception;
        }
    }
}
