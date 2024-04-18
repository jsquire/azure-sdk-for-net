// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Microsoft.Messaging.Prototype;

namespace Azure.Core
{
    internal static partial class Argument
    {
        public static void AssertNotEmptyOrWhiteSpace(string argumentValue, string argumentName)
        {
            if (argumentValue is null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(argumentValue))
            {
                throw new ArgumentException($"The argument '{argumentName}' may not be empty or white-space, though it may be null.", argumentName);
            }
        }

        public static void AssertNotTooLong(string argumentValue, int maximumLength, string argumentName)
        {
            if (argumentValue != null && argumentValue.Length > maximumLength)
            {
                throw new ArgumentOutOfRangeException(argumentName, $"The argument '{argumentName}' cannot exceed {maximumLength} characters.");
            }
        }

        public static void AssertNotNegative(TimeSpan argumentValue, string argumentName)
        {
            if (argumentValue < TimeSpan.Zero)
            {
                throw new ArgumentOutOfRangeException(argumentName, $"Argument {argumentName} must be a non-negative timespan value. The provided value was {argumentValue}.");
            }
        }

       public static void AssertAtLeast(long argumentValue, long minimumValue, string argumentName)
        {
            if (argumentValue < minimumValue)
            {
                throw new ArgumentOutOfRangeException(argumentName, $"The value supplied must be greater than or equal to {minimumValue}.");
            }
        }

        public static void AssertAtLeast(int argumentValue, int minimumValue, string argumentName)
        {
            if (argumentValue < minimumValue)
            {
                throw new ArgumentOutOfRangeException(argumentName, $"The value supplied must be greater than or equal to {minimumValue}.");
            }
        }

       public static void AssertNotDisposed(bool wasDisposed, string targetName)
        {
            if (wasDisposed)
            {
                throw new ObjectDisposedException(targetName, "OMG, this was disposed!");
            }
        }

        public static void AssertNotClosed(bool wasClosed, string targetName)
        {
            if (wasClosed)
            {
                throw new MessagingException(targetName, "<< CLOSED >>", MessagingFailureReason.ClientClosed);
            }
        }

        public static void AssertWellFormedEventHubsNamespace(string argumentValue, string argumentName)
        {
            argumentValue ??= string.Empty;

            if (Uri.CheckHostName(argumentValue) == UriHostNameType.Unknown)
            {
                throw new ArgumentException($"<< Invalid Namespace: { argumentValue } >>", argumentName);
            }
        }
    }
}
