using System.CodeDom.Compiler;
using Angelic.Agent;
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
        public ICollection<AgentNotification>? Events { get; set; } 

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