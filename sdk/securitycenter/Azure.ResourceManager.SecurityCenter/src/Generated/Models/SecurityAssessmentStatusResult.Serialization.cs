// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityAssessmentStatusResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("code");
            writer.WriteStringValue(Code.ToString());
            if (Optional.IsDefined(Cause))
            {
                writer.WritePropertyName("cause");
                writer.WriteStringValue(Cause);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static SecurityAssessmentStatusResult DeserializeSecurityAssessmentStatusResult(JsonElement element)
        {
            Optional<DateTimeOffset> firstEvaluationDate = default;
            Optional<DateTimeOffset> statusChangeDate = default;
            AssessmentStatusCode code = default;
            Optional<string> cause = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firstEvaluationDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    firstEvaluationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("statusChangeDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statusChangeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("code"))
                {
                    code = new AssessmentStatusCode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cause"))
                {
                    cause = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new SecurityAssessmentStatusResult(code, cause.Value, description.Value, Optional.ToNullable(firstEvaluationDate), Optional.ToNullable(statusChangeDate));
        }
    }
}
