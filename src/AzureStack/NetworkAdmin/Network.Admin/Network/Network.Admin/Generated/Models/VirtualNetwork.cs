// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Network.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This represents a Virtual Networks.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualNetwork : ResourceTenant
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetwork class.
        /// </summary>
        public VirtualNetwork()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetwork class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Region Location of resource.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="provisioningState">The provisioning state.</param>
        /// <param name="subscriptionId">The subscription Id.</param>
        /// <param name="tenantResourceUri">The tenant resource URI.</param>
        /// <param name="configurationState">The configuration state.</param>
        public VirtualNetwork(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), string subscriptionId = default(string), string tenantResourceUri = default(string), VirtualNetworkConfigurationState configurationState = default(VirtualNetworkConfigurationState))
            : base(id, name, type, location, tags, provisioningState, subscriptionId, tenantResourceUri)
        {
            ConfigurationState = configurationState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the configuration state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.configurationState")]
        public VirtualNetworkConfigurationState ConfigurationState { get; set; }

    }
}
