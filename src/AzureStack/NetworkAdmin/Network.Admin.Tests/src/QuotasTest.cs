// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using System;
using System.Threading;
using Microsoft.AzureStack.Management.Network.Admin;
using Microsoft.AzureStack.Management.Network.Admin.Models;
using Xunit;

namespace Network.Tests
{
    public class QuotasTests : NetworkTestBase
    {
        private void AssertQuotasAreSame(NetworkQuota expected, NetworkQuota found)
        {
            if (expected == null)
            {
                Assert.Null(found);
            }
            else
            {
                Assert.True(NetworkCommon.CheckBaseResourcesAreSame(expected, found));

                Assert.Equal(expected.MaxLoadBalancersPerSubscription, found.MaxLoadBalancersPerSubscription);
                Assert.Equal(expected.MaxNicsPerSubscription, found.MaxNicsPerSubscription);
                Assert.Equal(expected.MaxPublicIpsPerSubscription, found.MaxPublicIpsPerSubscription);
                Assert.Equal(expected.MaxSecurityGroupsPerSubscription, found.MaxSecurityGroupsPerSubscription);
                Assert.Equal(expected.MaxVirtualNetworkGatewayConnectionsPerSubscription, found.MaxVirtualNetworkGatewayConnectionsPerSubscription);
                Assert.Equal(expected.MaxVirtualNetworkGatewaysPerSubscription, found.MaxVirtualNetworkGatewaysPerSubscription);
                Assert.Equal(expected.MaxVnetsPerSubscription, found.MaxVnetsPerSubscription);
                Assert.Equal(expected.MigrationPhase, found.MigrationPhase);
            }
        }

        [Fact]
        public void TestGetQuota()
        {
            RunTest((client) =>
            {
                var quota = client.Quotas.List(Location).GetFirst();
                if (quota != null)
                {
                    var retrieved = client.Quotas.Get(Location, quota.Name);
                    AssertQuotasAreSame(quota, retrieved);
                }
            });
        }

        [Fact]
        public void TestGetAllQuotas()
        {
            RunTest((client) =>
            {
                var quotas = client.Quotas.List(Location);
                if (quotas != null)
                {
                    Common.MapOverIPage(quotas, client.Quotas.ListNext, (quota) =>
                    {
                        var retrieved = client.Quotas.Get(Location, quota.Name);
                        AssertQuotasAreSame(quota, retrieved);
                    });
                }
            });
        }

        private NetworkQuota CreateTestNetworkQuota()
        {
            var newNetworkQuota = new NetworkQuota()
            {
                MaxPublicIpsPerSubscription = 32,
                MaxVnetsPerSubscription = 32,
                MaxVirtualNetworkGatewaysPerSubscription = 32,
                MaxVirtualNetworkGatewayConnectionsPerSubscription = 32,
                MaxLoadBalancersPerSubscription = 32,
                MaxNicsPerSubscription = 4,
                MaxSecurityGroupsPerSubscription = 2
            };
            return newNetworkQuota;
        }

        [Fact]
        public void TestPutAndDeleteQuota()
        {
            RunTest((client) =>
            {
                var networkQuotaName = "TestQuotaForRemoval";
                var newNetworkQuota = CreateTestNetworkQuota();

                Console.WriteLine("Checking for existing quota...");
                var retrieved = client.Quotas.Get(Location, networkQuotaName);
                if (retrieved != null)
                {
                    // Delete quota
                    Console.WriteLine("Deleting quota...");
                    client.Quotas.Delete(Location, networkQuotaName);
                    Thread.Sleep(20000);
                }

                Console.WriteLine("Creating new test quota...");
                var quota = client.Quotas.Create(Location, networkQuotaName, newNetworkQuota);
                var created = client.Quotas.Get(Location, networkQuotaName);

                AssertQuotasAreSame(quota, created);

                Console.WriteLine("Deleting quota...");
                client.Quotas.Delete(Location, networkQuotaName);
                Thread.Sleep(20000);

                var deleted = client.Quotas.Get(Location, networkQuotaName);
                Assert.Null(deleted);
            });
        }

        [Fact]
        public void TestGetQuotaInvalid()
        {
            RunTest((client) =>
            {
                var quota = client.Quotas.Get(Location, "NonExistantQuota");
                Assert.Null(quota);
            });
        }
        [Fact(Skip = "Defaulting to local")]
        public void TestGetQuotaInvalidLocation()
        {
            RunTest((client) =>
            {
                var quota = client.Quotas.Get("InvalidateLocation", "Default Quota");
                Assert.Null(quota);
            });
        }

        [Fact(Skip = "BUG 14218404")]
        public void TestGetAllQuotasInvalidLocation()
        {
            RunTest((client) =>
            {
                var quotas = client.Quotas.List("InvalidLocation");
                Assert.Null(quotas);
            });
        }
    }
}
