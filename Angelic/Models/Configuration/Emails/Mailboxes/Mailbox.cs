using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Integrations;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails.Mailboxes;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record Mailbox
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("server", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Server { get; set; } 

    [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; } 

    [JsonProperty("smtpaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SmtpAddress { get; set; } 

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("azureemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureEmail { get; set; } 

    [JsonProperty("display_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayAddress { get; set; } 

    [JsonProperty("google_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GoogleEmail { get; set; } 

    [JsonProperty("inbound_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InboundMethod { get; set; } 

    [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? HaloIntegratorLastSync { get; set; } 

    [JsonProperty("halointegrator_outlook_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? HaloIntegratorOutlookLastSync { get; set; } 

    [JsonProperty("halointegrator_outlook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HaloIntegratorOutlook { get; set; } 

    [JsonProperty("halointegrator_outlook_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloIntegratorOutlookLastError { get; set; } 

    [JsonProperty("password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Password { get; set; } 

    [JsonProperty("usetls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseTls { get; set; } 

    [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestrictionType { get; set; } 

    [JsonProperty("restrictto_org_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestrictToOrgId { get; set; } 

    [JsonProperty("restrictto_org_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RestrictToOrgName { get; set; } 

    [JsonProperty("restrictto_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestrictToDepartmentId { get; set; } 

    [JsonProperty("restrictto_department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RestrictToDepartmentName { get; set; } 

    [JsonProperty("restrictto_team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestrictToTeamId { get; set; } 

    [JsonProperty("restrictto_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RestrictToTeamName { get; set; } 

    [JsonProperty("exchangemailboxdisplayname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ExchangeMailboxDisplayName { get; set; } 

    [JsonProperty("exchangemailboxfqdn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ExchangeMailboxFqdn { get; set; } 

    [JsonProperty("harddeletereadmessages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HardDeleteReadMessages { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketTypeId { get; set; } 

    [JsonProperty("popport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PopPort { get; set; } 

    [JsonProperty("smtpserver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SmtpServer { get; set; } 

    [JsonProperty("smtpusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SmtpUsername { get; set; } 

    [JsonProperty("smtppassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SmtpPassword { get; set; } 

    [JsonProperty("smtpport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SmtpPort { get; set; } 

    [JsonProperty("smtpusetls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SmtpUseTls { get; set; } 

    [JsonProperty("usesmtpforazuremailbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseSmtpForAzureMailbox { get; set; } 

    [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MessageGroupId { get; set; } 

    [JsonProperty("smtpdisplayname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SmtpDisplayName { get; set; } 

    [JsonProperty("syncaddressbook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncAddressBook { get; set; } 

    [JsonProperty("dontsendack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontSendAck { get; set; } 

    [JsonProperty("defaultuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultUser { get; set; } 

    [JsonProperty("defaultuserid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultUserid { get; set; } 

    [JsonProperty("changeseq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChangeSeq { get; set; } 

    [JsonProperty("accesstoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccessToken { get; set; } 

    [JsonProperty("accesstokenexpirydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? AccessTokenExpiryDate { get; set; } 

    [JsonProperty("refreshtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RefreshToken { get; set; } 

    [JsonProperty("refreshtokenexpirydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? RefreshTokenExpiryDate { get; set; } 

    [JsonProperty("tokendestructiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? TokenDestructionDate { get; set; } 

    [JsonProperty("deleteditemsfolder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DeletedItemsFolder { get; set; } 

    [JsonProperty("tlstype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TlsType { get; set; } 

    [JsonProperty("ewsusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EwsUsername { get; set; } 

    [JsonProperty("azureappid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureAppid { get; set; } 

    [JsonProperty("azuretenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureTenant { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientSecret { get; set; } 

    [JsonProperty("new_azure_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAzureAccessToken { get; set; } 

    [JsonProperty("new_azure_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAzureRefreshToken { get; set; } 

    [JsonProperty("oauth_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OauthCode { get; set; } 

    [JsonProperty("azureredirecturi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureRedirectUri { get; set; } 

    [JsonProperty("_exchangecodefortoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ExchangeCodeForToken { get; set; } 

    [JsonProperty("_testonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TestOnly { get; set; } 

    [JsonProperty("signature_overrides", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MailboxTechnician>? SignatureOverrides { get; set; } 

    [JsonProperty("_isglobalsmtp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsGlobalSmtp { get; set; } 

    [JsonProperty("new_google_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewGoogleAccessToken { get; set; } 

    [JsonProperty("new_google_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewGoogleRefreshToken { get; set; } 

    [JsonProperty("google_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? GoogleTokenExpiry { get; set; } 

    [JsonProperty("google_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GoogleRedirect { get; set; } 

    [JsonProperty("_getgoogletoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? GetGoogleToken { get; set; } 

    [JsonProperty("google_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GoogleCode { get; set; } 

    [JsonProperty("azure_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AzureAuthorized { get; set; } 

    [JsonProperty("google_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? GoogleAuthorized { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("shared_mailbox_emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SharedMailboxEmailAddress { get; set; } 

    [JsonProperty("google_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GoogleType { get; set; } 

    [JsonProperty("graph_host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GraphHost { get; set; } 

    [JsonProperty("azuredatecutoff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? AzureDateCutOff { get; set; } 

    [JsonProperty("azureleavemailininbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AzureLeaveMailInInbox { get; set; } 

    [JsonProperty("imapdatecutoff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ImapDateCutoff { get; set; } 

    [JsonProperty("imapleavemailininbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ImapLeaveMailInInbox { get; set; } 

    [JsonProperty("azure_subscription_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureSubscriptionId { get; set; } 

    [JsonProperty("azure_subscription_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? AzureSubscriptionExpiry { get; set; } 

    [JsonProperty("azure_subscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AzureSubscribed { get; set; } 

    [JsonProperty("new_azure_subscription_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAzureSubscriptionSecret { get; set; } 

    [JsonProperty("_webhookaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public WebhookSubscriptionAction? WebhookAction { get; set; } 

    [JsonProperty("ignore_cc_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IgnoreCcEmails { get; set; } 

    [JsonProperty("accept_auto_replies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AcceptAutoReplies { get; set; } 

    [JsonProperty("allow_email_hashtags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowEmailHashtags { get; set; } 

    [JsonProperty("site_prefix_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SitePrefixMatching { get; set; } 

    [JsonProperty("site_wildcard_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SiteWildcardMatching { get; set; } 

    [JsonProperty("site_domain_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SiteDomainMatching { get; set; } 

    [JsonProperty("site_tocc_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SiteToCcMatching { get; set; } 

    [JsonProperty("unmatched_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UnmatchedUsers { get; set; } 

    [JsonProperty("newuser_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewUserDefaultSite { get; set; } 

    [JsonProperty("newuser_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewUserDefaultSiteName { get; set; } 

    [JsonProperty("newuser_send_welcome_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewUserSendWelcomeEmail { get; set; } 

    [JsonProperty("newuser_send_ack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewUserSendAck { get; set; } 

    [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloIntegratorLastError { get; set; } 

    [JsonProperty("azure_authority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AzureAuthority { get; set; } 

    [JsonProperty("defaultusersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultUserSite { get; set; } 

    [JsonProperty("safe_attachment_policy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SafeAttachmentPolicy { get; set; } 

    [JsonProperty("safe_attachment_placeholder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SafeAttachmentPlaceholder { get; set; } 

    [JsonProperty("creationdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreationDate { get; set; } 

    [JsonProperty("dontimportbeforecreation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontImportBeforeCreation { get; set; } 

    [JsonProperty("azure_authentication_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AzureAuthenticationType { get; set; } 

    [JsonProperty("_confirmmanagedidentitysetup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ConfirmManagedIdentitySetup { get; set; } 

    [JsonProperty("_confirmclientcredentialssetup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ConfirmClientCredentialsSetup { get; set; } 

    [JsonProperty("stopnewticketsviaemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? StopNewTicketsViaEmail { get; set; } 

    [JsonProperty("_confirmropcssetup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ConfirmRopcsSetup { get; set; } 

    [JsonProperty("showinfromaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowInFromAddress { get; set; } 

    [JsonProperty("mappings_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? MappingsUser { get; set; } 

}