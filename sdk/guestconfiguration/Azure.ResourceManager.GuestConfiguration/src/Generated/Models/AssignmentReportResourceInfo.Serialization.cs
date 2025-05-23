// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    public partial class AssignmentReportResourceInfo : IUtf8JsonSerializable, IJsonModel<AssignmentReportResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AssignmentReportResourceInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AssignmentReportResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignmentReportResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssignmentReportResourceInfo)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ComplianceStatus))
            {
                writer.WritePropertyName("complianceStatus"u8);
                writer.WriteStringValue(ComplianceStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AssignmentResourceSettingName))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(AssignmentResourceSettingName);
            }
            if (Optional.IsCollectionDefined(Reasons))
            {
                writer.WritePropertyName("reasons"u8);
                writer.WriteStartArray();
                foreach (var item in Reasons)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Properties);
#else
                using (JsonDocument document = JsonDocument.Parse(Properties, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        AssignmentReportResourceInfo IJsonModel<AssignmentReportResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignmentReportResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssignmentReportResourceInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAssignmentReportResourceInfo(document.RootElement, options);
        }

        internal static AssignmentReportResourceInfo DeserializeAssignmentReportResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AssignedGuestConfigurationMachineComplianceStatus? complianceStatus = default;
            string resourceId = default;
            IList<AssignmentReportResourceComplianceReason> reasons = default;
            BinaryData properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("complianceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complianceStatus = new AssignedGuestConfigurationMachineComplianceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reasons"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AssignmentReportResourceComplianceReason> array = new List<AssignmentReportResourceComplianceReason>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AssignmentReportResourceComplianceReason.DeserializeAssignmentReportResourceComplianceReason(item, options));
                    }
                    reasons = array;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AssignmentReportResourceInfo(complianceStatus, resourceId, reasons ?? new ChangeTrackingList<AssignmentReportResourceComplianceReason>(), properties, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ComplianceStatus), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  complianceStatus: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ComplianceStatus))
                {
                    builder.Append("  complianceStatus: ");
                    builder.AppendLine($"'{ComplianceStatus.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AssignmentResourceSettingName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  resourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AssignmentResourceSettingName))
                {
                    builder.Append("  resourceId: ");
                    if (AssignmentResourceSettingName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AssignmentResourceSettingName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AssignmentResourceSettingName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Reasons), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  reasons: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Reasons))
                {
                    if (Reasons.Any())
                    {
                        builder.Append("  reasons: ");
                        builder.AppendLine("[");
                        foreach (var item in Reasons)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  reasons: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Properties), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  properties: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Properties))
                {
                    builder.Append("  properties: ");
                    builder.AppendLine($"'{Properties.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AssignmentReportResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignmentReportResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerGuestConfigurationContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AssignmentReportResourceInfo)} does not support writing '{options.Format}' format.");
            }
        }

        AssignmentReportResourceInfo IPersistableModel<AssignmentReportResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignmentReportResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAssignmentReportResourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AssignmentReportResourceInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AssignmentReportResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
