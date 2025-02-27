// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class Scans
    {
        internal static Scans DeserializeScans(JsonElement element)
        {
            Optional<IReadOnlyList<SqlVulnerabilityAssessmentScanData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SqlVulnerabilityAssessmentScanData> array = new List<SqlVulnerabilityAssessmentScanData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlVulnerabilityAssessmentScanData.DeserializeSqlVulnerabilityAssessmentScanData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new Scans(Optional.ToList(value));
        }
    }
}
