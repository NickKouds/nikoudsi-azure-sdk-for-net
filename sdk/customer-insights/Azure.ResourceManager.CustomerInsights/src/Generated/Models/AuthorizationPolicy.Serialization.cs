// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class AuthorizationPolicy
    {
        internal static AuthorizationPolicy DeserializeAuthorizationPolicy(JsonElement element)
        {
            Optional<string> policyName = default;
            IReadOnlyList<PermissionType> permissions = default;
            Optional<string> primaryKey = default;
            Optional<string> secondaryKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyName"))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("permissions"))
                {
                    List<PermissionType> array = new List<PermissionType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToPermissionType());
                    }
                    permissions = array;
                    continue;
                }
                if (property.NameEquals("primaryKey"))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
            }
            return new AuthorizationPolicy(policyName.Value, permissions, primaryKey.Value, secondaryKey.Value);
        }
    }
}
