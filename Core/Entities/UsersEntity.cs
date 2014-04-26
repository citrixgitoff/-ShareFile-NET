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
using System.IO;
using ShareFile.Api.Models;
using ShareFile.Api.Client;
using ShareFile.Api.Client.Requests;
using ShareFile.Api.Client.Extensions;


namespace ShareFile.Api.Client.Entities
{

	public interface IUsersEntity : IEntityBase
	{
		/// <summary>
		/// Get User
		/// </summary>
		/// <remarks>
		/// Retrieve a single user, by ID or email, or the currently authenticated user.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="emailAddress"></param>
		/// <returns>
		/// the requested User object
		/// </returns>
		IQuery<User> Get(string id = null, string emailAddress = null);
		/// <summary>
		/// Create Customer
		/// </summary>
		/// <example>
		/// {
		/// "Email":"user.one@domain.com",
		/// "FirstName":"Name",
		/// "LastName":"Last Name",
		/// "Company":"Company",
		/// "Password":"password",
		/// "Preferences":
		/// {
		/// "CanResetPassword":true,
		/// "CanViewMySettings":true
		/// },
		/// "DefaultZone":
		/// {
		/// "Id":"zoneid"
		/// }
		/// }
		/// </example>
		/// <remarks>
		/// The following parameters from the input object are used: Email, FirstName, LastName, Company,
		/// DefaultZone, Password, Preferences.CanResetPassword and Preferences.CanViewMySettingsOther parameters are ignored
		/// </remarks>
		/// <param name="user"></param>
		/// <param name="pushCreatorDefaultSettings"></param>
		/// <param name="addshared"></param>
		/// <param name="notify"></param>
		/// <param name="ifNecessary"></param>
		/// <returns>
		/// The new user
		/// </returns>
		IQuery<User> Create(User user, bool pushCreatorDefaultSettings = false, bool addshared = false, bool notify = false, bool ifNecessary = false);
		/// <summary>
		/// Create Employee
		/// </summary>
		/// <example>
		/// {
		/// "Email":"user.one@domain.com",
		/// "FirstName":"Name",
		/// "LastName":"Last Name",
		/// "Company":"Company",
		/// "Password":"password",
		/// "StorageQuotaLimitGB":50,
		/// "Preferences":
		/// {
		/// "CanResetPassword":true,
		/// "CanViewMySettings":true
		/// },
		/// "DefaultZone":
		/// {
		/// "Id":"zoneid"
		/// },
		/// "IsAdministrator": false,
		/// "CanCreateFolders": false,
		/// "CanUseFileBox": true,
		/// "CanManageUsers": false,
		/// "Roles": [
		/// "CanChangePassword", "CanManageMySettings",
		/// "CanUseFileBox, "CanManageUsers, "CanCreateFolders, "CanUseDropBox, "CanSelectFolderZone,
		/// "AdminAccountPolicies", "AdminBilling", "AdminBranding", "AdminChangePlan", "AdminFileBoxAccess",
		/// "AdminManageEmployees", "AdminRemoteUploadForms", "AdminReporting", "AdminSharedDistGroups",
		/// "AdminSharedAddressBook", "AdminViewReceipts", "AdminDelegate", "AdminManageFolderTemplates",
		/// "AdminEmailMessages", "AdminSSO", "AdminSuperGroup", "AdminZones", "AdminCreateSharedGroups", "AdminConnectors"
		/// ]
		/// }
		/// </example>
		/// <remarks>
		/// Create a new Employee user (AccountUser)
		/// The following parameters from the input object are used: Email, FirstName, LastName, Company,
		/// DefaultZone, Password, IsEmployee, IsAdministrator, CanCreateFolders, CanUseFileBox, CanManageUsers,
		/// Preferences.CanResetPassword and Preferences.CanViewMySettings.
		/// Other parameters are ignoredStorageQuotaLimitGB parameter is optional. If not specified or equal to -1 the account default storage quota value will be set for the user.
		/// </remarks>
		/// <param name="user"></param>
		/// <param name="pushCreatorDefaultSettings"></param>
		/// <param name="addshared"></param>
		/// <param name="notify"></param>
		/// <param name="ifNecessary"></param>
		/// <returns>
		/// The new employee user
		/// </returns>
		IQuery<User> CreateAccountUser(AccountUser user, bool pushCreatorDefaultSettings = false, bool addshared = false, bool notify = false, bool ifNecessary = false);
		/// <summary>
		/// Update User
		/// </summary>
		/// <example>
		/// {
		/// "FirstName":"FirstName",
		/// "LastName":"LastName",
		/// "Company":"Company",
		/// "Email":"user@domain.com",
		/// "Security":
		/// {
		/// "IsDisabled":false
		/// }
		/// "DefaultZone":
		/// {
		/// "Id":"newzoneid"
		/// }
		/// }
		/// </example>
		/// <remarks>
		/// Modifies an existing user object
		/// The following parameters can be modified through this call: FirstName, LastName, Company,
		/// Email, IsDisabled, DefaultZone Id
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="user"></param>
		/// <returns>
		/// a modified user record
		/// </returns>
		IQuery<User> Update(string id, User user);
		/// <summary>
		/// Add Roles
		/// </summary>
		/// <example>
		/// {
		/// "Roles" : [ "CanManageUsers", "CanSelectFolderZone" ]
		/// }
		/// </example>
		/// <remarks>
		/// Modifies an existing user object to ADD a new role
		/// The following roles can be added to the user through this call (depending on User type):
		/// CanCreateFolders,
		/// CanSelectFolderZone,
		/// CanUseFileBox,
		/// CanManageUsers,
		/// AdminSharedAddressBook,
		/// CanChangePassword,
		/// CanManageMySettings
		/// </remarks>
		/// <param name="parentid"></param>
		/// <param name="user"></param>
		/// <returns>
		/// a modified user record
		/// </returns>
		IQuery<User> UpdateRoles(string parentid, User user);
		/// <summary>
		/// Set Roles
		/// </summary>
		/// <example>
		/// {
		/// "Roles" : [ "CanManageUsers", "CanSelectFolderZone" ]
		/// }
		/// </example>
		/// <remarks>
		/// Sets the roles for a user (roles not provided will be disabled.)
		/// The following roles can be set to the user through this call (depending on User type):
		/// CanCreateFolders,
		/// CanSelectFolderZone,
		/// CanUseFileBox,
		/// CanManageUsers,
		/// AdminSharedAddressBook,
		/// CanChangePassword,
		/// CanManageMySettings
		/// </remarks>
		/// <param name="parentid"></param>
		/// <param name="user"></param>
		/// <returns>
		/// a modified user record
		/// </returns>
		IQuery<User> PatchRoles(string parentid, User user);
		/// <summary>
		/// Update Employee or Promote Customer
		/// </summary>
		/// <example>
		/// {
		/// "FirstName":"FirstName",
		/// "LastName":"LastName",
		/// "Company":"Company",
		/// "Email":"user@domain.com",
		/// "StorageQuotaLimitGB":100,
		/// "Security":
		/// {
		/// "IsDisabled":false
		/// }
		/// "DefaultZone":
		/// {
		/// "Id":"newzoneid"
		/// }
		/// }
		/// </example>
		/// <remarks>
		/// Modifies an existing user object
		/// The following parameters can be modified through this call: FirstName, LastName, Company,
		/// Email, IsEmployee, IsDisabled, DefaultZone Id, StorageQuotaLimitGB.During a promotion (the user id points to Customer), the following parameters can be
		/// modified: CanCreateFolders, CanUseFileBox, CanManageUsers. StorageQuotaLimitGB equal to -1 sets the user quota to the account default storage quota value.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="user"></param>
		/// <returns>
		/// a modified user record
		/// </returns>
		IQuery<User> UpdateAccountUser(string id, AccountUser user);
		/// <summary>
		/// Get HomeFolder
		/// </summary>
		/// <remarks>
		/// Returns a user's home folder
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// A folder record representing the requesting user home folder
		/// </returns>
		IQuery<Item> GetHomeFolder(string id);
		IQuery<ODataFeed<Item>> TopFolders(string userId);
		IQuery<ODataFeed<Item>> Box(string userId);
		/// <summary>
		/// Get User Preferences
		/// </summary>
		/// <remarks>
		/// Retrieves the User preferences record - all user-selected prefernces, such as timezone,
		/// time format, sort preferences, etc.
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// the user selected preferences
		/// </returns>
		IQuery<UserPreferences> GetPreferences(string id);
		/// <summary>
		/// Reset Password
		/// </summary>
		/// <example>
		/// {
		/// "NewPassword":"new password",
		/// "OldPassword":"old password"
		/// }
		/// {
		/// "NewPassword":"new password",
		/// "OldPassword":"old password"
		/// }
		/// </example>
		/// <remarks>
		/// Resets a user password. A user can reset his own password providing the old and new
		/// passwords. Administrators can issue this call without providing the old password.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="properties"></param>
		/// <param name="notify"></param>
		/// <returns>
		/// The modified user record
		/// </returns>
		IQuery<User> ResetPassword(string id, ODataObject properties, bool notify = false);
		/// <summary>
		/// Send Welcome Email
		/// </summary>
		/// <remarks>
		/// Resends the 'welcome' email to the given user
		/// </remarks>
		/// <param name="id"></param>
		IQuery ResendWelcome(string id);
		/// <summary>
		/// Delete User
		/// </summary>
		/// <remarks>
		/// Removes an user
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="completely"></param>
		IQuery Delete(string id, bool completely = false);
		/// <summary>
		/// Get List of User Shared Folders
		/// </summary>
		/// <remarks>
		/// Retrieve the list of shared folders the authenticated user has access to
		/// </remarks>
		/// <returns>
		/// A list of Folder objects, representing shared folders of an user
		/// </returns>
		IQuery<ODataFeed<Item>> GetAllSharedFolders();
		/// <summary>
		/// Get List of User Shared Folders
		/// </summary>
		/// <remarks>
		/// Retrieve the top-level folders for this user. This method requires the account to be
		/// in the new UI model of "My Files", "Shared", "Connectors", "Favorites" tab - otherwise
		/// it will return an empty list (new UX model is the default since May 2013).
		/// </remarks>
		/// <returns>
		/// A list of Folder objects, representing shared folders of an user
		/// </returns>
		IQuery<ODataFeed<Item>> GetTopFolders();
		/// <summary>
		/// Get List of User Shared Folders
		/// </summary>
		/// <remarks>
		/// Retrieve the connector folders that are associated with a network share service
		/// </remarks>
		/// <returns>
		/// A list of Folder objects, representing network shared connector folders of an user
		/// </returns>
		IQuery<ODataFeed<Item>> NetworkShareConnectors();
		/// <summary>
		/// Get List of User Shared Folders
		/// </summary>
		/// <remarks>
		/// Retrieve the connector folders that are associated with a sharepoint service
		/// </remarks>
		/// <returns>
		/// A list of Folder objects, representing sharepoint folders of an user
		/// </returns>
		IQuery<ODataFeed<Item>> SharepointConnectors();
		/// <summary>
		/// Confirm the current user logging in for the first time
		/// </summary>
		/// <example>
		/// {
		/// "FirstName":"",
		/// "LastName":"",
		/// "Company":"",
		/// "Password":"",
		/// "DayLightName":"",
		/// "UTCOffset":"",
		/// "DateFormat":"",
		/// "TimeFormat":"",
		/// "EmailInterval":0
		/// }
		/// </example>
		/// <param name="settings"></param>
		/// <returns>
		/// no data on success
		/// </returns>
		IQuery Confirm(UserConfirmationSettings settings);
		/// <summary>
		/// Get Current User Info
		/// </summary>
		/// <returns>
		/// UserInfo
		/// </returns>
		IQuery<UserInfo> GetInfo();
	}

	public class UsersEntity : EntityBase, IUsersEntity
	{
		public UsersEntity(IShareFileClient client)
			: base (client, "Users")
			
		{

		}

		/// <summary>
		/// Get User
		/// </summary>
		/// <remarks>
		/// Retrieve a single user, by ID or email, or the currently authenticated user.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="emailAddress"></param>
		/// <returns>
		/// the requested User object
		/// </returns>
		public IQuery<User> Get(string id = null, string emailAddress = null)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<User>(Client);
			sfApiQuery.From("Users");
			if (id != null)
			{
				sfApiQuery.QueryString("id", id);
			}
			if (emailAddress != null)
			{
				sfApiQuery.QueryString("emailAddress", emailAddress);
			}
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Create Customer
		/// </summary>
		/// <example>
		/// {
		/// "Email":"user.one@domain.com",
		/// "FirstName":"Name",
		/// "LastName":"Last Name",
		/// "Company":"Company",
		/// "Password":"password",
		/// "Preferences":
		/// {
		/// "CanResetPassword":true,
		/// "CanViewMySettings":true
		/// },
		/// "DefaultZone":
		/// {
		/// "Id":"zoneid"
		/// }
		/// }
		/// </example>
		/// <remarks>
		/// The following parameters from the input object are used: Email, FirstName, LastName, Company,
		/// DefaultZone, Password, Preferences.CanResetPassword and Preferences.CanViewMySettingsOther parameters are ignored
		/// </remarks>
		/// <param name="user"></param>
		/// <param name="pushCreatorDefaultSettings"></param>
		/// <param name="addshared"></param>
		/// <param name="notify"></param>
		/// <param name="ifNecessary"></param>
		/// <returns>
		/// The new user
		/// </returns>
		public IQuery<User> Create(User user, bool pushCreatorDefaultSettings = false, bool addshared = false, bool notify = false, bool ifNecessary = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<User>(Client);
			sfApiQuery.From("Users");
			if (pushCreatorDefaultSettings != false)
			{
				sfApiQuery.QueryString("pushCreatorDefaultSettings", pushCreatorDefaultSettings);
			}
			if (addshared != false)
			{
				sfApiQuery.QueryString("addshared", addshared);
			}
			if (notify != false)
			{
				sfApiQuery.QueryString("notify", notify);
			}
			if (ifNecessary != false)
			{
				sfApiQuery.QueryString("ifNecessary", ifNecessary);
			}
			sfApiQuery.Body = user;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Create Employee
		/// </summary>
		/// <example>
		/// {
		/// "Email":"user.one@domain.com",
		/// "FirstName":"Name",
		/// "LastName":"Last Name",
		/// "Company":"Company",
		/// "Password":"password",
		/// "StorageQuotaLimitGB":50,
		/// "Preferences":
		/// {
		/// "CanResetPassword":true,
		/// "CanViewMySettings":true
		/// },
		/// "DefaultZone":
		/// {
		/// "Id":"zoneid"
		/// },
		/// "IsAdministrator": false,
		/// "CanCreateFolders": false,
		/// "CanUseFileBox": true,
		/// "CanManageUsers": false,
		/// "Roles": [
		/// "CanChangePassword", "CanManageMySettings",
		/// "CanUseFileBox, "CanManageUsers, "CanCreateFolders, "CanUseDropBox, "CanSelectFolderZone,
		/// "AdminAccountPolicies", "AdminBilling", "AdminBranding", "AdminChangePlan", "AdminFileBoxAccess",
		/// "AdminManageEmployees", "AdminRemoteUploadForms", "AdminReporting", "AdminSharedDistGroups",
		/// "AdminSharedAddressBook", "AdminViewReceipts", "AdminDelegate", "AdminManageFolderTemplates",
		/// "AdminEmailMessages", "AdminSSO", "AdminSuperGroup", "AdminZones", "AdminCreateSharedGroups", "AdminConnectors"
		/// ]
		/// }
		/// </example>
		/// <remarks>
		/// Create a new Employee user (AccountUser)
		/// The following parameters from the input object are used: Email, FirstName, LastName, Company,
		/// DefaultZone, Password, IsEmployee, IsAdministrator, CanCreateFolders, CanUseFileBox, CanManageUsers,
		/// Preferences.CanResetPassword and Preferences.CanViewMySettings.
		/// Other parameters are ignoredStorageQuotaLimitGB parameter is optional. If not specified or equal to -1 the account default storage quota value will be set for the user.
		/// </remarks>
		/// <param name="user"></param>
		/// <param name="pushCreatorDefaultSettings"></param>
		/// <param name="addshared"></param>
		/// <param name="notify"></param>
		/// <param name="ifNecessary"></param>
		/// <returns>
		/// The new employee user
		/// </returns>
		public IQuery<User> CreateAccountUser(AccountUser user, bool pushCreatorDefaultSettings = false, bool addshared = false, bool notify = false, bool ifNecessary = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<User>(Client);
			sfApiQuery.From("Users");
			sfApiQuery.Action("AccountUser");
			if (pushCreatorDefaultSettings != false)
			{
				sfApiQuery.QueryString("pushCreatorDefaultSettings", pushCreatorDefaultSettings);
			}
			if (addshared != false)
			{
				sfApiQuery.QueryString("addshared", addshared);
			}
			if (notify != false)
			{
				sfApiQuery.QueryString("notify", notify);
			}
			if (ifNecessary != false)
			{
				sfApiQuery.QueryString("ifNecessary", ifNecessary);
			}
			sfApiQuery.Body = user;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Update User
		/// </summary>
		/// <example>
		/// {
		/// "FirstName":"FirstName",
		/// "LastName":"LastName",
		/// "Company":"Company",
		/// "Email":"user@domain.com",
		/// "Security":
		/// {
		/// "IsDisabled":false
		/// }
		/// "DefaultZone":
		/// {
		/// "Id":"newzoneid"
		/// }
		/// }
		/// </example>
		/// <remarks>
		/// Modifies an existing user object
		/// The following parameters can be modified through this call: FirstName, LastName, Company,
		/// Email, IsDisabled, DefaultZone Id
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="user"></param>
		/// <returns>
		/// a modified user record
		/// </returns>
		public IQuery<User> Update(string id, User user)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<User>(Client);
			sfApiQuery.From("Users");
			sfApiQuery.Ids(id);
			sfApiQuery.Body = user;
			sfApiQuery.HttpMethod = "PATCH";
			return sfApiQuery;
		}

		/// <summary>
		/// Add Roles
		/// </summary>
		/// <example>
		/// {
		/// "Roles" : [ "CanManageUsers", "CanSelectFolderZone" ]
		/// }
		/// </example>
		/// <remarks>
		/// Modifies an existing user object to ADD a new role
		/// The following roles can be added to the user through this call (depending on User type):
		/// CanCreateFolders,
		/// CanSelectFolderZone,
		/// CanUseFileBox,
		/// CanManageUsers,
		/// AdminSharedAddressBook,
		/// CanChangePassword,
		/// CanManageMySettings
		/// </remarks>
		/// <param name="parentid"></param>
		/// <param name="user"></param>
		/// <returns>
		/// a modified user record
		/// </returns>
		public IQuery<User> UpdateRoles(string parentid, User user)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<User>(Client);
			sfApiQuery.From("Users");
			sfApiQuery.Action("Roles");
			sfApiQuery.Ids(parentid);
			sfApiQuery.Body = user;
			sfApiQuery.HttpMethod = "PATCH";
			return sfApiQuery;
		}

		/// <summary>
		/// Set Roles
		/// </summary>
		/// <example>
		/// {
		/// "Roles" : [ "CanManageUsers", "CanSelectFolderZone" ]
		/// }
		/// </example>
		/// <remarks>
		/// Sets the roles for a user (roles not provided will be disabled.)
		/// The following roles can be set to the user through this call (depending on User type):
		/// CanCreateFolders,
		/// CanSelectFolderZone,
		/// CanUseFileBox,
		/// CanManageUsers,
		/// AdminSharedAddressBook,
		/// CanChangePassword,
		/// CanManageMySettings
		/// </remarks>
		/// <param name="parentid"></param>
		/// <param name="user"></param>
		/// <returns>
		/// a modified user record
		/// </returns>
		public IQuery<User> PatchRoles(string parentid, User user)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<User>(Client);
			sfApiQuery.From("Users");
			sfApiQuery.Action("Roles");
			sfApiQuery.Ids(parentid);
			sfApiQuery.Body = user;
			sfApiQuery.HttpMethod = "PUT";
			return sfApiQuery;
		}

		/// <summary>
		/// Update Employee or Promote Customer
		/// </summary>
		/// <example>
		/// {
		/// "FirstName":"FirstName",
		/// "LastName":"LastName",
		/// "Company":"Company",
		/// "Email":"user@domain.com",
		/// "StorageQuotaLimitGB":100,
		/// "Security":
		/// {
		/// "IsDisabled":false
		/// }
		/// "DefaultZone":
		/// {
		/// "Id":"newzoneid"
		/// }
		/// }
		/// </example>
		/// <remarks>
		/// Modifies an existing user object
		/// The following parameters can be modified through this call: FirstName, LastName, Company,
		/// Email, IsEmployee, IsDisabled, DefaultZone Id, StorageQuotaLimitGB.During a promotion (the user id points to Customer), the following parameters can be
		/// modified: CanCreateFolders, CanUseFileBox, CanManageUsers. StorageQuotaLimitGB equal to -1 sets the user quota to the account default storage quota value.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="user"></param>
		/// <returns>
		/// a modified user record
		/// </returns>
		public IQuery<User> UpdateAccountUser(string id, AccountUser user)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<User>(Client);
			sfApiQuery.From("Users");
			sfApiQuery.Action("AccountUser");
			sfApiQuery.ActionIds(id);
			sfApiQuery.Body = user;
			sfApiQuery.HttpMethod = "PATCH";
			return sfApiQuery;
		}

		/// <summary>
		/// Get HomeFolder
		/// </summary>
		/// <remarks>
		/// Returns a user's home folder
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// A folder record representing the requesting user home folder
		/// </returns>
		public IQuery<Item> GetHomeFolder(string id)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Item>(Client);
			sfApiQuery.From("Users");
			sfApiQuery.Action("HomeFolder");
			sfApiQuery.Ids(id);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		public IQuery<ODataFeed<Item>> TopFolders(string userId)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Item>>(Client);
			sfApiQuery.From("Users");
			sfApiQuery.Action("TopFolders");
			sfApiQuery.Ids(userId);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		public IQuery<ODataFeed<Item>> Box(string userId)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Item>>(Client);
			sfApiQuery.From("Users");
			sfApiQuery.Action("Box");
			sfApiQuery.Ids(userId);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get User Preferences
		/// </summary>
		/// <remarks>
		/// Retrieves the User preferences record - all user-selected prefernces, such as timezone,
		/// time format, sort preferences, etc.
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// the user selected preferences
		/// </returns>
		public IQuery<UserPreferences> GetPreferences(string id)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<UserPreferences>(Client);
			sfApiQuery.From("Users");
			sfApiQuery.Action("Preferences");
			sfApiQuery.Ids(id);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Reset Password
		/// </summary>
		/// <example>
		/// {
		/// "NewPassword":"new password",
		/// "OldPassword":"old password"
		/// }
		/// {
		/// "NewPassword":"new password",
		/// "OldPassword":"old password"
		/// }
		/// </example>
		/// <remarks>
		/// Resets a user password. A user can reset his own password providing the old and new
		/// passwords. Administrators can issue this call without providing the old password.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="properties"></param>
		/// <param name="notify"></param>
		/// <returns>
		/// The modified user record
		/// </returns>
		public IQuery<User> ResetPassword(string id, ODataObject properties, bool notify = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<User>(Client);
			sfApiQuery.From("Users");
			sfApiQuery.Action("ResetPassword");
			sfApiQuery.Ids(id);
			if (notify != false)
			{
				sfApiQuery.QueryString("notify", notify);
			}
			sfApiQuery.Body = properties;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Send Welcome Email
		/// </summary>
		/// <remarks>
		/// Resends the 'welcome' email to the given user
		/// </remarks>
		/// <param name="id"></param>
		public IQuery ResendWelcome(string id)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("Users");
			sfApiQuery.Action("ResendWelcome");
			sfApiQuery.Ids(id);
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Delete User
		/// </summary>
		/// <remarks>
		/// Removes an user
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="completely"></param>
		public IQuery Delete(string id, bool completely = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("Users");
			sfApiQuery.Ids(id);
			if (completely != false)
			{
				sfApiQuery.QueryString("completely", completely);
			}
			sfApiQuery.HttpMethod = "DELETE";
			return sfApiQuery;
		}

		/// <summary>
		/// Get List of User Shared Folders
		/// </summary>
		/// <remarks>
		/// Retrieve the list of shared folders the authenticated user has access to
		/// </remarks>
		/// <returns>
		/// A list of Folder objects, representing shared folders of an user
		/// </returns>
		public IQuery<ODataFeed<Item>> GetAllSharedFolders()
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Item>>(Client);
			sfApiQuery.From("Users");
			sfApiQuery.Action("AllSharedFolders");
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get List of User Shared Folders
		/// </summary>
		/// <remarks>
		/// Retrieve the top-level folders for this user. This method requires the account to be
		/// in the new UI model of "My Files", "Shared", "Connectors", "Favorites" tab - otherwise
		/// it will return an empty list (new UX model is the default since May 2013).
		/// </remarks>
		/// <returns>
		/// A list of Folder objects, representing shared folders of an user
		/// </returns>
		public IQuery<ODataFeed<Item>> GetTopFolders()
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Item>>(Client);
			sfApiQuery.From("Users");
			sfApiQuery.Action("TopFolders");
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get List of User Shared Folders
		/// </summary>
		/// <remarks>
		/// Retrieve the connector folders that are associated with a network share service
		/// </remarks>
		/// <returns>
		/// A list of Folder objects, representing network shared connector folders of an user
		/// </returns>
		public IQuery<ODataFeed<Item>> NetworkShareConnectors()
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Item>>(Client);
			sfApiQuery.From("Users");
			sfApiQuery.Action("NetworkShareConnectors");
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get List of User Shared Folders
		/// </summary>
		/// <remarks>
		/// Retrieve the connector folders that are associated with a sharepoint service
		/// </remarks>
		/// <returns>
		/// A list of Folder objects, representing sharepoint folders of an user
		/// </returns>
		public IQuery<ODataFeed<Item>> SharepointConnectors()
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Item>>(Client);
			sfApiQuery.From("Users");
			sfApiQuery.Action("SharepointConnectors");
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Confirm the current user logging in for the first time
		/// </summary>
		/// <example>
		/// {
		/// "FirstName":"",
		/// "LastName":"",
		/// "Company":"",
		/// "Password":"",
		/// "DayLightName":"",
		/// "UTCOffset":"",
		/// "DateFormat":"",
		/// "TimeFormat":"",
		/// "EmailInterval":0
		/// }
		/// </example>
		/// <param name="settings"></param>
		/// <returns>
		/// no data on success
		/// </returns>
		public IQuery Confirm(UserConfirmationSettings settings)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("Users");
			sfApiQuery.Action("Confirm");
			sfApiQuery.Body = settings;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Get Current User Info
		/// </summary>
		/// <returns>
		/// UserInfo
		/// </returns>
		public IQuery<UserInfo> GetInfo()
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<UserInfo>(Client);
			sfApiQuery.From("Users");
			sfApiQuery.Action("Info");
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

	}
}
