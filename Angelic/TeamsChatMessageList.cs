using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TeamsChatMessageList
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("chat_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChatId { get; set; } 

    [JsonProperty("message_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MessageId { get; set; } 

    [JsonProperty("external_link_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ExternalLinkId { get; set; } 

    [JsonProperty("note_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NoteHtml { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("who_azure_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WhoAzureId { get; set; } 

    [JsonProperty("who", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Who { get; set; } 

    [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datetime { get; set; } 

    [JsonProperty("whoagent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WhoagentId { get; set; } 

    [JsonProperty("whoagent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WhoagentName { get; set; } 

    [JsonProperty("_sendmessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sendmessage { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("remote_session_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RemoteSessionId { get; set; } 

}