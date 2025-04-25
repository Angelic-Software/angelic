using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Twitter;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TwitterEvent
{
    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Id { get; set; } 

    [JsonProperty("created_timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? CreatedTimestamp { get; set; } 

    [JsonProperty("message_create", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TwitterMessage? MessageCreate { get; set; } 

}