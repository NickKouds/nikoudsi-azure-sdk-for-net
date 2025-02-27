// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HybridData
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.HybridData. </summary>
    public static partial class HybridDataExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Lists all the data manager resources available under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.HybridData/dataManagers
        /// Operation Id: DataManagers_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataManagerResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DataManagerResource> GetDataManagersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDataManagersAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the data manager resources available under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.HybridData/dataManagers
        /// Operation Id: DataManagers_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataManagerResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DataManagerResource> GetDataManagers(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDataManagers(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of DataManagerResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DataManagerResources and their operations over a DataManagerResource. </returns>
        public static DataManagerCollection GetDataManagers(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetDataManagers();
        }

        /// <summary>
        /// Gets information about the specified data manager resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridData/dataManagers/{dataManagerName}
        /// Operation Id: DataManagers_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="dataManagerName"> The name of the DataManager Resource within the specified resource group. DataManager names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataManagerName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DataManagerResource>> GetDataManagerAsync(this ResourceGroupResource resourceGroupResource, string dataManagerName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetDataManagers().GetAsync(dataManagerName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the specified data manager resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridData/dataManagers/{dataManagerName}
        /// Operation Id: DataManagers_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="dataManagerName"> The name of the DataManager Resource within the specified resource group. DataManager names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataManagerName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<DataManagerResource> GetDataManager(this ResourceGroupResource resourceGroupResource, string dataManagerName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetDataManagers().Get(dataManagerName, cancellationToken);
        }

        #region DataManagerResource
        /// <summary>
        /// Gets an object representing a <see cref="DataManagerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataManagerResource.CreateResourceIdentifier" /> to create a <see cref="DataManagerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataManagerResource" /> object. </returns>
        public static DataManagerResource GetDataManagerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataManagerResource.ValidateResourceId(id);
                return new DataManagerResource(client, id);
            }
            );
        }
        #endregion

        #region DataServiceResource
        /// <summary>
        /// Gets an object representing a <see cref="DataServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataServiceResource.CreateResourceIdentifier" /> to create a <see cref="DataServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataServiceResource" /> object. </returns>
        public static DataServiceResource GetDataServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataServiceResource.ValidateResourceId(id);
                return new DataServiceResource(client, id);
            }
            );
        }
        #endregion

        #region HybridDataJobDefinitionResource
        /// <summary>
        /// Gets an object representing a <see cref="HybridDataJobDefinitionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridDataJobDefinitionResource.CreateResourceIdentifier" /> to create a <see cref="HybridDataJobDefinitionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridDataJobDefinitionResource" /> object. </returns>
        public static HybridDataJobDefinitionResource GetHybridDataJobDefinitionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                HybridDataJobDefinitionResource.ValidateResourceId(id);
                return new HybridDataJobDefinitionResource(client, id);
            }
            );
        }
        #endregion

        #region HybridDataJobResource
        /// <summary>
        /// Gets an object representing a <see cref="HybridDataJobResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridDataJobResource.CreateResourceIdentifier" /> to create a <see cref="HybridDataJobResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridDataJobResource" /> object. </returns>
        public static HybridDataJobResource GetHybridDataJobResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                HybridDataJobResource.ValidateResourceId(id);
                return new HybridDataJobResource(client, id);
            }
            );
        }
        #endregion

        #region DataStoreResource
        /// <summary>
        /// Gets an object representing a <see cref="DataStoreResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataStoreResource.CreateResourceIdentifier" /> to create a <see cref="DataStoreResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataStoreResource" /> object. </returns>
        public static DataStoreResource GetDataStoreResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataStoreResource.ValidateResourceId(id);
                return new DataStoreResource(client, id);
            }
            );
        }
        #endregion

        #region DataStoreTypeResource
        /// <summary>
        /// Gets an object representing a <see cref="DataStoreTypeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataStoreTypeResource.CreateResourceIdentifier" /> to create a <see cref="DataStoreTypeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataStoreTypeResource" /> object. </returns>
        public static DataStoreTypeResource GetDataStoreTypeResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataStoreTypeResource.ValidateResourceId(id);
                return new DataStoreTypeResource(client, id);
            }
            );
        }
        #endregion

        #region HybridDataPublicKeyResource
        /// <summary>
        /// Gets an object representing a <see cref="HybridDataPublicKeyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridDataPublicKeyResource.CreateResourceIdentifier" /> to create a <see cref="HybridDataPublicKeyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridDataPublicKeyResource" /> object. </returns>
        public static HybridDataPublicKeyResource GetHybridDataPublicKeyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                HybridDataPublicKeyResource.ValidateResourceId(id);
                return new HybridDataPublicKeyResource(client, id);
            }
            );
        }
        #endregion
    }
}
