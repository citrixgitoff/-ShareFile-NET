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
using System.IO;
using ShareFile.Api.Models;
using ShareFile.Api.Client;
using ShareFile.Api.Client.Requests;
using ShareFile.Api.Client.Extensions;

namespace ShareFile.Api.Client.Entities
{
    public interface IConfigsEntityInternal : IEntityBase
    {
        
        /// <summary>
        /// Get Configs
        /// </summary>
        /// <returns>
        /// List of GenericConfg
        /// </returns>
        IQuery<ODataFeed<GenericConfig>> Get();
    }

    public class ConfigsEntityInternal : EntityBase, IConfigsEntityInternal
    {
        public ConfigsEntityInternal (IShareFileClient client)
            : base (client, "Configs")
        { }
        
        
        /// <summary>
        /// Get Configs
        /// </summary>
        /// <returns>
        /// List of GenericConfg
        /// </returns>
        public IQuery<ODataFeed<GenericConfig>> Get()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<GenericConfig>>(Client);
		    sfApiQuery.From("Configs");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
    }
}