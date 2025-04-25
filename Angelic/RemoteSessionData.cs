using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class RemoteSessionData
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("thirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyid { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("actionnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Actionnumber { get; set; } 

    [JsonProperty("calllogid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Calllogid { get; set; } 

    [JsonProperty("customername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Customername { get; set; } 

    [JsonProperty("sitename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

    [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; } 

    [JsonProperty("emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailAddress { get; set; } 

    [JsonProperty("sessionstate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sessionstate { get; set; } 

    [JsonProperty("sessionfinished", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sessionfinished { get; set; } 

    [JsonProperty("unum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Unum { get; set; } 

    [JsonProperty("uname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Uname { get; set; } 

    [JsonProperty("queuedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Queuedate { get; set; } 

    [JsonProperty("leftqueuedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Leftqueuedate { get; set; } 

    [JsonProperty("sessionstartdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Sessionstartdate { get; set; } 

    [JsonProperty("sessionenddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Sessionenddate { get; set; } 

    [JsonProperty("matchedclient", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Matchedclient { get; set; } 

    [JsonProperty("matchedsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Matchedsite { get; set; } 

    [JsonProperty("matcheduser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Matcheduser { get; set; } 

    [JsonProperty("outcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Outcome { get; set; } 

    [JsonProperty("phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Phonenumber { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("resolved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Resolved { get; set; } 

    [JsonProperty("isnewreq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsNewreq { get; set; } 

    [JsonProperty("userid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Userid { get; set; } 

    [JsonProperty("livechatid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Livechatid { get; set; } 

    [JsonProperty("clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Clientid { get; set; } 

    [JsonProperty("siteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Siteid { get; set; } 

    [JsonProperty("_override_create_action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OverrideCreateAction { get; set; } 

    [JsonProperty("time_taken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TimeTaken { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("agent_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentUrl { get; set; } 

    [JsonProperty("new_webhook_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewWebhookPassword { get; set; } 

    [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ModuleId { get; set; } 

    [JsonProperty("recording_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RecordingUrl { get; set; } 

}