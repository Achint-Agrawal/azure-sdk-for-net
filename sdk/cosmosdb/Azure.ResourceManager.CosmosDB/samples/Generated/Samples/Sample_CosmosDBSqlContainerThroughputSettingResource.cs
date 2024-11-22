// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_CosmosDBSqlContainerThroughputSettingResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CosmosDBSqlContainerThroughputGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBSqlContainerThroughputGet.json
            // this example is just showing the usage of "SqlResources_GetSqlContainerThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlContainerThroughputSettingResource created on azure
            // for more information of creating CosmosDBSqlContainerThroughputSettingResource, please refer to the document of CosmosDBSqlContainerThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            ResourceIdentifier cosmosDBSqlContainerThroughputSettingResourceId = CosmosDBSqlContainerThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName);
            CosmosDBSqlContainerThroughputSettingResource cosmosDBSqlContainerThroughputSetting = client.GetCosmosDBSqlContainerThroughputSettingResource(cosmosDBSqlContainerThroughputSettingResourceId);

            // invoke the operation
            CosmosDBSqlContainerThroughputSettingResource result = await cosmosDBSqlContainerThroughputSetting.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CosmosDBSqlContainerThroughputUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBSqlContainerThroughputUpdate.json
            // this example is just showing the usage of "SqlResources_UpdateSqlContainerThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlContainerThroughputSettingResource created on azure
            // for more information of creating CosmosDBSqlContainerThroughputSettingResource, please refer to the document of CosmosDBSqlContainerThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            ResourceIdentifier cosmosDBSqlContainerThroughputSettingResourceId = CosmosDBSqlContainerThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName);
            CosmosDBSqlContainerThroughputSettingResource cosmosDBSqlContainerThroughputSetting = client.GetCosmosDBSqlContainerThroughputSettingResource(cosmosDBSqlContainerThroughputSettingResourceId);

            // invoke the operation
            ThroughputSettingsUpdateData data = new ThroughputSettingsUpdateData(new AzureLocation("West US"), new ThroughputSettingsResourceInfo()
            {
                Throughput = 400,
            })
            {
                Tags =
{
},
            };
            ArmOperation<CosmosDBSqlContainerThroughputSettingResource> lro = await cosmosDBSqlContainerThroughputSetting.CreateOrUpdateAsync(WaitUntil.Completed, data);
            CosmosDBSqlContainerThroughputSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task MigrateSqlContainerToAutoscale_CosmosDBSqlContainerMigrateToAutoscale()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBSqlContainerMigrateToAutoscale.json
            // this example is just showing the usage of "SqlResources_MigrateSqlContainerToAutoscale" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlContainerThroughputSettingResource created on azure
            // for more information of creating CosmosDBSqlContainerThroughputSettingResource, please refer to the document of CosmosDBSqlContainerThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            ResourceIdentifier cosmosDBSqlContainerThroughputSettingResourceId = CosmosDBSqlContainerThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName);
            CosmosDBSqlContainerThroughputSettingResource cosmosDBSqlContainerThroughputSetting = client.GetCosmosDBSqlContainerThroughputSettingResource(cosmosDBSqlContainerThroughputSettingResourceId);

            // invoke the operation
            ArmOperation<CosmosDBSqlContainerThroughputSettingResource> lro = await cosmosDBSqlContainerThroughputSetting.MigrateSqlContainerToAutoscaleAsync(WaitUntil.Completed);
            CosmosDBSqlContainerThroughputSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task MigrateSqlContainerToManualThroughput_CosmosDBSqlContainerMigrateToManualThroughput()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBSqlContainerMigrateToManualThroughput.json
            // this example is just showing the usage of "SqlResources_MigrateSqlContainerToManualThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlContainerThroughputSettingResource created on azure
            // for more information of creating CosmosDBSqlContainerThroughputSettingResource, please refer to the document of CosmosDBSqlContainerThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            ResourceIdentifier cosmosDBSqlContainerThroughputSettingResourceId = CosmosDBSqlContainerThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName);
            CosmosDBSqlContainerThroughputSettingResource cosmosDBSqlContainerThroughputSetting = client.GetCosmosDBSqlContainerThroughputSettingResource(cosmosDBSqlContainerThroughputSettingResourceId);

            // invoke the operation
            ArmOperation<CosmosDBSqlContainerThroughputSettingResource> lro = await cosmosDBSqlContainerThroughputSetting.MigrateSqlContainerToManualThroughputAsync(WaitUntil.Completed);
            CosmosDBSqlContainerThroughputSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task SqlContainerRetrieveThroughputDistribution_CosmosDBSqlContainerRetrieveThroughputDistribution()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBSqlContainerRetrieveThroughputDistribution.json
            // this example is just showing the usage of "SqlResources_SqlContainerRetrieveThroughputDistribution" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlContainerThroughputSettingResource created on azure
            // for more information of creating CosmosDBSqlContainerThroughputSettingResource, please refer to the document of CosmosDBSqlContainerThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            ResourceIdentifier cosmosDBSqlContainerThroughputSettingResourceId = CosmosDBSqlContainerThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName);
            CosmosDBSqlContainerThroughputSettingResource cosmosDBSqlContainerThroughputSetting = client.GetCosmosDBSqlContainerThroughputSettingResource(cosmosDBSqlContainerThroughputSettingResourceId);

            // invoke the operation
            RetrieveThroughputParameters retrieveThroughputParameters = new RetrieveThroughputParameters(new AzureLocation("placeholder"), new RetrieveThroughputPropertiesResource(new WritableSubResource[]
            {
new WritableSubResource()
{
Id = new ResourceIdentifier("0"),
},new WritableSubResource()
{
Id = new ResourceIdentifier("1"),
}
            }));
            ArmOperation<PhysicalPartitionThroughputInfoResult> lro = await cosmosDBSqlContainerThroughputSetting.SqlContainerRetrieveThroughputDistributionAsync(WaitUntil.Completed, retrieveThroughputParameters);
            PhysicalPartitionThroughputInfoResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task SqlContainerRedistributeThroughput_CosmosDBSqlContainerRedistributeThroughput()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBSqlContainerRedistributeThroughput.json
            // this example is just showing the usage of "SqlResources_SqlContainerRedistributeThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlContainerThroughputSettingResource created on azure
            // for more information of creating CosmosDBSqlContainerThroughputSettingResource, please refer to the document of CosmosDBSqlContainerThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            ResourceIdentifier cosmosDBSqlContainerThroughputSettingResourceId = CosmosDBSqlContainerThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName);
            CosmosDBSqlContainerThroughputSettingResource cosmosDBSqlContainerThroughputSetting = client.GetCosmosDBSqlContainerThroughputSettingResource(cosmosDBSqlContainerThroughputSettingResourceId);

            // invoke the operation
            RedistributeThroughputParameters redistributeThroughputParameters = new RedistributeThroughputParameters(new AzureLocation("placeholder"), new RedistributeThroughputPropertiesResource(ThroughputPolicyType.Custom, new PhysicalPartitionThroughputInfoResource[]
            {
new PhysicalPartitionThroughputInfoResource("0")
{
Throughput = 5000,
},new PhysicalPartitionThroughputInfoResource("1")
{
Throughput = 5000,
}
            }, new PhysicalPartitionThroughputInfoResource[]
            {
new PhysicalPartitionThroughputInfoResource("2")
{
Throughput = 5000,
},new PhysicalPartitionThroughputInfoResource("3")
            }));
            ArmOperation<PhysicalPartitionThroughputInfoResult> lro = await cosmosDBSqlContainerThroughputSetting.SqlContainerRedistributeThroughputAsync(WaitUntil.Completed, redistributeThroughputParameters);
            PhysicalPartitionThroughputInfoResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
