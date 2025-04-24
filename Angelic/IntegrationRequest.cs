using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IntegrationRequest
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("isoutgoing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isoutgoing { get; set; } 

    [JsonProperty("operation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Operation { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("msid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Msid { get; set; } 

    [JsonProperty("request_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Request_body { get; set; } 

    [JsonProperty("datelogged", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datelogged { get; set; } 

    [JsonProperty("resultcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Resultcode { get; set; } 

    [JsonProperty("response_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Response_body { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Details_id { get; set; } 

    [JsonProperty("request_headers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Request_headers { get; set; } 

    [JsonProperty("response_headers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Response_headers { get; set; } 

    [JsonProperty("trace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Trace>? Trace { get; set; } 

    [JsonProperty("_retrywebhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _retrywebhook { get; set; } 

    [JsonProperty("preserve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Preserve { get; set; } 

    [JsonProperty("hastrace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hastrace { get; set; } 

    [JsonProperty("format_as_xml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Format_as_xml { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}