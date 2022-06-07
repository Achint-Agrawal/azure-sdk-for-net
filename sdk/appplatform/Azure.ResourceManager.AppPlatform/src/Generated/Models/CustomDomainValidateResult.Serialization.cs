// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class CustomDomainValidateResult
    {
        internal static CustomDomainValidateResult DeserializeCustomDomainValidateResult(JsonElement element)
        {
            Optional<bool> isValid = default;
            Optional<string> message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isValid"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isValid = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new CustomDomainValidateResult(Optional.ToNullable(isValid), message.Value);
        }
    }
}
