// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Microsoft.Messaging.Prototype
{
    public class MessagingRetryOptions
    {
        private int _maximumRetries = 3;
        private TimeSpan _delay = TimeSpan.FromSeconds(0.8);
        private TimeSpan _maximumDelay = TimeSpan.FromMinutes(1);
        private TimeSpan _tryTimeout = TimeSpan.FromMinutes(1);

        public RetryMode Mode { get; set; } = RetryMode.Exponential;

        public int MaxRetries
        {
            get => _maximumRetries;

            set
            {
                Argument.AssertInRange(value, 0, 100, nameof(MaxRetries));
                _maximumRetries = value;
            }
        }

         public TimeSpan Delay
        {
            get => _delay;

            set
            {
                Argument.AssertInRange(value, TimeSpan.FromMilliseconds(1), TimeSpan.FromMinutes(5), nameof(Delay));
                _delay = value;
            }
        }

        public TimeSpan MaxDelay
        {
            get => _maximumDelay;

            set
            {
                Argument.AssertNotNegative(value, nameof(MaxDelay));
                _maximumDelay = value;
            }
        }

        public TimeSpan TryTimeout
        {
            get => _tryTimeout;

            set
            {
                Argument.AssertInRange(value, TimeSpan.Zero, TimeSpan.FromHours(1), nameof(TryTimeout));
                _tryTimeout = value;
            }
        }

        public MessagingRetryPolicy CustomRetryPolicy { get; set; }
    }
}
