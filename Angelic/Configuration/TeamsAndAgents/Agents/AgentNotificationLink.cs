using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Agent;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AgentNotificationLink
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentName { get; set; } 

    [JsonProperty("notification_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NotificationId { get; set; } 

    [JsonProperty("notification_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? NotificationGuid { get; set; } 

    [JsonProperty("notification_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NotificationName { get; set; } 

    [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RoleId { get; set; } 

    [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RoleName { get; set; } 

    [JsonProperty("user_role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserRoleId { get; set; } 

    [JsonProperty("user_role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserRoleName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}