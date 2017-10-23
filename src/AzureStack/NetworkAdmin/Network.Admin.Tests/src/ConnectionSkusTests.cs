// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Network.Admin;
using Microsoft.AzureStack.Management.Network.Admin.Models;
using System.Collections.Generic;
using Xunit;

namespace Network.Tests
{
    public class ConnectionSkusTests : NetworkTestBase
    {
        private void AssertConnectionSkusAreSame(VirtualNetworkGatewayConnectionSku expected, VirtualNetworkGatewayConnectionSku found)
        {
            if (expected == null)
            {
                Assert.Null(found);
            }
            else
            {
                Assert.True(NetworkCommon.CheckBaseResourcesAreSame(expected, found));

                Assert.Equal(expected.Capabilities, found.Capabilities);
            }
        }

        [Fact]
        public void TestGetAllConnectionSkus()
        {
            RunTest((client) => {
                var skus = client.ConnectionSkus.List(Location);
                if (skus != null)
                {
                    skus.ForEach((sku) =>
                    {
                        var retrieved = client.ConnectionSkus.Get(Location, sku.Name);
                        AssertConnectionSkusAreSame(sku, retrieved);
                    });
                }
            });
        }

        [Fact]
        public void TestGetInvalidConnectionSku()
        {
            RunTest((client) =>
            {
                var sku = client.ConnectionSkus.Get(Location, "NonExistantConnectionSku");
                Assert.Null(null);
            });
        }
    }
}