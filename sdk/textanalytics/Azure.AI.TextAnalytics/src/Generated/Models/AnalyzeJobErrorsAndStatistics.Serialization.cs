// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class AnalyzeJobErrorsAndStatistics
    {
        internal static AnalyzeJobErrorsAndStatistics DeserializeAnalyzeJobErrorsAndStatistics(JsonElement element)
        {
            Optional<IReadOnlyList<TextAnalyticsErrorInternal>> errors = default;
            Optional<TextDocumentBatchStatistics> statistics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TextAnalyticsErrorInternal> array = new List<TextAnalyticsErrorInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextAnalyticsErrorInternal.DeserializeTextAnalyticsErrorInternal(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("statistics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statistics = TextDocumentBatchStatistics.DeserializeTextDocumentBatchStatistics(property.Value);
                    continue;
                }
            }
            return new AnalyzeJobErrorsAndStatistics(Optional.ToList(errors), statistics.Value);
        }
    }
}
