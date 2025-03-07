// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class ServerAutomaticTuningData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(DesiredState))
            {
                writer.WritePropertyName("desiredState");
                writer.WriteStringValue(DesiredState.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(Options))
            {
                writer.WritePropertyName("options");
                writer.WriteStartObject();
                foreach (var item in Options)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ServerAutomaticTuningData DeserializeServerAutomaticTuningData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<AutomaticTuningServerMode> desiredState = default;
            Optional<AutomaticTuningServerMode> actualState = default;
            Optional<IDictionary<string, AutomaticTuningServerOptions>> options = default;
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
                        if (property0.NameEquals("desiredState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            desiredState = property0.Value.GetString().ToAutomaticTuningServerMode();
                            continue;
                        }
                        if (property0.NameEquals("actualState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            actualState = property0.Value.GetString().ToAutomaticTuningServerMode();
                            continue;
                        }
                        if (property0.NameEquals("options"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, AutomaticTuningServerOptions> dictionary = new Dictionary<string, AutomaticTuningServerOptions>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, AutomaticTuningServerOptions.DeserializeAutomaticTuningServerOptions(property1.Value));
                            }
                            options = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ServerAutomaticTuningData(id, name, type, systemData, Optional.ToNullable(desiredState), Optional.ToNullable(actualState), Optional.ToDictionary(options));
        }
    }
}
