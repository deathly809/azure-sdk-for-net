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

        [Fact(Skip = "Need to investigate operationId")]
        public void TestGetOperations()
        {
            RunTest((client) =>
            {
                var operation = client.Operations.Get(Location, 1);
            });
        }
    }
}
