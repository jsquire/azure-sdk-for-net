// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseGrantSqlControlToManagedIdentity : IUtf8JsonSerializable, IJsonModel<SynapseGrantSqlControlToManagedIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseGrantSqlControlToManagedIdentity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseGrantSqlControlToManagedIdentity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseGrantSqlControlToManagedIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseGrantSqlControlToManagedIdentity)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(DesiredState))
            {
                writer.WritePropertyName("desiredState"u8);
                writer.WriteStringValue(DesiredState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(ActualState))
            {
                writer.WritePropertyName("actualState"u8);
                writer.WriteStringValue(ActualState.Value.ToSerialString());
            }
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

        SynapseGrantSqlControlToManagedIdentity IJsonModel<SynapseGrantSqlControlToManagedIdentity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseGrantSqlControlToManagedIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseGrantSqlControlToManagedIdentity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseGrantSqlControlToManagedIdentity(document.RootElement, options);
        }

        internal static SynapseGrantSqlControlToManagedIdentity DeserializeSynapseGrantSqlControlToManagedIdentity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SynapseDesiredState? desiredState = default;
            SynapseGrantSqlControlToManagedIdentityState? actualState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("desiredState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    desiredState = property.Value.GetString().ToSynapseDesiredState();
                    continue;
                }
                if (property.NameEquals("actualState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actualState = property.Value.GetString().ToSynapseGrantSqlControlToManagedIdentityState();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SynapseGrantSqlControlToManagedIdentity(desiredState, actualState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseGrantSqlControlToManagedIdentity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseGrantSqlControlToManagedIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSynapseContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SynapseGrantSqlControlToManagedIdentity)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseGrantSqlControlToManagedIdentity IPersistableModel<SynapseGrantSqlControlToManagedIdentity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseGrantSqlControlToManagedIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSynapseGrantSqlControlToManagedIdentity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseGrantSqlControlToManagedIdentity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseGrantSqlControlToManagedIdentity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
