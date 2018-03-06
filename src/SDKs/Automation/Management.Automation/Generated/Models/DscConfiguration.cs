// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Definition of the configuration type.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DscConfiguration : Resource
    {
        /// <summary>
        /// Initializes a new instance of the DscConfiguration class.
        /// </summary>
        public DscConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DscConfiguration class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="provisioningState">Gets or sets the provisioning state
        /// of the configuration. Possible values include: 'Succeeded'</param>
        /// <param name="jobCount">Gets or sets the job count of the
        /// configuration.</param>
        /// <param name="parameters">Gets or sets the configuration
        /// parameters.</param>
        /// <param name="source">Gets or sets the source.</param>
        /// <param name="state">Gets or sets the state of the configuration.
        /// Possible values include: 'New', 'Edit', 'Published'</param>
        /// <param name="logVerbose">Gets or sets verbose log option.</param>
        /// <param name="creationTime">Gets or sets the creation time.</param>
        /// <param name="lastModifiedTime">Gets or sets the last modified
        /// time.</param>
        /// <param name="description">Gets or sets the description.</param>
        /// <param name="etag">Gets or sets the etag of the resource.</param>
        public DscConfiguration(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), DscConfigurationProvisioningState? provisioningState = default(DscConfigurationProvisioningState?), int? jobCount = default(int?), IDictionary<string, DscConfigurationParameter> parameters = default(IDictionary<string, DscConfigurationParameter>), ContentSource source = default(ContentSource), string state = default(string), bool? logVerbose = default(bool?), System.DateTime? creationTime = default(System.DateTime?), System.DateTime? lastModifiedTime = default(System.DateTime?), string description = default(string), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            ProvisioningState = provisioningState;
            JobCount = jobCount;
            Parameters = parameters;
            Source = source;
            State = state;
            LogVerbose = logVerbose;
            CreationTime = creationTime;
            LastModifiedTime = lastModifiedTime;
            Description = description;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the provisioning state of the configuration. Possible
        /// values include: 'Succeeded'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public DscConfigurationProvisioningState? ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the job count of the configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.jobCount")]
        public int? JobCount { get; set; }

        /// <summary>
        /// Gets or sets the configuration parameters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public IDictionary<string, DscConfigurationParameter> Parameters { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        [JsonProperty(PropertyName = "properties.source")]
        public ContentSource Source { get; set; }

        /// <summary>
        /// Gets or sets the state of the configuration. Possible values
        /// include: 'New', 'Edit', 'Published'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets verbose log option.
        /// </summary>
        [JsonProperty(PropertyName = "properties.logVerbose")]
        public bool? LogVerbose { get; set; }

        /// <summary>
        /// Gets or sets the creation time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the last modified time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the etag of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Source != null)
            {
                Source.Validate();
            }
        }
    }
}
