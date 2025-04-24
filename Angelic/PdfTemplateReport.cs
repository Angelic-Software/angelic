using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PdfTemplateReport
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pdftemplate_id { get; set; } 

    [JsonProperty("report_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Report_id { get; set; } 

    [JsonProperty("report_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Report_name { get; set; } 

    [JsonProperty("report_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AnalyzerProfile? Report_data { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}