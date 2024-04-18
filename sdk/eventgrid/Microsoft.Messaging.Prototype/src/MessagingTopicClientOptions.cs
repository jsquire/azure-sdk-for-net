// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Azure.Core;

namespace Microsoft.Messaging.Prototype
{
    public class MessagingTopicClientOptions
    {
        private MessagingConnectionOptions _connectionOptions = new MessagingConnectionOptions();

        private MessagingRetryOptions _retryOptions = new MessagingRetryOptions();

        public string Identifier { get; set; }

        public MessagingConnectionOptions ConnectionOptions
        {
            get => _connectionOptions;
            set
            {
                Argument.AssertNotNull(value, nameof(ConnectionOptions));
                _connectionOptions = value;
            }
        }

        public MessagingRetryOptions RetryOptions
        {
            get => _retryOptions;
            set
            {
                Argument.AssertNotNull(value, nameof(RetryOptions));
                _retryOptions = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => base.Equals(obj);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => base.ToString();
    }
}
