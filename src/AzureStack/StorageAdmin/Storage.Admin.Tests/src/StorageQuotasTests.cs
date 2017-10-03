using System.Linq;
using Microsoft.AzureStack.Management.Storage.Admin;
using Microsoft.AzureStack.Management.Storage.Admin.Models;
using Xunit;

namespace Storage.Tests
{
    public class StorageQuotasTests : StorageTestBase
    {
        private void AssertStorageQuotasAreSame(StorageQuota expected, StorageQuota found) {
            if (expected == null)
            {
                Assert.NotNull(found);
            }
            else
            {
                Assert.NotNull(found);
                Assert.Equal(expected.CapacityInGb, found.CapacityInGb);
                Assert.Equal(expected.NumberOfStorageAccounts, found.NumberOfStorageAccounts);
            }
        }

        private void ValidateQuota(StorageQuota quota) {
            Assert.NotNull(quota);
            Assert.NotNull(quota.CapacityInGb);
            Assert.NotNull(quota.NumberOfStorageAccounts);
        }

        [Fact]
        public void TestListAllStorageQuotas() {
            RunTest((client) => {
                var quotas = client.Quotas.List(Location);
                Common.WriteIEnumerableToFile(quotas, "ListAllStorageQuotas.txt");
            });
        }

        [Fact]
        public void TestGetStorageQuota() {
            RunTest((client) => {
                var quota = client.Quotas.List(Location).First();
                var retrieved = client.Quotas.Get(Location, quota.Name.Replace(Location + "/", ""));
                AssertStorageQuotasAreSame(quota, retrieved);
            });
        }

        [Fact]
        public void TestGetAllStorageQuotas() {
            RunTest((client) => {
                var quotas = client.Quotas.List(Location);
                foreach(var quota in quotas)
                {
                    var retrieved = client.Quotas.Get(Location, quota.Name.Replace(Location + "/", ""));
                    AssertStorageQuotasAreSame(quota, retrieved);
                }
            });
        }

        [Fact]
        public void TestCreateQuota() {
            RunTest((client) => {
                var quotaName = "TestCreateQuota";
                IgnoreExceptions(() => client.Quotas.Delete(Location, quotaName));

                var parameters = new StorageQuotaParameters()
                {
                    CapacityInGb = -100000000,
                    NumberOfStorageAccounts = -1000000000
                };
                var retrieved = client.Quotas.CreateOrUpdate(Location, quotaName, parameters);

                Assert.NotNull(retrieved);
                Assert.Equal(parameters.CapacityInGb, retrieved.CapacityInGb);
                Assert.Equal(parameters.NumberOfStorageAccounts, retrieved.NumberOfStorageAccounts);
                retrieved = client.Quotas.Get(Location, quotaName);

                IgnoreExceptions(() => client.Quotas.Delete(Location, quotaName));
            });
        }

        [Fact]
        public void TestUpdateQuota() {
            RunTest((client) => {
                var quotaName = "TestUpdateQuota";
                IgnoreExceptions(() => client.Quotas.Delete(Location, quotaName));

                var parameters = new StorageQuotaParameters()
                {
                    CapacityInGb = 50,
                    NumberOfStorageAccounts = 100
                };
                var retrieved = client.Quotas.CreateOrUpdate(Location, quotaName, parameters);
                Assert.NotNull(retrieved);
                Assert.Equal(parameters.CapacityInGb, retrieved.CapacityInGb);
                Assert.Equal(parameters.NumberOfStorageAccounts, retrieved.NumberOfStorageAccounts);

                parameters.CapacityInGb = 123;
                parameters.NumberOfStorageAccounts = 10;
                retrieved = client.Quotas.CreateOrUpdate(Location, quotaName, parameters);
                Assert.NotNull(retrieved);
                Assert.Equal(parameters.CapacityInGb, retrieved.CapacityInGb);
                Assert.Equal(parameters.NumberOfStorageAccounts, retrieved.NumberOfStorageAccounts);

                IgnoreExceptions(() => client.Quotas.Delete(Location, quotaName));
            });
        }

        [Fact]
        public void TestDeleteQuota() {
            RunTest((client) => {
                var quotaName = $"TestDeleteQuota";
                IgnoreExceptions(() => client.Quotas.Delete(Location, quotaName));

                var parameters = new StorageQuotaParameters() 
                {
                    CapacityInGb = 0,
                    NumberOfStorageAccounts = -1
                };
                IgnoreExceptions(() => client.Quotas.CreateOrUpdate(Location, quotaName, parameters));
                client.Quotas.Delete(Location, quotaName);
            });
        }

    }
}
