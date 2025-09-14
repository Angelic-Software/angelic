using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Invoice;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record InvoiceDetailMeterTiers
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("idid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IdId { get; set; } 

    [JsonProperty("minquantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? MinQuantity { get; set; } 

    [JsonProperty("maxquantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? MaxQuantity { get; set; } 

    [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Price { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}