using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SlackBlockElementDispatchActionConfig
{
    [JsonProperty("trigger_actions_on", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Trigger_actions_on { get; set; } 

}