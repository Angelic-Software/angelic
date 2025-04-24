using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LiveChatMsg
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("chat_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Chat_id { get; set; } 

    [JsonProperty("sender_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sender_id { get; set; } 

    [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Text { get; set; } 

    [JsonProperty("value_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Value_int { get; set; } 

    [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } 

    [JsonProperty("system_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? System_id { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? User_id { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Agent_id { get; set; } 

    [JsonProperty("unknown_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Unknown_id { get; set; } 

    [JsonProperty("display_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Display_name { get; set; } 

    [JsonProperty("lastmessageid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Lastmessageid { get; set; } 

    [JsonProperty("_isremoteinvite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isremoteinvite { get; set; } 

    [JsonProperty("_remoteintegration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _remoteintegration { get; set; } 

    [JsonProperty("remotetechid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Remotetechid { get; set; } 

    [JsonProperty("user_chat_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? User_chat_url { get; set; } 

    [JsonProperty("input_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Input_id { get; set; } 

    [JsonProperty("next_input_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Next_input_id { get; set; } 

    [JsonProperty("next_input_fieldinfo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ChatInputField? Next_input_fieldinfo { get; set; } 

    [JsonProperty("kb_search_results", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<KBEntry_List>? Kb_search_results { get; set; } 

    [JsonProperty("services_search_results", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServSite_List>? Services_search_results { get; set; } 

    [JsonProperty("chat_image_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Chat_image_type { get; set; } 

    [JsonProperty("attachment_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? Attachment_ids { get; set; } 

    [JsonProperty("attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Attachment_id { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("value_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Value_bool { get; set; } 

    [JsonProperty("value_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Value_date { get; set; } 

    [JsonProperty("value_multi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value_multi { get; set; } 

    [JsonProperty("is_message_safe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_message_safe { get; set; } 

}