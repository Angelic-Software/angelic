using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ScriptLine
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("script_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Script_id { get; set; } 

    [JsonProperty("sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sort_seq { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("question", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Question { get; set; } 

    [JsonProperty("next_question_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Next_question_id { get; set; } 

    [JsonProperty("update_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Update_field_id { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("input_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Input_type { get; set; } 

    [JsonProperty("temp_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Temp_id { get; set; } 

    [JsonProperty("choices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ScriptChoice>? Choices { get; set; } 

    [JsonProperty("verification_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FieldInfo>? Verification_fields { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}