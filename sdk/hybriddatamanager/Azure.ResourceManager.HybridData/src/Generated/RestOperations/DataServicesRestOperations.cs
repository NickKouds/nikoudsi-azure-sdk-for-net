// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.HybridData.Models;

namespace Azure.ResourceManager.HybridData
{
    internal partial class DataServicesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DataServicesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DataServicesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2019-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByDataManagerRequest(string subscriptionId, string resourceGroupName, string dataManagerName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.HybridData/dataManagers/", false);
            uri.AppendPath(dataManagerName, true);
            uri.AppendPath("/dataServices", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> This method gets all the data services. </summary>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="dataManagerName"> The name of the DataManager Resource within the specified resource group. DataManager names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="dataManagerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="dataManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataServiceList>> ListByDataManagerAsync(string subscriptionId, string resourceGroupName, string dataManagerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(dataManagerName, nameof(dataManagerName));

            using var message = CreateListByDataManagerRequest(subscriptionId, resourceGroupName, dataManagerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataServiceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataServiceList.DeserializeDataServiceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> This method gets all the data services. </summary>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="dataManagerName"> The name of the DataManager Resource within the specified resource group. DataManager names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="dataManagerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="dataManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataServiceList> ListByDataManager(string subscriptionId, string resourceGroupName, string dataManagerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(dataManagerName, nameof(dataManagerName));

            using var message = CreateListByDataManagerRequest(subscriptionId, resourceGroupName, dataManagerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataServiceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataServiceList.DeserializeDataServiceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string dataManagerName, string dataServiceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.HybridData/dataManagers/", false);
            uri.AppendPath(dataManagerName, true);
            uri.AppendPath("/dataServices/", false);
            uri.AppendPath(dataServiceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the data service that matches the data service name given. </summary>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="dataManagerName"> The name of the DataManager Resource within the specified resource group. DataManager names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="dataServiceName"> The name of the data service that is being queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="dataManagerName"/> or <paramref name="dataServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="dataManagerName"/> or <paramref name="dataServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataServiceData>> GetAsync(string subscriptionId, string resourceGroupName, string dataManagerName, string dataServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(dataManagerName, nameof(dataManagerName));
            Argument.AssertNotNullOrEmpty(dataServiceName, nameof(dataServiceName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, dataManagerName, dataServiceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataServiceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataServiceData.DeserializeDataServiceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DataServiceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the data service that matches the data service name given. </summary>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="dataManagerName"> The name of the DataManager Resource within the specified resource group. DataManager names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="dataServiceName"> The name of the data service that is being queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="dataManagerName"/> or <paramref name="dataServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="dataManagerName"/> or <paramref name="dataServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataServiceData> Get(string subscriptionId, string resourceGroupName, string dataManagerName, string dataServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(dataManagerName, nameof(dataManagerName));
            Argument.AssertNotNullOrEmpty(dataServiceName, nameof(dataServiceName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, dataManagerName, dataServiceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataServiceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataServiceData.DeserializeDataServiceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DataServiceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByDataManagerNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string dataManagerName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> This method gets all the data services. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="dataManagerName"> The name of the DataManager Resource within the specified resource group. DataManager names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="dataManagerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="dataManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataServiceList>> ListByDataManagerNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string dataManagerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(dataManagerName, nameof(dataManagerName));

            using var message = CreateListByDataManagerNextPageRequest(nextLink, subscriptionId, resourceGroupName, dataManagerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataServiceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataServiceList.DeserializeDataServiceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> This method gets all the data services. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Subscription Id. </param>
        /// <param name="resourceGroupName"> The Resource Group Name. </param>
        /// <param name="dataManagerName"> The name of the DataManager Resource within the specified resource group. DataManager names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="dataManagerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="dataManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataServiceList> ListByDataManagerNextPage(string nextLink, string subscriptionId, string resourceGroupName, string dataManagerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(dataManagerName, nameof(dataManagerName));

            using var message = CreateListByDataManagerNextPageRequest(nextLink, subscriptionId, resourceGroupName, dataManagerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataServiceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataServiceList.DeserializeDataServiceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
