using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Quotation;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record QuotationHeaderPdf
{
    [JsonProperty("desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Desc { get; set; } 

    [JsonProperty("uniqueid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UniqueId { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("quotationheaderid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QuotationHeaderId { get; set; } 

    [JsonProperty("prepend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Prepend { get; set; } 

}