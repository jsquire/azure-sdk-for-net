// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using System.Net;
using System.Net.Security;
using Azure.Core;

namespace Microsoft.Messaging.Prototype
{
    public class MessagingConnectionOptions
    {
        private TimeSpan _connectionIdleTimeout = TimeSpan.FromMinutes(1);

        public MessagingTransportType TransportType { get; set; } = MessagingTransportType.AmqpTcp;

        public TimeSpan ConnectionIdleTimeout
        {
            get => _connectionIdleTimeout;
            set
            {
                Argument.AssertNotNegative(value, nameof(ConnectionIdleTimeout));
                _connectionIdleTimeout = value;
            }
        }

        public int SendBufferSizeInBytes { get; set; } = -1;

        public int ReceiveBufferSizeInBytes { get; set; } = -1;

        public IWebProxy Proxy { get; set; }

        public Uri CustomEndpointAddress { get; set; }

        public RemoteCertificateValidationCallback CertificateValidationCallback { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => base.Equals(obj);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => base.ToString();
    }
}
