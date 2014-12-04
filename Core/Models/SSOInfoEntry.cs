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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;

namespace ShareFile.Api.Models 
{
	public class SSOInfoEntry : ODataObject 
	{

		public string Key { get; set; }

		public string Value { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as SSOInfoEntry;
			if(typedSource != null)
			{
				Key = typedSource.Key;
				Value = typedSource.Value;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("Key", out token) && token.Type != JTokenType.Null)
				{
					Key = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Value", out token) && token.Type != JTokenType.Null)
				{
					Value = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
			}
		}
	}
}