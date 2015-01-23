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
#if ShareFile
	public class TrialPeriod : ODataObject 
	{

		public string ProductID { get; set; }

		public string AppStore { get; set; }

		public int DurationInDays { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as TrialPeriod;
			if(typedSource != null)
			{
				ProductID = typedSource.ProductID;
				AppStore = typedSource.AppStore;
				DurationInDays = typedSource.DurationInDays;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("ProductID", out token) && token.Type != JTokenType.Null)
				{
					ProductID = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("AppStore", out token) && token.Type != JTokenType.Null)
				{
					AppStore = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("DurationInDays", out token) && token.Type != JTokenType.Null)
				{
					DurationInDays = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
			}
		}
	}
#endif
}