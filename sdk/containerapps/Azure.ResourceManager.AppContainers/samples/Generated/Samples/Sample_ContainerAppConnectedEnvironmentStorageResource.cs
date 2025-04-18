// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppContainers.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppConnectedEnvironmentStorageResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAEnvironmentsStoragePropertiesBySubscription()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/ConnectedEnvironmentsStorages_Get.json
            // this example is just showing the usage of "ConnectedEnvironmentsStorages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentStorageResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentStorageResource, please refer to the document of ContainerAppConnectedEnvironmentStorageResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "env";
            string storageName = "jlaw-demo1";
            ResourceIdentifier containerAppConnectedEnvironmentStorageResourceId = ContainerAppConnectedEnvironmentStorageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName, storageName);
            ContainerAppConnectedEnvironmentStorageResource containerAppConnectedEnvironmentStorage = client.GetContainerAppConnectedEnvironmentStorageResource(containerAppConnectedEnvironmentStorageResourceId);

            // invoke the operation
            ContainerAppConnectedEnvironmentStorageResource result = await containerAppConnectedEnvironmentStorage.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppConnectedEnvironmentStorageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ListEnvironmentsStoragesBySubscription()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/ConnectedEnvironmentsStorages_Delete.json
            // this example is just showing the usage of "ConnectedEnvironmentsStorages_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentStorageResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentStorageResource, please refer to the document of ContainerAppConnectedEnvironmentStorageResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "env";
            string storageName = "jlaw-demo1";
            ResourceIdentifier containerAppConnectedEnvironmentStorageResourceId = ContainerAppConnectedEnvironmentStorageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName, storageName);
            ContainerAppConnectedEnvironmentStorageResource containerAppConnectedEnvironmentStorage = client.GetContainerAppConnectedEnvironmentStorageResource(containerAppConnectedEnvironmentStorageResourceId);

            // invoke the operation
            await containerAppConnectedEnvironmentStorage.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateEnvironmentsStorage()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/ConnectedEnvironmentsStorages_CreateOrUpdate.json
            // this example is just showing the usage of "ConnectedEnvironmentsStorages_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentStorageResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentStorageResource, please refer to the document of ContainerAppConnectedEnvironmentStorageResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "env";
            string storageName = "jlaw-demo1";
            ResourceIdentifier containerAppConnectedEnvironmentStorageResourceId = ContainerAppConnectedEnvironmentStorageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName, storageName);
            ContainerAppConnectedEnvironmentStorageResource containerAppConnectedEnvironmentStorage = client.GetContainerAppConnectedEnvironmentStorageResource(containerAppConnectedEnvironmentStorageResourceId);

            // invoke the operation
            ContainerAppConnectedEnvironmentStorageData data = new ContainerAppConnectedEnvironmentStorageData
            {
                ConnectedEnvironmentStorageAzureFile = new ContainerAppAzureFileProperties
                {
                    AccountName = "account1",
                    AccountKey = "key",
                    AccessMode = ContainerAppAccessMode.ReadOnly,
                    ShareName = "share1",
                },
            };
            ArmOperation<ContainerAppConnectedEnvironmentStorageResource> lro = await containerAppConnectedEnvironmentStorage.UpdateAsync(WaitUntil.Completed, data);
            ContainerAppConnectedEnvironmentStorageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppConnectedEnvironmentStorageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
