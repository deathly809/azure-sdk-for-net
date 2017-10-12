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
                var operation = client.PublicIPAddresses.List();
            });
        }
    }
}
