// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppPlatform.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary> A class representing the AppBuild data model. </summary>
    public partial class AppBuildData : ResourceData
    {
        /// <summary> Initializes a new instance of AppBuildData. </summary>
        public AppBuildData()
        {
        }

        /// <summary> Initializes a new instance of AppBuildData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of the build resource. </param>
        internal AppBuildData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AppBuildProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Properties of the build resource. </summary>
        public AppBuildProperties Properties { get; set; }
    }
}
