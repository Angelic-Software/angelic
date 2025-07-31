using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Integrations.Custom;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IncomingEvent
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RuleId { get; set; } 

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
    public int? ResponseStatus { get; set; } 

    [JsonProperty("responsebody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ResponseBody { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Error { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("deletion_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DeletionDate { get; set; } 

    [JsonProperty("output_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomIntegrationMethodValue>? OutputVariables { get; set; } 

    [JsonProperty("_retry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Retry { get; set; } 

    [JsonProperty("_apply_this_rule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApplyThisRule { get; set; } 

    [JsonProperty("_is_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsLink { get; set; } 

    [JsonProperty("rule_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RuleName { get; set; } 

    [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EntityId { get; set; } 

    [JsonProperty("thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyId { get; set; } 

    [JsonProperty("status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StatusName { get; set; } 

    [JsonProperty("responsetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ResponseType { get; set; } 

    [JsonProperty("response_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ResponseDesc { get; set; } 

}