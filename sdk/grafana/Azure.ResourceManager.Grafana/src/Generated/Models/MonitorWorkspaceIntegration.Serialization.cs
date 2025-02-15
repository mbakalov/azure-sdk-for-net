// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Grafana.Models
{
    public partial class MonitorWorkspaceIntegration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MonitorWorkspaceResourceId))
            {
                writer.WritePropertyName("azureMonitorWorkspaceResourceId"u8);
                writer.WriteStringValue(MonitorWorkspaceResourceId);
            }
            writer.WriteEndObject();
        }

        internal static MonitorWorkspaceIntegration DeserializeMonitorWorkspaceIntegration(JsonElement element)
        {
            Optional<ResourceIdentifier> azureMonitorWorkspaceResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureMonitorWorkspaceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureMonitorWorkspaceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new MonitorWorkspaceIntegration(azureMonitorWorkspaceResourceId.Value);
        }
    }
}
