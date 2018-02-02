// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Compute.Admin;
using Microsoft.AzureStack.Management.Compute.Admin.Models;
using System;
using System.Linq;
using Xunit;

namespace Compute.Tests
{
    public class PlatformImageTests : ComputeTestBase
    {
        private static string VHDUri = "https://test.blob.local.azurestack.external/test/xenial-server-cloudimg-amd64-disk1.vhd";
        private static int sleepTime = 1; // 30 * 1000 for live runs
        // Helper
        private PlatformImage Create() {
            return new PlatformImage()
            {
                OsDisk = new OsDisk()
                {
                    OsType = OsType.Linux,
                    Uri = VHDUri
                }
            };
        }


        private void ValidatePlatformImage(PlatformImage image) {
            Assert.NotNull(image.Id);
            Assert.NotNull(image.Type);
            Assert.NotNull(image.Location);

            Assert.NotNull(image);
            Assert.NotNull(image.OsDisk);
            Assert.NotNull(image.ProvisioningState);
        }

        private void AssertSame(PlatformImage expected, PlatformImage given, bool resourceToo = true) {
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
            }
        }

        [Fact]
        public void TestListPlatformImages() {
            RunTest((client) => {
                var platformImages = client.PlatformImages.List("local");
                platformImages.ForEach(ValidatePlatformImage);
            });
        }

        [Fact]
        public void TestGetPlatformImage() {
            RunTest((client) => {
                var platformImage = client.PlatformImages.List("local").FirstOrDefault();
                if (platformImage != null)
                {
                    var items = platformImage.Id.Split(new[] { '/' }, System.StringSplitOptions.RemoveEmptyEntries);
                    var publisher = items[9];
                    var offer = items[11];
                    var sku = items[13];
                    var version = items[15];
                    client.PlatformImages.Get("local", publisher, offer, sku, version);
                }
            });
        }

        [Fact]
        public void TestGetAllPlatformImages() {
            RunTest((client) => {
                var platformImages = client.PlatformImages.List("local");
                platformImages.ForEach((platformImage) => {
                    var items = platformImage.Id.Split(new[] { '/' }, System.StringSplitOptions.RemoveEmptyEntries);
                    var publisher = items[9];
                    var offer = items[11];
                    var sku = items[13];
                    var version = items[15];
                    client.PlatformImages.Get("local", publisher, offer, sku, version);
                });
            });
        }

        private void untilFalse(Func<bool> func) {
            while (func()) System.Threading.Thread.Sleep(sleepTime);
        }

        [Fact]
        public void TestCreatePlatformImage() {

            RunTest((client) => {
                var Location = "Canonical";
                var Publisher = "Test";
                var Offer = "UbuntuServer";
                var Sku = "16.04-LTS";
                var Version = "1.0.0";

                // Create
                var image = client.PlatformImages.Create(Location, Publisher, Offer, Sku, Version, Create());
                Assert.NotNull(image);
                Assert.Equal(VHDUri, image.OsDisk.Uri);

                untilFalse(() => client.PlatformImages.Get(Location, Publisher, Offer, Sku, Version).ProvisioningState == ProvisioningState.Creating);
                
                var result = client.PlatformImages.Get(Location, Publisher, Offer, Sku, Version);
                Assert.Equal(ProvisioningState.Succeeded, result.ProvisioningState);

            });
        }

        [Fact]
        public void TestCreateAndDeletePlatformImage() {
            RunTest((client) => {

                var Location = "local";
                var Publisher = "Test";
                var Offer = "UbuntuServer";
                var Sku = "16.04-LTS";
                var Version = "1.0.0";

                // Create
                var image = client.PlatformImages.Create(Location, Publisher, Offer, Sku, Version, Create());
                Assert.NotNull(image);
                Assert.Equal(VHDUri, image.OsDisk.Uri);

                untilFalse(() => client.PlatformImages.Get(Location, Publisher, Offer, Sku, Version).ProvisioningState == ProvisioningState.Creating);

                var result = client.PlatformImages.Get(Location, Publisher, Offer, Sku, Version);
                Assert.Equal(ProvisioningState.Succeeded, result.ProvisioningState);

                // Delete
                client.PlatformImages.Delete(Location, Publisher, Offer, Sku, Version);
                result = client.PlatformImages.Get(Location, Publisher, Offer, Sku, Version);
                Assert.Null(result);
            });
        }
    }
}
