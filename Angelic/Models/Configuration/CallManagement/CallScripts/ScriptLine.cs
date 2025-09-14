using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Custom.CustomFields;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.CallManagement.CallScripts;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record ScriptLine
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("script_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ScriptId { get; set; } 

    [JsonProperty("sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SortSeq { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("question", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Question { get; set; } 

    [JsonProperty("next_question_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NextQuestionId { get; set; } 

    [JsonProperty("update_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UpdateFieldId { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("input_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InputType { get; set; } 

    [JsonProperty("temp_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TempId { get; set; } 

    [JsonProperty("choices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ScriptChoice>? Choices { get; set; } 

    [JsonProperty("verification_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FieldInfo>? VerificationFields { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}