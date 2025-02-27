// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxShipmentPickUpResult
    {
        internal static DataBoxShipmentPickUpResult DeserializeDataBoxShipmentPickUpResult(JsonElement element)
        {
            Optional<string> confirmationNumber = default;
            Optional<DateTimeOffset> readyByTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("confirmationNumber"))
                {
                    confirmationNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("readyByTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    readyByTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new DataBoxShipmentPickUpResult(confirmationNumber.Value, Optional.ToNullable(readyByTime));
        }
    }
}
