// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerCapabilityProperties
    {
        internal static PostgreSqlFlexibleServerCapabilityProperties DeserializePostgreSqlFlexibleServerCapabilityProperties(JsonElement element)
        {
            Optional<string> zone = default;
            Optional<bool> geoBackupSupported = default;
            Optional<bool> zoneRedundantHaSupported = default;
            Optional<bool> zoneRedundantHaAndGeoBackupSupported = default;
            Optional<IReadOnlyList<PostgreSqlFlexibleServerEditionCapability>> supportedFlexibleServerEditions = default;
            Optional<IReadOnlyList<PostgreSqlFlexibleServerHyperscaleNodeEditionCapability>> supportedHyperscaleNodeEditions = default;
            Optional<IReadOnlyList<string>> supportedHAMode = default;
            Optional<string> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zone"))
                {
                    zone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("geoBackupSupported"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    geoBackupSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("zoneRedundantHaSupported"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    zoneRedundantHaSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("zoneRedundantHaAndGeoBackupSupported"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    zoneRedundantHaAndGeoBackupSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("supportedFlexibleServerEditions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PostgreSqlFlexibleServerEditionCapability> array = new List<PostgreSqlFlexibleServerEditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerEditionCapability.DeserializePostgreSqlFlexibleServerEditionCapability(item));
                    }
                    supportedFlexibleServerEditions = array;
                    continue;
                }
                if (property.NameEquals("supportedHyperscaleNodeEditions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PostgreSqlFlexibleServerHyperscaleNodeEditionCapability> array = new List<PostgreSqlFlexibleServerHyperscaleNodeEditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerHyperscaleNodeEditionCapability.DeserializePostgreSqlFlexibleServerHyperscaleNodeEditionCapability(item));
                    }
                    supportedHyperscaleNodeEditions = array;
                    continue;
                }
                if (property.NameEquals("supportedHAMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedHAMode = array;
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
            }
            return new PostgreSqlFlexibleServerCapabilityProperties(zone.Value, Optional.ToNullable(geoBackupSupported), Optional.ToNullable(zoneRedundantHaSupported), Optional.ToNullable(zoneRedundantHaAndGeoBackupSupported), Optional.ToList(supportedFlexibleServerEditions), Optional.ToList(supportedHyperscaleNodeEditions), Optional.ToList(supportedHAMode), status.Value);
        }
    }
}
