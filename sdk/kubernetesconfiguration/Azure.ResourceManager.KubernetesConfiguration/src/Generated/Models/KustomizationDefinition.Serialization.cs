// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KustomizationDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path");
                writer.WriteStringValue(Path);
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                if (DependsOn != null)
                {
                    writer.WritePropertyName("dependsOn");
                    writer.WriteStartArray();
                    foreach (var item in DependsOn)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("dependsOn");
                }
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                if (TimeoutInSeconds != null)
                {
                    writer.WritePropertyName("timeoutInSeconds");
                    writer.WriteNumberValue(TimeoutInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("timeoutInSeconds");
                }
            }
            if (Optional.IsDefined(SyncIntervalInSeconds))
            {
                if (SyncIntervalInSeconds != null)
                {
                    writer.WritePropertyName("syncIntervalInSeconds");
                    writer.WriteNumberValue(SyncIntervalInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("syncIntervalInSeconds");
                }
            }
            if (Optional.IsDefined(RetryIntervalInSeconds))
            {
                if (RetryIntervalInSeconds != null)
                {
                    writer.WritePropertyName("retryIntervalInSeconds");
                    writer.WriteNumberValue(RetryIntervalInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("retryIntervalInSeconds");
                }
            }
            if (Optional.IsDefined(Prune))
            {
                writer.WritePropertyName("prune");
                writer.WriteBooleanValue(Prune.Value);
            }
            if (Optional.IsDefined(Force))
            {
                writer.WritePropertyName("force");
                writer.WriteBooleanValue(Force.Value);
            }
            writer.WriteEndObject();
        }

        internal static KustomizationDefinition DeserializeKustomizationDefinition(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> path = default;
            Optional<IList<string>> dependsOn = default;
            Optional<long?> timeoutInSeconds = default;
            Optional<long?> syncIntervalInSeconds = default;
            Optional<long?> retryIntervalInSeconds = default;
            Optional<bool> prune = default;
            Optional<bool> force = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dependsOn = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("timeoutInSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeoutInSeconds = null;
                        continue;
                    }
                    timeoutInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("syncIntervalInSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        syncIntervalInSeconds = null;
                        continue;
                    }
                    syncIntervalInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("retryIntervalInSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        retryIntervalInSeconds = null;
                        continue;
                    }
                    retryIntervalInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("prune"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    prune = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("force"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    force = property.Value.GetBoolean();
                    continue;
                }
            }
            return new KustomizationDefinition(name.Value, path.Value, Optional.ToList(dependsOn), Optional.ToNullable(timeoutInSeconds), Optional.ToNullable(syncIntervalInSeconds), Optional.ToNullable(retryIntervalInSeconds), Optional.ToNullable(prune), Optional.ToNullable(force));
        }
    }
}
