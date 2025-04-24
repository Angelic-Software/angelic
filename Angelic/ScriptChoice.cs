using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ScriptChoice
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("script_question_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Script_question_id { get; set; } 

    [JsonProperty("choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Choice { get; set; } 

    [JsonProperty("next_question_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Next_question_id { get; set; } 

    [JsonProperty("sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sort_seq { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}