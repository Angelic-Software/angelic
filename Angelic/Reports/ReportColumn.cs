using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Reports;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReportColumn
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }
    
    [JsonProperty("report_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReportId { get; set; }
    
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }
    
    [JsonProperty("display_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayName { get; set; }
    
    [JsonProperty("datatype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DataType { get; set; }
    
    [JsonProperty("columnorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ColumnOrder { get; set; }
    
    [JsonProperty("is_visible", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsVisible { get; set; }
    
    [JsonProperty("is_filterable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsFilterable { get; set; }
    
    [JsonProperty("is_sortable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsSortable { get; set; }
    
    [JsonProperty("is_groupable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsGroupable { get; set; }
    
    [JsonProperty("width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Width { get; set; }
    
    [JsonProperty("format", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Format { get; set; }
    
    [JsonProperty("alignment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Alignment { get; set; }
    
    [JsonProperty("tooltip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tooltip { get; set; }
    
    [JsonProperty("is_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsSummary { get; set; }
    
    [JsonProperty("summary_function", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SummaryFunction { get; set; }
    
    [JsonProperty("lookup_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LookupValues { get; set; }
    
    [JsonProperty("is_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsDate { get; set; }
    
    [JsonProperty("is_numeric", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsNumeric { get; set; }
    
    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; }
    
    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; }
    
    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; }
    
    [JsonProperty("new_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewValue { get; set; }
    
    [JsonProperty("applied", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Applied { get; set; }
    
    [JsonProperty("applied_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? AppliedDate { get; set; }
    
    [JsonProperty("dismissed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dismissed { get; set; }
    
    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; }
}
