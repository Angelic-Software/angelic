using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TeamsChatMessage_List
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("chat_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Chat_id { get; set; } 

    [JsonProperty("message_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Message_id { get; set; } 

    [JsonProperty("external_link_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? External_link_id { get; set; } 

    [JsonProperty("note_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note_html { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("who_azure_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Who_azure_id { get; set; } 

    [JsonProperty("who", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Who { get; set; } 

    [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datetime { get; set; } 

    [JsonProperty("whoagent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Whoagent_id { get; set; } 

    [JsonProperty("whoagent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Whoagent_name { get; set; } 

    [JsonProperty("_sendmessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _sendmessage { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("remote_session_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Remote_session_id { get; set; } 

}