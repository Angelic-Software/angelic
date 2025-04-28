using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Custom.CustomFields;
using Newtonsoft.Json;

namespace Angelic.Models.Areas;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AreaNote
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierId { get; set; } 

    [JsonProperty("sales_order_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesOrderId { get; set; } 

    [JsonProperty("purchase_order_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PurchaseOrderId { get; set; } 

    [JsonProperty("quote_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QuoteId { get; set; } 

    [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceId { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datetime { get; set; } 

    [JsonProperty("who_agentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WhoAgentid { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("detail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Detail { get; set; } 

    [JsonProperty("timetaken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TimeTaken { get; set; } 

    [JsonProperty("mailentryid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mailentryid { get; set; } 

    [JsonProperty("nextcalldate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Nextcalldate { get; set; } 

    [JsonProperty("satisfaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Satisfaction { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyId { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("ticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticketid { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("hide_time_taken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideTimeTaken { get; set; } 

    [JsonProperty("add_to_calendar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AddToCalendar { get; set; } 

    [JsonProperty("app_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AppUserId { get; set; } 

    [JsonProperty("app_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AppAgentId { get; set; } 

    [JsonProperty("app_subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AppSubject { get; set; } 

    [JsonProperty("nextcallduration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Nextcallduration { get; set; } 

    [JsonProperty("createdfromaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Createdfromaction { get; set; } 

}