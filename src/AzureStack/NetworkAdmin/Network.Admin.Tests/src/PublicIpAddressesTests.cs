// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Network.Admin;
using Microsoft.AzureStack.Management.Network.Admin.Models;
using Xunit;

namespace Network.Tests
{
    public class PublicIPAddressesTests : NetworkTestBase
    {
        private void Setup()
        {
            // TODO Setup public IP Address
        }

        [Fact]
        public void TestGetAllPublicIpAddresses()
        {
            RunTest((client) =>
            {
                var addresses = client.PublicIPAddresses.List();
                if (addresses != null)
                {
                    Common.MapOverIPage(addresses, client.PublicIPAddresses.ListNext, (address) =>
                    {
                        NetworkCommon.ValidateBaseResources(address);

                        NetworkCommon.ValidateBaseResourceTenant(address);

                        Assert.NotNull(address.IpAddress);
                        Assert.NotNull(address.IpPool);
                    });
                }
                else
                {
                    // Setup
                }
            });
        }
    }
}
