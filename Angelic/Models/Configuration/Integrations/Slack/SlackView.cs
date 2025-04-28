using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Slack;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SlackView
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("callback_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CallbackId { get; set; } 

    [JsonProperty("private_metadata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PrivateMetadata { get; set; } 

    [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackViewText? Title { get; set; } 

    [JsonProperty("submit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackViewText? Submit { get; set; } 

    [JsonProperty("blocks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SlackViewBlock>? Blocks { get; set; } 

    [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackViewState? State { get; set; } 

}