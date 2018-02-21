// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Fabric.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Representation of a storage pool resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StoragePool : Resource
    {
        /// <summary>
        /// Initializes a new instance of the StoragePool class.
        /// </summary>
        public StoragePool()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StoragePool class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">The region where the resource is
        /// located.</param>
        /// <param name="tags">List of key-value pairs.</param>
        /// <param name="sizeGB">Amount of space in the storage pool in
        /// GB.</param>
        public StoragePool(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), int? sizeGB = default(int?))
            : base(id, name, type, location, tags)
        {
            SizeGB = sizeGB;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets amount of space in the storage pool in GB.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sizeGB")]
        public int? SizeGB { get; set; }

    }
}
