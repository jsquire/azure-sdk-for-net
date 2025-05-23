// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HealthcareApis.Models;
using Azure.ResourceManager.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.HealthcareApis.Samples
{
    public partial class Sample_FhirServiceCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateAFhirService()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/fhirservices/FhirServices_Create.json
            // this example is just showing the usage of "FhirServices_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisWorkspaceResource created on azure
            // for more information of creating HealthcareApisWorkspaceResource, please refer to the document of HealthcareApisWorkspaceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            ResourceIdentifier healthcareApisWorkspaceResourceId = HealthcareApisWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            HealthcareApisWorkspaceResource healthcareApisWorkspace = client.GetHealthcareApisWorkspaceResource(healthcareApisWorkspaceResourceId);

            // get the collection of this FhirServiceResource
            FhirServiceCollection collection = healthcareApisWorkspace.GetFhirServices();

            // invoke the operation
            string fhirServiceName = "fhirservice1";
            FhirServiceData data = new FhirServiceData(new AzureLocation("westus"))
            {
                Kind = FhirServiceKind.FhirR4,
                AcrConfiguration = new FhirServiceAcrConfiguration
                {
                    LoginServers = { "test1.azurecr.io" },
                },
                AuthenticationConfiguration = new FhirServiceAuthenticationConfiguration
                {
                    Authority = "https://login.microsoftonline.com/abfde7b2-df0f-47e6-aabf-2462b07508dc",
                    Audience = "https://azurehealthcareapis.com",
                    IsSmartProxyEnabled = true,
                    SmartIdentityProviders = {new SmartIdentityProviderConfiguration
{
Authority = "https://login.b2clogin.com/11111111-1111-1111-1111-111111111111/v2.0",
Applications = {new SmartIdentityProviderApplication
{
ClientId = "22222222-2222-2222-2222-222222222222",
Audience = "22222222-2222-2222-2222-222222222222",
AllowedDataActions = {SmartDataAction.Read},
}},
}},
                },
                CorsConfiguration = new FhirServiceCorsConfiguration
                {
                    Origins = { "*" },
                    Headers = { "*" },
                    Methods = { "DELETE", "GET", "OPTIONS", "PATCH", "POST", "PUT" },
                    MaxAge = 1440,
                    AllowCredentials = false,
                },
                ExportStorageAccountName = "existingStorageAccount",
                ImportConfiguration = new FhirServiceImportConfiguration
                {
                    IntegrationDataStore = "existingStorageAccount",
                    IsInitialImportMode = false,
                    IsEnabled = false,
                },
                IsUsCoreMissingDataEnabled = false,
                KeyEncryptionKeyUri = new Uri("https://mykeyvault.vault.azure.net/keys/myEncryptionKey/myKeyVersion"),
                Identity = new ManagedServiceIdentity("UserAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/subid/resourcegroups/testRG/providers/Microsoft.ManagedIdentity/userAssignedIdentities/test-mi")] = new UserAssignedIdentity()
},
                },
                Tags =
{
["additionalProp1"] = "string",
["additionalProp2"] = "string",
["additionalProp3"] = "string"
},
            };
            ArmOperation<FhirServiceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, fhirServiceName, data);
            FhirServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FhirServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAFhirService()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/fhirservices/FhirServices_Get.json
            // this example is just showing the usage of "FhirServices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisWorkspaceResource created on azure
            // for more information of creating HealthcareApisWorkspaceResource, please refer to the document of HealthcareApisWorkspaceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            ResourceIdentifier healthcareApisWorkspaceResourceId = HealthcareApisWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            HealthcareApisWorkspaceResource healthcareApisWorkspace = client.GetHealthcareApisWorkspaceResource(healthcareApisWorkspaceResourceId);

            // get the collection of this FhirServiceResource
            FhirServiceCollection collection = healthcareApisWorkspace.GetFhirServices();

            // invoke the operation
            string fhirServiceName = "fhirservices1";
            FhirServiceResource result = await collection.GetAsync(fhirServiceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FhirServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListFhirservices()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/fhirservices/FhirServices_List.json
            // this example is just showing the usage of "FhirServices_ListByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisWorkspaceResource created on azure
            // for more information of creating HealthcareApisWorkspaceResource, please refer to the document of HealthcareApisWorkspaceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            ResourceIdentifier healthcareApisWorkspaceResourceId = HealthcareApisWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            HealthcareApisWorkspaceResource healthcareApisWorkspace = client.GetHealthcareApisWorkspaceResource(healthcareApisWorkspaceResourceId);

            // get the collection of this FhirServiceResource
            FhirServiceCollection collection = healthcareApisWorkspace.GetFhirServices();

            // invoke the operation and iterate over the result
            await foreach (FhirServiceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FhirServiceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAFhirService()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/fhirservices/FhirServices_Get.json
            // this example is just showing the usage of "FhirServices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisWorkspaceResource created on azure
            // for more information of creating HealthcareApisWorkspaceResource, please refer to the document of HealthcareApisWorkspaceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            ResourceIdentifier healthcareApisWorkspaceResourceId = HealthcareApisWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            HealthcareApisWorkspaceResource healthcareApisWorkspace = client.GetHealthcareApisWorkspaceResource(healthcareApisWorkspaceResourceId);

            // get the collection of this FhirServiceResource
            FhirServiceCollection collection = healthcareApisWorkspace.GetFhirServices();

            // invoke the operation
            string fhirServiceName = "fhirservices1";
            bool result = await collection.ExistsAsync(fhirServiceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAFhirService()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/fhirservices/FhirServices_Get.json
            // this example is just showing the usage of "FhirServices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisWorkspaceResource created on azure
            // for more information of creating HealthcareApisWorkspaceResource, please refer to the document of HealthcareApisWorkspaceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            ResourceIdentifier healthcareApisWorkspaceResourceId = HealthcareApisWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            HealthcareApisWorkspaceResource healthcareApisWorkspace = client.GetHealthcareApisWorkspaceResource(healthcareApisWorkspaceResourceId);

            // get the collection of this FhirServiceResource
            FhirServiceCollection collection = healthcareApisWorkspace.GetFhirServices();

            // invoke the operation
            string fhirServiceName = "fhirservices1";
            NullableResponse<FhirServiceResource> response = await collection.GetIfExistsAsync(fhirServiceName);
            FhirServiceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FhirServiceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
