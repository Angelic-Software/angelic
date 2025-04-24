using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Outgoingemail
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("datesent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datesent { get; set; } 

    [JsonProperty("memo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Memo { get; set; } 

    [JsonProperty("html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Html { get; set; } 

    [JsonProperty("delete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Delete { get; set; } 

    [JsonProperty("from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? From { get; set; } 

    [JsonProperty("to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? To { get; set; } 

    [JsonProperty("cc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Cc { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("likely_cause", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Likely_cause { get; set; } 

    [JsonProperty("changeseq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Changeseq { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("idone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Idone { get; set; } 

    [JsonProperty("idtwo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Idtwo { get; set; } 

    [JsonProperty("actiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Actiondate { get; set; } 

    [JsonProperty("error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Error { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}