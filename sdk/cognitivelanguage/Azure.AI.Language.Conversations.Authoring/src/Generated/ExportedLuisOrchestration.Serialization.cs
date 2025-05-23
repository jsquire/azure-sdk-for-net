// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations.Authoring
{
    public partial class ExportedLuisOrchestration : IUtf8JsonSerializable, IJsonModel<ExportedLuisOrchestration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExportedLuisOrchestration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExportedLuisOrchestration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportedLuisOrchestration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportedLuisOrchestration)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("appId"u8);
            writer.WriteStringValue(AppId);
            if (Optional.IsDefined(AppVersion))
            {
                writer.WritePropertyName("appVersion"u8);
                writer.WriteStringValue(AppVersion);
            }
            if (Optional.IsDefined(SlotName))
            {
                writer.WritePropertyName("slotName"u8);
                writer.WriteStringValue(SlotName);
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

        ExportedLuisOrchestration IJsonModel<ExportedLuisOrchestration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportedLuisOrchestration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportedLuisOrchestration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExportedLuisOrchestration(document.RootElement, options);
        }

        internal static ExportedLuisOrchestration DeserializeExportedLuisOrchestration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid appId = default;
            string appVersion = default;
            string slotName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appId"u8))
                {
                    appId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("appVersion"u8))
                {
                    appVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("slotName"u8))
                {
                    slotName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExportedLuisOrchestration(appId, appVersion, slotName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExportedLuisOrchestration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportedLuisOrchestration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAILanguageConversationsAuthoringContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ExportedLuisOrchestration)} does not support writing '{options.Format}' format.");
            }
        }

        ExportedLuisOrchestration IPersistableModel<ExportedLuisOrchestration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportedLuisOrchestration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeExportedLuisOrchestration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExportedLuisOrchestration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExportedLuisOrchestration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ExportedLuisOrchestration FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeExportedLuisOrchestration(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
