// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers
{
    internal class ContainerAppConnectedEnvironmentOperationSource : IOperationSource<ContainerAppConnectedEnvironmentResource>
    {
        private readonly ArmClient _client;

        internal ContainerAppConnectedEnvironmentOperationSource(ArmClient client)
        {
            _client = client;
        }

        ContainerAppConnectedEnvironmentResource IOperationSource<ContainerAppConnectedEnvironmentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ContainerAppConnectedEnvironmentData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerAppContainersContext.Default);
            return new ContainerAppConnectedEnvironmentResource(_client, data);
        }

        async ValueTask<ContainerAppConnectedEnvironmentResource> IOperationSource<ContainerAppConnectedEnvironmentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ContainerAppConnectedEnvironmentData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerAppContainersContext.Default);
            return await Task.FromResult(new ContainerAppConnectedEnvironmentResource(_client, data)).ConfigureAwait(false);
        }
    }
}
