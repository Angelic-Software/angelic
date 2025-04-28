using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Billing;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Expense
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("fault_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FaultId { get; set; } 

    [JsonProperty("actionnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Actionnumber { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Amount { get; set; } 

    [JsonProperty("lookup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LookupId { get; set; } 

    [JsonProperty("date_added", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateAdded { get; set; } 

    [JsonProperty("date_reimbursed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateReimbursed { get; set; } 

    [JsonProperty("date_invoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateInvoiced { get; set; } 

    [JsonProperty("invoiceable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Invoiceable { get; set; } 

    [JsonProperty("ihid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ihid { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}