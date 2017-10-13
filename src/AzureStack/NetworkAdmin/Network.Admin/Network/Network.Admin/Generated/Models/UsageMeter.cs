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
    /// This represents a usage meter.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class UsageMeter : Resource
    {
        /// <summary>
        /// Initializes a new instance of the UsageMeter class.
        /// </summary>
        public UsageMeter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsageMeter class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Region Location of resource.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="meterId">The meter id.</param>
        /// <param name="meterName">The meter name.</param>
        /// <param name="meterCategory">The meter category.</param>
        /// <param name="meterSubCategory">The meter sub category.</param>
        /// <param name="unit">The unit.</param>
        public UsageMeter(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string meterId = default(string), string meterName = default(string), string meterCategory = default(string), string meterSubCategory = default(string), string unit = default(string))
            : base(id, name, type, location, tags)
        {
            MeterId = meterId;
            MeterName = meterName;
            MeterCategory = meterCategory;
            MeterSubCategory = meterSubCategory;
            Unit = unit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the meter id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterId")]
        public string MeterId { get; set; }

        /// <summary>
        /// Gets or sets the meter name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterName")]
        public string MeterName { get; set; }

        /// <summary>
        /// Gets or sets the meter category.
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterCategory")]
        public string MeterCategory { get; set; }

        /// <summary>
        /// Gets or sets the meter sub category.
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterSubCategory")]
        public string MeterSubCategory { get; set; }

        /// <summary>
        /// Gets or sets the unit.
        /// </summary>
        [JsonProperty(PropertyName = "properties.unit")]
        public string Unit { get; set; }

    }
}
