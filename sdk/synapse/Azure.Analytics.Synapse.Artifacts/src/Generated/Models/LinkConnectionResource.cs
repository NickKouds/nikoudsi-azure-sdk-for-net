// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The LinkConnectionResource. </summary>
    public partial class LinkConnectionResource
    {
        /// <summary> Initializes a new instance of LinkConnectionResource. </summary>
        /// <param name="properties"> Properties of link connection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public LinkConnectionResource(LinkConnection properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of LinkConnectionResource. </summary>
        /// <param name="id"> Link connection id. </param>
        /// <param name="name"> Link connection name. </param>
        /// <param name="type"> Link connection type. </param>
        /// <param name="properties"> Properties of link connection. </param>
        /// <param name="description"> Link connection description. </param>
        internal LinkConnectionResource(string id, string name, string type, LinkConnection properties, string description)
        {
            Id = id;
            Name = name;
            Type = type;
            Properties = properties;
            Description = description;
        }

        /// <summary> Link connection id. </summary>
        public string Id { get; set; }
        /// <summary> Link connection name. </summary>
        public string Name { get; set; }
        /// <summary> Link connection type. </summary>
        public string Type { get; set; }
        /// <summary> Properties of link connection. </summary>
        public LinkConnection Properties { get; set; }
        /// <summary> Link connection description. </summary>
        public string Description { get; set; }
    }
}
