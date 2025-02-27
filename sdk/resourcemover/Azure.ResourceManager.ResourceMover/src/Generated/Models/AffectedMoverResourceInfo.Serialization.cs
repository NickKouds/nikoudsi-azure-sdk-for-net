// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class AffectedMoverResourceInfo
    {
        internal static AffectedMoverResourceInfo DeserializeAffectedMoverResourceInfo(JsonElement element)
        {
            Optional<ResourceIdentifier> id = default;
            Optional<ResourceIdentifier> sourceId = default;
            Optional<IReadOnlyList<AffectedMoverResourceInfo>> moveResources = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("moveResources"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AffectedMoverResourceInfo> array = new List<AffectedMoverResourceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeAffectedMoverResourceInfo(item));
                    }
                    moveResources = array;
                    continue;
                }
            }
            return new AffectedMoverResourceInfo(id.Value, sourceId.Value, Optional.ToList(moveResources));
        }
    }
}
