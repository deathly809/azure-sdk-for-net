// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Compute.Admin;
using Microsoft.AzureStack.Management.Compute.Admin.Models;
using System.Linq;
using Xunit;

namespace Compute.Tests
{
    public class VMExtensionTests : ComputeTestBase
    {
        
        private string publisher = "Microsoft";
        private string type = "MicroExtension";
        private string version = "0.1.0";

        // Helper
        private VMExtension Create() {
            return new VMExtension()
            {
                ComputeRole = "N/A",
                VmScaleSetEnabled = false,
                SourceBlob = new AzureBlob("https://github.com/Microsoft/PowerShell-DSC-for-Linux/archive/v1.1.1-294.zip"),
                IsSystemExtension = false,
                SupportMultipleExtensions = true,
                VmOsType = OsType.Linux
            };
        }


        private void ValidateVMExtension(VMExtension image) {
            //AssertValidResource(image);
            Assert.NotNull(image);
        }

        private void AssertSame(VMExtension expected, VMExtension given, bool resourceToo = true) {
            if (resourceToo)
            {
                AssertSameResource(expected, given);
            }
            if (expected == null)
            {
                Assert.Null(given);
            }
            else
            {
                Assert.NotNull(given);
                Assert.Equal(expected.ComputeRole, given.ComputeRole);
                Assert.Equal(expected.IsSystemExtension, given.IsSystemExtension);
                Assert.Equal(expected.ProvisioningState, given.ProvisioningState);
                Assert.Equal(expected.SupportMultipleExtensions, given.SupportMultipleExtensions);
                Assert.Equal(expected.VmOsType, given.VmOsType);
                Assert.Equal(expected.VmScaleSetEnabled, given.VmScaleSetEnabled);
            }
        }

        [Fact]
        public void TestListVMExtensions() {
            RunTest((client) => {
                var list = client.VMExtensions.List("local");
                list.ForEach(ValidateVMExtension);
            });
        }

        [Fact]
        public void TestGetVMExtension() {
            RunTest((client) => {
                var ext = client.VMExtensions.List("local").First();
                var parts = ext.Id.Split(new[] { '/' }, System.StringSplitOptions.RemoveEmptyEntries);
                var publisher = parts[9];
                var type = parts[11];
                var version = parts[13];
                var result = client.VMExtensions.Get("local", publisher, type, version);
                AssertSame(ext, result);
            });
        }

        [Fact]
        public void TestGetAllVMExtensions() {
            RunTest((client) => {
                var exts = client.VMExtensions.List("local");
                exts.ForEach((ext) => {
                    var parts = ext.Id.Split(new[] { '/' }, System.StringSplitOptions.RemoveEmptyEntries);
                    var publisher = parts[9];
                    var type = parts[11];
                    var version = parts[13];
                    var result = client.VMExtensions.Get("local", publisher, type, version);
                    AssertSame(ext, result);
                });
            });
        }


        [Fact]
        public void TestCreateVMExtension() {
            RunTest((client) => {
                client.VMExtensions.Delete(Location, publisher, type, version);
                var extension = client.VMExtensions.Create(Location, publisher, type, version, Create());
                var result = client.VMExtensions.Get(Location, publisher, type, version);
                AssertSame(extension, result);
                client.VMExtensions.Delete(Location, publisher, type, version);
            });
        }

        [Fact]

        public void TestDeleteVMExtension() {
            RunTest((client) => {
                // Setup

                client.VMExtensions.Create(Location, publisher, type, version, Create());

                // Do
                client.VMExtensions.Delete(Location, publisher, type, version);

                // Validate
                var result = client.VMExtensions.Get(Location, publisher, type, version);
                Assert.Null(result);
            });
        }
    }
}
