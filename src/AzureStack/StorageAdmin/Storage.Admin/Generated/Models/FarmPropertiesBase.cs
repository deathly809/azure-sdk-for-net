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
    using System.Linq;

    /// <summary>
    /// Storage farm properties base object.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FarmPropertiesBase
    {
        /// <summary>
        /// Initializes a new instance of the FarmPropertiesBase class.
        /// </summary>
        public FarmPropertiesBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FarmPropertiesBase class.
        /// </summary>
        /// <param name="settingsPollingIntervalInSecond">The polling interval
        /// (in second).</param>
        /// <param name="retentionPeriodForDeletedStorageAccountsInDays">The
        /// retention period (in days) for deleted storage account.</param>
        /// <param name="hostStyleHttpPort">Host style HTTP port.</param>
        /// <param name="hostStyleHttpsPort">Host style HTTPs port.</param>
        /// <param name="corsAllowedOriginsList">The list of allowed
        /// origins.</param>
        /// <param name="dataCenterUriHostSuffixes">The suffixes of URI of
        /// hosts in data center.</param>
        /// <param name="bandwidthThrottleIsEnabled">Switch of bandwidth
        /// throttle enablement.</param>
        /// <param name="usageCollectionIntervalInSeconds">Interval (in
        /// seconds) of storage usage collection.</param>
        /// <param name="feedbackRefreshIntervalInSeconds">Interval (in
        /// seconds) of feedback refresh.</param>
        /// <param name="numberOfAccountsToSync">Number of accounts to
        /// sync.</param>
        /// <param
        /// name="defaultThrottleProbabilityDecayIntervalInSeconds">Interval
        /// (in seconds) of default throttle probability decay.</param>
        /// <param name="gracePeriodForFullThrottlingInRefreshIntervals">Grace
        /// period for full throttling in refresh intervals.</param>
        /// <param name="gracePeriodMaxThrottleProbability">Maximum probability
        /// of throttle in grace period.</param>
        /// <param name="overallRequestThresholdInTps">Overall request
        /// threshold (in TPS).</param>
        /// <param name="defaultRequestThresholdInTps">Default request
        /// threshold (in TPS).</param>
        /// <param name="minimumRequestThresholdInTps">Minimum request
        /// threshold (in TPS).</param>
        /// <param name="toleranceFactorForTps">Tolerance factor for
        /// TPS.</param>
        /// <param name="overallIngressThresholdInGbps">Overall ingress
        /// threshold (in Gbps)</param>
        /// <param name="defaultIngressThresholdInGbps">Default ingress
        /// threshold (in Gbps).</param>
        /// <param name="minimumIngressThresholdInGbps">Minimum ingress
        /// threshold (in Gbps).</param>
        /// <param name="toleranceFactorForIngress">Tolerance factor for
        /// ingress.</param>
        /// <param name="overallIntranetIngressThresholdInGbps">Overall
        /// Intranet ingress threshold (in Gbps).</param>
        /// <param name="defaultIntranetIngressThresholdInGbps">Default
        /// Intranet ingress threshold (in Gbps).</param>
        /// <param name="minimumIntranetIngressThresholdInGbps">Minimum
        /// Intranet ingress threshold (in Gbps).</param>
        /// <param name="toleranceFactorForIntranetIngress">Tolerance factor
        /// for Intranet ingress.</param>
        /// <param name="overallEgressThresholdInGbps">Overall egress threshold
        /// (in Gbps).</param>
        /// <param name="defaultEgressThresholdInGbps">Default egress threshold
        /// (in Gbps).</param>
        /// <param name="minimumEgressThresholdInGbps">Minimum egress threshold
        /// (in Gbps).</param>
        /// <param name="toleranceFactorForEgress">Tolerance factor for
        /// egress.</param>
        /// <param name="overallIntranetEgressThresholdInGbps">Overall Intranet
        /// egress threshold (in Gbps).</param>
        /// <param name="defaultIntranetEgressThresholdInGbps">Default Intranet
        /// egress threshold (in Gbps).</param>
        /// <param name="minimumIntranetEgressThresholdInGbps">Minimum Intranet
        /// egress threshold (in Gbps).</param>
        /// <param name="toleranceFactorForIntranetEgress">Tolerance factor for
        /// Intranet egress.</param>
        /// <param name="overallTotalIngressThresholdInGbps">Overall total
        /// ingress threshold (in Gbps).</param>
        /// <param name="defaultTotalIngressThresholdInGbps">Default total
        /// ingress threshold (in Gbps).</param>
        /// <param name="minimumTotalIngressThresholdInGbps">Minimum total
        /// ingress threshold (in Gbps).</param>
        /// <param name="toleranceFactorForTotalIngress">Tolerance factor for
        /// total ingress.</param>
        /// <param name="overallTotalEgressThresholdInGbps">Overall total
        /// egress threshold (in Gbps).</param>
        /// <param name="defaultTotalEgressThresholdInGbps">Default total
        /// egress threshold (in Gbps).</param>
        /// <param name="minimumTotalEgressThresholdInGbps">Minimum total
        /// egress threshold (in Gbp</param>
        /// <param name="toleranceFactorForTotalEgress">Tolerance factor for
        /// total egress.</param>
        public FarmPropertiesBase(int? settingsPollingIntervalInSecond = default(int?), int? retentionPeriodForDeletedStorageAccountsInDays = default(int?), int? hostStyleHttpPort = default(int?), int? hostStyleHttpsPort = default(int?), string corsAllowedOriginsList = default(string), string dataCenterUriHostSuffixes = default(string), bool? bandwidthThrottleIsEnabled = default(bool?), int? usageCollectionIntervalInSeconds = default(int?), int? feedbackRefreshIntervalInSeconds = default(int?), int? numberOfAccountsToSync = default(int?), int? defaultThrottleProbabilityDecayIntervalInSeconds = default(int?), int? gracePeriodForFullThrottlingInRefreshIntervals = default(int?), double? gracePeriodMaxThrottleProbability = default(double?), double? overallRequestThresholdInTps = default(double?), double? defaultRequestThresholdInTps = default(double?), double? minimumRequestThresholdInTps = default(double?), double? toleranceFactorForTps = default(double?), double? overallIngressThresholdInGbps = default(double?), double? defaultIngressThresholdInGbps = default(double?), double? minimumIngressThresholdInGbps = default(double?), double? toleranceFactorForIngress = default(double?), double? overallIntranetIngressThresholdInGbps = default(double?), double? defaultIntranetIngressThresholdInGbps = default(double?), double? minimumIntranetIngressThresholdInGbps = default(double?), double? toleranceFactorForIntranetIngress = default(double?), double? overallEgressThresholdInGbps = default(double?), double? defaultEgressThresholdInGbps = default(double?), double? minimumEgressThresholdInGbps = default(double?), double? toleranceFactorForEgress = default(double?), double? overallIntranetEgressThresholdInGbps = default(double?), double? defaultIntranetEgressThresholdInGbps = default(double?), double? minimumIntranetEgressThresholdInGbps = default(double?), double? toleranceFactorForIntranetEgress = default(double?), double? overallTotalIngressThresholdInGbps = default(double?), double? defaultTotalIngressThresholdInGbps = default(double?), double? minimumTotalIngressThresholdInGbps = default(double?), double? toleranceFactorForTotalIngress = default(double?), double? overallTotalEgressThresholdInGbps = default(double?), double? defaultTotalEgressThresholdInGbps = default(double?), double? minimumTotalEgressThresholdInGbps = default(double?), double? toleranceFactorForTotalEgress = default(double?))
        {
            SettingsPollingIntervalInSecond = settingsPollingIntervalInSecond;
            RetentionPeriodForDeletedStorageAccountsInDays = retentionPeriodForDeletedStorageAccountsInDays;
            HostStyleHttpPort = hostStyleHttpPort;
            HostStyleHttpsPort = hostStyleHttpsPort;
            CorsAllowedOriginsList = corsAllowedOriginsList;
            DataCenterUriHostSuffixes = dataCenterUriHostSuffixes;
            BandwidthThrottleIsEnabled = bandwidthThrottleIsEnabled;
            UsageCollectionIntervalInSeconds = usageCollectionIntervalInSeconds;
            FeedbackRefreshIntervalInSeconds = feedbackRefreshIntervalInSeconds;
            NumberOfAccountsToSync = numberOfAccountsToSync;
            DefaultThrottleProbabilityDecayIntervalInSeconds = defaultThrottleProbabilityDecayIntervalInSeconds;
            GracePeriodForFullThrottlingInRefreshIntervals = gracePeriodForFullThrottlingInRefreshIntervals;
            GracePeriodMaxThrottleProbability = gracePeriodMaxThrottleProbability;
            OverallRequestThresholdInTps = overallRequestThresholdInTps;
            DefaultRequestThresholdInTps = defaultRequestThresholdInTps;
            MinimumRequestThresholdInTps = minimumRequestThresholdInTps;
            ToleranceFactorForTps = toleranceFactorForTps;
            OverallIngressThresholdInGbps = overallIngressThresholdInGbps;
            DefaultIngressThresholdInGbps = defaultIngressThresholdInGbps;
            MinimumIngressThresholdInGbps = minimumIngressThresholdInGbps;
            ToleranceFactorForIngress = toleranceFactorForIngress;
            OverallIntranetIngressThresholdInGbps = overallIntranetIngressThresholdInGbps;
            DefaultIntranetIngressThresholdInGbps = defaultIntranetIngressThresholdInGbps;
            MinimumIntranetIngressThresholdInGbps = minimumIntranetIngressThresholdInGbps;
            ToleranceFactorForIntranetIngress = toleranceFactorForIntranetIngress;
            OverallEgressThresholdInGbps = overallEgressThresholdInGbps;
            DefaultEgressThresholdInGbps = defaultEgressThresholdInGbps;
            MinimumEgressThresholdInGbps = minimumEgressThresholdInGbps;
            ToleranceFactorForEgress = toleranceFactorForEgress;
            OverallIntranetEgressThresholdInGbps = overallIntranetEgressThresholdInGbps;
            DefaultIntranetEgressThresholdInGbps = defaultIntranetEgressThresholdInGbps;
            MinimumIntranetEgressThresholdInGbps = minimumIntranetEgressThresholdInGbps;
            ToleranceFactorForIntranetEgress = toleranceFactorForIntranetEgress;
            OverallTotalIngressThresholdInGbps = overallTotalIngressThresholdInGbps;
            DefaultTotalIngressThresholdInGbps = defaultTotalIngressThresholdInGbps;
            MinimumTotalIngressThresholdInGbps = minimumTotalIngressThresholdInGbps;
            ToleranceFactorForTotalIngress = toleranceFactorForTotalIngress;
            OverallTotalEgressThresholdInGbps = overallTotalEgressThresholdInGbps;
            DefaultTotalEgressThresholdInGbps = defaultTotalEgressThresholdInGbps;
            MinimumTotalEgressThresholdInGbps = minimumTotalEgressThresholdInGbps;
            ToleranceFactorForTotalEgress = toleranceFactorForTotalEgress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the polling interval (in second).
        /// </summary>
        [JsonProperty(PropertyName = "settings.settingsPollingIntervalInSecond")]
        public int? SettingsPollingIntervalInSecond { get; set; }

        /// <summary>
        /// Gets or sets the retention period (in days) for deleted storage
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "settings.retentionPeriodForDeletedStorageAccountsInDays")]
        public int? RetentionPeriodForDeletedStorageAccountsInDays { get; set; }

        /// <summary>
        /// Gets or sets host style HTTP port.
        /// </summary>
        [JsonProperty(PropertyName = "settings.hostStyleHttpPort")]
        public int? HostStyleHttpPort { get; set; }

        /// <summary>
        /// Gets or sets host style HTTPs port.
        /// </summary>
        [JsonProperty(PropertyName = "settings.hostStyleHttpsPort")]
        public int? HostStyleHttpsPort { get; set; }

        /// <summary>
        /// Gets or sets the list of allowed origins.
        /// </summary>
        [JsonProperty(PropertyName = "settings.corsAllowedOriginsList")]
        public string CorsAllowedOriginsList { get; set; }

        /// <summary>
        /// Gets or sets the suffixes of URI of hosts in data center.
        /// </summary>
        [JsonProperty(PropertyName = "settings.dataCenterUriHostSuffixes")]
        public string DataCenterUriHostSuffixes { get; set; }

        /// <summary>
        /// Gets or sets switch of bandwidth throttle enablement.
        /// </summary>
        [JsonProperty(PropertyName = "settings.bandwidthThrottleIsEnabled")]
        public bool? BandwidthThrottleIsEnabled { get; set; }

        /// <summary>
        /// Gets or sets interval (in seconds) of storage usage collection.
        /// </summary>
        [JsonProperty(PropertyName = "settings.usageCollectionIntervalInSeconds")]
        public int? UsageCollectionIntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets interval (in seconds) of feedback refresh.
        /// </summary>
        [JsonProperty(PropertyName = "settings.feedbackRefreshIntervalInSeconds")]
        public int? FeedbackRefreshIntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets number of accounts to sync.
        /// </summary>
        [JsonProperty(PropertyName = "settings.numberOfAccountsToSync")]
        public int? NumberOfAccountsToSync { get; set; }

        /// <summary>
        /// Gets or sets interval (in seconds) of default throttle probability
        /// decay.
        /// </summary>
        [JsonProperty(PropertyName = "settings.defaultThrottleProbabilityDecayIntervalInSeconds")]
        public int? DefaultThrottleProbabilityDecayIntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets grace period for full throttling in refresh intervals.
        /// </summary>
        [JsonProperty(PropertyName = "settings.gracePeriodForFullThrottlingInRefreshIntervals")]
        public int? GracePeriodForFullThrottlingInRefreshIntervals { get; set; }

        /// <summary>
        /// Gets or sets maximum probability of throttle in grace period.
        /// </summary>
        [JsonProperty(PropertyName = "settings.gracePeriodMaxThrottleProbability")]
        public double? GracePeriodMaxThrottleProbability { get; set; }

        /// <summary>
        /// Gets or sets overall request threshold (in TPS).
        /// </summary>
        [JsonProperty(PropertyName = "settings.overallRequestThresholdInTps")]
        public double? OverallRequestThresholdInTps { get; set; }

        /// <summary>
        /// Gets or sets default request threshold (in TPS).
        /// </summary>
        [JsonProperty(PropertyName = "settings.defaultRequestThresholdInTps")]
        public double? DefaultRequestThresholdInTps { get; set; }

        /// <summary>
        /// Gets or sets minimum request threshold (in TPS).
        /// </summary>
        [JsonProperty(PropertyName = "settings.minimumRequestThresholdInTps")]
        public double? MinimumRequestThresholdInTps { get; set; }

        /// <summary>
        /// Gets or sets tolerance factor for TPS.
        /// </summary>
        [JsonProperty(PropertyName = "settings.toleranceFactorForTps")]
        public double? ToleranceFactorForTps { get; set; }

        /// <summary>
        /// Gets or sets overall ingress threshold (in Gbps)
        /// </summary>
        [JsonProperty(PropertyName = "settings.overallIngressThresholdInGbps")]
        public double? OverallIngressThresholdInGbps { get; set; }

        /// <summary>
        /// Gets or sets default ingress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "settings.defaultIngressThresholdInGbps")]
        public double? DefaultIngressThresholdInGbps { get; set; }

        /// <summary>
        /// Gets or sets minimum ingress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "settings.minimumIngressThresholdInGbps")]
        public double? MinimumIngressThresholdInGbps { get; set; }

        /// <summary>
        /// Gets or sets tolerance factor for ingress.
        /// </summary>
        [JsonProperty(PropertyName = "settings.toleranceFactorForIngress")]
        public double? ToleranceFactorForIngress { get; set; }

        /// <summary>
        /// Gets or sets overall Intranet ingress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "settings.overallIntranetIngressThresholdInGbps")]
        public double? OverallIntranetIngressThresholdInGbps { get; set; }

        /// <summary>
        /// Gets or sets default Intranet ingress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "settings.defaultIntranetIngressThresholdInGbps")]
        public double? DefaultIntranetIngressThresholdInGbps { get; set; }

        /// <summary>
        /// Gets or sets minimum Intranet ingress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "settings.minimumIntranetIngressThresholdInGbps")]
        public double? MinimumIntranetIngressThresholdInGbps { get; set; }

        /// <summary>
        /// Gets or sets tolerance factor for Intranet ingress.
        /// </summary>
        [JsonProperty(PropertyName = "settings.toleranceFactorForIntranetIngress")]
        public double? ToleranceFactorForIntranetIngress { get; set; }

        /// <summary>
        /// Gets or sets overall egress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "settings.overallEgressThresholdInGbps")]
        public double? OverallEgressThresholdInGbps { get; set; }

        /// <summary>
        /// Gets or sets default egress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "settings.defaultEgressThresholdInGbps")]
        public double? DefaultEgressThresholdInGbps { get; set; }

        /// <summary>
        /// Gets or sets minimum egress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "settings.minimumEgressThresholdInGbps")]
        public double? MinimumEgressThresholdInGbps { get; set; }

        /// <summary>
        /// Gets or sets tolerance factor for egress.
        /// </summary>
        [JsonProperty(PropertyName = "settings.toleranceFactorForEgress")]
        public double? ToleranceFactorForEgress { get; set; }

        /// <summary>
        /// Gets or sets overall Intranet egress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "settings.overallIntranetEgressThresholdInGbps")]
        public double? OverallIntranetEgressThresholdInGbps { get; set; }

        /// <summary>
        /// Gets or sets default Intranet egress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "settings.defaultIntranetEgressThresholdInGbps")]
        public double? DefaultIntranetEgressThresholdInGbps { get; set; }

        /// <summary>
        /// Gets or sets minimum Intranet egress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "settings.minimumIntranetEgressThresholdInGbps")]
        public double? MinimumIntranetEgressThresholdInGbps { get; set; }

        /// <summary>
        /// Gets or sets tolerance factor for Intranet egress.
        /// </summary>
        [JsonProperty(PropertyName = "settings.toleranceFactorForIntranetEgress")]
        public double? ToleranceFactorForIntranetEgress { get; set; }

        /// <summary>
        /// Gets or sets overall total ingress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "settings.overallTotalIngressThresholdInGbps")]
        public double? OverallTotalIngressThresholdInGbps { get; set; }

        /// <summary>
        /// Gets or sets default total ingress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "settings.defaultTotalIngressThresholdInGbps")]
        public double? DefaultTotalIngressThresholdInGbps { get; set; }

        /// <summary>
        /// Gets or sets minimum total ingress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "settings.minimumTotalIngressThresholdInGbps")]
        public double? MinimumTotalIngressThresholdInGbps { get; set; }

        /// <summary>
        /// Gets or sets tolerance factor for total ingress.
        /// </summary>
        [JsonProperty(PropertyName = "settings.toleranceFactorForTotalIngress")]
        public double? ToleranceFactorForTotalIngress { get; set; }

        /// <summary>
        /// Gets or sets overall total egress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "settings.overallTotalEgressThresholdInGbps")]
        public double? OverallTotalEgressThresholdInGbps { get; set; }

        /// <summary>
        /// Gets or sets default total egress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "settings.defaultTotalEgressThresholdInGbps")]
        public double? DefaultTotalEgressThresholdInGbps { get; set; }

        /// <summary>
        /// Gets or sets minimum total egress threshold (in Gbp
        /// </summary>
        [JsonProperty(PropertyName = "settings.minimumTotalEgressThresholdInGbps")]
        public double? MinimumTotalEgressThresholdInGbps { get; set; }

        /// <summary>
        /// Gets or sets tolerance factor for total egress.
        /// </summary>
        [JsonProperty(PropertyName = "settings.toleranceFactorForTotalEgress")]
        public double? ToleranceFactorForTotalEgress { get; set; }

    }
}
