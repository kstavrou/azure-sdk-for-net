// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LinkTableRequestTargetConverter))]
    public partial class LinkTableRequestTarget : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TableName))
            {
                writer.WritePropertyName("tableName");
                writer.WriteStringValue(TableName);
            }
            if (Optional.IsDefined(SchemaName))
            {
                writer.WritePropertyName("schemaName");
                writer.WriteStringValue(SchemaName);
            }
            if (Optional.IsDefined(DistributionOptions))
            {
                writer.WritePropertyName("distributionOptions");
                writer.WriteObjectValue(DistributionOptions);
            }
            writer.WriteEndObject();
        }

        internal static LinkTableRequestTarget DeserializeLinkTableRequestTarget(JsonElement element)
        {
            Optional<string> tableName = default;
            Optional<string> schemaName = default;
            Optional<LinkTableRequestTargetDistributionOptions> distributionOptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tableName"))
                {
                    tableName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaName"))
                {
                    schemaName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("distributionOptions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    distributionOptions = LinkTableRequestTargetDistributionOptions.DeserializeLinkTableRequestTargetDistributionOptions(property.Value);
                    continue;
                }
            }
            return new LinkTableRequestTarget(tableName.Value, schemaName.Value, distributionOptions.Value);
        }

        internal partial class LinkTableRequestTargetConverter : JsonConverter<LinkTableRequestTarget>
        {
            public override void Write(Utf8JsonWriter writer, LinkTableRequestTarget model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LinkTableRequestTarget Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkTableRequestTarget(document.RootElement);
            }
        }
    }
}
