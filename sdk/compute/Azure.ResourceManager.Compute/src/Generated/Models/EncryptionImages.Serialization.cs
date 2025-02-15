// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class EncryptionImages : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OSDiskImage))
            {
                writer.WritePropertyName("osDiskImage"u8);
                writer.WriteObjectValue(OSDiskImage);
            }
            if (Optional.IsCollectionDefined(DataDiskImages))
            {
                writer.WritePropertyName("dataDiskImages"u8);
                writer.WriteStartArray();
                foreach (var item in DataDiskImages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static EncryptionImages DeserializeEncryptionImages(JsonElement element)
        {
            Optional<OSDiskImageEncryption> osDiskImage = default;
            Optional<IList<DataDiskImageEncryption>> dataDiskImages = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osDiskImage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    osDiskImage = OSDiskImageEncryption.DeserializeOSDiskImageEncryption(property.Value);
                    continue;
                }
                if (property.NameEquals("dataDiskImages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataDiskImageEncryption> array = new List<DataDiskImageEncryption>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataDiskImageEncryption.DeserializeDataDiskImageEncryption(item));
                    }
                    dataDiskImages = array;
                    continue;
                }
            }
            return new EncryptionImages(osDiskImage.Value, Optional.ToList(dataDiskImages));
        }
    }
}
