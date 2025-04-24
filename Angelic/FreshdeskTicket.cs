using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FreshdeskTicket
{
    [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FreshdeskAttachment>? Attachments { get; set; } 

    [JsonProperty("cc_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Cc_emails { get; set; } 

    [JsonProperty("company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Company_id { get; set; } 

    [JsonProperty("deleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Deleted { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("description_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description_text { get; set; } 

    [JsonProperty("due_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Due_by { get; set; } 

    [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email { get; set; } 

    [JsonProperty("email_config_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Email_config_id { get; set; } 

    [JsonProperty("facebook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Facebook_id { get; set; } 

    [JsonProperty("fr_due_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Fr_due_by { get; set; } 

    [JsonProperty("fr_escalated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Fr_escalated { get; set; } 

    [JsonProperty("fwd_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Fwd_emails { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Group_id { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("is_escalated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_escalated { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Phone { get; set; } 

    [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Priority { get; set; } 

    [JsonProperty("product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Product_id { get; set; } 

    [JsonProperty("reply_cc_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Reply_cc_emails { get; set; } 

    [JsonProperty("requester_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Requester_id { get; set; } 

    [JsonProperty("responder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Responder_id { get; set; } 

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
    public ICollection<string>? To_emails { get; set; } 

    [JsonProperty("twitter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Twitter_id { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("created_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Created_at { get; set; } 

    [JsonProperty("updated_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Updated_at { get; set; } 

    [JsonProperty("requester", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public FreshdeskUser? Requester { get; set; } 

    [JsonProperty("stats", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public FreshdeskStats? Stats { get; set; } 

    [JsonProperty("company", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public FreshdeskCompany? Company { get; set; } 

    [JsonProperty("sla_policy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public FreshdeskSLA? Sla_policy { get; set; } 

    [JsonProperty("custom_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public IDictionary<string, string?>? Custom_fields { get; set; } 

    [JsonProperty("association_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Association_type { get; set; } 

    [JsonProperty("associated_tickets_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? Associated_tickets_list { get; set; } 

}