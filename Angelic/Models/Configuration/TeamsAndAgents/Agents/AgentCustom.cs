using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.TeamsAndAgents.Agents;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AgentCustom
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentName { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldId { get; set; } 

    [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldName { get; set; } 

    [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RoleId { get; set; } 

    [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RoleName { get; set; } 

    [JsonProperty("field_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldType { get; set; } 

    [JsonProperty("level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Level { get; set; } 

    [JsonProperty("canadd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanAdd { get; set; } 

    [JsonProperty("candelete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanDelete { get; set; } 

    [JsonProperty("canedit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanEdit { get; set; } 

    [JsonProperty("customfield_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CustomFieldType { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}