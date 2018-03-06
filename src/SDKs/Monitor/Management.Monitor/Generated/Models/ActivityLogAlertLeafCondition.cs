// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An Activity Log alert condition that is met by comparing an activity
    /// log field and value.
    /// </summary>
    public partial class ActivityLogAlertLeafCondition
    {
        /// <summary>
        /// Initializes a new instance of the ActivityLogAlertLeafCondition
        /// class.
        /// </summary>
        public ActivityLogAlertLeafCondition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActivityLogAlertLeafCondition
        /// class.
        /// </summary>
        /// <param name="field">The name of the field that this condition will
        /// examine. The possible values for this field are (case-insensitive):
        /// 'resourceId', 'category', 'caller', 'level', 'operationName',
        /// 'resourceGroup', 'resourceProvider', 'status', 'subStatus',
        /// 'resourceType', or anything beginning with 'properties.'.</param>
        /// <param name="equals">The field value will be compared to this value
        /// (case-insensitive) to determine if the condition is met.</param>
        public ActivityLogAlertLeafCondition(string field, string equals)
        {
            Field = field;
            Equals = equals;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the field that this condition will
        /// examine. The possible values for this field are (case-insensitive):
        /// 'resourceId', 'category', 'caller', 'level', 'operationName',
        /// 'resourceGroup', 'resourceProvider', 'status', 'subStatus',
        /// 'resourceType', or anything beginning with 'properties.'.
        /// </summary>
        [JsonProperty(PropertyName = "field")]
        public string Field { get; set; }

        /// <summary>
        /// Gets or sets the field value will be compared to this value
        /// (case-insensitive) to determine if the condition is met.
        /// </summary>
        [JsonProperty(PropertyName = "equals")]
        public string Equals { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Field == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Field");
            }
            if (Equals == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Equals");
            }
        }
    }
}
