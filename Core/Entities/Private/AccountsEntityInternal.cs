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
	public class AccountsEntityInternal : AccountsEntity
	{
		public AccountsEntityInternal(IShareFileClient client)
			: base (client)
			
		{

		}

		/// <summary>
		/// Get Outlook Information
		/// </summary>
		/// <returns>
		/// OutlookInformation
		/// </returns>
		public IQuery<OutlookInformation> GetOutlookInformation()
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<OutlookInformation>(Client);
			sfApiQuery.From("Accounts");
			sfApiQuery.Action("OutlookInformation");
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

	}
#endif
}
