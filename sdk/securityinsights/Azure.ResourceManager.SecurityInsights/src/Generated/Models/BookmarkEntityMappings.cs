// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Describes the entity mappings of a single entity. </summary>
    public partial class BookmarkEntityMappings
    {
        /// <summary> Initializes a new instance of BookmarkEntityMappings. </summary>
        public BookmarkEntityMappings()
        {
            FieldMappings = new ChangeTrackingList<EntityFieldMapping>();
        }

        /// <summary> Initializes a new instance of BookmarkEntityMappings. </summary>
        /// <param name="entityType"> The entity type. </param>
        /// <param name="fieldMappings"> Array of fields mapping for that entity type. </param>
        internal BookmarkEntityMappings(string entityType, IList<EntityFieldMapping> fieldMappings)
        {
            EntityType = entityType;
            FieldMappings = fieldMappings;
        }

        /// <summary> The entity type. </summary>
        public string EntityType { get; set; }
        /// <summary> Array of fields mapping for that entity type. </summary>
        public IList<EntityFieldMapping> FieldMappings { get; }
    }
}
