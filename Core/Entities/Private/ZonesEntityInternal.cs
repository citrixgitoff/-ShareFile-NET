// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2014 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using ShareFile.Api.Models;
using ShareFile.Api.Client;
using ShareFile.Api.Client.Requests;

namespace ShareFile.Api.Client.Entities
{
#if ShareFile

	public interface IZonesEntityInternal : IEntityBase
	{
		/// <summary>
		/// Get List of Zones
		/// </summary>
		/// <remarks>
		/// Retrieve the list of Zones accessible to the authenticated user
		/// This method will concatenate the list of private zones in the user's account and the
		/// list of public zones accessible to this account. Any user can see the list of zones.
		/// </remarks>
		/// <param name="services"></param>
		/// <param name="includeDisabled"></param>
		/// <returns>
		/// The list of public and private zones accessible to this user
		/// </returns>
		IQuery<ODataFeed<Zone>> Get(ZoneService services = ZoneService.StorageZone, bool includeDisabled = false);
		/// <summary>
		/// Get List of Zones
		/// </summary>
		/// <remarks>
		/// Retrieve the list of Zones accessible to the authenticated user
		/// This method will concatenate the list of private zones in the user's account and the
		/// list of public zones accessible to this account. Any user can see the list of zones.
		/// </remarks>
		/// <param name="services"></param>
		/// <param name="includeDisabled"></param>
		/// <returns>
		/// The list of public and private zones accessible to this user
		/// </returns>
		IQuery<Zone> Get(string id, bool secret = false);
		/// <summary>
		/// Create Zone
		/// </summary>
		/// <example>
		/// {
		/// "Name":"Name",
		/// "HeartbeatTolerance":10,
		/// "ZoneServices":"StorageZone, SharepointConnector, NetworkShareConnector"
		/// }
		/// </example>
		/// <remarks>
		/// Creates a new Zone.
		/// </remarks>
		/// <returns>
		/// the created zone
		/// </returns>
		IQuery<Zone> Create(Zone zone);
		/// <summary>
		/// Update Zone
		/// </summary>
		/// <example>
		/// {
		/// "Name":"Name",
		/// "HeartbeatTolerance":10,
		/// "ZoneServices":"StorageZone, SharepointConnector, NetworkShareConnector"
		/// }
		/// </example>
		/// <remarks>
		/// Updates an existing zone
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="zone"></param>
		/// <returns>
		/// The modified zone
		/// </returns>
		IQuery<Zone> Update(string id, Zone zone);
		/// <summary>
		/// Delete Zone
		/// </summary>
		/// <remarks>
		/// Removes an existing zone
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="force"></param>
		IQuery Delete(string id, bool force = false);
		/// <summary>
		/// Reset Zone Secret
		/// </summary>
		/// <remarks>
		/// Resets the current Zone Secret to a new Random value
		/// Caution! This Call will invalidate all Storage Center communications until the Storage Center Zone secret
		/// is also updated.
		/// User must be a Zone admin to perform this action
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// The modified Zone object
		/// </returns>
		IQuery<Zone> ResetSecret(string id);
		/// <summary>
		/// Get Zone Metadata
		/// </summary>
		/// <remarks>
		/// Gets metadata associated with the specified zone
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// the zone metadata feed
		/// </returns>
		IQuery<ODataFeed<Metadata>> GetMetadata(string id);
		/// <summary>
		/// Create or update Zone Metadata
		/// </summary>
		/// <example>
		/// [
		/// {"Name":"metadataName1", "Value":"metadataValue1", "IsPublic":"true"},
		/// {"Name":"metadataName2", "Value":"metadataValue2", "IsPublic":"false"},
		/// ...
		/// ]
		/// </example>
		/// <remarks>
		/// Creates or updates Metadata entries associated with the specified zone
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="metadata"></param>
		/// <returns>
		/// the zone metadata feed
		/// </returns>
		IQuery<ODataFeed<Metadata>> CreateMetadata(string id, IEnumerable<Metadata> metadata);
		/// <summary>
		/// Delete Zone Metadata
		/// </summary>
		/// <remarks>
		/// Delete the Metadata entry associated with the specified zone
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="name"></param>
		/// <returns>
		/// no data on success
		/// </returns>
		IQuery DeleteMetadata(string id, string name);
	}

	public class ZonesEntityInternal : EntityBase, IZonesEntityInternal
	{
		public ZonesEntityInternal(IShareFileClient client)
			: base (client, "Zones")
			
		{

		}

		/// <summary>
		/// Get List of Zones
		/// </summary>
		/// <remarks>
		/// Retrieve the list of Zones accessible to the authenticated user
		/// This method will concatenate the list of private zones in the user's account and the
		/// list of public zones accessible to this account. Any user can see the list of zones.
		/// </remarks>
		/// <param name="services"></param>
		/// <param name="includeDisabled"></param>
		/// <returns>
		/// The list of public and private zones accessible to this user
		/// </returns>
		public IQuery<ODataFeed<Zone>> Get(ZoneService services = ZoneService.StorageZone, bool includeDisabled = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Zone>>(Client);
			sfApiQuery.From("Zones");
			sfApiQuery.QueryString("services", services);
			sfApiQuery.QueryString("includeDisabled", includeDisabled);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get List of Zones
		/// </summary>
		/// <remarks>
		/// Retrieve the list of Zones accessible to the authenticated user
		/// This method will concatenate the list of private zones in the user's account and the
		/// list of public zones accessible to this account. Any user can see the list of zones.
		/// </remarks>
		/// <param name="services"></param>
		/// <param name="includeDisabled"></param>
		/// <returns>
		/// The list of public and private zones accessible to this user
		/// </returns>
		public IQuery<Zone> Get(string id, bool secret = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Zone>(Client);
			sfApiQuery.From("Zones");
			sfApiQuery.Ids(id);
			sfApiQuery.QueryString("secret", secret);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Create Zone
		/// </summary>
		/// <example>
		/// {
		/// "Name":"Name",
		/// "HeartbeatTolerance":10,
		/// "ZoneServices":"StorageZone, SharepointConnector, NetworkShareConnector"
		/// }
		/// </example>
		/// <remarks>
		/// Creates a new Zone.
		/// </remarks>
		/// <returns>
		/// the created zone
		/// </returns>
		public IQuery<Zone> Create(Zone zone)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Zone>(Client);
			sfApiQuery.From("Zones");
			sfApiQuery.Body = zone;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Update Zone
		/// </summary>
		/// <example>
		/// {
		/// "Name":"Name",
		/// "HeartbeatTolerance":10,
		/// "ZoneServices":"StorageZone, SharepointConnector, NetworkShareConnector"
		/// }
		/// </example>
		/// <remarks>
		/// Updates an existing zone
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="zone"></param>
		/// <returns>
		/// The modified zone
		/// </returns>
		public IQuery<Zone> Update(string id, Zone zone)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Zone>(Client);
			sfApiQuery.From("Zones");
			sfApiQuery.Ids(id);
			sfApiQuery.Body = zone;
			sfApiQuery.HttpMethod = "PATCH";
			return sfApiQuery;
		}

		/// <summary>
		/// Delete Zone
		/// </summary>
		/// <remarks>
		/// Removes an existing zone
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="force"></param>
		public IQuery Delete(string id, bool force = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("Zones");
			sfApiQuery.Ids(id);
			sfApiQuery.QueryString("force", force);
			sfApiQuery.HttpMethod = "DELETE";
			return sfApiQuery;
		}

		/// <summary>
		/// Reset Zone Secret
		/// </summary>
		/// <remarks>
		/// Resets the current Zone Secret to a new Random value
		/// Caution! This Call will invalidate all Storage Center communications until the Storage Center Zone secret
		/// is also updated.
		/// User must be a Zone admin to perform this action
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// The modified Zone object
		/// </returns>
		public IQuery<Zone> ResetSecret(string id)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Zone>(Client);
			sfApiQuery.From("Zones");
			sfApiQuery.Action("ResetSecret");
			sfApiQuery.Ids(id);
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Get Zone Metadata
		/// </summary>
		/// <remarks>
		/// Gets metadata associated with the specified zone
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// the zone metadata feed
		/// </returns>
		public IQuery<ODataFeed<Metadata>> GetMetadata(string id)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Metadata>>(Client);
			sfApiQuery.From("Zones");
			sfApiQuery.Action("Metadata");
			sfApiQuery.Ids(id);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Create or update Zone Metadata
		/// </summary>
		/// <example>
		/// [
		/// {"Name":"metadataName1", "Value":"metadataValue1", "IsPublic":"true"},
		/// {"Name":"metadataName2", "Value":"metadataValue2", "IsPublic":"false"},
		/// ...
		/// ]
		/// </example>
		/// <remarks>
		/// Creates or updates Metadata entries associated with the specified zone
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="metadata"></param>
		/// <returns>
		/// the zone metadata feed
		/// </returns>
		public IQuery<ODataFeed<Metadata>> CreateMetadata(string id, IEnumerable<Metadata> metadata)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Metadata>>(Client);
			sfApiQuery.From("Zones");
			sfApiQuery.Action("Metadata");
			sfApiQuery.Ids(id);
			sfApiQuery.Body = metadata;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Delete Zone Metadata
		/// </summary>
		/// <remarks>
		/// Delete the Metadata entry associated with the specified zone
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="name"></param>
		/// <returns>
		/// no data on success
		/// </returns>
		public IQuery DeleteMetadata(string id, string name)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("Zones");
			sfApiQuery.Action("Metadata");
			sfApiQuery.Ids(id);
			sfApiQuery.QueryString("name", name);
			sfApiQuery.HttpMethod = "DELETE";
			return sfApiQuery;
		}

	}
#endif
}
