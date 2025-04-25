using System.CodeDom.Compiler;
using Newtonsoft.Json;
using static Newtonsoft.Json.Required;

namespace Angelic.Configuration.Integrations.Lookups;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DatabaseLookupField
{
    [JsonProperty("id", Required = Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("lookup_profile_id", Required = Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LookupProfileId { get; set; } 

    [JsonProperty("field_id", Required = Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldId { get; set; } 

    [JsonProperty("field_name", Required = Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldName { get; set; } 

    [JsonProperty("required", Required = Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Required { get; set; } 

    [JsonProperty("_warning", Required = Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}