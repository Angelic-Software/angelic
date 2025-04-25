using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TaxRuleResult
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("tableenum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tableenum { get; set; } 

    [JsonProperty("tableid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TableEnum? Tableid { get; set; } 

    [JsonProperty("lineid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Lineid { get; set; } 

    [JsonProperty("entityid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Entityid { get; set; } 

    [JsonProperty("taxamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Taxamount { get; set; } 

    [JsonProperty("taxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Taxcode { get; set; } 

    [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ModuleId { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyId { get; set; } 

    [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datecreated { get; set; } 

    [JsonProperty("thirdpartyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdpartyname { get; set; } 

    [JsonProperty("taxid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Taxid { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}