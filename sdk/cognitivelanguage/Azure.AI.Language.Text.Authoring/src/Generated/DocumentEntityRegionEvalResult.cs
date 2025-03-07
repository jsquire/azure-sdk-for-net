// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.Text.Authoring
{
    /// <summary> Represents the evaluation comparison between the expected and predicted entities of a document region. </summary>
    public partial class DocumentEntityRegionEvalResult
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

        /// <summary> Initializes a new instance of <see cref="DocumentEntityRegionEvalResult"/>. </summary>
        /// <param name="expectedEntities"> Represents the region's expected entity labels. </param>
        /// <param name="predictedEntities"> Represents the region's predicted entity labels. </param>
        /// <param name="regionOffset"> Represents the region offset. </param>
        /// <param name="regionLength"> Represents the region length. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="expectedEntities"/> or <paramref name="predictedEntities"/> is null. </exception>
        internal DocumentEntityRegionEvalResult(IEnumerable<DocumentEntityLabelEvalResult> expectedEntities, IEnumerable<DocumentEntityLabelEvalResult> predictedEntities, int regionOffset, int regionLength)
        {
            Argument.AssertNotNull(expectedEntities, nameof(expectedEntities));
            Argument.AssertNotNull(predictedEntities, nameof(predictedEntities));

            ExpectedEntities = expectedEntities.ToList();
            PredictedEntities = predictedEntities.ToList();
            RegionOffset = regionOffset;
            RegionLength = regionLength;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentEntityRegionEvalResult"/>. </summary>
        /// <param name="expectedEntities"> Represents the region's expected entity labels. </param>
        /// <param name="predictedEntities"> Represents the region's predicted entity labels. </param>
        /// <param name="regionOffset"> Represents the region offset. </param>
        /// <param name="regionLength"> Represents the region length. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentEntityRegionEvalResult(IReadOnlyList<DocumentEntityLabelEvalResult> expectedEntities, IReadOnlyList<DocumentEntityLabelEvalResult> predictedEntities, int regionOffset, int regionLength, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ExpectedEntities = expectedEntities;
            PredictedEntities = predictedEntities;
            RegionOffset = regionOffset;
            RegionLength = regionLength;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentEntityRegionEvalResult"/> for deserialization. </summary>
        internal DocumentEntityRegionEvalResult()
        {
        }

        /// <summary> Represents the region's expected entity labels. </summary>
        public IReadOnlyList<DocumentEntityLabelEvalResult> ExpectedEntities { get; }
        /// <summary> Represents the region's predicted entity labels. </summary>
        public IReadOnlyList<DocumentEntityLabelEvalResult> PredictedEntities { get; }
        /// <summary> Represents the region offset. </summary>
        public int RegionOffset { get; }
        /// <summary> Represents the region length. </summary>
        public int RegionLength { get; }
    }
}
