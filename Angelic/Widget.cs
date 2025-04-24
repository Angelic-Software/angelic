using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Widget
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("dashboardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Dashboardid { get; set; } 

    [JsonProperty("i", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? I { get; set; } 

    [JsonProperty("w", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? W { get; set; } 

    [JsonProperty("h", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? H { get; set; } 

    [JsonProperty("x", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? X { get; set; } 

    [JsonProperty("y", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Y { get; set; } 

    [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(255)]
    public string? Title { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("report_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Report_id { get; set; } 

    [JsonProperty("counter_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Counter_type { get; set; } 

    [JsonProperty("count_format_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Count_format_type { get; set; } 

    [JsonProperty("column_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(255)]
    public string? Column_name { get; set; } 

    [JsonProperty("ticketarea_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticketarea_id { get; set; } 

    [JsonProperty("view_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? View_type { get; set; } 

    [JsonProperty("filter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Filter_id { get; set; } 

    [JsonProperty("tree_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tree_id { get; set; } 

    [JsonProperty("tree_id2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tree_id2 { get; set; } 

    [JsonProperty("columns_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Columns_id { get; set; } 

    [JsonProperty("page_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Page_size { get; set; } 

    [JsonProperty("custom_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(10000)]
    public string? Custom_html { get; set; } 

    [JsonProperty("custom_html_translated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Custom_html_translated { get; set; } 

    [JsonProperty("style", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Style { get; set; } 

    [JsonProperty("custom_css", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(4000)]
    public string? Custom_css { get; set; } 

    [JsonProperty("initialcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Initialcolour { get; set; } 

    [JsonProperty("changedcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Changedcolour { get; set; } 

    [JsonProperty("thresholdvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Thresholdvalue { get; set; } 

    [JsonProperty("colourchangerule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Colourchangerule { get; set; } 

    [JsonProperty("override_drilldown_report_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Override_drilldown_report_id { get; set; } 

    [JsonProperty("default_currency_symbol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_currency_symbol { get; set; } 

    [JsonProperty("relation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Relation { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Field_id { get; set; } 

    [JsonProperty("outcome_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Outcome_id { get; set; } 

    [JsonProperty("field_columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Field_columns { get; set; } 

    [JsonProperty("mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mode { get; set; } 

    [JsonProperty("actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TOutcome>? Actions { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("open_report_in_new_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Open_report_in_new_tab { get; set; } 

    [JsonProperty("display_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Display_type { get; set; } 

    [JsonProperty("charttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Charttype { get; set; } 

    [JsonProperty("xaxis", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xaxis { get; set; } 

    [JsonProperty("yaxis", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Yaxis { get; set; } 

    [JsonProperty("xaxiscaption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xaxiscaption { get; set; } 

    [JsonProperty("yaxiscaption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Yaxiscaption { get; set; } 

    [JsonProperty("series", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AnalyzerProfileSeries>? Series { get; set; } 

    [JsonProperty("colours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AnalyzerProfileColour>? Colours { get; set; } 

    [JsonProperty("graphorderby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Graphorderby { get; set; } 

    [JsonProperty("graphorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Graphorder { get; set; } 

    [JsonProperty("count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Count { get; set; } 

    [JsonProperty("sum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sum { get; set; } 

    [JsonProperty("average", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Average { get; set; } 

    [JsonProperty("averageaspercentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Averageaspercentage { get; set; } 

    [JsonProperty("show_top_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Show_top_only { get; set; } 

    [JsonProperty("top_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Top_count { get; set; } 

    [JsonProperty("show_trendline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Show_trendline { get; set; } 

    [JsonProperty("show_datavalues", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Show_datavalues { get; set; } 

    [JsonProperty("stackbars", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Stackbars { get; set; } 

    [JsonProperty("colourpallette", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colourpallette { get; set; } 

    [JsonProperty("chart_comparison", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Chart_comparison { get; set; } 

    [JsonProperty("autosize", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Autosize { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

}