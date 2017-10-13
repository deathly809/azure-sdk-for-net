// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Network.Admin;
using Microsoft.AzureStack.Management.Network.Admin.Models;
using Xunit;

namespace Network.Tests
{
    public class BackendAddressPoolsTests : NetworkTestBase
    {
        private void AssertBackendAddressPoolsAreSame(BackendAddressPool expected, BackendAddressPool found)
        {
            if (expected == null)
            {
                Assert.Null(found);
            }
            else
            {
                Assert.True(NetworkCommon.CheckBaseResourcesAreSame(expected, found));

                Assert.Equal(expected.ProvisioningState, found.ProvisioningState);
                Assert.Equal(expected.StartIpAddress, found.StartIpAddress);
                Assert.Equal(expected.EndIpAddress, found.EndIpAddress);
                Assert.Equal(expected.NumberOfIPAddresses, found.NumberOfIPAddresses);
                Assert.Equal(expected.NumberOfIPAddressesAllocated, found.NumberOfIPAddressesAllocated);
                Assert.Equal(expected.NumberOfIPAddressesInTransition, found.NumberOfIPAddressesInTransition);
            }
        }

        [Fact]
        public void TestGetAllBackendAddressPools()
        {
            RunTest((client) => {
                var pools = client.BackendAddressPools.List();
                if (pools != null)
                {
                    Common.MapOverIPage(pools, client.BackendAddressPools.ListNext, (pool) =>
                    {
                        // GET isn't implemented
                        //var retrieved = client.BackendAddressPools.Get(pool.Name);
                        //AssertBackendAddressPoolsAreSame(pool, retrieved);

                        NetworkCommon.ValidateBaseResources(pool);

                        Assert.NotNull(pool.ProvisioningState);
                        Assert.NotNull(pool.StartIpAddress);
                        Assert.NotNull(pool.EndIpAddress);
                        Assert.NotNull(pool.NumberOfIPAddresses);
                        Assert.NotNull(pool.NumberOfIPAddressesAllocated);
                        Assert.NotNull(pool.NumberOfIPAddressesInTransition);
                    });
                }
            });
        }

        [Fact(Skip = "Get isn't implemented")]
        public void TestGetBackendAddressPool()
        {
            RunTest((client) =>
            {
                var pool = client.BackendAddressPools.List().GetFirst();
                if (pool != null)
                {
                    var retrieved = client.BackendAddressPools.Get(pool.Name);
                    AssertBackendAddressPoolsAreSame(pool, retrieved);
                }
            });
        }
    }
}