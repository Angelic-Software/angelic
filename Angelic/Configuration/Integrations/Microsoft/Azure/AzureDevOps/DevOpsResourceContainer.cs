using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DevOpsResourceContainer
{
    [JsonProperty("project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DevOpsResourceContainerDetail? Project { get; set; } 

}