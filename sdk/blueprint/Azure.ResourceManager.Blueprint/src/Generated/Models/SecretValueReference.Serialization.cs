// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Blueprint.Models
{
    public partial class SecretValueReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyVault");
            JsonSerializer.Serialize(writer, KeyVault); writer.WritePropertyName("secretName");
            writer.WriteStringValue(SecretName);
            if (Optional.IsDefined(SecretVersion))
            {
                writer.WritePropertyName("secretVersion");
                writer.WriteStringValue(SecretVersion);
            }
            writer.WriteEndObject();
        }

        internal static SecretValueReference DeserializeSecretValueReference(JsonElement element)
        {
            WritableSubResource keyVault = default;
            string secretName = default;
            Optional<string> secretVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVault"))
                {
                    keyVault = JsonSerializer.Deserialize<WritableSubResource>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("secretName"))
                {
                    secretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretVersion"))
                {
                    secretVersion = property.Value.GetString();
                    continue;
                }
            }
            return new SecretValueReference(keyVault, secretName, secretVersion.Value);
        }
    }
}
