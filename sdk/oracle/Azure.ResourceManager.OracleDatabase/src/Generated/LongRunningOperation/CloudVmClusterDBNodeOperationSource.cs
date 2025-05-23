// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase
{
    internal class CloudVmClusterDBNodeOperationSource : IOperationSource<CloudVmClusterDBNodeResource>
    {
        private readonly ArmClient _client;

        internal CloudVmClusterDBNodeOperationSource(ArmClient client)
        {
            _client = client;
        }

        CloudVmClusterDBNodeResource IOperationSource<CloudVmClusterDBNodeResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<CloudVmClusterDBNodeData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerOracleDatabaseContext.Default);
            return new CloudVmClusterDBNodeResource(_client, data);
        }

        async ValueTask<CloudVmClusterDBNodeResource> IOperationSource<CloudVmClusterDBNodeResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<CloudVmClusterDBNodeData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerOracleDatabaseContext.Default);
            return await Task.FromResult(new CloudVmClusterDBNodeResource(_client, data)).ConfigureAwait(false);
        }
    }
}
