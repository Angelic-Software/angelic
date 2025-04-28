using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FormattedEmail
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("fmid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Fmid { get; set; } 

    [JsonProperty("fmdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Fmdata { get; set; } 

    [JsonProperty("customer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Customer { get; set; } 

    [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Priority { get; set; } 

    [JsonProperty("dateopened", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Dateopened { get; set; } 

    [JsonProperty("site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site { get; set; } 

    [JsonProperty("email_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailTo { get; set; } 

    [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; } 

    [JsonProperty("timeopened", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Timeopened { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Details { get; set; } 

    [JsonProperty("tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketType { get; set; } 

    [JsonProperty("agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Agent { get; set; } 

    [JsonProperty("team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Team { get; set; } 

    [JsonProperty("category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category1 { get; set; } 

    [JsonProperty("category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category2 { get; set; } 

    [JsonProperty("category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category3 { get; set; } 

    [JsonProperty("category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category4 { get; set; } 

    [JsonProperty("opportunity_contact_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OpportunityContactName { get; set; } 

    [JsonProperty("opportunity_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OpportunityCompanyName { get; set; } 

    [JsonProperty("opportunity_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OpportunityEmail { get; set; } 

    [JsonProperty("opportunity_phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OpportunityPhone { get; set; } 

    [JsonProperty("opportunity_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OpportunityValue { get; set; } 

    [JsonProperty("email_cc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailCc { get; set; } 

    [JsonProperty("opportunity_country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OpportunityCountry { get; set; } 

    [JsonProperty("template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TemplateName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}