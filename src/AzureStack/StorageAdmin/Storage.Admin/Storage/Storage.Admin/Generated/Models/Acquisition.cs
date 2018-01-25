// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Storage.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// TODO
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Acquisition : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Acquisition class.
        /// </summary>
        public Acquisition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Acquisition class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Location where resource is location.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="filePath">TODO</param>
        /// <param name="maximumblobsize">TODO</param>
        /// <param name="status">TODO. Possible values include: 'InProgress',
        /// 'Success', 'Failed'</param>
        /// <param name="susbcriptionid">TODO</param>
        /// <param name="storageaccount">TODO</param>
        /// <param name="container">TODO</param>
        /// <param name="blob">TODO</param>
        /// <param name="acquisitionid">TODO</param>
        public Acquisition(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string filePath = default(string), long? maximumblobsize = default(long?), string status = default(string), string susbcriptionid = default(string), string storageaccount = default(string), string container = default(string), string blob = default(string), string acquisitionid = default(string))
            : base(id, name, type, location, tags)
        {
            FilePath = filePath;
            Maximumblobsize = maximumblobsize;
            Status = status;
            Susbcriptionid = susbcriptionid;
            Storageaccount = storageaccount;
            Container = container;
            Blob = blob;
            Acquisitionid = acquisitionid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.filePath")]
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.maximumblobsize")]
        public long? Maximumblobsize { get; set; }

        /// <summary>
        /// Gets or sets TODO. Possible values include: 'InProgress',
        /// 'Success', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.susbcriptionid")]
        public string Susbcriptionid { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageaccount")]
        public string Storageaccount { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.container")]
        public string Container { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.blob")]
        public string Blob { get; set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.acquisitionid")]
        public string Acquisitionid { get; set; }

    }
}
