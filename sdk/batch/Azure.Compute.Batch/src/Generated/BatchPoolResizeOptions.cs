// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> Parameters for changing the size of an Azure Batch Pool. </summary>
    public partial class BatchPoolResizeOptions
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

        /// <summary> Initializes a new instance of <see cref="BatchPoolResizeOptions"/>. </summary>
        public BatchPoolResizeOptions()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BatchPoolResizeOptions"/>. </summary>
        /// <param name="targetDedicatedNodes"> The desired number of dedicated Compute Nodes in the Pool. </param>
        /// <param name="targetLowPriorityNodes"> The desired number of Spot/Low-priority Compute Nodes in the Pool. </param>
        /// <param name="resizeTimeout"> The timeout for allocation of Nodes to the Pool or removal of Compute Nodes from the Pool. The default value is 15 minutes. The minimum value is 5 minutes. If you specify a value less than 5 minutes, the Batch service returns an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </param>
        /// <param name="nodeDeallocationOption"> Determines what to do with a Compute Node and its running task(s) if the Pool size is decreasing. The default value is requeue. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchPoolResizeOptions(int? targetDedicatedNodes, int? targetLowPriorityNodes, TimeSpan? resizeTimeout, BatchNodeDeallocationOption? nodeDeallocationOption, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetDedicatedNodes = targetDedicatedNodes;
            TargetLowPriorityNodes = targetLowPriorityNodes;
            ResizeTimeout = resizeTimeout;
            NodeDeallocationOption = nodeDeallocationOption;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The desired number of dedicated Compute Nodes in the Pool. </summary>
        public int? TargetDedicatedNodes { get; set; }
        /// <summary> The desired number of Spot/Low-priority Compute Nodes in the Pool. </summary>
        public int? TargetLowPriorityNodes { get; set; }
        /// <summary> The timeout for allocation of Nodes to the Pool or removal of Compute Nodes from the Pool. The default value is 15 minutes. The minimum value is 5 minutes. If you specify a value less than 5 minutes, the Batch service returns an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </summary>
        public TimeSpan? ResizeTimeout { get; set; }
        /// <summary> Determines what to do with a Compute Node and its running task(s) if the Pool size is decreasing. The default value is requeue. </summary>
        public BatchNodeDeallocationOption? NodeDeallocationOption { get; set; }
    }
}
