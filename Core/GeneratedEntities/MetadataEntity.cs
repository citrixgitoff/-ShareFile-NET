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
	public class MetadataEntity : EntityBase
	{
		public MetadataEntity(ShareFileClient client)
			: base (client)
		{

		}

		/// <summary>
		/// Get Metadata by ID
		/// </summary>
		/// <remarks>
		/// Retrieves a single Metadata entry that has a given Name for a given Item.
		/// Note:
		/// 'GET https://account.sf-api.com/sf/v3/Items(parentid)/Metadata(id)' is unsupported.
		/// Current routing doesn't support the URI to retrieve a single Metadata enntry since it is aliased with the GetByItem feed.
		/// So for now we support only the same syntax as for AccessControls, i.e. .../Metadata(name=name,itemid=itemid)
		/// </remarks>
		/// <param name="name"></param>
		/// <param name="itemid"></param>
		/// <returns>
		/// A single Metadata object matching the query
		/// </returns>
		public IQuery<Metadata> Get(string name, string itemid)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Metadata>(Client);
			sfApiQuery.From("Metadata");
			sfApiQuery.Ids("name", name);
			sfApiQuery.Ids("itemid", itemid);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get Metadata List By Item
		/// </summary>
		/// <remarks>
		/// Retrieves the Metadata List for a given Item.
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// The Metadata list of the given object ID.
		/// </returns>
		public IQuery<ODataFeed<Metadata>> GetByItem(string id)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Metadata>>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("Metadata");
			sfApiQuery.Ids(id);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Create Metadata
		/// </summary>
		/// <example>
		/// {
		/// "Name":"metadata name",
		/// "Value":"metadata value"
		/// }
		/// </example>
		/// <remarks>
		/// Creates a single Metadata entry that has a specified Name for a given Item. Fails if an entry with the given name already exists for this Item.
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// The created Metadata object
		/// </returns>
		public IQuery<Metadata> CreateByItem(string id, Metadata metadata)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Metadata>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("Metadata");
			sfApiQuery.Ids(id);
			sfApiQuery.Body = metadata;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Update Metadata
		/// </summary>
		/// <example>
		/// {
		/// "Value":"metadata value"
		/// }
		/// </example>
		/// <remarks>
		/// Updates a single Metadata entry that has a specified Name for a given Item. Fails if an entry with the given name doesn't exist for this Item.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="metadataId"></param>
		/// <returns>
		/// The updated Metadata object
		/// </returns>
		public IQuery<Metadata> UpdateByItem(string id, string metadataId, Metadata metadata)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Metadata>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("Metadata");
			sfApiQuery.Ids(id);
			sfApiQuery.ActionIds(metadataId);
			sfApiQuery.Body = metadata;
			sfApiQuery.HttpMethod = "PATCH";
			return sfApiQuery;
		}

		/// <summary>
		/// Update Metadata
		/// </summary>
		/// <example>
		/// {
		/// "Value":"metadata value"
		/// }
		/// </example>
		/// <remarks>
		/// Updates a single Metadata entry that has a specified Name for a given Item. Fails if an entry with the given name doesn't exist for this Item.
		/// </remarks>
		/// <param name="name"></param>
		/// <param name="itemid"></param>
		/// <returns>
		/// The updated Metadata object
		/// </returns>
		public IQuery<Metadata> Update(string name, string itemid, Metadata metadata)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Metadata>(Client);
			sfApiQuery.From("Metadata");
			sfApiQuery.Ids("name", name);
			sfApiQuery.Ids("itemid", itemid);
			sfApiQuery.Body = metadata;
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Delete Metadata
		/// </summary>
		/// <remarks>
		/// Deletes a single Metadata entry that has a specified Name for a given Item. Fails if an entry with the given name doesn't exist for this Item.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="metadataId"></param>
		/// <returns>
		/// (no data)
		/// </returns>
		public IQuery DeleteByItem(string id, string metadataId)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("Metadata");
			sfApiQuery.Ids(id);
			sfApiQuery.ActionIds(metadataId);
			sfApiQuery.HttpMethod = "DELETE";
			return sfApiQuery;
		}

		/// <summary>
		/// Delete Metadata
		/// </summary>
		/// <remarks>
		/// Deletes a single Metadata entry that has a specified Name for a given Item. Fails if an entry with the given name doesn't exist for this Item.
		/// </remarks>
		/// <param name="name"></param>
		/// <param name="itemid"></param>
		/// <returns>
		/// (no data)
		/// </returns>
		public IQuery Delete(string name, string itemid)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("Metadata");
			sfApiQuery.Ids("name", name);
			sfApiQuery.Ids("itemid", itemid);
			sfApiQuery.HttpMethod = "DELETE";
			return sfApiQuery;
		}

	}
}
