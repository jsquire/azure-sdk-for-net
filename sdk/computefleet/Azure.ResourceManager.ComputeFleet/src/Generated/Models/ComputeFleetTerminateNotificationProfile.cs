// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary> Specifies Terminate Scheduled Event related configurations. </summary>
    public partial class ComputeFleetTerminateNotificationProfile
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ComputeFleetTerminateNotificationProfile"/>. </summary>
        public ComputeFleetTerminateNotificationProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ComputeFleetTerminateNotificationProfile"/>. </summary>
        /// <param name="notBeforeTimeout">
        /// Configurable length of time a Virtual Machine being deleted will have to
        /// potentially approve the Terminate Scheduled Event before the event is auto
        /// approved (timed out). The configuration must be specified in ISO 8601 format,
        /// the default value is 5 minutes (PT5M)
        /// </param>
        /// <param name="isEnabled"> Specifies whether the Terminate Scheduled event is enabled or disabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputeFleetTerminateNotificationProfile(string notBeforeTimeout, bool? isEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NotBeforeTimeout = notBeforeTimeout;
            IsEnabled = isEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Configurable length of time a Virtual Machine being deleted will have to
        /// potentially approve the Terminate Scheduled Event before the event is auto
        /// approved (timed out). The configuration must be specified in ISO 8601 format,
        /// the default value is 5 minutes (PT5M)
        /// </summary>
        public string NotBeforeTimeout { get; set; }
        /// <summary> Specifies whether the Terminate Scheduled event is enabled or disabled. </summary>
        public bool? IsEnabled { get; set; }
    }
}
