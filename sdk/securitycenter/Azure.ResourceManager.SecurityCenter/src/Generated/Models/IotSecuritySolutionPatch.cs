// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The IotSecuritySolutionPatch. </summary>
    public partial class IotSecuritySolutionPatch : TagsResourceInfo
    {
        /// <summary> Initializes a new instance of IotSecuritySolutionPatch. </summary>
        public IotSecuritySolutionPatch()
        {
            RecommendationsConfiguration = new ChangeTrackingList<RecommendationConfigurationProperties>();
        }

        /// <summary> Initializes a new instance of IotSecuritySolutionPatch. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="userDefinedResources"> Properties of the IoT Security solution&apos;s user defined resources. </param>
        /// <param name="recommendationsConfiguration"> List of the configuration status for each recommendation type. </param>
        internal IotSecuritySolutionPatch(IDictionary<string, string> tags, UserDefinedResourcesProperties userDefinedResources, IList<RecommendationConfigurationProperties> recommendationsConfiguration) : base(tags)
        {
            UserDefinedResources = userDefinedResources;
            RecommendationsConfiguration = recommendationsConfiguration;
        }

        /// <summary> Properties of the IoT Security solution&apos;s user defined resources. </summary>
        public UserDefinedResourcesProperties UserDefinedResources { get; set; }
        /// <summary> List of the configuration status for each recommendation type. </summary>
        public IList<RecommendationConfigurationProperties> RecommendationsConfiguration { get; }
    }
}
