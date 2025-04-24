using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ChatInputSuggestion
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("flowdetail_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FlowdetailId { get; set; } 

    [JsonProperty("suggestion_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SuggestionText { get; set; } 

    [JsonProperty("message_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MessageText { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}