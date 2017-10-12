using System.Linq;
using Microsoft.AzureStack.Management.Storage.Admin;
using Microsoft.AzureStack.Management.Storage.Admin.Models;
using Xunit;

namespace Storage.Tests
{
    public class TableServicesTests : StorageTestBase
    {
        private void AssertTableServicesAreSame(TableService expected, TableService found) {
            if (expected == null)
            {
                Assert.NotNull(found);
            }
            else
            {
                ValidateTableService(found);
            }
        }

        private void ValidateTableService(TableService tableService)
        {
            Assert.NotNull(tableService);
            Assert.NotNull(tableService.HealthStatus);
            Assert.NotNull(tableService.BackEndHttpListenPort);
            Assert.NotNull(tableService.FrontEndCallbackThreadsCount);
            Assert.NotNull(tableService.FrontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds);
            Assert.NotNull(tableService.FrontEndCpuBasedKeepAliveThrottlingEnabled);
            Assert.NotNull(tableService.FrontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold);
            Assert.NotNull(tableService.FrontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle);
            Assert.NotNull(tableService.FrontEndHttpListenPort);
            Assert.NotNull(tableService.FrontEndMaxMillisecondsBetweenMemorySamples);
            Assert.NotNull(tableService.FrontEndMemoryThrottleThresholdSettings);
            Assert.NotNull(tableService.FrontEndMemoryThrottlingEnabled);
            Assert.NotNull(tableService.FrontEndMinThreadPoolThreads);
            Assert.NotNull(tableService.FrontEndThreadPoolBasedKeepAliveIOCompletionThreshold);
            Assert.NotNull(tableService.FrontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds);
            Assert.NotNull(tableService.FrontEndThreadPoolBasedKeepAlivePercentage);
            Assert.NotNull(tableService.FrontEndThreadPoolBasedKeepAliveWorkerThreadThreshold);
            Assert.NotNull(tableService.FrontEndUseSlaTimeInAvailability);
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
