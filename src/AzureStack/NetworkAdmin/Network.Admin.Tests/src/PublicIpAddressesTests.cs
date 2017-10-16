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

        [Fact]
        public void TestGetAllPublicIpAddresses()
        {
            RunTest((client) =>
            {
                var addresses = client.PublicIPAddresses.List();

                // This test should be using the SessionRecord which has an existing PublicIPAddress created
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
            });
        }

        [Fact(Skip = "Not implemented")]
        public void TestGetPublicIpAddress()
        {
            RunTest((client) =>
            {
                var addresses = client.PublicIPAddresses.Get("192.168.102.32");
            });
        }
    }
}
