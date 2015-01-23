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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;

namespace ShareFile.Api.Models 
{
	public class ConnectorGroup : Folder 
	{

		/// <summary>
		/// Zones that contain this Connector type
		/// </summary>
		public IEnumerable<ConnectorGroupZone> Zones { get; set; }

		/// <summary>
		/// Provider identifier for this group. This is the 1st element in a ShareFile URL,
		/// for example - cifs for Network Shares connectors. Items in Network Share connectors
		/// will always have the url /cifs/vN/...
		/// </summary>
		public string Provider { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as ConnectorGroup;
			if(typedSource != null)
			{
				Zones = typedSource.Zones;
				Provider = typedSource.Provider;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("Zones", out token) && token.Type != JTokenType.Null)
				{
					Zones = (IEnumerable<ConnectorGroupZone>)serializer.Deserialize(token.CreateReader(), typeof(IEnumerable<ConnectorGroupZone>));
				}
				if(source.TryGetProperty("Provider", out token) && token.Type != JTokenType.Null)
				{
					Provider = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
			}
		}
	}
}