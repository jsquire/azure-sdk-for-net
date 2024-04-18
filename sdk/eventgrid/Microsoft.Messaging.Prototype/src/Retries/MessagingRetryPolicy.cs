// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;

namespace Microsoft.Messaging.Prototype
{
    public abstract class MessagingRetryPolicy
    {
        public abstract TimeSpan CalculateTryTimeout(int attemptCount);

        public abstract TimeSpan? CalculateRetryDelay(Exception lastException, int attemptCount);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => base.Equals(obj);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => base.ToString();
    }
}
