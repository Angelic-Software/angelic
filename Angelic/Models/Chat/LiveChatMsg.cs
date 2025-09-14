using System.CodeDom.Compiler;
using Angelic.Models.Configuration.SelfServicePortal;
using Angelic.Models.KnowledgeBase;
using Newtonsoft.Json;

namespace Angelic.Models.Chat;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record LiveChatMsg
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("chat_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChatId { get; set; } 

    [JsonProperty("sender_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SenderId { get; set; } 

    [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Text { get; set; } 

    [JsonProperty("value_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ValueInt { get; set; } 

    [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } 

    [JsonProperty("system_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SystemId { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("unknown_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UnknownId { get; set; } 

    [JsonProperty("display_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayName { get; set; } 

    [JsonProperty("lastmessageid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LastMessageId { get; set; } 

    [JsonProperty("_isremoteinvite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsRemoteInvite { get; set; } 

    [JsonProperty("_remoteintegration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RemoteIntegration { get; set; } 

    [JsonProperty("remotetechid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RemoteTechId { get; set; } 

    [JsonProperty("user_chat_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserChatUrl { get; set; } 

    [JsonProperty("input_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InputId { get; set; } 

    [JsonProperty("next_input_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NextInputId { get; set; } 

    [JsonProperty("next_input_fieldinfo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ChatInputField? NextInputFieldInfo { get; set; } 

    [JsonProperty("kb_search_results", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<KbArticleList>? KbSearchResults { get; set; } 

    [JsonProperty("services_search_results", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServSiteList>? ServicesSearchResults { get; set; } 

    [JsonProperty("chat_image_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChatImageType { get; set; } 

    [JsonProperty("attachment_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? AttachmentIds { get; set; } 

    [JsonProperty("attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AttachmentId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("value_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ValueBool { get; set; } 

    [JsonProperty("value_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ValueDate { get; set; } 

    [JsonProperty("value_multi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ValueMulti { get; set; } 

    [JsonProperty("is_message_safe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsMessageSafe { get; set; } 

}