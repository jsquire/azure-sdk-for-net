// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Search.Documents.Agents.Models
{
    public partial class KnowledgeAgentAzureSearchDocReference
    {
        internal static KnowledgeAgentAzureSearchDocReference DeserializeKnowledgeAgentAzureSearchDocReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string docKey = default;
            IReadOnlyDictionary<string, object> sourceData = default;
            string type = default;
            string id = default;
            int activitySource = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("docKey"u8))
                {
                    docKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    sourceData = dictionary;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activitySource"u8))
                {
                    activitySource = property.Value.GetInt32();
                    continue;
                }
            }
            return new KnowledgeAgentAzureSearchDocReference(type, id, activitySource, docKey, sourceData ?? new ChangeTrackingDictionary<string, object>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new KnowledgeAgentAzureSearchDocReference FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeKnowledgeAgentAzureSearchDocReference(document.RootElement);
        }
    }
}
