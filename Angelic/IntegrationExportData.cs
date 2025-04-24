using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IntegrationExportData
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("integration_export_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Integration_export_id { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_id { get; set; } 

    [JsonProperty("exported", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Exported { get; set; } 

    [JsonProperty("export_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public byte[]? Export_body { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}