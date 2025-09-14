using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Freshdesk;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record FreshdeskTicket
{
    [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FreshdeskAttachment>? Attachments { get; set; } 

    [JsonProperty("cc_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? CcEmails { get; set; } 

    [JsonProperty("company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? CompanyId { get; set; } 

    [JsonProperty("deleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Deleted { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("description_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DescriptionText { get; set; } 

    [JsonProperty("due_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DueBy { get; set; } 

    [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email { get; set; } 

    [JsonProperty("email_config_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? EmailConfigId { get; set; } 

    [JsonProperty("facebook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FacebookId { get; set; } 

    [JsonProperty("fr_due_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FrDueBy { get; set; } 

    [JsonProperty("fr_escalated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FrEscalated { get; set; } 

    [JsonProperty("fwd_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? FwdEmails { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? GroupId { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("is_escalated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsEscalated { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Phone { get; set; } 

    [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Priority { get; set; } 

    [JsonProperty("product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? ProductId { get; set; } 

    [JsonProperty("reply_cc_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? ReplyCcEmails { get; set; } 

    [JsonProperty("requester_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? RequesterId { get; set; } 

    [JsonProperty("responder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? ResponderId { get; set; } 

    [JsonProperty("source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Source { get; set; } 

    [JsonProperty("spam", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Spam { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tags { get; set; } 

    [JsonProperty("to_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? ToEmails { get; set; } 

    [JsonProperty("twitter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TwitterId { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("created_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CreatedAt { get; set; } 

    [JsonProperty("updated_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UpdatedAt { get; set; } 

    [JsonProperty("requester", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public FreshdeskUser? Requester { get; set; } 

    [JsonProperty("stats", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public FreshdeskStats? Stats { get; set; } 

    [JsonProperty("company", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public FreshdeskCompany? Company { get; set; } 

    [JsonProperty("sla_policy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public FreshdeskSla? SlaPolicy { get; set; } 

    [JsonProperty("custom_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public IDictionary<string, string?>? CustomFields { get; set; } 

    [JsonProperty("association_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssociationType { get; set; } 

    [JsonProperty("associated_tickets_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? AssociatedTicketsList { get; set; } 

}