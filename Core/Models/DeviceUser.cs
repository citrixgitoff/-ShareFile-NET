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
	public class DeviceUser : ODataObject 
	{

		public Account Account { get; set; }

		public User User { get; set; }

		public Device Device { get; set; }

		public bool? IsOwner { get; set; }

		public string FriendlyName { get; set; }

		public bool? Wipe { get; set; }

		public bool? IsLocked { get; set; }

		public bool? IsDeleted { get; set; }

		public DateTime? Created { get; set; }

		public DateTime? LastLogin { get; set; }

		public DateTime? LastWipe { get; set; }

		public string WipeToken { get; set; }

		public string WipeInitiator { get; set; }

		public SafeEnum<DeviceActionInitiatorRole> WipeInitiatorRole { get; set; }

		public string LockInitiator { get; set; }

		public SafeEnum<DeviceActionInitiatorRole> LockInitiatorRole { get; set; }

		public SafeEnum<SFTool> DeviceType { get; set; }

		public string LastErrorMessage { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as DeviceUser;
			if(typedSource != null)
			{
				Account = typedSource.Account;
				User = typedSource.User;
				Device = typedSource.Device;
				IsOwner = typedSource.IsOwner;
				FriendlyName = typedSource.FriendlyName;
				Wipe = typedSource.Wipe;
				IsLocked = typedSource.IsLocked;
				IsDeleted = typedSource.IsDeleted;
				Created = typedSource.Created;
				LastLogin = typedSource.LastLogin;
				LastWipe = typedSource.LastWipe;
				WipeToken = typedSource.WipeToken;
				WipeInitiator = typedSource.WipeInitiator;
				WipeInitiatorRole = typedSource.WipeInitiatorRole;
				LockInitiator = typedSource.LockInitiator;
				LockInitiatorRole = typedSource.LockInitiatorRole;
				DeviceType = typedSource.DeviceType;
				LastErrorMessage = typedSource.LastErrorMessage;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("Account", out token) && token.Type != JTokenType.Null)
				{
					Account = (Account)serializer.Deserialize(token.CreateReader(), typeof(Account));
				}
				if(source.TryGetProperty("User", out token) && token.Type != JTokenType.Null)
				{
					User = (User)serializer.Deserialize(token.CreateReader(), typeof(User));
				}
				if(source.TryGetProperty("Device", out token) && token.Type != JTokenType.Null)
				{
					Device = (Device)serializer.Deserialize(token.CreateReader(), typeof(Device));
				}
				if(source.TryGetProperty("IsOwner", out token) && token.Type != JTokenType.Null)
				{
					IsOwner = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("FriendlyName", out token) && token.Type != JTokenType.Null)
				{
					FriendlyName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Wipe", out token) && token.Type != JTokenType.Null)
				{
					Wipe = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("IsLocked", out token) && token.Type != JTokenType.Null)
				{
					IsLocked = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("IsDeleted", out token) && token.Type != JTokenType.Null)
				{
					IsDeleted = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("Created", out token) && token.Type != JTokenType.Null)
				{
					Created = (DateTime?)serializer.Deserialize(token.CreateReader(), typeof(DateTime?));
				}
				if(source.TryGetProperty("LastLogin", out token) && token.Type != JTokenType.Null)
				{
					LastLogin = (DateTime?)serializer.Deserialize(token.CreateReader(), typeof(DateTime?));
				}
				if(source.TryGetProperty("LastWipe", out token) && token.Type != JTokenType.Null)
				{
					LastWipe = (DateTime?)serializer.Deserialize(token.CreateReader(), typeof(DateTime?));
				}
				if(source.TryGetProperty("WipeToken", out token) && token.Type != JTokenType.Null)
				{
					WipeToken = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("WipeInitiator", out token) && token.Type != JTokenType.Null)
				{
					WipeInitiator = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("WipeInitiatorRole", out token) && token.Type != JTokenType.Null)
				{
					WipeInitiatorRole = (SafeEnum<DeviceActionInitiatorRole>)serializer.Deserialize(token.CreateReader(), typeof(SafeEnum<DeviceActionInitiatorRole>));
				}
				if(source.TryGetProperty("LockInitiator", out token) && token.Type != JTokenType.Null)
				{
					LockInitiator = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("LockInitiatorRole", out token) && token.Type != JTokenType.Null)
				{
					LockInitiatorRole = (SafeEnum<DeviceActionInitiatorRole>)serializer.Deserialize(token.CreateReader(), typeof(SafeEnum<DeviceActionInitiatorRole>));
				}
				if(source.TryGetProperty("DeviceType", out token) && token.Type != JTokenType.Null)
				{
					DeviceType = (SafeEnum<SFTool>)serializer.Deserialize(token.CreateReader(), typeof(SafeEnum<SFTool>));
				}
				if(source.TryGetProperty("LastErrorMessage", out token) && token.Type != JTokenType.Null)
				{
					LastErrorMessage = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
			}
		}
	}
}