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
	public class Zone : Principal 
	{
		public string Secret { get; set; }

		public SafeEnum<ZoneType> ZoneType { get; set; }

		public Account Account { get; set; }

		public int? HeartBeatTolerance { get; set; }

		public int? PingBackInterval { get; set; }

		public string Version { get; set; }

		public SafeEnum<ZoneService> ZoneServices { get; set; }

		public bool? IsHIPAAZone { get; set; }

		public IEnumerable<StorageCenter> StorageCenters { get; set; }

		public IEnumerable<Metadata> Metadata { get; set; }

	}
}