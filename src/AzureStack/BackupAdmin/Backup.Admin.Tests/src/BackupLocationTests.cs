// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Backup.Admin;
using Microsoft.AzureStack.Management.Backup.Admin.Models;
using System;
using Xunit;

namespace Backup.Tests
{
    public class BackupLocationTests : BackupTestBase
    {


        [Fact]
        public void TestListSubscriberUsageAggregatesFromLastTwoDays() {
            RunTest((client) => {
                client.BackupLocations.List("System.local");
            });
        }

    }
}
