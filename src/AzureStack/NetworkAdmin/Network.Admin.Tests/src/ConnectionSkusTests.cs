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

                AssertSkuCapabilitiyAreSame(expected.Capabilities, found.Capabilities);
            }
        }

        private void AssertSkuCapabilitiyAreSame(IList<SkuCapabilityProperties> expected, IList<SkuCapabilityProperties> found)
        {
            if (expected == null)
            {
                Assert.Null(found);
            }
            else
            {
                Assert.Equal(expected.Count, found.Count);

                for (int i = 0; i < expected.Count; i++)
                {
                    var expectedCapability = expected[i];
                    var foundCapability = found[i];

                    Assert.Equal(expectedCapability.Name, foundCapability.Name);
                    Assert.Equal(expectedCapability.Value, foundCapability.Value);
                }
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

        private List<SkuCapabilityProperties> CreateTestCapabilitiesList()
        {
            var skuList = new List<SkuCapabilityProperties>
            {
                new SkuCapabilityProperties()
                {
                    Name = "GatewayPool",
                    Value = "default"
                },
                new SkuCapabilityProperties()
                {
                    Name = "Type",
                    Value = "IPSec"
                },
                new SkuCapabilityProperties()
                {
                    Name = "TxBandwidthInMegabitsPerSecond",
                    Value = "50"
                },
                new SkuCapabilityProperties()
                {
                    Name = "RxBandwidthInMegabitsPerSecond",
                    Value = "50"
                }
            };
            return skuList;
        }

        private List<SkuCapabilityProperties> UpdateTestCapabilitiesList()
        {
            var skuList = new List<SkuCapabilityProperties>
            {
                new SkuCapabilityProperties()
                {
                    Name = "GatewayPool",
                    Value = "default"
                },
                new SkuCapabilityProperties()
                {
                    Name = "Type",
                    Value = "IPSec"
                },
                new SkuCapabilityProperties()
                {
                    Name = "TxBandwidthInMegabitsPerSecond",
                    Value = "80"
                },
                new SkuCapabilityProperties()
                {
                    Name = "RxBandwidthInMegabitsPerSecond",
                    Value = "80"
                }
            };
            return skuList;
        }

        private VirtualNetworkGatewayConnectionSku CreateTestSku()
        {
            return new VirtualNetworkGatewayConnectionSku()
            {
                Capabilities = CreateTestCapabilitiesList()
            };
        }

        [Fact]
        public void TestPutAndDeleteConnectionSku()
        {
            RunTest((client) => {
                var skuName = "TestVirtualNetworkGatewayConnectionSkuForRemoval";
                var newSku = CreateTestSku();

                var retrieved = client.ConnectionSkus.Get(Location, skuName);
                if (retrieved != null)
                {
                    // Delete sku
                    client.ConnectionSkus.Delete(Location, skuName);
                }

                var sku = client.ConnectionSkus.CreateOrUpdate(Location, skuName, newSku);
                var created = client.ConnectionSkus.Get(Location, skuName);
                AssertConnectionSkusAreSame(sku, created);

                client.ConnectionSkus.Delete(Location, skuName);

                var deleted = client.ConnectionSkus.Get(Location, skuName);
                Assert.Null(deleted);
            });
        }

        [Fact]
        public void TestUpdateConnectionSku()
        {
            RunTest((client) => {
                var skuName = "TestVirtualNetworkGatewayConnectionSkuForUpdate";
                var newSku = CreateTestSku();

                var retrieved = client.ConnectionSkus.Get(Location, skuName);
                if (retrieved != null)
                {
                    // Delete sku
                    client.ConnectionSkus.Delete(Location, skuName);
                }

                var sku = client.ConnectionSkus.CreateOrUpdate(Location, skuName, newSku);
                var created = client.ConnectionSkus.Get(Location, skuName);
                AssertConnectionSkusAreSame(sku, created);

                // Change capability
                created.Capabilities = UpdateTestCapabilitiesList();

                var updatedSku = client.ConnectionSkus.CreateOrUpdate(Location, skuName, created);
                var getUpdatedSku = client.ConnectionSkus.Get(Location, skuName);
                AssertConnectionSkusAreSame(updatedSku, getUpdatedSku);

                client.ConnectionSkus.Delete(Location, skuName);

                var deleted = client.ConnectionSkus.Get(Location, skuName);
                Assert.Null(deleted);
            });
        }

        [Fact]
        public void TestGetInvalidConnectionSku()
        {
            RunTest((client) =>
            {
                var sku = client.ConnectionSkus.Get(Location, "NonExistantConnectionSku");
                Assert.Null(sku);
            });
        }

        [Fact]
        public void TestDeleteInvalidConnectionSku()
        {
            RunTest((client) =>
            {
                var sku = client.ConnectionSkus.Delete(Location, "NonExistantConnectionSku");
                Assert.Null(sku);
            });
        }
    }
}