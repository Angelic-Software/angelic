using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LiveChatIsTyping
{
    [JsonProperty("chat_id", Required = Required.Always)]
    public int Chat_id { get; set; } 

    [JsonProperty("sender_id", Required = Required.Always)]
    public int Sender_id { get; set; } 

    [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } 

    [JsonProperty("_stopped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _stopped { get; set; } 

}