// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2015 Citrix ShareFile. All rights reserved.
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
    public interface IEncryptedEmailsEntityInternal : IEntityBase
    {
        IQuery<EncryptedEmail> Get(Uri url, string firstName = null, string lastName = null, string email = null, string company = null);
        IQuery<ODataFeed<EncryptedEmail>> Thread(Uri url, string firstName = null, string lastName = null, string email = null, string company = null);
        IQuery<ODataFeed<EncryptedEmail>> Received();
        IQuery<EncryptedEmail> Reply(Uri url, EncryptedEmailReplyParams encryptedEmailParams);
        IQuery<EncryptedEmail> ReplyAll(Uri url, EncryptedEmailParams encryptedEmailParams);
        IQuery<EncryptedEmail> Create(EncryptedEmailCreateParams encryptedEmailParams);
        IQuery Send(Uri url, EncryptedEmailSendParams encryptedEmailSendParams);
        IQuery Complete(Uri url, EncryptedEmailSendParams encryptedEmailSendParams);
        IQuery<Stream> Message(Uri url, string aliasId = null, bool redirect = true);
        IQuery Delete(Uri url);
        IQuery<UploadSpecification> Upload(Uri url, UploadMethod method = UploadMethod.Standard, bool raw = false, string fileName = null, long fileSize = 0, string batchId = null, bool batchLast = false, bool canResume = false, bool startOver = false, bool unzip = false, string tool = "apiv3", bool overwrite = false, string title = null, string details = null, bool isSend = false, string sendGuid = null, string opid = null, int threadCount = 4, string responseFormat = "json", bool notify = false, DateTime? clientCreatedDateUTC = null, DateTime? clientModifiedDateUTC = null, int? expirationDays = null);
        IQuery<UploadSpecification> Upload2(Uri url, UploadRequestParams uploadParams, int? expirationDays = null);
        IQuery<EncryptedEmail> GetEncryptedEmailByShare(Uri url);
    }

    public class EncryptedEmailsEntityInternal : EntityBase, IEncryptedEmailsEntityInternal
    {
        public EncryptedEmailsEntityInternal (IShareFileClient client)
            : base (client, "EncryptedEmails")
        { }
        
        public IQuery<EncryptedEmail> Get(Uri url, string firstName = null, string lastName = null, string email = null, string company = null)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<EncryptedEmail>(Client);
            sfApiQuery.Uri(url);
            sfApiQuery.QueryString("firstName", firstName);
            sfApiQuery.QueryString("lastName", lastName);
            sfApiQuery.QueryString("email", email);
            sfApiQuery.QueryString("company", company);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        public IQuery<ODataFeed<EncryptedEmail>> Thread(Uri url, string firstName = null, string lastName = null, string email = null, string company = null)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<EncryptedEmail>>(Client);
		    sfApiQuery.Action("Thread");
            sfApiQuery.Uri(url);
            sfApiQuery.QueryString("firstName", firstName);
            sfApiQuery.QueryString("lastName", lastName);
            sfApiQuery.QueryString("email", email);
            sfApiQuery.QueryString("company", company);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        public IQuery<ODataFeed<EncryptedEmail>> Received()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<EncryptedEmail>>(Client);
		    sfApiQuery.From("EncryptedEmails");
		    sfApiQuery.Action("Received");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        public IQuery<EncryptedEmail> Reply(Uri url, EncryptedEmailReplyParams encryptedEmailParams)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<EncryptedEmail>(Client);
		    sfApiQuery.Action("Reply");
            sfApiQuery.Uri(url);
            sfApiQuery.Body = encryptedEmailParams;
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        public IQuery<EncryptedEmail> ReplyAll(Uri url, EncryptedEmailParams encryptedEmailParams)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<EncryptedEmail>(Client);
		    sfApiQuery.Action("ReplyAll");
            sfApiQuery.Uri(url);
            sfApiQuery.Body = encryptedEmailParams;
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        public IQuery<EncryptedEmail> Create(EncryptedEmailCreateParams encryptedEmailParams)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<EncryptedEmail>(Client);
		    sfApiQuery.From("EncryptedEmails");
            sfApiQuery.Body = encryptedEmailParams;
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        public IQuery Send(Uri url, EncryptedEmailSendParams encryptedEmailSendParams)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
		    sfApiQuery.Action("Send");
            sfApiQuery.Uri(url);
            sfApiQuery.Body = encryptedEmailSendParams;
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        public IQuery Complete(Uri url, EncryptedEmailSendParams encryptedEmailSendParams)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
		    sfApiQuery.Action("Complete");
            sfApiQuery.Uri(url);
            sfApiQuery.Body = encryptedEmailSendParams;
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        public IQuery<Stream> Message(Uri url, string aliasId = null, bool redirect = true)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Stream>(Client);
		    sfApiQuery.Action("Message");
            sfApiQuery.Uri(url);
            sfApiQuery.QueryString("aliasId", aliasId);
            sfApiQuery.QueryString("redirect", redirect);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        public IQuery Delete(Uri url)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
            sfApiQuery.Uri(url);
            sfApiQuery.HttpMethod = "DELETE";	
		    return sfApiQuery;
        }
        public IQuery<UploadSpecification> Upload(Uri url, UploadMethod method = UploadMethod.Standard, bool raw = false, string fileName = null, long fileSize = 0, string batchId = null, bool batchLast = false, bool canResume = false, bool startOver = false, bool unzip = false, string tool = "apiv3", bool overwrite = false, string title = null, string details = null, bool isSend = false, string sendGuid = null, string opid = null, int threadCount = 4, string responseFormat = "json", bool notify = false, DateTime? clientCreatedDateUTC = null, DateTime? clientModifiedDateUTC = null, int? expirationDays = null)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<UploadSpecification>(Client);
		    sfApiQuery.Action("Upload");
            sfApiQuery.Uri(url);
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
        public IQuery<UploadSpecification> Upload2(Uri url, UploadRequestParams uploadParams, int? expirationDays = null)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<UploadSpecification>(Client);
		    sfApiQuery.Action("Upload2");
            sfApiQuery.Uri(url);
            sfApiQuery.QueryString("expirationDays", expirationDays);
            sfApiQuery.Body = uploadParams;
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        public IQuery<EncryptedEmail> GetEncryptedEmailByShare(Uri url)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<EncryptedEmail>(Client);
		    sfApiQuery.Action("EncryptedEmail");
            sfApiQuery.Uri(url);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
    }
}