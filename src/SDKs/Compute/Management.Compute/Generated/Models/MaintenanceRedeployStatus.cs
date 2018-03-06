// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Maintenance Operation Status.
    /// </summary>
    public partial class MaintenanceRedeployStatus
    {
        /// <summary>
        /// Initializes a new instance of the MaintenanceRedeployStatus class.
        /// </summary>
        public MaintenanceRedeployStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MaintenanceRedeployStatus class.
        /// </summary>
        /// <param name="isCustomerInitiatedMaintenanceAllowed">True, if
        /// customer is allowed to perform Maintenance.</param>
        /// <param name="preMaintenanceWindowStartTime">Start Time for the Pre
        /// Maintenance Window.</param>
        /// <param name="preMaintenanceWindowEndTime">End Time for the Pre
        /// Maintenance Window.</param>
        /// <param name="maintenanceWindowStartTime">Start Time for the
        /// Maintenance Window.</param>
        /// <param name="maintenanceWindowEndTime">End Time for the Maintenance
        /// Window.</param>
        /// <param name="lastOperationResultCode">The Last Maintenance
        /// Operation Result Code. Possible values include: 'None',
        /// 'RetryLater', 'MaintenanceAborted', 'MaintenanceCompleted'</param>
        /// <param name="lastOperationMessage">Message returned for the last
        /// Maintenance Operation.</param>
        public MaintenanceRedeployStatus(bool? isCustomerInitiatedMaintenanceAllowed = default(bool?), System.DateTime? preMaintenanceWindowStartTime = default(System.DateTime?), System.DateTime? preMaintenanceWindowEndTime = default(System.DateTime?), System.DateTime? maintenanceWindowStartTime = default(System.DateTime?), System.DateTime? maintenanceWindowEndTime = default(System.DateTime?), MaintenanceOperationResultCodeTypes? lastOperationResultCode = default(MaintenanceOperationResultCodeTypes?), string lastOperationMessage = default(string))
        {
            IsCustomerInitiatedMaintenanceAllowed = isCustomerInitiatedMaintenanceAllowed;
            PreMaintenanceWindowStartTime = preMaintenanceWindowStartTime;
            PreMaintenanceWindowEndTime = preMaintenanceWindowEndTime;
            MaintenanceWindowStartTime = maintenanceWindowStartTime;
            MaintenanceWindowEndTime = maintenanceWindowEndTime;
            LastOperationResultCode = lastOperationResultCode;
            LastOperationMessage = lastOperationMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets true, if customer is allowed to perform Maintenance.
        /// </summary>
        [JsonProperty(PropertyName = "isCustomerInitiatedMaintenanceAllowed")]
        public bool? IsCustomerInitiatedMaintenanceAllowed { get; set; }

        /// <summary>
        /// Gets or sets start Time for the Pre Maintenance Window.
        /// </summary>
        [JsonProperty(PropertyName = "preMaintenanceWindowStartTime")]
        public System.DateTime? PreMaintenanceWindowStartTime { get; set; }

        /// <summary>
        /// Gets or sets end Time for the Pre Maintenance Window.
        /// </summary>
        [JsonProperty(PropertyName = "preMaintenanceWindowEndTime")]
        public System.DateTime? PreMaintenanceWindowEndTime { get; set; }

        /// <summary>
        /// Gets or sets start Time for the Maintenance Window.
        /// </summary>
        [JsonProperty(PropertyName = "maintenanceWindowStartTime")]
        public System.DateTime? MaintenanceWindowStartTime { get; set; }

        /// <summary>
        /// Gets or sets end Time for the Maintenance Window.
        /// </summary>
        [JsonProperty(PropertyName = "maintenanceWindowEndTime")]
        public System.DateTime? MaintenanceWindowEndTime { get; set; }

        /// <summary>
        /// Gets or sets the Last Maintenance Operation Result Code. Possible
        /// values include: 'None', 'RetryLater', 'MaintenanceAborted',
        /// 'MaintenanceCompleted'
        /// </summary>
        [JsonProperty(PropertyName = "lastOperationResultCode")]
        public MaintenanceOperationResultCodeTypes? LastOperationResultCode { get; set; }

        /// <summary>
        /// Gets or sets message returned for the last Maintenance Operation.
        /// </summary>
        [JsonProperty(PropertyName = "lastOperationMessage")]
        public string LastOperationMessage { get; set; }

    }
}
