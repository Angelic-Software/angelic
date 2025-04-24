using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

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