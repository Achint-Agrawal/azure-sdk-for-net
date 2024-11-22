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
    public partial class Sample_GremlinGraphResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CosmosDBGremlinGraphGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBGremlinGraphGet.json
            // this example is just showing the usage of "GremlinResources_GetGremlinGraph" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GremlinGraphResource created on azure
            // for more information of creating GremlinGraphResource, please refer to the document of GremlinGraphResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string graphName = "graphName";
            ResourceIdentifier gremlinGraphResourceId = GremlinGraphResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, graphName);
            GremlinGraphResource gremlinGraph = client.GetGremlinGraphResource(gremlinGraphResourceId);

            // invoke the operation
            GremlinGraphResource result = await gremlinGraph.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GremlinGraphData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CosmosDBGremlinGraphCreateUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBGremlinGraphCreateUpdate.json
            // this example is just showing the usage of "GremlinResources_CreateUpdateGremlinGraph" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GremlinGraphResource created on azure
            // for more information of creating GremlinGraphResource, please refer to the document of GremlinGraphResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string graphName = "graphName";
            ResourceIdentifier gremlinGraphResourceId = GremlinGraphResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, graphName);
            GremlinGraphResource gremlinGraph = client.GetGremlinGraphResource(gremlinGraphResourceId);

            // invoke the operation
            GremlinGraphCreateOrUpdateContent content = new GremlinGraphCreateOrUpdateContent(new AzureLocation("West US"), new GremlinGraphResourceInfo("graphName")
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
            })
            {
                Options = new CosmosDBCreateUpdateConfig(),
                Tags =
{
},
            };
            ArmOperation<GremlinGraphResource> lro = await gremlinGraph.UpdateAsync(WaitUntil.Completed, content);
            GremlinGraphResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GremlinGraphData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_CosmosDBGremlinGraphDelete()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBGremlinGraphDelete.json
            // this example is just showing the usage of "GremlinResources_DeleteGremlinGraph" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GremlinGraphResource created on azure
            // for more information of creating GremlinGraphResource, please refer to the document of GremlinGraphResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string graphName = "graphName";
            ResourceIdentifier gremlinGraphResourceId = GremlinGraphResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, graphName);
            GremlinGraphResource gremlinGraph = client.GetGremlinGraphResource(gremlinGraphResourceId);

            // invoke the operation
            await gremlinGraph.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task RetrieveContinuousBackupInformation_CosmosDBGremlinGraphBackupInformation()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBGremlinGraphBackupInformation.json
            // this example is just showing the usage of "GremlinResources_RetrieveContinuousBackupInformation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GremlinGraphResource created on azure
            // for more information of creating GremlinGraphResource, please refer to the document of GremlinGraphResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string graphName = "graphName";
            ResourceIdentifier gremlinGraphResourceId = GremlinGraphResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, graphName);
            GremlinGraphResource gremlinGraph = client.GetGremlinGraphResource(gremlinGraphResourceId);

            // invoke the operation
            ContinuousBackupRestoreLocation location = new ContinuousBackupRestoreLocation()
            {
                Location = new AzureLocation("North Europe"),
            };
            ArmOperation<CosmosDBBackupInformation> lro = await gremlinGraph.RetrieveContinuousBackupInformationAsync(WaitUntil.Completed, location);
            CosmosDBBackupInformation result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
