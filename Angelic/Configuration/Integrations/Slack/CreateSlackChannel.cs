using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Slack;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateSlackChannel
{
    [JsonProperty("workspace_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WorkspaceId { get; set; } 

    [JsonProperty("access_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessType { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("members", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SlackUser>? Members { get; set; } 

}