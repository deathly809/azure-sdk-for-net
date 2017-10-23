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
        private void AssertQuotasAreSame(Quota expected, Quota found)
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

        private Quota CreateTestQuota()
        {
            var newQuota = new Quota()
            {
                MaxPublicIpsPerSubscription = 32,
                MaxVnetsPerSubscription = 32,
                MaxVirtualNetworkGatewaysPerSubscription = 32,
                MaxVirtualNetworkGatewayConnectionsPerSubscription = 32,
                MaxLoadBalancersPerSubscription = 32,
                MaxNicsPerSubscription = 4,
                MaxSecurityGroupsPerSubscription = 2
            };
            return newQuota;
        }

        [Fact]
        public void TestPutAndDeleteQuota()
        {
            RunTest((client) =>
            {
                var quotaName = "TestQuotaForRemoval";
                var newQuota = CreateTestQuota();

                var retrieved = client.Quotas.Get(Location, quotaName);
                if (retrieved != null)
                {
                    // Delete quota
                    Console.WriteLine("Deleting quota...");
                    client.Quotas.Delete(Location, quotaName);
                    Thread.Sleep(10000);
                }

                var quota = client.Quotas.CreateOrUpdate(Location, quotaName, newQuota);
                var created = client.Quotas.Get(Location, quotaName);

                AssertQuotasAreSame(quota, created);

                client.Quotas.Delete(Location, quotaName);
                Thread.Sleep(10000);

                var deleted = client.Quotas.Get(Location, quotaName);
                Assert.Null(deleted);
            });
        }

        [Fact]
        public void TestPutAndUpdateQuota()
        {
            RunTest((client) =>
            {
                var quotaName = "TestQuotaForUpdate";
                var newQuota = CreateTestQuota();

                var retrieved = client.Quotas.Get(Location, quotaName);
                if (retrieved != null)
                {
                    // Delete quota
                    Console.WriteLine("Deleting quota...");
                    client.Quotas.Delete(Location, quotaName);
                    Thread.Sleep(10000);
                }

                var quota = client.Quotas.CreateOrUpdate(Location, quotaName, newQuota);
                var created = client.Quotas.Get(Location, quotaName);

                AssertQuotasAreSame(quota, created);
                created.MaxNicsPerSubscription = 8;

                var updatedQuota = client.Quotas.CreateOrUpdate(Location, quotaName, newQuota);

                AssertQuotasAreSame(updatedQuota, created);

                client.Quotas.Delete(Location, quotaName);
                Thread.Sleep(10000);

                var deleted = client.Quotas.Get(Location, quotaName);
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
    }
}
