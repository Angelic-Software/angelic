using System.CodeDom.Compiler;
using Angelic.Models.Configuration;
using Angelic.Models.Configuration.Integrations;
using Angelic.Models.Configuration.Tickets.Workflows;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Chat;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ChatProfile
{
    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Key { get; set; } 

    [JsonProperty("access_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessType { get; set; } 

    [JsonProperty("chatnameoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Chatnameoverride { get; set; } 

    [JsonProperty("greeting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Greeting { get; set; } 

    [JsonProperty("bot_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BotName { get; set; } 

    [JsonProperty("technamevisibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Technamevisibility { get; set; } 

    [JsonProperty("technamevisibilitytext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Technamevisibilitytext { get; set; } 

    [JsonProperty("techmustonline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Techmustonline { get; set; } 

    [JsonProperty("workdays_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WorkdaysId { get; set; } 

    [JsonProperty("workdays_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WorkdaysName { get; set; } 

    [JsonProperty("logticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Logticket { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketTypeId { get; set; } 

    [JsonProperty("tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketTypeName { get; set; } 

    [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; } 

    [JsonProperty("icon_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IconSize { get; set; } 

    [JsonProperty("colour_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ColourType { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("theme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Theme { get; set; } 

    [JsonProperty("enable_feedback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableFeedback { get; set; } 

    [JsonProperty("feedback_message_before", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FeedbackMessageBefore { get; set; } 

    [JsonProperty("feedback_message_after", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FeedbackMessageAfter { get; set; } 

    [JsonProperty("cors_whitelist_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? CorsWhitelistList { get; set; } 

    [JsonProperty("steps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FlowDetail>? Steps { get; set; } 

    [JsonProperty("flow_chart_json", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FlowChartJson { get; set; } 

    [JsonProperty("in_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InUse { get; set; } 

    [JsonProperty("_chat_available", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ChatAvailable { get; set; } 

    [JsonProperty("_chat_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChatMode { get; set; } 

    [JsonProperty("_chatserviceurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Chatserviceurl { get; set; } 

    [JsonProperty("_tenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TenantId { get; set; } 

    [JsonProperty("bubble_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BubbleType { get; set; } 

    [JsonProperty("message_box_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MessageBoxSize { get; set; } 

    [JsonProperty("use_bubble_popup_message_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseBubblePopupMessageMappings { get; set; } 

    [JsonProperty("popup_message_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ChatPopupMessage>? PopupMessageMappings { get; set; } 

    [JsonProperty("default_ticket_clientsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultTicketClientsite { get; set; } 

    [JsonProperty("default_ticket_clientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultTicketClientsiteName { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("email_storage_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailStorageKey { get; set; } 

    [JsonProperty("name_storage_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NameStorageKey { get; set; } 

    [JsonProperty("fullscreen_threshold_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FullscreenThresholdOverride { get; set; } 

    [JsonProperty("bot_width_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BotWidthOverride { get; set; } 

    [JsonProperty("bot_height_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BotHeightOverride { get; set; } 

    [JsonProperty("bot_height_units", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BotHeightUnits { get; set; } 

    [JsonProperty("textcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Textcolour { get; set; } 

    [JsonProperty("textcolour_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TextcolourType { get; set; } 

    [JsonProperty("agent_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<NhdRoles>? AgentRoles { get; set; } 

    [JsonProperty("enable_start_message_mapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableStartMessageMapping { get; set; } 

    [JsonProperty("new_chat_window_controls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewChatWindowControls { get; set; } 

    [JsonProperty("abandoned_live_chat_check_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AbandonedLiveChatCheckPeriod { get; set; } 

    [JsonProperty("start_message_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ChatStartMessage>? StartMessageMappings { get; set; } 

    [JsonProperty("default_wait_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? DefaultWaitTime { get; set; } 

    [JsonProperty("wait_time_calc_mins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WaitTimeCalcMins { get; set; } 

    [JsonProperty("anon_token_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AnonTokenMethod { get; set; } 

    [JsonProperty("enable_user_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableUserMatching { get; set; } 

    [JsonProperty("new_hmac_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewHmacSecret { get; set; } 

    [JsonProperty("validate_lifetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ValidateLifetime { get; set; } 

    [JsonProperty("use_subject_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseSubjectMatching { get; set; } 

    [JsonProperty("new_user_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewUserSiteId { get; set; } 

    [JsonProperty("new_user_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewUserSiteName { get; set; } 

    [JsonProperty("usermappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? Usermappings { get; set; } 

    [JsonProperty("enable_feedback_comments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableFeedbackComments { get; set; } 

    [JsonProperty("feedback_message_before_comments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FeedbackMessageBeforeComments { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}