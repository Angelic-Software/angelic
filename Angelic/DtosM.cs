using System.CodeDom.Compiler;
using Angelic.Dtos;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MYOBDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("isdesktop", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isdesktop { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("company_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Company_url { get; set; } 

        [JsonProperty("company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Company_id { get; set; } 

        [JsonProperty("company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Company_name { get; set; } 

        [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Code { get; set; } 

        [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_client_secret { get; set; } 

        [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _exchangecode { get; set; } 

        [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Authorized { get; set; } 

        [JsonProperty("newmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newmethod { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_id { get; set; } 

        [JsonProperty("defaulttaxcodeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaulttaxcodeid { get; set; } 

        [JsonProperty("defaulttaxcodename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaulttaxcodename { get; set; } 

        [JsonProperty("clienttoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clienttoplevel { get; set; } 

        [JsonProperty("defaultitemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultitemgroup { get; set; } 

        [JsonProperty("defaultsalesaccountid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultsalesaccountid { get; set; } 

        [JsonProperty("defaultsalesaccountname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultsalesaccountname { get; set; } 

        [JsonProperty("defaultexpenseaccountid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultexpenseaccountid { get; set; } 

        [JsonProperty("defaultexpenseaccountname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultexpenseaccountname { get; set; } 

        [JsonProperty("enablesync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablesync { get; set; } 

        [JsonProperty("syncentities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Syncentities { get; set; } 

        [JsonProperty("showmessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showmessage { get; set; } 

        [JsonProperty("defaultinvoiceitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultinvoiceitem { get; set; } 

        [JsonProperty("defaultorderitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultorderitem { get; set; } 

        [JsonProperty("suppliertoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Suppliertoplevel { get; set; } 

        [JsonProperty("suppliernamefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Suppliernamefield { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_password { get; set; } 

        [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_top_level_name { get; set; } 

        [JsonProperty("item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_group_name { get; set; } 

        [JsonProperty("supplier_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_top_level_name { get; set; } 

        [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Sync_entities_list { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_refresh_token { get; set; } 

        [JsonProperty("_disconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _disconnect { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Client_mappings { get; set; } 

        [JsonProperty("supplier_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Supplier_mappings { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailCampaign
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("created_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_datetime { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; } 

        [JsonProperty("status_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status_desc { get; set; } 

        [JsonProperty("sent_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Sent_datetime { get; set; } 

        [JsonProperty("emails_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Emails_sent { get; set; } 

        [JsonProperty("halo_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halo_created { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("distribution_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Distribution_list { get; set; } 

        [JsonProperty("mailbox_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailbox_from { get; set; } 

        [JsonProperty("mailbox_replyto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mailbox_replyto { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type_name { get; set; } 

        [JsonProperty("distribution_list_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Distribution_list_name { get; set; } 

        [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? External_links { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? New_external_link { get; set; } 

        [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_thirdparty_id { get; set; } 

        [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _match_integration_id { get; set; } 

        [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_integration_name { get; set; } 

        [JsonProperty("mailchimp_campaign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MailchimpCampaign? Mailchimp_campaign { get; set; } 

        [JsonProperty("recipients_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Recipients_count { get; set; } 

        [JsonProperty("create_in", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Create_in { get; set; } 

        [JsonProperty("mailchimp_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mailchimp_list { get; set; } 

        [JsonProperty("mailchimp_sent_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MailchimpSentTo>? Mailchimp_sent_to { get; set; } 

        [JsonProperty("emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MailCampaignEmail>? Emails { get; set; } 

        [JsonProperty("marketing_unsubscribes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MarketingUnsubscribe>? Marketing_unsubscribes { get; set; } 

        [JsonProperty("unsubscribe_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Unsubscribe_rate { get; set; } 

        [JsonProperty("total_unsubscribes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Total_unsubscribes { get; set; } 

        [JsonProperty("total_opens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Total_opens { get; set; } 

        [JsonProperty("unique_open_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Unique_open_rate { get; set; } 

        [JsonProperty("total_clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Total_clicks { get; set; } 

        [JsonProperty("click_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Click_rate { get; set; } 

        [JsonProperty("top_clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TopLinkClick>? Top_clicks { get; set; } 

        [JsonProperty("all_clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MarketingOpen>? All_clicks { get; set; } 

        [JsonProperty("all_opens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MarketingOpen>? All_opens { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("_start_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _start_code { get; set; } 

        [JsonProperty("_start_campaign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _start_campaign { get; set; } 

        [JsonProperty("_start_campaign_confirmed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _start_campaign_confirmed { get; set; } 

        [JsonProperty("_cancel_campaign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _cancel_campaign { get; set; } 

        [JsonProperty("_end_campaign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _end_campaign { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailCampaignEmail
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("mailcampaign_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailcampaign_id { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("body_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Body_html { get; set; } 

        [JsonProperty("body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Body { get; set; } 

        [JsonProperty("date_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_sent { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; } 

        [JsonProperty("send_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Send_type { get; set; } 

        [JsonProperty("send_at_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Send_at_datetime { get; set; } 

        [JsonProperty("send_at_timeafter_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Send_at_timeafter_days { get; set; } 

        [JsonProperty("send_at_timeafter_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Send_at_timeafter_hours { get; set; } 

        [JsonProperty("send_at_timeafter_mins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Send_at_timeafter_mins { get; set; } 

        [JsonProperty("status_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status_desc { get; set; } 

        [JsonProperty("design", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public HtmlDesign? Design { get; set; } 

    }

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

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailboxAddress
    {
        [JsonProperty("route", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Route { get; set; } 

        [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Address { get; set; } 

        [JsonProperty("localPart", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LocalPart { get; set; } 

        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Domain { get; set; } 

        [JsonProperty("isInternational", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsInternational { get; set; } 

        [JsonProperty("encoding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Encoding? Encoding { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailboxTechnician
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailbox_id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Signature { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum MailboxType
    {

        _0 = 0,

        _1 = 1,

        _2 = 2,

        _3 = 3,

        _4 = 4,

        _5 = 5,

        _6 = 6,

        _7 = 7,

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailchimpAb_Split_Opts
    {
        [JsonProperty("split_test", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Split_test { get; set; } 

        [JsonProperty("pick_winner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pick_winner { get; set; } 

        [JsonProperty("wait_units", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Wait_units { get; set; } 

        [JsonProperty("wait_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Wait_time { get; set; } 

        [JsonProperty("split_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Split_size { get; set; } 

        [JsonProperty("from_name_a", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? From_name_a { get; set; } 

        [JsonProperty("from_name_b", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? From_name_b { get; set; } 

        [JsonProperty("reply_email_a", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Reply_email_a { get; set; } 

        [JsonProperty("reply_email_b", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Reply_email_b { get; set; } 

        [JsonProperty("subject_a", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject_a { get; set; } 

        [JsonProperty("subject_b", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject_b { get; set; } 

        [JsonProperty("send_time_a", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Send_time_a { get; set; } 

        [JsonProperty("send_time_b", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Send_time_b { get; set; } 

        [JsonProperty("send_time_winner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Send_time_winner { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailchimpCampaign
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("web_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Web_id { get; set; } 

        [JsonProperty("parent_campaign_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Parent_campaign_id { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("create_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Create_time { get; set; } 

        [JsonProperty("archive_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Archive_url { get; set; } 

        [JsonProperty("long_archive_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Long_archive_url { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status { get; set; } 

        [JsonProperty("emails_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Emails_sent { get; set; } 

        [JsonProperty("send_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Send_time { get; set; } 

        [JsonProperty("content_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Content_type { get; set; } 

        [JsonProperty("needs_block_refresh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Needs_block_refresh { get; set; } 

        [JsonProperty("resendable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Resendable { get; set; } 

        [JsonProperty("recipients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MailchimpRecipients? Recipients { get; set; } 

        [JsonProperty("settings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MailchimpSettings? Settings { get; set; } 

        [JsonProperty("variate_settings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MailchimpVariate_Settings? Variate_settings { get; set; } 

        [JsonProperty("tracking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MailchimpTracking? Tracking { get; set; } 

        [JsonProperty("rss_opts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MailchimpRss_Opts? Rss_opts { get; set; } 

        [JsonProperty("ab_split_opts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MailchimpAb_Split_Opts? Ab_split_opts { get; set; } 

        [JsonProperty("social_card", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MailchimpSocial_Card? Social_card { get; set; } 

        [JsonProperty("report_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MailchimpReport_Summary? Report_summary { get; set; } 

        [JsonProperty("delivery_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MailchimpDelivery_Status? Delivery_status { get; set; } 

        [JsonProperty("_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Mailchimp_Links>? _links { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailchimpCapsule
    {
        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Notes { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailchimpCombination
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("subject_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Subject_line { get; set; } 

        [JsonProperty("send_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Send_time { get; set; } 

        [JsonProperty("from_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? From_name { get; set; } 

        [JsonProperty("reply_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reply_to { get; set; } 

        [JsonProperty("content_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Content_description { get; set; } 

        [JsonProperty("recipients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Recipients { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailchimpDelivery_Status
    {
        [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } 

        [JsonProperty("can_cancel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Can_cancel { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status { get; set; } 

        [JsonProperty("emails_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Emails_sent { get; set; } 

        [JsonProperty("emails_canceled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Emails_canceled { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailchimpEcommerce
    {
        [JsonProperty("total_orders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Total_orders { get; set; } 

        [JsonProperty("total_spent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Total_spent { get; set; } 

        [JsonProperty("total_revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Total_revenue { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailchimpMerge_Fields
    {
        [JsonProperty("property1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? Property1 { get; set; } 

        [JsonProperty("property2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? Property2 { get; set; } 

        [JsonProperty("fname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fname { get; set; } 

        [JsonProperty("lname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lname { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailchimpRecipients
    {
        [JsonProperty("list_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? List_id { get; set; } 

        [JsonProperty("list_is_active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? List_is_active { get; set; } 

        [JsonProperty("list_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? List_name { get; set; } 

        [JsonProperty("segment_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Segment_text { get; set; } 

        [JsonProperty("recipient_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Recipient_count { get; set; } 

        [JsonProperty("segment_opts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MailchimpSegment_Opts? Segment_opts { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailchimpReport_Summary
    {
        [JsonProperty("opens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Opens { get; set; } 

        [JsonProperty("unique_opens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unique_opens { get; set; } 

        [JsonProperty("open_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Open_rate { get; set; } 

        [JsonProperty("clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clicks { get; set; } 

        [JsonProperty("subscriber_clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Subscriber_clicks { get; set; } 

        [JsonProperty("click_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Click_rate { get; set; } 

        [JsonProperty("ecommerce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MailchimpEcommerce? Ecommerce { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailchimpRss_Opts
    {
        [JsonProperty("feed_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Feed_url { get; set; } 

        [JsonProperty("frequency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Frequency { get; set; } 

        [JsonProperty("schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Schedule? Schedule { get; set; } 

        [JsonProperty("last_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_sent { get; set; } 

        [JsonProperty("constrain_rss_img", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Constrain_rss_img { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailchimpSalesforce
    {
        [JsonProperty("campaign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Campaign { get; set; } 

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Notes { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailchimpSegment_Opts
    {
        [JsonProperty("saved_segment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Saved_segment_id { get; set; } 

        [JsonProperty("prebuilt_segment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prebuilt_segment_id { get; set; } 

        [JsonProperty("match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Match { get; set; } 

        [JsonProperty("conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<object>? Conditions { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailchimpSentTo
    {
        [JsonProperty("email_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email_id { get; set; } 

        [JsonProperty("email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email_address { get; set; } 

        [JsonProperty("merge_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MailchimpMerge_Fields? Merge_fields { get; set; } 

        [JsonProperty("vip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Vip { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status { get; set; } 

        [JsonProperty("open_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Open_count { get; set; } 

        [JsonProperty("last_open", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_open { get; set; } 

        [JsonProperty("absplit_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Absplit_group { get; set; } 

        [JsonProperty("gmt_offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Gmt_offset { get; set; } 

        [JsonProperty("list_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? List_id { get; set; } 

        [JsonProperty("campaign_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Campaign_id { get; set; } 

        [JsonProperty("list_is_active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? List_is_active { get; set; } 

        [JsonProperty("_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Mailchimp_Links>? _links { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailchimpSettings
    {
        [JsonProperty("subject_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject_line { get; set; } 

        [JsonProperty("preview_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Preview_text { get; set; } 

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; } 

        [JsonProperty("from_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? From_name { get; set; } 

        [JsonProperty("reply_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Reply_to { get; set; } 

        [JsonProperty("use_conversation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_conversation { get; set; } 

        [JsonProperty("to_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? To_name { get; set; } 

        [JsonProperty("folder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Folder_id { get; set; } 

        [JsonProperty("authenticate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Authenticate { get; set; } 

        [JsonProperty("auto_footer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auto_footer { get; set; } 

        [JsonProperty("inline_css", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inline_css { get; set; } 

        [JsonProperty("auto_tweet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auto_tweet { get; set; } 

        [JsonProperty("auto_fb_post", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Auto_fb_post { get; set; } 

        [JsonProperty("fb_comments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fb_comments { get; set; } 

        [JsonProperty("timewarp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Timewarp { get; set; } 

        [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Template_id { get; set; } 

        [JsonProperty("drag_and_drop", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Drag_and_drop { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailchimpSocial_Card
    {
        [JsonProperty("image_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Image_url { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailchimpTracking
    {
        [JsonProperty("opens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Opens { get; set; } 

        [JsonProperty("html_clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Html_clicks { get; set; } 

        [JsonProperty("text_clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Text_clicks { get; set; } 

        [JsonProperty("goal_tracking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Goal_tracking { get; set; } 

        [JsonProperty("ecomm360", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ecomm360 { get; set; } 

        [JsonProperty("google_analytics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Google_analytics { get; set; } 

        [JsonProperty("clicktale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Clicktale { get; set; } 

        [JsonProperty("salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MailchimpSalesforce? Salesforce { get; set; } 

        [JsonProperty("capsule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MailchimpCapsule? Capsule { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MailchimpVariate_Settings
    {
        [JsonProperty("winning_combination_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Winning_combination_id { get; set; } 

        [JsonProperty("winning_campaign_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Winning_campaign_id { get; set; } 

        [JsonProperty("winner_criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Winner_criteria { get; set; } 

        [JsonProperty("wait_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Wait_time { get; set; } 

        [JsonProperty("test_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Test_size { get; set; } 

        [JsonProperty("subject_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Subject_lines { get; set; } 

        [JsonProperty("send_times", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<DateTimeOffset>? Send_times { get; set; } 

        [JsonProperty("from_names", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? From_names { get; set; } 

        [JsonProperty("reply_to_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Reply_to_addresses { get; set; } 

        [JsonProperty("contents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Contents { get; set; } 

        [JsonProperty("combinations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MailchimpCombination>? Combinations { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Mailchimp_Links
    {
        [JsonProperty("rel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rel { get; set; } 

        [JsonProperty("href", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Href { get; set; } 

        [JsonProperty("method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Method { get; set; } 

        [JsonProperty("targetSchema", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TargetSchema { get; set; } 

        [JsonProperty("schema", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Schema { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ManageEngineDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("instancetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Instancetype { get; set; } 

        [JsonProperty("region", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Region { get; set; } 

        [JsonProperty("manageengine_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Manageengine_clientid { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_refresh_token { get; set; } 

        [JsonProperty("tokenexpiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Tokenexpiry { get; set; } 

        [JsonProperty("isauthorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isauthorized { get; set; } 

        [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_client_secret { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("server_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Server_url { get; set; } 

        [JsonProperty("unique_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Unique_user_id { get; set; } 

        [JsonProperty("_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _code { get; set; } 

        [JsonProperty("_otp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _otp { get; set; } 

        [JsonProperty("set_local_auth_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Set_local_auth_token { get; set; } 

        [JsonProperty("new_integration_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_integration_key { get; set; } 

        [JsonProperty("client_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Client_links { get; set; } 

        [JsonProperty("default_devicesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_devicesite { get; set; } 

        [JsonProperty("default_devicesite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_devicesite_name { get; set; } 

        [JsonProperty("default_devicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_devicetype { get; set; } 

        [JsonProperty("default_devicetypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_devicetypename { get; set; } 

        [JsonProperty("assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetimportidentifier { get; set; } 

        [JsonProperty("assetimportidentifier_fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetimportidentifier_fieldname { get; set; } 

        [JsonProperty("manageengine_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Manageengine_fieldmappings { get; set; } 

        [JsonProperty("sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Sitemappings { get; set; } 

        [JsonProperty("enableintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableintegrator { get; set; } 

        [JsonProperty("lastsyncdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastsyncdate { get; set; } 

        [JsonProperty("lastsyncerror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastsyncerror { get; set; } 

        [JsonProperty("halo_integrator_import_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halo_integrator_import_list { get; set; } 

        [JsonProperty("halo_integrator_import_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Halo_integrator_import_types { get; set; } 

        [JsonProperty("delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delete_devices { get; set; } 

        [JsonProperty("dont_create_new_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_create_new_devices { get; set; } 

        [JsonProperty("dont_update_device_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_update_device_type { get; set; } 

        [JsonProperty("import_software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Import_software { get; set; } 

        [JsonProperty("dont_move_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_move_site { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Mappings_xtype { get; set; } 

        [JsonProperty("default_assetgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_assetgroup { get; set; } 

        [JsonProperty("default_assetgroupname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_assetgroupname { get; set; } 

        [JsonProperty("assettype_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettype_choice { get; set; } 

        [JsonProperty("assettype_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assettype_field { get; set; } 

        [JsonProperty("_disconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _disconnect { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Manager
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MarketingOpen
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("mailcampaign_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailcampaign_id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email_address { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("email_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Email_id { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_name { get; set; } 

        [JsonProperty("mailcampaign_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mailcampaign_name { get; set; } 

        [JsonProperty("email_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email_name { get; set; } 

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Token { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MarketingUnsubscribe
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("mailcampaign_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailcampaign_id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email_address { get; set; } 

        [JsonProperty("email_unsubscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Email_unsubscribed { get; set; } 

        [JsonProperty("date_unsubscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_unsubscribed { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_name { get; set; } 

        [JsonProperty("mailcampaign_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mailcampaign_name { get; set; } 

        [JsonProperty("email_unsubscribed_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email_unsubscribed_name { get; set; } 

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Token { get; set; } 

        [JsonProperty("validate_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Validate_token { get; set; } 

        [JsonProperty("unsub_all", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Unsub_all { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MattermostChannelDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("mmid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mmid { get; set; } 

        [JsonProperty("channelid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Channelid { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("agentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agentid { get; set; } 

        [JsonProperty("webhookid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webhookid { get; set; } 

        [JsonProperty("webhookname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webhookname { get; set; } 

        [JsonProperty("webhookdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webhookdesc { get; set; } 

        [JsonProperty("botname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Botname { get; set; } 

        [JsonProperty("boticon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Boticon { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MattermostDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_integration_method { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _code { get; set; } 

        [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _exchangecode { get; set; } 

        [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Authorized { get; set; } 

        [JsonProperty("channels", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MattermostChannelDetails>? Channels { get; set; } 

        [JsonProperty("enableintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableintegrator { get; set; } 

        [JsonProperty("integratorhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Integratorhours { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MattermostPropsObject
    {
        [JsonProperty("from_webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? From_webhook { get; set; } 

        [JsonProperty("haloid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Haloid { get; set; } 

        [JsonProperty("override_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Override_username { get; set; } 

        [JsonProperty("webhook_display_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webhook_display_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MattermostWebhook
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("channel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Channel_id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_id { get; set; } 

        [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team_id { get; set; } 

        [JsonProperty("display_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Display_name { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("icon_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon_url { get; set; } 

        [JsonProperty("create_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Create_at { get; set; } 

        [JsonProperty("update_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Update_at { get; set; } 

        [JsonProperty("delete_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Delete_at { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MattermostWebhookContent
    {
        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Text { get; set; } 

        [JsonProperty("channel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Channel { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("icon_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon_url { get; set; } 

        [JsonProperty("icon_emoji", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon_emoji { get; set; } 

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? Attachments { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("props", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MattermostPropsObject? Props { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MerakiWebhook
    {
        [JsonProperty("sharedSecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SharedSecret { get; set; } 

        [JsonProperty("deviceSerial", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DeviceSerial { get; set; } 

        [JsonProperty("deviceName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DeviceName { get; set; } 

        [JsonProperty("alertId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlertId { get; set; } 

        [JsonProperty("alertType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlertType { get; set; } 

        [JsonProperty("alertTypeId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlertTypeId { get; set; } 

        [JsonProperty("alertLevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlertLevel { get; set; } 

        [JsonProperty("organizationName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OrganizationName { get; set; } 

        [JsonProperty("networkName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NetworkName { get; set; } 

        [JsonProperty("alertData", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? AlertData { get; set; } 

        [JsonProperty("networkTags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? NetworkTags { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MessageContent
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("body_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Body_text { get; set; } 

        [JsonProperty("body_sms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Body_sms { get; set; } 

        [JsonProperty("body_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Body_html { get; set; } 

        [JsonProperty("design", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public HtmlDesign? Design { get; set; } 

        [JsonProperty("announcement_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Announcement_end_date { get; set; } 

        [JsonProperty("_isclone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isclone { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("sectionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sectionid { get; set; } 

        [JsonProperty("header_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Header_text { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("is_single_obj", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_single_obj { get; set; } 

        [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Messagegroup_id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum MessageImportance
    {

        _0 = 0,

        _1 = 1,

        _2 = 2,

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MessagePart
    {
        [JsonProperty("body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MessagePartBody? Body { get; set; } 

        [JsonProperty("filename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Filename { get; set; } 

        [JsonProperty("headers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MessagePartHeader>? Headers { get; set; } 

        [JsonProperty("mimeType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MimeType { get; set; } 

        [JsonProperty("partId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PartId { get; set; } 

        [JsonProperty("parts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MessagePart>? Parts { get; set; } 

        [JsonProperty("eTag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ETag { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MessagePartBody
    {
        [JsonProperty("attachmentId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AttachmentId { get; set; } 

        [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Data { get; set; } 

        [JsonProperty("size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; } 

        [JsonProperty("eTag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ETag { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MessagePartHeader
    {
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

        [JsonProperty("eTag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ETag { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum MessagePriority
    {

        _0 = 0,

        _1 = 1,

        _2 = 2,

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MicrosoftSubscriptionMapping
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("halo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Halo_id { get; set; } 

        [JsonProperty("halo_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halo_name { get; set; } 

        [JsonProperty("microsoft_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Microsoft_id { get; set; } 

        [JsonProperty("microsoft_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Microsoft_name { get; set; } 

        [JsonProperty("site_path", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_path { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("azure_connection_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azure_connection_id { get; set; } 

        [JsonProperty("_subscriptionaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public WebhookSubscriptionAction? _subscriptionaction { get; set; } 

        [JsonProperty("subscription_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subscription_id { get; set; } 

        [JsonProperty("subscription_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Subscription_expiry { get; set; } 

        [JsonProperty("subscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Subscribed { get; set; } 

        [JsonProperty("new_subscription_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_subscription_key { get; set; } 

        [JsonProperty("azure_connection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AzureAdConnection? Azure_connection { get; set; } 

        [JsonProperty("_dosave", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dosave { get; set; } 

        [JsonProperty("mappings_folder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Mappings_folder { get; set; } 

        [JsonProperty("sharepoint_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SharePointList? Sharepoint_list { get; set; } 

        [JsonProperty("sharepoint_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SharePointSite? Sharepoint_site { get; set; } 

        [JsonProperty("change_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Change_token { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("fullname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fullname { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MicrosoftTeamsMapping
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team_id { get; set; } 

        [JsonProperty("team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team_name { get; set; } 

        [JsonProperty("_subscriptionaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public WebhookSubscriptionAction? _subscriptionaction { get; set; } 

        [JsonProperty("subscription_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subscription_id { get; set; } 

        [JsonProperty("subscription_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Subscription_expiry { get; set; } 

        [JsonProperty("subscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Subscribed { get; set; } 

        [JsonProperty("new_subscription_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_subscription_key { get; set; } 

        [JsonProperty("_dosave", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dosave { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MileStone
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Start_date { get; set; } 

        [JsonProperty("target_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Target_date { get; set; } 

        [JsonProperty("milestone_dependencies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MileStone>? Milestone_dependencies { get; set; } 

        [JsonProperty("dependencies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MileStoneDependency>? Dependencies { get; set; } 

        [JsonProperty("tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultsMileStone>? Tickets { get; set; } 

        [JsonProperty("_complete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _complete { get; set; } 

        [JsonProperty("_dateschanged", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dateschanged { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("start_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Start_days { get; set; } 

        [JsonProperty("target_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Target_days { get; set; } 

        [JsonProperty("_fromtemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _fromtemplate { get; set; } 

        [JsonProperty("milestone_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Milestone_value { get; set; } 

        [JsonProperty("processed_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Processed_date { get; set; } 

        [JsonProperty("invoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoicenumber { get; set; } 

        [JsonProperty("from_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? From_template_id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MileStoneDependency
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("child", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Child { get; set; } 

        [JsonProperty("parent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parent { get; set; } 

        [JsonProperty("parent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Parent_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MimeEntity
    {
        [JsonProperty("headers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Header>? Headers { get; set; } 

        [JsonProperty("contentDisposition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ContentDisposition? ContentDisposition { get; set; } 

        [JsonProperty("contentType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ContentType? ContentType { get; set; } 

        [JsonProperty("contentBase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Uri? ContentBase { get; set; } 

        [JsonProperty("contentLocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Uri? ContentLocation { get; set; } 

        [JsonProperty("contentId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ContentId { get; set; } 

        [JsonProperty("isAttachment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAttachment { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MimeMessage
    {
        [JsonProperty("headers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Header>? Headers { get; set; } 

        [JsonProperty("importance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MessageImportance? Importance { get; set; } 

        [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MessagePriority? Priority { get; set; } 

        [JsonProperty("xPriority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public XMessagePriority? XPriority { get; set; } 

        [JsonProperty("sender", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MailboxAddress? Sender { get; set; } 

        [JsonProperty("resentSender", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MailboxAddress? ResentSender { get; set; } 

        [JsonProperty("from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InternetAddress>? From { get; set; } 

        [JsonProperty("resentFrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InternetAddress>? ResentFrom { get; set; } 

        [JsonProperty("replyTo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InternetAddress>? ReplyTo { get; set; } 

        [JsonProperty("resentReplyTo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InternetAddress>? ResentReplyTo { get; set; } 

        [JsonProperty("to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InternetAddress>? To { get; set; } 

        [JsonProperty("resentTo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InternetAddress>? ResentTo { get; set; } 

        [JsonProperty("cc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InternetAddress>? Cc { get; set; } 

        [JsonProperty("resentCc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InternetAddress>? ResentCc { get; set; } 

        [JsonProperty("bcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InternetAddress>? Bcc { get; set; } 

        [JsonProperty("resentBcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InternetAddress>? ResentBcc { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("resentDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ResentDate { get; set; } 

        [JsonProperty("references", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? References { get; set; } 

        [JsonProperty("inReplyTo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InReplyTo { get; set; } 

        [JsonProperty("messageId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MessageId { get; set; } 

        [JsonProperty("resentMessageId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ResentMessageId { get; set; } 

        [JsonProperty("mimeVersion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MimeVersion { get; set; } 

        [JsonProperty("body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MimeEntity? Body { get; set; } 

        [JsonProperty("textBody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TextBody { get; set; } 

        [JsonProperty("htmlBody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HtmlBody { get; set; } 

        [JsonProperty("bodyParts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MimeEntity>? BodyParts { get; set; } 

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MimeEntity>? Attachments { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ModuleSetup
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("module_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Module_name { get; set; } 

        [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } 

        [JsonProperty("core", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Core { get; set; } 

        [JsonProperty("licensed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Licensed { get; set; } 

        [JsonProperty("accesslevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Accesslevel { get; set; } 

        [JsonProperty("halointegratorenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegratorenabled { get; set; } 

        [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_lastsync { get; set; } 

        [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_lasterror { get; set; } 

        [JsonProperty("actual_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Actual_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MoveMailRequest
    {
        [JsonProperty("mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailbox_id { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MultiselectFilter
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

    }