using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.KnowledgeBase;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record KbArticleTopLevelAccess
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("toplevel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TopLevelId { get; set; } 

    [JsonProperty("toplevel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TopLevelName { get; set; } 

    [JsonProperty("kb_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? KbId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}