using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class InvoiceDetailQuantity
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("invoice_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Invoice_line_id { get; set; } 

    [JsonProperty("kind", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Kind { get; set; } 

    [JsonProperty("type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type_id { get; set; } 

    [JsonProperty("device_group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Device_group_id { get; set; } 

    [JsonProperty("type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type_name { get; set; } 

    [JsonProperty("device_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Device_group_name { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site_id { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site_name { get; set; } 

    [JsonProperty("licence_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Licence_id { get; set; } 

    [JsonProperty("licence_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Licence_name { get; set; } 

    [JsonProperty("assigned_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Assigned_licences { get; set; } 

    [JsonProperty("qty_free", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Qty_free { get; set; } 

    [JsonProperty("minimum_qty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Minimum_qty { get; set; } 

    [JsonProperty("pro_rata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pro_rata { get; set; } 

    [JsonProperty("criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceDetailQuantityCriteria>? Criteria { get; set; } 

    [JsonProperty("use_linked_subscription_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Use_linked_subscription_price { get; set; } 

    [JsonProperty("use_linked_subscription_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Use_linked_subscription_cost { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}