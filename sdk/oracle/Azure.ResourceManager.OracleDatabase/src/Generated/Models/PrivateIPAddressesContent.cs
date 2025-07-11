// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary> Private Ip Addresses filter. </summary>
    public partial class PrivateIPAddressesContent
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

        /// <summary> Initializes a new instance of <see cref="PrivateIPAddressesContent"/>. </summary>
        /// <param name="subnetOcid"> Subnet OCID. </param>
        /// <param name="vnicOcid"> VCN OCID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetOcid"/> or <paramref name="vnicOcid"/> is null. </exception>
        public PrivateIPAddressesContent(string subnetOcid, string vnicOcid)
        {
            Argument.AssertNotNull(subnetOcid, nameof(subnetOcid));
            Argument.AssertNotNull(vnicOcid, nameof(vnicOcid));

            SubnetOcid = subnetOcid;
            VnicOcid = vnicOcid;
        }

        /// <summary> Initializes a new instance of <see cref="PrivateIPAddressesContent"/>. </summary>
        /// <param name="subnetOcid"> Subnet OCID. </param>
        /// <param name="vnicOcid"> VCN OCID. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateIPAddressesContent(string subnetOcid, string vnicOcid, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SubnetOcid = subnetOcid;
            VnicOcid = vnicOcid;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PrivateIPAddressesContent"/> for deserialization. </summary>
        internal PrivateIPAddressesContent()
        {
        }

        /// <summary> Subnet OCID. </summary>
        public string SubnetOcid { get; }
        /// <summary> VCN OCID. </summary>
        public string VnicOcid { get; }
    }
}
