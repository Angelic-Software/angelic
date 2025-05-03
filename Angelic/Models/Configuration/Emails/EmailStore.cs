using System.CodeDom.Compiler;
using Angelic.Models.Attachments;
using Angelic.Models.Configuration.Emails.Mailboxes;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails;

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
    public string? EmailBody { get; set; } 

    [JsonProperty("emailbody_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailBodyHtml { get; set; } 

    [JsonProperty("emailto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailTo { get; set; } 

    [JsonProperty("emailcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailCc { get; set; } 

    [JsonProperty("dateemailed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateEmailed { get; set; } 

    [JsonProperty("emailattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailAttachments { get; set; } 

    [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MessageGroupId { get; set; } 

    [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FaultId { get; set; } 

    [JsonProperty("templateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Templateid { get; set; } 

    [JsonProperty("emailbcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailBcc { get; set; } 

    [JsonProperty("keymessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Keymessage { get; set; } 

    [JsonProperty("reply_direct", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReplyDirect { get; set; } 

    [JsonProperty("replyaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Replyaddress { get; set; } 

    [JsonProperty("addactionaftersending", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Addactionaftersending { get; set; } 

    [JsonProperty("mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MailboxId { get; set; } 

    [JsonProperty("org_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OrgId { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

    [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("test_credentials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Mailbox? TestCredentials { get; set; } 

    [JsonProperty("_emailsent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Emailsent { get; set; } 

    [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Attachment>? Attachments { get; set; } 

    [JsonProperty("quotation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QuotationId { get; set; } 

    [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesOrderId { get; set; } 

    [JsonProperty("purchaseorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PurchaseOrderId { get; set; } 

    [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceId { get; set; } 

    [JsonProperty("sales_mailbox_override_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesMailboxOverrideId { get; set; } 

    [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateCreated { get; set; } 

    [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractId { get; set; } 

    [JsonProperty("bulk_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BulkUserId { get; set; } 

    [JsonProperty("bulk_user_id_array", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? BulkUserIdArray { get; set; } 

    [JsonProperty("_isbatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsBatch { get; set; } 

    [JsonProperty("kb_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? KbId { get; set; } 

    [JsonProperty("report_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReportId { get; set; } 

    [JsonProperty("from_dl_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FromDlId { get; set; } 

    [JsonProperty("add_to_feed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AddToFeed { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}