// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Network.Admin
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ConnectionSkusOperations.
    /// </summary>
    public static partial class ConnectionSkusOperationsExtensions
    {
            /// <summary>
            /// Get a list of connection skus.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<VirtualNetworkGatewayConnectionSku> List(this IConnectionSkusOperations operations, string location, ODataQuery<VirtualNetworkGatewayConnectionSku> odataQuery = default(ODataQuery<VirtualNetworkGatewayConnectionSku>))
            {
                return operations.ListAsync(location, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of connection skus.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualNetworkGatewayConnectionSku>> ListAsync(this IConnectionSkusOperations operations, string location, ODataQuery<VirtualNetworkGatewayConnectionSku> odataQuery = default(ODataQuery<VirtualNetworkGatewayConnectionSku>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(location, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get connection sku by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='resourceName'>
            /// Name of the resource.
            /// </param>
            public static VirtualNetworkGatewayConnectionSku Get(this IConnectionSkusOperations operations, string location, string resourceName)
            {
                return operations.GetAsync(location, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get connection sku by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='resourceName'>
            /// Name of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkGatewayConnectionSku> GetAsync(this IConnectionSkusOperations operations, string location, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(location, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a given virtual network gateway connection sku.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='resourceName'>
            /// Name of the resource.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionSku'>
            /// Virtual Network Gateway Connection Sku.
            /// </param>
            public static VirtualNetworkGatewayConnectionSku CreateOrUpdate(this IConnectionSkusOperations operations, string location, string resourceName, VirtualNetworkGatewayConnectionSku virtualNetworkGatewayConnectionSku)
            {
                return operations.CreateOrUpdateAsync(location, resourceName, virtualNetworkGatewayConnectionSku).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a given virtual network gateway connection sku.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='resourceName'>
            /// Name of the resource.
            /// </param>
            /// <param name='virtualNetworkGatewayConnectionSku'>
            /// Virtual Network Gateway Connection Sku.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkGatewayConnectionSku> CreateOrUpdateAsync(this IConnectionSkusOperations operations, string location, string resourceName, VirtualNetworkGatewayConnectionSku virtualNetworkGatewayConnectionSku, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(location, resourceName, virtualNetworkGatewayConnectionSku, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a virtual network gateway connection sku by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='resourceName'>
            /// Name of the resource.
            /// </param>
            public static void Delete(this IConnectionSkusOperations operations, string location, string resourceName)
            {
                operations.DeleteAsync(location, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a virtual network gateway connection sku by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='resourceName'>
            /// Name of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IConnectionSkusOperations operations, string location, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(location, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get a list of connection skus.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualNetworkGatewayConnectionSku> ListNext(this IConnectionSkusOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of connection skus.
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
            public static async Task<IPage<VirtualNetworkGatewayConnectionSku>> ListNextAsync(this IConnectionSkusOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
