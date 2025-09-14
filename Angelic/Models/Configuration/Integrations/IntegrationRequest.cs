using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record IntegrationRequest
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("isoutgoing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsOutgoing { get; set; } 

    [JsonProperty("operation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Operation { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("msid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MsId { get; set; } 

    [JsonProperty("request_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RequestBody { get; set; } 

    [JsonProperty("datelogged", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateLogged { get; set; } 

    [JsonProperty("resultcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ResultCode { get; set; } 

    [JsonProperty("response_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ResponseBody { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DetailsId { get; set; } 

    [JsonProperty("request_headers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RequestHeaders { get; set; } 

    [JsonProperty("response_headers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ResponseHeaders { get; set; } 

    [JsonProperty("trace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Trace>? Trace { get; set; } 

    [JsonProperty("_retrywebhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RetryWebhook { get; set; } 

    [JsonProperty("preserve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Preserve { get; set; } 

    [JsonProperty("hastrace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HasTrace { get; set; } 

    [JsonProperty("format_as_xml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FormatAsXml { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}