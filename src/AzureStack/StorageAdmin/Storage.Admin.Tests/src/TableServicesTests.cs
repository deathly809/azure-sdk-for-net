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
            Assert.NotNull(tableService.Properties);
            Assert.NotNull(tableService.Properties.BackEndHttpListenPort);
            Assert.NotNull(tableService.Properties.FrontEndCallbackThreadsCount);
            Assert.NotNull(tableService.Properties.FrontEndCpuBasedKeepAliveThrottlingCpuMonitorIntervalInSeconds);
            Assert.NotNull(tableService.Properties.FrontEndCpuBasedKeepAliveThrottlingEnabled);
            Assert.NotNull(tableService.Properties.FrontEndCpuBasedKeepAliveThrottlingPercentCpuThreshold);
            Assert.NotNull(tableService.Properties.FrontEndCpuBasedKeepAliveThrottlingPercentRequestsToThrottle);
            Assert.NotNull(tableService.Properties.FrontEndHttpListenPort);
            Assert.NotNull(tableService.Properties.FrontEndMaxMillisecondsBetweenMemorySamples);
            Assert.NotNull(tableService.Properties.FrontEndMemoryThrottleThresholdSettings);
            Assert.NotNull(tableService.Properties.FrontEndMemoryThrottlingEnabled);
            Assert.NotNull(tableService.Properties.FrontEndMinThreadPoolThreads);
            Assert.NotNull(tableService.Properties.FrontEndThreadPoolBasedKeepAliveIOCompletionThreshold);
            Assert.NotNull(tableService.Properties.FrontEndThreadPoolBasedKeepAliveMonitorIntervalInSeconds);
            Assert.NotNull(tableService.Properties.FrontEndThreadPoolBasedKeepAlivePercentage);
            Assert.NotNull(tableService.Properties.FrontEndThreadPoolBasedKeepAliveWorkerThreadThreshold);
            Assert.NotNull(tableService.Properties.FrontEndUseSlaTimeInAvailability);
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
