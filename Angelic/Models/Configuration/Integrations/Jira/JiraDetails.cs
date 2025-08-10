using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Jira;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class JiraDetails
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
    public string? InstanceUrl { get; set; } // Changed from Instance_url

    [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; }

    [JsonProperty("newmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewMethod { get; set; } // Changed from NewMethod

    [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewPassword { get; set; } // Changed from New_password

    [JsonProperty("sync_components", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncComponents { get; set; } // Changed from Sync_components

    [JsonProperty("issue_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IssueBody { get; set; } // Changed from Issue_body

    [JsonProperty("defaulttickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultTicketType { get; set; } // Changed from DefaultTickettype

    [JsonProperty("defaulttickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? DefaultTicketTypeGuid { get; set; } // Changed from DefaultTickettype_guid

    [JsonProperty("defaulttickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultTicketTypeName { get; set; } // Changed from DefaultTickettype_name

    [JsonProperty("defaultuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultUser { get; set; } // Changed from DefaultUser

    [JsonProperty("defaultuser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultUsername { get; set; } // Changed from DefaultUser_name

    [JsonProperty("visibletoendusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? VisibleToEndUsers { get; set; } // Changed from Visibletoendusers

    [JsonProperty("primary_update_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrimaryUpdateStatus { get; set; } // Changed from Primary_update_status

    [JsonProperty("relation_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RelationType { get; set; } // Changed from Relation_type

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; }

    [JsonProperty("issuetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IssueType { get; set; } // Changed from Issuetype

    [JsonProperty("defaultsendattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultSendAttachments { get; set; } // Changed from Defaultsendattachments

    [JsonProperty("default_reporter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultReporter { get; set; } // Changed from Default_reporter

    [JsonProperty("status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? StatusMappings { get; set; } // Changed from Status_mappings

    [JsonProperty("tickettype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<JiraMappings>? TicketTypeMappings { get; set; } // Changed from TicketType_mappings

    [JsonProperty("jirafield_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? JiraFieldMappings { get; set; } // Changed from Jirafield_mappings

    [JsonProperty("comment_contains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CommentContains { get; set; } // Changed from Comment_contains

    [JsonProperty("remove_comment_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RemoveCommentTag { get; set; } // Changed from Remove_comment_tag

    [JsonProperty("priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? PriorityMappings { get; set; } // Changed from Priority_mappings

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } // Changed from _warning
}