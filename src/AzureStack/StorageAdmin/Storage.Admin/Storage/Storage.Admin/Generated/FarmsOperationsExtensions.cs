// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Storage.Admin
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FarmsOperations.
    /// </summary>
    public static partial class FarmsOperationsExtensions
    {
            /// <summary>
            /// Create a new farm
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// The name of the farm.
            /// </param>
            /// <param name='settingAccessStringProperty'>
            /// </param>
            public static Farm Create(this IFarmsOperations operations, string resourceGroupName, string farmId, string settingAccessStringProperty = default(string))
            {
                return operations.CreateAsync(resourceGroupName, farmId, settingAccessStringProperty).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new farm
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// The name of the farm.
            /// </param>
            /// <param name='settingAccessStringProperty'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Farm> CreateAsync(this IFarmsOperations operations, string resourceGroupName, string farmId, string settingAccessStringProperty = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, farmId, settingAccessStringProperty, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get an existing farm
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// The name of the farm.
            /// </param>
            public static Farm Get(this IFarmsOperations operations, string resourceGroupName, string farmId)
            {
                return operations.GetAsync(resourceGroupName, farmId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an existing farm
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// The name of the farm.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Farm> GetAsync(this IFarmsOperations operations, string resourceGroupName, string farmId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, farmId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update an existing farm.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// The name of the farm.
            /// </param>
            /// <param name='settingAccessStringProperty'>
            /// </param>
            public static Farm Update(this IFarmsOperations operations, string resourceGroupName, string farmId, string settingAccessStringProperty = default(string))
            {
                return operations.UpdateAsync(resourceGroupName, farmId, settingAccessStringProperty).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update an existing farm.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// The name of the farm.
            /// </param>
            /// <param name='settingAccessStringProperty'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Farm> UpdateAsync(this IFarmsOperations operations, string resourceGroupName, string farmId, string settingAccessStringProperty = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, farmId, settingAccessStringProperty, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the list of metric definitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// The name of the farm.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<MetricDefinition> ListMetricDefinitions(this IFarmsOperations operations, string resourceGroupName, string farmId, ODataQuery<MetricDefinition> odataQuery = default(ODataQuery<MetricDefinition>))
            {
                return operations.ListMetricDefinitionsAsync(resourceGroupName, farmId, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of metric definitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// The name of the farm.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<MetricDefinition>> ListMetricDefinitionsAsync(this IFarmsOperations operations, string resourceGroupName, string farmId, ODataQuery<MetricDefinition> odataQuery = default(ODataQuery<MetricDefinition>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricDefinitionsWithHttpMessagesAsync(resourceGroupName, farmId, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the list of metrics.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// The name of the farm.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<Metric> ListMetrics(this IFarmsOperations operations, string resourceGroupName, string farmId, ODataQuery<Metric> odataQuery = default(ODataQuery<Metric>))
            {
                return operations.ListMetricsAsync(resourceGroupName, farmId, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of metrics.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// The name of the farm.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Metric>> ListMetricsAsync(this IFarmsOperations operations, string resourceGroupName, string farmId, ODataQuery<Metric> odataQuery = default(ODataQuery<Metric>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricsWithHttpMessagesAsync(resourceGroupName, farmId, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of all farms.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<Farm> List(this IFarmsOperations operations, string resourceGroupName, ODataQuery<Farm> odataQuery = default(ODataQuery<Farm>))
            {
                return operations.ListAsync(resourceGroupName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of all farms.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Farm>> ListAsync(this IFarmsOperations operations, string resourceGroupName, ODataQuery<Farm> odataQuery = default(ODataQuery<Farm>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// TODO
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// The name of the farm.
            /// </param>
            public static string StartGarbageCollect(this IFarmsOperations operations, string resourceGroupName, string farmId)
            {
                return operations.StartGarbageCollectAsync(resourceGroupName, farmId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// TODO
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// The name of the farm.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> StartGarbageCollectAsync(this IFarmsOperations operations, string resourceGroupName, string farmId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.StartGarbageCollectWithHttpMessagesAsync(resourceGroupName, farmId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// TODO
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// The name of the farm.
            /// </param>
            /// <param name='operationId'>
            /// </param>
            public static string GetGarbageCollectState(this IFarmsOperations operations, string resourceGroupName, string farmId, string operationId)
            {
                return operations.GetGarbageCollectStateAsync(resourceGroupName, farmId, operationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// TODO
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// The name of the farm.
            /// </param>
            /// <param name='operationId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GetGarbageCollectStateAsync(this IFarmsOperations operations, string resourceGroupName, string farmId, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGarbageCollectStateWithHttpMessagesAsync(resourceGroupName, farmId, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the list of metric definitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<MetricDefinition> ListMetricDefinitionsNext(this IFarmsOperations operations, string nextPageLink)
            {
                return operations.ListMetricDefinitionsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of metric definitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<MetricDefinition>> ListMetricDefinitionsNextAsync(this IFarmsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricDefinitionsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the list of metrics.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Metric> ListMetricsNext(this IFarmsOperations operations, string nextPageLink)
            {
                return operations.ListMetricsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of metrics.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Metric>> ListMetricsNextAsync(this IFarmsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of all farms.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Farm> ListNext(this IFarmsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of all farms.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Farm>> ListNextAsync(this IFarmsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
