using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IncomingEvent
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Rule_id { get; set; } 

    [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("duration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Duration { get; set; } 

    [JsonProperty("requestheaders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Requestheaders { get; set; } 

    [JsonProperty("requestbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Requestbody { get; set; } 

    [JsonProperty("responsestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Responsestatus { get; set; } 

    [JsonProperty("responsebody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Responsebody { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Error { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("deletion_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Deletion_date { get; set; } 

    [JsonProperty("output_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OutboundIntegrationMethodValue>? Output_variables { get; set; } 

    [JsonProperty("_retry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _retry { get; set; } 

    [JsonProperty("_apply_this_rule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _apply_this_rule { get; set; } 

    [JsonProperty("_is_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _is_link { get; set; } 

    [JsonProperty("rule_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Rule_name { get; set; } 

    [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Entity_id { get; set; } 

    [JsonProperty("thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdparty_id { get; set; } 

    [JsonProperty("status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status_name { get; set; } 

    [JsonProperty("responsetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Responsetype { get; set; } 

    [JsonProperty("response_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Response_desc { get; set; } 

}