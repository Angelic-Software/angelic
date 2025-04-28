using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Restriction
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("key1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Key1 { get; set; } 

    [JsonProperty("key1_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Key1Name { get; set; } 

    [JsonProperty("key2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Key2 { get; set; } 

    [JsonProperty("key2_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Key2Guid { get; set; } 

    [JsonProperty("key2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Key2Name { get; set; } 

    [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RoleId { get; set; } 

    [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RoleName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}