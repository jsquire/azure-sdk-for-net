// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure Data Explorer (Kusto) linked service. </summary>
    public partial class AzureDataExplorerLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="AzureDataExplorerLinkedService"/>. </summary>
        /// <param name="endpoint"> The endpoint of Azure Data Explorer (the engine's endpoint). URL will be in the format https://&lt;clusterName&gt;.&lt;regionName&gt;.kusto.windows.net. Type: string (or Expression with resultType string). </param>
        /// <param name="database"> Database name for connection. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="database"/> is null. </exception>
        public AzureDataExplorerLinkedService(object endpoint, object database)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(database, nameof(database));

            Endpoint = endpoint;
            Database = database;
            Type = "AzureDataExplorer";
        }

        /// <summary> Initializes a new instance of <see cref="AzureDataExplorerLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="version"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="endpoint"> The endpoint of Azure Data Explorer (the engine's endpoint). URL will be in the format https://&lt;clusterName&gt;.&lt;regionName&gt;.kusto.windows.net. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalId"> The ID of the service principal used to authenticate against Azure Data Explorer. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey">
        /// The key of the service principal used to authenticate against Kusto.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="database"> Database name for connection. Type: string (or Expression with resultType string). </param>
        /// <param name="tenant"> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        internal AzureDataExplorerLinkedService(string type, string version, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object endpoint, object servicePrincipalId, SecretBase servicePrincipalKey, object database, object tenant, CredentialReference credential) : base(type, version, connectVia, description, parameters, annotations, additionalProperties)
        {
            Endpoint = endpoint;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Database = database;
            Tenant = tenant;
            Credential = credential;
            Type = type ?? "AzureDataExplorer";
        }

        /// <summary> The endpoint of Azure Data Explorer (the engine's endpoint). URL will be in the format https://&lt;clusterName&gt;.&lt;regionName&gt;.kusto.windows.net. Type: string (or Expression with resultType string). </summary>
        public object Endpoint { get; set; }
        /// <summary> The ID of the service principal used to authenticate against Azure Data Explorer. Type: string (or Expression with resultType string). </summary>
        public object ServicePrincipalId { get; set; }
        /// <summary>
        /// The key of the service principal used to authenticate against Kusto.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase ServicePrincipalKey { get; set; }
        /// <summary> Database name for connection. Type: string (or Expression with resultType string). </summary>
        public object Database { get; set; }
        /// <summary> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </summary>
        public object Tenant { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public CredentialReference Credential { get; set; }
    }
}
