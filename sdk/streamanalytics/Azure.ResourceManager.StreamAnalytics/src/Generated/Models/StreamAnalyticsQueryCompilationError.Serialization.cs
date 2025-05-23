// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamAnalyticsQueryCompilationError : IUtf8JsonSerializable, IJsonModel<StreamAnalyticsQueryCompilationError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamAnalyticsQueryCompilationError>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StreamAnalyticsQueryCompilationError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsQueryCompilationError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsQueryCompilationError)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (options.Format != "W" && Optional.IsDefined(StartLine))
            {
                writer.WritePropertyName("startLine"u8);
                writer.WriteNumberValue(StartLine.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(StartColumn))
            {
                writer.WritePropertyName("startColumn"u8);
                writer.WriteNumberValue(StartColumn.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(EndLine))
            {
                writer.WritePropertyName("endLine"u8);
                writer.WriteNumberValue(EndLine.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(EndColumn))
            {
                writer.WritePropertyName("endColumn"u8);
                writer.WriteNumberValue(EndColumn.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsGlobal))
            {
                writer.WritePropertyName("isGlobal"u8);
                writer.WriteBooleanValue(IsGlobal.Value);
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

        StreamAnalyticsQueryCompilationError IJsonModel<StreamAnalyticsQueryCompilationError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsQueryCompilationError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsQueryCompilationError)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamAnalyticsQueryCompilationError(document.RootElement, options);
        }

        internal static StreamAnalyticsQueryCompilationError DeserializeStreamAnalyticsQueryCompilationError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string message = default;
            int? startLine = default;
            int? startColumn = default;
            int? endLine = default;
            int? endColumn = default;
            bool? isGlobal = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startLine"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startLine = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startColumn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startColumn = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("endLine"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endLine = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("endColumn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endColumn = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isGlobal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isGlobal = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StreamAnalyticsQueryCompilationError(
                message,
                startLine,
                startColumn,
                endLine,
                endColumn,
                isGlobal,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamAnalyticsQueryCompilationError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsQueryCompilationError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerStreamAnalyticsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsQueryCompilationError)} does not support writing '{options.Format}' format.");
            }
        }

        StreamAnalyticsQueryCompilationError IPersistableModel<StreamAnalyticsQueryCompilationError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsQueryCompilationError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStreamAnalyticsQueryCompilationError(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsQueryCompilationError)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamAnalyticsQueryCompilationError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
