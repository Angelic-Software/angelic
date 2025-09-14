using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Reports;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record ReportContent
{
    [JsonProperty("loaded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Loaded { get; set; } 

    [JsonProperty("load_error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LoadError { get; set; } 

    [JsonProperty("rows", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IDictionary<string, object>>? Rows { get; set; } 

    [JsonProperty("chart_labels", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<object>? ChartLabels { get; set; } 

    [JsonProperty("chart_dataset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<object>? ChartDataset { get; set; } 

    [JsonProperty("chart_dataset1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<object>? ChartDataset1 { get; set; } 

    [JsonProperty("chart_dataset2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<object>? ChartDataset2 { get; set; } 

    [JsonProperty("chart_dataset3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<object>? ChartDataset3 { get; set; } 

    [JsonProperty("chart_dataset4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<object>? ChartDataset4 { get; set; } 

    [JsonProperty("chart_dataset5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<object>? ChartDataset5 { get; set; } 

    [JsonProperty("base_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BaseLink { get; set; } 

    [JsonProperty("table_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TableHtml { get; set; } 

    [JsonProperty("datasets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public IDictionary<string, ICollection<object>?>? Datasets { get; set; } 

}