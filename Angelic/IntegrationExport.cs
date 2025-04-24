using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IntegrationExport
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("export_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Export_id { get; set; } 

    [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Module_id { get; set; } 

    [JsonProperty("halo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Halo_id { get; set; } 

    [JsonProperty("halo_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halo_name { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_id { get; set; } 

    [JsonProperty("third_party_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_name { get; set; } 

    [JsonProperty("export_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Export_url { get; set; } 

    [JsonProperty("export_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Export_date { get; set; } 

    [JsonProperty("export_progress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Export_progress { get; set; } 

    [JsonProperty("ready_for_import", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ready_for_import { get; set; } 

    [JsonProperty("progress_error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Progress_error { get; set; } 

    [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Details_id { get; set; } 

    [JsonProperty("exportdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationExportData>? Exportdata { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}