using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class InvoiceDetailQuantityCriteria
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("invoicedetailquantity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoicedetailquantityId { get; set; } 

    [JsonProperty("tablename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tablename { get; set; } 

    [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Fieldname { get; set; } 

    [JsonProperty("value_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ValueType { get; set; } 

    [JsonProperty("value_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ValueInt { get; set; } 

    [JsonProperty("value_float", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ValueFloat { get; set; } 

    [JsonProperty("value_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ValueString { get; set; } 

    [JsonProperty("value_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ValueDatetime { get; set; } 

    [JsonProperty("value_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ValueDisplay { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}