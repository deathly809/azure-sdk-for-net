using System.Linq;
using Microsoft.AzureStack.Management.Storage.Admin;
using Microsoft.AzureStack.Management.Storage.Admin.Models;
using Xunit;

namespace Storage.Tests
{
    public class SharesTests : StorageTestBase
    {
        private void AssertSharesAreSame(Share expected, Share found) {
            if (expected == null)
            {
                Assert.NotNull(found);
            }
            else
            {
                ValidateShare(found);
            }
        }

        private void ValidateShare(Share share)
        {
            Assert.NotNull(share);
            Assert.NotNull(share.FreeCapacity);
            Assert.NotNull(share.HealthStatus);
            Assert.NotNull(share.Id);
            Assert.NotNull(share.Name);
            Assert.NotNull(share.ShareName);
            Assert.NotNull(share.Tags);
            Assert.NotNull(share.TotalCapacity);
            Assert.NotNull(share.Type);
            Assert.NotNull(share.UncPath);
            Assert.NotNull(share.UsedCapacity);
        }

        [Fact]
        public void GetTableService()
        {
            RunTest((client) => {
             //   var retrieved = client.TableServices.Get(Location);
             //   AssertTableServicesAreSame(result, retrieved);
            });
        }

        [Fact]
        public void ListAllTableServiceMetricDefinitions()
        {
            RunTest((client) => {
               // var result = client.TableServices.ListMetricDefinitions(Location);
               // Common.WriteIEnumerableToFile(result, "ListAllTableServiceMetricDefinitions.txt");
            });
        }

        [Fact]
        public void ListAllTableServiceMetricDefinitionsOData()
        {
            RunTest((client) => {
                // var result = client.TableServices.ListMetricDefinitions(Location);
                // Common.WriteIEnumerableToFile(result, "ListAllTableServiceMetricDefinitions.txt");
            });
        }

        [Fact]
        public void ListAllTableServiceMetricsDefinitions()
        {
            RunTest((client) => {
                // var result = client.TableServices.ListMetrics(Location);
                // Common.WriteIEnumerableToFile(result, "ListAllTableServiceMetricDefinitions.txt");
            });
        }

        [Fact]
        public void ListAllTableServiceMetricsOData()
        {
            RunTest((client) => {
                // var result = client.TableServices.ListMetrics(Location);
                // Common.WriteIEnumerableToFile(result, "ListAllTableServiceMetricDefinitions.txt");
            });
        }
    }
}
