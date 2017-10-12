// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Network.Admin;
using Microsoft.AzureStack.Management.Network.Admin.Models;
using Xunit;

namespace Network.Tests
{
    public class LoadBalancerMuxesTests : NetworkTestBase
    {
        [Fact(Skip = "Not officially supported")]
        public void TestGetAllLoadBalancerMuxes()
        {
            RunTest((client) =>
            {
                var muxes = client.LoadBalancerMuxes.List();
                if (muxes != null)
                {
                    Assert.NotNull(muxes.Id);
                }
            });
        }
    }
}
