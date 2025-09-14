using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Reports;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record ReportColour
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }
    
    [JsonProperty("report_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReportId { get; set; }
    
    [JsonProperty("widget_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WidgetId { get; set; }
    
    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; }
    
    [JsonProperty("min_threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MinThreshold { get; set; }
    
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }
    
    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; }
}
