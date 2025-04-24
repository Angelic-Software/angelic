using System.CodeDom.Compiler;
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
    public string? Display_address { get; set; } 

    [JsonProperty("google_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Google_email { get; set; } 

    [JsonProperty("inbound_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inbound_method { get; set; } 

    [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Halointegrator_lastsync { get; set; } 

    [JsonProperty("halointegrator_outlook_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Halointegrator_outlook_lastsync { get; set; } 

    [JsonProperty("halointegrator_outlook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Halointegrator_outlook { get; set; } 

    [JsonProperty("halointegrator_outlook_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halointegrator_outlook_lasterror { get; set; } 

    [JsonProperty("password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Password { get; set; } 

    [JsonProperty("usetls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Usetls { get; set; } 

    [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Restriction_type { get; set; } 

    [JsonProperty("restrictto_org_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Restrictto_org_id { get; set; } 

    [JsonProperty("restrictto_org_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Restrictto_org_name { get; set; } 

    [JsonProperty("restrictto_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Restrictto_department_id { get; set; } 

    [JsonProperty("restrictto_department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Restrictto_department_name { get; set; } 

    [JsonProperty("restrictto_team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Restrictto_team_id { get; set; } 

    [JsonProperty("restrictto_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Restrictto_team_name { get; set; } 

    [JsonProperty("exchangemailboxdisplayname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Exchangemailboxdisplayname { get; set; } 

    [JsonProperty("exchangemailboxfqdn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Exchangemailboxfqdn { get; set; } 

    [JsonProperty("harddeletereadmessages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Harddeletereadmessages { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tickettype_id { get; set; } 

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
    public int? Messagegroup_id { get; set; } 

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
    public string? New_client_secret { get; set; } 

    [JsonProperty("new_azure_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_azure_access_token { get; set; } 

    [JsonProperty("new_azure_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_azure_refresh_token { get; set; } 

    [JsonProperty("oauth_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Oauth_code { get; set; } 

    [JsonProperty("azureredirecturi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Azureredirecturi { get; set; } 

    [JsonProperty("_exchangecodefortoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _exchangecodefortoken { get; set; } 

    [JsonProperty("_testonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _testonly { get; set; } 

    [JsonProperty("signature_overrides", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MailboxTechnician>? Signature_overrides { get; set; } 

    [JsonProperty("_isglobalsmtp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isglobalsmtp { get; set; } 

    [JsonProperty("new_google_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_google_access_token { get; set; } 

    [JsonProperty("new_google_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_google_refresh_token { get; set; } 

    [JsonProperty("google_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Google_token_expiry { get; set; } 

    [JsonProperty("google_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Google_redirect { get; set; } 

    [JsonProperty("_getgoogletoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _getgoogletoken { get; set; } 

    [JsonProperty("google_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Google_code { get; set; } 

    [JsonProperty("azure_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Azure_authorized { get; set; } 

    [JsonProperty("google_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Google_authorized { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("shared_mailbox_emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Shared_mailbox_emailaddress { get; set; } 

    [JsonProperty("google_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Google_type { get; set; } 

    [JsonProperty("graph_host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Graph_host { get; set; } 

    [JsonProperty("azuredatecutoff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Azuredatecutoff { get; set; } 

    [JsonProperty("azureleavemailininbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Azureleavemailininbox { get; set; } 

    [JsonProperty("imapdatecutoff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Imapdatecutoff { get; set; } 

    [JsonProperty("imapleavemailininbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Imapleavemailininbox { get; set; } 

    [JsonProperty("azure_subscription_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Azure_subscription_id { get; set; } 

    [JsonProperty("azure_subscription_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Azure_subscription_expiry { get; set; } 

    [JsonProperty("azure_subscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Azure_subscribed { get; set; } 

    [JsonProperty("new_azure_subscription_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_azure_subscription_secret { get; set; } 

    [JsonProperty("_webhookaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public WebhookSubscriptionAction? _webhookaction { get; set; } 

    [JsonProperty("ignore_cc_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ignore_cc_emails { get; set; } 

    [JsonProperty("accept_auto_replies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Accept_auto_replies { get; set; } 

    [JsonProperty("allow_email_hashtags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allow_email_hashtags { get; set; } 

    [JsonProperty("site_prefix_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Site_prefix_matching { get; set; } 

    [JsonProperty("site_wildcard_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Site_wildcard_matching { get; set; } 

    [JsonProperty("site_domain_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Site_domain_matching { get; set; } 

    [JsonProperty("site_tocc_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Site_tocc_matching { get; set; } 

    [JsonProperty("unmatched_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Unmatched_users { get; set; } 

    [JsonProperty("newuser_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Newuser_default_site { get; set; } 

    [JsonProperty("newuser_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Newuser_default_site_name { get; set; } 

    [JsonProperty("newuser_send_welcome_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Newuser_send_welcome_email { get; set; } 

    [JsonProperty("newuser_send_ack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Newuser_send_ack { get; set; } 

    [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halointegrator_lasterror { get; set; } 

    [JsonProperty("azure_authority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Azure_authority { get; set; } 

    [JsonProperty("defaultusersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Defaultusersite { get; set; } 

    [JsonProperty("safe_attachment_policy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Safe_attachment_policy { get; set; } 

    [JsonProperty("safe_attachment_placeholder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Safe_attachment_placeholder { get; set; } 

    [JsonProperty("creationdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Creationdate { get; set; } 

    [JsonProperty("dontimportbeforecreation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontimportbeforecreation { get; set; } 

    [JsonProperty("azure_authentication_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Azure_authentication_type { get; set; } 

    [JsonProperty("_confirmmanagedidentitysetup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _confirmmanagedidentitysetup { get; set; } 

    [JsonProperty("_confirmclientcredentialssetup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _confirmclientcredentialssetup { get; set; } 

    [JsonProperty("stopnewticketsviaemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Stopnewticketsviaemail { get; set; } 

    [JsonProperty("_confirmropcssetup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _confirmropcssetup { get; set; } 

    [JsonProperty("showinfromaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showinfromaddress { get; set; } 

    [JsonProperty("mappings_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? Mappings_user { get; set; } 

}