﻿// Copyright (c) Microsoft Corporation. All rights reserved.
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
        public void TestListProducts() {
            RunTest((client) => {
                var list = client.Products.List("azurestack-activation", "default");
                Common.WriteIPagesToFile(list, client.Products.ListNext, "TestListProducts");
            });
        }

        //[Fact]
        //public void TestGetNonExistantProduct()
        //{
        //    RunTest((client) => {
        //        var product = client.Products.Get("azurestack-activation", "default", "nonexsting-product");
        //        Assert.Null(product);
        //    });
        //}

    }
}
