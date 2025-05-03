using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AuditPasswordField
{
    [JsonProperty("object_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ObjectType { get; set; } 

    [JsonProperty("object_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ObjectId { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldId { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; } 

    [Range(0, 4)]
    [JsonProperty("object", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Object { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}