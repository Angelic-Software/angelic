using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReleaseProductEmail
{
    [JsonProperty("product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ProductId { get; set; } 

    [JsonProperty("release_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReleaseId { get; set; } 

    [JsonProperty("releasetype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReleasetypeName { get; set; } 

    [JsonProperty("emailtemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EmailtemplateId { get; set; } 

    [JsonProperty("emailtemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailtemplateName { get; set; } 

    [JsonProperty("change_status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChangeStatusId { get; set; } 

    [JsonProperty("push_to_children", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PushToChildren { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}