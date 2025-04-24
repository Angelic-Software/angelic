using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DistributionListsLog
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("distributionlists_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DistributionlistsId { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Action { get; set; } 

    [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datetime { get; set; } 

    [JsonProperty("emailsubject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailsubject { get; set; } 

    [JsonProperty("emailbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailbody { get; set; } 

    [JsonProperty("action_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ActionDesc { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserName { get; set; } 

}