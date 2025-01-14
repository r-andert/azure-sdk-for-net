// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.MySql
{
    /// <summary>
    /// A class representing a collection of <see cref="MySqlRecommendationActionResource" /> and their operations.
    /// Each <see cref="MySqlRecommendationActionResource" /> in the collection will belong to the same instance of <see cref="MySqlAdvisorResource" />.
    /// To get a <see cref="MySqlRecommendationActionCollection" /> instance call the GetMySqlRecommendationActions method from an instance of <see cref="MySqlAdvisorResource" />.
    /// </summary>
    public partial class MySqlRecommendationActionCollection : ArmCollection, IEnumerable<MySqlRecommendationActionResource>, IAsyncEnumerable<MySqlRecommendationActionResource>
    {
        private readonly ClientDiagnostics _mySqlRecommendationActionRecommendedActionsClientDiagnostics;
        private readonly RecommendedActionsRestOperations _mySqlRecommendationActionRecommendedActionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MySqlRecommendationActionCollection"/> class for mocking. </summary>
        protected MySqlRecommendationActionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MySqlRecommendationActionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MySqlRecommendationActionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mySqlRecommendationActionRecommendedActionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql", MySqlRecommendationActionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MySqlRecommendationActionResource.ResourceType, out string mySqlRecommendationActionRecommendedActionsApiVersion);
            _mySqlRecommendationActionRecommendedActionsRestClient = new RecommendedActionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mySqlRecommendationActionRecommendedActionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MySqlAdvisorResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MySqlAdvisorResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Retrieve recommended actions from the advisor.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/advisors/{advisorName}/recommendedActions/{recommendedActionName}
        /// Operation Id: RecommendedActions_Get
        /// </summary>
        /// <param name="recommendedActionName"> The recommended action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recommendedActionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendedActionName"/> is null. </exception>
        public virtual async Task<Response<MySqlRecommendationActionResource>> GetAsync(string recommendedActionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recommendedActionName, nameof(recommendedActionName));

            using var scope = _mySqlRecommendationActionRecommendedActionsClientDiagnostics.CreateScope("MySqlRecommendationActionCollection.Get");
            scope.Start();
            try
            {
                var response = await _mySqlRecommendationActionRecommendedActionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, recommendedActionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlRecommendationActionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve recommended actions from the advisor.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/advisors/{advisorName}/recommendedActions/{recommendedActionName}
        /// Operation Id: RecommendedActions_Get
        /// </summary>
        /// <param name="recommendedActionName"> The recommended action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recommendedActionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendedActionName"/> is null. </exception>
        public virtual Response<MySqlRecommendationActionResource> Get(string recommendedActionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recommendedActionName, nameof(recommendedActionName));

            using var scope = _mySqlRecommendationActionRecommendedActionsClientDiagnostics.CreateScope("MySqlRecommendationActionCollection.Get");
            scope.Start();
            try
            {
                var response = _mySqlRecommendationActionRecommendedActionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, recommendedActionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlRecommendationActionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve recommended actions from the advisor.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/advisors/{advisorName}/recommendedActions
        /// Operation Id: RecommendedActions_ListByServer
        /// </summary>
        /// <param name="sessionId"> The recommendation action session identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlRecommendationActionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlRecommendationActionResource> GetAllAsync(string sessionId = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<MySqlRecommendationActionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mySqlRecommendationActionRecommendedActionsClientDiagnostics.CreateScope("MySqlRecommendationActionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _mySqlRecommendationActionRecommendedActionsRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sessionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MySqlRecommendationActionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MySqlRecommendationActionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _mySqlRecommendationActionRecommendedActionsClientDiagnostics.CreateScope("MySqlRecommendationActionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _mySqlRecommendationActionRecommendedActionsRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sessionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MySqlRecommendationActionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Retrieve recommended actions from the advisor.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/advisors/{advisorName}/recommendedActions
        /// Operation Id: RecommendedActions_ListByServer
        /// </summary>
        /// <param name="sessionId"> The recommendation action session identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlRecommendationActionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlRecommendationActionResource> GetAll(string sessionId = null, CancellationToken cancellationToken = default)
        {
            Page<MySqlRecommendationActionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mySqlRecommendationActionRecommendedActionsClientDiagnostics.CreateScope("MySqlRecommendationActionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _mySqlRecommendationActionRecommendedActionsRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sessionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MySqlRecommendationActionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MySqlRecommendationActionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _mySqlRecommendationActionRecommendedActionsClientDiagnostics.CreateScope("MySqlRecommendationActionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _mySqlRecommendationActionRecommendedActionsRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sessionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MySqlRecommendationActionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/advisors/{advisorName}/recommendedActions/{recommendedActionName}
        /// Operation Id: RecommendedActions_Get
        /// </summary>
        /// <param name="recommendedActionName"> The recommended action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recommendedActionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendedActionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string recommendedActionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recommendedActionName, nameof(recommendedActionName));

            using var scope = _mySqlRecommendationActionRecommendedActionsClientDiagnostics.CreateScope("MySqlRecommendationActionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mySqlRecommendationActionRecommendedActionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, recommendedActionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/advisors/{advisorName}/recommendedActions/{recommendedActionName}
        /// Operation Id: RecommendedActions_Get
        /// </summary>
        /// <param name="recommendedActionName"> The recommended action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recommendedActionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendedActionName"/> is null. </exception>
        public virtual Response<bool> Exists(string recommendedActionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recommendedActionName, nameof(recommendedActionName));

            using var scope = _mySqlRecommendationActionRecommendedActionsClientDiagnostics.CreateScope("MySqlRecommendationActionCollection.Exists");
            scope.Start();
            try
            {
                var response = _mySqlRecommendationActionRecommendedActionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, recommendedActionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MySqlRecommendationActionResource> IEnumerable<MySqlRecommendationActionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MySqlRecommendationActionResource> IAsyncEnumerable<MySqlRecommendationActionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
