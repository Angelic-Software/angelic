using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.CallManagement.CallScripts;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record ScriptChoice
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("script_question_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ScriptQuestionId { get; set; } 

    [JsonProperty("choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Choice { get; set; } 

    [JsonProperty("next_question_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NextQuestionId { get; set; } 

    [JsonProperty("sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SortSeq { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}