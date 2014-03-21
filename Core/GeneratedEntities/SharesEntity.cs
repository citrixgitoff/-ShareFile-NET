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
	public class SharesEntity : EntityBase
	{
		public SharesEntity(ShareFileClient client)
			: base (client)
		{

		}

		/// <summary>
		/// Get List of Shares
		/// </summary>
		/// <remarks>
		/// Retrieve all outstanding Shares of the authenticated user
		/// </remarks>
		/// <returns>
		/// List of Shares created by the authenticated user
		/// </returns>
		public IQuery<ODataFeed<Share>> Get()
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Share>>(Client);
			sfApiQuery.From("Shares");
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get Share
		/// </summary>
		/// <remarks>
		/// Retrieve a single Share entity. If the Share allows anonymous access, then this method will not
		/// require authentication.
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// A single Share
		/// </returns>
		public IQuery<Share> Get(string id)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Share>(Client);
			sfApiQuery.From("Shares");
			sfApiQuery.Ids(id);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get Recipients of a Share
		/// </summary>
		/// <remarks>
		/// Retrieve the list of Recipients in the share. Recipients represent the target users of the Share, containing
		/// access information, such as number of times that user downloaded files from the share. Each Recipient is
		/// identified by an Alias, which is an unique ID given to each user - allowing tracking of downloads for
		/// non-authenticated users.
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// A feed of Share Aliases representing recipients of the Share
		/// </returns>
		public IQuery<ODataFeed<ShareAlias>> GetRecipients(string id)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<ShareAlias>>(Client);
			sfApiQuery.From("Shares");
			sfApiQuery.Action("Recipients");
			sfApiQuery.Ids(id);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get Items of a Share
		/// </summary>
		/// <remarks>
		/// Retrieve the list of Items (files and folders) in the Share.
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// A feed of Items of the Share
		/// </returns>
		public IQuery<ODataFeed<Item>> GetItems(string id)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Item>>(Client);
			sfApiQuery.From("Shares");
			sfApiQuery.Action("Items");
			sfApiQuery.Ids(id);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get Recipients of a Share
		/// </summary>
		/// <remarks>
		/// Retrieve a single Item in the Share
		/// </remarks>
		/// <param name="shareid"></param>
		/// <param name="itemid"></param>
		/// <returns>
		/// An item in the Share
		/// </returns>
		public IQuery<Item> GetItems(string shareid, string itemid)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Item>(Client);
			sfApiQuery.From("Shares");
			sfApiQuery.Action("Items");
			sfApiQuery.Ids(shareid);
			sfApiQuery.ActionIds(itemid);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Downloads Share Items
		/// </summary>
		/// <remarks>
		/// Downloads items from the Share. The default action will download all Items in the Share.
		/// If a Share has a single item, the download attachment name
		/// will use the item name. Otherwise, the download will contain a ZIP archive containing all
		/// files and folders in the share, named Files.zip.To download Shares that require authentication, make sure this request is authenticated. To download
		/// shares that require require user information, provide the Name, Email and Company parameters in the URI
		/// query. Anyone can download files from anonymous shares.You can also download individual Items in the Share. Use the Share(id)/Items(id)/Download action. The
		/// item ID must be a top-level item in the Share - i.e., you cannot download or address files contained inside
		/// a shared folder.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="Name"></param>
		/// <param name="Email"></param>
		/// <param name="Company"></param>
		/// <returns>
		/// Redirects the caller (302) to the download address for the share contents.
		/// </returns>
		public IQuery<Stream> Download(string id, string grandparentid, string Name = null, string Email = null, string Company = null)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Stream>(Client);
			sfApiQuery.From("Shares");
			sfApiQuery.Action("Download");
			sfApiQuery.Ids(id);
			sfApiQuery.QueryString("grandparentid", grandparentid);
			sfApiQuery.QueryString("Name", Name);
			sfApiQuery.QueryString("Email", Email);
			sfApiQuery.QueryString("Company", Company);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Create Share
		/// </summary>
		/// <example>
		/// {
		/// "ShareType":"Send",
		/// "Title":"Sample Send Share",
		/// "Items": [ { "Id":"itemid" }, {...} ],
		/// "Recipients":[ { "User": { "Id":"userid" } }, { "User": { "Email": "user@email" } } ],
		/// "ExpirationDate": "2013-07-23",
		/// "RequireLogin": false,
		/// "RequireUserInfo": false,
		/// "MaxDownloads": -1,
		/// "UsesStreamIDs": false
		/// }
		/// {
		/// "ShareType":"Request",
		/// "Title":"Sample Request Share",
		/// "Recipients":[ { "User": { "Id":"userid" } }, { "User": { "Email": "user@email" } } ],
		/// "Parent": { "Id":"folderid" },
		/// "ExpirationDate": "2013-07-23",
		/// "RequireLogin": false,
		/// "RequireUserInfo": false,
		/// "TrackUntilDate": "2013-07-23",
		/// "SendFrequency": -1,
		/// "SendInterval": -1
		/// }
		/// </example>
		/// <remarks>
		/// Creates a new Send or Request Share.
		/// Expiration date:
		/// - if not specified the default is 30 days
		/// - "9999-12-31" disables share expiration.
		/// To use stream IDs as item IDs UsesStreamIDs needs to be set to true, and all the IDs in Items need to be specified
		/// as stream IDs.
		/// </remarks>
		/// <param name="share"></param>
		/// <param name="notify"></param>
		/// <returns>
		/// The new Share
		/// </returns>
		public IQuery<Share> Create(Share share, bool notify = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Share>(Client);
			sfApiQuery.From("Shares");
			sfApiQuery.QueryString("notify", notify);
			sfApiQuery.Body = share;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Modify Share
		/// </summary>
		/// <example>
		/// {
		/// "Title": "New Title",
		/// "ExpirationDate": "2013-07-23",
		/// "RequireLogin": false,
		/// "Items": [ { "Id":"itemid" }, {...} ],
		/// }
		/// </example>
		/// <remarks>
		/// Modifies an existing Share. If Items are specified they are added to the share.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="share"></param>
		/// <returns>
		/// The modified Share
		/// </returns>
		public IQuery<Share> Update(string id, Share share)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Share>(Client);
			sfApiQuery.From("Shares");
			sfApiQuery.Ids(id);
			sfApiQuery.Body = share;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Delete Share
		/// </summary>
		/// <remarks>
		/// Removes an existing Share
		/// </remarks>
		/// <param name="id"></param>
		public IQuery Delete(string id)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("Shares");
			sfApiQuery.Ids(id);
			sfApiQuery.HttpMethod = "DELETE";
			return sfApiQuery;
		}

		/// <summary>
		/// Create Share Alias
		/// </summary>
		/// <remarks>
		/// Creates a share alias for the specified share ID and user email. If a user with the given email address does not
		/// exist it is created first.
		/// For shares requiring login an activation email is sent to the created user. If 'notify' is enabled, the user activation is
		/// included in the share notification email.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="email"></param>
		/// <param name="notify"></param>
		/// <returns>
		/// Share with the AliasID property set to the created alias ID
		/// </returns>
		public IQuery<Share> CreateAlias(string id, string email, bool notify = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Share>(Client);
			sfApiQuery.From("Shares");
			sfApiQuery.Action("Alias");
			sfApiQuery.Ids(id);
			sfApiQuery.QueryString("email", email);
			sfApiQuery.QueryString("notify", notify);
			sfApiQuery.HttpMethod = "DELETE";
			return sfApiQuery;
		}

		/// <summary>
		/// Deliver Send a File Email
		/// </summary>
		/// <remarks>
		/// Sends an Email to the specified list of addresses, containing a link to the specified Items.
		/// The default number of expiration days is 30. -1 disables share expiration.
		/// </remarks>
		/// <param name="parameters"></param>
		public IQuery CreateSend(ShareSendParams parameters)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("Shares");
			sfApiQuery.Action("Send");
			sfApiQuery.Body = parameters;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Deliver Request a File Email
		/// </summary>
		/// <remarks>
		/// Sends an Email to the specified list of addresses, containing a link to files upload.
		/// The default number of expiration days is 30. -1 disables share expiration.
		/// </remarks>
		/// <param name="parameters"></param>
		public IQuery CreateRequest(ShareRequestParams parameters)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("Shares");
			sfApiQuery.Action("Request");
			sfApiQuery.Body = parameters;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

	}
}
