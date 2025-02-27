// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.DigitalTwins.Core
{
    /// <summary> A collection of DigitalTwinsModelData objects. </summary>
    internal partial class PagedDigitalTwinsModelDataCollection
    {
        /// <summary> Initializes a new instance of PagedDigitalTwinsModelDataCollection. </summary>
        /// <param name="value"> The DigitalTwinsModelData objects. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal PagedDigitalTwinsModelDataCollection(IEnumerable<DigitalTwinsModelData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of PagedDigitalTwinsModelDataCollection. </summary>
        /// <param name="value"> The DigitalTwinsModelData objects. </param>
        /// <param name="nextLink"> A URI to retrieve the next page of objects. </param>
        internal PagedDigitalTwinsModelDataCollection(IReadOnlyList<DigitalTwinsModelData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The DigitalTwinsModelData objects. </summary>
        public IReadOnlyList<DigitalTwinsModelData> Value { get; }
        /// <summary> A URI to retrieve the next page of objects. </summary>
        public string NextLink { get; }
    }
}
