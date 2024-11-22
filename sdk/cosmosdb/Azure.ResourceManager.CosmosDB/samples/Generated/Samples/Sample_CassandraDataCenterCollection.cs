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
    public partial class Sample_CassandraDataCenterCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_CosmosDBManagedCassandraDataCenterList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBManagedCassandraDataCenterList.json
            // this example is just showing the usage of "CassandraDataCenters_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraClusterResource created on azure
            // for more information of creating CassandraClusterResource, please refer to the document of CassandraClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "cassandra-prod-rg";
            string clusterName = "cassandra-prod";
            ResourceIdentifier cassandraClusterResourceId = CassandraClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CassandraClusterResource cassandraCluster = client.GetCassandraClusterResource(cassandraClusterResourceId);

            // get the collection of this CassandraDataCenterResource
            CassandraDataCenterCollection collection = cassandraCluster.GetCassandraDataCenters();

            // invoke the operation and iterate over the result
            await foreach (CassandraDataCenterResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CassandraDataCenterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CosmosDBManagedCassandraDataCenterGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBManagedCassandraDataCenterGet.json
            // this example is just showing the usage of "CassandraDataCenters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraClusterResource created on azure
            // for more information of creating CassandraClusterResource, please refer to the document of CassandraClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "cassandra-prod-rg";
            string clusterName = "cassandra-prod";
            ResourceIdentifier cassandraClusterResourceId = CassandraClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CassandraClusterResource cassandraCluster = client.GetCassandraClusterResource(cassandraClusterResourceId);

            // get the collection of this CassandraDataCenterResource
            CassandraDataCenterCollection collection = cassandraCluster.GetCassandraDataCenters();

            // invoke the operation
            string dataCenterName = "dc1";
            CassandraDataCenterResource result = await collection.GetAsync(dataCenterName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CassandraDataCenterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_CosmosDBManagedCassandraDataCenterGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBManagedCassandraDataCenterGet.json
            // this example is just showing the usage of "CassandraDataCenters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraClusterResource created on azure
            // for more information of creating CassandraClusterResource, please refer to the document of CassandraClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "cassandra-prod-rg";
            string clusterName = "cassandra-prod";
            ResourceIdentifier cassandraClusterResourceId = CassandraClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CassandraClusterResource cassandraCluster = client.GetCassandraClusterResource(cassandraClusterResourceId);

            // get the collection of this CassandraDataCenterResource
            CassandraDataCenterCollection collection = cassandraCluster.GetCassandraDataCenters();

            // invoke the operation
            string dataCenterName = "dc1";
            bool result = await collection.ExistsAsync(dataCenterName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_CosmosDBManagedCassandraDataCenterGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBManagedCassandraDataCenterGet.json
            // this example is just showing the usage of "CassandraDataCenters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraClusterResource created on azure
            // for more information of creating CassandraClusterResource, please refer to the document of CassandraClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "cassandra-prod-rg";
            string clusterName = "cassandra-prod";
            ResourceIdentifier cassandraClusterResourceId = CassandraClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CassandraClusterResource cassandraCluster = client.GetCassandraClusterResource(cassandraClusterResourceId);

            // get the collection of this CassandraDataCenterResource
            CassandraDataCenterCollection collection = cassandraCluster.GetCassandraDataCenters();

            // invoke the operation
            string dataCenterName = "dc1";
            NullableResponse<CassandraDataCenterResource> response = await collection.GetIfExistsAsync(dataCenterName);
            CassandraDataCenterResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CassandraDataCenterData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CosmosDBManagedCassandraDataCenterCreate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBManagedCassandraDataCenterCreate.json
            // this example is just showing the usage of "CassandraDataCenters_CreateUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraClusterResource created on azure
            // for more information of creating CassandraClusterResource, please refer to the document of CassandraClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "cassandra-prod-rg";
            string clusterName = "cassandra-prod";
            ResourceIdentifier cassandraClusterResourceId = CassandraClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CassandraClusterResource cassandraCluster = client.GetCassandraClusterResource(cassandraClusterResourceId);

            // get the collection of this CassandraDataCenterResource
            CassandraDataCenterCollection collection = cassandraCluster.GetCassandraDataCenters();

            // invoke the operation
            string dataCenterName = "dc1";
            CassandraDataCenterData data = new CassandraDataCenterData()
            {
                Properties = new CassandraDataCenterProperties()
                {
                    DataCenterLocation = new AzureLocation("West US 2"),
                    DelegatedSubnetId = new ResourceIdentifier("/subscriptions/536e130b-d7d6-4ac7-98a5-de20d69588d2/resourceGroups/customer-vnet-rg/providers/Microsoft.Network/virtualNetworks/customer-vnet/subnets/dc1-subnet"),
                    NodeCount = 9,
                    Base64EncodedCassandraYamlFragment = "Y29tcGFjdGlvbl90aHJvdWdocHV0X21iX3Blcl9zZWM6IDMyCmNvbXBhY3Rpb25fbGFyZ2VfcGFydGl0aW9uX3dhcm5pbmdfdGhyZXNob2xkX21iOiAxMDA=",
                },
            };
            ArmOperation<CassandraDataCenterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataCenterName, data);
            CassandraDataCenterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CassandraDataCenterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
