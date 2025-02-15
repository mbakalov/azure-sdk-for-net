// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class ManagedRuleExclusion : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("matchVariable"u8);
            writer.WriteStringValue(MatchVariable.ToString());
            writer.WritePropertyName("selectorMatchOperator"u8);
            writer.WriteStringValue(SelectorMatchOperator.ToString());
            writer.WritePropertyName("selector"u8);
            writer.WriteStringValue(Selector);
            writer.WriteEndObject();
        }

        internal static ManagedRuleExclusion DeserializeManagedRuleExclusion(JsonElement element)
        {
            ManagedRuleExclusionMatchVariable matchVariable = default;
            ManagedRuleExclusionSelectorMatchOperator selectorMatchOperator = default;
            string selector = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("matchVariable"u8))
                {
                    matchVariable = new ManagedRuleExclusionMatchVariable(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("selectorMatchOperator"u8))
                {
                    selectorMatchOperator = new ManagedRuleExclusionSelectorMatchOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("selector"u8))
                {
                    selector = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedRuleExclusion(matchVariable, selectorMatchOperator, selector);
        }
    }
}
