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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PublicIPAddressesOperations.
    /// </summary>
    public static partial class PublicIPAddressesOperationsExtensions
    {
            /// <summary>
            /// List of public ip addresses.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='inlineCount'>
            /// OData inline count parameter.
            /// </param>
            public static IEnumerable<PublicIpAddresses> List(this IPublicIPAddressesOperations operations, ODataQuery<PublicIpAddresses> odataQuery = default(ODataQuery<PublicIpAddresses>), string inlineCount = default(string))
            {
                return operations.ListAsync(odataQuery, inlineCount).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List of public ip addresses.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='inlineCount'>
            /// OData inline count parameter.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<PublicIpAddresses>> ListAsync(this IPublicIPAddressesOperations operations, ODataQuery<PublicIpAddresses> odataQuery = default(ODataQuery<PublicIpAddresses>), string inlineCount = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, inlineCount, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
