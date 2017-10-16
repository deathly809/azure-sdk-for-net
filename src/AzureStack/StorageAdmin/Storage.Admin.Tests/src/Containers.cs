using System.Linq;
using Microsoft.AzureStack.Management.Storage.Admin;
using Microsoft.AzureStack.Management.Storage.Admin.Models;
using Xunit;

namespace Storage.Tests
{
    public class ContainersTests : StorageTestBase
    {
        private void AssertAreEqual(Container expected, Container found) {
            if (expected == null)
            {
                Assert.NotNull(found);
            }
            else
            {
                ValidateContainer(found);
            }
        }

        private void ValidateContainer(Container container)
        {
            Assert.NotNull(container);
            Assert.NotNull(container.Accountid);
            Assert.NotNull(container.Accountname);
            Assert.NotNull(container.Containerid);
            Assert.NotNull(container.Containername);
            Assert.NotNull(container.ContainerState);
            Assert.NotNull(container.Sharename);
        }

        [Fact]
        public void GetContainer()
        {
            RunTest((client) => {
             //   var retrieved = client.Containers.Get(Location);
             //   AssertContainersAreSame(result, retrieved);
            });
        }

        [Fact]
        public void List()
        {
            RunTest((client) => {
               // var result = client.Containers.List(Location);
               // Common.WriteIEnumerableToFile(result, "ListAllContainers.txt");
            });
        }

        [Fact]
        public void ListDestinationShares()
        {
            RunTest((client) => {
                // var result = client.Containers.ListDestinationShares(Location);
                // Common.WriteIEnumerableToFile(result, "ListAllDestinationShares.txt");
            });
        }

        [Fact]
        public void MigrateShare()
        {
            RunTest((client) => {
                // var result = client.Containers.MigrateShare(Location);
            });
        }

        [Fact]
        public void CancelMigration()
        {
            RunTest((client) => {
                // var result = client.Containers.CancelMigration(Location);
            });
        }
    }
}
