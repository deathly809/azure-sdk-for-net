// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Fabric.Admin.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Description of a bare metal node used for ScaleOut operation on a
    /// cluster.
    /// </summary>
    public partial class BareMetalNodeDescription
    {
        /// <summary>
        /// Initializes a new instance of the BareMetalNodeDescription class.
        /// </summary>
        public BareMetalNodeDescription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BareMetalNodeDescription class.
        /// </summary>
        /// <param name="bMCIPv4Address">Bmc address of the physical
        /// machine.</param>
        /// <param name="vendor">Vendor of the physical machine.</param>
        /// <param name="model">Model of the physical machine.</param>
        /// <param name="serialNumber">Serial number of the physical
        /// machine.</param>
        /// <param name="biosVersion">Bios version of the physical
        /// machine.</param>
        /// <param name="computerName">Name of the computer.</param>
        /// <param name="clusterName">Name of the cluster.</param>
        /// <param name="macAddress">Name of the mac address of the bare metal
        /// node.</param>
        public BareMetalNodeDescription(string bMCIPv4Address = default(string), string vendor = default(string), string model = default(string), string serialNumber = default(string), string biosVersion = default(string), string computerName = default(string), string clusterName = default(string), string macAddress = default(string))
        {
            BMCIPv4Address = bMCIPv4Address;
            Vendor = vendor;
            Model = model;
            SerialNumber = serialNumber;
            BiosVersion = biosVersion;
            ComputerName = computerName;
            ClusterName = clusterName;
            MacAddress = macAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets bmc address of the physical machine.
        /// </summary>
        [JsonProperty(PropertyName = "bmcIpv4Address")]
        public string BMCIPv4Address { get; set; }

        /// <summary>
        /// Gets or sets vendor of the physical machine.
        /// </summary>
        [JsonProperty(PropertyName = "vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// Gets or sets model of the physical machine.
        /// </summary>
        [JsonProperty(PropertyName = "model")]
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets serial number of the physical machine.
        /// </summary>
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or sets bios version of the physical machine.
        /// </summary>
        [JsonProperty(PropertyName = "biosVersion")]
        public string BiosVersion { get; set; }

        /// <summary>
        /// Gets or sets name of the computer.
        /// </summary>
        [JsonProperty(PropertyName = "computerName")]
        public string ComputerName { get; set; }

        /// <summary>
        /// Gets or sets name of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "clusterName")]
        public string ClusterName { get; set; }

        /// <summary>
        /// Gets or sets name of the mac address of the bare metal node.
        /// </summary>
        [JsonProperty(PropertyName = "macAddress")]
        public string MacAddress { get; set; }

    }
}
