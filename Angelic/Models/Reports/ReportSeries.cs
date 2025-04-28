using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Reports;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReportSeries
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }
    
    [JsonProperty("report_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReportId { get; set; }
    
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }
    
    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; }
    
    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; }
    
    [JsonProperty("visible", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Visible { get; set; }
    
    [JsonProperty("axis", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Axis { get; set; }
    
    [JsonProperty("order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Order { get; set; }
    
    [JsonProperty("stack_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StackGroup { get; set; }
    
    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; }
}
