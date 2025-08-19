using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IntegrationExport
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("export_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ExportId { get; set; } 

    [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ModuleId { get; set; } 

    [JsonProperty("halo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HaloId { get; set; } 

    [JsonProperty("halo_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloName { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyId { get; set; } 

    [JsonProperty("third_party_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyName { get; set; } 

    [JsonProperty("export_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ExportUrl { get; set; } 

    [JsonProperty("export_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ExportDate { get; set; } 

    [JsonProperty("export_progress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ExportProgress { get; set; } 

    [JsonProperty("ready_for_import", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReadyForImport { get; set; } 

    [JsonProperty("progress_error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProgressError { get; set; } 

    [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DetailsId { get; set; } 

    [JsonProperty("exportdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationExportData>? ExportData { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}