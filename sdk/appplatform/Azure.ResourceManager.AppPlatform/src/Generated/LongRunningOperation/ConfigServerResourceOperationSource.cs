// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppPlatform
{
    internal class ConfigServerResourceOperationSource : IOperationSource<ConfigServerResource>
    {
        private readonly ArmClient _client;

        internal ConfigServerResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        ConfigServerResource IOperationSource<ConfigServerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ConfigServerResourceData.DeserializeConfigServerResourceData(document.RootElement);
            return new ConfigServerResource(_client, data);
        }

        async ValueTask<ConfigServerResource> IOperationSource<ConfigServerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ConfigServerResourceData.DeserializeConfigServerResourceData(document.RootElement);
            return new ConfigServerResource(_client, data);
        }
    }
}
