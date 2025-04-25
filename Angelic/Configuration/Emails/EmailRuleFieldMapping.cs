using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Emails;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EmailRuleFieldMapping
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("emailruleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Emailruleid { get; set; } 

    [JsonProperty("fieldid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Fieldid { get; set; } 

    [JsonProperty("fieldtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Fieldtype { get; set; } 

    [JsonProperty("searchtext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Searchtext { get; set; } 

    [JsonProperty("starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Starttag { get; set; } 

    [JsonProperty("endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Endtag { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; } 

    [JsonProperty("searchresult", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Searchresult { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}