using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.AccessControl;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class AccessControl
{
    [JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } = default!;

    [JsonProperty("entity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Entity { get; set; } = default!;

    [JsonProperty("entity_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EntityId { get; set; } = default!;

    [JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } = default!;

    [JsonProperty("agent_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } = default!;

    [JsonProperty("user_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } = default!;

    [JsonProperty("role_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RoleId { get; set; } = default!;

    [JsonProperty("team_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TeamId { get; set; } = default!;

    [JsonProperty("department_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DepartmentId { get; set; } = default!;

    [JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } = default!;

    [JsonProperty("level", Required = Newtonsoft.Json.Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Level { get; set; } = default!;

    [JsonProperty("_warning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } = default!;

    [JsonProperty("entity_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EntityName { get; set; } = default!;

    [JsonProperty("entity_text_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EntityTextId { get; set; } = default!;
}
