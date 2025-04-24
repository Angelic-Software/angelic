using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class WebhookEvent
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Id { get; set; } 

    [JsonProperty("webhook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Webhook_id { get; set; } 

    [JsonProperty("integration_method_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Integration_method_id { get; set; } 

    [JsonProperty("integation_method_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Integation_method_name { get; set; } 

    [JsonProperty("notification_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Notification_id { get; set; } 

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

    [JsonProperty("responseheaders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Responseheaders { get; set; } 

    [JsonProperty("responsebody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Responsebody { get; set; } 

    [JsonProperty("automation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Automation_id { get; set; } 

    [JsonProperty("automation_step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Automation_step { get; set; } 

    [JsonProperty("automation_iteration_state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Automation_iteration_state { get; set; } 

    [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Entity_id { get; set; } 

    [JsonProperty("error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Error { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("log_retention_policy_deletion_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Log_retention_policy_deletion_date { get; set; } 

}