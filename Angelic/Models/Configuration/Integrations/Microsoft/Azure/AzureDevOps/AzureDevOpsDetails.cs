using System.CodeDom.Compiler;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Microsoft.Azure.AzureDevOps;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AzureDevOpsDetails
{
    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("instance_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InstanceUrl { get; set; } 

    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAccessToken { get; set; } 

    [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewMethod { get; set; } 

    [JsonProperty("fields_to_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldsToSync { get; set; } 

    [JsonProperty("fields_to_sync_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? FieldsToSyncList { get; set; } 

    [JsonProperty("sync_mapped_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncMappedFields { get; set; } 

    [JsonProperty("sync_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncAttachments { get; set; } 

    [JsonProperty("sync_area_path", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncAreaPath { get; set; } 

    [JsonProperty("sync_iteration_path", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncIterationPath { get; set; } 

    [JsonProperty("sync_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncPriority { get; set; } 

    [JsonProperty("sync_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncStatus { get; set; } 

    [JsonProperty("sync_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncStartDate { get; set; } 

    [JsonProperty("sync_target_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncTargetDate { get; set; } 

    [JsonProperty("status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? StatusMappings { get; set; } 

    [JsonProperty("priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? PriorityMappings { get; set; } 

    [JsonProperty("areapath_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? AreapathMappings { get; set; } 

    [JsonProperty("iterationpath_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? IterationpathMappings { get; set; } 

    [JsonProperty("otherfield_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? OtherfieldMappings { get; set; } 

    [JsonProperty("area_path_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AreaPathField { get; set; } 

    [JsonProperty("iteration_path_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IterationPathField { get; set; } 

    [JsonProperty("work_item_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WorkItemDescription { get; set; } 

    [JsonProperty("webhook_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WebhookUsername { get; set; } 

    [JsonProperty("new_webhook_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewWebhookPassword { get; set; } 

    [JsonProperty("webhook_salt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WebhookSalt { get; set; } 

    [JsonProperty("webhook_iterations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WebhookIterations { get; set; } 

    [JsonProperty("ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketType { get; set; } 

    [JsonProperty("ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketTypeName { get; set; } 

    [JsonProperty("ticket_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketUser { get; set; } 

    [JsonProperty("ticket_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketUserName { get; set; } 

    [JsonProperty("user_is_created_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UserIsCreatedBy { get; set; } 

    [JsonProperty("sync_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncSummary { get; set; } 

    [JsonProperty("private_updates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrivateUpdates { get; set; } 

    [JsonProperty("new_webhook_password_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewWebhookPasswordMethod { get; set; } 

    [JsonProperty("enableintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enableintegrator { get; set; } 

    [JsonProperty("lastsyncdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastSyncDate { get; set; } 

    [JsonProperty("lastsyncerror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LastSyncEror { get; set; } 

    [JsonProperty("update_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UpdateDays { get; set; } 

    [JsonProperty("enablepipelines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enablepipelines { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFilter>? Filters { get; set; } 

    [JsonProperty("import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportEntities { get; set; } 

    [JsonProperty("import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? ImportEntitiesList { get; set; } 

}