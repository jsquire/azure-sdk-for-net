// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Microsoft.Messaging.Prototype
{
    internal class BasicRetryPolicy : MessagingRetryPolicy
    {
        private static int s_randomSeed = Environment.TickCount;
        private static readonly ThreadLocal<Random> RandomNumberGenerator = new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref s_randomSeed)), false);
        private static readonly double MaximumTimeSpanSeconds = TimeSpan.MaxValue.TotalSeconds;

        public MessagingRetryOptions Options { get; }

        public double JitterFactor { get; } = 0.08;

        public int MinimumThrottleSeconds { get; } = 4;

        public int MaximumThrottleSeconds { get; } = 8;

        public BasicRetryPolicy(MessagingRetryOptions retryOptions)
        {
            Argument.AssertNotNull(retryOptions, nameof(retryOptions));
            Options = retryOptions;
        }

        public override TimeSpan CalculateTryTimeout(int attemptCount) => Options.TryTimeout;

        public override TimeSpan? CalculateRetryDelay(Exception lastException,
                                                      int attemptCount)
        {
            if ((Options.MaxRetries <= 0)
                || (Options.Delay == TimeSpan.Zero)
                || (Options.MaxDelay == TimeSpan.Zero)
                || (attemptCount > Options.MaxRetries)
                || (!ShouldRetryException(lastException)))
            {
                return null;
            }

            var baseJitterSeconds = (Options.Delay.TotalSeconds * JitterFactor);

            TimeSpan retryDelay = Options.Mode switch
            {
                RetryMode.Fixed => CalculateFixedDelay(Options.Delay.TotalSeconds, baseJitterSeconds, RandomNumberGenerator.Value),
                RetryMode.Exponential => CalculateExponentialDelay(attemptCount, Options.Delay.TotalSeconds, baseJitterSeconds, RandomNumberGenerator.Value),
                _ => throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "<< Unknown Retry Mode >>", Options.Mode.ToString())),
            };

            // If the exception indicates a service throttle, adjust the delay for an
            // additional throttle factor.

            if (IsThrottleException(lastException))
            {
                retryDelay = retryDelay.Add(TimeSpan.FromSeconds(RandomNumberGenerator.Value.Next(MinimumThrottleSeconds, (MaximumThrottleSeconds + 1))));
            }

            // Adjust the delay, if needed, to keep within the maximum
            // duration.

            if (Options.MaxDelay < retryDelay)
            {
                return Options.MaxDelay;
            }

            return retryDelay;
        }

       private static bool ShouldRetryException(Exception exception)
        {
            if ((exception is TaskCanceledException) || (exception is OperationCanceledException))
            {
                exception = exception?.InnerException;
            }
            else if (exception is AggregateException aggregateEx)
            {
                exception = aggregateEx?.Flatten().InnerException;
            }

            switch (exception)
            {
                case null:
                    return false;

                case MessagingException ex:
                    return ex.IsTransient;

                case TimeoutException _:
                case IOException _:
                case UnauthorizedAccessException _:
                    return true;

                case SocketException ex:
                    return ex.SocketErrorCode != SocketError.HostUnreachable
                        && ex.SocketErrorCode != SocketError.HostNotFound
                        && ex.SocketErrorCode != SocketError.NoRecovery;

                default:
                    return false;
            }
        }

        private static bool IsThrottleException(Exception exception) =>
            exception switch
            {
                MessagingException ex when (ex.Reason == MessagingFailureReason.ServiceBusy) => true,
                _ => false
            };

        private static TimeSpan CalculateExponentialDelay(int attemptCount,
                                                          double baseDelaySeconds,
                                                          double baseJitterSeconds,
                                                          Random random)
        {
            var delay = (Math.Pow(2, attemptCount) * baseDelaySeconds) + (random.NextDouble() * baseJitterSeconds);
            return delay > MaximumTimeSpanSeconds ? TimeSpan.MaxValue : TimeSpan.FromSeconds(delay);
        }

        private static TimeSpan CalculateFixedDelay(double baseDelaySeconds,
                                                    double baseJitterSeconds,
                                                    Random random)
        {
            var delay = baseDelaySeconds + (random.NextDouble() * baseJitterSeconds);
            return delay > MaximumTimeSpanSeconds ? TimeSpan.MaxValue : TimeSpan.FromSeconds(delay);
        }
    }
}
