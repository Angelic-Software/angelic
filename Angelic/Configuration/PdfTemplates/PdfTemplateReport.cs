using System.CodeDom.Compiler;
using Angelic.Reports;
using Newtonsoft.Json;

namespace Angelic.Configuration.PdfTemplates;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PdfTemplateReport
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PdfTemplateId { get; set; } 

    [JsonProperty("report_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReportId { get; set; } 

    [JsonProperty("report_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReportName { get; set; } 

    [JsonProperty("report_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Report? ReportData { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}