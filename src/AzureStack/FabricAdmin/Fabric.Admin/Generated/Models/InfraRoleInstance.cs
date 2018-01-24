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
    /// The virtual machine resource is used to represent an infrastructure
    /// virtual machine in the Azure Stack environment. The fabric resource
    /// provider only surfaces infrastructure virtual machines. These machines
    /// are never created directly by the admin, but rather as a side effect of
    /// expanding admin services.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class InfraRoleInstance : Resource
    {
        /// <summary>
        /// Initializes a new instance of the InfraRoleInstance class.
        /// </summary>
        public InfraRoleInstance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InfraRoleInstance class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Region Location of resource.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="scaleUnit">The cluster that the virtual machine's host
        /// is part of.</param>
        /// <param name="scaleUnitNode">URI to the scale unit node.</param>
        /// <param name="size">Size of the virtual machine.</param>
        /// <param name="state">The current state of the virtual machine.
        /// Possible values include: 'Stopped', 'Starting', 'Running',
        /// 'Stopping'</param>
        public InfraRoleInstance(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string scaleUnit = default(string), string scaleUnitNode = default(string), InfraRoleInstanceSize size = default(InfraRoleInstanceSize), string state = default(string))
            : base(id, name, type, location, tags)
        {
            ScaleUnit = scaleUnit;
            ScaleUnitNode = scaleUnitNode;
            Size = size;
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the cluster that the virtual machine's host is part
        /// of.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scaleUnit")]
        public string ScaleUnit { get; set; }

        /// <summary>
        /// Gets or sets URI to the scale unit node.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scaleUnitNode")]
        public string ScaleUnitNode { get; set; }

        /// <summary>
        /// Gets or sets size of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.size")]
        public InfraRoleInstanceSize Size { get; set; }

        /// <summary>
        /// Gets or sets the current state of the virtual machine. Possible
        /// values include: 'Stopped', 'Starting', 'Running', 'Stopping'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

    }
}
