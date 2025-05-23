// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevOpsInfrastructure.Models
{
    public partial class DevOpsPoolVmImage : IUtf8JsonSerializable, IJsonModel<DevOpsPoolVmImage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevOpsPoolVmImage>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevOpsPoolVmImage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsPoolVmImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevOpsPoolVmImage)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(WellKnownImageName))
            {
                writer.WritePropertyName("wellKnownImageName"u8);
                writer.WriteStringValue(WellKnownImageName);
            }
            if (Optional.IsCollectionDefined(Aliases))
            {
                writer.WritePropertyName("aliases"u8);
                writer.WriteStartArray();
                foreach (var item in Aliases)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Buffer))
            {
                writer.WritePropertyName("buffer"u8);
                writer.WriteStringValue(Buffer);
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

        DevOpsPoolVmImage IJsonModel<DevOpsPoolVmImage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsPoolVmImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevOpsPoolVmImage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevOpsPoolVmImage(document.RootElement, options);
        }

        internal static DevOpsPoolVmImage DeserializeDevOpsPoolVmImage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceId = default;
            string wellKnownImageName = default;
            IList<string> aliases = default;
            string buffer = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("wellKnownImageName"u8))
                {
                    wellKnownImageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aliases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    aliases = array;
                    continue;
                }
                if (property.NameEquals("buffer"u8))
                {
                    buffer = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevOpsPoolVmImage(resourceId, wellKnownImageName, aliases ?? new ChangeTrackingList<string>(), buffer, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevOpsPoolVmImage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsPoolVmImage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDevOpsInfrastructureContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DevOpsPoolVmImage)} does not support writing '{options.Format}' format.");
            }
        }

        DevOpsPoolVmImage IPersistableModel<DevOpsPoolVmImage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsPoolVmImage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDevOpsPoolVmImage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevOpsPoolVmImage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevOpsPoolVmImage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
