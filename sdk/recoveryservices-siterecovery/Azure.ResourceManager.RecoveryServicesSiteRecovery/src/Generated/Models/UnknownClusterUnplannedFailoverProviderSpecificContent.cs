// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Unknown version of ClusterUnplannedFailoverProviderSpecificInput. </summary>
    internal partial class UnknownClusterUnplannedFailoverProviderSpecificContent : ClusterUnplannedFailoverProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="UnknownClusterUnplannedFailoverProviderSpecificContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownClusterUnplannedFailoverProviderSpecificContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            InstanceType = instanceType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownClusterUnplannedFailoverProviderSpecificContent"/> for deserialization. </summary>
        internal UnknownClusterUnplannedFailoverProviderSpecificContent()
        {
        }
    }
}
