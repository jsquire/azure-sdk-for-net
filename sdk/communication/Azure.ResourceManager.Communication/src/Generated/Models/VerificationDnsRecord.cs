// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> A class that represents a VerificationStatus record. </summary>
    public partial class VerificationDnsRecord
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

        /// <summary> Initializes a new instance of <see cref="VerificationDnsRecord"/>. </summary>
        internal VerificationDnsRecord()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VerificationDnsRecord"/>. </summary>
        /// <param name="dnsRecordType"> Type of the DNS record. Example: TXT. </param>
        /// <param name="name"> Name of the DNS record. </param>
        /// <param name="value"> Value of the DNS record. </param>
        /// <param name="timeToLiveInSeconds"> Represents an expiry time in seconds to represent how long this entry can be cached by the resolver, default = 3600sec. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VerificationDnsRecord(string dnsRecordType, string name, string value, int? timeToLiveInSeconds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DnsRecordType = dnsRecordType;
            Name = name;
            Value = value;
            TimeToLiveInSeconds = timeToLiveInSeconds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of the DNS record. Example: TXT. </summary>
        [WirePath("type")]
        public string DnsRecordType { get; }
        /// <summary> Name of the DNS record. </summary>
        [WirePath("name")]
        public string Name { get; }
        /// <summary> Value of the DNS record. </summary>
        [WirePath("value")]
        public string Value { get; }
        /// <summary> Represents an expiry time in seconds to represent how long this entry can be cached by the resolver, default = 3600sec. </summary>
        [WirePath("ttl")]
        public int? TimeToLiveInSeconds { get; }
    }
}
