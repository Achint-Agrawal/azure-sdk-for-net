// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CosmosDB.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_GremlinDatabaseCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_CosmosDBGremlinDatabaseList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBGremlinDatabaseList.json
            // this example is just showing the usage of "GremlinResources_ListGremlinDatabases" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBAccountResource created on azure
            // for more information of creating CosmosDBAccountResource, please refer to the document of CosmosDBAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            ResourceIdentifier cosmosDBAccountResourceId = CosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CosmosDBAccountResource cosmosDBAccount = client.GetCosmosDBAccountResource(cosmosDBAccountResourceId);

            // get the collection of this GremlinDatabaseResource
            GremlinDatabaseCollection collection = cosmosDBAccount.GetGremlinDatabases();

            // invoke the operation and iterate over the result
            await foreach (GremlinDatabaseResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GremlinDatabaseData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CosmosDBGremlinDatabaseGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBGremlinDatabaseGet.json
            // this example is just showing the usage of "GremlinResources_GetGremlinDatabase" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBAccountResource created on azure
            // for more information of creating CosmosDBAccountResource, please refer to the document of CosmosDBAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            ResourceIdentifier cosmosDBAccountResourceId = CosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CosmosDBAccountResource cosmosDBAccount = client.GetCosmosDBAccountResource(cosmosDBAccountResourceId);

            // get the collection of this GremlinDatabaseResource
            GremlinDatabaseCollection collection = cosmosDBAccount.GetGremlinDatabases();

            // invoke the operation
            string databaseName = "databaseName";
            GremlinDatabaseResource result = await collection.GetAsync(databaseName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GremlinDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_CosmosDBGremlinDatabaseGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBGremlinDatabaseGet.json
            // this example is just showing the usage of "GremlinResources_GetGremlinDatabase" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBAccountResource created on azure
            // for more information of creating CosmosDBAccountResource, please refer to the document of CosmosDBAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            ResourceIdentifier cosmosDBAccountResourceId = CosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CosmosDBAccountResource cosmosDBAccount = client.GetCosmosDBAccountResource(cosmosDBAccountResourceId);

            // get the collection of this GremlinDatabaseResource
            GremlinDatabaseCollection collection = cosmosDBAccount.GetGremlinDatabases();

            // invoke the operation
            string databaseName = "databaseName";
            bool result = await collection.ExistsAsync(databaseName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_CosmosDBGremlinDatabaseGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBGremlinDatabaseGet.json
            // this example is just showing the usage of "GremlinResources_GetGremlinDatabase" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBAccountResource created on azure
            // for more information of creating CosmosDBAccountResource, please refer to the document of CosmosDBAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            ResourceIdentifier cosmosDBAccountResourceId = CosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CosmosDBAccountResource cosmosDBAccount = client.GetCosmosDBAccountResource(cosmosDBAccountResourceId);

            // get the collection of this GremlinDatabaseResource
            GremlinDatabaseCollection collection = cosmosDBAccount.GetGremlinDatabases();

            // invoke the operation
            string databaseName = "databaseName";
            NullableResponse<GremlinDatabaseResource> response = await collection.GetIfExistsAsync(databaseName);
            GremlinDatabaseResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GremlinDatabaseData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CosmosDBGremlinDatabaseCreateUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBGremlinDatabaseCreateUpdate.json
            // this example is just showing the usage of "GremlinResources_CreateUpdateGremlinDatabase" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBAccountResource created on azure
            // for more information of creating CosmosDBAccountResource, please refer to the document of CosmosDBAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            ResourceIdentifier cosmosDBAccountResourceId = CosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CosmosDBAccountResource cosmosDBAccount = client.GetCosmosDBAccountResource(cosmosDBAccountResourceId);

            // get the collection of this GremlinDatabaseResource
            GremlinDatabaseCollection collection = cosmosDBAccount.GetGremlinDatabases();

            // invoke the operation
            string databaseName = "databaseName";
            GremlinDatabaseCreateOrUpdateContent content = new GremlinDatabaseCreateOrUpdateContent(new AzureLocation("West US"), new GremlinDatabaseResourceInfo("databaseName"))
            {
                Options = new CosmosDBCreateUpdateConfig(),
                Tags =
{
},
            };
            ArmOperation<GremlinDatabaseResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, databaseName, content);
            GremlinDatabaseResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GremlinDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
