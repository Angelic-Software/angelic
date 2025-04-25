using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrganisationField
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("org_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OrgId { get; set; } 

    [JsonProperty("org_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OrgName { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldId { get; set; } 

}