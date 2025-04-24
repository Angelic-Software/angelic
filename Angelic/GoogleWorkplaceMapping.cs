using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class GoogleWorkplaceMapping
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("customerid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Customerid { get; set; } 

    [JsonProperty("siteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Siteid { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site_name { get; set; } 

    [JsonProperty("filterfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Filterfield { get; set; } 

    [JsonProperty("filtertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Filtertype { get; set; } 

    [JsonProperty("filtervalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Filtervalue { get; set; } 

    [JsonProperty("roleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Roleid { get; set; } 

    [JsonProperty("filter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Filter { get; set; } 

    [JsonProperty("userroleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Userroleid { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}