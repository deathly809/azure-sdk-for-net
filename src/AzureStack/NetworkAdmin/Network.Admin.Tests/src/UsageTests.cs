// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Network.Admin;
using Xunit;

namespace Network.Tests.src
{
    public class UsageTests : NetworkTestBase
    {
        [Fact]
        public void TestUsageList()
        {
            RunTest((client) =>
            {
                client.Usage.List(Location).ForEach( (usage) =>
                {
                    Assert.NotNull(usage.MeterCategory);
                    Assert.NotNull(usage.MeterId);
                    Assert.NotNull(usage.MeterName);
                    Assert.NotNull(usage.MeterSubCategory);
                });
            });
        }
    }
}
