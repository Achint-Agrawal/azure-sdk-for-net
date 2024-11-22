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
    public partial class Sample_CosmosDBSqlContainerCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_CosmosDBSqlContainerList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBSqlContainerList.json
            // this example is just showing the usage of "SqlResources_ListSqlContainers" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlDatabaseResource created on azure
            // for more information of creating CosmosDBSqlDatabaseResource, please refer to the document of CosmosDBSqlDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier cosmosDBSqlDatabaseResourceId = CosmosDBSqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            CosmosDBSqlDatabaseResource cosmosDBSqlDatabase = client.GetCosmosDBSqlDatabaseResource(cosmosDBSqlDatabaseResourceId);

            // get the collection of this CosmosDBSqlContainerResource
            CosmosDBSqlContainerCollection collection = cosmosDBSqlDatabase.GetCosmosDBSqlContainers();

            // invoke the operation and iterate over the result
            await foreach (CosmosDBSqlContainerResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBSqlContainerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CosmosDBSqlContainerGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBSqlContainerGet.json
            // this example is just showing the usage of "SqlResources_GetSqlContainer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlDatabaseResource created on azure
            // for more information of creating CosmosDBSqlDatabaseResource, please refer to the document of CosmosDBSqlDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier cosmosDBSqlDatabaseResourceId = CosmosDBSqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            CosmosDBSqlDatabaseResource cosmosDBSqlDatabase = client.GetCosmosDBSqlDatabaseResource(cosmosDBSqlDatabaseResourceId);

            // get the collection of this CosmosDBSqlContainerResource
            CosmosDBSqlContainerCollection collection = cosmosDBSqlDatabase.GetCosmosDBSqlContainers();

            // invoke the operation
            string containerName = "containerName";
            CosmosDBSqlContainerResource result = await collection.GetAsync(containerName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBSqlContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_CosmosDBSqlContainerGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBSqlContainerGet.json
            // this example is just showing the usage of "SqlResources_GetSqlContainer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlDatabaseResource created on azure
            // for more information of creating CosmosDBSqlDatabaseResource, please refer to the document of CosmosDBSqlDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier cosmosDBSqlDatabaseResourceId = CosmosDBSqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            CosmosDBSqlDatabaseResource cosmosDBSqlDatabase = client.GetCosmosDBSqlDatabaseResource(cosmosDBSqlDatabaseResourceId);

            // get the collection of this CosmosDBSqlContainerResource
            CosmosDBSqlContainerCollection collection = cosmosDBSqlDatabase.GetCosmosDBSqlContainers();

            // invoke the operation
            string containerName = "containerName";
            bool result = await collection.ExistsAsync(containerName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_CosmosDBSqlContainerGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBSqlContainerGet.json
            // this example is just showing the usage of "SqlResources_GetSqlContainer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlDatabaseResource created on azure
            // for more information of creating CosmosDBSqlDatabaseResource, please refer to the document of CosmosDBSqlDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier cosmosDBSqlDatabaseResourceId = CosmosDBSqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            CosmosDBSqlDatabaseResource cosmosDBSqlDatabase = client.GetCosmosDBSqlDatabaseResource(cosmosDBSqlDatabaseResourceId);

            // get the collection of this CosmosDBSqlContainerResource
            CosmosDBSqlContainerCollection collection = cosmosDBSqlDatabase.GetCosmosDBSqlContainers();

            // invoke the operation
            string containerName = "containerName";
            NullableResponse<CosmosDBSqlContainerResource> response = await collection.GetIfExistsAsync(containerName);
            CosmosDBSqlContainerResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBSqlContainerData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CosmosDBSqlContainerCreateUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBSqlContainerCreateUpdate.json
            // this example is just showing the usage of "SqlResources_CreateUpdateSqlContainer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlDatabaseResource created on azure
            // for more information of creating CosmosDBSqlDatabaseResource, please refer to the document of CosmosDBSqlDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier cosmosDBSqlDatabaseResourceId = CosmosDBSqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            CosmosDBSqlDatabaseResource cosmosDBSqlDatabase = client.GetCosmosDBSqlDatabaseResource(cosmosDBSqlDatabaseResourceId);

            // get the collection of this CosmosDBSqlContainerResource
            CosmosDBSqlContainerCollection collection = cosmosDBSqlDatabase.GetCosmosDBSqlContainers();

            // invoke the operation
            string containerName = "containerName";
            CosmosDBSqlContainerCreateOrUpdateContent content = new CosmosDBSqlContainerCreateOrUpdateContent(new AzureLocation("West US"), new CosmosDBSqlContainerResourceInfo("containerName")
            {
                IndexingPolicy = new CosmosDBIndexingPolicy()
                {
                    IsAutomatic = true,
                    IndexingMode = CosmosDBIndexingMode.Consistent,
                    IncludedPaths =
{
new CosmosDBIncludedPath()
{
Path = "/*",
Indexes =
{
new CosmosDBPathIndexes()
{
DataType = CosmosDBDataType.String,
Precision = -1,
Kind = CosmosDBIndexKind.Range,
},new CosmosDBPathIndexes()
{
DataType = CosmosDBDataType.Number,
Precision = -1,
Kind = CosmosDBIndexKind.Range,
}
},
}
},
                    ExcludedPaths =
{
},
                    VectorIndexes =
{
new VectorIndex("/vectorPath1",VectorIndexType.Flat),new VectorIndex("/vectorPath2",VectorIndexType.QuantizedFlat),new VectorIndex("/vectorPath3",VectorIndexType.DiskANN)
},
                },
                PartitionKey = new CosmosDBContainerPartitionKey()
                {
                    Paths =
{
"/AccountNumber"
},
                    Kind = CosmosDBPartitionKind.Hash,
                },
                DefaultTtl = 100,
                UniqueKeys =
{
new CosmosDBUniqueKey()
{
Paths =
{
"/testPath"
},
}
},
                ConflictResolutionPolicy = new ConflictResolutionPolicy()
                {
                    Mode = ConflictResolutionMode.LastWriterWins,
                    ConflictResolutionPath = "/path",
                },
                ClientEncryptionPolicy = new CosmosDBClientEncryptionPolicy(new CosmosDBClientEncryptionIncludedPath[]
            {
new CosmosDBClientEncryptionIncludedPath("/path","keyId","Deterministic","AEAD_AES_256_CBC_HMAC_SHA256")
            }, 2),
                ComputedProperties =
{
new ComputedProperty()
{
Name = "cp_lowerName",
Query = "SELECT VALUE LOWER(c.name) FROM c",
}
},
                VectorEmbeddings =
{
new VectorEmbedding("/vectorPath1",VectorDataType.Float32,DistanceFunction.Euclidean,400),new VectorEmbedding("/vectorPath2",VectorDataType.Uint8,DistanceFunction.Cosine,512),new VectorEmbedding("/vectorPath3",VectorDataType.Int8,DistanceFunction.Dotproduct,512)
},
            })
            {
                Options = new CosmosDBCreateUpdateConfig(),
                Tags =
{
},
            };
            ArmOperation<CosmosDBSqlContainerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, containerName, content);
            CosmosDBSqlContainerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBSqlContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CosmosDBSqlContainerRestore()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBSqlContainerRestore.json
            // this example is just showing the usage of "SqlResources_CreateUpdateSqlContainer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlDatabaseResource created on azure
            // for more information of creating CosmosDBSqlDatabaseResource, please refer to the document of CosmosDBSqlDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier cosmosDBSqlDatabaseResourceId = CosmosDBSqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            CosmosDBSqlDatabaseResource cosmosDBSqlDatabase = client.GetCosmosDBSqlDatabaseResource(cosmosDBSqlDatabaseResourceId);

            // get the collection of this CosmosDBSqlContainerResource
            CosmosDBSqlContainerCollection collection = cosmosDBSqlDatabase.GetCosmosDBSqlContainers();

            // invoke the operation
            string containerName = "containerName";
            CosmosDBSqlContainerCreateOrUpdateContent content = new CosmosDBSqlContainerCreateOrUpdateContent(new AzureLocation("West US"), new CosmosDBSqlContainerResourceInfo("containerName")
            {
                RestoreParameters = new ResourceRestoreParameters()
                {
                    RestoreSource = "/subscriptions/subid/providers/Microsoft.DocumentDB/locations/WestUS/restorableDatabaseAccounts/restorableDatabaseAccountId",
                    RestoreTimestampInUtc = DateTimeOffset.Parse("2022-07-20T18:28:00Z"),
                    IsRestoreWithTtlDisabled = true,
                },
                CreateMode = CosmosDBAccountCreateMode.Restore,
            })
            {
                Options = new CosmosDBCreateUpdateConfig(),
                Tags =
{
},
            };
            ArmOperation<CosmosDBSqlContainerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, containerName, content);
            CosmosDBSqlContainerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBSqlContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CosmosDBSqlMaterializedViewCreateUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBSqlMaterializedViewCreateUpdate.json
            // this example is just showing the usage of "SqlResources_CreateUpdateSqlContainer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlDatabaseResource created on azure
            // for more information of creating CosmosDBSqlDatabaseResource, please refer to the document of CosmosDBSqlDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier cosmosDBSqlDatabaseResourceId = CosmosDBSqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            CosmosDBSqlDatabaseResource cosmosDBSqlDatabase = client.GetCosmosDBSqlDatabaseResource(cosmosDBSqlDatabaseResourceId);

            // get the collection of this CosmosDBSqlContainerResource
            CosmosDBSqlContainerCollection collection = cosmosDBSqlDatabase.GetCosmosDBSqlContainers();

            // invoke the operation
            string containerName = "mvContainerName";
            CosmosDBSqlContainerCreateOrUpdateContent content = new CosmosDBSqlContainerCreateOrUpdateContent(new AzureLocation("West US"), new CosmosDBSqlContainerResourceInfo("mvContainerName")
            {
                IndexingPolicy = new CosmosDBIndexingPolicy()
                {
                    IsAutomatic = true,
                    IndexingMode = CosmosDBIndexingMode.Consistent,
                    IncludedPaths =
{
new CosmosDBIncludedPath()
{
Path = "/*",
Indexes =
{
new CosmosDBPathIndexes()
{
DataType = CosmosDBDataType.String,
Precision = -1,
Kind = CosmosDBIndexKind.Range,
},new CosmosDBPathIndexes()
{
DataType = CosmosDBDataType.Number,
Precision = -1,
Kind = CosmosDBIndexKind.Range,
}
},
}
},
                    ExcludedPaths =
{
},
                },
                PartitionKey = new CosmosDBContainerPartitionKey()
                {
                    Paths =
{
"/mvpk"
},
                    Kind = CosmosDBPartitionKind.Hash,
                },
                MaterializedViewDefinition = new MaterializedViewDefinition("sourceContainerName", "select * from ROOT"),
            })
            {
                Options = new CosmosDBCreateUpdateConfig(),
                Tags =
{
},
            };
            ArmOperation<CosmosDBSqlContainerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, containerName, content);
            CosmosDBSqlContainerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBSqlContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
