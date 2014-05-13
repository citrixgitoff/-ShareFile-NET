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
	public class SSOAccountProvider : ODataObject 
	{
		public string LogoutUrl { get; set; }

		public string LoginUrl { get; set; }

		public string IPRestrictions { get; set; }

		public bool? ForceSSO { get; set; }

		public string Certificate { get; set; }

		public Account Account { get; set; }

		public string EntityID { get; set; }

		public string SFEntityID { get; set; }

		public string SPInitatedAuthContext { get; set; }

		public string SPInitatedAuthMethod { get; set; }

		public bool? IsActive { get; set; }

		public string ProviderID { get; set; }

		public bool? DebugMode { get; set; }

		public bool? LenientSignatures { get; set; }

	}
}