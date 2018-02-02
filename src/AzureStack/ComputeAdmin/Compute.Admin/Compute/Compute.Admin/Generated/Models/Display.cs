// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Compute.Admin.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains the localized display information for this particular
    /// operation / action..
    /// </summary>
    public partial class Display
    {
        /// <summary>
        /// Initializes a new instance of the Display class.
        /// </summary>
        public Display()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Display class.
        /// </summary>
        /// <param name="provider">The localized friendly form of the resource
        /// provider name – it is expected to also include the
        /// publisher/company responsible. It should use Title Casing and begin
        /// with "Microsoft" for 1st party services. e.g. "Microsoft Monitoring
        /// Insights" or "Microsoft Compute."</param>
        /// <param name="resource">The localized friendly form of the resource
        /// type related to this action/operation – it should match the public
        /// documentation for the resource provider.</param>
        /// <param name="operation">The localized friendly name for the
        /// operation, as it should be shown to the user.</param>
        /// <param name="description">The localized friendly description for
        /// the operation, as it should be shown to the user. It should be
        /// thorough, yet concise – it will be used in tool tips and detailed
        /// views.</param>
        public Display(string provider = default(string), string resource = default(string), string operation = default(string), string description = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the localized friendly form of the resource provider
        /// name – it is expected to also include the publisher/company
        /// responsible. It should use Title Casing and begin with "Microsoft"
        /// for 1st party services. e.g. "Microsoft Monitoring Insights" or
        /// "Microsoft Compute."
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets the localized friendly form of the resource type
        /// related to this action/operation – it should match the public
        /// documentation for the resource provider.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets the localized friendly name for the operation, as it
        /// should be shown to the user.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets the localized friendly description for the operation,
        /// as it should be shown to the user. It should be thorough, yet
        /// concise – it will be used in tool tips and detailed views.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
