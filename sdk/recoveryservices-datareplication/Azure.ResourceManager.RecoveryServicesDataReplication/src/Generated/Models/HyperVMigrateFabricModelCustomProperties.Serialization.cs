// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class HyperVMigrateFabricModelCustomProperties : IUtf8JsonSerializable, IJsonModel<HyperVMigrateFabricModelCustomProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HyperVMigrateFabricModelCustomProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HyperVMigrateFabricModelCustomProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVMigrateFabricModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVMigrateFabricModelCustomProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("hyperVSiteId"u8);
            writer.WriteStringValue(HyperVSiteId);
            if (options.Format != "W" && Optional.IsDefined(FabricResourceId))
            {
                writer.WritePropertyName("fabricResourceId"u8);
                writer.WriteStringValue(FabricResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(FabricContainerId))
            {
                writer.WritePropertyName("fabricContainerId"u8);
                writer.WriteStringValue(FabricContainerId);
            }
            writer.WritePropertyName("migrationSolutionId"u8);
            writer.WriteStringValue(MigrationSolutionId);
            if (options.Format != "W" && Optional.IsDefined(MigrationHubUri))
            {
                writer.WritePropertyName("migrationHubUri"u8);
                writer.WriteStringValue(MigrationHubUri.AbsoluteUri);
            }
        }

        HyperVMigrateFabricModelCustomProperties IJsonModel<HyperVMigrateFabricModelCustomProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVMigrateFabricModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVMigrateFabricModelCustomProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVMigrateFabricModelCustomProperties(document.RootElement, options);
        }

        internal static HyperVMigrateFabricModelCustomProperties DeserializeHyperVMigrateFabricModelCustomProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier hyperVSiteId = default;
            ResourceIdentifier fabricResourceId = default;
            string fabricContainerId = default;
            ResourceIdentifier migrationSolutionId = default;
            Uri migrationHubUri = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hyperVSiteId"u8))
                {
                    hyperVSiteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fabricResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fabricContainerId"u8))
                {
                    fabricContainerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationSolutionId"u8))
                {
                    migrationSolutionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("migrationHubUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationHubUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HyperVMigrateFabricModelCustomProperties(
                instanceType,
                serializedAdditionalRawData,
                hyperVSiteId,
                fabricResourceId,
                fabricContainerId,
                migrationSolutionId,
                migrationHubUri);
        }

        BinaryData IPersistableModel<HyperVMigrateFabricModelCustomProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVMigrateFabricModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HyperVMigrateFabricModelCustomProperties)} does not support writing '{options.Format}' format.");
            }
        }

        HyperVMigrateFabricModelCustomProperties IPersistableModel<HyperVMigrateFabricModelCustomProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVMigrateFabricModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHyperVMigrateFabricModelCustomProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HyperVMigrateFabricModelCustomProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HyperVMigrateFabricModelCustomProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
