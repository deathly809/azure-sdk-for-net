// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Network.Admin;
using Microsoft.AzureStack.Management.Network.Admin.Models;
using Xunit;

namespace Network.Tests
{
    public class VirtualNetworksTests : NetworkTestBase
    {
        [Fact]
        public void TestGetAllVirtualNetworks()
        {
            RunTest((client) =>
            {
                var networks = client.VirtualNetworks.List();
            });
        }

        [Fact(Skip = "Testing")]
        public void TestGetVirtualNetworks()
        {
            RunTest((client) =>
            {
                var network = client.VirtualNetworks.List().GetFirst();

                client.VirtualNetworks.Get(network.Name);
            });
        }
    }
}
