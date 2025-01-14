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

namespace Azure.ResourceManager.LoadTesting
{
    internal class LoadTestingOperationSource : IOperationSource<LoadTestingResource>
    {
        private readonly ArmClient _client;

        internal LoadTestingOperationSource(ArmClient client)
        {
            _client = client;
        }

        LoadTestingResource IOperationSource<LoadTestingResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = LoadTestingData.DeserializeLoadTestingData(document.RootElement);
            return new LoadTestingResource(_client, data);
        }

        async ValueTask<LoadTestingResource> IOperationSource<LoadTestingResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = LoadTestingData.DeserializeLoadTestingData(document.RootElement);
            return new LoadTestingResource(_client, data);
        }
    }
}
