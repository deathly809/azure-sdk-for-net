// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Compute.Admin;
using Microsoft.AzureStack.Management.Compute.Admin.Models;
using System.Linq;
using Xunit;

namespace Compute.Tests
{
    public class QuotaTests : ComputeTestBase
    {
        // Helper
        private Quota Create(int asc, int cl, int vssc, int vmc) {
            var newQuota = new Quota()
            {
                AvailabilitySetCount = asc,
                CoresLimit = cl,
                VmScaleSetCount = vssc,
                VirtualMachineCount = vmc
            };
            return newQuota;
        }


        private void ValidateQuota(Quota quota) {
            AssertValidResource(quota);
            Assert.NotNull(quota);
            Assert.NotNull(quota.AvailabilitySetCount);
            Assert.NotNull(quota.CoresLimit);
            Assert.NotNull(quota.VirtualMachineCount);
            Assert.NotNull(quota.VmScaleSetCount);
        }

        private void AssertSame(Quota expected, Quota given, bool resourceToo = true) {
            if (resourceToo)
            {
                AssertSameResource(expected, given);
            }
            if (expected == null)
            {
                Assert.Null(given);
            }
            else
            {
                Assert.NotNull(given);
                Assert.Equal(expected.AvailabilitySetCount, given.AvailabilitySetCount);
                Assert.Equal(expected.CoresLimit, given.CoresLimit);
                Assert.Equal(expected.VirtualMachineCount, given.VirtualMachineCount);
                Assert.Equal(expected.VmScaleSetCount, given.VmScaleSetCount);
            }
        }

        [Fact]
        public void TestListQuotas() {
            RunTest((client) => {

                var quotas = client.Quotas.List("local");
                Assert.NotNull(quotas);
                quotas.ForEach(ValidateQuota);
            });
        }

        [Fact]
        public void TestGetQuota() {
            RunTest((client) => {
                var quota = client.Quotas.List("local").FirstOrDefault();
                var result = client.Quotas.Get("local", quota.Name);
                AssertSame(quota, result);
            });
        }

        [Fact]
        public void TestGetAllQuotas() {
            RunTest((client) => {
                var quotas = client.Quotas.List("local");
                quotas.ForEach((quota) => {
                    var result = client.Quotas.Get("local", quota.Name);
                    AssertSame(quota, result);
                });
            });
        }
        
        [Fact]
        public void TestCreateQuota() {
            RunTest((client) => {

                var location = "local";
                var quotaNamePrefix = "testQuota";

                var data = new System.Collections.Generic.List<int[]>  {
                    new [] { 0, 0, 0, 0, 0 },
                    new [] { 0, 1, 0, 0, 1 },
                    new [] { 0, 0, 1, 0 , 2},
                    new [] { 0, 0, 0, 1 , 3},
                    new [] { 100, 100, 100, 100 , 4},
                    new [] { 1000, 1000, 1000, 1000 , 5}
                };

                data.ForEach((d) => {
                    var name = quotaNamePrefix + d[4];
                    var newQuota = Create(d[0], d[1], d[2], d[3]);
                    var quota = client.Quotas.Create(location, name, newQuota);
                    var result = client.Quotas.Get(location, name);
                    AssertSame(quota, result, false);
                });

                data.ForEach((d) => {
                    var name = quotaNamePrefix + d[4];
                    var list = client.Quotas.List(location);
                    Assert.Equal(1, list.Count((q) => q.Name.Equals(name)));
                });

                data.ForEach((d) => {
                    var name = quotaNamePrefix + d[4];
                    client.Quotas.Delete(location, name);
                    var result = client.Quotas.Get(location, name);
                    Assert.Null(result);
                });
            });
        }

        #region Test With Invalid data


        [Fact]
        public void TestCreateInvalidQuota() {
            RunTest((client) => {
                var name = "myQuota";
                Assert.ThrowsAny<System.Exception>(() => client.Quotas.Create("local", name, Create(-1, 1, 1, 1)));
                Assert.ThrowsAny<System.Exception>(() => client.Quotas.Create("local", name, Create(1, -1, 1, 1)));
                Assert.ThrowsAny<System.Exception>(() => client.Quotas.Create("local", name, Create(1, 1, -1, 1)));
                Assert.ThrowsAny<System.Exception>(() => client.Quotas.Create("local", name, Create(1, 1, 1, -1)));
                Assert.ThrowsAny<System.Exception>(() => client.Quotas.Create("local", name, Create(-1, 0, 0, 0)));
                Assert.ThrowsAny<System.Exception>(() => client.Quotas.Create("local", name, Create(0, -1, 0, 0)));
                Assert.ThrowsAny<System.Exception>(() => client.Quotas.Create("local", name, Create(0, 0, -1, 0)));
                Assert.ThrowsAny<System.Exception>(() => client.Quotas.Create("local", name, Create(0, 0, 0, -1)));
                Assert.ThrowsAny<System.Exception>(() => client.Quotas.Create("local", name, Create(-1, -1, -1, -1)));

            });
        }

        // Invalid Locations

        [Fact(Skip = "CRP does not handle invalid locations correctly.")]
        public void TestListInvalidLocation() {
            RunTest((client) => {
                var list = client.Quotas.List("thisisnotarealplace");
                Assert.Equal(0, list.Count());
            });
        }

        [Fact]
        public void TestDeleteNonExistingQuota() {
            RunTest((client) => {
                client.Quotas.Delete("local", "thisdoesnotexistandifitdoesoops");
            });
        }

        [Fact(Skip = "CRP does not handle invalid locations correctly.")]
        public void TestCreateQuotaOnInvalidLocation() {
            RunTest((client) => {

                var location = "thislocationdoesnotexist";
                var quotaNamePrefix = "testQuota";

                var data = new System.Collections.Generic.List<int[]>  {
                    new [] { 0, 0, 0, 0, 0 },
                    new [] { 0, 1, 0, 0, 1 },
                    new [] { 0, 0, 1, 0 , 2},
                    new [] { 0, 0, 0, 1 , 3},
                    new [] { 100, 100, 100, 100 , 4},
                    new [] { 1000, 1000, 1000, 1000 , 5}
                };

                data.ForEach((d) => {
                    var name = quotaNamePrefix + d[4];
                    var newQuota = Create(d[0], d[1], d[2], d[3]);
                    var quota = client.Quotas.Create(location, name, newQuota);
                    var result = client.Quotas.Get(location, name);
                    Assert.Null(quota);
                    Assert.Null(result);
                });

                data.ForEach((d) => {
                    var name = quotaNamePrefix + d[4];
                    var list = client.Quotas.List(location);
                    Assert.Equal(0, list.Count((q) => q.Name.Equals(name)));
                });
                
            });
        }

        #endregion

    }
}
