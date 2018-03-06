// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApplicationInsights.Management.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An Application Insights component daily data volume cap status
    /// </summary>
    public partial class ApplicationInsightsComponentQuotaStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationInsightsComponentQuotaStatus class.
        /// </summary>
        public ApplicationInsightsComponentQuotaStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationInsightsComponentQuotaStatus class.
        /// </summary>
        /// <param name="appId">The Application ID for the Application Insights
        /// component.</param>
        /// <param name="shouldBeThrottled">The daily data volume cap is met,
        /// and data ingestion will be stopped.</param>
        /// <param name="expirationTime">Date and time when the daily data
        /// volume cap will be reset, and data ingestion will resume.</param>
        public ApplicationInsightsComponentQuotaStatus(string appId = default(string), bool? shouldBeThrottled = default(bool?), string expirationTime = default(string))
        {
            AppId = appId;
            ShouldBeThrottled = shouldBeThrottled;
            ExpirationTime = expirationTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the Application ID for the Application Insights component.
        /// </summary>
        [JsonProperty(PropertyName = "AppId")]
        public string AppId { get; private set; }

        /// <summary>
        /// Gets the daily data volume cap is met, and data ingestion will be
        /// stopped.
        /// </summary>
        [JsonProperty(PropertyName = "ShouldBeThrottled")]
        public bool? ShouldBeThrottled { get; private set; }

        /// <summary>
        /// Gets date and time when the daily data volume cap will be reset,
        /// and data ingestion will resume.
        /// </summary>
        [JsonProperty(PropertyName = "ExpirationTime")]
        public string ExpirationTime { get; private set; }

    }
}
