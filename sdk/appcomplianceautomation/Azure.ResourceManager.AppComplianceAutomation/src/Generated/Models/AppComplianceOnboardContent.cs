// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> Parameters for onboard operation. </summary>
    public partial class AppComplianceOnboardContent
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

        /// <summary> Initializes a new instance of <see cref="AppComplianceOnboardContent"/>. </summary>
        /// <param name="subscriptionIds"> List of subscription ids to be onboarded. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionIds"/> is null. </exception>
        public AppComplianceOnboardContent(IEnumerable<string> subscriptionIds)
        {
            Argument.AssertNotNull(subscriptionIds, nameof(subscriptionIds));

            SubscriptionIds = subscriptionIds.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AppComplianceOnboardContent"/>. </summary>
        /// <param name="subscriptionIds"> List of subscription ids to be onboarded. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppComplianceOnboardContent(IList<string> subscriptionIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SubscriptionIds = subscriptionIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AppComplianceOnboardContent"/> for deserialization. </summary>
        internal AppComplianceOnboardContent()
        {
        }

        /// <summary> List of subscription ids to be onboarded. </summary>
        public IList<string> SubscriptionIds { get; }
    }
}
