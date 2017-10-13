using System.Linq;
using Microsoft.AzureStack.Management.Storage.Admin;
using Microsoft.AzureStack.Management.Storage.Admin.Models;
using Xunit;

namespace Storage.Tests
{
    public class StorageQuotasTests : StorageTestBase
    {
        private void AssertAreEqual(StorageQuota expected, StorageQuota found) {
            if (expected == null)
            {
                Assert.NotNull(found);
            }
            else
            {
                ValidateQuota(found);
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
        public void ListAllStorageQuotas() {
            RunTest((client) => {
                var result = client.Quotas.List(Location);
                Common.WriteIEnumerableToFile(result, "ListAllStorageQuotas.txt");
            });
        }

        [Fact]
        public void GetStorageQuota() {
            RunTest((client) => {
                var result = client.Quotas.List(Location).First();
                var retrieved = client.Quotas.Get(Location, result.Name.Replace(Location + "/", ""));
                ValidateQuota(retrieved);
            });
        }

        [Fact]
        public void GetAllStorageQuotas() {
            RunTest((client) => {
                var results = client.Quotas.List(Location);
                foreach(var result in results)
                {
                    var retrieved = client.Quotas.Get(Location, result.Name.Replace(Location + "/", ""));
                    AssertAreEqual(result, retrieved);
                }
            });
        }

        [Fact]
        public void CreateQuota() {
            RunTest((client) => {
                var name = "TestCreateQuota";
                IgnoreExceptions(() => client.Quotas.Delete(Location, name));

                var parameters = new StorageQuotaParameters()
                {
                    CapacityInGb = -100000000,
                    NumberOfStorageAccounts = -1000000000
                };
                var retrieved = client.Quotas.CreateOrUpdate(Location, name, parameters);

                Assert.NotNull(retrieved);
                Assert.Equal(parameters.CapacityInGb, retrieved.CapacityInGb);
                Assert.Equal(parameters.NumberOfStorageAccounts, retrieved.NumberOfStorageAccounts);
                retrieved = client.Quotas.Get(Location, name);

                IgnoreExceptions(() => client.Quotas.Delete(Location, name));
            });
        }

        [Fact]
        public void UpdateQuota() {
            RunTest((client) => {
                var quotaName = "TestUpdateQuota";
                IgnoreExceptions(() => client.Quotas.Delete(Location, quotaName));

                var parameters = new StorageQuotaParameters()
                {
                    CapacityInGb = 50,
                    NumberOfStorageAccounts = 100
                };
                var retrieved = client.Quotas.CreateOrUpdate(Location, quotaName, parameters);
                ValidateQuota(retrieved);
                Assert.Equal(parameters.CapacityInGb, retrieved.CapacityInGb);
                Assert.Equal(parameters.NumberOfStorageAccounts, retrieved.NumberOfStorageAccounts);

                parameters.CapacityInGb = 123;
                parameters.NumberOfStorageAccounts = 10;
                retrieved = client.Quotas.CreateOrUpdate(Location, quotaName, parameters);
                ValidateQuota(retrieved);
                Assert.Equal(parameters.CapacityInGb, retrieved.CapacityInGb);
                Assert.Equal(parameters.NumberOfStorageAccounts, retrieved.NumberOfStorageAccounts);

                IgnoreExceptions(() => client.Quotas.Delete(Location, quotaName));
            });
        }

        [Fact]
        public void DeleteQuota() {
            RunTest((client) => {
                var name = $"TestDeleteQuota";
                IgnoreExceptions(() => client.Quotas.Delete(Location, name));

                var parameters = new StorageQuotaParameters() 
                {
                    CapacityInGb = 0,
                    NumberOfStorageAccounts = -1
                };
                IgnoreExceptions(() => client.Quotas.CreateOrUpdate(Location, name, parameters));
                client.Quotas.Delete(Location, name);
            });
        }
    }
}
