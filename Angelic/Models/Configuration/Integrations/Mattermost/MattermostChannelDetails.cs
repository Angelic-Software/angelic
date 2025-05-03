using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Mattermost;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MattermostChannelDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("mmid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mmid { get; set; } 

    [JsonProperty("channelid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Channelid { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("agentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("webhookid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Webhookid { get; set; } 

    [JsonProperty("webhookname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Webhookname { get; set; } 

    [JsonProperty("webhookdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Webhookdesc { get; set; } 

    [JsonProperty("botname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Botname { get; set; } 

    [JsonProperty("boticon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Boticon { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}