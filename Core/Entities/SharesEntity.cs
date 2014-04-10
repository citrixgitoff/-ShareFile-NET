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

	public interface ISharesEntity : IEntityBase
	{
		/// <summary>
		/// Get List of Shares
		/// </summary>
		/// <remarks>
		/// Retrieve all outstanding Shares of the authenticated user
		/// </remarks>
		/// <returns>
		/// List of Shares created by the authenticated user
		/// </returns>
		IQuery<ODataFeed<Share>> Get();
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
		IQuery<Share> Get(string id);
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
		IQuery<ODataFeed<ShareAlias>> GetRecipients(string id);
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
		IQuery<ODataFeed<Item>> GetItems(string id);
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
		IQuery<Item> GetItems(string shareid, string itemid);
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
		/// <param name="shareId"></param>
		/// <param name="Name"></param>
		/// <param name="Email"></param>
		/// <param name="Company"></param>
		/// <param name="redirect"></param>
		/// <returns>
		/// Redirects the caller (302) to the download address for the share contents.
		/// </returns>
		IQuery<Stream> Download(string shareId, string id, string Name = null, string Email = null, string Company = null, bool redirect = true);
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
		IQuery<Share> Create(Share share, bool notify = false);
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
		IQuery<Share> Update(string id, Share share);
		/// <summary>
		/// Delete Share
		/// </summary>
		/// <remarks>
		/// Removes an existing Share
		/// </remarks>
		/// <param name="id"></param>
		IQuery Delete(string id);
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
		IQuery<Share> CreateAlias(string id, string email, bool notify = false);
		/// <summary>
		/// Deliver Send a File Email
		/// </summary>
		/// <remarks>
		/// Sends an Email to the specified list of addresses, containing a link to the specified Items.
		/// The default number of expiration days is 30. -1 disables share expiration.
		/// </remarks>
		/// <param name="parameters"></param>
		IQuery CreateSend(ShareSendParams parameters);
		/// <summary>
		/// Deliver Request a File Email
		/// </summary>
		/// <remarks>
		/// Sends an Email to the specified list of addresses, containing a link to files upload.
		/// The default number of expiration days is 30. -1 disables share expiration.
		/// </remarks>
		/// <param name="parameters"></param>
		IQuery CreateRequest(ShareRequestParams parameters);
		/// <summary>
		/// Upload File to Request Share
		/// </summary>
		/// <remarks>
		/// Prepares the links for uploading files to the target Share.
		/// This method returns an Upload Specification object. The fields are
		/// populated based on the upload method, provider, and resume parameters passed to the
		/// upload call.
		/// The Method determines how the URLs must be called.
		/// 
		/// Standard uploads use a single HTTP POST message to the ChunkUri address provided in
		/// the response. All other fields will be empty. Standard uploads do not support Resume.
		/// 
		/// Streamed uploads use multiple HTTP POST calls to the ChunkUri address. The client must
		/// append the parameters index, offset and hash to the end of the ChunkUri address. Index
		/// is a sequential number representing the data block (zero-based); Offset represents the
		/// byte offset for the block; and hash contains the MD5 hash of the block. The last HTTP
		/// POST must also contain finish=true parameter.
		/// 
		/// Threaded uploads use multiple HTTP POST calls to ChunkUri, and can have a number of
		/// threads issuing blocks in parallel. Clients must append index, offset and hash to
		/// the end of ChunkUri, as explained in Streamed. After all chunks were sent, the client
		/// must call the FinishUri provided in this spec.
		/// 
		/// For all uploaders, the contents of the POST Body can either be "raw", if the "Raw" parameter
		/// was provided to the Uploader, or use MIME multi-part form encoding otherwise. Raw uploads
		/// simply put the block content in the POST body - Content-Length specifies the size. Multi-part
		/// form encoding has to pass the File as a Form parameter named "File1".
		/// 
		/// For streamed and threaded, if Resume options were provided to the Upload call, then the
		/// fields IsResume, ResumeIndex, ResumeOffset and ResumeFileHash MAY be populated. If they are,
		/// it indicates that the server has identified a partial upload with that specification, and is
		/// ready to resume on the provided parameters. The clients can then verify the ResumeFileHash to
		/// ensure the file has not been modified; and continue issuing ChunkUri calls from the ResumeIndex
		/// ResumeOffset parameters. If the client decides to restart, it should simply ignore the resume
		/// parameters and send the blocks from Index 0.
		/// 
		/// For all uploaders: the result code for the HTTP POST calls to Chunk and Finish Uri can either
		/// be a 401 - indicating authentication is required; 4xx/5xx indicating some kind of error; or
		/// 200 with a Content Body of format 'ERROR:message'. Successful calls will return either a 200
		/// response with no Body, or with Body of format 'OK'.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="method"></param>
		/// <param name="raw"></param>
		/// <param name="fileName"></param>
		/// <param name="fileSize"></param>
		/// <param name="batchId"></param>
		/// <param name="batchLast"></param>
		/// <param name="canResume"></param>
		/// <param name="startOver"></param>
		/// <param name="unzip"></param>
		/// <param name="tool"></param>
		/// <param name="overwrite"></param>
		/// <param name="title"></param>
		/// <param name="details"></param>
		/// <param name="isSend"></param>
		/// <param name="sendGuid"></param>
		/// <param name="opid"></param>
		/// <param name="threadCount"></param>
		/// <param name="responseFormat"></param>
		/// <param name="notify"></param>
		/// <returns>
		/// an Upload Specification element, containing the links for uploading, and the parameters for resume.
		/// The caller must know the protocol for sending the prepare, chunk and finish URLs returned in the spec; as well as
		/// negotiate the resume upload.
		/// </returns>
		IQuery<UploadSpecification> Upload(string id, UploadMethod method = UploadMethod.Standard, bool raw = false, string fileName = null, long fileSize = 0, string batchId = null, bool batchLast = false, bool canResume = false, bool startOver = false, bool unzip = false, string tool = "apiv3", bool overwrite = false, string title = null, string details = null, bool isSend = false, string sendGuid = null, string opid = null, int threadCount = 4, string responseFormat = "json", bool notify = false, DateTime? clientCreatedDateUTC = null, DateTime? clientModifiedDateUTC = null, int? expirationDays = null);
	}

	public class SharesEntity : EntityBase, ISharesEntity
	{
		public SharesEntity(IShareFileClient client)
			: base (client, "Shares")
			
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
		/// <param name="shareId"></param>
		/// <param name="Name"></param>
		/// <param name="Email"></param>
		/// <param name="Company"></param>
		/// <param name="redirect"></param>
		/// <returns>
		/// Redirects the caller (302) to the download address for the share contents.
		/// </returns>
		public IQuery<Stream> Download(string shareId, string id, string Name = null, string Email = null, string Company = null, bool redirect = true)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Stream>(Client);
			sfApiQuery.From("Shares");
			sfApiQuery.Action("Download");
			sfApiQuery.Ids(shareId);
			sfApiQuery.QueryString("id", id);
			sfApiQuery.QueryString("Name", Name);
			sfApiQuery.QueryString("Email", Email);
			sfApiQuery.QueryString("Company", Company);
			sfApiQuery.QueryString("redirect", redirect);
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

		/// <summary>
		/// Upload File to Request Share
		/// </summary>
		/// <remarks>
		/// Prepares the links for uploading files to the target Share.
		/// This method returns an Upload Specification object. The fields are
		/// populated based on the upload method, provider, and resume parameters passed to the
		/// upload call.
		/// The Method determines how the URLs must be called.
		/// 
		/// Standard uploads use a single HTTP POST message to the ChunkUri address provided in
		/// the response. All other fields will be empty. Standard uploads do not support Resume.
		/// 
		/// Streamed uploads use multiple HTTP POST calls to the ChunkUri address. The client must
		/// append the parameters index, offset and hash to the end of the ChunkUri address. Index
		/// is a sequential number representing the data block (zero-based); Offset represents the
		/// byte offset for the block; and hash contains the MD5 hash of the block. The last HTTP
		/// POST must also contain finish=true parameter.
		/// 
		/// Threaded uploads use multiple HTTP POST calls to ChunkUri, and can have a number of
		/// threads issuing blocks in parallel. Clients must append index, offset and hash to
		/// the end of ChunkUri, as explained in Streamed. After all chunks were sent, the client
		/// must call the FinishUri provided in this spec.
		/// 
		/// For all uploaders, the contents of the POST Body can either be "raw", if the "Raw" parameter
		/// was provided to the Uploader, or use MIME multi-part form encoding otherwise. Raw uploads
		/// simply put the block content in the POST body - Content-Length specifies the size. Multi-part
		/// form encoding has to pass the File as a Form parameter named "File1".
		/// 
		/// For streamed and threaded, if Resume options were provided to the Upload call, then the
		/// fields IsResume, ResumeIndex, ResumeOffset and ResumeFileHash MAY be populated. If they are,
		/// it indicates that the server has identified a partial upload with that specification, and is
		/// ready to resume on the provided parameters. The clients can then verify the ResumeFileHash to
		/// ensure the file has not been modified; and continue issuing ChunkUri calls from the ResumeIndex
		/// ResumeOffset parameters. If the client decides to restart, it should simply ignore the resume
		/// parameters and send the blocks from Index 0.
		/// 
		/// For all uploaders: the result code for the HTTP POST calls to Chunk and Finish Uri can either
		/// be a 401 - indicating authentication is required; 4xx/5xx indicating some kind of error; or
		/// 200 with a Content Body of format 'ERROR:message'. Successful calls will return either a 200
		/// response with no Body, or with Body of format 'OK'.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="method"></param>
		/// <param name="raw"></param>
		/// <param name="fileName"></param>
		/// <param name="fileSize"></param>
		/// <param name="batchId"></param>
		/// <param name="batchLast"></param>
		/// <param name="canResume"></param>
		/// <param name="startOver"></param>
		/// <param name="unzip"></param>
		/// <param name="tool"></param>
		/// <param name="overwrite"></param>
		/// <param name="title"></param>
		/// <param name="details"></param>
		/// <param name="isSend"></param>
		/// <param name="sendGuid"></param>
		/// <param name="opid"></param>
		/// <param name="threadCount"></param>
		/// <param name="responseFormat"></param>
		/// <param name="notify"></param>
		/// <returns>
		/// an Upload Specification element, containing the links for uploading, and the parameters for resume.
		/// The caller must know the protocol for sending the prepare, chunk and finish URLs returned in the spec; as well as
		/// negotiate the resume upload.
		/// </returns>
		public IQuery<UploadSpecification> Upload(string id, UploadMethod method = UploadMethod.Standard, bool raw = false, string fileName = null, long fileSize = 0, string batchId = null, bool batchLast = false, bool canResume = false, bool startOver = false, bool unzip = false, string tool = "apiv3", bool overwrite = false, string title = null, string details = null, bool isSend = false, string sendGuid = null, string opid = null, int threadCount = 4, string responseFormat = "json", bool notify = false, DateTime? clientCreatedDateUTC = null, DateTime? clientModifiedDateUTC = null, int? expirationDays = null)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<UploadSpecification>(Client);
			sfApiQuery.From("Shares");
			sfApiQuery.Action("Upload");
			sfApiQuery.Ids(id);
			sfApiQuery.QueryString("method", method);
			sfApiQuery.QueryString("raw", raw);
			sfApiQuery.QueryString("fileName", fileName);
			sfApiQuery.QueryString("fileSize", fileSize);
			sfApiQuery.QueryString("batchId", batchId);
			sfApiQuery.QueryString("batchLast", batchLast);
			sfApiQuery.QueryString("canResume", canResume);
			sfApiQuery.QueryString("startOver", startOver);
			sfApiQuery.QueryString("unzip", unzip);
			sfApiQuery.QueryString("tool", tool);
			sfApiQuery.QueryString("overwrite", overwrite);
			sfApiQuery.QueryString("title", title);
			sfApiQuery.QueryString("details", details);
			sfApiQuery.QueryString("isSend", isSend);
			sfApiQuery.QueryString("sendGuid", sendGuid);
			sfApiQuery.QueryString("opid", opid);
			sfApiQuery.QueryString("threadCount", threadCount);
			sfApiQuery.QueryString("responseFormat", responseFormat);
			sfApiQuery.QueryString("notify", notify);
			sfApiQuery.QueryString("clientCreatedDateUTC", clientCreatedDateUTC);
			sfApiQuery.QueryString("clientModifiedDateUTC", clientModifiedDateUTC);
			sfApiQuery.QueryString("expirationDays", expirationDays);
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

	}
}
