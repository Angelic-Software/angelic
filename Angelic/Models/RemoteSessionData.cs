using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class RemoteSessionData
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("thirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyId { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("actionnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ActionNumber { get; set; } 

    [JsonProperty("calllogid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CallLogId { get; set; } 

    [JsonProperty("customername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CustomerName { get; set; } 

    [JsonProperty("sitename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

    [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; } 

    [JsonProperty("emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailAddress { get; set; } 

    [JsonProperty("sessionstate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SessionState { get; set; } 

    [JsonProperty("sessionfinished", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SessionFinished { get; set; } 

    [JsonProperty("unum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Unum { get; set; } 

    [JsonProperty("uname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Uname { get; set; } 

    [JsonProperty("queuedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? QueueDate { get; set; } 

    [JsonProperty("leftqueuedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LeftQueueDate { get; set; } 

    [JsonProperty("sessionstartdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SessionStartDate { get; set; } 

    [JsonProperty("sessionenddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SessionEndDate { get; set; } 

    [JsonProperty("matchedclient", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MatchedClient { get; set; } 

    [JsonProperty("matchedsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MatchedSite { get; set; } 

    [JsonProperty("matcheduser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchedUser { get; set; } 

    [JsonProperty("outcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Outcome { get; set; } 

    [JsonProperty("phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PhoneNumber { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("resolved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Resolved { get; set; }
    
    [JsonProperty("isnewreq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsNewReq { get; set; } 

    [JsonProperty("userid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Userid { get; set; } 

    [JsonProperty("livechatid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LiveChatId { get; set; } 

    [JsonProperty("clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("siteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

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