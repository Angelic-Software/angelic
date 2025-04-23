using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Webhook
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("content_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Content_type { get; set; } 

        [JsonProperty("authentication_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Authentication_type { get; set; } 

        [JsonProperty("method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Method { get; set; } 

        [JsonProperty("basic_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Basic_username { get; set; } 

        [JsonProperty("basic_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Basic_password { get; set; } 

        [JsonProperty("certificate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Certificate_id { get; set; } 

        [JsonProperty("certificate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Certificate_name { get; set; } 

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } 

        [JsonProperty("events", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameNotification>? Events { get; set; } 

        [JsonProperty("last_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Last_status { get; set; } 

        [JsonProperty("systemuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Systemuse { get; set; } 

        [JsonProperty("runbook_start_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Runbook_start_type { get; set; } 

        [JsonProperty("inbound_authentication_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inbound_authentication_type { get; set; } 

        [JsonProperty("authentication_header", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Authentication_header { get; set; } 

        [JsonProperty("algorithm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Algorithm { get; set; } 

        [JsonProperty("digest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Digest { get; set; } 

        [JsonProperty("signature_prefix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Signature_prefix { get; set; } 

        [JsonProperty("_iszapier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _iszapier { get; set; } 

        [JsonProperty("zapier_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Zapier_type { get; set; } 

        [JsonProperty("zapier_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Zapier_client_id { get; set; } 

        [JsonProperty("zapier_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Zapier_site_id { get; set; } 

        [JsonProperty("zapier_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Zapier_username { get; set; } 

        [JsonProperty("zapier_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Zapier_tickettype_id { get; set; } 

        [JsonProperty("zapier_status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Zapier_status_id { get; set; } 

        [JsonProperty("zapier_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Zapier_sla_id { get; set; } 

        [JsonProperty("zapier_priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Zapier_priority_id { get; set; } 

        [JsonProperty("zapier_team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Zapier_team_id { get; set; } 

        [JsonProperty("zapier_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Zapier_agent_id { get; set; } 

        [JsonProperty("mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<WebhookMapping>? Mappings { get; set; } 

        [JsonProperty("custom_payload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Custom_payload { get; set; } 

        [JsonProperty("payload_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Payload_type { get; set; } 

        [JsonProperty("flow_chart_json", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Flow_chart_json { get; set; } 

        [JsonProperty("library_licence_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Library_licence_name { get; set; } 

        [JsonProperty("icon_base64", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon_base64 { get; set; } 

        [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon { get; set; } 

        [JsonProperty("major_version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Major_version_number { get; set; } 

        [JsonProperty("minor_version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Minor_version_number { get; set; } 

        [JsonProperty("patch_version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Patch_version_number { get; set; } 

        [JsonProperty("version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Version_number { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? Note { get; set; } 

        [JsonProperty("install_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? Install_popup { get; set; } 

        [JsonProperty("steps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FlowDetail>? Steps { get; set; } 

        [JsonProperty("input_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OutboundIntegrationMethodValue>? Input_variables { get; set; } 

        [JsonProperty("standalone_methods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OutboundIntegrationMethod>? Standalone_methods { get; set; } 

        [JsonProperty("integrations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OutboundIntegration>? Integrations { get; set; } 

        [JsonProperty("schedule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Schedule_id { get; set; } 

        [JsonProperty("disabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; } 

        [JsonProperty("lastcreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastcreated { get; set; } 

        [JsonProperty("nextcreationdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Nextcreationdate { get; set; } 

        [JsonProperty("log_retention_policy_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Log_retention_policy_days { get; set; } 

        [JsonProperty("batch_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Batch_method { get; set; } 

        [JsonProperty("batch_delay_seconds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Batch_delay_seconds { get; set; } 

        [JsonProperty("batch_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Batch_limit { get; set; } 

        [JsonProperty("infinite_loop_threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Infinite_loop_threshold { get; set; } 

        [JsonProperty("notify_on_failure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Notify_on_failure { get; set; } 

        [JsonProperty("_test", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _test { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class WebhookEvent
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; } 

        [JsonProperty("webhook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Webhook_id { get; set; } 

        [JsonProperty("integration_method_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Integration_method_id { get; set; } 

        [JsonProperty("integation_method_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integation_method_name { get; set; } 

        [JsonProperty("notification_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Notification_id { get; set; } 

        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Timestamp { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; } 

        [JsonProperty("duration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Duration { get; set; } 

        [JsonProperty("requestheaders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Requestheaders { get; set; } 

        [JsonProperty("requestbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Requestbody { get; set; } 

        [JsonProperty("responsestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Responsestatus { get; set; } 

        [JsonProperty("responseheaders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Responseheaders { get; set; } 

        [JsonProperty("responsebody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Responsebody { get; set; } 

        [JsonProperty("automation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Automation_id { get; set; } 

        [JsonProperty("automation_step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Automation_step { get; set; } 

        [JsonProperty("automation_iteration_state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Automation_iteration_state { get; set; } 

        [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Entity_id { get; set; } 

        [JsonProperty("error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Error { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("log_retention_policy_deletion_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Log_retention_policy_deletion_date { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class WebhookMapping
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("webhookid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Webhookid { get; set; } 

        [JsonProperty("fiusage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fiusage { get; set; } 

        [JsonProperty("fiusagename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fiusagename { get; set; } 

        [JsonProperty("fiid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fiid { get; set; } 

        [JsonProperty("finame", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Finame { get; set; } 

        [JsonProperty("filabel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Filabel { get; set; } 

        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Key { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum WebhookSubscriptionAction
    {

        _0 = 0,

        _1 = 1,

        _2 = 2,

        _3 = 3,

    }

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

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class WordpressComLinks
    {
        [JsonProperty("counts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Counts { get; set; } 

        [JsonProperty("self", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Self { get; set; } 

        [JsonProperty("help", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Help { get; set; } 

        [JsonProperty("site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class WordpressComMeta
    {
        [JsonProperty("links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public WordpressComLinks? Links { get; set; } 

        [JsonProperty("next_page", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Next_page { get; set; } 

        [JsonProperty("wpcom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Wpcom { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class WordpressComObject
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("slug", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Slug { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("post_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Post_count { get; set; } 

        [JsonProperty("parent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parent { get; set; } 

        [JsonProperty("meta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public WordpressComMeta? Meta { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class WordpressDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("connectionname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectionname { get; set; } 

        [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_integration_method { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _code { get; set; } 

        [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _exchangecode { get; set; } 

        [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Authorized { get; set; } 

        [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } 

        [JsonProperty("blogid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Blogid { get; set; } 

        [JsonProperty("blogurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Blogurl { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class WordpressOrgDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("connectionname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectionname { get; set; } 

        [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_integration_method { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("new_app_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_app_password { get; set; } 

        [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } 

        [JsonProperty("blogurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Blogurl { get; set; } 

        [JsonProperty("import_this_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Import_this_tag { get; set; } 

        [JsonProperty("post_status_to_import", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Post_status_to_import { get; set; } 

        [JsonProperty("custom_endpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Custom_endpoint { get; set; } 

        [JsonProperty("use_custom_endpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_custom_endpoint { get; set; } 

        [JsonProperty("import_this_tag_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Import_this_tag_name { get; set; } 

        [JsonProperty("default_faqlist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_faqlist { get; set; } 

        [JsonProperty("default_faqlist_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_faqlist_name { get; set; } 

        [JsonProperty("importcategories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Importcategories { get; set; } 

        [JsonProperty("nocategoryupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nocategoryupdate { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class WorkdayBreak
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("workday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workday_id { get; set; } 

        [JsonProperty("start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Start { get; set; } 

        [JsonProperty("end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End { get; set; } 

        [JsonProperty("incmonday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incmonday { get; set; } 

        [JsonProperty("inctuesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inctuesday { get; set; } 

        [JsonProperty("incwednesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incwednesday { get; set; } 

        [JsonProperty("incthursday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incthursday { get; set; } 

        [JsonProperty("incfriday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incfriday { get; set; } 

        [JsonProperty("incsaturday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incsaturday { get; set; } 

        [JsonProperty("incsunday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incsunday { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Workdays
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Timezone { get; set; } 

        [JsonProperty("start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Start { get; set; } 

        [JsonProperty("end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End { get; set; } 

        [JsonProperty("incmonday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incmonday { get; set; } 

        [JsonProperty("inctuesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inctuesday { get; set; } 

        [JsonProperty("incwednesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incwednesday { get; set; } 

        [JsonProperty("incthursday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incthursday { get; set; } 

        [JsonProperty("incfriday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incfriday { get; set; } 

        [JsonProperty("incsaturday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incsaturday { get; set; } 

        [JsonProperty("incsunday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incsunday { get; set; } 

        [JsonProperty("alldayssame", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Alldayssame { get; set; } 

        [JsonProperty("endmonday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Endmonday { get; set; } 

        [JsonProperty("endtuesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Endtuesday { get; set; } 

        [JsonProperty("endwednesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Endwednesday { get; set; } 

        [JsonProperty("endthursday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Endthursday { get; set; } 

        [JsonProperty("endfriday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Endfriday { get; set; } 

        [JsonProperty("endsaturday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Endsaturday { get; set; } 

        [JsonProperty("endsunday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Endsunday { get; set; } 

        [JsonProperty("startmonday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startmonday { get; set; } 

        [JsonProperty("starttuesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Starttuesday { get; set; } 

        [JsonProperty("startwednesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startwednesday { get; set; } 

        [JsonProperty("startthursday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startthursday { get; set; } 

        [JsonProperty("startfriday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startfriday { get; set; } 

        [JsonProperty("startsaturday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startsaturday { get; set; } 

        [JsonProperty("startsunday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startsunday { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("holidays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Holidays>? Holidays { get; set; } 

        [JsonProperty("timeslots", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Timeslot>? Timeslots { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("breaks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<WorkdayBreak>? Breaks { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class WorkflowHistory
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("moved_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Moved_from { get; set; } 

        [JsonProperty("moved_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Moved_to { get; set; } 

        [JsonProperty("flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Flow_id { get; set; } 

        [JsonProperty("moved_from_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Moved_from_stage { get; set; } 

        [JsonProperty("moved_to_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Moved_to_stage { get; set; } 

        [JsonProperty("moved_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Moved_date { get; set; } 

        [JsonProperty("target_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Target_date { get; set; } 

        [JsonProperty("target_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Target_hours { get; set; } 

        [JsonProperty("actual_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Actual_hours { get; set; } 

        [JsonProperty("target_met", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Target_met { get; set; } 

        [JsonProperty("override_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Override_date { get; set; } 

        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Action_id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class WorkflowTarget
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Flow_id { get; set; } 

        [JsonProperty("flow_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Flow_guid { get; set; } 

        [JsonProperty("target_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Target_type { get; set; } 

        [JsonProperty("start_stage_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Start_stage_id { get; set; } 

        [JsonProperty("start_stage_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Start_stage_name { get; set; } 

        [JsonProperty("end_stage_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? End_stage_id { get; set; } 

        [JsonProperty("end_stage_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? End_stage_name { get; set; } 

        [JsonProperty("start_steps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<WorkflowTargetStep>? Start_steps { get; set; } 

        [JsonProperty("end_steps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<WorkflowTargetStep>? End_steps { get; set; } 

        [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Target { get; set; } 

        [JsonProperty("target_units", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Target_units { get; set; } 

        [JsonProperty("workday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workday { get; set; } 

        [JsonProperty("workday_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workday_name { get; set; } 

        [JsonProperty("rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Autoassign>? Rules { get; set; } 

        [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rule_id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class WorkflowTargetStep
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("workflowtarget_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workflowtarget_id { get; set; } 

        [JsonProperty("step_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Step_id { get; set; } 

        [JsonProperty("is_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_end { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("flowheader_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Flowheader_id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class WorkspaceApplication
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; } 

        [JsonProperty("database_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Database_id { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Client_id { get; set; } 

        [JsonProperty("client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_secret { get; set; } 

        [JsonProperty("workspace_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workspace_id { get; set; } 

        [JsonProperty("workspace_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workspace_token { get; set; } 

    }