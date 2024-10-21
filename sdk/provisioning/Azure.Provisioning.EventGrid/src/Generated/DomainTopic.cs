// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// DomainTopic.
/// </summary>
public partial class DomainTopic : ProvisionableResource
{
    /// <summary>
    /// Name of the domain topic.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Provisioning state of the domain topic.
    /// </summary>
    public BicepValue<DomainTopicProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<DomainTopicProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent EventGridDomain.
    /// </summary>
    public EventGridDomain? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<EventGridDomain> _parent;

    /// <summary>
    /// Creates a new DomainTopic.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the DomainTopic resource.  This can be
    /// used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the DomainTopic.</param>
    public DomainTopic(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.EventGrid/domains/topics", resourceVersion ?? "2022-06-15")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<DomainTopicProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<EventGridDomain>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported DomainTopic resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2022-06-15.
        /// </summary>
        public static readonly string V2022_06_15 = "2022-06-15";

        /// <summary>
        /// 2021-12-01.
        /// </summary>
        public static readonly string V2021_12_01 = "2021-12-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-06-01.
        /// </summary>
        public static readonly string V2019_06_01 = "2019-06-01";
    }

    /// <summary>
    /// Creates a reference to an existing DomainTopic.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the DomainTopic resource.  This can be
    /// used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the DomainTopic.</param>
    /// <returns>The existing DomainTopic resource.</returns>
    public static DomainTopic FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this DomainTopic resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 3, maxLength: 50, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);
}
