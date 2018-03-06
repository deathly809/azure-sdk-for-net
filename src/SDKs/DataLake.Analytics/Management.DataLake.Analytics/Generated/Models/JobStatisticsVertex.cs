// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// the detailed information for a vertex.
    /// </summary>
    public partial class JobStatisticsVertex
    {
        /// <summary>
        /// Initializes a new instance of the JobStatisticsVertex class.
        /// </summary>
        public JobStatisticsVertex()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobStatisticsVertex class.
        /// </summary>
        /// <param name="name">the name of the vertex.</param>
        /// <param name="vertexId">the id of the vertex.</param>
        /// <param name="executionTime">the amount of execution time of the
        /// vertex.</param>
        /// <param name="dataRead">the amount of data read of the vertex, in
        /// bytes.</param>
        /// <param name="peakMemUsage">the amount of peak memory usage of the
        /// vertex, in bytes.</param>
        public JobStatisticsVertex(string name = default(string), System.Guid? vertexId = default(System.Guid?), System.TimeSpan? executionTime = default(System.TimeSpan?), long? dataRead = default(long?), long? peakMemUsage = default(long?))
        {
            Name = name;
            VertexId = vertexId;
            ExecutionTime = executionTime;
            DataRead = dataRead;
            PeakMemUsage = peakMemUsage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the vertex.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the id of the vertex.
        /// </summary>
        [JsonProperty(PropertyName = "vertexId")]
        public System.Guid? VertexId { get; private set; }

        /// <summary>
        /// Gets the amount of execution time of the vertex.
        /// </summary>
        [JsonProperty(PropertyName = "executionTime")]
        public System.TimeSpan? ExecutionTime { get; private set; }

        /// <summary>
        /// Gets the amount of data read of the vertex, in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "dataRead")]
        public long? DataRead { get; private set; }

        /// <summary>
        /// Gets the amount of peak memory usage of the vertex, in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "peakMemUsage")]
        public long? PeakMemUsage { get; private set; }

    }
}
