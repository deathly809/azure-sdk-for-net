using System.Linq;
using Microsoft.AzureStack.Management.Storage.Admin;
using Microsoft.AzureStack.Management.Storage.Admin.Models;
using Xunit;

namespace Storage.Tests
{
    public class SharesTests : StorageTestBase
    {
        private void AssertAreEqual(Share expected, Share found) {
            if (expected == null)
            {
                Assert.NotNull(found);
            }
            else
            {
                ValidateShare(found);
                Assert.Equal(expected.FreeCapacity, found.FreeCapacity);
                Assert.Equal(expected.HealthStatus, found.HealthStatus);
                Assert.Equal(expected.Id, found.Id);
                Assert.Equal(expected.Location, found.Location);
                Assert.Equal(expected.Name, found.Name);
                Assert.Equal(expected.ShareName, found.ShareName);
                foreach(var expectedTag in expected.Tags)
                {
                    Assert.True(found.Tags.ContainsKey(expectedTag.Key));
                }
                Assert.Equal(expected.TotalCapacity, found.TotalCapacity);
                Assert.Equal(expected.Type, found.Type);
                Assert.Equal(expected.UncPath, found.UncPath);
                Assert.Equal(expected.UsedCapacity, found.UsedCapacity);
            }
        }

        private void ValidateShare(Share share)
        {
            Assert.NotNull(share);
            Assert.NotNull(share.FreeCapacity);
            Assert.NotNull(share.HealthStatus);
            Assert.NotNull(share.Id);
            Assert.NotNull(share.Location);
            Assert.NotNull(share.Name);
            Assert.NotNull(share.ShareName);
            //Assert.NotNull(share.Tags);
            Assert.NotNull(share.TotalCapacity);
            Assert.NotNull(share.Type);
            Assert.NotNull(share.UncPath);
            Assert.NotNull(share.UsedCapacity);
        }

        [Fact]
        public void GetShare()
        {
            RunTest((client) => {
                //   var retrieved = client.Shares.Get(Location);
                //   AssertSharesAreSame(result, retrieved);
            });
        }

        [Fact]
        public void GetAllShares()
        {
            RunTest((client) => {
                //var results = client.Shares.List(Location);
                //foreach (var result in results)
                //{
                //    var retrieved = client.Shares.Get(Location, result.Name.Replace(Location + "/", ""));
                //    AssertSharesAreSame(result, retrieved);
                //}
            });
        }

        [Fact]
        public void ListAllShares()
        {
            RunTest((client) => {
                /*      var result = client.Shares.List(Location);
                        Common.WriteIEnumerableToFile(result, "ListAllShares.txt"); */
            });
        }

        [Fact]
        public void ListAllShareMetricDefinitions()
        {
            RunTest((client) => {
               // var result = client.Shares.ListMetricDefinitions(Location);
               // Common.WriteIEnumerableToFile(result, "ListAllShareMetricDefinitions.txt");
            });
        }


        [Fact]
        public void ListAllShareMetricsDefinitions()
        {
            RunTest((client) => {
                // var result = client.Shares.ListMetrics(Location);
                // Common.WriteIEnumerableToFile(result, "ListAllShareMetricDefinitions.txt");
            });
        }
    }
}
