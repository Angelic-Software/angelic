using System.CodeDom.Compiler;
using Angelic.Dtos;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class IMAPMessage
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("haloMailboxId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HaloMailboxId { get; set; } 

        [JsonProperty("incomingEmailId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IncomingEmailId { get; set; } 

        [JsonProperty("mimeMessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MimeMessage? MimeMessage { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class IMRWebhook
    {
        [JsonProperty("topic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Topic { get; set; } 

        [JsonProperty("event", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Event { get; set; } 

        [JsonProperty("eventTimeStamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EventTimeStamp { get; set; } 

        [JsonProperty("eventId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EventId { get; set; } 

        [JsonProperty("resource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? Resource { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class IframeTabRequestType
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tickettype_id { get; set; } 

        [JsonProperty("iframetab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Iframetab_id { get; set; } 

        [JsonProperty("iframetab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Iframetab_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ImpersonationRequest
    {
        [JsonProperty("irid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Irid { get; set; } 

        [JsonProperty("requestor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Requestor { get; set; } 

        [JsonProperty("agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent { get; set; } 

        [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User { get; set; } 

        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Timestamp { get; set; } 

        [JsonProperty("enc_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Enc_id { get; set; } 

        [JsonProperty("token_used", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Token_used { get; set; } 

        [JsonProperty("used_timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Used_timestamp { get; set; } 

        [JsonProperty("jwt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jwt { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ImportCsv
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Mappings { get; set; } 

        [JsonProperty("create_new_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Create_new_lines { get; set; } 

        [JsonProperty("one_time_charges", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? One_time_charges { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class IncomingEmail
    {
        [JsonProperty("old_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Old_id { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("mbid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mbid { get; set; } 

        [JsonProperty("agentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agentid { get; set; } 

        [JsonProperty("addactiontofaultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Addactiontofaultid { get; set; } 

        [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datecreated { get; set; } 

        [JsonProperty("dateprocessed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Dateprocessed { get; set; } 

        [JsonProperty("memo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Memo { get; set; } 

        [JsonProperty("processed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Processed { get; set; } 

        [JsonProperty("delete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delete { get; set; } 

        [JsonProperty("issalesmb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Issalesmb { get; set; } 

        [JsonProperty("from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? From { get; set; } 

        [JsonProperty("html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Html { get; set; } 

        [JsonProperty("to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? To { get; set; } 

        [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Users? User { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("mailid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mailid { get; set; } 

        [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[]? Data { get; set; } 

        [JsonProperty("source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Source { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; } 

        [JsonProperty("removed_from_mailbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Removed_from_mailbox { get; set; } 

        [JsonProperty("retry_remaining", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Retry_remaining { get; set; } 

        [JsonProperty("last_attempt_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_attempt_date { get; set; } 

        [JsonProperty("_checkmailid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _checkmailid { get; set; } 

        [JsonProperty("_downloadmail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _downloadmail { get; set; } 

        [JsonProperty("mailbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Mailbox? Mailbox { get; set; } 

        [JsonProperty("mailbox_type_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailbox_type_int { get; set; } 

        [JsonProperty("outbound", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Outbound { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class IncomingEvent
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rule_id { get; set; } 

        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Timestamp { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; } 

        [JsonProperty("duration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Duration { get; set; } 

        [JsonProperty("requestheaders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Requestheaders { get; set; } 

        [JsonProperty("requestbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Requestbody { get; set; } 

        [JsonProperty("responsestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Responsestatus { get; set; } 

        [JsonProperty("responsebody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Responsebody { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Error { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("deletion_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Deletion_date { get; set; } 

        [JsonProperty("output_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OutboundIntegrationMethodValue>? Output_variables { get; set; } 

        [JsonProperty("_retry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _retry { get; set; } 

        [JsonProperty("_apply_this_rule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _apply_this_rule { get; set; } 

        [JsonProperty("_is_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _is_link { get; set; } 

        [JsonProperty("rule_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rule_name { get; set; } 

        [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Entity_id { get; set; } 

        [JsonProperty("thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdparty_id { get; set; } 

        [JsonProperty("status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status_name { get; set; } 

        [JsonProperty("responsetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Responsetype { get; set; } 

        [JsonProperty("response_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Response_desc { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class IngramMicroDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_method { get; set; } 

        [JsonProperty("import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Import_entities { get; set; } 

        [JsonProperty("toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Toplevel { get; set; } 

        [JsonProperty("update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Update_addresses { get; set; } 

        [JsonProperty("marketplace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Marketplace { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_password { get; set; } 

        [JsonProperty("new_subscription_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_subscription_key { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Client_mappings { get; set; } 

        [JsonProperty("top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Top_level_name { get; set; } 

        [JsonProperty("halointegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator { get; set; } 

        [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_lastsync { get; set; } 

        [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_lasterror { get; set; } 

        [JsonProperty("import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Import_entities_list { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class IngramMicroResellerDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_method { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_id { get; set; } 

        [JsonProperty("customer_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Customer_number { get; set; } 

        [JsonProperty("country_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Country_code { get; set; } 

        [JsonProperty("correlation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Correlation_id { get; set; } 

        [JsonProperty("company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Company_id { get; set; } 

        [JsonProperty("receive_order_status_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Receive_order_status_updated { get; set; } 

        [JsonProperty("receive_quote_to_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Receive_quote_to_order { get; set; } 

        [JsonProperty("auto_create_purchase_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auto_create_purchase_order { get; set; } 

        [JsonProperty("sync_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sync_entities { get; set; } 

        [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Sync_entities_list { get; set; } 

        [JsonProperty("api_app_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Api_app_type { get; set; } 

        [JsonProperty("reseller_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reseller_site { get; set; } 

        [JsonProperty("delivery_address_auto_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Delivery_address_auto_po { get; set; } 

        [JsonProperty("order_status_canceled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Order_status_canceled { get; set; } 

        [JsonProperty("order_status_backordered", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Order_status_backordered { get; set; } 

        [JsonProperty("order_status_processing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Order_status_processing { get; set; } 

        [JsonProperty("order_status_hold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Order_status_hold { get; set; } 

        [JsonProperty("order_status_delivered", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Order_status_delivered { get; set; } 

        [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_client_secret { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("new_webhook_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_webhook_signature { get; set; } 

        [JsonProperty("company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Company_name { get; set; } 

        [JsonProperty("ordered_status_canceled_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ordered_status_canceled_name { get; set; } 

        [JsonProperty("order_status_backordered_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Order_status_backordered_name { get; set; } 

        [JsonProperty("order_status_processing_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Order_status_processing_name { get; set; } 

        [JsonProperty("order_status_hold_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Order_status_hold_name { get; set; } 

        [JsonProperty("order_status_delivered_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Order_status_delivered_name { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("default_assetgroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_assetgroup_id { get; set; } 

        [JsonProperty("default_assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_assetgroup_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class InstagramBusinessAccount
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Instance
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("hostname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hostname { get; set; } 

        [JsonProperty("envname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Envname { get; set; } 

        [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Version { get; set; } 

        [JsonProperty("commits_ahead", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Commits_ahead { get; set; } 

        [JsonProperty("commits_behind", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Commits_behind { get; set; } 

        [JsonProperty("syncid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Syncid { get; set; } 

        [JsonProperty("offline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Offline { get; set; } 

        [JsonProperty("insync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Insync { get; set; } 

        [JsonProperty("versionmatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Versionmatch { get; set; } 

        [JsonProperty("canmerge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canmerge { get; set; } 

        [JsonProperty("iscurrent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Iscurrent { get; set; } 

        [JsonProperty("nomergereason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nomergereason { get; set; } 

        [JsonProperty("isself", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isself { get; set; } 

        [JsonProperty("isprod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isprod { get; set; } 

        [JsonProperty("_restore_from_prod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _restore_from_prod { get; set; } 

        [JsonProperty("_restore_from_prod_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _restore_from_prod_result { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Int32NullableStringDateTimeNullableInt32NullableDateTimeNullableTuple
    {
        [JsonProperty("item1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item1 { get; set; } 

        [JsonProperty("item2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item2 { get; set; } 

        [JsonProperty("item3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Item3 { get; set; } 

        [JsonProperty("item4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item4 { get; set; } 

        [JsonProperty("item5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Item5 { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Int32NullableStringDateTimeNullableInt32NullableTuple
    {
        [JsonProperty("item1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item1 { get; set; } 

        [JsonProperty("item2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item2 { get; set; } 

        [JsonProperty("item3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Item3 { get; set; } 

        [JsonProperty("item4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item4 { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class IntegrationConfiguration
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("application_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Application_url { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_id { get; set; } 

        [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_client_secret { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_refresh_token { get; set; } 

        [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Token_expiry { get; set; } 

        [JsonProperty("redirect_uri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Redirect_uri { get; set; } 

        [JsonProperty("_isauthorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isauthorized { get; set; } 

        [JsonProperty("tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenant { get; set; } 

        [JsonProperty("resource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Resource { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_method { get; set; } 

        [JsonProperty("alternate_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Alternate_client_id { get; set; } 

        [JsonProperty("new_alternate_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_alternate_client_secret { get; set; } 

        [JsonProperty("client_credentials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Client_credentials { get; set; } 

        [JsonProperty("password_credentials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Password_credentials { get; set; } 

        [JsonProperty("webhook_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webhook_username { get; set; } 

        [JsonProperty("new_webhook_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_webhook_password { get; set; } 

        [JsonProperty("webhook_iterations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Webhook_iterations { get; set; } 

        [JsonProperty("new_webhook_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_webhook_method { get; set; } 

        [JsonProperty("last_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_update { get; set; } 

        [JsonProperty("token_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Token_url { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class IntegrationError
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Module_id { get; set; } 

        [JsonProperty("detail_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Detail_id { get; set; } 

        [JsonProperty("entity_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Entity_type { get; set; } 

        [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Entity_id { get; set; } 

        [JsonProperty("entity_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Entity_name { get; set; } 

        [JsonProperty("endpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Endpoint { get; set; } 

        [JsonProperty("error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Error { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class IntegrationExport
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("export_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Export_id { get; set; } 

        [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Module_id { get; set; } 

        [JsonProperty("halo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Halo_id { get; set; } 

        [JsonProperty("halo_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halo_name { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_id { get; set; } 

        [JsonProperty("third_party_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_name { get; set; } 

        [JsonProperty("export_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Export_url { get; set; } 

        [JsonProperty("export_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Export_date { get; set; } 

        [JsonProperty("export_progress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Export_progress { get; set; } 

        [JsonProperty("ready_for_import", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ready_for_import { get; set; } 

        [JsonProperty("progress_error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Progress_error { get; set; } 

        [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Details_id { get; set; } 

        [JsonProperty("exportdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationExportData>? Exportdata { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class IntegrationExportData
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("integration_export_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Integration_export_id { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_id { get; set; } 

        [JsonProperty("exported", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exported { get; set; } 

        [JsonProperty("export_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[]? Export_body { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class IntegrationFieldData
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("msid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Msid { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("fieldid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fieldid { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Details_id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class IntegrationFieldMapping
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("fiid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fiid { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("thirdpartyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartyname { get; set; } 

        [JsonProperty("msid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Msid { get; set; } 

        [JsonProperty("typeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Typeid { get; set; } 

        [JsonProperty("isassetfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isassetfield { get; set; } 

        [JsonProperty("subtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Subtypeid { get; set; } 

        [JsonProperty("newrecords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newrecords { get; set; } 

        [JsonProperty("xmvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xmvalue { get; set; } 

        [JsonProperty("third_party_friendly_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_friendly_name { get; set; } 

        [JsonProperty("sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync { get; set; } 

        [JsonProperty("synctype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Synctype { get; set; } 

        [JsonProperty("product", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Product { get; set; } 

        [JsonProperty("dontupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontupdate { get; set; } 

        [JsonProperty("product_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Product_name { get; set; } 

        [JsonProperty("third_party_field_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Third_party_field_type { get; set; } 

        [JsonProperty("populateemptyvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Populateemptyvalue { get; set; } 

        [JsonProperty("value_set", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value_set { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class IntegrationFilter
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Integration_id { get; set; } 

        [JsonProperty("mapping_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mapping_id { get; set; } 

        [JsonProperty("mapping_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mapping_name { get; set; } 

        [JsonProperty("filter_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Filter_field { get; set; } 

        [JsonProperty("filter_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Filter_type { get; set; } 

        [JsonProperty("filter_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Filter_value { get; set; } 

        [JsonProperty("query_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Query_string { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Details_id { get; set; } 

        [JsonProperty("value_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Value_type { get; set; } 

        [JsonProperty("filter_operator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Filter_operator { get; set; } 

        [JsonProperty("filter_type2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Filter_type2 { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class IntegrationLookUp
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("module_id", Required = Required.Always)]
        public int Module_id { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_id { get; set; } 

        [JsonProperty("value", Required = Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Value { get; set; } 

        [JsonProperty("_success", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _success { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class IntegrationRequest
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("isoutgoing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isoutgoing { get; set; } 

        [JsonProperty("operation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Operation { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("msid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Msid { get; set; } 

        [JsonProperty("request_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Request_body { get; set; } 

        [JsonProperty("datelogged", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datelogged { get; set; } 

        [JsonProperty("resultcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Resultcode { get; set; } 

        [JsonProperty("response_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Response_body { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Details_id { get; set; } 

        [JsonProperty("request_headers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Request_headers { get; set; } 

        [JsonProperty("response_headers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Response_headers { get; set; } 

        [JsonProperty("trace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Trace>? Trace { get; set; } 

        [JsonProperty("_retrywebhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _retrywebhook { get; set; } 

        [JsonProperty("preserve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Preserve { get; set; } 

        [JsonProperty("hastrace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hastrace { get; set; } 

        [JsonProperty("format_as_xml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Format_as_xml { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class IntegrationRunbookVariable
    {
        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

        [JsonProperty("group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Group { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("output", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Output { get; set; } 

        [JsonProperty("method_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Method_id { get; set; } 

        [JsonProperty("method_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Method_name { get; set; } 

        [JsonProperty("step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Step { get; set; } 

        [JsonProperty("step_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Step_name { get; set; } 

        [JsonProperty("persist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Persist { get; set; } 

        [JsonProperty("mapping_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mapping_type { get; set; } 

        [JsonProperty("object_mapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Object_mapping { get; set; } 

        [JsonProperty("variable_name_root_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Variable_name_root_override { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class IntegrationSiteMapping
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("halo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Halo_id { get; set; } 

        [JsonProperty("halo_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halo_name { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_id { get; set; } 

        [JsonProperty("third_party_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_name { get; set; } 

        [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Module_id { get; set; } 

        [JsonProperty("third_party_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_client_id { get; set; } 

        [JsonProperty("third_party_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_client_name { get; set; } 

        [JsonProperty("third_party_full_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_full_name { get; set; } 

        [JsonProperty("halo_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Halo_client_id { get; set; } 

        [JsonProperty("halo_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halo_client_name { get; set; } 

        [JsonProperty("halo_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halo_site_name { get; set; } 

        [JsonProperty("userules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Userules { get; set; } 

        [JsonProperty("criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMappingCriteria>? Criteria { get; set; } 

        [JsonProperty("rule_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rule_count { get; set; } 

        [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Seq { get; set; } 

        [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Details_id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class InternetAddress
    {
        [JsonProperty("encoding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Encoding? Encoding { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class InvoiceChange
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_id { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_id { get; set; } 

        [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field_name { get; set; } 

        [JsonProperty("old_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Old_value { get; set; } 

        [JsonProperty("new_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_value { get; set; } 

        [JsonProperty("who", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Who { get; set; } 

        [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datetime { get; set; } 

        [JsonProperty("invoice_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_line_id { get; set; } 

        [JsonProperty("invoice_detail_quantity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_detail_quantity_id { get; set; } 

        [JsonProperty("invoice_detail_prorata_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_detail_prorata_id { get; set; } 

        [JsonProperty("type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type_id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class InvoiceDetail
    {
        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("ihid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ihid { get; set; } 

        [JsonProperty("item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_code { get; set; } 

        [JsonProperty("item_shortdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_shortdescription { get; set; } 

        [JsonProperty("item_longdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_longdescription { get; set; } 

        [JsonProperty("nominal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nominal_code { get; set; } 

        [JsonProperty("tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tax_code { get; set; } 

        [JsonProperty("qty_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Qty_order { get; set; } 

        [JsonProperty("unit_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Unit_price { get; set; } 

        [JsonProperty("unit_price_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Unit_price_converted { get; set; } 

        [JsonProperty("net_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Net_amount { get; set; } 

        [JsonProperty("tax_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Tax_amount { get; set; } 

        [JsonProperty("tax_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Tax_rate { get; set; } 

        [JsonProperty("comment_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Comment_1 { get; set; } 

        [JsonProperty("comment_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Comment_2 { get; set; } 

        [JsonProperty("itemonorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Itemonorder { get; set; } 

        [JsonProperty("dsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dsite { get; set; } 

        [JsonProperty("ddevnum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ddevnum { get; set; } 

        [JsonProperty("_itemid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _itemid { get; set; } 

        [JsonProperty("productnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Productnumber { get; set; } 

        [JsonProperty("unit_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Unit_cost { get; set; } 

        [JsonProperty("asset_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_id { get; set; } 

        [JsonProperty("asset_inventory_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Asset_inventory_number { get; set; } 

        [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contract_id { get; set; } 

        [JsonProperty("recurring_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Recurring_invoice_id { get; set; } 

        [JsonProperty("recurring_invoice_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Recurring_invoice_line_id { get; set; } 

        [JsonProperty("actioncode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actioncode { get; set; } 

        [JsonProperty("site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site { get; set; } 

        [JsonProperty("meter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Meter_id { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("lineactiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lineactiondate { get; set; } 

        [JsonProperty("labourdepartmentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Labourdepartmentid { get; set; } 

        [JsonProperty("salesorder_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesorder_line { get; set; } 

        [JsonProperty("salesorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesorder_line_id { get; set; } 

        [JsonProperty("meter_pricing_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Meter_pricing_method { get; set; } 

        [JsonProperty("line_fully_invoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Line_fully_invoiced { get; set; } 

        [JsonProperty("xero_lineid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_lineid { get; set; } 

        [JsonProperty("prepay_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prepay_id { get; set; } 

        [JsonProperty("calculate_price_from_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Calculate_price_from_assets { get; set; } 

        [JsonProperty("calculate_price_from_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Calculate_price_from_users { get; set; } 

        [JsonProperty("creditlinkedidid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Creditlinkedidid { get; set; } 

        [JsonProperty("recurring_invoice_price_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Recurring_invoice_price_type { get; set; } 

        [JsonProperty("entity_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Entity_type { get; set; } 

        [JsonProperty("item_internal_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_internal_reference { get; set; } 

        [JsonProperty("item_external_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_external_reference { get; set; } 

        [JsonProperty("linked_item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Item? Linked_item { get; set; } 

        [JsonProperty("item_tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_tax_name { get; set; } 

        [JsonProperty("xero_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_tax_code { get; set; } 

        [JsonProperty("override_ast_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Override_ast_total { get; set; } 

        [JsonProperty("prorata_next_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prorata_next_invoice { get; set; } 

        [JsonProperty("prorata_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prorata_quantity { get; set; } 

        [JsonProperty("prorata_unit_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prorata_unit_price { get; set; } 

        [JsonProperty("prorata_shortdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prorata_shortdescription { get; set; } 

        [JsonProperty("prorata_longdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prorata_longdescription { get; set; } 

        [JsonProperty("isinactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isinactive { get; set; } 

        [JsonProperty("period_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Period_type { get; set; } 

        [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_id { get; set; } 

        [JsonProperty("isgroupdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isgroupdesc { get; set; } 

        [JsonProperty("kashflow_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kashflow_line_id { get; set; } 

        [JsonProperty("_is_calculated_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _is_calculated_line { get; set; } 

        [JsonProperty("tax_code_overriden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Tax_code_overriden { get; set; } 

        [JsonProperty("is_meter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_meter { get; set; } 

        [JsonProperty("current_reading", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Current_reading { get; set; } 

        [JsonProperty("last_reading_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_reading_date { get; set; } 

        [JsonProperty("prorata_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InvoiceDetailProRata>? Prorata_data { get; set; } 

        [JsonProperty("quantity_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InvoiceDetailQuantity>? Quantity_users { get; set; } 

        [JsonProperty("quantity_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InvoiceDetailQuantity>? Quantity_assets { get; set; } 

        [JsonProperty("quantity_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InvoiceDetailQuantity>? Quantity_licences { get; set; } 

        [JsonProperty("quantity_subscriptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InvoiceDetailQuantity>? Quantity_subscriptions { get; set; } 

        [JsonProperty("recurring_invoice_quantity_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Recurring_invoice_quantity_type { get; set; } 

        [JsonProperty("quantity_custom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity_custom { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("billingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Billingperiod { get; set; } 

        [JsonProperty("line_periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Line_periods { get; set; } 

        [JsonProperty("percent_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Percent_increase { get; set; } 

        [JsonProperty("min_meter_units", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Min_meter_units { get; set; } 

        [JsonProperty("sequenceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequenceid { get; set; } 

        [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdate { get; set; } 

        [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Enddate { get; set; } 

        [JsonProperty("autorenew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autorenew { get; set; } 

        [JsonProperty("autorenewperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Autorenewperiod { get; set; } 

        [JsonProperty("intacct_location_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_location_id { get; set; } 

        [JsonProperty("intacct_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_department_id { get; set; } 

        [JsonProperty("synced_to_intacct", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Synced_to_intacct { get; set; } 

        [JsonProperty("hideitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hideitems { get; set; } 

        [JsonProperty("includegrouppriceandqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includegrouppriceandqty { get; set; } 

        [JsonProperty("auto_increase_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Auto_increase_period { get; set; } 

        [JsonProperty("auto_increase_last_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Auto_increase_last_date { get; set; } 

        [JsonProperty("onetimecharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Onetimecharge { get; set; } 

        [JsonProperty("onetimechargeinvoiceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Onetimechargeinvoiceid { get; set; } 

        [JsonProperty("needsreviewbeforecreation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Needsreviewbeforecreation { get; set; } 

        [JsonProperty("reviewed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reviewed { get; set; } 

        [JsonProperty("metertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Metertype { get; set; } 

        [JsonProperty("importcsvid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Importcsvid { get; set; } 

        [JsonProperty("force_new", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force_new { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("dbc_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dbc_id { get; set; } 

        [JsonProperty("purchaseorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Purchaseorder_id { get; set; } 

        [JsonProperty("purchaseorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Purchaseorder_line_id { get; set; } 

        [JsonProperty("discount_perc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Discount_perc { get; set; } 

        [JsonProperty("exclude_auto_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exclude_auto_increase { get; set; } 

        [JsonProperty("createproratanormallines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Createproratanormallines { get; set; } 

        [JsonProperty("createproratadate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Createproratadate { get; set; } 

        [JsonProperty("pro_rata_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pro_rata_line_id { get; set; } 

        [JsonProperty("supplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier { get; set; } 

        [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_name { get; set; } 

        [JsonProperty("hide_on_pdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_on_pdf { get; set; } 

        [JsonProperty("intacct_warehouse_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_warehouse_id { get; set; } 

        [JsonProperty("invoice_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoice_class { get; set; } 

        [JsonProperty("percent_invoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Percent_invoiced { get; set; } 

        [JsonProperty("is_bundled_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_bundled_line { get; set; } 

        [JsonProperty("meter_tiers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InvoiceDetailMeterTiers>? Meter_tiers { get; set; } 

        [JsonProperty("meter_min_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Meter_min_quantity { get; set; } 

        [JsonProperty("original_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Original_client_id { get; set; } 

        [JsonProperty("myob_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Myob_location { get; set; } 

        [JsonProperty("myob_row_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Myob_row_id { get; set; } 

        [JsonProperty("dbc_sequence_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dbc_sequence_id { get; set; } 

        [JsonProperty("minimum_line_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Minimum_line_total { get; set; } 

        [JsonProperty("hide_grouped_items_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_grouped_items_price { get; set; } 

        [JsonProperty("credit_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Credit_id { get; set; } 

        [JsonProperty("is_deferred_revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_deferred_revenue { get; set; } 

        [JsonProperty("deferred_revenue_olid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Deferred_revenue_olid { get; set; } 

        [JsonProperty("deferred_revenue_olseq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Deferred_revenue_olseq { get; set; } 

        [JsonProperty("is_recognised_revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_recognised_revenue { get; set; } 

        [JsonProperty("no_tax_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? No_tax_override { get; set; } 

        [JsonProperty("_temp_order_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _temp_order_id { get; set; } 

        [JsonProperty("_temp_order_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _temp_order_seq { get; set; } 

        [JsonProperty("_temp_order_qty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? _temp_order_qty { get; set; } 

        [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_tax_code { get; set; } 

        [JsonProperty("_updateprorata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _updateprorata { get; set; } 

        [JsonProperty("bundle_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bundle_id { get; set; } 

        [JsonProperty("bundle_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Bundle_name { get; set; } 

        [JsonProperty("bundle_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bundle_line_id { get; set; } 

        [JsonProperty("xero_category_1_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_category_1_lookup { get; set; } 

        [JsonProperty("xero_category_2_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_category_2_lookup { get; set; } 

        [JsonProperty("xero_category_1_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_category_1_lookup_name { get; set; } 

        [JsonProperty("xero_category_2_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_category_2_lookup_name { get; set; } 

        [JsonProperty("use_rpi_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_rpi_increase { get; set; } 

        [JsonProperty("merge_lines_if_matched", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Merge_lines_if_matched { get; set; } 

        [JsonProperty("surcharge_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Surcharge_id { get; set; } 

        [JsonProperty("override_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Override_tax_code { get; set; } 

        [JsonProperty("baseprice_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Baseprice_converted { get; set; } 

        [JsonProperty("baseprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Baseprice { get; set; } 

        [JsonProperty("unitprice_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Unitprice_converted { get; set; } 

        [JsonProperty("total_tax_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_tax_converted { get; set; } 

        [JsonProperty("net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Net_total { get; set; } 

        [JsonProperty("tax_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Tax_converted { get; set; } 

        [JsonProperty("total_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_tax { get; set; } 

        [JsonProperty("total_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_price { get; set; } 

        [JsonProperty("total_discount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_discount { get; set; } 

        [JsonProperty("discount_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Discount_converted { get; set; } 

        [JsonProperty("net_amount_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Net_amount_converted { get; set; } 

        [JsonProperty("total_price_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_price_converted { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tax_name { get; set; } 

        [JsonProperty("taxRuleResult", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TaxRuleResult>? TaxRuleResult { get; set; } 

        [JsonProperty("decimalplacesforinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Decimalplacesforinvoices { get; set; } 

        [JsonProperty("total_net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_net_total { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class InvoiceDetailMeterTiers
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("idid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Idid { get; set; } 

        [JsonProperty("minquantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Minquantity { get; set; } 

        [JsonProperty("maxquantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Maxquantity { get; set; } 

        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Price { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class InvoiceDetailProRata
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("invoicedetailid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoicedetailid { get; set; } 

        [JsonProperty("recurring_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Recurring_invoice_id { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("client_to_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_to_invoice_id { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity { get; set; } 

        [JsonProperty("unitprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Unitprice { get; set; } 

        [JsonProperty("unitcost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Unitcost { get; set; } 

        [JsonProperty("shortdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Shortdescription { get; set; } 

        [JsonProperty("longdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Longdescription { get; set; } 

        [JsonProperty("quantity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity_id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("device_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device_id { get; set; } 

        [JsonProperty("prorata_next_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prorata_next_invoice { get; set; } 

        [JsonProperty("invoiceheaderid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoiceheaderid { get; set; } 

        [JsonProperty("dont_auto_calculate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_auto_calculate { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("isinvoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isinvoiced { get; set; } 

        [JsonProperty("isfuturepr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isfuturepr { get; set; } 

        [JsonProperty("inv_manual_pr_immediately", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inv_manual_pr_immediately { get; set; } 

        [JsonProperty("change_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Change_id { get; set; } 

        [JsonProperty("istempprorata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Istempprorata { get; set; } 

        [JsonProperty("include_in_roi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Include_in_roi { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class InvoiceDetailQuantity
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("invoice_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_line_id { get; set; } 

        [JsonProperty("kind", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kind { get; set; } 

        [JsonProperty("type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type_id { get; set; } 

        [JsonProperty("device_group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device_group_id { get; set; } 

        [JsonProperty("type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type_name { get; set; } 

        [JsonProperty("device_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Device_group_name { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("licence_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Licence_id { get; set; } 

        [JsonProperty("licence_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Licence_name { get; set; } 

        [JsonProperty("assigned_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Assigned_licences { get; set; } 

        [JsonProperty("qty_free", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qty_free { get; set; } 

        [JsonProperty("minimum_qty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Minimum_qty { get; set; } 

        [JsonProperty("pro_rata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pro_rata { get; set; } 

        [JsonProperty("criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InvoiceDetailQuantityCriteria>? Criteria { get; set; } 

        [JsonProperty("use_linked_subscription_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_linked_subscription_price { get; set; } 

        [JsonProperty("use_linked_subscription_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_linked_subscription_cost { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class InvoiceDetailQuantityCriteria
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("invoicedetailquantity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoicedetailquantity_id { get; set; } 

        [JsonProperty("tablename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tablename { get; set; } 

        [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fieldname { get; set; } 

        [JsonProperty("value_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value_type { get; set; } 

        [JsonProperty("value_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Value_int { get; set; } 

        [JsonProperty("value_float", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Value_float { get; set; } 

        [JsonProperty("value_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value_string { get; set; } 

        [JsonProperty("value_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Value_datetime { get; set; } 

        [JsonProperty("value_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value_display { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class InvoiceHeader
    {
        [JsonProperty("disabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("sitenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sitenumber { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountsid { get; set; } 

        [JsonProperty("uid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Uid { get; set; } 

        [JsonProperty("invoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoicenumber { get; set; } 

        [JsonProperty("thirdpartyinvoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartyinvoicenumber { get; set; } 

        [JsonProperty("posted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Posted { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("address1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Address1 { get; set; } 

        [JsonProperty("address2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Address2 { get; set; } 

        [JsonProperty("address3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Address3 { get; set; } 

        [JsonProperty("address4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Address4 { get; set; } 

        [JsonProperty("address5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Address5 { get; set; } 

        [JsonProperty("deladdress1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deladdress1 { get; set; } 

        [JsonProperty("deladdress2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deladdress2 { get; set; } 

        [JsonProperty("deladdress3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deladdress3 { get; set; } 

        [JsonProperty("deladdress4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deladdress4 { get; set; } 

        [JsonProperty("deladdress5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deladdress5 { get; set; } 

        [JsonProperty("tel_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tel_number { get; set; } 

        [JsonProperty("contactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contactname { get; set; } 

        [JsonProperty("global_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Global_tax_code { get; set; } 

        [JsonProperty("invoice_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Invoice_date { get; set; } 

        [JsonProperty("schedule_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Schedule_date { get; set; } 

        [JsonProperty("dateposted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Dateposted { get; set; } 

        [JsonProperty("last_synced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_synced { get; set; } 

        [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_modified { get; set; } 

        [JsonProperty("notes_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notes_1 { get; set; } 

        [JsonProperty("notes_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notes_2 { get; set; } 

        [JsonProperty("notes_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notes_3 { get; set; } 

        [JsonProperty("taken_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Taken_by { get; set; } 

        [JsonProperty("order_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Order_number { get; set; } 

        [JsonProperty("cust_order_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cust_order_number { get; set; } 

        [JsonProperty("payment_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Payment_ref { get; set; } 

        [JsonProperty("global_nom_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Global_nom_code { get; set; } 

        [JsonProperty("global_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Global_details { get; set; } 

        [JsonProperty("invoice_type_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoice_type_code { get; set; } 

        [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesorder_id { get; set; } 

        [JsonProperty("datetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Datetype { get; set; } 

        [JsonProperty("percentold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Percentold { get; set; } 

        [JsonProperty("percent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Percent { get; set; } 

        [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contract_id { get; set; } 

        [JsonProperty("contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contract_ref { get; set; } 

        [JsonProperty("datesent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datesent { get; set; } 

        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Currency { get; set; } 

        [JsonProperty("currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Currency_code { get; set; } 

        [JsonProperty("currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Currency_code_name { get; set; } 

        [JsonProperty("currency_conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Currency_conversion_rate { get; set; } 

        [JsonProperty("paymentterms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Paymentterms { get; set; } 

        [JsonProperty("hideinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hideinvoice { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("invoicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoicetype { get; set; } 

        [JsonProperty("datepaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datepaid { get; set; } 

        [JsonProperty("paymentstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Paymentstatus { get; set; } 

        [JsonProperty("xeroid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xeroid { get; set; } 

        [JsonProperty("amountpaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Amountpaid { get; set; } 

        [JsonProperty("amountdue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Amountdue { get; set; } 

        [JsonProperty("amount_remaining", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount_remaining { get; set; } 

        [JsonProperty("emailstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Emailstatus { get; set; } 

        [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Address { get; set; } 

        [JsonProperty("shipaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Shipaddress { get; set; } 

        [JsonProperty("originaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Originaddress { get; set; } 

        [JsonProperty("lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InvoiceDetail>? Lines { get; set; } 

        [JsonProperty("add_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InvoiceDetail>? Add_lines { get; set; } 

        [JsonProperty("_print_preview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _print_preview { get; set; } 

        [JsonProperty("_print_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _print_generate { get; set; } 

        [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Printhtml { get; set; } 

        [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pdf_attachment_id { get; set; } 

        [JsonProperty("pdf_attachment_date_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Pdf_attachment_date_created { get; set; } 

        [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pdftemplate_id { get; set; } 

        [JsonProperty("pdftemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pdftemplate_name { get; set; } 

        [JsonProperty("composite_tax_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Composite_tax_total { get; set; } 

        [JsonProperty("total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total { get; set; } 

        [JsonProperty("reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Reference { get; set; } 

        [JsonProperty("duedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Duedate { get; set; } 

        [JsonProperty("_is_invoice_run", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _is_invoice_run { get; set; } 

        [JsonProperty("_billing_cut_off", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? _billing_cut_off { get; set; } 

        [JsonProperty("is_recurring_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_recurring_invoice { get; set; } 

        [JsonProperty("schedule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Schedule_id { get; set; } 

        [JsonProperty("lastcreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastcreated { get; set; } 

        [JsonProperty("nextcreationdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Nextcreationdate { get; set; } 

        [JsonProperty("period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; } 

        [JsonProperty("schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public StdRequest? Schedule { get; set; } 

        [JsonProperty("create_recurring_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Create_recurring_invoice { get; set; } 

        [JsonProperty("take_auto_payment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Take_auto_payment { get; set; } 

        [JsonProperty("recurring_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Recurring_invoice_id { get; set; } 

        [JsonProperty("add_contract_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Add_contract_assets { get; set; } 

        [JsonProperty("add_labour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Add_labour { get; set; } 

        [JsonProperty("add_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Add_project { get; set; } 

        [JsonProperty("add_travel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Add_travel { get; set; } 

        [JsonProperty("add_mileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Add_mileage { get; set; } 

        [JsonProperty("add_itemsissued", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Add_itemsissued { get; set; } 

        [JsonProperty("add_prepay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Add_prepay { get; set; } 

        [JsonProperty("add_salesorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Add_salesorder { get; set; } 

        [JsonProperty("force_creation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force_creation { get; set; } 

        [JsonProperty("_create_from_areaitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaItem>? _create_from_areaitems { get; set; } 

        [JsonProperty("_create_from_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _create_from_contract { get; set; } 

        [JsonProperty("_validateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _validateonly { get; set; } 

        [JsonProperty("qboid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qboid { get; set; } 

        [JsonProperty("billingcategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Billingcategory { get; set; } 

        [JsonProperty("_sendmassinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _sendmassinvoice { get; set; } 

        [JsonProperty("xero_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_tenant_id { get; set; } 

        [JsonProperty("xero_branding_theme_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_branding_theme_id { get; set; } 

        [JsonProperty("xero_branding_theme_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_branding_theme_name { get; set; } 

        [JsonProperty("xero_branding_theme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? Xero_branding_theme { get; set; } 

        [JsonProperty("due_date_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Due_date_int { get; set; } 

        [JsonProperty("due_date_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Due_date_type { get; set; } 

        [JsonProperty("createdbyagentname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Createdbyagentname { get; set; } 

        [JsonProperty("internal_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Internal_note { get; set; } 

        [JsonProperty("mailboxid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailboxid { get; set; } 

        [JsonProperty("period_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Period_type { get; set; } 

        [JsonProperty("kashflow_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kashflow_tenant_id { get; set; } 

        [JsonProperty("kashflowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kashflowid { get; set; } 

        [JsonProperty("kashflow_pdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kashflow_pdf { get; set; } 

        [JsonProperty("original_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Original_client_id { get; set; } 

        [JsonProperty("original_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Original_client_name { get; set; } 

        [JsonProperty("xero_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_status { get; set; } 

        [JsonProperty("merge_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InvoiceHeaderMerge>? Merge_data { get; set; } 

        [JsonProperty("snelstart_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snelstart_id { get; set; } 

        [JsonProperty("time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Time { get; set; } 

        [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdate { get; set; } 

        [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Enddate { get; set; } 

        [JsonProperty("daysplus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Daysplus { get; set; } 

        [JsonProperty("periodname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Periodname { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("duedatename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Duedatename { get; set; } 

        [JsonProperty("date_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_created { get; set; } 

        [JsonProperty("invoice_prorata_periods_ahead", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_prorata_periods_ahead { get; set; } 

        [JsonProperty("nextcreationperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nextcreationperiod { get; set; } 

        [JsonProperty("qbo_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbo_company_id { get; set; } 

        [JsonProperty("intacct_recordno", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intacct_recordno { get; set; } 

        [JsonProperty("period_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Period_start_date { get; set; } 

        [JsonProperty("period_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Period_end_date { get; set; } 

        [JsonProperty("payments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InvoicePayment_List>? Payments { get; set; } 

        [JsonProperty("markaspaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Markaspaid { get; set; } 

        [JsonProperty("markaspaidmoduleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Markaspaidmoduleid { get; set; } 

        [JsonProperty("dbc_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dbc_id { get; set; } 

        [JsonProperty("dbc_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dbc_company_id { get; set; } 

        [JsonProperty("reviewrequired", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reviewrequired { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("_xmlwarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _xmlwarning { get; set; } 

        [JsonProperty("creditlinkedtoinvoiceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Creditlinkedtoinvoiceid { get; set; } 

        [JsonProperty("creditlinkedtoinvoiceid_thirdpartynumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Creditlinkedtoinvoiceid_thirdpartynumber { get; set; } 

        [JsonProperty("creditlinkedtoinvoiceid_typeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Creditlinkedtoinvoiceid_typeid { get; set; } 

        [JsonProperty("purchaseorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Purchaseorder_id { get; set; } 

        [JsonProperty("sage_business_cloud_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sage_business_cloud_details_id { get; set; } 

        [JsonProperty("sage_business_cloud_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage_business_cloud_id { get; set; } 

        [JsonProperty("exact_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exact_id { get; set; } 

        [JsonProperty("exact_division", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Exact_division { get; set; } 

        [JsonProperty("xero_line_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_line_tax { get; set; } 

        [JsonProperty("invoice_auto_increase_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_auto_increase_period { get; set; } 

        [JsonProperty("invoice_percent_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Invoice_percent_increase { get; set; } 

        [JsonProperty("schedule_ignore_delete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Schedule_ignore_delete { get; set; } 

        [JsonProperty("assigned_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assigned_agent { get; set; } 

        [JsonProperty("assigned_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assigned_agent_name { get; set; } 

        [JsonProperty("approval_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approval_status { get; set; } 

        [JsonProperty("approvalagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approvalagent { get; set; } 

        [JsonProperty("approvalemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approvalemailaddress { get; set; } 

        [JsonProperty("approvalnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approvalnote { get; set; } 

        [JsonProperty("approvalagentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approvalagentid { get; set; } 

        [JsonProperty("approvaldatetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Approvaldatetime { get; set; } 

        [JsonProperty("ticket_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticket_summary { get; set; } 

        [JsonProperty("ticket_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticket_note { get; set; } 

        [JsonProperty("approval_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Approval_start { get; set; } 

        [JsonProperty("requires_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Requires_approval { get; set; } 

        [JsonProperty("xero_online_invoice_payment_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_online_invoice_payment_url { get; set; } 

        [JsonProperty("generic_online_invoice_payment_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Generic_online_invoice_payment_url { get; set; } 

        [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_save_location { get; set; } 

        [JsonProperty("intacctseparatetaxline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intacctseparatetaxline { get; set; } 

        [JsonProperty("intacct_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_class { get; set; } 

        [JsonProperty("intacct_class_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_class_name { get; set; } 

        [JsonProperty("take_payment_on_duedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Take_payment_on_duedate { get; set; } 

        [JsonProperty("contains_calculated_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Contains_calculated_quantity { get; set; } 

        [JsonProperty("intacct_tax_solution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_tax_solution { get; set; } 

        [JsonProperty("intacct_tax_solution_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_tax_solution_name { get; set; } 

        [JsonProperty("intacct_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_project { get; set; } 

        [JsonProperty("intacct_project_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_project_name { get; set; } 

        [JsonProperty("_create_credit_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _create_credit_note { get; set; } 

        [JsonProperty("credit_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Credit_total { get; set; } 

        [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_id { get; set; } 

        [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_name { get; set; } 

        [JsonProperty("_dont_fire_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dont_fire_automations { get; set; } 

        [JsonProperty("_is_process", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _is_process { get; set; } 

        [JsonProperty("_is_task_schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _is_task_schedule { get; set; } 

        [JsonProperty("payments_pending", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Payments_pending { get; set; } 

        [JsonProperty("include_in_autopay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Include_in_autopay { get; set; } 

        [JsonProperty("_forcethirdpartysync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _forcethirdpartysync { get; set; } 

        [JsonProperty("client_to_invoice_to_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_to_invoice_to_id { get; set; } 

        [JsonProperty("creation_source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Creation_source { get; set; } 

        [JsonProperty("typeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Typeid { get; set; } 

        [JsonProperty("twilio_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Twilio_invoice { get; set; } 

        [JsonProperty("invoice_separately", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invoice_separately { get; set; } 

        [JsonProperty("minimum_price_active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Minimum_price_active { get; set; } 

        [JsonProperty("minimum_line_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Minimum_line_description { get; set; } 

        [JsonProperty("minimum_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Minimum_amount { get; set; } 

        [JsonProperty("avalara_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Avalara_details_id { get; set; } 

        [JsonProperty("qbo_term_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbo_term_name { get; set; } 

        [JsonProperty("qbo_term_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qbo_term_id { get; set; } 

        [JsonProperty("qbo_term", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? Qbo_term { get; set; } 

        [JsonProperty("exact_payment_conditon_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exact_payment_conditon_name { get; set; } 

        [JsonProperty("exact_payment_conditon_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exact_payment_conditon_id { get; set; } 

        [JsonProperty("exact_payment_conditon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? Exact_payment_conditon { get; set; } 

        [JsonProperty("avalara_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Avalara_details_name { get; set; } 

        [JsonProperty("voided", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Voided { get; set; } 

        [JsonProperty("credit_outstanding_for_customer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Credit_outstanding_for_customer { get; set; } 

        [JsonProperty("credit_outstanding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Credit_outstanding { get; set; } 

        [JsonProperty("credit_used", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Credit_used { get; set; } 

        [JsonProperty("mark_credit_as_used", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mark_credit_as_used { get; set; } 

        [JsonProperty("apply_credit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Apply_credit { get; set; } 

        [JsonProperty("apply_credit_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Apply_credit_id { get; set; } 

        [JsonProperty("apply_credit_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Apply_credit_amount { get; set; } 

        [JsonProperty("apply_credit_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Apply_credit_description { get; set; } 

        [JsonProperty("apply_credit_long_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Apply_credit_long_description { get; set; } 

        [JsonProperty("apply_credit_tax_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Apply_credit_tax_type { get; set; } 

        [JsonProperty("invoice_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoice_display { get; set; } 

        [JsonProperty("_novalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _novalidate { get; set; } 

        [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sqlimport_id { get; set; } 

        [JsonProperty("invoice_match_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoice_match_id { get; set; } 

        [JsonProperty("sync_include_paid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_include_paid { get; set; } 

        [JsonProperty("dont_set_original_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_set_original_client_id { get; set; } 

        [JsonProperty("_docommitsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _docommitsync { get; set; } 

        [JsonProperty("_ignore_dont_send_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _ignore_dont_send_invoice { get; set; } 

        [JsonProperty("ticket_client_to_invoice_to_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_client_to_invoice_to_id { get; set; } 

        [JsonProperty("originaddress1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Originaddress1 { get; set; } 

        [JsonProperty("originaddress2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Originaddress2 { get; set; } 

        [JsonProperty("originaddress3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Originaddress3 { get; set; } 

        [JsonProperty("originaddress4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Originaddress4 { get; set; } 

        [JsonProperty("originaddress5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Originaddress5 { get; set; } 

        [JsonProperty("most_recent_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Most_recent_invoice_id { get; set; } 

        [JsonProperty("most_recent_invoice_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Most_recent_invoice_type { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomButton>? Custombuttons { get; set; } 

        [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tabname>? Extratabs { get; set; } 

        [JsonProperty("update_invoice_conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Update_invoice_conversion_rate { get; set; } 

        [JsonProperty("conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Conversion_rate { get; set; } 

        [JsonProperty("dont_sync_to_3rd_party", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_sync_to_3rd_party { get; set; } 

        [JsonProperty("is_invoice_screen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_invoice_screen { get; set; } 

        [JsonProperty("_dotaxsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dotaxsync { get; set; } 

        [JsonProperty("tax_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Tax_total { get; set; } 

        [JsonProperty("revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Revenue { get; set; } 

        [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? External_links { get; set; } 

        [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _importtypeid { get; set; } 

        [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importthirdpartyid { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? New_external_link { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class InvoiceHeaderMerge
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_id { get; set; } 

        [JsonProperty("recurring_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Recurring_invoice_id { get; set; } 

        [JsonProperty("schedule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Schedule_id { get; set; } 

        [JsonProperty("schedule_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Schedule_date { get; set; } 

        [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contract_id { get; set; } 

        [JsonProperty("contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contract_ref { get; set; } 

        [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesorder_id { get; set; } 

        [JsonProperty("percent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Percent { get; set; } 

        [JsonProperty("due_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Due_date { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class InvoicePayment_List
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_id { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; } 

        [JsonProperty("method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Method { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; } 

        [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Module_id { get; set; } 

        [JsonProperty("intent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent_id { get; set; } 

        [JsonProperty("intent_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Intent_date { get; set; } 

        [JsonProperty("intent_response", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent_response { get; set; } 

        [JsonProperty("webhook_payload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webhook_payload { get; set; } 

        [JsonProperty("webhook_received_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Webhook_received_date { get; set; } 

        [JsonProperty("sage50_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50_reference { get; set; } 

        [JsonProperty("thirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartyid { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("_statuswarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _statuswarning { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("qbo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qbo_id { get; set; } 

        [JsonProperty("xero_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_id { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sqlimport_id { get; set; } 

        [JsonProperty("invoice_match_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoice_match_id { get; set; } 

        [JsonProperty("invoice_invoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoice_invoicenumber { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Item
    {
        [JsonProperty("asset_type_matching_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Asset_type_matching_field_name { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; } 

        [JsonProperty("assetgroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetgroup_id { get; set; } 

        [JsonProperty("assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetgroup_name { get; set; } 

        [JsonProperty("third_party_assetgroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_assetgroup_id { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("supplier_part_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_part_code { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("purchase_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Purchase_description { get; set; } 

        [JsonProperty("internalreference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Internalreference { get; set; } 

        [JsonProperty("externalreference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Externalreference { get; set; } 

        [JsonProperty("quantity_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity_in_stock { get; set; } 

        [JsonProperty("quantity_reserved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity_reserved { get; set; } 

        [JsonProperty("quantity_on_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity_on_order { get; set; } 

        [JsonProperty("goodsinunit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Goodsinunit { get; set; } 

        [JsonProperty("goodsoutunit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Goodsoutunit { get; set; } 

        [JsonProperty("inoutconversion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inoutconversion { get; set; } 

        [JsonProperty("qtyissuedthisyear", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Qtyissuedthisyear { get; set; } 

        [JsonProperty("baseprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Baseprice { get; set; } 

        [JsonProperty("created_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Created_by { get; set; } 

        [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_id { get; set; } 

        [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_name { get; set; } 

        [JsonProperty("manufacturer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Manufacturer_id { get; set; } 

        [JsonProperty("manufacturer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Manufacturer_name { get; set; } 

        [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettype_id { get; set; } 

        [JsonProperty("assettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assettype_name { get; set; } 

        [JsonProperty("minstockqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Minstockqty { get; set; } 

        [JsonProperty("min_purchase_qty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Min_purchase_qty { get; set; } 

        [JsonProperty("secondprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Secondprice { get; set; } 

        [JsonProperty("promptforprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Promptforprice { get; set; } 

        [JsonProperty("sleeveprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Sleeveprice { get; set; } 

        [JsonProperty("taxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Taxcode { get; set; } 

        [JsonProperty("taxcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Taxcode_name { get; set; } 

        [JsonProperty("taxcodeother", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Taxcodeother { get; set; } 

        [JsonProperty("taxcodeother_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Taxcodeother_name { get; set; } 

        [JsonProperty("costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Costprice { get; set; } 

        [JsonProperty("accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountsid { get; set; } 

        [JsonProperty("margin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Margin { get; set; } 

        [JsonProperty("reorderqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Reorderqty { get; set; } 

        [JsonProperty("binlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Binlocation { get; set; } 

        [JsonProperty("nominalcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nominalcode { get; set; } 

        [JsonProperty("costingmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Costingmethod { get; set; } 

        [JsonProperty("servicefee", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Servicefee { get; set; } 

        [JsonProperty("recovery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Recovery { get; set; } 

        [JsonProperty("avco", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Avco { get; set; } 

        [JsonProperty("qtyonallsalesorders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Qtyonallsalesorders { get; set; } 

        [JsonProperty("doesnotneedconsigning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Doesnotneedconsigning { get; set; } 

        [JsonProperty("shaccountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Shaccountsid { get; set; } 

        [JsonProperty("applydiscount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Applydiscount { get; set; } 

        [JsonProperty("secondhandprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Secondhandprice { get; set; } 

        [JsonProperty("hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Hours { get; set; } 

        [JsonProperty("markupperc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Markupperc { get; set; } 

        [JsonProperty("metertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Metertype { get; set; } 

        [JsonProperty("meterlife", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Meterlife { get; set; } 

        [JsonProperty("isrecurringitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isrecurringitem { get; set; } 

        [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Template_id { get; set; } 

        [JsonProperty("template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Template_name { get; set; } 

        [JsonProperty("recurringprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Recurringprice { get; set; } 

        [JsonProperty("showmobilescanner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showmobilescanner { get; set; } 

        [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon { get; set; } 

        [JsonProperty("icon_download_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon_download_url { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("group_third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Group_third_party_id { get; set; } 

        [JsonProperty("sagetoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sagetoken { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_id { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomButton>? Custombuttons { get; set; } 

        [JsonProperty("item_suppliers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ItemSupplier>? Item_suppliers { get; set; } 

        [JsonProperty("xero_salestax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_salestax { get; set; } 

        [JsonProperty("xero_purchasetax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_purchasetax { get; set; } 

        [JsonProperty("purchasenominalcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Purchasenominalcode { get; set; } 

        [JsonProperty("fullyqualifiedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fullyqualifiedname { get; set; } 

        [JsonProperty("salestaxincluded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Salestaxincluded { get; set; } 

        [JsonProperty("purchasetaxincluded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Purchasetaxincluded { get; set; } 

        [JsonProperty("taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Taxable { get; set; } 

        [JsonProperty("assetaccountcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetaccountcode { get; set; } 

        [JsonProperty("qbo_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qbo_quantity { get; set; } 

        [JsonProperty("qboinitial_quantity_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Qboinitial_quantity_date { get; set; } 

        [JsonProperty("stocklocations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Site_List>? Stocklocations { get; set; } 

        [JsonProperty("xero_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_tenant_id { get; set; } 

        [JsonProperty("xero_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_tenant_name { get; set; } 

        [JsonProperty("xerodetails_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Xerodetails_id { get; set; } 

        [JsonProperty("income_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Income_account_name { get; set; } 

        [JsonProperty("expense_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Expense_account_name { get; set; } 

        [JsonProperty("asset_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Asset_account_name { get; set; } 

        [JsonProperty("income_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? Income_account { get; set; } 

        [JsonProperty("expense_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? Expense_account { get; set; } 

        [JsonProperty("asset_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? Asset_account { get; set; } 

        [JsonProperty("qbosku", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbosku { get; set; } 

        [JsonProperty("qbocategoryid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbocategoryid { get; set; } 

        [JsonProperty("qbocategoryname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbocategoryname { get; set; } 

        [JsonProperty("qbo_category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? Qbo_category { get; set; } 

        [JsonProperty("autotaskserviceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Autotaskserviceid { get; set; } 

        [JsonProperty("autotaskproductid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Autotaskproductid { get; set; } 

        [JsonProperty("iscontractitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Iscontractitem { get; set; } 

        [JsonProperty("dontinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontinvoice { get; set; } 

        [JsonProperty("kashflowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kashflowid { get; set; } 

        [JsonProperty("kashflow_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kashflow_tenant_id { get; set; } 

        [JsonProperty("kashflow_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kashflow_tenant_name { get; set; } 

        [JsonProperty("nominalcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nominalcode_name { get; set; } 

        [JsonProperty("purchasenominalcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Purchasenominalcode_name { get; set; } 

        [JsonProperty("linked_item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linked_item_id { get; set; } 

        [JsonProperty("linked_item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Linked_item_name { get; set; } 

        [JsonProperty("update_recurring_invoice_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Update_recurring_invoice_price { get; set; } 

        [JsonProperty("update_recurring_invoice_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Update_recurring_invoice_cost { get; set; } 

        [JsonProperty("snelstart_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snelstart_id { get; set; } 

        [JsonProperty("snelstart_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snelstart_department_id { get; set; } 

        [JsonProperty("snelstart_department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snelstart_department_name { get; set; } 

        [JsonProperty("snelstart_department", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? Snelstart_department { get; set; } 

        [JsonProperty("linked_asset_defaults", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ItemDeviceDefaults>? Linked_asset_defaults { get; set; } 

        [JsonProperty("maxitemdiscount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Maxitemdiscount { get; set; } 

        [JsonProperty("item_default_billing_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_default_billing_period { get; set; } 

        [JsonProperty("primaryimageid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Primaryimageid { get; set; } 

        [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datecreated { get; set; } 

        [JsonProperty("lastmodified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastmodified { get; set; } 

        [JsonProperty("qbo_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbo_company_id { get; set; } 

        [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Import_details_id { get; set; } 

        [JsonProperty("quickbooks_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public QuickBooksDetails? Quickbooks_details { get; set; } 

        [JsonProperty("qbo_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbo_company_name { get; set; } 

        [JsonProperty("extra_invoice_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? Extra_invoice_description { get; set; } 

        [JsonProperty("isitemdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isitemdetails { get; set; } 

        [JsonProperty("intacct_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_type { get; set; } 

        [JsonProperty("item_group_nominalcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_group_nominalcode { get; set; } 

        [JsonProperty("item_group_nominalcode_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_group_nominalcode_purchase { get; set; } 

        [JsonProperty("item_group_itemcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_group_itemcode { get; set; } 

        [JsonProperty("item_group_taxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_group_taxcode { get; set; } 

        [JsonProperty("item_group_taxcode_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_group_taxcode_purchase { get; set; } 

        [JsonProperty("recurringcost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Recurringcost { get; set; } 

        [JsonProperty("dbc_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dbc_company_id { get; set; } 

        [JsonProperty("dbc_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dbc_company_name { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

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

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("sage_business_cloud_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sage_business_cloud_details_id { get; set; } 

        [JsonProperty("sage_business_cloud_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage_business_cloud_details_name { get; set; } 

        [JsonProperty("budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Budgettype_id { get; set; } 

        [JsonProperty("budgettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Budgettype_name { get; set; } 

        [JsonProperty("serialise_only_one", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Serialise_only_one { get; set; } 

        [JsonProperty("exact_division", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Exact_division { get; set; } 

        [JsonProperty("exact_division_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exact_division_name { get; set; } 

        [JsonProperty("dattocommerce_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dattocommerce_tenant { get; set; } 

        [JsonProperty("user_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_description { get; set; } 

        [JsonProperty("weight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Weight { get; set; } 

        [JsonProperty("ignore_from_accounting_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ignore_from_accounting_sync { get; set; } 

        [JsonProperty("invoice_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoice_class { get; set; } 

        [JsonProperty("sage50uk_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sage50uk_department_id { get; set; } 

        [JsonProperty("dont_track_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_track_stock { get; set; } 

        [JsonProperty("dont_receive_on_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_receive_on_po { get; set; } 

        [JsonProperty("xero_inventory_account_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_inventory_account_code { get; set; } 

        [JsonProperty("xero_cogs_account_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_cogs_account_code { get; set; } 

        [JsonProperty("xero_inventory_account_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_inventory_account_code_name { get; set; } 

        [JsonProperty("xero_cogs_account_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_cogs_account_code_name { get; set; } 

        [JsonProperty("intacct_product_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_product_line_id { get; set; } 

        [JsonProperty("_updateitemtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _updateitemtype { get; set; } 

        [JsonProperty("related_item_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Related_item_count { get; set; } 

        [JsonProperty("myob_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Myob_tenant { get; set; } 

        [JsonProperty("myob_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Myob_tenant_name { get; set; } 

        [JsonProperty("myob_asset_account_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Myob_asset_account_code { get; set; } 

        [JsonProperty("items_per_buying_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Items_per_buying_price { get; set; } 

        [JsonProperty("items_per_selling_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Items_per_selling_price { get; set; } 

        [JsonProperty("avalara_item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Avalara_item_code { get; set; } 

        [JsonProperty("purchase_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Purchase_currency_code { get; set; } 

        [JsonProperty("purchase_currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Purchase_currency_code_name { get; set; } 

        [JsonProperty("purchase_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Currency? Purchase_currency { get; set; } 

        [JsonProperty("autorenew_quote_line_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autorenew_quote_line_default { get; set; } 

        [JsonProperty("price_calculated_from_components", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Price_calculated_from_components { get; set; } 

        [JsonProperty("cost_calculated_from_components", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cost_calculated_from_components { get; set; } 

        [JsonProperty("auto_reorder_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Auto_reorder_type { get; set; } 

        [JsonProperty("relatedcategories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IdValueKeyPair>? Relatedcategories { get; set; } 

        [JsonProperty("relatedcategories_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Relatedcategories_list { get; set; } 

        [JsonProperty("item_listed_only_on_bundle_setup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Item_listed_only_on_bundle_setup { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ItemDeviceDefaults
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("iid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Iid { get; set; } 

        [JsonProperty("dtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dtype { get; set; } 

        [JsonProperty("yseq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Yseq { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ItemGroup
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<QuotationDetail>? Lines { get; set; } 

        [JsonProperty("oldLines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<QuotationDetail>? OldLines { get; set; } 

        [JsonProperty("hideitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hideitems { get; set; } 

        [JsonProperty("add_all_group_items_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Add_all_group_items_quote { get; set; } 

        [JsonProperty("quantity_group_items_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity_group_items_quote { get; set; } 

        [JsonProperty("hide_items_group_items_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Hide_items_group_items_quote { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("hide_grouped_items_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Hide_grouped_items_price { get; set; } 

        [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category { get; set; } 

        [JsonProperty("name_extra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name_extra { get; set; } 

        [JsonProperty("one_optional_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? One_optional_mandatory { get; set; } 

        [JsonProperty("one_optional_mandatory_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? One_optional_mandatory_list { get; set; } 

        [JsonProperty("default_billingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_billingperiod { get; set; } 

        [JsonProperty("nominal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nominal_code { get; set; } 

        [JsonProperty("force_quantity_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force_quantity_relationship { get; set; } 

        [JsonProperty("force_price_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force_price_relationship { get; set; } 

        [JsonProperty("force_term_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force_term_relationship { get; set; } 

        [JsonProperty("price_calculation_formula", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Price_calculation_formula { get; set; } 

        [JsonProperty("_updaterecurringbundleprices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _updaterecurringbundleprices { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ItemId
    {
        [JsonProperty("uniqueId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UniqueId { get; set; } 

        [JsonProperty("changeKey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChangeKey { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ItemRestriction
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_id { get; set; } 

        [JsonProperty("servicerequest_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Servicerequest_id { get; set; } 

        [JsonProperty("item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ItemStock
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_id { get; set; } 

        [JsonProperty("item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_name { get; set; } 

        [JsonProperty("item_assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_assettype_id { get; set; } 

        [JsonProperty("stocklocation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stocklocation_id { get; set; } 

        [JsonProperty("stocklocation_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stocklocation_name { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("quantity_in", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity_in { get; set; } 

        [JsonProperty("quantity_issued", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity_issued { get; set; } 

        [JsonProperty("quantity_remaining", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity_remaining { get; set; } 

        [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cost { get; set; } 

        [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_id { get; set; } 

        [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_name { get; set; } 

        [JsonProperty("purchaseorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Purchaseorder_id { get; set; } 

        [JsonProperty("purchaseorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Purchaseorder_line_id { get; set; } 

        [JsonProperty("purchaseorder_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Purchaseorder_ref { get; set; } 

        [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesorder_id { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("serialised_asset_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Serialised_asset_count { get; set; } 

        [JsonProperty("serialised_assets_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Serialised_assets_in_stock { get; set; } 

        [JsonProperty("serialised_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Serialised_assets { get; set; } 

        [JsonProperty("is_stock_take", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_stock_take { get; set; } 

        [JsonProperty("delivering_to_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delivering_to_user { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("line_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Line_site_id { get; set; } 

        [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stockbin_id { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("real_quantity_in", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Real_quantity_in { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("stockbin_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stockbin_name { get; set; } 

        [JsonProperty("serialise_only_one", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Serialise_only_one { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ItemSupplier
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_id { get; set; } 

        [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_id { get; set; } 

        [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_name { get; set; } 

        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Price { get; set; } 

        [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cost { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("supplier_sku", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_sku { get; set; } 

        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ViewFilterDetails>? Filters { get; set; } 

        [JsonProperty("_is_new", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _is_new { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }