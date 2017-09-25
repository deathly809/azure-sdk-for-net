// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.AzureBridge.Admin;
// using Microsoft.AzureStack.Management.AzureBridge.Admin.Models;
using System;
using Xunit;

namespace AzureBridge.Tests
{
    public class ProductTests : AzureBridgeTestBase
    {

        
        [Fact]
        public void TestListPublishedProducts() {
            RunTest((client) => {
                var list = client.PublishedProducts.List();
                Common.WriteIPagesToFile(list, client.PublishedProducts.ListNext, "TestListPublishedProducts");
            });
        }

    }
}
