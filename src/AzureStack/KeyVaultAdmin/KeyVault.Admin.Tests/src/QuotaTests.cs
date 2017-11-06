// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.KeyVault.Admin;
using Microsoft.AzureStack.Management.KeyVault.Admin.Models;
using System;
using Xunit;

namespace KeyVault.Tests
{
    public class SubscriberUsageAggregateTests : KeyVaultTestBase
    {

        private void ValidateQuota(Quota ua) {
            Assert.NotNull(ua);
            Assert.NotNull(ua.Id);
            Assert.NotNull(ua.Name);
            Assert.NotNull(ua.Type);
        }

        [Fact]
        public void TestListSubscriberUsageAggregatesFromLastTwoDays() {
            RunTest((client) => {

                var quotas = client.Quotas.List("local");
                quotas.ForEach(ValidateQuota);
            });
        }

    }
}
