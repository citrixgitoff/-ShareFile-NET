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
	public class UserConfirmationSettings : ODataObject 
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Company { get; set; }

		public string Password { get; set; }

		public string DayLightName { get; set; }

		public string UTCOffset { get; set; }

		public string DateFormat { get; set; }

		public string TimeFormat { get; set; }

		public int? EmailInterval { get; set; }

	}
}