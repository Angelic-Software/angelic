using System.CodeDom.Compiler;
using Angelic.Configuration.Integrations;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ImportCsv
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? Mappings { get; set; } 

    [JsonProperty("create_new_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateNewLines { get; set; } 

    [JsonProperty("one_time_charges", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OneTimeCharges { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}