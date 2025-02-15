// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class OutputSelector : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Property))
            {
                writer.WritePropertyName("property"u8);
                writer.WriteStringValue(Property.Value.ToString());
            }
            if (Optional.IsDefined(Operator))
            {
                writer.WritePropertyName("operator"u8);
                writer.WriteStringValue(Operator.Value.ToString());
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            writer.WriteEndObject();
        }

        internal static OutputSelector DeserializeOutputSelector(JsonElement element)
        {
            Optional<OutputSelectorProperty> property = default;
            Optional<OutputSelectorOperator> @operator = default;
            Optional<string> value = default;
            foreach (var property0 in element.EnumerateObject())
            {
                if (property0.NameEquals("property"u8))
                {
                    if (property0.Value.ValueKind == JsonValueKind.Null)
                    {
                        property0.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    property = new OutputSelectorProperty(property0.Value.GetString());
                    continue;
                }
                if (property0.NameEquals("operator"u8))
                {
                    if (property0.Value.ValueKind == JsonValueKind.Null)
                    {
                        property0.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    @operator = new OutputSelectorOperator(property0.Value.GetString());
                    continue;
                }
                if (property0.NameEquals("value"u8))
                {
                    value = property0.Value.GetString();
                    continue;
                }
            }
            return new OutputSelector(Optional.ToNullable(property), Optional.ToNullable(@operator), value.Value);
        }
    }
}
