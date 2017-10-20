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
                Assert.Equal(expected.BackEndHttpListenPort, found.BackEndHttpListenPort);
                Assert.Equal(expected.FrontEndCallbackThreadsCount, found.FrontEndCallbackThreadsCount);
                Assert.Equal(expected.FrontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds, found.FrontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds);
                Assert.Equal(expected.FrontEndCpuBasedKeepAliveThrottlingEnabled, found.FrontEndCpuBasedKeepAliveThrottlingEnabled);
                Assert.Equal(expected.FrontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold, found.FrontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold);
                Assert.Equal(expected.FrontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle, found.FrontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle);
                Assert.Equal(expected.FrontEndHttpListenPort, found.FrontEndHttpListenPort);
                Assert.Equal(expected.FrontEndMaxMillisecondsBetweenMemorySamples, found.FrontEndMaxMillisecondsBetweenMemorySamples);
                Assert.Equal(expected.FrontEndMemoryThrottleThresholdSettings, found.FrontEndMemoryThrottleThresholdSettings);
                Assert.Equal(expected.FrontEndMemoryThrottlingEnabled, found.FrontEndMemoryThrottlingEnabled);
                Assert.Equal(expected.FrontEndMinThreadPoolThreads, found.FrontEndMinThreadPoolThreads);
                Assert.Equal(expected.FrontEndThreadPoolBasedKeepAliveIOCompletionThreshold, found.FrontEndThreadPoolBasedKeepAliveIOCompletionThreshold);
                Assert.Equal(expected.FrontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds, found.FrontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds);
                Assert.Equal(expected.FrontEndThreadPoolBasedKeepAlivePercentage, found.FrontEndThreadPoolBasedKeepAlivePercentage);
                Assert.Equal(expected.FrontEndThreadPoolBasedKeepAliveWorkerThreadThreshold, found.FrontEndThreadPoolBasedKeepAliveWorkerThreadThreshold);
                Assert.Equal(expected.FrontEndUseSlaTimeInAvailability, found.FrontEndUseSlaTimeInAvailability);
                Assert.Equal(expected.HealthStatus, found.HealthStatus);
                Assert.Equal(expected.Id, found.Id);
                Assert.Equal(expected.Location, found.Location);
                Assert.Equal(expected.Name, found.Name);
                foreach (var expectedTag in expected.Tags)
                {
                    Assert.True(found.Tags.ContainsKey(expectedTag.Key));
                }
                Assert.Equal(expected.Type, found.Type);
                Assert.Equal(expected.Version, found.Version);
            }
        }

        private void ValidateQueueService(QueueService queueService)
        {
            Assert.NotNull(queueService);
            Assert.NotNull(queueService.BackEndHttpListenPort);
            Assert.NotNull(queueService.FrontEndCallbackThreadsCount);
            Assert.NotNull(queueService.FrontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds);
            Assert.NotNull(queueService.FrontEndCpuBasedKeepAliveThrottlingEnabled);
            Assert.NotNull(queueService.FrontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold);
            Assert.NotNull(queueService.FrontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle);
            Assert.NotNull(queueService.FrontEndHttpListenPort);
            Assert.NotNull(queueService.FrontEndMaxMillisecondsBetweenMemorySamples);
            Assert.NotNull(queueService.FrontEndMemoryThrottleThresholdSettings);
            Assert.NotNull(queueService.FrontEndMemoryThrottlingEnabled);
            Assert.NotNull(queueService.FrontEndMinThreadPoolThreads);
            Assert.NotNull(queueService.FrontEndThreadPoolBasedKeepAliveIOCompletionThreshold);
            Assert.NotNull(queueService.FrontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds);
            Assert.NotNull(queueService.FrontEndThreadPoolBasedKeepAlivePercentage);
            Assert.NotNull(queueService.FrontEndThreadPoolBasedKeepAliveWorkerThreadThreshold);
            Assert.NotNull(queueService.FrontEndUseSlaTimeInAvailability);
            Assert.NotNull(queueService.HealthStatus);
            Assert.NotNull(queueService.Id);
            Assert.NotNull(queueService.Location);
            Assert.NotNull(queueService.Name);
            Assert.NotNull(queueService.Type);
            Assert.NotNull(queueService.Version);
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
