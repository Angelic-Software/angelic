using System.CodeDom.Compiler;
using Angelic.Agent;
using Angelic.Configuration.Workflow;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations;

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
        public string? ContentType { get; set; } 

        [JsonProperty("authentication_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AuthenticationType { get; set; } 

        [JsonProperty("method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Method { get; set; } 

        [JsonProperty("basic_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BasicUsername { get; set; } 

        [JsonProperty("basic_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BasicPassword { get; set; } 

        [JsonProperty("certificate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CertificateId { get; set; } 

        [JsonProperty("certificate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CertificateName { get; set; } 

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } 

        [JsonProperty("events", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentNotification>? Events { get; set; } 

        [JsonProperty("last_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LastStatus { get; set; } 

        [JsonProperty("systemuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Systemuse { get; set; } 

        [JsonProperty("runbook_start_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RunbookStartType { get; set; } 

        [JsonProperty("inbound_authentication_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InboundAuthenticationType { get; set; } 

        [JsonProperty("authentication_header", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AuthenticationHeader { get; set; } 

        [JsonProperty("algorithm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Algorithm { get; set; } 

        [JsonProperty("digest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Digest { get; set; } 

        [JsonProperty("signature_prefix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SignaturePrefix { get; set; } 

        [JsonProperty("_iszapier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Iszapier { get; set; } 

        [JsonProperty("zapier_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ZapierType { get; set; } 

        [JsonProperty("zapier_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ZapierClientId { get; set; } 

        [JsonProperty("zapier_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ZapierSiteId { get; set; } 

        [JsonProperty("zapier_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ZapierUsername { get; set; } 

        [JsonProperty("zapier_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ZapierTickettypeId { get; set; } 

        [JsonProperty("zapier_status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ZapierStatusId { get; set; } 

        [JsonProperty("zapier_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ZapierSlaId { get; set; } 

        [JsonProperty("zapier_priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ZapierPriorityId { get; set; } 

        [JsonProperty("zapier_team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ZapierTeamId { get; set; } 

        [JsonProperty("zapier_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ZapierAgentId { get; set; } 

        [JsonProperty("mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<WebhookMapping>? Mappings { get; set; } 

        [JsonProperty("custom_payload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CustomPayload { get; set; } 

        [JsonProperty("payload_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PayloadType { get; set; } 

        [JsonProperty("flow_chart_json", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FlowChartJson { get; set; } 

        [JsonProperty("library_licence_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LibraryLicenceName { get; set; } 

        [JsonProperty("icon_base64", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IconBase64 { get; set; } 

        [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon { get; set; } 

        [JsonProperty("major_version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MajorVersionNumber { get; set; } 

        [JsonProperty("minor_version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MinorVersionNumber { get; set; } 

        [JsonProperty("patch_version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PatchVersionNumber { get; set; } 

        [JsonProperty("version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? VersionNumber { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? Note { get; set; } 

        [JsonProperty("install_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? InstallPopup { get; set; } 

        [JsonProperty("steps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FlowDetail>? Steps { get; set; } 

        [JsonProperty("input_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomIntegrationMethodValue>? InputVariables { get; set; } 

        [JsonProperty("standalone_methods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomIntegrationMethod>? StandaloneMethods { get; set; } 

        [JsonProperty("integrations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomIntegration>? Integrations { get; set; } 

        [JsonProperty("schedule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ScheduleId { get; set; } 

        [JsonProperty("disabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; } 

        [JsonProperty("lastcreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastcreated { get; set; } 

        [JsonProperty("nextcreationdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Nextcreationdate { get; set; } 

        [JsonProperty("log_retention_policy_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LogRetentionPolicyDays { get; set; } 

        [JsonProperty("batch_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BatchMethod { get; set; } 

        [JsonProperty("batch_delay_seconds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BatchDelaySeconds { get; set; } 

        [JsonProperty("batch_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BatchLimit { get; set; } 

        [JsonProperty("infinite_loop_threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InfiniteLoopThreshold { get; set; } 

        [JsonProperty("notify_on_failure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotifyOnFailure { get; set; } 

        [JsonProperty("_test", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Test { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }