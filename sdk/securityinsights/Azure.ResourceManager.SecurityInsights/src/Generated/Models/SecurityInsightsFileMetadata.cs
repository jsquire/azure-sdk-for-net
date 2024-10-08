// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents a file. </summary>
    public partial class SecurityInsightsFileMetadata
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

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsFileMetadata"/>. </summary>
        public SecurityInsightsFileMetadata()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsFileMetadata"/>. </summary>
        /// <param name="fileFormat"> The format of the file. </param>
        /// <param name="fileName"> The name of the file. </param>
        /// <param name="fileSize"> The size of the file. </param>
        /// <param name="fileContentUri"> A URI with a valid SAS token to allow uploading / downloading the file. </param>
        /// <param name="deleteStatus"> Indicates whether the file was deleted from the storage account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsFileMetadata(SecurityInsightsFileFormat? fileFormat, string fileName, int? fileSize, Uri fileContentUri, SecurityInsightsFileDeleteStatus? deleteStatus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileFormat = fileFormat;
            FileName = fileName;
            FileSize = fileSize;
            FileContentUri = fileContentUri;
            DeleteStatus = deleteStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The format of the file. </summary>
        [WirePath("fileFormat")]
        public SecurityInsightsFileFormat? FileFormat { get; set; }
        /// <summary> The name of the file. </summary>
        [WirePath("fileName")]
        public string FileName { get; set; }
        /// <summary> The size of the file. </summary>
        [WirePath("fileSize")]
        public int? FileSize { get; set; }
        /// <summary> A URI with a valid SAS token to allow uploading / downloading the file. </summary>
        [WirePath("fileContentUri")]
        public Uri FileContentUri { get; }
        /// <summary> Indicates whether the file was deleted from the storage account. </summary>
        [WirePath("deleteStatus")]
        public SecurityInsightsFileDeleteStatus? DeleteStatus { get; }
    }
}
