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
    using System.Linq;

    /// <summary>
    /// TODO
    /// </summary>
    public partial class QueueServiceSettings : QueueServiceWritableSettings
    {
        /// <summary>
        /// Initializes a new instance of the QueueServiceSettings class.
        /// </summary>
        public QueueServiceSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueueServiceSettings class.
        /// </summary>
        /// <param name="frontEndCallbackThreadsCount">TODO</param>
        /// <param
        /// name="frontEndCpuBasedKeepAliveThrottlingEnabled">TODO</param>
        /// <param
        /// name="frontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold">TODO</param>
        /// <param
        /// name="frontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle">TODO</param>
        /// <param
        /// name="frontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds">TODO</param>
        /// <param name="frontEndMemoryThrottlingEnabled">TODO</param>
        /// <param
        /// name="frontEndMaxMillisecondsBetweenMemorySamples">TODO</param>
        /// <param name="frontEndMemoryThrottleThresholdSettings">TODO</param>
        /// <param name="frontEndMinThreadPoolThreads">TODO</param>
        /// <param
        /// name="frontEndThreadPoolBasedKeepAliveIOCompletionThreshold">TODO</param>
        /// <param
        /// name="frontEndThreadPoolBasedKeepAliveWorkerThreadThreshold">TODO</param>
        /// <param
        /// name="frontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds">TODO</param>
        /// <param
        /// name="frontEndThreadPoolBasedKeepAlivePercentage">TODO</param>
        /// <param name="frontEndUseSlaTimeInAvailability">TODO</param>
        public QueueServiceSettings(int? frontEndCallbackThreadsCount = default(int?), bool? frontEndCpuBasedKeepAliveThrottlingEnabled = default(bool?), double? frontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold = default(double?), double? frontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle = default(double?), int? frontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds = default(int?), bool? frontEndMemoryThrottlingEnabled = default(bool?), int? frontEndMaxMillisecondsBetweenMemorySamples = default(int?), string frontEndMemoryThrottleThresholdSettings = default(string), int? frontEndMinThreadPoolThreads = default(int?), int? frontEndThreadPoolBasedKeepAliveIOCompletionThreshold = default(int?), int? frontEndThreadPoolBasedKeepAliveWorkerThreadThreshold = default(int?), int? frontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds = default(int?), double? frontEndThreadPoolBasedKeepAlivePercentage = default(double?), bool? frontEndUseSlaTimeInAvailability = default(bool?), int? frontEndHttpListenPort = default(int?), int? backEndHttpListenPort = default(int?))
            : base(frontEndCallbackThreadsCount, frontEndCpuBasedKeepAliveThrottlingEnabled, frontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold, frontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle, frontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds, frontEndMemoryThrottlingEnabled, frontEndMaxMillisecondsBetweenMemorySamples, frontEndMemoryThrottleThresholdSettings, frontEndMinThreadPoolThreads, frontEndThreadPoolBasedKeepAliveIOCompletionThreshold, frontEndThreadPoolBasedKeepAliveWorkerThreadThreshold, frontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds, frontEndThreadPoolBasedKeepAlivePercentage, frontEndUseSlaTimeInAvailability, frontEndHttpListenPort, backEndHttpListenPort)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
