using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class InvoiceChange
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceId { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldId { get; set; } 

    [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldName { get; set; } 

    [JsonProperty("old_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OldValue { get; set; } 

    [JsonProperty("new_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewValue { get; set; } 

    [JsonProperty("who", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Who { get; set; } 

    [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datetime { get; set; } 

    [JsonProperty("invoice_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceLineId { get; set; } 

    [JsonProperty("invoice_detail_quantity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceDetailQuantityId { get; set; } 

    [JsonProperty("invoice_detail_prorata_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceDetailProrataId { get; set; } 

    [JsonProperty("type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TypeId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}