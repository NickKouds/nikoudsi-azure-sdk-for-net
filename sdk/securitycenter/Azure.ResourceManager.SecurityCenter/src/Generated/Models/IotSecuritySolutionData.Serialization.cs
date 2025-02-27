// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class IotSecuritySolutionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Workspace))
            {
                writer.WritePropertyName("workspace");
                writer.WriteStringValue(Workspace);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Export))
            {
                writer.WritePropertyName("export");
                writer.WriteStartArray();
                foreach (var item in Export)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DisabledDataSources))
            {
                writer.WritePropertyName("disabledDataSources");
                writer.WriteStartArray();
                foreach (var item in DisabledDataSources)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IotHubs))
            {
                writer.WritePropertyName("iotHubs");
                writer.WriteStartArray();
                foreach (var item in IotHubs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UserDefinedResources))
            {
                writer.WritePropertyName("userDefinedResources");
                writer.WriteObjectValue(UserDefinedResources);
            }
            if (Optional.IsCollectionDefined(RecommendationsConfiguration))
            {
                writer.WritePropertyName("recommendationsConfiguration");
                writer.WriteStartArray();
                foreach (var item in RecommendationsConfiguration)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UnmaskedIPLoggingStatus))
            {
                writer.WritePropertyName("unmaskedIpLoggingStatus");
                writer.WriteStringValue(UnmaskedIPLoggingStatus.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AdditionalWorkspaces))
            {
                writer.WritePropertyName("additionalWorkspaces");
                writer.WriteStartArray();
                foreach (var item in AdditionalWorkspaces)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static IotSecuritySolutionData DeserializeIotSecuritySolutionData(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> workspace = default;
            Optional<string> displayName = default;
            Optional<SecuritySolutionStatus> status = default;
            Optional<IList<IotSecuritySolutionExportOption>> export = default;
            Optional<IList<DataSource>> disabledDataSources = default;
            Optional<IList<string>> iotHubs = default;
            Optional<UserDefinedResourcesProperties> userDefinedResources = default;
            Optional<IReadOnlyList<string>> autoDiscoveredResources = default;
            Optional<IList<RecommendationConfigurationProperties>> recommendationsConfiguration = default;
            Optional<UnmaskedIPLoggingStatus> unmaskedIPLoggingStatus = default;
            Optional<IList<AdditionalWorkspacesProperties>> additionalWorkspaces = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("workspace"))
                        {
                            workspace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new SecuritySolutionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("export"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<IotSecuritySolutionExportOption> array = new List<IotSecuritySolutionExportOption>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new IotSecuritySolutionExportOption(item.GetString()));
                            }
                            export = array;
                            continue;
                        }
                        if (property0.NameEquals("disabledDataSources"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DataSource> array = new List<DataSource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new DataSource(item.GetString()));
                            }
                            disabledDataSources = array;
                            continue;
                        }
                        if (property0.NameEquals("iotHubs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            iotHubs = array;
                            continue;
                        }
                        if (property0.NameEquals("userDefinedResources"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            userDefinedResources = UserDefinedResourcesProperties.DeserializeUserDefinedResourcesProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("autoDiscoveredResources"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            autoDiscoveredResources = array;
                            continue;
                        }
                        if (property0.NameEquals("recommendationsConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RecommendationConfigurationProperties> array = new List<RecommendationConfigurationProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RecommendationConfigurationProperties.DeserializeRecommendationConfigurationProperties(item));
                            }
                            recommendationsConfiguration = array;
                            continue;
                        }
                        if (property0.NameEquals("unmaskedIpLoggingStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            unmaskedIPLoggingStatus = new UnmaskedIPLoggingStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("additionalWorkspaces"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AdditionalWorkspacesProperties> array = new List<AdditionalWorkspacesProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AdditionalWorkspacesProperties.DeserializeAdditionalWorkspacesProperties(item));
                            }
                            additionalWorkspaces = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new IotSecuritySolutionData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, workspace.Value, displayName.Value, Optional.ToNullable(status), Optional.ToList(export), Optional.ToList(disabledDataSources), Optional.ToList(iotHubs), userDefinedResources.Value, Optional.ToList(autoDiscoveredResources), Optional.ToList(recommendationsConfiguration), Optional.ToNullable(unmaskedIPLoggingStatus), Optional.ToList(additionalWorkspaces));
        }
    }
}
