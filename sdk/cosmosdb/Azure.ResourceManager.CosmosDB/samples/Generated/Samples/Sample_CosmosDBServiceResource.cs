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
    public partial class Sample_CosmosDBServiceResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_DataTransferServiceCreate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBDataTransferServiceCreate.json
            // this example is just showing the usage of "Service_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBServiceResource created on azure
            // for more information of creating CosmosDBServiceResource, please refer to the document of CosmosDBServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string serviceName = "DataTransfer";
            ResourceIdentifier cosmosDBServiceResourceId = CosmosDBServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, serviceName);
            CosmosDBServiceResource cosmosDBService = client.GetCosmosDBServiceResource(cosmosDBServiceResourceId);

            // invoke the operation
            CosmosDBServiceCreateOrUpdateContent content = new CosmosDBServiceCreateOrUpdateContent()
            {
                Properties = new DataTransferServiceResourceCreateUpdateProperties()
                {
                    InstanceSize = CosmosDBServiceSize.CosmosD4S,
                    InstanceCount = 1,
                },
            };
            ArmOperation<CosmosDBServiceResource> lro = await cosmosDBService.UpdateAsync(WaitUntil.Completed, content);
            CosmosDBServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_GraphAPIComputeServiceCreate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBGraphAPIComputeServiceCreate.json
            // this example is just showing the usage of "Service_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBServiceResource created on azure
            // for more information of creating CosmosDBServiceResource, please refer to the document of CosmosDBServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string serviceName = "GraphAPICompute";
            ResourceIdentifier cosmosDBServiceResourceId = CosmosDBServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, serviceName);
            CosmosDBServiceResource cosmosDBService = client.GetCosmosDBServiceResource(cosmosDBServiceResourceId);

            // invoke the operation
            CosmosDBServiceCreateOrUpdateContent content = new CosmosDBServiceCreateOrUpdateContent()
            {
                Properties = new GraphApiComputeServiceResourceCreateUpdateProperties()
                {
                    InstanceSize = CosmosDBServiceSize.CosmosD4S,
                    InstanceCount = 1,
                },
            };
            ArmOperation<CosmosDBServiceResource> lro = await cosmosDBService.UpdateAsync(WaitUntil.Completed, content);
            CosmosDBServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_MaterializedViewsBuilderServiceCreate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBMaterializedViewsBuilderServiceCreate.json
            // this example is just showing the usage of "Service_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBServiceResource created on azure
            // for more information of creating CosmosDBServiceResource, please refer to the document of CosmosDBServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string serviceName = "MaterializedViewsBuilder";
            ResourceIdentifier cosmosDBServiceResourceId = CosmosDBServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, serviceName);
            CosmosDBServiceResource cosmosDBService = client.GetCosmosDBServiceResource(cosmosDBServiceResourceId);

            // invoke the operation
            CosmosDBServiceCreateOrUpdateContent content = new CosmosDBServiceCreateOrUpdateContent()
            {
                Properties = new MaterializedViewsBuilderServiceResourceCreateUpdateProperties()
                {
                    InstanceSize = CosmosDBServiceSize.CosmosD4S,
                    InstanceCount = 1,
                },
            };
            ArmOperation<CosmosDBServiceResource> lro = await cosmosDBService.UpdateAsync(WaitUntil.Completed, content);
            CosmosDBServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_SqlDedicatedGatewayServiceCreate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/services/sqldedicatedgateway/CosmosDBSqlDedicatedGatewayServiceCreate.json
            // this example is just showing the usage of "Service_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBServiceResource created on azure
            // for more information of creating CosmosDBServiceResource, please refer to the document of CosmosDBServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string serviceName = "SqlDedicatedGateway";
            ResourceIdentifier cosmosDBServiceResourceId = CosmosDBServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, serviceName);
            CosmosDBServiceResource cosmosDBService = client.GetCosmosDBServiceResource(cosmosDBServiceResourceId);

            // invoke the operation
            CosmosDBServiceCreateOrUpdateContent content = new CosmosDBServiceCreateOrUpdateContent()
            {
                Properties = new SqlDedicatedGatewayServiceResourceCreateUpdateProperties()
                {
                    DedicatedGatewayType = DedicatedGatewayType.IntegratedCache,
                    InstanceSize = CosmosDBServiceSize.CosmosD4S,
                    InstanceCount = 1,
                },
            };
            ArmOperation<CosmosDBServiceResource> lro = await cosmosDBService.UpdateAsync(WaitUntil.Completed, content);
            CosmosDBServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_DataTransferServiceGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBDataTransferServiceGet.json
            // this example is just showing the usage of "Service_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBServiceResource created on azure
            // for more information of creating CosmosDBServiceResource, please refer to the document of CosmosDBServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string serviceName = "DataTransfer";
            ResourceIdentifier cosmosDBServiceResourceId = CosmosDBServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, serviceName);
            CosmosDBServiceResource cosmosDBService = client.GetCosmosDBServiceResource(cosmosDBServiceResourceId);

            // invoke the operation
            CosmosDBServiceResource result = await cosmosDBService.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GraphAPIComputeServiceGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBGraphAPIComputeServiceGet.json
            // this example is just showing the usage of "Service_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBServiceResource created on azure
            // for more information of creating CosmosDBServiceResource, please refer to the document of CosmosDBServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string serviceName = "GraphAPICompute";
            ResourceIdentifier cosmosDBServiceResourceId = CosmosDBServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, serviceName);
            CosmosDBServiceResource cosmosDBService = client.GetCosmosDBServiceResource(cosmosDBServiceResourceId);

            // invoke the operation
            CosmosDBServiceResource result = await cosmosDBService.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_MaterializedViewsBuilderServiceGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBMaterializedViewsBuilderServiceGet.json
            // this example is just showing the usage of "Service_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBServiceResource created on azure
            // for more information of creating CosmosDBServiceResource, please refer to the document of CosmosDBServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string serviceName = "MaterializedViewsBuilder";
            ResourceIdentifier cosmosDBServiceResourceId = CosmosDBServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, serviceName);
            CosmosDBServiceResource cosmosDBService = client.GetCosmosDBServiceResource(cosmosDBServiceResourceId);

            // invoke the operation
            CosmosDBServiceResource result = await cosmosDBService.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SqlDedicatedGatewayServiceGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/services/sqldedicatedgateway/CosmosDBSqlDedicatedGatewayServiceGet.json
            // this example is just showing the usage of "Service_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBServiceResource created on azure
            // for more information of creating CosmosDBServiceResource, please refer to the document of CosmosDBServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string serviceName = "SqlDedicatedGateway";
            ResourceIdentifier cosmosDBServiceResourceId = CosmosDBServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, serviceName);
            CosmosDBServiceResource cosmosDBService = client.GetCosmosDBServiceResource(cosmosDBServiceResourceId);

            // invoke the operation
            CosmosDBServiceResource result = await cosmosDBService.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DataTransferServiceDelete()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBDataTransferServiceDelete.json
            // this example is just showing the usage of "Service_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBServiceResource created on azure
            // for more information of creating CosmosDBServiceResource, please refer to the document of CosmosDBServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string serviceName = "DataTransfer";
            ResourceIdentifier cosmosDBServiceResourceId = CosmosDBServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, serviceName);
            CosmosDBServiceResource cosmosDBService = client.GetCosmosDBServiceResource(cosmosDBServiceResourceId);

            // invoke the operation
            await cosmosDBService.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_GraphAPIComputeServiceDelete()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBGraphAPIComputeServiceDelete.json
            // this example is just showing the usage of "Service_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBServiceResource created on azure
            // for more information of creating CosmosDBServiceResource, please refer to the document of CosmosDBServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string serviceName = "GraphAPICompute";
            ResourceIdentifier cosmosDBServiceResourceId = CosmosDBServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, serviceName);
            CosmosDBServiceResource cosmosDBService = client.GetCosmosDBServiceResource(cosmosDBServiceResourceId);

            // invoke the operation
            await cosmosDBService.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_MaterializedViewsBuilderServiceDelete()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/CosmosDBMaterializedViewsBuilderServiceDelete.json
            // this example is just showing the usage of "Service_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBServiceResource created on azure
            // for more information of creating CosmosDBServiceResource, please refer to the document of CosmosDBServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string serviceName = "MaterializedViewsBuilder";
            ResourceIdentifier cosmosDBServiceResourceId = CosmosDBServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, serviceName);
            CosmosDBServiceResource cosmosDBService = client.GetCosmosDBServiceResource(cosmosDBServiceResourceId);

            // invoke the operation
            await cosmosDBService.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_SqlDedicatedGatewayServiceDelete()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/services/sqldedicatedgateway/CosmosDBSqlDedicatedGatewayServiceDelete.json
            // this example is just showing the usage of "Service_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBServiceResource created on azure
            // for more information of creating CosmosDBServiceResource, please refer to the document of CosmosDBServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string serviceName = "SqlDedicatedGateway";
            ResourceIdentifier cosmosDBServiceResourceId = CosmosDBServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, serviceName);
            CosmosDBServiceResource cosmosDBService = client.GetCosmosDBServiceResource(cosmosDBServiceResourceId);

            // invoke the operation
            await cosmosDBService.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
