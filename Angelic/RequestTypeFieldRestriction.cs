using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class RequestTypeFieldRestriction
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tickettype_id { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Field_id { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Role_id { get; set; } 

    [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Role_name { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("alloweditbeforeapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Alloweditbeforeapproval { get; set; } 

    [JsonProperty("alloweditafterapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Alloweditafterapproval { get; set; } 

    [JsonProperty("alloweditduringapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Alloweditduringapproval { get; set; } 

}