using System.CodeDom.Compiler;
using Angelic.Models.Users;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Microsoft.Teams;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CreateTeamsChat
{
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("members", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<User>? Members { get; set; } 

}