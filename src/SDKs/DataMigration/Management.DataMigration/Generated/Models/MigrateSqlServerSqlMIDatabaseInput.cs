// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Database specific information for SQL to Azure SQL DB Managed Instance
    /// migration task inputs
    /// </summary>
    public partial class MigrateSqlServerSqlMIDatabaseInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MigrateSqlServerSqlMIDatabaseInput class.
        /// </summary>
        public MigrateSqlServerSqlMIDatabaseInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MigrateSqlServerSqlMIDatabaseInput class.
        /// </summary>
        /// <param name="name">Name of the database</param>
        /// <param name="restoreDatabaseName">Name of the database at
        /// destination</param>
        /// <param name="backupFileShare">Backup file share information for
        /// backing up this database.</param>
        public MigrateSqlServerSqlMIDatabaseInput(string name, string restoreDatabaseName, FileShare backupFileShare = default(FileShare))
        {
            Name = name;
            RestoreDatabaseName = restoreDatabaseName;
            BackupFileShare = backupFileShare;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the database
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets name of the database at destination
        /// </summary>
        [JsonProperty(PropertyName = "restoreDatabaseName")]
        public string RestoreDatabaseName { get; set; }

        /// <summary>
        /// Gets or sets backup file share information for backing up this
        /// database.
        /// </summary>
        [JsonProperty(PropertyName = "backupFileShare")]
        public FileShare BackupFileShare { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (RestoreDatabaseName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RestoreDatabaseName");
            }
            if (BackupFileShare != null)
            {
                BackupFileShare.Validate();
            }
        }
    }
}
