using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.TeamsAndAgents.Agents;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AgentNotification
{
    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentName { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("delivery_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DeliveryMethod { get; set; } 

    [JsonProperty("sendpushnotification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sendpushnotification { get; set; } 

    [JsonProperty("sendpushnotificationbrowser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sendpushnotificationbrowser { get; set; } 

    [JsonProperty("popupinnotificationpane", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Popupinnotificationpane { get; set; } 

    [JsonProperty("eventno", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Eventno { get; set; } 

    [JsonProperty("emailtemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EmailTemplateId { get; set; } 

    [JsonProperty("emailtemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? EmailTemplateGuid { get; set; } 

    [JsonProperty("emailtemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailTemplateName { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserName { get; set; } 

    [JsonProperty("email_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailList { get; set; } 

    [JsonProperty("slack_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SlackId { get; set; } 

    [JsonProperty("interval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Interval { get; set; } 

    [JsonProperty("useworkinghours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Useworkinghours { get; set; } 

    [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestrictionType { get; set; } 

    [JsonProperty("restriction_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestrictionDepartmentId { get; set; } 

    [JsonProperty("restriction_department_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? RestrictionDepartmentGuid { get; set; } 

    [JsonProperty("restriction_department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RestrictionDepartmentName { get; set; } 

    [JsonProperty("restriction_team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestrictionTeamId { get; set; } 

    [JsonProperty("restriction_team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? RestrictionTeamGuid { get; set; } 

    [JsonProperty("restriction_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RestrictionTeamName { get; set; } 

    [JsonProperty("webhook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? WebhookId { get; set; } 

    [JsonProperty("agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentNotificationLink>? Agents { get; set; } 

    [JsonProperty("condition_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConditionCount { get; set; } 

    [JsonProperty("subscriber_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SubscriberCount { get; set; } 

    [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RoleId { get; set; } 

    [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RoleName { get; set; } 

    [JsonProperty("conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<NotificationConditions>? Conditions { get; set; } 

    [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanUpdate { get; set; } 

    [JsonProperty("slack_channel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SlackChannelName { get; set; } 

    [JsonProperty("teams_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TeamsId { get; set; } 

    [JsonProperty("teams_channel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TeamsChannelName { get; set; } 

    [JsonProperty("value1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Value1 { get; set; } 

    [JsonProperty("value1_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value1Name { get; set; } 

    [JsonProperty("_iszapier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Iszapier { get; set; } 

    [JsonProperty("filter_sitecontact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FilterSitecontact { get; set; } 

    [JsonProperty("sitecontact_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SitecontactType { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentNotificationLink>? Roles { get; set; } 

    [JsonProperty("mattermost_channelid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MattermostChannelid { get; set; } 

    [JsonProperty("mattermost_channel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MattermostChannelName { get; set; } 

    [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RuleId { get; set; } 

    [JsonProperty("rule_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RuleName { get; set; } 

    [JsonProperty("user_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentNotificationLink>? UserRoles { get; set; } 

    [JsonProperty("filter_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FilterType { get; set; } 

    [JsonProperty("customisecolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Customisecolour { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

}