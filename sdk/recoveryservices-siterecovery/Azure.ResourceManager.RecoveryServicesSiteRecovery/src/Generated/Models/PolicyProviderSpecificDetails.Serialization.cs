// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownPolicyProviderSpecificDetails))]
    public partial class PolicyProviderSpecificDetails : IUtf8JsonSerializable, IJsonModel<PolicyProviderSpecificDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyProviderSpecificDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PolicyProviderSpecificDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyProviderSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyProviderSpecificDetails)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        PolicyProviderSpecificDetails IJsonModel<PolicyProviderSpecificDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyProviderSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyProviderSpecificDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyProviderSpecificDetails(document.RootElement, options);
        }

        internal static PolicyProviderSpecificDetails DeserializePolicyProviderSpecificDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "A2A": return A2APolicyDetails.DeserializeA2APolicyDetails(element, options);
                    case "HyperVReplica2012": return HyperVReplicaPolicyDetails.DeserializeHyperVReplicaPolicyDetails(element, options);
                    case "HyperVReplica2012R2": return HyperVReplicaBluePolicyDetails.DeserializeHyperVReplicaBluePolicyDetails(element, options);
                    case "HyperVReplicaAzure": return HyperVReplicaAzurePolicyDetails.DeserializeHyperVReplicaAzurePolicyDetails(element, options);
                    case "HyperVReplicaBasePolicyDetails": return HyperVReplicaBasePolicyDetails.DeserializeHyperVReplicaBasePolicyDetails(element, options);
                    case "InMage": return InMagePolicyDetails.DeserializeInMagePolicyDetails(element, options);
                    case "InMageAzureV2": return InMageAzureV2PolicyDetails.DeserializeInMageAzureV2PolicyDetails(element, options);
                    case "InMageBasePolicyDetails": return InMageBasePolicyDetails.DeserializeInMageBasePolicyDetails(element, options);
                    case "InMageRcm": return InMageRcmPolicyDetails.DeserializeInMageRcmPolicyDetails(element, options);
                    case "InMageRcmFailback": return InMageRcmFailbackPolicyDetails.DeserializeInMageRcmFailbackPolicyDetails(element, options);
                    case "VMwareCbt": return VMwareCbtPolicyDetails.DeserializeVMwareCbtPolicyDetails(element, options);
                }
            }
            return UnknownPolicyProviderSpecificDetails.DeserializeUnknownPolicyProviderSpecificDetails(element, options);
        }

        BinaryData IPersistableModel<PolicyProviderSpecificDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyProviderSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesSiteRecoveryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(PolicyProviderSpecificDetails)} does not support writing '{options.Format}' format.");
            }
        }

        PolicyProviderSpecificDetails IPersistableModel<PolicyProviderSpecificDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyProviderSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePolicyProviderSpecificDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicyProviderSpecificDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyProviderSpecificDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
