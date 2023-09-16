// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.CosmosDB;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_CosmosDBSqlDatabaseCollection
    {
        // CosmosDBSqlDatabaseList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_CosmosDBSqlDatabaseList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2023-09-15-preview/examples/CosmosDBSqlDatabaseList.json
            // this example is just showing the usage of "SqlResources_ListSqlDatabases" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this CosmosDBSqlDatabaseResource
            CosmosDBSqlDatabaseCollection collection = cosmosDBAccount.GetCosmosDBSqlDatabases();

            // invoke the operation and iterate over the result
            await foreach (CosmosDBSqlDatabaseResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBSqlDatabaseData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBSqlDatabaseGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBSqlDatabaseGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2023-09-15-preview/examples/CosmosDBSqlDatabaseGet.json
            // this example is just showing the usage of "SqlResources_GetSqlDatabase" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this CosmosDBSqlDatabaseResource
            CosmosDBSqlDatabaseCollection collection = cosmosDBAccount.GetCosmosDBSqlDatabases();

            // invoke the operation
            string databaseName = "databaseName";
            CosmosDBSqlDatabaseResource result = await collection.GetAsync(databaseName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBSqlDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBSqlDatabaseGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_CosmosDBSqlDatabaseGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2023-09-15-preview/examples/CosmosDBSqlDatabaseGet.json
            // this example is just showing the usage of "SqlResources_GetSqlDatabase" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this CosmosDBSqlDatabaseResource
            CosmosDBSqlDatabaseCollection collection = cosmosDBAccount.GetCosmosDBSqlDatabases();

            // invoke the operation
            string databaseName = "databaseName";
            bool result = await collection.ExistsAsync(databaseName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // CosmosDBSqlDatabaseCreateUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CosmosDBSqlDatabaseCreateUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2023-09-15-preview/examples/CosmosDBSqlDatabaseCreateUpdate.json
            // this example is just showing the usage of "SqlResources_CreateUpdateSqlDatabase" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this CosmosDBSqlDatabaseResource
            CosmosDBSqlDatabaseCollection collection = cosmosDBAccount.GetCosmosDBSqlDatabases();

            // invoke the operation
            string databaseName = "databaseName";
            CosmosDBSqlDatabaseCreateOrUpdateContent content = new CosmosDBSqlDatabaseCreateOrUpdateContent(new AzureLocation("West US"), new CosmosDBSqlDatabaseResourceInfo("databaseName"))
            {
                Options = new CosmosDBCreateUpdateConfig(),
                Tags =
{
},
            };
            ArmOperation<CosmosDBSqlDatabaseResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, databaseName, content);
            CosmosDBSqlDatabaseResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBSqlDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBSqlDatabaseRestore
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CosmosDBSqlDatabaseRestore()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2023-09-15-preview/examples/CosmosDBSqlDatabaseRestore.json
            // this example is just showing the usage of "SqlResources_CreateUpdateSqlDatabase" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this CosmosDBSqlDatabaseResource
            CosmosDBSqlDatabaseCollection collection = cosmosDBAccount.GetCosmosDBSqlDatabases();

            // invoke the operation
            string databaseName = "databaseName";
            CosmosDBSqlDatabaseCreateOrUpdateContent content = new CosmosDBSqlDatabaseCreateOrUpdateContent(new AzureLocation("West US"), new CosmosDBSqlDatabaseResourceInfo("databaseName")
            {
                RestoreParameters = new ResourceRestoreParameters()
                {
                    RestoreSource = "/subscriptions/subid/providers/Microsoft.DocumentDB/locations/WestUS/restorableDatabaseAccounts/restorableDatabaseAccountId",
                    RestoreTimestampInUtc = DateTimeOffset.Parse("2022-07-20T18:28:00Z"),
                },
                CreateMode = CosmosDBAccountCreateMode.Restore,
            })
            {
                Options = new CosmosDBCreateUpdateConfig(),
                Tags =
{
},
            };
            ArmOperation<CosmosDBSqlDatabaseResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, databaseName, content);
            CosmosDBSqlDatabaseResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBSqlDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
