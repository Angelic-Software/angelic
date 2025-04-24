using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

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