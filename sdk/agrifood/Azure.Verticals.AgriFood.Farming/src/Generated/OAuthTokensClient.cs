// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    /// <summary> The OAuthTokens service client. </summary>
    public partial class OAuthTokensClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of OAuthTokensClient for mocking. </summary>
        protected OAuthTokensClient()
        {
        }

        /// <summary> Initializes a new instance of OAuthTokensClient. </summary>
        /// <param name="endpoint"> The endpoint of your FarmBeats resource (protocol and hostname, for example: https://{resourceName}.farmbeats.azure.net). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public OAuthTokensClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new FarmBeatsClientOptions())
        {
        }

        /// <summary> Initializes a new instance of OAuthTokensClient. </summary>
        /// <param name="endpoint"> The endpoint of your FarmBeats resource (protocol and hostname, for example: https://{resourceName}.farmbeats.azure.net). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public OAuthTokensClient(Uri endpoint, TokenCredential credential, FarmBeatsClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new FarmBeatsClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Returns Connection link needed in the OAuth flow. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   farmerId: string (required),
        ///   oAuthProviderId: string (required),
        ///   userRedirectLink: string (required),
        ///   userRedirectState: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetOAuthConnectionLinkAsync(RequestContent content, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("OAuthTokensClient.GetOAuthConnectionLink");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetOAuthConnectionLinkRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns Connection link needed in the OAuth flow. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   farmerId: string (required),
        ///   oAuthProviderId: string (required),
        ///   userRedirectLink: string (required),
        ///   userRedirectState: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetOAuthConnectionLink(RequestContent content, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("OAuthTokensClient.GetOAuthConnectionLink");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetOAuthConnectionLinkRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get cascade delete job details for OAuth tokens for specified job ID. </summary>
        /// <param name="jobId"> ID of the job. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   resourceId: string,
        ///   resourceType: string,
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetCascadeDeleteJobDetailsAsync(string jobId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("OAuthTokensClient.GetCascadeDeleteJobDetails");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetCascadeDeleteJobDetailsRequest(jobId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get cascade delete job details for OAuth tokens for specified job ID. </summary>
        /// <param name="jobId"> ID of the job. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   resourceId: string,
        ///   resourceType: string,
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetCascadeDeleteJobDetails(string jobId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("OAuthTokensClient.GetCascadeDeleteJobDetails");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetCascadeDeleteJobDetailsRequest(jobId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns a list of OAuthToken documents. </summary>
        /// <param name="authProviderIds"> Name of AuthProvider. </param>
        /// <param name="farmerIds"> List of farmers. </param>
        /// <param name="isValid"> If the token object is valid. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       farmerId: string,
        ///       authProviderId: string,
        ///       isValid: boolean,
        ///       eTag: string,
        ///       createdDateTime: string (ISO 8601 Format),
        ///       modifiedDateTime: string (ISO 8601 Format)
        ///     }
        ///   ],
        ///   $skipToken: string,
        ///   nextLink: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual AsyncPageable<BinaryData> GetOAuthTokensAsync(IEnumerable<string> authProviderIds = null, IEnumerable<string> farmerIds = null, bool? isValid = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestContext context = null)
        {
            return GetOAuthTokensImplementationAsync("OAuthTokensClient.GetOAuthTokens", authProviderIds, farmerIds, isValid, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
        }

        private AsyncPageable<BinaryData> GetOAuthTokensImplementationAsync(string diagnosticsScopeName, IEnumerable<string> authProviderIds, IEnumerable<string> farmerIds, bool? isValid, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, diagnosticsScopeName);
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetOAuthTokensRequest(authProviderIds, farmerIds, isValid, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context)
                        : CreateGetOAuthTokensNextPageRequest(nextLink, authProviderIds, farmerIds, isValid, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "value", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> Returns a list of OAuthToken documents. </summary>
        /// <param name="authProviderIds"> Name of AuthProvider. </param>
        /// <param name="farmerIds"> List of farmers. </param>
        /// <param name="isValid"> If the token object is valid. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       farmerId: string,
        ///       authProviderId: string,
        ///       isValid: boolean,
        ///       eTag: string,
        ///       createdDateTime: string (ISO 8601 Format),
        ///       modifiedDateTime: string (ISO 8601 Format)
        ///     }
        ///   ],
        ///   $skipToken: string,
        ///   nextLink: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Pageable<BinaryData> GetOAuthTokens(IEnumerable<string> authProviderIds = null, IEnumerable<string> farmerIds = null, bool? isValid = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestContext context = null)
        {
            return GetOAuthTokensImplementation("OAuthTokensClient.GetOAuthTokens", authProviderIds, farmerIds, isValid, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
        }

        private Pageable<BinaryData> GetOAuthTokensImplementation(string diagnosticsScopeName, IEnumerable<string> authProviderIds, IEnumerable<string> farmerIds, bool? isValid, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, diagnosticsScopeName);
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetOAuthTokensRequest(authProviderIds, farmerIds, isValid, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context)
                        : CreateGetOAuthTokensNextPageRequest(nextLink, authProviderIds, farmerIds, isValid, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "value", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> Create a cascade delete job for OAuth tokens. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobId"> Job ID supplied by end user. </param>
        /// <param name="farmerId"> ID of the farmer. </param>
        /// <param name="oauthProviderId"> ID of the OAuthProvider. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/>, <paramref name="farmerId"/> or <paramref name="oauthProviderId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   resourceId: string,
        ///   resourceType: string,
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Operation<BinaryData>> CreateCascadeDeleteJobAsync(WaitUntil waitUntil, string jobId, string farmerId, string oauthProviderId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));
            Argument.AssertNotNull(farmerId, nameof(farmerId));
            Argument.AssertNotNull(oauthProviderId, nameof(oauthProviderId));

            using var scope = ClientDiagnostics.CreateScope("OAuthTokensClient.CreateCascadeDeleteJob");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateCascadeDeleteJobRequest(jobId, farmerId, oauthProviderId, context);
                return await ProtocolOperationHelpers.ProcessMessageAsync(_pipeline, message, ClientDiagnostics, "OAuthTokensClient.CreateCascadeDeleteJob", OperationFinalStateVia.Location, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a cascade delete job for OAuth tokens. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobId"> Job ID supplied by end user. </param>
        /// <param name="farmerId"> ID of the farmer. </param>
        /// <param name="oauthProviderId"> ID of the OAuthProvider. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/>, <paramref name="farmerId"/> or <paramref name="oauthProviderId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   resourceId: string,
        ///   resourceType: string,
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Operation<BinaryData> CreateCascadeDeleteJob(WaitUntil waitUntil, string jobId, string farmerId, string oauthProviderId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));
            Argument.AssertNotNull(farmerId, nameof(farmerId));
            Argument.AssertNotNull(oauthProviderId, nameof(oauthProviderId));

            using var scope = ClientDiagnostics.CreateScope("OAuthTokensClient.CreateCascadeDeleteJob");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateCascadeDeleteJobRequest(jobId, farmerId, oauthProviderId, context);
                return ProtocolOperationHelpers.ProcessMessage(_pipeline, message, ClientDiagnostics, "OAuthTokensClient.CreateCascadeDeleteJob", OperationFinalStateVia.Location, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetOAuthTokensRequest(IEnumerable<string> authProviderIds, IEnumerable<string> farmerIds, bool? isValid, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/oauth/tokens", false);
            if (authProviderIds != null)
            {
                foreach (var param in authProviderIds)
                {
                    uri.AppendQuery("authProviderIds", param, true);
                }
            }
            if (farmerIds != null)
            {
                foreach (var param in farmerIds)
                {
                    uri.AppendQuery("farmerIds", param, true);
                }
            }
            if (isValid != null)
            {
                uri.AppendQuery("isValid", isValid.Value, true);
            }
            if (minCreatedDateTime != null)
            {
                uri.AppendQuery("minCreatedDateTime", minCreatedDateTime.Value, "O", true);
            }
            if (maxCreatedDateTime != null)
            {
                uri.AppendQuery("maxCreatedDateTime", maxCreatedDateTime.Value, "O", true);
            }
            if (minLastModifiedDateTime != null)
            {
                uri.AppendQuery("minLastModifiedDateTime", minLastModifiedDateTime.Value, "O", true);
            }
            if (maxLastModifiedDateTime != null)
            {
                uri.AppendQuery("maxLastModifiedDateTime", maxLastModifiedDateTime.Value, "O", true);
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("$maxPageSize", maxPageSize.Value, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetOAuthConnectionLinkRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/oauth/tokens/:connect", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetCascadeDeleteJobDetailsRequest(string jobId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/oauth/tokens/remove/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateCreateCascadeDeleteJobRequest(string jobId, string farmerId, string oauthProviderId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier202);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/oauth/tokens/remove/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("farmerId", farmerId, true);
            uri.AppendQuery("oauthProviderId", oauthProviderId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetOAuthTokensNextPageRequest(string nextLink, IEnumerable<string> authProviderIds, IEnumerable<string> farmerIds, bool? isValid, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
        private static ResponseClassifier _responseClassifier202;
        private static ResponseClassifier ResponseClassifier202 => _responseClassifier202 ??= new StatusCodeClassifier(stackalloc ushort[] { 202 });
    }
}
