using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Chat;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ChatFlowProcess
{
    [JsonProperty("chat_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChatId { get; set; } 

    [JsonProperty("chat_profile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChatProfileId { get; set; } 

    [JsonProperty("flow_step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FlowStep { get; set; } 

}