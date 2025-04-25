using System.CodeDom.Compiler;
using Angelic.Configuration.CustomField;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTableRow
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("fkid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Fkid { get; set; } 

    [JsonProperty("display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Display { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

}