using System.CodeDom.Compiler;
using Angelic.Models.Configuration;
using Angelic.Models.Configuration.Language;
using Angelic.Models.Reports;
using Newtonsoft.Json;

namespace Angelic.Models.Dashboards;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Widget
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("dashboardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DashboardId { get; set; } 

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
    public int? ReportId { get; set; } 

    [JsonProperty("counter_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CounterType { get; set; } 

    [JsonProperty("count_format_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CountFormatType { get; set; } 

    [JsonProperty("column_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(255)]
    public string? ColumnName { get; set; } 

    [JsonProperty("ticketarea_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketareaId { get; set; } 

    [JsonProperty("view_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ViewType { get; set; } 

    [JsonProperty("filter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FilterId { get; set; } 

    [JsonProperty("tree_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TreeId { get; set; } 

    [JsonProperty("tree_id2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TreeId2 { get; set; } 

    [JsonProperty("columns_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ColumnsId { get; set; } 

    [JsonProperty("page_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PageSize { get; set; } 

    [JsonProperty("custom_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(10000)]
    public string? CustomHtml { get; set; } 

    [JsonProperty("custom_html_translated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CustomHtmlTranslated { get; set; } 

    [JsonProperty("style", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Style { get; set; } 

    [JsonProperty("custom_css", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(4000)]
    public string? CustomCss { get; set; } 

    [JsonProperty("initialcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InitialColour { get; set; } 

    [JsonProperty("changedcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChangedColour { get; set; } 

    [JsonProperty("thresholdvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ThresholdValue { get; set; } 

    [JsonProperty("colourchangerule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ColourChangeRule { get; set; } 

    [JsonProperty("override_drilldown_report_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OverrideDrilldownReportId { get; set; } 

    [JsonProperty("default_currency_symbol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultCurrencySymbol { get; set; } 

    [JsonProperty("relation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Relation { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldId { get; set; } 

    [JsonProperty("outcome_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OutcomeId { get; set; } 

    [JsonProperty("field_columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldColumns { get; set; } 

    [JsonProperty("mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mode { get; set; } 

    [JsonProperty("actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ActionOutcome>? Actions { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("open_report_in_new_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OpenReportInNewTab { get; set; } 

    [JsonProperty("display_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DisplayType { get; set; } 

    [JsonProperty("charttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChartType { get; set; } 

    [JsonProperty("xaxis", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XAxis { get; set; } 

    [JsonProperty("yaxis", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? YAxis { get; set; } 

    [JsonProperty("xaxiscaption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XAxisCaption { get; set; } 

    [JsonProperty("yaxiscaption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? YAxisCaption { get; set; } 

    [JsonProperty("series", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ReportSeries>? Series { get; set; } 

    [JsonProperty("colours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ReportColour>? Colours { get; set; } 

    [JsonProperty("graphorderby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GraphOrderBy { get; set; } 

    [JsonProperty("graphorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GraphOrder { get; set; } 

    [JsonProperty("count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Count { get; set; } 

    [JsonProperty("sum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sum { get; set; } 

    [JsonProperty("average", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Average { get; set; } 

    [JsonProperty("averageaspercentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AverageAsPercentage { get; set; } 

    [JsonProperty("show_top_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowTopOnly { get; set; } 

    [JsonProperty("top_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TopCount { get; set; } 

    [JsonProperty("show_trendline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowTrendLine { get; set; } 

    [JsonProperty("show_datavalues", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowDataValues { get; set; } 

    [JsonProperty("stackbars", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? StackBars { get; set; } 

    [JsonProperty("colourpallette", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ColourPalette { get; set; } 

    [JsonProperty("chart_comparison", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChartComparison { get; set; } 

    [JsonProperty("autosize", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Autosize { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

}