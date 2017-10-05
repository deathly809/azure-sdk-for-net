// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.AzureBridge.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Registration resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RegistrationResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RegistrationResource class.
        /// </summary>
        public RegistrationResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegistrationResource class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Location where resource is location.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="galleryItemUri">Gallery item URI.</param>
        /// <param name="provisioningState">Provisioning state of the resource.
        /// Possible values include: 'Stopped', 'Starting', 'Running',
        /// 'Stopping'</param>
        public RegistrationResource(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string galleryItemUri = default(string), string provisioningState = default(string))
            : base(id, name, type, location, tags)
        {
            GalleryItemUri = galleryItemUri;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets gallery item URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.galleryItemUri")]
        public string GalleryItemUri { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the resource. Possible values
        /// include: 'Stopped', 'Starting', 'Running', 'Stopping'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

    }
}
