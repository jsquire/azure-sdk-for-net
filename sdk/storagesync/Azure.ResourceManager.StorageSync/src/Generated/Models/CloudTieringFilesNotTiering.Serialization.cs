// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class CloudTieringFilesNotTiering : IUtf8JsonSerializable, IJsonModel<CloudTieringFilesNotTiering>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudTieringFilesNotTiering>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CloudTieringFilesNotTiering>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringFilesNotTiering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudTieringFilesNotTiering)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedTimestamp"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(TotalFileCount))
            {
                writer.WritePropertyName("totalFileCount"u8);
                writer.WriteNumberValue(TotalFileCount.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        CloudTieringFilesNotTiering IJsonModel<CloudTieringFilesNotTiering>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringFilesNotTiering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudTieringFilesNotTiering)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudTieringFilesNotTiering(document.RootElement, options);
        }

        internal static CloudTieringFilesNotTiering DeserializeCloudTieringFilesNotTiering(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? lastUpdatedTimestamp = default;
            long? totalFileCount = default;
            IReadOnlyList<FilesNotTieringError> errors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastUpdatedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("totalFileCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalFileCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FilesNotTieringError> array = new List<FilesNotTieringError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FilesNotTieringError.DeserializeFilesNotTieringError(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CloudTieringFilesNotTiering(lastUpdatedTimestamp, totalFileCount, errors ?? new ChangeTrackingList<FilesNotTieringError>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CloudTieringFilesNotTiering>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringFilesNotTiering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerStorageSyncContext.Default);
                default:
                    throw new FormatException($"The model {nameof(CloudTieringFilesNotTiering)} does not support writing '{options.Format}' format.");
            }
        }

        CloudTieringFilesNotTiering IPersistableModel<CloudTieringFilesNotTiering>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringFilesNotTiering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCloudTieringFilesNotTiering(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CloudTieringFilesNotTiering)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudTieringFilesNotTiering>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
