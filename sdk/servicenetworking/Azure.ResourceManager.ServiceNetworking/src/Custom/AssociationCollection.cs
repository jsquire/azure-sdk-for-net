// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ServiceNetworking
{
    /// <summary>
    /// A class representing a collection of <see cref="AssociationResource"/> and their operations.
    /// Each <see cref="AssociationResource"/> in the collection will belong to the same instance of <see cref="TrafficControllerResource"/>.
    /// To get an <see cref="AssociationCollection"/> instance call the GetAssociations method from an instance of <see cref="TrafficControllerResource"/>.
    /// </summary>
    [Obsolete("This class is now deprecated. Please use the new class `TrafficControllerAssociationCollection` moving forward.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class AssociationCollection : ArmCollection, IEnumerable<AssociationResource>, IAsyncEnumerable<AssociationResource>
    {
        private readonly ClientDiagnostics _associationAssociationsInterfaceClientDiagnostics;
        private readonly AssociationsInterfaceRestOperations _associationAssociationsInterfaceRestClient;

        /// <summary> Initializes a new instance of the <see cref="AssociationCollection"/> class for mocking. </summary>
        protected AssociationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AssociationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AssociationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _associationAssociationsInterfaceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceNetworking", AssociationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AssociationResource.ResourceType, out string associationAssociationsInterfaceApiVersion);
            _associationAssociationsInterfaceRestClient = new AssociationsInterfaceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, associationAssociationsInterfaceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TrafficControllerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TrafficControllerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a Association
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceNetworking/trafficControllers/{trafficControllerName}/associations/{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociationsInterface_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="associationName"> Name of Association. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AssociationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string associationName, AssociationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _associationAssociationsInterfaceClientDiagnostics.CreateScope("AssociationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _associationAssociationsInterfaceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, associationName, data.ToTrafficControllerAssociationData(), cancellationToken).ConfigureAwait(false);
                var operation = new ServiceNetworkingArmOperation<AssociationResource>(new AssociationOperationSource(Client),_associationAssociationsInterfaceClientDiagnostics, Pipeline, _associationAssociationsInterfaceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, associationName, data.ToTrafficControllerAssociationData()).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a Association
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceNetworking/trafficControllers/{trafficControllerName}/associations/{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociationsInterface_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="associationName"> Name of Association. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AssociationResource> CreateOrUpdate(WaitUntil waitUntil, string associationName, AssociationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _associationAssociationsInterfaceClientDiagnostics.CreateScope("AssociationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _associationAssociationsInterfaceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, associationName, data.ToTrafficControllerAssociationData(), cancellationToken);
                var operation = new ServiceNetworkingArmOperation<AssociationResource>(new AssociationOperationSource(Client), _associationAssociationsInterfaceClientDiagnostics, Pipeline, _associationAssociationsInterfaceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, associationName, data.ToTrafficControllerAssociationData()).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Association
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceNetworking/trafficControllers/{trafficControllerName}/associations/{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociationsInterface_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="associationName"> Name of Association. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> is null. </exception>
        public virtual async Task<Response<AssociationResource>> GetAsync(string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var scope = _associationAssociationsInterfaceClientDiagnostics.CreateScope("AssociationCollection.Get");
            scope.Start();
            try
            {
                var response = await _associationAssociationsInterfaceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, associationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AssociationResource(Client, new AssociationData(response.Value)), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Association
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceNetworking/trafficControllers/{trafficControllerName}/associations/{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociationsInterface_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="associationName"> Name of Association. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> is null. </exception>
        public virtual Response<AssociationResource> Get(string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var scope = _associationAssociationsInterfaceClientDiagnostics.CreateScope("AssociationCollection.Get");
            scope.Start();
            try
            {
                var response = _associationAssociationsInterfaceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, associationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AssociationResource(Client, new AssociationData(response.Value)), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Association resources by TrafficController
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceNetworking/trafficControllers/{trafficControllerName}/associations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociationsInterface_ListByTrafficController</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AssociationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AssociationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _associationAssociationsInterfaceRestClient.CreateListByTrafficControllerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _associationAssociationsInterfaceRestClient.CreateListByTrafficControllerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AssociationResource(Client, AssociationData.DeserializeAssociationData(e)), _associationAssociationsInterfaceClientDiagnostics, Pipeline, "AssociationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Association resources by TrafficController
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceNetworking/trafficControllers/{trafficControllerName}/associations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociationsInterface_ListByTrafficController</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AssociationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AssociationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _associationAssociationsInterfaceRestClient.CreateListByTrafficControllerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _associationAssociationsInterfaceRestClient.CreateListByTrafficControllerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AssociationResource(Client, AssociationData.DeserializeAssociationData(e)), _associationAssociationsInterfaceClientDiagnostics, Pipeline, "AssociationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceNetworking/trafficControllers/{trafficControllerName}/associations/{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociationsInterface_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="associationName"> Name of Association. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var scope = _associationAssociationsInterfaceClientDiagnostics.CreateScope("AssociationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _associationAssociationsInterfaceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, associationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceNetworking/trafficControllers/{trafficControllerName}/associations/{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociationsInterface_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="associationName"> Name of Association. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> is null. </exception>
        public virtual Response<bool> Exists(string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var scope = _associationAssociationsInterfaceClientDiagnostics.CreateScope("AssociationCollection.Exists");
            scope.Start();
            try
            {
                var response = _associationAssociationsInterfaceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, associationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceNetworking/trafficControllers/{trafficControllerName}/associations/{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociationsInterface_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="associationName"> Name of Association. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> is null. </exception>
        public virtual async Task<NullableResponse<AssociationResource>> GetIfExistsAsync(string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var scope = _associationAssociationsInterfaceClientDiagnostics.CreateScope("AssociationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _associationAssociationsInterfaceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, associationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AssociationResource>(response.GetRawResponse());
                return Response.FromValue(new AssociationResource(Client, new AssociationData(response.Value)), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceNetworking/trafficControllers/{trafficControllerName}/associations/{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssociationsInterface_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="associationName"> Name of Association. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> is null. </exception>
        public virtual NullableResponse<AssociationResource> GetIfExists(string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var scope = _associationAssociationsInterfaceClientDiagnostics.CreateScope("AssociationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _associationAssociationsInterfaceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, associationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AssociationResource>(response.GetRawResponse());
                return Response.FromValue(new AssociationResource(Client, new AssociationData(response.Value)), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AssociationResource> IEnumerable<AssociationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AssociationResource> IAsyncEnumerable<AssociationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
