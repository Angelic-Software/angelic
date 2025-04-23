using System.CodeDom.Compiler;
using Angelic.Appointment;
using Angelic.Dtos;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class EWSAppointmentBasic
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ItemId? Id { get; set; } 

        [JsonProperty("iCalUid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ICalUid { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Start { get; set; } 

        [JsonProperty("end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End { get; set; } 

        [JsonProperty("organizer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public EmailAddress? Organizer { get; set; } 

        [JsonProperty("appointmentType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppointmentType? AppointmentType { get; set; } 

        [JsonProperty("isAllDayEvent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAllDayEvent { get; set; } 

        [JsonProperty("isRecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRecurring { get; set; } 

        [JsonProperty("isMeeting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMeeting { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class EWSAppointmentChange
    {
        [JsonProperty("changeType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ChangeType? ChangeType { get; set; } 

        [JsonProperty("itemId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ItemId? ItemId { get; set; } 

        [JsonProperty("item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public EWSAppointmentBasic? Item { get; set; } 

        [JsonProperty("agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Uname_List? Agent { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class EcommerceOrder
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("moduleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Moduleid { get; set; } 

        [JsonProperty("thirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartyid { get; set; } 

        [JsonProperty("thirdpartyurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartyurl { get; set; } 

        [JsonProperty("thirdpartyordernumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartyordernumber { get; set; } 

        [JsonProperty("thirdpartycustomerid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartycustomerid { get; set; } 

        [JsonProperty("thirdpartystatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartystatus { get; set; } 

        [JsonProperty("thirdpartystatus2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartystatus2 { get; set; } 

        [JsonProperty("thirdpartycreateddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Thirdpartycreateddate { get; set; } 

        [JsonProperty("integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integration_name { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Details_id { get; set; } 

        [JsonProperty("shop_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Shop_name { get; set; } 

        [JsonProperty("_unlink_from_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _unlink_from_ticket { get; set; } 

        [JsonProperty("jsonobj", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jsonobj { get; set; } 

        [JsonProperty("_amazon_buyer_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AmazonSellerBuyerInfo? _amazon_buyer_info { get; set; } 

        [JsonProperty("_adobecommerce_billing_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AdobeCommerceBilling_Address? _adobecommerce_billing_address { get; set; } 

        [JsonProperty("linked_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<EcommerceOrderFault>? Linked_tickets { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class EcommerceOrderFault
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("eo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Eo_id { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("third_party_order_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_order_id { get; set; } 

        [JsonProperty("third_party_order_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_order_url { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class EmailAddress
    {
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Address { get; set; } 

        [JsonProperty("routingType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RoutingType { get; set; } 

        [JsonProperty("mailboxType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MailboxType? MailboxType { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ItemId? Id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class EmailRule
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("pop3serverid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pop3serverid { get; set; } 

        [JsonProperty("mailbox_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mailbox_name { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Body { get; set; } 

        [JsonProperty("fromaddr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fromaddr { get; set; } 

        [JsonProperty("toaddr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Toaddr { get; set; } 

        [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } 

        [JsonProperty("starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Starttag { get; set; } 

        [JsonProperty("endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Endtag { get; set; } 

        [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fieldname { get; set; } 

        [JsonProperty("length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Length { get; set; } 

        [JsonProperty("useendofline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useendofline { get; set; } 

        [JsonProperty("2starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _2starttag { get; set; } 

        [JsonProperty("2endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _2endtag { get; set; } 

        [JsonProperty("2fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _2fieldname { get; set; } 

        [JsonProperty("2length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _2length { get; set; } 

        [JsonProperty("2useendofline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _2useendofline { get; set; } 

        [JsonProperty("3starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _3starttag { get; set; } 

        [JsonProperty("3endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _3endtag { get; set; } 

        [JsonProperty("3fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _3fieldname { get; set; } 

        [JsonProperty("3length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _3length { get; set; } 

        [JsonProperty("3useendofline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _3useendofline { get; set; } 

        [JsonProperty("closestring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Closestring { get; set; } 

        [JsonProperty("requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Requesttype { get; set; } 

        [JsonProperty("4starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _4starttag { get; set; } 

        [JsonProperty("4endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _4endtag { get; set; } 

        [JsonProperty("4fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _4fieldname { get; set; } 

        [JsonProperty("4length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _4length { get; set; } 

        [JsonProperty("4useendofline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _4useendofline { get; set; } 

        [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Seq { get; set; } 

        [JsonProperty("pagerduty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Pagerduty { get; set; } 

        [JsonProperty("fromaddrexact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fromaddrexact { get; set; } 

        [JsonProperty("toaddrexact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Toaddrexact { get; set; } 

        [JsonProperty("privateactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Privateactions { get; set; } 

        [JsonProperty("3useticketuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _3useticketuser { get; set; } 

        [JsonProperty("fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<EmailRuleFieldMapping>? Fieldmappings { get; set; } 

        [JsonProperty("endtagmatchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Endtagmatchtype { get; set; } 

        [JsonProperty("3matchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _3matchtype { get; set; } 

        [JsonProperty("3endtagmatchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _3endtagmatchtype { get; set; } 

        [JsonProperty("pagerdutyagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pagerdutyagent { get; set; } 

        [JsonProperty("pagerduty_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerduty_service { get; set; } 

        [JsonProperty("pagerduty_service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerduty_service_name { get; set; } 

        [JsonProperty("5starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _5starttag { get; set; } 

        [JsonProperty("5endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _5endtag { get; set; } 

        [JsonProperty("5fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _5fieldname { get; set; } 

        [JsonProperty("5length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _5length { get; set; } 

        [JsonProperty("5useendofline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _5useendofline { get; set; } 

        [JsonProperty("5endtagmatchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _5endtagmatchtype { get; set; } 

        [JsonProperty("splunkoncall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Splunkoncall { get; set; } 

        [JsonProperty("attachmentname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Attachmentname { get; set; } 

        [JsonProperty("attachmentmatchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Attachmentmatchtype { get; set; } 

        [JsonProperty("matchonattachment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Matchonattachment { get; set; } 

        [JsonProperty("matchccandbcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Matchccandbcc { get; set; } 

        [JsonProperty("6starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _6starttag { get; set; } 

        [JsonProperty("6endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _6endtag { get; set; } 

        [JsonProperty("6length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _6length { get; set; } 

        [JsonProperty("6useendofline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _6useendofline { get; set; } 

        [JsonProperty("6endtagmatchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _6endtagmatchtype { get; set; } 

        [JsonProperty("always_close_alerts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Always_close_alerts { get; set; } 

        [JsonProperty("closed_alerts_read_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Closed_alerts_read_status { get; set; } 

        [JsonProperty("dontsendacknowledgement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontsendacknowledgement { get; set; } 

        [JsonProperty("scan_full_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Scan_full_body { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("response_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Response_template_id { get; set; } 

        [JsonProperty("response_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Response_template_name { get; set; } 

        [JsonProperty("dont_update_from_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_update_from_address { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class EmailRuleFieldMapping
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("emailruleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Emailruleid { get; set; } 

        [JsonProperty("fieldid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fieldid { get; set; } 

        [JsonProperty("fieldtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fieldtype { get; set; } 

        [JsonProperty("searchtext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Searchtext { get; set; } 

        [JsonProperty("starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Starttag { get; set; } 

        [JsonProperty("endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Endtag { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

        [JsonProperty("searchresult", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Searchresult { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class EmailStore
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ref { get; set; } 

        [JsonProperty("emailsubject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailsubject { get; set; } 

        [JsonProperty("emailbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailbody { get; set; } 

        [JsonProperty("emailbody_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailbody_html { get; set; } 

        [JsonProperty("emailto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailto { get; set; } 

        [JsonProperty("emailcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailcc { get; set; } 

        [JsonProperty("dateemailed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Dateemailed { get; set; } 

        [JsonProperty("emailattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailattachments { get; set; } 

        [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Messagegroup_id { get; set; } 

        [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Faultid { get; set; } 

        [JsonProperty("templateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Templateid { get; set; } 

        [JsonProperty("emailbcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailbcc { get; set; } 

        [JsonProperty("keymessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Keymessage { get; set; } 

        [JsonProperty("reply_direct", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reply_direct { get; set; } 

        [JsonProperty("replyaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Replyaddress { get; set; } 

        [JsonProperty("addactionaftersending", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Addactionaftersending { get; set; } 

        [JsonProperty("mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailbox_id { get; set; } 

        [JsonProperty("org_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Org_id { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("test_credentials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Mailbox? Test_credentials { get; set; } 

        [JsonProperty("_emailsent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _emailsent { get; set; } 

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Attachment>? Attachments { get; set; } 

        [JsonProperty("quotation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quotation_id { get; set; } 

        [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesorder_id { get; set; } 

        [JsonProperty("purchaseorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Purchaseorder_id { get; set; } 

        [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_id { get; set; } 

        [JsonProperty("sales_mailbox_override_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sales_mailbox_override_id { get; set; } 

        [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datecreated { get; set; } 

        [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contract_id { get; set; } 

        [JsonProperty("bulk_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bulk_user_id { get; set; } 

        [JsonProperty("bulk_user_id_array", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? Bulk_user_id_array { get; set; } 

        [JsonProperty("_isbatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isbatch { get; set; } 

        [JsonProperty("kb_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kb_id { get; set; } 

        [JsonProperty("report_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Report_id { get; set; } 

        [JsonProperty("from_dl_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? From_dl_id { get; set; } 

        [JsonProperty("add_to_feed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Add_to_feed { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class EncoderFallback
    {
        [JsonProperty("maxCharCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxCharCount { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Encoding
    {
        [JsonProperty("bodyName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BodyName { get; set; } 

        [JsonProperty("encodingName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EncodingName { get; set; } 

        [JsonProperty("headerName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HeaderName { get; set; } 

        [JsonProperty("webName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WebName { get; set; } 

        [JsonProperty("windowsCodePage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WindowsCodePage { get; set; } 

        [JsonProperty("isBrowserDisplay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBrowserDisplay { get; set; } 

        [JsonProperty("isBrowserSave", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBrowserSave { get; set; } 

        [JsonProperty("isMailNewsDisplay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMailNewsDisplay { get; set; } 

        [JsonProperty("isMailNewsSave", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMailNewsSave { get; set; } 

        [JsonProperty("isSingleByte", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSingleByte { get; set; } 

        [JsonProperty("encoderFallback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public EncoderFallback? EncoderFallback { get; set; } 

        [JsonProperty("decoderFallback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DecoderFallback? DecoderFallback { get; set; } 

        [JsonProperty("isReadOnly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReadOnly { get; set; } 

        [JsonProperty("codePage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CodePage { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class EscMsg
    {
        [JsonProperty("emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailaddress { get; set; } 

        [JsonProperty("full", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Full { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("emailstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Emailstatus { get; set; } 

        [JsonProperty("popupstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Popupstatus { get; set; } 

        [JsonProperty("popupaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Popupaddress { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("emailbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailbody { get; set; } 

        [JsonProperty("emailbody_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailbody_html { get; set; } 

        [JsonProperty("ccaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ccaddress { get; set; } 

        [JsonProperty("smsstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Smsstatus { get; set; } 

        [JsonProperty("pushstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pushstatus { get; set; } 

        [JsonProperty("smsnos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Smsnos { get; set; } 

        [JsonProperty("smsbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Smsbody { get; set; } 

        [JsonProperty("sendemailifnopopup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendemailifnopopup { get; set; } 

        [JsonProperty("slackid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Slackid { get; set; } 

        [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Template_id { get; set; } 

        [JsonProperty("approval_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approval_id { get; set; } 

        [JsonProperty("msteamsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Msteamsid { get; set; } 

        [JsonProperty("deleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; } 

        [JsonProperty("apiversion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Apiversion { get; set; } 

        [JsonProperty("integratorwarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Integratorwarning { get; set; } 

        [JsonProperty("next_retry_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Next_retry_date { get; set; } 

        [JsonProperty("template_already_processed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Template_already_processed { get; set; } 

        [JsonProperty("mattermost_channelid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mattermost_channelid { get; set; } 

        [JsonProperty("replyto_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Replyto_address { get; set; } 

        [JsonProperty("mailbox_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailbox_from { get; set; } 

        [JsonProperty("batch_master", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Batch_master { get; set; } 

        [JsonProperty("batch_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Batch_use { get; set; } 

        [JsonProperty("batch_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Batch_status { get; set; } 

        [JsonProperty("batch_parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Batch_parent_id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("_ignoreperms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _ignoreperms { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("eventno", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Eventno { get; set; } 

        [JsonProperty("notification_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Notification_id { get; set; } 

        [JsonProperty("notification_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notification_name { get; set; } 

        [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Message { get; set; } 

        [JsonProperty("read_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Read_status { get; set; } 

        [JsonProperty("read_status_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Read_status_update { get; set; } 

        [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datetime { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("action_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Action_number { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("shown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Shown { get; set; } 

        [JsonProperty("key_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Key_id { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; } 

        [JsonProperty("status_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status_update { get; set; } 

        [JsonProperty("popupcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Popupcolour { get; set; } 

        [JsonProperty("attachment_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Attachment_type { get; set; } 

        [JsonProperty("at_entity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? At_entity { get; set; } 

        [JsonProperty("at_uniqueid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? At_uniqueid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class EventMapping
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("eventrule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Eventrule_id { get; set; } 

        [JsonProperty("eventrule_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Eventrule_guid { get; set; } 

        [JsonProperty("integration_method_value_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Integration_method_value_id { get; set; } 

        [JsonProperty("integration_method_value_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integration_method_value_name { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_id { get; set; } 

        [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class EventRule
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notes { get; set; } 

        [JsonProperty("precedence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Precedence { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_name { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tickettype_id { get; set; } 

        [JsonProperty("tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Tickettype_guid { get; set; } 

        [JsonProperty("tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tickettype_name { get; set; } 

        [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Template_id { get; set; } 

        [JsonProperty("template_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Template_guid { get; set; } 

        [JsonProperty("template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Template_name { get; set; } 

        [JsonProperty("create_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Create_type { get; set; } 

        [JsonProperty("values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OutboundIntegrationMethodValue>? Values { get; set; } 

        [JsonProperty("criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AutoassignCriteria>? Criteria { get; set; } 

        [JsonProperty("mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<EventMapping>? Mappings { get; set; } 

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } 

        [JsonProperty("event_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Event_key { get; set; } 

        [JsonProperty("hide_actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_actions { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ExactDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("tokenexpiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Tokenexpiry { get; set; } 

        [JsonProperty("isauthorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isauthorized { get; set; } 

        [JsonProperty("redirecturi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Redirecturi { get; set; } 

        [JsonProperty("clienttoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clienttoplevel { get; set; } 

        [JsonProperty("itemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Itemgroup { get; set; } 

        [JsonProperty("enablesync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablesync { get; set; } 

        [JsonProperty("defaultitemcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultitemcode { get; set; } 

        [JsonProperty("showmessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showmessage { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_id { get; set; } 

        [JsonProperty("syncentities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Syncentities { get; set; } 

        [JsonProperty("exdnewmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exdnewmethod { get; set; } 

        [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_client_secret { get; set; } 

        [JsonProperty("item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_group_name { get; set; } 

        [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Code { get; set; } 

        [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _exchangecode { get; set; } 

        [JsonProperty("_disconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _disconnect { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_refresh_token { get; set; } 

        [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_top_level_name { get; set; } 

        [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Sync_entities_list { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Client_mappings { get; set; } 

        [JsonProperty("item_group_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Item_group_mappings { get; set; } 

        [JsonProperty("locale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Locale { get; set; } 

        [JsonProperty("division", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Division { get; set; } 

        [JsonProperty("division_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Division_name { get; set; } 

        [JsonProperty("division_object", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExactDivision? Division_object { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ExactDivision
    {
        [JsonProperty("currentDivision", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentDivision { get; set; } 

        [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Code { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Expense
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("fault_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fault_id { get; set; } 

        [JsonProperty("actionnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actionnumber { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; } 

        [JsonProperty("lookup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lookup_id { get; set; } 

        [JsonProperty("date_added", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_added { get; set; } 

        [JsonProperty("date_reimbursed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_reimbursed { get; set; } 

        [JsonProperty("date_invoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_invoiced { get; set; } 

        [JsonProperty("invoiceable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invoiceable { get; set; } 

        [JsonProperty("ihid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ihid { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ExternalLink_List
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Table_id { get; set; } 

        [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Module_id { get; set; } 

        [JsonProperty("integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integration_name { get; set; } 

        [JsonProperty("halo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Halo_id { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_id { get; set; } 

        [JsonProperty("third_party_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_desc { get; set; } 

        [JsonProperty("third_party_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_type { get; set; } 

        [JsonProperty("third_party_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_url { get; set; } 

        [JsonProperty("third_party_assigned_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_assigned_to { get; set; } 

        [JsonProperty("third_party_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Third_party_count { get; set; } 

        [JsonProperty("primary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Primary { get; set; } 

        [JsonProperty("halo_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halo_desc { get; set; } 

        [JsonProperty("halo_second_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Halo_second_id { get; set; } 

        [JsonProperty("halo_second_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halo_second_desc { get; set; } 

        [JsonProperty("extra_match_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Extra_match_field { get; set; } 

        [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Details_id { get; set; } 

        [JsonProperty("third_party_secondary_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_secondary_id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("third_party_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_status { get; set; } 

        [JsonProperty("third_party_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_priority { get; set; } 

        [JsonProperty("_match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _match { get; set; } 

        [JsonProperty("populate_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Populate_url { get; set; } 

        [JsonProperty("date_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_created { get; set; } 

        [JsonProperty("date_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_updated { get; set; } 

        [JsonProperty("subscription_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subscription_id { get; set; } 

        [JsonProperty("new_subscription_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_subscription_key { get; set; } 

        [JsonProperty("subscription_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Subscription_expiry { get; set; } 

        [JsonProperty("_webhookaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public WebhookSubscriptionAction? _webhookaction { get; set; } 

        [JsonProperty("revisions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Revisions { get; set; } 

        [JsonProperty("dont_move_existing_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_move_existing_assets { get; set; } 

        [JsonProperty("chat_message_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chat_message_count { get; set; } 

        [JsonProperty("third_party_additional_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_additional_id { get; set; } 

    }