// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the create or update webhook operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class WebhookCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the WebhookCreateOrUpdateParameters
        /// class.
        /// </summary>
        public WebhookCreateOrUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebhookCreateOrUpdateParameters
        /// class.
        /// </summary>
        /// <param name="name">Gets or sets the name of the webhook.</param>
        /// <param name="isEnabled">Gets or sets the value of the enabled flag
        /// of webhook.</param>
        /// <param name="uri">Gets or sets the uri.</param>
        /// <param name="expiryTime">Gets or sets the expiry time.</param>
        /// <param name="parameters">Gets or sets the parameters of the
        /// job.</param>
        /// <param name="runbook">Gets or sets the runbook.</param>
        /// <param name="runOn">Gets or sets the name of the hybrid worker
        /// group the webhook job will run on.</param>
        public WebhookCreateOrUpdateParameters(string name, bool? isEnabled = default(bool?), string uri = default(string), System.DateTime? expiryTime = default(System.DateTime?), IDictionary<string, string> parameters = default(IDictionary<string, string>), RunbookAssociationProperty runbook = default(RunbookAssociationProperty), string runOn = default(string))
        {
            Name = name;
            IsEnabled = isEnabled;
            Uri = uri;
            ExpiryTime = expiryTime;
            Parameters = parameters;
            Runbook = runbook;
            RunOn = runOn;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the webhook.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the enabled flag of webhook.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isEnabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the uri.
        /// </summary>
        [JsonProperty(PropertyName = "properties.uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the expiry time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expiryTime")]
        public System.DateTime? ExpiryTime { get; set; }

        /// <summary>
        /// Gets or sets the parameters of the job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public IDictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Gets or sets the runbook.
        /// </summary>
        [JsonProperty(PropertyName = "properties.runbook")]
        public RunbookAssociationProperty Runbook { get; set; }

        /// <summary>
        /// Gets or sets the name of the hybrid worker group the webhook job
        /// will run on.
        /// </summary>
        [JsonProperty(PropertyName = "properties.runOn")]
        public string RunOn { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
