// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Data Lake Store account information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DataLakeStoreAccount : Resource
    {
        /// <summary>
        /// Initializes a new instance of the DataLakeStoreAccount class.
        /// </summary>
        public DataLakeStoreAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataLakeStoreAccount class.
        /// </summary>
        /// <param name="id">The resource identifier.</param>
        /// <param name="name">The resource name.</param>
        /// <param name="type">The resource type.</param>
        /// <param name="location">The resource location.</param>
        /// <param name="tags">The resource tags.</param>
        /// <param name="identity">The Key Vault encryption identity, if
        /// any.</param>
        /// <param name="accountId">The unique identifier associated with this
        /// Data Lake Store account.</param>
        /// <param name="provisioningState">The provisioning status of the Data
        /// Lake Store account. Possible values include: 'Failed', 'Creating',
        /// 'Running', 'Succeeded', 'Patching', 'Suspending', 'Resuming',
        /// 'Deleting', 'Deleted', 'Undeleting', 'Canceled'</param>
        /// <param name="state">The state of the Data Lake Store account.
        /// Possible values include: 'Active', 'Suspended'</param>
        /// <param name="creationTime">The account creation time.</param>
        /// <param name="lastModifiedTime">The account last modified
        /// time.</param>
        /// <param name="endpoint">The full CName endpoint for this
        /// account.</param>
        /// <param name="defaultGroup">The default owner group for all new
        /// folders and files created in the Data Lake Store account.</param>
        /// <param name="encryptionConfig">The Key Vault encryption
        /// configuration.</param>
        /// <param name="encryptionState">The current state of encryption for
        /// this Data Lake Store account. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        /// <param name="encryptionProvisioningState">The current state of
        /// encryption provisioning for this Data Lake Store account. Possible
        /// values include: 'Creating', 'Succeeded'</param>
        /// <param name="firewallRules">The list of firewall rules associated
        /// with this Data Lake Store account.</param>
        /// <param name="firewallState">The current state of the IP address
        /// firewall for this Data Lake Store account. Possible values include:
        /// 'Enabled', 'Disabled'</param>
        /// <param name="firewallAllowAzureIps">The current state of allowing
        /// or disallowing IPs originating within Azure through the firewall.
        /// If the firewall is disabled, this is not enforced. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="trustedIdProviders">The list of trusted identity
        /// providers associated with this Data Lake Store account.</param>
        /// <param name="trustedIdProviderState">The current state of the
        /// trusted identity provider feature for this Data Lake Store account.
        /// Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="newTier">The commitment tier to use for next month.
        /// Possible values include: 'Consumption', 'Commitment_1TB',
        /// 'Commitment_10TB', 'Commitment_100TB', 'Commitment_500TB',
        /// 'Commitment_1PB', 'Commitment_5PB'</param>
        /// <param name="currentTier">The commitment tier in use for the
        /// current month. Possible values include: 'Consumption',
        /// 'Commitment_1TB', 'Commitment_10TB', 'Commitment_100TB',
        /// 'Commitment_500TB', 'Commitment_1PB', 'Commitment_5PB'</param>
        public DataLakeStoreAccount(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), EncryptionIdentity identity = default(EncryptionIdentity), System.Guid? accountId = default(System.Guid?), DataLakeStoreAccountStatus? provisioningState = default(DataLakeStoreAccountStatus?), DataLakeStoreAccountState? state = default(DataLakeStoreAccountState?), System.DateTime? creationTime = default(System.DateTime?), System.DateTime? lastModifiedTime = default(System.DateTime?), string endpoint = default(string), string defaultGroup = default(string), EncryptionConfig encryptionConfig = default(EncryptionConfig), EncryptionState? encryptionState = default(EncryptionState?), EncryptionProvisioningState? encryptionProvisioningState = default(EncryptionProvisioningState?), IList<FirewallRule> firewallRules = default(IList<FirewallRule>), FirewallState? firewallState = default(FirewallState?), FirewallAllowAzureIpsState? firewallAllowAzureIps = default(FirewallAllowAzureIpsState?), IList<TrustedIdProvider> trustedIdProviders = default(IList<TrustedIdProvider>), TrustedIdProviderState? trustedIdProviderState = default(TrustedIdProviderState?), TierType? newTier = default(TierType?), TierType? currentTier = default(TierType?))
            : base(id, name, type, location, tags)
        {
            Identity = identity;
            AccountId = accountId;
            ProvisioningState = provisioningState;
            State = state;
            CreationTime = creationTime;
            LastModifiedTime = lastModifiedTime;
            Endpoint = endpoint;
            DefaultGroup = defaultGroup;
            EncryptionConfig = encryptionConfig;
            EncryptionState = encryptionState;
            EncryptionProvisioningState = encryptionProvisioningState;
            FirewallRules = firewallRules;
            FirewallState = firewallState;
            FirewallAllowAzureIps = firewallAllowAzureIps;
            TrustedIdProviders = trustedIdProviders;
            TrustedIdProviderState = trustedIdProviderState;
            NewTier = newTier;
            CurrentTier = currentTier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the Key Vault encryption identity, if any.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public EncryptionIdentity Identity { get; private set; }

        /// <summary>
        /// Gets the unique identifier associated with this Data Lake Store
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountId")]
        public System.Guid? AccountId { get; private set; }

        /// <summary>
        /// Gets the provisioning status of the Data Lake Store account.
        /// Possible values include: 'Failed', 'Creating', 'Running',
        /// 'Succeeded', 'Patching', 'Suspending', 'Resuming', 'Deleting',
        /// 'Deleted', 'Undeleting', 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public DataLakeStoreAccountStatus? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the state of the Data Lake Store account. Possible values
        /// include: 'Active', 'Suspended'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public DataLakeStoreAccountState? State { get; private set; }

        /// <summary>
        /// Gets the account creation time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets the account last modified time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets the full CName endpoint for this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpoint")]
        public string Endpoint { get; private set; }

        /// <summary>
        /// Gets the default owner group for all new folders and files created
        /// in the Data Lake Store account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultGroup")]
        public string DefaultGroup { get; private set; }

        /// <summary>
        /// Gets the Key Vault encryption configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryptionConfig")]
        public EncryptionConfig EncryptionConfig { get; private set; }

        /// <summary>
        /// Gets the current state of encryption for this Data Lake Store
        /// account. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryptionState")]
        public EncryptionState? EncryptionState { get; private set; }

        /// <summary>
        /// Gets the current state of encryption provisioning for this Data
        /// Lake Store account. Possible values include: 'Creating',
        /// 'Succeeded'
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryptionProvisioningState")]
        public EncryptionProvisioningState? EncryptionProvisioningState { get; private set; }

        /// <summary>
        /// Gets the list of firewall rules associated with this Data Lake
        /// Store account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallRules")]
        public IList<FirewallRule> FirewallRules { get; private set; }

        /// <summary>
        /// Gets the current state of the IP address firewall for this Data
        /// Lake Store account. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallState")]
        public FirewallState? FirewallState { get; private set; }

        /// <summary>
        /// Gets the current state of allowing or disallowing IPs originating
        /// within Azure through the firewall. If the firewall is disabled,
        /// this is not enforced. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallAllowAzureIps")]
        public FirewallAllowAzureIpsState? FirewallAllowAzureIps { get; private set; }

        /// <summary>
        /// Gets the list of trusted identity providers associated with this
        /// Data Lake Store account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.trustedIdProviders")]
        public IList<TrustedIdProvider> TrustedIdProviders { get; private set; }

        /// <summary>
        /// Gets the current state of the trusted identity provider feature for
        /// this Data Lake Store account. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.trustedIdProviderState")]
        public TrustedIdProviderState? TrustedIdProviderState { get; private set; }

        /// <summary>
        /// Gets the commitment tier to use for next month. Possible values
        /// include: 'Consumption', 'Commitment_1TB', 'Commitment_10TB',
        /// 'Commitment_100TB', 'Commitment_500TB', 'Commitment_1PB',
        /// 'Commitment_5PB'
        /// </summary>
        [JsonProperty(PropertyName = "properties.newTier")]
        public TierType? NewTier { get; private set; }

        /// <summary>
        /// Gets the commitment tier in use for the current month. Possible
        /// values include: 'Consumption', 'Commitment_1TB', 'Commitment_10TB',
        /// 'Commitment_100TB', 'Commitment_500TB', 'Commitment_1PB',
        /// 'Commitment_5PB'
        /// </summary>
        [JsonProperty(PropertyName = "properties.currentTier")]
        public TierType? CurrentTier { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EncryptionConfig != null)
            {
                EncryptionConfig.Validate();
            }
        }
    }
}
