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
	public class EncryptedEmailRecipient : ODataObject 
	{

		public User User { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Company { get; set; }

		public string Email { get; set; }

		public string FullName { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as EncryptedEmailRecipient;
			if(typedSource != null)
			{
				User = typedSource.User;
				FirstName = typedSource.FirstName;
				LastName = typedSource.LastName;
				Company = typedSource.Company;
				Email = typedSource.Email;
				FullName = typedSource.FullName;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("User", out token) && token.Type != JTokenType.Null)
				{
					User = (User)serializer.Deserialize(token.CreateReader(), typeof(User));
				}
				if(source.TryGetProperty("FirstName", out token) && token.Type != JTokenType.Null)
				{
					FirstName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("LastName", out token) && token.Type != JTokenType.Null)
				{
					LastName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Company", out token) && token.Type != JTokenType.Null)
				{
					Company = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Email", out token) && token.Type != JTokenType.Null)
				{
					Email = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("FullName", out token) && token.Type != JTokenType.Null)
				{
					FullName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
			}
		}
	}
#endif
}