using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Ai;

public record AiAssistantRequest
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }

    [JsonProperty("assistant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssistantId { get; set; }

    [JsonProperty("thread_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThreadId { get; set; }

    [JsonProperty("run_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RunId { get; set; }

    [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EntityId { get; set; }

    [JsonProperty("prompt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Prompt { get; set; }

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; }

    [JsonProperty("iterations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Iterations { get; set; }

    [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; }

    [JsonProperty("error_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ErrorMessage { get; set; }

    [JsonProperty("query", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Query { get; set; }
}