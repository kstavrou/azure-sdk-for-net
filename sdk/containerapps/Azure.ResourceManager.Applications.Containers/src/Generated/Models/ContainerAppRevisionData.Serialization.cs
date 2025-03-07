// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Applications.Containers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Applications.Containers
{
    public partial class ContainerAppRevisionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ContainerAppRevisionData DeserializeContainerAppRevisionData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<string> fqdn = default;
            Optional<ContainerAppTemplate> template = default;
            Optional<bool> active = default;
            Optional<int> replicas = default;
            Optional<int> trafficWeight = default;
            Optional<string> provisioningError = default;
            Optional<RevisionHealthState> healthState = default;
            Optional<RevisionProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("createdTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("fqdn"))
                        {
                            fqdn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("template"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            template = ContainerAppTemplate.DeserializeContainerAppTemplate(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("active"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            active = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("replicas"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            replicas = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("trafficWeight"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            trafficWeight = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("provisioningError"))
                        {
                            provisioningError = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("healthState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            healthState = new RevisionHealthState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new RevisionProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ContainerAppRevisionData(id, name, type, systemData, Optional.ToNullable(createdTime), fqdn.Value, template.Value, Optional.ToNullable(active), Optional.ToNullable(replicas), Optional.ToNullable(trafficWeight), provisioningError.Value, Optional.ToNullable(healthState), Optional.ToNullable(provisioningState));
        }
    }
}
