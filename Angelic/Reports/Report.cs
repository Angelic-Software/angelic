using System.CodeDom.Compiler;
using Angelic.Agent;
using Angelic.Dtos;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Reports;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Report
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }
    
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }
    
    [JsonProperty("sql", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sql { get; set; }
    
    [JsonProperty("reportingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReportingPeriod { get; set; }
    
    [JsonProperty("availablefields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AvailableFields { get; set; }
    
    [JsonProperty("selectedfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SelectedFields { get; set; }
    
    [JsonProperty("reportingperiodstartdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ReportingPeriodStartDate { get; set; }
    
    [JsonProperty("reportingperiodenddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ReportingPeriodEndDate { get; set; }
    
    [JsonProperty("reportingperioddatefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReportingPeriodDateField { get; set; }
    
    [JsonProperty("sqlid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SqlId { get; set; }
    
    [JsonProperty("charttitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChartTitle { get; set; }
    
    [JsonProperty("xaxis", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XAxis { get; set; }
    
    [JsonProperty("yaxis", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? YAxis { get; set; }
    
    [JsonProperty("xaxiscaption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XAxisCaption { get; set; }
    
    [JsonProperty("yaxiscaption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? YAxisCaption { get; set; }
    
    [JsonProperty("graphorderby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GraphOrderBy { get; set; }
    
    [JsonProperty("charttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChartType { get; set; }
    
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
    
    [JsonProperty("showgraphvalues", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowGraphValues { get; set; }
    
    [JsonProperty("client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client { get; set; }
    
    [JsonProperty("builtinid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? BuiltInId { get; set; }
    
    [JsonProperty("seriestype1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SeriesType1 { get; set; }
    
    [JsonProperty("seriestype2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SeriesType2 { get; set; }
    
    [JsonProperty("seriestype3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SeriesType3 { get; set; }
    
    [JsonProperty("seriestype4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SeriesType4 { get; set; }
    
    [JsonProperty("seriestype5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SeriesType5 { get; set; }
    
    [JsonProperty("yaxis1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? YAxis1 { get; set; }
    
    [JsonProperty("yaxis2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? YAxis2 { get; set; }
    
    [JsonProperty("yaxis3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? YAxis3 { get; set; }
    
    [JsonProperty("yaxis4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? YAxis4 { get; set; }
    
    [JsonProperty("yaxis5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? YAxis5 { get; set; }
    
    [JsonProperty("stackbars", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? StackBars { get; set; }
    
    [JsonProperty("includesummary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeSummary { get; set; }
    
    [JsonProperty("timezonename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TimeZoneName { get; set; }
    
    [JsonProperty("onlyshowsummaries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OnlyShowSummaries { get; set; }
    
    [JsonProperty("usetechlink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseTechLink { get; set; }
    
    [JsonProperty("is_published", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsPublished { get; set; }
    
    [JsonProperty("published_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PublishedId { get; set; }
    
    [JsonProperty("sqlhasdatefilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SqlHasDateFilter { get; set; }
    
    [JsonProperty("usesdynamicsql", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UsesDynamicSql { get; set; }
    
    [JsonProperty("available_columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ReportColumn>? AvailableColumns { get; set; }
    
    [JsonProperty("columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ReportColumn>? Columns { get; set; }
    
    [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ReportFilter>? Filters { get; set; }
    
    [JsonProperty("conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ReportFilter>? Conditions { get; set; }
    
    [JsonProperty("filterable_columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ReportColumn>? FilterableColumns { get; set; }
    
    [JsonProperty("filterable_columns_conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ReportColumn>? FilterableColumnsConditions { get; set; }
    
    [JsonProperty("permissions_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentReport>? PermissionsAgent { get; set; }
    
    [JsonProperty("permissions_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UserAnalyzer>? PermissionsUser { get; set; }
    
    [JsonProperty("schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StdRequestList>? Schedule { get; set; }
    
    [JsonProperty("local_library_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LocalLibraryId { get; set; }
    
    [JsonProperty("is_onlinerepository_report", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsOnlineRepositoryReport { get; set; }
    
    [JsonProperty("get_reportfield_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GetReportFieldValues { get; set; }
    
    [JsonProperty("get_reportcondition_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GetReportConditionValues { get; set; }
    
    [JsonProperty("filter_lookup_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? FilterLookupValues { get; set; }
    
    [JsonProperty("report", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ReportContent? Report { get; set; }
    
    [JsonProperty("previous_report", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ReportContent? PreviousReport { get; set; }
    
    [JsonProperty("_testonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TestOnly { get; set; }
    
    [JsonProperty("_testchart", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TestChart { get; set; }
    
    [JsonProperty("_loadreportonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LoadReportOnly { get; set; }
    
    [JsonProperty("_print_preview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrintPreview { get; set; }
    
    [JsonProperty("_print_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrintGenerate { get; set; }
    
    [JsonProperty("_xls_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? XlsGenerate { get; set; }
    
    [JsonProperty("_json_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? JsonGenerate { get; set; }
    
    [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PrintHtml { get; set; }
    
    [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PdfAttachmentId { get; set; }
    
    [JsonProperty("xls_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? XlsAttachmentId { get; set; }
    
    [JsonProperty("xls_attachment_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XlsAttachmentLink { get; set; }
    
    [JsonProperty("csv_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CsvAttachmentId { get; set; }
    
    [JsonProperty("csv_attachment_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CsvAttachmentLink { get; set; }
    
    [JsonProperty("json_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? JsonAttachmentId { get; set; }
    
    [JsonProperty("json_attachment_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JsonAttachmentLink { get; set; }
    
    [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PdfTemplateId { get; set; }
    
    [JsonProperty("pdftemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PdfTemplateName { get; set; }
    
    [JsonProperty("pdftemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public PdfTemplate? PdfTemplate { get; set; }
    
    [JsonProperty("chart_base64", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChartBase64 { get; set; }
    
    [JsonProperty("customise_table_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CustomiseTableHtml { get; set; }
    
    [JsonProperty("report_table_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReportTableHtml { get; set; }
    
    [JsonProperty("report_table_row_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReportTableRowHtml { get; set; }
    
    [JsonProperty("report_table_group_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReportTableGroupHtml { get; set; }
    
    [JsonProperty("report_table_total_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReportTableTotalHtml { get; set; }
    
    [JsonProperty("alreadyconverted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AlreadyConverted { get; set; }
    
    [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceId { get; set; }
    
    [JsonProperty("quote_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QuoteId { get; set; }
    
    [JsonProperty("consignment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConsignmentId { get; set; }
    
    [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractId { get; set; }
    
    [JsonProperty("purchase_order_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PurchaseOrderId { get; set; }
    
    [JsonProperty("sales_order_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesOrderId { get; set; }
    
    [JsonProperty("asset_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetId { get; set; }
    
    [JsonProperty("bookmarked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Bookmarked { get; set; }
    
    [JsonProperty("report_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReportAccessToken { get; set; }
    
    [JsonProperty("colourpallette", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ColourPallette { get; set; }
    
    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; }
    
    [JsonProperty("show_top_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowTopOnly { get; set; }
    
    [JsonProperty("top_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TopCount { get; set; }
    
    [JsonProperty("show_trendline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowTrendline { get; set; }
    
    [JsonProperty("show_datavalues", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowDataValues { get; set; }
    
    [JsonProperty("series", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ReportSeries>? Series { get; set; }
    
    [JsonProperty("colours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ReportColour>? Colours { get; set; }
    
    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; }
    
    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; }
    
    [JsonProperty("report_comparison", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReportComparison { get; set; }
    
    [JsonProperty("chart_comparison", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChartComparison { get; set; }
    
    [JsonProperty("_run_prompt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RunPrompt { get; set; }
    
    [JsonProperty("_check_prompt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CheckPrompt { get; set; }
    
    [JsonProperty("ai_prompt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AiPrompt { get; set; }
    
    [JsonProperty("ai_threadid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AiThreadId { get; set; }
    
    [JsonProperty("ai_runid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AiRunId { get; set; }
    
    [JsonProperty("assistant_request", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AiAssistantRequest.AiAssistantRequest? AssistantRequest { get; set; }
    
    [JsonProperty("publish_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PublishType { get; set; }
    
    [JsonProperty("apply_query_builder_perms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ApplyQueryBuilderPerms { get; set; }
    
    [JsonProperty("last_run_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastRunDate { get; set; }
    
    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GroupId { get; set; }
    
    [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GroupName { get; set; }
    
    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; }
    
    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; }
    
    [JsonProperty("datasource_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DatasourceId { get; set; }
    
    [JsonProperty("restrictaccess", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RestrictAccess { get; set; }
    
    [JsonProperty("systemreportid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SystemReportId { get; set; }
    
    [JsonProperty("mainentity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MainEntity { get; set; }
    
    [JsonProperty("canbeaccessedbyallusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanBeAccessedByAllUsers { get; set; }
    
    [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanUpdate { get; set; }
    
    [JsonProperty("apiquery_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApiQueryId { get; set; }
}
