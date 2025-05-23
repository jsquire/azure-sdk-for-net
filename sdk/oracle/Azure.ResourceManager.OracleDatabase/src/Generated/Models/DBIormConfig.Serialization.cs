// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    public partial class DBIormConfig : IUtf8JsonSerializable, IJsonModel<DBIormConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DBIormConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DBIormConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DBIormConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DBIormConfig)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(DBName))
            {
                writer.WritePropertyName("dbName"u8);
                writer.WriteStringValue(DBName);
            }
            if (Optional.IsDefined(FlashCacheLimit))
            {
                writer.WritePropertyName("flashCacheLimit"u8);
                writer.WriteStringValue(FlashCacheLimit);
            }
            if (Optional.IsDefined(Share))
            {
                writer.WritePropertyName("share"u8);
                writer.WriteNumberValue(Share.Value);
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

        DBIormConfig IJsonModel<DBIormConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DBIormConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DBIormConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDBIormConfig(document.RootElement, options);
        }

        internal static DBIormConfig DeserializeDBIormConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string dbName = default;
            string flashCacheLimit = default;
            int? share = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dbName"u8))
                {
                    dbName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("flashCacheLimit"u8))
                {
                    flashCacheLimit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("share"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    share = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DBIormConfig(dbName, flashCacheLimit, share, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DBIormConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DBIormConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerOracleDatabaseContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DBIormConfig)} does not support writing '{options.Format}' format.");
            }
        }

        DBIormConfig IPersistableModel<DBIormConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DBIormConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDBIormConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DBIormConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DBIormConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
