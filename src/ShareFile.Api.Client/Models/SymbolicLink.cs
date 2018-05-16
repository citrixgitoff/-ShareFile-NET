// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2018 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Exceptions;

namespace ShareFile.Api.Client.Models 
{
	/// <summary>
	/// Symbolic Links represent a remote folder in a ShareFile file system structure. A
	/// Symbolic Link uses the URL field to point to another provider. Client must query
	/// the url location to retrieve Item information. In some cases, the Symbolic Link
	/// fields may be populated in the remote provider - for example, Storage Zone Connectors
	/// populate the "Name" field in the ShareFile provider. In this case, clients can use
	/// the available fields without the remote call to the provider.
	/// </summary>
	public class SymbolicLink : Folder 
	{
		public Uri Link { get; set; }
		public ConnectorGroup ConnectorGroup { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as SymbolicLink;
			if(typedSource != null)
			{
				Link = typedSource.Link;
				ConnectorGroup = typedSource.ConnectorGroup;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("Link", out token) && token.Type != JTokenType.Null)
				{
					Link = (Uri)serializer.Deserialize(token.CreateReader(), typeof(Uri));
				}
				if(source.TryGetProperty("ConnectorGroup", out token) && token.Type != JTokenType.Null)
				{
					ConnectorGroup = (ConnectorGroup)serializer.Deserialize(token.CreateReader(), typeof(ConnectorGroup));
				}
			}
		}
	}
}