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
	public class AccountPreferences : ODataObject 
	{
		public bool? EnableViewOnly { get; set; }

		public bool? EnableWatermarkOnViewOnly { get; set; }

		public bool? AllowProactiveNotifications { get; set; }

		public bool? ShowUserListToClients { get; set; }

		public bool? RequireLoginOnDownload { get; set; }

		public bool? RequireLoginByDefault { get; set; }

		public bool? EnableClientSend { get; set; }

		public bool? EnableThumbnails { get; set; }

		public bool? EnableSSO { get; set; }

		public int? VirusStrictness { get; set; }

		public bool? EnableSfAdi { get; set; }

		public bool? EnableMultipleZones { get; set; }

		public Zone DefaultZone { get; set; }

		public bool? EnableVersioning { get; set; }

		public string SystemType { get; set; }

		public bool? EnableSync { get; set; }

		public string SystemName { get; set; }

		public string HomeScreenName { get; set; }

		public bool? ShowTermsCheckbox { get; set; }

		public string TermsCheckboxText { get; set; }

		public int? TermsCheckboxStrictness { get; set; }

		public bool? RequireCompanyNameWithUserInfo { get; set; }

		public bool? EnableEditor { get; set; }

		public int? ShareIDMaxExpirationDays { get; set; }

		public bool? AdminIsSuperUser { get; set; }

		public bool? ShowFolderAccessList { get; set; }

		public bool? FromEmailIsShareFile { get; set; }

		public bool? UseAlternateSMTP { get; set; }

		public bool? ShowPasswordInEmail { get; set; }

		public string EmailPasswordText { get; set; }

		public bool? EnableSelfNotificationsUpload { get; set; }

		public bool? EnableSelfNotificationsDownload { get; set; }

		public bool? EnableUploadShareIDReceipt { get; set; }

		public int? DefaultConsolidatedNotificationInterval { get; set; }

		public int? ExpirationDays { get; set; }

		public string DefaultSortField { get; set; }

		public string DefaultSortOrder { get; set; }

		public bool? DefaultIsVersioned { get; set; }

		public int? DefaultMaxVersions { get; set; }

		public string ViewOnlyWatermarkText { get; set; }

		public bool? EnableDocViewerPrinting { get; set; }

		public bool? EnableWatermarkedDownloads { get; set; }

		public bool? EnableCaseSensitivePasswords { get; set; }

		public bool? EnableTwoFactorAuth { get; set; }

		public int? LoginFailMaxAttempts { get; set; }

		public int? LoginFailLockoutSecs { get; set; }

		public string IPRestrictions { get; set; }

		public int? InactiveTimeoutMins { get; set; }

		public int? OAuth2RefreshTokenLifetimeMinutes { get; set; }

		public string PasswordRegEx { get; set; }

		public string PasswordRegExFormula { get; set; }

		public string PasswordRegExDescription { get; set; }

		public bool? EnableActivationLinks { get; set; }

		public bool? IsFINRA { get; set; }

		public bool? EnableOAuth { get; set; }

		public bool EnableQandA { get; set; }

		public bool? EnableQandATextInNotifications { get; set; }

		public SafeEnum<UXMode> UXMode { get; set; }

		public int? IndustryCode { get; set; }

		public int PasswordMaxAgeDays { get; set; }

		public int PasswordHistoryCount { get; set; }

		public int MinimumLength { get; set; }

		public bool AlphaRequired { get; set; }

		public bool CaseRequired { get; set; }

		public bool NumericRequired { get; set; }

		public bool SpecialRequired { get; set; }

		public string AllowedSpecialCharacters { get; set; }

		public bool? EnableWebDAV { get; set; }

		public bool? EnableFTP { get; set; }

		public bool? EnableSFTP { get; set; }

		public string VDRDocViewerURL { get; set; }

		public bool? EnableSMBConnectorForAccount { get; set; }

		public string AccountID { get; set; }

	}
}