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
using ShareFile.Api.Client.Extensions;


namespace ShareFile.Api.Client.Entities
{
#if ShareFile

	public interface IItemsEntityInternal : IItemsEntity
	{
		/// <summary>
		/// Advanced Simple Search
		/// </summary>
		/// <example>
		/// {
		/// "Query":{
		/// "AuthID":"",
		/// "ItemType":"",
		/// "ParentID":"",
		/// "CreatorID":"",
		/// "LuceneQuery":"",
		/// "SearchQuery":"",
		/// "CreateStartDate":"",
		/// "CreateEndDate":"",
		/// "ItemNameOnly":"",
		/// },
		/// "Paging":{
		/// "Key":"",
		/// "PageNumber":1,
		/// "PageSize":10,
		/// },
		/// "Sort":{
		/// "SortBy":"",
		/// "Ascending":false,
		/// },
		/// "TimeoutInSeconds":10
		/// }
		/// </example>
		/// <remarks>
		/// Search for Items matching the criteria of the query parameter
		/// </remarks>
		/// <param name="simpleSearchQuery"></param>
		/// <returns>
		/// AdvancedSearchResults
		/// </returns>
		IQuery<AdvancedSearchResults> AdvancedSimpleSearch(SimpleSearchQuery simpleSearchQuery);
		/// <summary>
		/// Advanced Search
		/// </summary>
		/// <example>
		/// {
		/// "Query":{
		/// "AuthIDs":["id1", "id2", ...],
		/// "ItemTypes":["type1", "type2", ...],
		/// "ParentID":["id1", "id2", ...],
		/// "CreatorID":["id1", "id2", ...],
		/// "LuceneQuery":"",
		/// "SearchQuery":"",
		/// "CreateStartDate":"",
		/// "CreateEndDate":"",
		/// "ItemNameOnly":"",
		/// },
		/// "Paging":{
		/// "Key":"",
		/// "PageNumber":1,
		/// "PageSize":10,
		/// },
		/// "Sort":{
		/// "SortBy":"",
		/// "Ascending":false,
		/// },
		/// "TimeoutInSeconds":10
		/// }
		/// </example>
		/// <remarks>
		/// Search for Items matching the criteria of the query parameter
		/// </remarks>
		/// <param name="searchQuery"></param>
		/// <returns>
		/// AdvancedSearchResults
		/// </returns>
		IQuery<AdvancedSearchResults> AdvancedSearch(SearchQuery searchQuery);
	}

	public class ItemsEntityInternal : ItemsEntity, IItemsEntityInternal
	{
		public ItemsEntityInternal(IShareFileClient client)
			: base (client)
			
		{

		}

		/// <summary>
		/// Advanced Simple Search
		/// </summary>
		/// <example>
		/// {
		/// "Query":{
		/// "AuthID":"",
		/// "ItemType":"",
		/// "ParentID":"",
		/// "CreatorID":"",
		/// "LuceneQuery":"",
		/// "SearchQuery":"",
		/// "CreateStartDate":"",
		/// "CreateEndDate":"",
		/// "ItemNameOnly":"",
		/// },
		/// "Paging":{
		/// "Key":"",
		/// "PageNumber":1,
		/// "PageSize":10,
		/// },
		/// "Sort":{
		/// "SortBy":"",
		/// "Ascending":false,
		/// },
		/// "TimeoutInSeconds":10
		/// }
		/// </example>
		/// <remarks>
		/// Search for Items matching the criteria of the query parameter
		/// </remarks>
		/// <param name="simpleSearchQuery"></param>
		/// <returns>
		/// AdvancedSearchResults
		/// </returns>
		public IQuery<AdvancedSearchResults> AdvancedSimpleSearch(SimpleSearchQuery simpleSearchQuery)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<AdvancedSearchResults>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("AdvancedSimpleSearch");
			sfApiQuery.Body = simpleSearchQuery;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Advanced Search
		/// </summary>
		/// <example>
		/// {
		/// "Query":{
		/// "AuthIDs":["id1", "id2", ...],
		/// "ItemTypes":["type1", "type2", ...],
		/// "ParentID":["id1", "id2", ...],
		/// "CreatorID":["id1", "id2", ...],
		/// "LuceneQuery":"",
		/// "SearchQuery":"",
		/// "CreateStartDate":"",
		/// "CreateEndDate":"",
		/// "ItemNameOnly":"",
		/// },
		/// "Paging":{
		/// "Key":"",
		/// "PageNumber":1,
		/// "PageSize":10,
		/// },
		/// "Sort":{
		/// "SortBy":"",
		/// "Ascending":false,
		/// },
		/// "TimeoutInSeconds":10
		/// }
		/// </example>
		/// <remarks>
		/// Search for Items matching the criteria of the query parameter
		/// </remarks>
		/// <param name="searchQuery"></param>
		/// <returns>
		/// AdvancedSearchResults
		/// </returns>
		public IQuery<AdvancedSearchResults> AdvancedSearch(SearchQuery searchQuery)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<AdvancedSearchResults>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("AdvancedSimpleSearch");
			sfApiQuery.Body = searchQuery;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

	}
#endif
}
