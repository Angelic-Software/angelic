using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Chat;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record ChatStepQuestion
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("flowdetail_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FlowDetailId { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("question", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Question { get; set; } 

    [JsonProperty("answer_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AnswerFieldId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}