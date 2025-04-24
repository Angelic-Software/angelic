using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ConfigCommit
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } 

    [JsonProperty("source_instance_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SourceInstanceId { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("object_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ObjectGuid { get; set; } 

    [JsonProperty("operation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Operation { get; set; } 

    [JsonProperty("payload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Payload { get; set; } 

    [JsonProperty("rollback_operation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RollbackOperation { get; set; } 

    [JsonProperty("rollback_payload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RollbackPayload { get; set; } 

    [JsonProperty("rolled_back", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RolledBack { get; set; } 

    [JsonProperty("rolled_back_timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? RolledBackTimestamp { get; set; } 

    [JsonProperty("rolled_back_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RolledBackAgentId { get; set; } 

    [JsonProperty("is_merge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsMerge { get; set; } 

    [JsonProperty("original_json", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OriginalJson { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("_rollback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Rollback { get; set; } 

    [JsonProperty("_push_to_instance_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PushToInstanceId { get; set; } 

}