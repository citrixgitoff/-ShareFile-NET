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
#if ShareFile
	public class EncryptedEmailCreateParams : EncrypedEmailReplyParams 
	{

		public bool? RequireUserInfo { get; set; }

		public bool? RequireLogin { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as EncryptedEmailCreateParams;
			if(typedSource != null)
			{
				RequireUserInfo = typedSource.RequireUserInfo;
				RequireLogin = typedSource.RequireLogin;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("RequireUserInfo", out token) && token.Type != JTokenType.Null)
				{
					RequireUserInfo = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("RequireLogin", out token) && token.Type != JTokenType.Null)
				{
					RequireLogin = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
			}
		}
	}
#endif
}