using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class WorkspaceApplication
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Id { get; set; } 

    [JsonProperty("database_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? DatabaseId { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ClientId { get; set; } 

    [JsonProperty("client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientSecret { get; set; } 

    [JsonProperty("workspace_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WorkspaceId { get; set; } 

    [JsonProperty("workspace_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WorkspaceToken { get; set; } 

}