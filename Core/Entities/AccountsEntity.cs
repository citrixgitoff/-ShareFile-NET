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
    public interface IAccountsEntity : IEntityBase
    {
        
        /// <summary>
        /// Get current Account
        /// </summary>
        /// <remarks>
        /// Retrieves information about the Account defined in the call subdomain
        /// </remarks>
        /// <returns>
        /// The subdomain account information
        /// </returns>
        IQuery<Account> Get();
        
        /// <summary>
        /// Get current Account branding
        /// </summary>
        /// <remarks>
        /// Retrievs Branding information about the subdomain account.
        /// This operation does not require authentication.
        /// </remarks>
        /// <returns>
        /// Branding information for a given sharefile account
        /// </returns>
        IQuery<Account> GetBranding();
        
        /// <summary>
        /// Modify the Branding for this account
        /// </summary>
        /// <remarks>
        /// Modifies Branding information about the subdomain account.
        /// This operation requires authentication.
        /// </remarks>
        /// <returns>
        /// Branding information for a given sharefile account
        /// </returns>
        IQuery<Account> UpdateBranding(Account account);
        
        /// <summary>
        /// Get List of current Account Employees
        /// </summary>
        /// <remarks>
        /// Retrives the list of Employees in the Account
        /// Employees are named users in the Account.
        /// </remarks>
        /// <returns>
        /// A Feed containing all Employees Contacts in the account
        /// </returns>
        IQuery<ODataFeed<Contact>> GetEmployees();
        
        /// <summary>
        /// Get List of current Account Clients
        /// </summary>
        /// <remarks>
        /// Retrieves the list of Clients in the Account.
        /// Clients are restricted users of an Account, that can receive and send files
        /// to Employees, but have no other permissions besides basic sharing with Employees.
        /// </remarks>
        /// <returns>
        /// A Feed containing all Clients in the account
        /// </returns>
        IQuery<ODataFeed<Contact>> GetClients();
        
        /// <summary>
        /// Get Account AddressBooks
        /// </summary>
        /// <remarks>
        /// Retrieves an address book from the account.
        /// Address Books are the contacts of Eployees and Clients, maintained on a personal or
        /// account-wide basis (shared).
        /// </remarks>
        /// <param name="type"></param>
        /// <param name="searchTerm"></param>
        /// <returns>
        /// A Feed of Contact objects representing the Address Book retrieved
        /// </returns>
        IQuery<ODataFeed<Contact>> GetAddressBook(string type = "personal", string searchTerm = "");
        
        /// <summary>
        /// Get Account Mobile Security Settings
        /// </summary>
        /// <remarks>
        /// Returns the Mobile device configuration settings for this account
        /// </remarks>
        /// <returns>
        /// The current mobile security configuration for this account
        /// </returns>
        IQuery<MobileSecuritySettings> GetMobileSecuritySettings();
        
        /// <summary>
        /// Get Account Product Defaults
        /// </summary>
        /// <returns>
        /// Account defaults
        /// </returns>
        IQuery<ProductDefaults> GetProductDefaults();
        
        /// <summary>
        /// Get Account Preferences
        /// </summary>
        /// <returns>
        /// Account preferences
        /// </returns>
        IQuery<AccountPreferences> GetPreferences();
        
        /// <summary>
        /// Get Account Single Sign-On Configuration
        /// </summary>
        /// <remarks>
        /// Retrieve the Single Sign-on configuration for the Account
        /// </remarks>
        /// <param name="provider"></param>
        IQuery<SSOAccountProvider> GetSSO(string provider = "saml");
        
        /// <summary>
        /// Update Account Single Sign-On Configuration
        /// </summary>
        /// <example>
        /// {
        /// "LogoutUrl":"",
        /// "LoginUrl":"https://idp.com/signin",
        /// "IPRestrictions":"+all",
        /// "ForceSSO":true,
        /// "EntityID":"http://account.sf-api.com/saml/info",
        /// "SFEntityID":"http://idp.com/saml/info",
        /// "SPInitatedAuthContext":"exact",
        /// "SPInitatedAuthMethod":"urn:oasis:names:tc:SAML:2.0:ac:classes:PasswordProtectedTransport"
        /// }
        /// </example>
        /// <remarks>
        /// Modifies the Single Sign-on Configuration for this account.
        /// </remarks>
        /// <param name="sso"></param>
        /// <param name="provider"></param>
        IQuery<SSOAccountProvider> UpdateSSO(SSOAccountProvider sso, string provider = "saml");
        
        /// <summary>
        /// Get List of Accounts for User
        /// </summary>
        /// <example>
        /// {
        /// "password":"password"
        /// }
        /// </example>
        /// <remarks>
        /// Retrieve the list of Accounts associated with a given user
        /// All parameters to this call may be passed in the Post body as root JSON parameters, or in the URI -
        /// with the exception of password that must be provided in the POST body.
        /// This operation does not require authentication
        /// </remarks>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="employeesonly"></param>
        /// <param name="requirehomefolders"></param>
        /// <param name="singleplane"></param>
        /// <returns>
        /// The list of Accounts associated with this username/password.
        /// </returns>
        IQuery<ODataFeed<Account>> GetByUser(ODataObject parameters, string username, bool employeesonly = false, bool requirehomefolders = false, bool singleplane = false);
        
        /// <summary>
        /// Email List of Accounts to User
        /// </summary>
        /// <remarks>
        /// Sends the list of accounts to the specified email address
        /// This operation does not require authentication
        /// </remarks>
        /// <param name="email"></param>
        IQuery SendToEmail(string email);
        
        /// <summary>
        /// Get the Login Access Control List of domains
        /// </summary>
        /// <remarks>
        /// Retrieve the list of domains that are allowed or disallowed to login.
        /// Whether the list is an allow or disallow list
        /// is configured by the AccessControlType property. The domain names are checked against the domains of all the
        /// email addresses of the user that attempts to log in to the Account.
        /// </remarks>
        /// <returns>
        /// The Login Access Control List of domains for the Account.
        /// </returns>
        IQuery<AccessControlDomains> GetLoginAccessControlDomains();
        
        /// <summary>
        /// Get the Folder Access Control List of domains
        /// </summary>
        /// <remarks>
        /// Retrieve the list of domains that are allowed or disallowed to have access to folders. Whether the list is an allow or disallow list
        /// is configured by the AccessControlType property.
        /// 
        /// The list blocks user access to folders by preventing adding a user to distribution groups or folders.
        /// The domain names are checked against the domains of all the email addresses of the user.
        /// This is an account-wide setting.
        /// </remarks>
        /// <returns>
        /// The Folder Access Control List of domains for the Account, e.g.
        /// 
        /// {
        /// "AccessControlType" : "AllowedDomains",
        /// "Domains": ["domainA", "domainB", ...]
        /// }
        /// </returns>
        IQuery<AccessControlDomains> GetFolderAccessControlDomains();
        
        /// <summary>
        /// Create or replace the Login Access Control List of domains
        /// </summary>
        /// <example>
        /// {
        /// "AccessControlType" : "AllowedDomains",
        /// "Domains": ["domainA", "domainB", ...]
        /// }
        /// </example>
        /// <param name="AccessControlType"></param>
        /// <param name="Domains"></param>
        /// <returns>
        /// The new Login Access Control List of domains for the Account
        /// </returns>
        IQuery<AccessControlDomains> CreateLoginAccessControlDomains(AccessControlDomains accessControlDomains);
        
        /// <summary>
        /// Create or replace the Folder Access Control List of domains
        /// </summary>
        /// <example>
        /// {
        /// "AccessControlType" : "AllowedDomains",
        /// "Domains": ["domainA", "domainB", ...]
        /// }
        /// </example>
        /// <param name="AccessControlType"></param>
        /// <param name="Domains"></param>
        /// <returns>
        /// The new Folder Access Control List of domains for the Account
        /// </returns>
        IQuery<AccessControlDomains> CreateFolderAccessControlDomains(AccessControlDomains accessControlDomains);
        
        /// <summary>
        /// Update the Login Access Control List of domains
        /// </summary>
        /// <example>
        /// {
        /// "AccessControlType" : "AllowedDomains",
        /// "Domains": ["domainA", "domainB", ...]
        /// }
        /// </example>
        /// <remarks>
        /// Merges the specified domains with existing domains in the list, and/or updates the AccessControlType. One of the parameters needs to be specified.
        /// </remarks>
        /// <param name="AccessControlType"></param>
        /// <param name="Domains"></param>
        /// <returns>
        /// The updated Login Access Control List of domains for the Account
        /// </returns>
        IQuery<AccessControlDomains> UpdateLoginAccessControlDomains(AccessControlDomains accessControlDomains);
        
        /// <summary>
        /// Update the Folder Access Control List of domains
        /// </summary>
        /// <example>
        /// {
        /// "AccessControlType" : "AllowedDomains",
        /// "Domains": ["domainA", "domainB", ...]
        /// }
        /// </example>
        /// <remarks>
        /// Merges the specified domains with existing domains in the list, and/or updates the AccessControlType. One of the parameters needs to be specified. It
        /// allows to add new domains to the list.
        /// </remarks>
        /// <param name="AccessControlType"></param>
        /// <param name="Domains"></param>
        /// <returns>
        /// The updated Folder Access Control List of domains for the Account
        /// </returns>
        IQuery<AccessControlDomains> UpdateFolderAccessControlDomains(AccessControlDomains accessControlDomains);
        
        /// <summary>
        /// Delete domains from the Logins Access Control List of domains
        /// </summary>
        /// <example>
        /// {
        /// "AccessControlType" : "AllowedDomains",
        /// "Domains": ["domainA", "domainB", ...]
        /// }
        /// </example>
        /// <remarks>
        /// Deletes the specified domains from the list.
        /// </remarks>
        /// <param name="AccessControlType"></param>
        /// <param name="Domains"></param>
        /// <returns>
        /// No content
        /// </returns>
        IQuery DeleteLoginAccessControlDomains(AccessControlDomains accessControlDomains);
        
        /// <summary>
        /// Delete domains from the Folder Access Control List of domains
        /// </summary>
        /// <example>
        /// {
        /// "AccessControlType" : "AllowedDomains",
        /// "Domains": ["domainA", "domainB", ...]
        /// }
        /// </example>
        /// <remarks>
        /// Deletes the specified domains from the list.
        /// </remarks>
        /// <param name="AccessControlType"></param>
        /// <param name="Domains"></param>
        /// <returns>
        /// No content
        /// </returns>
        IQuery DeleteFolderAccessControlDomains(AccessControlDomains accessControlDomains);
        
        /// <summary>
        /// Check if WebPop is required
        /// </summary>
        /// <param name="subdomain"></param>
        /// <param name="username"></param>
        /// <param name="singlePlane"></param>
        /// <returns>
        /// RequireWebPopResult
        /// </returns>
        IQuery<RequireWebPopResult> RequireWebPop(string subdomain, string username = null, bool singlePlane = false);
        
        /// <summary>
        /// Check if subdomain is required
        /// </summary>
        /// <param name="username"></param>
        /// <param name="singlePlane"></param>
        /// <returns>
        /// RequireSubdomainResult
        /// </returns>
        IQuery<RequireSubdomainResult> RequireSubdomain(string username, bool singlePlane = false);
        
        /// <summary>
        /// Find Subdomain
        /// </summary>
        /// <example>
        /// {
        /// "UsernameShort":"usernameShort",
        /// "Password":"pass",
        /// "EmployeeOnly":false
        /// }
        /// </example>
        /// <remarks>
        /// Find the user account information based on the short username
        /// </remarks>
        /// <param name="findSubdomainParams"></param>
        /// <param name="singlePlane"></param>
        /// <returns>
        /// FindSubdomainResult
        /// </returns>
        IQuery<FindSubdomainResult> FindSubdomain(FindSubdomainParams findSubdomainParams, bool singlePlane = false);
        
        /// <summary>
        /// Get Outlook Information
        /// </summary>
        /// <returns>
        /// OutlookInformation
        /// </returns>
        IQuery<OutlookInformation> GetOutlookInformation();
        
        /// <summary>
        /// Get SSO Info
        /// </summary>
        /// <param name="subdomain"></param>
        /// <returns>
        /// SSOInfo
        /// </returns>
        IQuery<SSOInfo> GetSSOInfo(string subdomain);
    }

    public class AccountsEntity : EntityBase, IAccountsEntity
    {
        public AccountsEntity (IShareFileClient client)
            : base (client, "Accounts")
        { }
        
        
        /// <summary>
        /// Get current Account
        /// </summary>
        /// <remarks>
        /// Retrieves information about the Account defined in the call subdomain
        /// </remarks>
        /// <returns>
        /// The subdomain account information
        /// </returns>
        public IQuery<Account> Get()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Account>(Client);
		    sfApiQuery.From("Accounts");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get current Account branding
        /// </summary>
        /// <remarks>
        /// Retrievs Branding information about the subdomain account.
        /// This operation does not require authentication.
        /// </remarks>
        /// <returns>
        /// Branding information for a given sharefile account
        /// </returns>
        public IQuery<Account> GetBranding()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Account>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("Branding");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Modify the Branding for this account
        /// </summary>
        /// <remarks>
        /// Modifies Branding information about the subdomain account.
        /// This operation requires authentication.
        /// </remarks>
        /// <returns>
        /// Branding information for a given sharefile account
        /// </returns>
        public IQuery<Account> UpdateBranding(Account account)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Account>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("Branding");
            sfApiQuery.Body = account;
            sfApiQuery.HttpMethod = "PATCH";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get List of current Account Employees
        /// </summary>
        /// <remarks>
        /// Retrives the list of Employees in the Account
        /// Employees are named users in the Account.
        /// </remarks>
        /// <returns>
        /// A Feed containing all Employees Contacts in the account
        /// </returns>
        public IQuery<ODataFeed<Contact>> GetEmployees()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Contact>>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("Employees");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get List of current Account Clients
        /// </summary>
        /// <remarks>
        /// Retrieves the list of Clients in the Account.
        /// Clients are restricted users of an Account, that can receive and send files
        /// to Employees, but have no other permissions besides basic sharing with Employees.
        /// </remarks>
        /// <returns>
        /// A Feed containing all Clients in the account
        /// </returns>
        public IQuery<ODataFeed<Contact>> GetClients()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Contact>>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("Clients");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get Account AddressBooks
        /// </summary>
        /// <remarks>
        /// Retrieves an address book from the account.
        /// Address Books are the contacts of Eployees and Clients, maintained on a personal or
        /// account-wide basis (shared).
        /// </remarks>
        /// <param name="type"></param>
        /// <param name="searchTerm"></param>
        /// <returns>
        /// A Feed of Contact objects representing the Address Book retrieved
        /// </returns>
        public IQuery<ODataFeed<Contact>> GetAddressBook(string type = "personal", string searchTerm = "")
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Contact>>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("AddressBook");
            sfApiQuery.QueryString("type", type);
            sfApiQuery.QueryString("searchTerm", searchTerm);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get Account Mobile Security Settings
        /// </summary>
        /// <remarks>
        /// Returns the Mobile device configuration settings for this account
        /// </remarks>
        /// <returns>
        /// The current mobile security configuration for this account
        /// </returns>
        public IQuery<MobileSecuritySettings> GetMobileSecuritySettings()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<MobileSecuritySettings>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("MobileSecuritySettings");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get Account Product Defaults
        /// </summary>
        /// <returns>
        /// Account defaults
        /// </returns>
        public IQuery<ProductDefaults> GetProductDefaults()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ProductDefaults>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("ProductDefaults");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get Account Preferences
        /// </summary>
        /// <returns>
        /// Account preferences
        /// </returns>
        public IQuery<AccountPreferences> GetPreferences()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<AccountPreferences>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("Preferences");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get Account Single Sign-On Configuration
        /// </summary>
        /// <remarks>
        /// Retrieve the Single Sign-on configuration for the Account
        /// </remarks>
        /// <param name="provider"></param>
        public IQuery<SSOAccountProvider> GetSSO(string provider = "saml")
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<SSOAccountProvider>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("SSO");
            sfApiQuery.QueryString("provider", provider);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Update Account Single Sign-On Configuration
        /// </summary>
        /// <example>
        /// {
        /// "LogoutUrl":"",
        /// "LoginUrl":"https://idp.com/signin",
        /// "IPRestrictions":"+all",
        /// "ForceSSO":true,
        /// "EntityID":"http://account.sf-api.com/saml/info",
        /// "SFEntityID":"http://idp.com/saml/info",
        /// "SPInitatedAuthContext":"exact",
        /// "SPInitatedAuthMethod":"urn:oasis:names:tc:SAML:2.0:ac:classes:PasswordProtectedTransport"
        /// }
        /// </example>
        /// <remarks>
        /// Modifies the Single Sign-on Configuration for this account.
        /// </remarks>
        /// <param name="sso"></param>
        /// <param name="provider"></param>
        public IQuery<SSOAccountProvider> UpdateSSO(SSOAccountProvider sso, string provider = "saml")
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<SSOAccountProvider>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("SSO");
            sfApiQuery.QueryString("provider", provider);
            sfApiQuery.Body = sso;
            sfApiQuery.HttpMethod = "PATCH";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get List of Accounts for User
        /// </summary>
        /// <example>
        /// {
        /// "password":"password"
        /// }
        /// </example>
        /// <remarks>
        /// Retrieve the list of Accounts associated with a given user
        /// All parameters to this call may be passed in the Post body as root JSON parameters, or in the URI -
        /// with the exception of password that must be provided in the POST body.
        /// This operation does not require authentication
        /// </remarks>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="employeesonly"></param>
        /// <param name="requirehomefolders"></param>
        /// <param name="singleplane"></param>
        /// <returns>
        /// The list of Accounts associated with this username/password.
        /// </returns>
        public IQuery<ODataFeed<Account>> GetByUser(ODataObject parameters, string username, bool employeesonly = false, bool requirehomefolders = false, bool singleplane = false)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Account>>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("GetByUser");
            parameters.AddProperty("username", username);
            parameters.AddProperty("employeesonly", employeesonly);
            parameters.AddProperty("requirehomefolders", requirehomefolders);
            parameters.AddProperty("singleplane", singleplane);
            sfApiQuery.Body = parameters;
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Email List of Accounts to User
        /// </summary>
        /// <remarks>
        /// Sends the list of accounts to the specified email address
        /// This operation does not require authentication
        /// </remarks>
        /// <param name="email"></param>
        public IQuery SendToEmail(string email)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("SendToEmail");
            sfApiQuery.QueryString("email", email);
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get the Login Access Control List of domains
        /// </summary>
        /// <remarks>
        /// Retrieve the list of domains that are allowed or disallowed to login.
        /// Whether the list is an allow or disallow list
        /// is configured by the AccessControlType property. The domain names are checked against the domains of all the
        /// email addresses of the user that attempts to log in to the Account.
        /// </remarks>
        /// <returns>
        /// The Login Access Control List of domains for the Account.
        /// </returns>
        public IQuery<AccessControlDomains> GetLoginAccessControlDomains()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<AccessControlDomains>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("LoginAccessControlDomains");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get the Folder Access Control List of domains
        /// </summary>
        /// <remarks>
        /// Retrieve the list of domains that are allowed or disallowed to have access to folders. Whether the list is an allow or disallow list
        /// is configured by the AccessControlType property.
        /// 
        /// The list blocks user access to folders by preventing adding a user to distribution groups or folders.
        /// The domain names are checked against the domains of all the email addresses of the user.
        /// This is an account-wide setting.
        /// </remarks>
        /// <returns>
        /// The Folder Access Control List of domains for the Account, e.g.
        /// 
        /// {
        /// "AccessControlType" : "AllowedDomains",
        /// "Domains": ["domainA", "domainB", ...]
        /// }
        /// </returns>
        public IQuery<AccessControlDomains> GetFolderAccessControlDomains()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<AccessControlDomains>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("FolderAccessControlDomains");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Create or replace the Login Access Control List of domains
        /// </summary>
        /// <example>
        /// {
        /// "AccessControlType" : "AllowedDomains",
        /// "Domains": ["domainA", "domainB", ...]
        /// }
        /// </example>
        /// <param name="AccessControlType"></param>
        /// <param name="Domains"></param>
        /// <returns>
        /// The new Login Access Control List of domains for the Account
        /// </returns>
        public IQuery<AccessControlDomains> CreateLoginAccessControlDomains(AccessControlDomains accessControlDomains)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<AccessControlDomains>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("LoginAccessControlDomains");
            sfApiQuery.Body = accessControlDomains;
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Create or replace the Folder Access Control List of domains
        /// </summary>
        /// <example>
        /// {
        /// "AccessControlType" : "AllowedDomains",
        /// "Domains": ["domainA", "domainB", ...]
        /// }
        /// </example>
        /// <param name="AccessControlType"></param>
        /// <param name="Domains"></param>
        /// <returns>
        /// The new Folder Access Control List of domains for the Account
        /// </returns>
        public IQuery<AccessControlDomains> CreateFolderAccessControlDomains(AccessControlDomains accessControlDomains)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<AccessControlDomains>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("FolderAccessControlDomains");
            sfApiQuery.Body = accessControlDomains;
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Update the Login Access Control List of domains
        /// </summary>
        /// <example>
        /// {
        /// "AccessControlType" : "AllowedDomains",
        /// "Domains": ["domainA", "domainB", ...]
        /// }
        /// </example>
        /// <remarks>
        /// Merges the specified domains with existing domains in the list, and/or updates the AccessControlType. One of the parameters needs to be specified.
        /// </remarks>
        /// <param name="AccessControlType"></param>
        /// <param name="Domains"></param>
        /// <returns>
        /// The updated Login Access Control List of domains for the Account
        /// </returns>
        public IQuery<AccessControlDomains> UpdateLoginAccessControlDomains(AccessControlDomains accessControlDomains)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<AccessControlDomains>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("LoginAccessControlDomains");
            sfApiQuery.Body = accessControlDomains;
            sfApiQuery.HttpMethod = "PATCH";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Update the Folder Access Control List of domains
        /// </summary>
        /// <example>
        /// {
        /// "AccessControlType" : "AllowedDomains",
        /// "Domains": ["domainA", "domainB", ...]
        /// }
        /// </example>
        /// <remarks>
        /// Merges the specified domains with existing domains in the list, and/or updates the AccessControlType. One of the parameters needs to be specified. It
        /// allows to add new domains to the list.
        /// </remarks>
        /// <param name="AccessControlType"></param>
        /// <param name="Domains"></param>
        /// <returns>
        /// The updated Folder Access Control List of domains for the Account
        /// </returns>
        public IQuery<AccessControlDomains> UpdateFolderAccessControlDomains(AccessControlDomains accessControlDomains)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<AccessControlDomains>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("FolderAccessControlDomains");
            sfApiQuery.Body = accessControlDomains;
            sfApiQuery.HttpMethod = "PATCH";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Delete domains from the Logins Access Control List of domains
        /// </summary>
        /// <example>
        /// {
        /// "AccessControlType" : "AllowedDomains",
        /// "Domains": ["domainA", "domainB", ...]
        /// }
        /// </example>
        /// <remarks>
        /// Deletes the specified domains from the list.
        /// </remarks>
        /// <param name="AccessControlType"></param>
        /// <param name="Domains"></param>
        /// <returns>
        /// No content
        /// </returns>
        public IQuery DeleteLoginAccessControlDomains(AccessControlDomains accessControlDomains)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("LoginAccessControlDomains");
            sfApiQuery.Body = accessControlDomains;
            sfApiQuery.HttpMethod = "DELETE";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Delete domains from the Folder Access Control List of domains
        /// </summary>
        /// <example>
        /// {
        /// "AccessControlType" : "AllowedDomains",
        /// "Domains": ["domainA", "domainB", ...]
        /// }
        /// </example>
        /// <remarks>
        /// Deletes the specified domains from the list.
        /// </remarks>
        /// <param name="AccessControlType"></param>
        /// <param name="Domains"></param>
        /// <returns>
        /// No content
        /// </returns>
        public IQuery DeleteFolderAccessControlDomains(AccessControlDomains accessControlDomains)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("FolderAccessControlDomains");
            sfApiQuery.Body = accessControlDomains;
            sfApiQuery.HttpMethod = "DELETE";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Check if WebPop is required
        /// </summary>
        /// <param name="subdomain"></param>
        /// <param name="username"></param>
        /// <param name="singlePlane"></param>
        /// <returns>
        /// RequireWebPopResult
        /// </returns>
        public IQuery<RequireWebPopResult> RequireWebPop(string subdomain, string username = null, bool singlePlane = false)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<RequireWebPopResult>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("RequireWebPop");
            sfApiQuery.QueryString("subdomain", subdomain);
            sfApiQuery.QueryString("username", username);
            sfApiQuery.QueryString("singlePlane", singlePlane);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Check if subdomain is required
        /// </summary>
        /// <param name="username"></param>
        /// <param name="singlePlane"></param>
        /// <returns>
        /// RequireSubdomainResult
        /// </returns>
        public IQuery<RequireSubdomainResult> RequireSubdomain(string username, bool singlePlane = false)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<RequireSubdomainResult>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("RequireSubdomain");
            sfApiQuery.QueryString("username", username);
            sfApiQuery.QueryString("singlePlane", singlePlane);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Find Subdomain
        /// </summary>
        /// <example>
        /// {
        /// "UsernameShort":"usernameShort",
        /// "Password":"pass",
        /// "EmployeeOnly":false
        /// }
        /// </example>
        /// <remarks>
        /// Find the user account information based on the short username
        /// </remarks>
        /// <param name="findSubdomainParams"></param>
        /// <param name="singlePlane"></param>
        /// <returns>
        /// FindSubdomainResult
        /// </returns>
        public IQuery<FindSubdomainResult> FindSubdomain(FindSubdomainParams findSubdomainParams, bool singlePlane = false)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<FindSubdomainResult>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("FindSubdomain");
            sfApiQuery.QueryString("singlePlane", singlePlane);
            sfApiQuery.Body = findSubdomainParams;
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get Outlook Information
        /// </summary>
        /// <returns>
        /// OutlookInformation
        /// </returns>
        public IQuery<OutlookInformation> GetOutlookInformation()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<OutlookInformation>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("OutlookInformation");
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get SSO Info
        /// </summary>
        /// <param name="subdomain"></param>
        /// <returns>
        /// SSOInfo
        /// </returns>
        public IQuery<SSOInfo> GetSSOInfo(string subdomain)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<SSOInfo>(Client);
		    sfApiQuery.From("Accounts");
		    sfApiQuery.Action("SSOInfo");
            sfApiQuery.QueryString("subdomain", subdomain);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
    }
}