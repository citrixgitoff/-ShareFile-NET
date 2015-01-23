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
	public class ShareAlias : ODataObject 
	{

		public User User { get; set; }

		public Share Share { get; set; }

		public string Email { get; set; }

		public int? Downloads { get; set; }

		public bool? IsConsumed { get; set; }

		public bool? IsArchived { get; set; }

		public bool? IsRead { get; set; }

		/// <summary>
		/// Uri to access the share through the Web portal
		/// </summary>
		public Uri Uri { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as ShareAlias;
			if(typedSource != null)
			{
				User = typedSource.User;
				Share = typedSource.Share;
				Email = typedSource.Email;
				Downloads = typedSource.Downloads;
				IsConsumed = typedSource.IsConsumed;
				IsArchived = typedSource.IsArchived;
				IsRead = typedSource.IsRead;
				Uri = typedSource.Uri;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("User", out token) && token.Type != JTokenType.Null)
				{
					User = (User)serializer.Deserialize(token.CreateReader(), typeof(User));
				}
				if(source.TryGetProperty("Share", out token) && token.Type != JTokenType.Null)
				{
					Share = (Share)serializer.Deserialize(token.CreateReader(), typeof(Share));
				}
				if(source.TryGetProperty("Email", out token) && token.Type != JTokenType.Null)
				{
					Email = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Downloads", out token) && token.Type != JTokenType.Null)
				{
					Downloads = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("IsConsumed", out token) && token.Type != JTokenType.Null)
				{
					IsConsumed = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("IsArchived", out token) && token.Type != JTokenType.Null)
				{
					IsArchived = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("IsRead", out token) && token.Type != JTokenType.Null)
				{
					IsRead = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("Uri", out token) && token.Type != JTokenType.Null)
				{
					Uri = (Uri)serializer.Deserialize(token.CreateReader(), typeof(Uri));
				}
			}
		}
	}
}