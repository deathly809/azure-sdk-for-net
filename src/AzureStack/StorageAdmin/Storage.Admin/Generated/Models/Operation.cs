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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the supported REST operation.
    /// </summary>
    public partial class Operation
    {
        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        public Operation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        /// <param name="name">The name of the operation being performed on
        /// this particular object. It should match the action name that
        /// appears in RBAC / the event service.</param>
        /// <param name="display">Contains the localized display information
        /// for this particular operation / action.</param>
        public Operation(string name = default(string), Display display = default(Display))
        {
            Name = name;
            Display = display;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the operation being performed on this
        /// particular object. It should match the action name that appears in
        /// RBAC / the event service.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets contains the localized display information for this
        /// particular operation / action.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public Display Display { get; set; }

    }
}
