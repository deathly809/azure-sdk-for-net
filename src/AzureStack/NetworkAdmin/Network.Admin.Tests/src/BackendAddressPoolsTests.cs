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
        [Fact]
        public void TestGetAllBackendAddressPools()
        {
            RunTest((client) => {
                var pools = client.BackendAddressPools.List();
                if (pools != null)
                {
                   pools.ForEach((pool) =>
                    {
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
    }
}