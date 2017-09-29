// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.AzureBridge.Admin;
using Microsoft.AzureStack.Management.AzureBridge.Admin.Models;
using System;
using Xunit;

namespace AzureBridge.Tests
{
    public class ProductTests : AzureBridgeTestBase
    {

        
        [Fact]
        public void TestListPublishedProducts() {
            RunTest((client) => {

                var activation = new Activation()
                {
                    DisplayName = "activationName",
                    AzureRegistrationResourceIdentifier = "asdf",
                    Expiration = new DateTime(2020, 01, 01),
                    MarketplaceSyndicationEnabled = true,
                    UsageReportingEnabled = false
                };
                client.Activations.Put("activationName", activation);
                var list = client.Activations.List();
                Common.WriteIPagesToFile(list, client.Activations.ListNext, "TestListPublishedProducts");
            });
        }

    }
}
