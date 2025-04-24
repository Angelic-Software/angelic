using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReportContent
{
    [JsonProperty("loaded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Loaded { get; set; } 

    [JsonProperty("load_error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Load_error { get; set; } 

    [JsonProperty("rows", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IDictionary<string, object>>? Rows { get; set; } 

    [JsonProperty("chart_labels", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<object>? Chart_labels { get; set; } 

    [JsonProperty("chart_dataset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<object>? Chart_dataset { get; set; } 

    [JsonProperty("chart_dataset1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<object>? Chart_dataset1 { get; set; } 

    [JsonProperty("chart_dataset2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<object>? Chart_dataset2 { get; set; } 

    [JsonProperty("chart_dataset3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<object>? Chart_dataset3 { get; set; } 

    [JsonProperty("chart_dataset4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<object>? Chart_dataset4 { get; set; } 

    [JsonProperty("chart_dataset5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<object>? Chart_dataset5 { get; set; } 

    [JsonProperty("base_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Base_link { get; set; } 

    [JsonProperty("table_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Table_html { get; set; } 

    [JsonProperty("datasets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public IDictionary<string, ICollection<object>?>? Datasets { get; set; } 

}