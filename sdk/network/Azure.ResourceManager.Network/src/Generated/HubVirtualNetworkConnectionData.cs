// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the HubVirtualNetworkConnection data model. </summary>
    public partial class HubVirtualNetworkConnectionData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of HubVirtualNetworkConnectionData. </summary>
        public HubVirtualNetworkConnectionData()
        {
        }

        /// <summary> Initializes a new instance of HubVirtualNetworkConnectionData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="remoteVirtualNetwork"> Reference to the remote virtual network. </param>
        /// <param name="allowHubToRemoteVnetTransit"> Deprecated: VirtualHub to RemoteVnet transit to enabled or not. </param>
        /// <param name="allowRemoteVnetToUseHubVnetGateways"> Deprecated: Allow RemoteVnet to use Virtual Hub&apos;s gateways. </param>
        /// <param name="enableInternetSecurity"> Enable internet security. </param>
        /// <param name="routingConfiguration"> The Routing Configuration indicating the associated and propagated route tables on this connection. </param>
        /// <param name="provisioningState"> The provisioning state of the hub virtual network connection resource. </param>
        internal HubVirtualNetworkConnectionData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, WritableSubResource remoteVirtualNetwork, bool? allowHubToRemoteVnetTransit, bool? allowRemoteVnetToUseHubVnetGateways, bool? enableInternetSecurity, RoutingConfiguration routingConfiguration, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            Etag = etag;
            RemoteVirtualNetwork = remoteVirtualNetwork;
            AllowHubToRemoteVnetTransit = allowHubToRemoteVnetTransit;
            AllowRemoteVnetToUseHubVnetGateways = allowRemoteVnetToUseHubVnetGateways;
            EnableInternetSecurity = enableInternetSecurity;
            RoutingConfiguration = routingConfiguration;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? Etag { get; }
        /// <summary> Reference to the remote virtual network. </summary>
        internal WritableSubResource RemoteVirtualNetwork { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier RemoteVirtualNetworkId
        {
            get => RemoteVirtualNetwork is null ? default : RemoteVirtualNetwork.Id;
            set
            {
                if (RemoteVirtualNetwork is null)
                    RemoteVirtualNetwork = new WritableSubResource();
                RemoteVirtualNetwork.Id = value;
            }
        }

        /// <summary> Deprecated: VirtualHub to RemoteVnet transit to enabled or not. </summary>
        public bool? AllowHubToRemoteVnetTransit { get; set; }
        /// <summary> Deprecated: Allow RemoteVnet to use Virtual Hub&apos;s gateways. </summary>
        public bool? AllowRemoteVnetToUseHubVnetGateways { get; set; }
        /// <summary> Enable internet security. </summary>
        public bool? EnableInternetSecurity { get; set; }
        /// <summary> The Routing Configuration indicating the associated and propagated route tables on this connection. </summary>
        public RoutingConfiguration RoutingConfiguration { get; set; }
        /// <summary> The provisioning state of the hub virtual network connection resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
