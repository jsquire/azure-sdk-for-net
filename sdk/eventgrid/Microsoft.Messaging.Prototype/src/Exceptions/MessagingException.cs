// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;
using System.Text;

namespace Microsoft.Messaging.Prototype.Exceptions
{
    public class MessagingException : Exception
    {
        public bool IsTransient { get; }

        public MessagingFailureReason Reason { get; }

       public string EventHubName { get; }

        public override string Message
        {
            get
            {
                if (string.IsNullOrEmpty(EventHubName))
                {
                    return string.Format(CultureInfo.InvariantCulture, "{0}.  {1}", base.Message, "<< Troubleshooting Guide >>");
                }

                return string.Format(CultureInfo.InvariantCulture, "{0} ({1}).  {2}", base.Message, EventHubName, "<< Troubleshooting Guide >>");
            }
        }

         public MessagingException(bool isTransient,
                                  string eventHubName) : this(isTransient, eventHubName, null, MessagingFailureReason.GeneralError, null)
        {
        }

       public MessagingException(bool isTransient,
                                  string eventHubName,
                                  MessagingFailureReason reason) : this(isTransient, eventHubName, null, reason, null)
        {
        }

        public MessagingException(bool isTransient,
                                  string eventHubName,
                                  string message) : this(isTransient, eventHubName, message, MessagingFailureReason.GeneralError, null)
        {
        }

        public MessagingException(bool isTransient,
                                  string eventHubName,
                                  string message,
                                  MessagingFailureReason reason) : this(isTransient, eventHubName, message, reason, null)
        {
        }

       public MessagingException(bool isTransient,
                                  string eventHubName,
                                  string message,
                                  Exception innerException) : this(isTransient, eventHubName, message, MessagingFailureReason.GeneralError, innerException)
        {
        }

        public MessagingException(bool isTransient,
                                  string eventHubName,
                                  string message,
                                  MessagingFailureReason reason,
                                  Exception innerException) : base(message, innerException)
        {
            IsTransient = isTransient;
            EventHubName = eventHubName;
            Reason = reason;
        }

       public MessagingException(string eventHubName,
                                  string message,
                                  MessagingFailureReason reason) : this(eventHubName, message, reason, null)
        {
        }

        internal MessagingException(string eventHubName,
                                    string message,
                                    MessagingFailureReason reason,
                                    Exception innerException) : this(false, eventHubName, message, reason, innerException)
        {
            IsTransient = reason switch
            {
                MessagingFailureReason.ServiceCommunicationProblem => true,
                MessagingFailureReason.ServiceTimeout => true,
                MessagingFailureReason.ServiceBusy => true,
                _ => false
            };
        }
    }
}
