// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Network.Admin;
using Microsoft.AzureStack.Management.Network.Admin.Models;
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
                Common.MapOverIPage(skus, client.ConnectionSkus.ListNext, (sku) =>
                {
                    var retrieved = client.ConnectionSkus.Get(Location, sku.Name);
                    AssertConnectionSkusAreSame(sku, retrieved);
                });
            });
        }

        [Fact]
        public void TestGetConnectionSku()
        {
            RunTest((client) =>
            {
                var sku = client.ConnectionSkus.List(Location).GetFirst();
                if (sku != null)
                {
                    var retrieved = client.ConnectionSkus.Get(Location, sku.Name);
                    AssertConnectionSkusAreSame(sku, retrieved);
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

        [Fact]
        public void TestGetInvalidConnectionSkuLocation()
        {
            RunTest((client) =>
            {
                var sku = client.ConnectionSkus.Get("InvalidLocation", "NonExistantConnectionSku");
                Assert.Null(sku);
            });
        }

        public void TestListInvalidConnectionSkuLocation()
        {
            RunTest((client) =>
            {
                var skus = client.ConnectionSkus.List("InvalidLocation");
                Assert.True(skus == null);
            });
        }
    }
}