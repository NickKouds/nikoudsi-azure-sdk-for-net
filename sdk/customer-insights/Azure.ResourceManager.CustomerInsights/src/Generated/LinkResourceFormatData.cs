// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary> A class representing the LinkResourceFormat data model. </summary>
    public partial class LinkResourceFormatData : ResourceData
    {
        /// <summary> Initializes a new instance of LinkResourceFormatData. </summary>
        public LinkResourceFormatData()
        {
            DisplayName = new ChangeTrackingDictionary<string, string>();
            Description = new ChangeTrackingDictionary<string, string>();
            Mappings = new ChangeTrackingList<TypePropertiesMapping>();
            ParticipantPropertyReferences = new ChangeTrackingList<ParticipantPropertyReference>();
        }

        /// <summary> Initializes a new instance of LinkResourceFormatData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tenantId"> The hub name. </param>
        /// <param name="linkName"> The link name. </param>
        /// <param name="sourceEntityType"> Type of source entity. </param>
        /// <param name="targetEntityType"> Type of target entity. </param>
        /// <param name="sourceEntityTypeName"> Name of the source Entity Type. </param>
        /// <param name="targetEntityTypeName"> Name of the target Entity Type. </param>
        /// <param name="displayName"> Localized display name for the Link. </param>
        /// <param name="description"> Localized descriptions for the Link. </param>
        /// <param name="mappings"> The set of properties mappings between the source and target Types. </param>
        /// <param name="participantPropertyReferences"> The properties that represent the participating profile. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="referenceOnly"> Indicating whether the link is reference only link. This flag is ignored if the Mappings are defined. If the mappings are not defined and it is set to true, links processing will not create or update profiles. </param>
        /// <param name="operationType"> Determines whether this link is supposed to create or delete instances if Link is NOT Reference Only. </param>
        internal LinkResourceFormatData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? tenantId, string linkName, EntityType? sourceEntityType, EntityType? targetEntityType, string sourceEntityTypeName, string targetEntityTypeName, IDictionary<string, string> displayName, IDictionary<string, string> description, IList<TypePropertiesMapping> mappings, IList<ParticipantPropertyReference> participantPropertyReferences, ProvisioningState? provisioningState, bool? referenceOnly, InstanceOperationType? operationType) : base(id, name, resourceType, systemData)
        {
            TenantId = tenantId;
            LinkName = linkName;
            SourceEntityType = sourceEntityType;
            TargetEntityType = targetEntityType;
            SourceEntityTypeName = sourceEntityTypeName;
            TargetEntityTypeName = targetEntityTypeName;
            DisplayName = displayName;
            Description = description;
            Mappings = mappings;
            ParticipantPropertyReferences = participantPropertyReferences;
            ProvisioningState = provisioningState;
            ReferenceOnly = referenceOnly;
            OperationType = operationType;
        }

        /// <summary> The hub name. </summary>
        public Guid? TenantId { get; }
        /// <summary> The link name. </summary>
        public string LinkName { get; }
        /// <summary> Type of source entity. </summary>
        public EntityType? SourceEntityType { get; set; }
        /// <summary> Type of target entity. </summary>
        public EntityType? TargetEntityType { get; set; }
        /// <summary> Name of the source Entity Type. </summary>
        public string SourceEntityTypeName { get; set; }
        /// <summary> Name of the target Entity Type. </summary>
        public string TargetEntityTypeName { get; set; }
        /// <summary> Localized display name for the Link. </summary>
        public IDictionary<string, string> DisplayName { get; }
        /// <summary> Localized descriptions for the Link. </summary>
        public IDictionary<string, string> Description { get; }
        /// <summary> The set of properties mappings between the source and target Types. </summary>
        public IList<TypePropertiesMapping> Mappings { get; }
        /// <summary> The properties that represent the participating profile. </summary>
        public IList<ParticipantPropertyReference> ParticipantPropertyReferences { get; }
        /// <summary> Provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Indicating whether the link is reference only link. This flag is ignored if the Mappings are defined. If the mappings are not defined and it is set to true, links processing will not create or update profiles. </summary>
        public bool? ReferenceOnly { get; set; }
        /// <summary> Determines whether this link is supposed to create or delete instances if Link is NOT Reference Only. </summary>
        public InstanceOperationType? OperationType { get; set; }
    }
}
