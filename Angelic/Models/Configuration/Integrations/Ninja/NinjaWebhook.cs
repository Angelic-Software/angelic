using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Ninja;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NinjaWebhook
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("activityTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? ActivityTime { get; set; } 

    [JsonProperty("deviceId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DeviceId { get; set; } 

    [JsonProperty("seriesUid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SeriesUid { get; set; } 

    [JsonProperty("activityType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ActivityType { get; set; } 

    [JsonProperty("statusCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StatusCode { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status { get; set; } 

    [JsonProperty("activityResult", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ActivityResult { get; set; } 

    [JsonProperty("sourceConfigUid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SourceConfigUid { get; set; } 

    [JsonProperty("sourceName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SourceName { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Message { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("severity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Severity { get; set; } 

    [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Priority { get; set; } 

    [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public NinjaWebhookData? Data { get; set; } 

    [JsonProperty("resourceObject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? ResourceObject { get; set; } 

    [JsonProperty("activityTypeEnum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public NinjaWebhookActivityType? ActivityTypeEnum { get; set; } 

    [JsonProperty("statusCodeEnum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public NinjaWebhookStatus? StatusCodeEnum { get; set; } 

    [JsonProperty("activityResultEnum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public NinjaWebhookActivityResult? ActivityResultEnum { get; set; } 

}