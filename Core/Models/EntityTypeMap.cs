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

namespace ShareFile.Api.Models
{
	public static class EntityTypeMap
	{
		private static Dictionary<string, Type> _entityTypeMap;

		public static Dictionary<string, Type> GetEntityTypeMap()
		{
			if(_entityTypeMap == null)
			{
				_entityTypeMap = new Dictionary<string, Type>();

                _entityTypeMap.Add("AccessControlsBulkParams", typeof(AccessControlsBulkParams));
                _entityTypeMap.Add("AccessControlsBulkParamss", typeof(AccessControlsBulkParams));
                _entityTypeMap.Add("AccessControlParam", typeof(AccessControlParam));
                _entityTypeMap.Add("AccessControlParams", typeof(AccessControlParam));
                _entityTypeMap.Add("UserUsage", typeof(UserUsage));
                _entityTypeMap.Add("UserUsages", typeof(UserUsage));
                _entityTypeMap.Add("DiskSpace", typeof(DiskSpace));
                _entityTypeMap.Add("DiskSpaces", typeof(DiskSpace));
                _entityTypeMap.Add("BillingInfo", typeof(BillingInfo));
                _entityTypeMap.Add("BillingInfos", typeof(BillingInfo));
                _entityTypeMap.Add("UploadRequestParams", typeof(UploadRequestParams));
                _entityTypeMap.Add("UploadRequestParamss", typeof(UploadRequestParams));
                _entityTypeMap.Add("ESignature", typeof(ESignature));
                _entityTypeMap.Add("ESignatures", typeof(ESignature));
                _entityTypeMap.Add("MarketAnalytics", typeof(MarketAnalytics));
                _entityTypeMap.Add("MarketAnalyticss", typeof(MarketAnalytics));
                _entityTypeMap.Add("FileLock", typeof(FileLock));
                _entityTypeMap.Add("FileLocks", typeof(FileLock));
                _entityTypeMap.Add("PowerTools", typeof(PowerTools));
                _entityTypeMap.Add("PowerToolss", typeof(PowerTools));
                _entityTypeMap.Add("Item", typeof(Item));
                _entityTypeMap.Add("Items", typeof(Item));
                _entityTypeMap.Add("Folder", typeof(Folder));
                _entityTypeMap.Add("Folders", typeof(Folder));
                _entityTypeMap.Add("ConnectorGroup", typeof(ConnectorGroup));
                _entityTypeMap.Add("ConnectorGroups", typeof(ConnectorGroup));
                _entityTypeMap.Add("ConnectorGroupZone", typeof(ConnectorGroupZone));
                _entityTypeMap.Add("ConnectorGroupZones", typeof(ConnectorGroupZone));
                _entityTypeMap.Add("ConnectorGroupAccessControl", typeof(ConnectorGroupAccessControl));
                _entityTypeMap.Add("ConnectorGroupAccessControls", typeof(ConnectorGroupAccessControl));
                _entityTypeMap.Add("Principal", typeof(Principal));
                _entityTypeMap.Add("Principals", typeof(Principal));
                _entityTypeMap.Add("PreviewPlatformInfo", typeof(PreviewPlatformInfo));
                _entityTypeMap.Add("PreviewPlatformInfos", typeof(PreviewPlatformInfo));
                _entityTypeMap.Add("ShareResendParams", typeof(ShareResendParams));
                _entityTypeMap.Add("ToolInformation", typeof(ToolInformation));
                _entityTypeMap.Add("ToolInformations", typeof(ToolInformation));
                _entityTypeMap.Add("AccessControl", typeof(AccessControl));
                _entityTypeMap.Add("AccessControls", typeof(AccessControl));
                _entityTypeMap.Add("AccessControlDomains", typeof(AccessControlDomains));
                _entityTypeMap.Add("Account", typeof(Account));
                _entityTypeMap.Add("Accounts", typeof(Account));
                _entityTypeMap.Add("AccountPreferences", typeof(AccountPreferences));
                _entityTypeMap.Add("User", typeof(User));
                _entityTypeMap.Add("Users", typeof(User));
                _entityTypeMap.Add("AccountUser", typeof(AccountUser));
                _entityTypeMap.Add("AccountUsers", typeof(AccountUser));
                _entityTypeMap.Add("AsyncOperation", typeof(AsyncOperation));
                _entityTypeMap.Add("AsyncOperations", typeof(AsyncOperation));
                _entityTypeMap.Add("Capability", typeof(Capability));
                _entityTypeMap.Add("Capabilities", typeof(Capability));
                _entityTypeMap.Add("Device", typeof(Device));
                _entityTypeMap.Add("Devices", typeof(Device));
                _entityTypeMap.Add("DeviceUser", typeof(DeviceUser));
                _entityTypeMap.Add("DeviceUsers", typeof(DeviceUser));
                _entityTypeMap.Add("DeviceUserWipe", typeof(DeviceUserWipe));
                _entityTypeMap.Add("DeviceUserWipes", typeof(DeviceUserWipe));
                _entityTypeMap.Add("DeviceStatus", typeof(DeviceStatus));
                _entityTypeMap.Add("DeviceStatuss", typeof(DeviceStatus));
                _entityTypeMap.Add("DeviceWipeReport", typeof(DeviceWipeReport));
                _entityTypeMap.Add("DeviceWipeReports", typeof(DeviceWipeReport));
                _entityTypeMap.Add("DeviceLogEntry", typeof(DeviceLogEntry));
                _entityTypeMap.Add("DeviceLogEntrys", typeof(DeviceLogEntry));
                _entityTypeMap.Add("DownloadSpecification", typeof(DownloadSpecification));
                _entityTypeMap.Add("DownloadSpecifications", typeof(DownloadSpecification));
                _entityTypeMap.Add("EnsSubscriberConfiguration", typeof(EnsSubscriberConfiguration));
                _entityTypeMap.Add("EnsSubscriberConfigurations", typeof(EnsSubscriberConfiguration));
                _entityTypeMap.Add("EnsSubscriptionRequest", typeof(EnsSubscriptionRequest));
                _entityTypeMap.Add("EnsSubscriptionRequests", typeof(EnsSubscriptionRequest));
                _entityTypeMap.Add("EnsSubscriptionToken", typeof(EnsSubscriptionToken));
                _entityTypeMap.Add("EnsSubscriptionTokens", typeof(EnsSubscriptionToken));
                _entityTypeMap.Add("FindSubdomainParams", typeof(FindSubdomainParams));
                _entityTypeMap.Add("FindSubdomainResult", typeof(FindSubdomainResult));
                _entityTypeMap.Add("FindSubdomainResults", typeof(FindSubdomainResult));
                _entityTypeMap.Add("GenericConfig", typeof(GenericConfig));
                _entityTypeMap.Add("GenericConfigs", typeof(GenericConfig));
                _entityTypeMap.Add("Contact", typeof(Contact));
                _entityTypeMap.Add("Contacts", typeof(Contact));
                _entityTypeMap.Add("FavoriteFolder", typeof(FavoriteFolder));
                _entityTypeMap.Add("FavoriteFolders", typeof(FavoriteFolder));
                _entityTypeMap.Add("File", typeof(File));
                _entityTypeMap.Add("Files", typeof(File));
                _entityTypeMap.Add("Group", typeof(Group));
                _entityTypeMap.Add("Groups", typeof(Group));
                _entityTypeMap.Add("Industry", typeof(Industry));
                _entityTypeMap.Add("Industrys", typeof(Industry));
                _entityTypeMap.Add("ItemInfo", typeof(ItemInfo));
                _entityTypeMap.Add("ItemInfos", typeof(ItemInfo));
                _entityTypeMap.Add("ItemProtocolLink", typeof(ItemProtocolLink));
                _entityTypeMap.Add("ItemProtocolLinks", typeof(ItemProtocolLink));
                _entityTypeMap.Add("Link", typeof(Link));
                _entityTypeMap.Add("Links", typeof(Link));
                _entityTypeMap.Add("Metadata", typeof(Metadata));
                _entityTypeMap.Add("Metadatas", typeof(Metadata));
                _entityTypeMap.Add("MobileSecuritySettings", typeof(MobileSecuritySettings));
                _entityTypeMap.Add("Note", typeof(Note));
                _entityTypeMap.Add("Notes", typeof(Note));
                _entityTypeMap.Add("Notification", typeof(Notification));
                _entityTypeMap.Add("Notifications", typeof(Notification));
                _entityTypeMap.Add("ProductDefaults", typeof(ProductDefaults));
                _entityTypeMap.Add("Redirection", typeof(Redirection));
                _entityTypeMap.Add("Redirections", typeof(Redirection));
                _entityTypeMap.Add("RequireSubdomainResult", typeof(RequireSubdomainResult));
                _entityTypeMap.Add("RequireSubdomainResults", typeof(RequireSubdomainResult));
                _entityTypeMap.Add("RequireWebPopResult", typeof(RequireWebPopResult));
                _entityTypeMap.Add("RequireWebPopResults", typeof(RequireWebPopResult));
                _entityTypeMap.Add("SearchQuery", typeof(SearchQuery));
                _entityTypeMap.Add("SearchQueries", typeof(SearchQuery));
                _entityTypeMap.Add("Query", typeof(Query));
                _entityTypeMap.Add("Queries", typeof(Query));
                _entityTypeMap.Add("QueryPaging", typeof(QueryPaging));
                _entityTypeMap.Add("QueryPagings", typeof(QueryPaging));
                _entityTypeMap.Add("QuerySorting", typeof(QuerySorting));
                _entityTypeMap.Add("QuerySortings", typeof(QuerySorting));
                _entityTypeMap.Add("SimpleSearchQuery", typeof(SimpleSearchQuery));
                _entityTypeMap.Add("SimpleSearchQueries", typeof(SimpleSearchQuery));
                _entityTypeMap.Add("SimpleQuery", typeof(SimpleQuery));
                _entityTypeMap.Add("SimpleQueries", typeof(SimpleQuery));
                _entityTypeMap.Add("SearchResults", typeof(SearchResults));
                _entityTypeMap.Add("AdvancedSearchResults", typeof(AdvancedSearchResults));
                _entityTypeMap.Add("SearchResult", typeof(SearchResult));
                _entityTypeMap.Add("Session", typeof(Session));
                _entityTypeMap.Add("Sessions", typeof(Session));
                _entityTypeMap.Add("Share", typeof(Share));
                _entityTypeMap.Add("Shares", typeof(Share));
                _entityTypeMap.Add("ShareAlias", typeof(ShareAlias));
                _entityTypeMap.Add("ShareAliases", typeof(ShareAlias));
                _entityTypeMap.Add("ShareRequestParams", typeof(ShareRequestParams));
                _entityTypeMap.Add("ShareSendParams", typeof(ShareSendParams));
                _entityTypeMap.Add("SSOAccountProvider", typeof(SSOAccountProvider));
                _entityTypeMap.Add("SSOAccountProviders", typeof(SSOAccountProvider));
                _entityTypeMap.Add("SSOInfoEntry", typeof(SSOInfoEntry));
                _entityTypeMap.Add("SSOInfoEntries", typeof(SSOInfoEntry));
                _entityTypeMap.Add("SSOInfo", typeof(SSOInfo));
                _entityTypeMap.Add("SSOInfos", typeof(SSOInfo));
                _entityTypeMap.Add("StorageCenter", typeof(StorageCenter));
                _entityTypeMap.Add("StorageCenters", typeof(StorageCenter));
                _entityTypeMap.Add("SymbolicLink", typeof(SymbolicLink));
                _entityTypeMap.Add("SymbolicLinks", typeof(SymbolicLink));
                _entityTypeMap.Add("UploadSpecification", typeof(UploadSpecification));
                _entityTypeMap.Add("UploadSpecifications", typeof(UploadSpecification));
                _entityTypeMap.Add("UserConfirmationSettings", typeof(UserConfirmationSettings));
                _entityTypeMap.Add("UserInfo", typeof(UserInfo));
                _entityTypeMap.Add("UserInfos", typeof(UserInfo));
                _entityTypeMap.Add("PlanFeatures", typeof(PlanFeatures));
                _entityTypeMap.Add("UserPreferences", typeof(UserPreferences));
                _entityTypeMap.Add("UserSecurity", typeof(UserSecurity));
                _entityTypeMap.Add("UserSecurities", typeof(UserSecurity));
                _entityTypeMap.Add("Zone", typeof(Zone));
                _entityTypeMap.Add("Zones", typeof(Zone));
			}

			return _entityTypeMap;
		}
        
        /// <summary>
        /// Add additional models to the type map.
        /// </summary>
        public static void AddEntity(string key, Type value)
        {
            lock(_entityTypeMap)
            {
                _entityTypeMap.Add(key, value);
            }
        }
    }
}