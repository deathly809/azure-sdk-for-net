// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Network.Admin;
using Microsoft.AzureStack.Management.Network.Admin.Models;
using Xunit;

namespace Network.Tests
{
    public class LoadBalancers : NetworkTestBase
    {
        private void AssertLoadBalancersAreSame(LoadBalancer expected, LoadBalancer found)
        {
            if (expected == null)
            {
                Assert.Null(found);
            }
            else
            {
                Assert.True(NetworkCommon.CheckBaseResourcesAreSame(expected, found));

                Assert.Equal(expected.LoadBalancerName, found.LoadBalancerName);
                Assert.Equal(expected.PublicIpAddress, found.PublicIpAddress);
                Assert.Equal(expected.TenantResourceUri, found.TenantResourceUri);
            }
        }

        [Fact]
        public void TestGetAllLoadBalancers()
        {
            RunTest((client) =>
            {
                var balancers = client.LoadBalancers.List();
                if (balancers != null)
                {
                    Common.MapOverIPage(balancers, client.LoadBalancers.ListNext, (loadBalancer) =>
                    {
                        var retrieved = client.LoadBalancers.Get(loadBalancer.Name);
                        AssertLoadBalancersAreSame(loadBalancer, retrieved);
                    });
                }
            });
        }

        [Fact]
        public void TestGetLoadBalancers()
        {
            RunTest((client) =>
            {
                var balancer = client.LoadBalancers.List().GetFirst();
                if (balancer != null)
                {
                    var retrieved = client.LoadBalancers.Get(balancer.Name);
                    AssertLoadBalancersAreSame(balancer, retrieved);
                }
            });
        }
    }
}
