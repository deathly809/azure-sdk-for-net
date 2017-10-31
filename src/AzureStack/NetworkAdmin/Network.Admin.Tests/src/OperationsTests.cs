// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Network.Admin;
using Microsoft.AzureStack.Management.Network.Admin.Models;
using Xunit;

namespace Network.Tests
{
    public class OperationsTests : NetworkTestBase
    {

        [Fact]
        public void TestGetOperationsInvalidOperationId()
        {
            RunTest((client) =>
            {
                var operation = client.Operations.Get(Location, "NonExistantId");
                Assert.Null(operation);
            });
        }

        [Fact(Skip = "Need a real operationId")]
        public void TestGetOperationsInvalidLocation()
        {
            RunTest((client) =>
            {
                var operation = client.Operations.Get("InvalidLocation", "NonExistantId");
                Assert.Null(operation);
            });
        }

        [Fact]
        public void TestGetOperationResultsInvalidOperationId()
        {
            RunTest((client) =>
            {
                var operation = client.OperationResults.Get(Location, "NonExistantId");
                Assert.Null(operation);
            });
        }

        [Fact(Skip = "Need a real operationId")]
        public void TestGetOperationResultsInvalidLocation()
        {
            RunTest((client) =>
            {
                var operation = client.OperationResults.Get("InvalidLocation", "NonExistantId");
                Assert.Null(operation);
            });
        }
    }
}
