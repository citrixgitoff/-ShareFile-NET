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
	public class EncryptedEmailParams : ODataObject 
	{

		public IEnumerable<Principal> ToRecipients { get; set; }

		public IEnumerable<Principal> CcRecipients { get; set; }

		public IEnumerable<Principal> BccRecipients { get; set; }

		public string Subject { get; set; }

		public int? ExpirationDays { get; set; }

		public bool? RequireUserInfo { get; set; }

		public bool? RequireLogin { get; set; }

		public bool? SendSeparateActivation { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as EncryptedEmailParams;
			if(typedSource != null)
			{
				ToRecipients = typedSource.ToRecipients;
				CcRecipients = typedSource.CcRecipients;
				BccRecipients = typedSource.BccRecipients;
				Subject = typedSource.Subject;
				ExpirationDays = typedSource.ExpirationDays;
				RequireUserInfo = typedSource.RequireUserInfo;
				RequireLogin = typedSource.RequireLogin;
				SendSeparateActivation = typedSource.SendSeparateActivation;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("ToRecipients", out token) && token.Type != JTokenType.Null)
				{
					ToRecipients = (IEnumerable<Principal>)serializer.Deserialize(token.CreateReader(), typeof(IEnumerable<Principal>));
				}
				if(source.TryGetProperty("CcRecipients", out token) && token.Type != JTokenType.Null)
				{
					CcRecipients = (IEnumerable<Principal>)serializer.Deserialize(token.CreateReader(), typeof(IEnumerable<Principal>));
				}
				if(source.TryGetProperty("BccRecipients", out token) && token.Type != JTokenType.Null)
				{
					BccRecipients = (IEnumerable<Principal>)serializer.Deserialize(token.CreateReader(), typeof(IEnumerable<Principal>));
				}
				if(source.TryGetProperty("Subject", out token) && token.Type != JTokenType.Null)
				{
					Subject = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("ExpirationDays", out token) && token.Type != JTokenType.Null)
				{
					ExpirationDays = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("RequireUserInfo", out token) && token.Type != JTokenType.Null)
				{
					RequireUserInfo = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("RequireLogin", out token) && token.Type != JTokenType.Null)
				{
					RequireLogin = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("SendSeparateActivation", out token) && token.Type != JTokenType.Null)
				{
					SendSeparateActivation = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
			}
		}
	}
#endif
}