// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using System.Linq;

    /// <summary>
    /// A metric describing the usage of a resource.
    /// </summary>
    public partial class UsageMetric
    {
        /// <summary>
        /// Initializes a new instance of the UsageMetric class.
        /// </summary>
        public UsageMetric() { }

        /// <summary>
        /// Initializes a new instance of the UsageMetric class.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        /// <param name="unit">The units used for the metric.</param>
        /// <param name="currentValue">The current value of the metric.</param>
        /// <param name="limit">The quota limit for the metric.</param>
        /// <param name="nextResetTime">The time that the metric's value will
        /// reset.</param>
        /// <param name="quotaPeriod">The quota period that determines the
        /// length of time between value resets.</param>
        public UsageMetric(MetricName name = default(MetricName), string unit = default(string), double? currentValue = default(double?), double? limit = default(double?), System.DateTime? nextResetTime = default(System.DateTime?), string quotaPeriod = default(string))
        {
            Name = name;
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            NextResetTime = nextResetTime;
            QuotaPeriod = quotaPeriod;
        }

        /// <summary>
        /// Gets or sets the name of the metric.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public MetricName Name { get; set; }

        /// <summary>
        /// Gets or sets the units used for the metric.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets the current value of the metric.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "currentValue")]
        public double? CurrentValue { get; set; }

        /// <summary>
        /// Gets or sets the quota limit for the metric.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Gets or sets the time that the metric's value will reset.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextResetTime")]
        public System.DateTime? NextResetTime { get; set; }

        /// <summary>
        /// Gets or sets the quota period that determines the length of time
        /// between value resets.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "quotaPeriod")]
        public string QuotaPeriod { get; set; }

    }
}
