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
	public class Redirection : ODataObject 
	{
		public string Method { get; set; }

		public Zone Zone { get; set; }

		public Uri Uri { get; set; }

		public string Body { get; set; }

	}
}