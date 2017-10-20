using System.Linq;
using Microsoft.AzureStack.Management.Storage.Admin;
using Microsoft.AzureStack.Management.Storage.Admin.Models;
using Xunit;
using System;

namespace Storage.Tests
{
    public class StorageAccountsTests : StorageTestBase
    {
        private void AssertAreEqual(StorageAccount expected, StorageAccount found) {
            if (expected == null)
            {
                Assert.NotNull(found);
            }
            else
            {
                ValidateStorageAccount(found);
                Assert.Equal(expected.AccountId, found.AccountId);
                Assert.Equal(expected.AccountStatus, found.AccountStatus);
                Assert.Equal(expected.AccountType, found.AccountType);
                Assert.Equal(expected.AcquisitionOperationCount, found.AcquisitionOperationCount);
                Assert.Equal(expected.AlternateName, found.AlternateName);
                Assert.Equal(expected.CurrentOperation, found.CurrentOperation);
                Assert.Equal(expected.CustomDomain, found.CustomDomain);
            }
        }

        private void ValidateStorageAccount(StorageAccount account) {
            Assert.NotNull(account);
            Assert.NotNull(account.AccountId);
            Assert.NotNull(account.AccountStatus);
            Assert.NotNull(account.AccountType);
            Assert.NotNull(account.AcquisitionOperationCount);
            Assert.NotNull(account.AlternateName);
            Assert.NotNull(account.CreationTime);
            Assert.NotNull(account.CurrentOperation);
            Assert.NotNull(account.CustomDomain);
            //Assert.NotNull(account.DeletedTime);
            Assert.NotNull(account.Id);
            Assert.NotNull(account.Location);
            Assert.NotNull(account.Name);
            Assert.NotNull(account.Permissions);
            Assert.NotNull(account.PrimaryEndpoints);
            Assert.NotNull(account.PrimaryLocation);
            Assert.NotNull(account.ProvisioningState);
            Assert.NotNull(account.RecoveredTime);
            Assert.NotNull(account.RecycledTime);
            Assert.NotNull(account.ResourceAdminApiVersion);
            Assert.NotNull(account.StatusOfPrimary);
            //Assert.NotNull(account.Tags);
            Assert.NotNull(account.TenantResourceGroupName);
            Assert.NotNull(account.TenantStorageAccountName);
            Assert.NotNull(account.TenantSubscriptionId);
            Assert.NotNull(account.TenantViewId);
            Assert.NotNull(account.Type);
            Assert.NotNull(account.WacInternalState);
        }

        [Fact]
        public void ListAllStorageAccounts() {
            RunTest((client) => {
        /*      var result = client.StorageAccounts.List(Location);
                Common.WriteIEnumerableToFile(result, "ListAllStorageQuotas.txt"); */
            });
        }

        [Fact]
        public void GetStorageQuota() {
            /*RunTest((client) => {
                var result = client.StorageAccounts.List(Location).First();
                var retrieved = client.StorageAccounts.Get(Location, result.Name.Replace(Location + "/", ""));
                ValidateStorageAccount(retrieved);
            }); */
        }

        [Fact]
        public void GetAllStorageAccounts()
        {
            RunTest((client) =>
            {
                /*   var results = client.StorageAccounts.List());
                     foreach(var result in results)
                     {
                         var retrieved = client.StorageAccounts.Get());
                         AssertStorageAccountsAreSame(result, retrieved);
                     } 
                */
            });
        }

        [Fact]
        public void GetAllStorageAccountSynchronize()
        {
            RunTest((client) =>
            {
                /*   var results = client.StorageAccounts.List());
                     foreach(var result in results)
                     {
                         var retrieved = client.StorageAccounts.Synchronize());
                     } 
                */
            });
        }

        [Fact]
        public void GetAllStorageAccountSynchronizeAll()
        {
            RunTest((client) =>
            {
                /*   var results = client.StorageAccounts.List());
                     foreach(var result in results)
                     {
                         var retrieved = client.StorageAccounts.SynchronizeAll());
                     } 
                */
            });
        }


        [Fact]
        public void UnDeleteStorageAccount()
        {
            RunTest((client) =>
            {
                /*   var results = client.StorageAccounts.List());
                     foreach(var result in results)
                     {
                         var retrieved = client.StorageAccounts.UnDelete());
                     } 
                */
            });
        }
    }
}
