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
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MigrationParameters
    {
        /// <summary>
        /// Initializes a new instance of the MigrationParameters class.
        /// </summary>
        public MigrationParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MigrationParameters class.
        /// </summary>
        /// <param name="storageAccountName">Share location where container is
        /// located.</param>
        /// <param name="containerName">Name of container to migrate.</param>
        /// <param name="destinationShareUNCPath">UNC path of share where
        /// container should be places.</param>
        public MigrationParameters(string storageAccountName, string containerName, string destinationShareUNCPath)
        {
            StorageAccountName = storageAccountName;
            ContainerName = containerName;
            DestinationShareUNCPath = destinationShareUNCPath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets share location where container is located.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountName")]
        public string StorageAccountName { get; set; }

        /// <summary>
        /// Gets or sets name of container to migrate.
        /// </summary>
        [JsonProperty(PropertyName = "containerName")]
        public string ContainerName { get; set; }

        /// <summary>
        /// Gets or sets UNC path of share where container should be places.
        /// </summary>
        [JsonProperty(PropertyName = "destinationShareUNCPath")]
        public string DestinationShareUNCPath { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageAccountName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageAccountName");
            }
            if (ContainerName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContainerName");
            }
            if (DestinationShareUNCPath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DestinationShareUNCPath");
            }
        }
    }
}
