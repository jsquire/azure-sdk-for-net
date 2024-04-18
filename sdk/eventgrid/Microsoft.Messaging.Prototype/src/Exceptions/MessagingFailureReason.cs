// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Messaging.Prototype.Exceptions
{
    public enum MessagingFailureReason
    {
        GeneralError,
        ClientClosed,
        MessagingEntityNotFound,
        MessagingEntityDisabled,
        MessageLockLost,
        MessageNotFound,
        MessageSizeExceeded,
        QuotaExceeded,
        ReaderDisconnected,
        ServiceBusy,
        ServiceTimeout,
        ServiceCommunicationProblem
    }
}
