using System.Linq;
using Microsoft.AzureStack.Management.Storage.Admin;
using Microsoft.AzureStack.Management.Storage.Admin.Models;
using Xunit;

namespace Storage.Tests
{
    public class QueueServicesTests : StorageTestBase
    {
        private void AssertAreEqual(QueueService expected, QueueService found) {
            if (expected == null)
            {
                Assert.NotNull(found);
            }
            else
            {
                ValidateQueueService(found);
            }
        }

        private void ValidateQueueService(QueueService QueueService)
        {
            Assert.NotNull(QueueService);
        }

        [Fact]
        public void GetQueueService()
        {
            RunTest((client) => {
                //   var retrieved = client.QueueServices.Get(Location);
                //   AssertQueueServicesAreSame(result, retrieved);
            });
        }

        [Fact]
        public void GetAllQueueServices()
        {
            RunTest((client) => {
                //var results = client.QueueServices.List(Location);
                //foreach (var result in results)
                //{
                //    var retrieved = client.QueueServices.Get(Location, result.Name.Replace(Location + "/", ""));
                //    AssertQueueServicesAreSame(result, retrieved);
                //}
            });
        }

        [Fact]
        public void ListAllQueueServices()
        {
            RunTest((client) => {
                /*      var result = client.QueueServices.List(Location);
                        Common.WriteIEnumerableToFile(result, "ListAllQueueServices.txt"); */
            });
        }

        [Fact]
        public void ListAllQueueServiceMetricDefinitions()
        {
            RunTest((client) => {
               // var result = client.QueueServices.ListMetricDefinitions(Location);
               // Common.WriteIEnumerableToFile(result, "ListAllQueueServiceMetricDefinitions.txt");
            });
        }

        [Fact]
        public void ListAllQueueServiceMetricsDefinitions()
        {
            RunTest((client) => {
                // var result = client.QueueServices.ListMetrics(Location);
                // Common.WriteIEnumerableToFile(result, "ListAllQueueServiceMetricDefinitions.txt");
            });
        }
    }
}
