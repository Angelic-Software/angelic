using System.CodeDom.Compiler;
using Angelic.Configuration.Integrations;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Mailbox
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
    public string? Smtpaddress { get; set; } 

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("azureemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Azureemail { get; set; } 

    [JsonProperty("display_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayAddress { get; set; } 

    [JsonProperty("google_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GoogleEmail { get; set; } 

    [JsonProperty("inbound_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InboundMethod { get; set; } 

    [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? HalointegratorLastsync { get; set; } 

    [JsonProperty("halointegrator_outlook_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? HalointegratorOutlookLastsync { get; set; } 

    [JsonProperty("halointegrator_outlook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HalointegratorOutlook { get; set; } 

    [JsonProperty("halointegrator_outlook_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HalointegratorOutlookLasterror { get; set; } 

    [JsonProperty("password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Password { get; set; } 

    [JsonProperty("usetls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Usetls { get; set; } 

    [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestrictionType { get; set; } 

    [JsonProperty("restrictto_org_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestricttoOrgId { get; set; } 

    [JsonProperty("restrictto_org_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RestricttoOrgName { get; set; } 

    [JsonProperty("restrictto_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestricttoDepartmentId { get; set; } 

    [JsonProperty("restrictto_department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RestricttoDepartmentName { get; set; } 

    [JsonProperty("restrictto_team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestricttoTeamId { get; set; } 

    [JsonProperty("restrictto_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RestricttoTeamName { get; set; } 

    [JsonProperty("exchangemailboxdisplayname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Exchangemailboxdisplayname { get; set; } 

    [JsonProperty("exchangemailboxfqdn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Exchangemailboxfqdn { get; set; } 

    [JsonProperty("harddeletereadmessages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Harddeletereadmessages { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TickettypeId { get; set; } 

    [JsonProperty("popport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Popport { get; set; } 

    [JsonProperty("smtpserver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Smtpserver { get; set; } 

    [JsonProperty("smtpusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Smtpusername { get; set; } 

    [JsonProperty("smtppassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Smtppassword { get; set; } 

    [JsonProperty("smtpport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Smtpport { get; set; } 

    [JsonProperty("smtpusetls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Smtpusetls { get; set; } 

    [JsonProperty("usesmtpforazuremailbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Usesmtpforazuremailbox { get; set; } 

    [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MessagegroupId { get; set; } 

    [JsonProperty("smtpdisplayname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Smtpdisplayname { get; set; } 

    [JsonProperty("syncaddressbook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Syncaddressbook { get; set; } 

    [JsonProperty("dontsendack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontsendack { get; set; } 

    [JsonProperty("defaultuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Defaultuser { get; set; } 

    [JsonProperty("defaultuserid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defaultuserid { get; set; } 

    [JsonProperty("changeseq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Changeseq { get; set; } 

    [JsonProperty("accesstoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Accesstoken { get; set; } 

    [JsonProperty("accesstokenexpirydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Accesstokenexpirydate { get; set; } 

    [JsonProperty("refreshtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Refreshtoken { get; set; } 

    [JsonProperty("refreshtokenexpirydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Refreshtokenexpirydate { get; set; } 

    [JsonProperty("tokendestructiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Tokendestructiondate { get; set; } 

    [JsonProperty("deleteditemsfolder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Deleteditemsfolder { get; set; } 

    [JsonProperty("tlstype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tlstype { get; set; } 

    [JsonProperty("ewsusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ewsusername { get; set; } 

    [JsonProperty("azureappid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Azureappid { get; set; } 

    [JsonProperty("azuretenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Azuretenant { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientSecret { get; set; } 

    [JsonProperty("new_azure_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAzureAccessToken { get; set; } 

    [JsonProperty("new_azure_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAzureRefreshToken { get; set; } 

    [JsonProperty("oauth_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OauthCode { get; set; } 

    [JsonProperty("azureredirecturi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Azureredirecturi { get; set; } 

    [JsonProperty("_exchangecodefortoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Exchangecodefortoken { get; set; } 

    [JsonProperty("_testonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Testonly { get; set; } 

    [JsonProperty("signature_overrides", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MailboxTechnician>? SignatureOverrides { get; set; } 

    [JsonProperty("_isglobalsmtp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isglobalsmtp { get; set; } 

    [JsonProperty("new_google_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewGoogleAccessToken { get; set; } 

    [JsonProperty("new_google_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewGoogleRefreshToken { get; set; } 

    [JsonProperty("google_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? GoogleTokenExpiry { get; set; } 

    [JsonProperty("google_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GoogleRedirect { get; set; } 

    [JsonProperty("_getgoogletoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Getgoogletoken { get; set; } 

    [JsonProperty("google_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GoogleCode { get; set; } 

    [JsonProperty("azure_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AzureAuthorized { get; set; } 

    [JsonProperty("google_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? GoogleAuthorized { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("shared_mailbox_emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SharedMailboxEmailaddress { get; set; } 

    [JsonProperty("google_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GoogleType { get; set; } 

    [JsonProperty("graph_host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GraphHost { get; set; } 

    [JsonProperty("azuredatecutoff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Azuredatecutoff { get; set; } 

    [JsonProperty("azureleavemailininbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Azureleavemailininbox { get; set; } 

    [JsonProperty("imapdatecutoff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Imapdatecutoff { get; set; } 

    [JsonProperty("imapleavemailininbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Imapleavemailininbox { get; set; } 

    [JsonProperty("azure_subscription_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureSubscriptionId { get; set; } 

    [JsonProperty("azure_subscription_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? AzureSubscriptionExpiry { get; set; } 

    [JsonProperty("azure_subscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AzureSubscribed { get; set; } 

    [JsonProperty("new_azure_subscription_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAzureSubscriptionSecret { get; set; } 

    [JsonProperty("_webhookaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public WebhookSubscriptionAction? Webhookaction { get; set; } 

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
    public bool? SiteToccMatching { get; set; } 

    [JsonProperty("unmatched_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UnmatchedUsers { get; set; } 

    [JsonProperty("newuser_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewuserDefaultSite { get; set; } 

    [JsonProperty("newuser_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewuserDefaultSiteName { get; set; } 

    [JsonProperty("newuser_send_welcome_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewuserSendWelcomeEmail { get; set; } 

    [JsonProperty("newuser_send_ack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewuserSendAck { get; set; } 

    [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HalointegratorLasterror { get; set; } 

    [JsonProperty("azure_authority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AzureAuthority { get; set; } 

    [JsonProperty("defaultusersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Defaultusersite { get; set; } 

    [JsonProperty("safe_attachment_policy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SafeAttachmentPolicy { get; set; } 

    [JsonProperty("safe_attachment_placeholder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SafeAttachmentPlaceholder { get; set; } 

    [JsonProperty("creationdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Creationdate { get; set; } 

    [JsonProperty("dontimportbeforecreation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontimportbeforecreation { get; set; } 

    [JsonProperty("azure_authentication_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AzureAuthenticationType { get; set; } 

    [JsonProperty("_confirmmanagedidentitysetup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Confirmmanagedidentitysetup { get; set; } 

    [JsonProperty("_confirmclientcredentialssetup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Confirmclientcredentialssetup { get; set; } 

    [JsonProperty("stopnewticketsviaemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Stopnewticketsviaemail { get; set; } 

    [JsonProperty("_confirmropcssetup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Confirmropcssetup { get; set; } 

    [JsonProperty("showinfromaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showinfromaddress { get; set; } 

    [JsonProperty("mappings_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? MappingsUser { get; set; } 

}