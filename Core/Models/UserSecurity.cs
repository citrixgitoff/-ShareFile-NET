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

namespace ShareFile.Api.Models 
{
	public class UserSecurity : ODataObject 
	{
		public bool? IsDisabled { get; set; }

		public bool? IsLocked { get; set; }

		public DateTime? LockExpires { get; set; }

		public DateTime? LastWebAppLogin { get; set; }

		public DateTime? LastAnyLogin { get; set; }

		public string UserIPRestrictions { get; set; }

		public DateTime? DisableLoginBefore { get; set; }

		public DateTime? DisableLoginAfter { get; set; }

		public bool? ForcePasswordChange { get; set; }

		public bool? PasswordNeverExpires { get; set; }

		public DateTime? LastPasswordChange { get; set; }

		public string UsernameShort { get; set; }

		public DateTime? LastFailedLogin { get; set; }

		public string LastFailedLoginIP { get; set; }

		public int? FailedLoginCount { get; set; }

	}
}