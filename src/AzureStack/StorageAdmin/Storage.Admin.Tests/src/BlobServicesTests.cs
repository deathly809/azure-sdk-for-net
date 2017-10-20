using System.Linq;
using Microsoft.AzureStack.Management.Storage.Admin;
using Microsoft.AzureStack.Management.Storage.Admin.Models;
using Xunit;

namespace Storage.Tests
{
    public class BlobServicesTests : StorageTestBase
    {
        private void AssertAreEqual(BlobService expected, BlobService found) {
            if (expected == null)
            {
                Assert.NotNull(found);
            }
            else
            {
                ValidateBlobService(found);
            }
        }

        private void ValidateBlobService(BlobService blobService)
        {
            Assert.NotNull(blobService);
            Assert.NotNull(blobService.BackEndHttpListenPort);
            Assert.NotNull(blobService.BlobSvcContainerGcInterval);
            Assert.NotNull(blobService.BlobSvcShallowGcInterval);
            Assert.NotNull(blobService.BlobSvcStreamMapMinContainerOccupancyPercent);
            Assert.NotNull(blobService.FrontEndCallbackThreadsCount);
            Assert.NotNull(blobService.FrontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds);
            Assert.NotNull(blobService.FrontEndCpuBasedKeepAliveThrottlingEnabled);
            Assert.NotNull(blobService.FrontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold);
            Assert.NotNull(blobService.FrontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle);
            Assert.NotNull(blobService.FrontEndHttpListenPort);
            Assert.NotNull(blobService.FrontEndMaxMillisecondsBetweenMemorySamples);
            Assert.NotNull(blobService.FrontEndMemoryThrottleThresholdSettings);
            Assert.NotNull(blobService.FrontEndMemoryThrottlingEnabled);
            Assert.NotNull(blobService.FrontEndMinThreadPoolThreads);
            Assert.NotNull(blobService.FrontEndThreadPoolBasedKeepAliveIOCompletionThreshold);
            Assert.NotNull(blobService.FrontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds);
            Assert.NotNull(blobService.FrontEndThreadPoolBasedKeepAlivePercentage);
            Assert.NotNull(blobService.FrontEndThreadPoolBasedKeepAliveWorkerThreadThreshold);
            Assert.NotNull(blobService.FrontEndUseSlaTimeInAvailability);
            Assert.NotNull(blobService.Id);
            Assert.NotNull(blobService.HealthStatus);
            Assert.NotNull(blobService.Location);
            Assert.NotNull(blobService.Name);
            Assert.NotNull(blobService.Type);
            Assert.NotNull(blobService.Version);
        }

        [Fact]
        public void GetBlobService()
        {
            RunTest((client) => {
             //   var retrieved = client.BlobServices.Get(Location);
             //   AssertBlobServicesAreSame(result, retrieved);
            });
        }

        [Fact]
        public void ListAllShares()
        {
            RunTest((client) => {
                /*      var result = client.BlobServices.List(Location);
                        Common.WriteIEnumerableToFile(result, "ListAllBlobServices.txt"); */
            });
        }

        [Fact]
        public void ListAllBlobServiceMetricDefinitions()
        {
            RunTest((client) => {
               // var result = client.BlobServices.ListMetricDefinitions(Location);
               // Common.WriteIEnumerableToFile(result, "ListAllBlobServiceMetricDefinitions.txt");
            });
        }

        [Fact]
        public void ListAllBlobServiceMetricsDefinitions()
        {
            RunTest((client) => {
                // var result = client.BlobServices.ListMetrics(Location);
                // Common.WriteIEnumerableToFile(result, "ListAllBlobServiceMetricDefinitions.txt");
            });
        }
    }
}
