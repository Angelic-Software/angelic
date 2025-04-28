using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using Angelic.Models.Areas;
using Angelic.Models.Sites;
using Angelic.Models.Users;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.CallManagement;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CallLog
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

    [JsonProperty("timetaken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TimeTaken { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } 

    [JsonProperty("client_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Area? ClientDetails { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

    [JsonProperty("site_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Site? SiteDetails { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserName { get; set; } 

    [JsonProperty("user_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public User? UserDetails { get; set; } 

    [JsonProperty("callerid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CallerId { get; set; } 

    [Phone]
    [JsonProperty("diallednumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DialledNumber { get; set; } 

    [JsonProperty("caller_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CallerName { get; set; } 

    [JsonProperty("caller_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CallerEmail { get; set; } 

    [JsonProperty("user_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserNumber { get; set; } 

    [JsonProperty("caller_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AddressStore? CallerAddress { get; set; } 

    [JsonProperty("outcome_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OutcomeId { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("action_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ActionNumber { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("call_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CallStatus { get; set; } 

    [JsonProperty("_complete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Complete { get; set; } 

    [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanUpdate { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyId { get; set; } 

    [JsonProperty("start_date_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StartDateNote { get; set; } 

    [JsonProperty("form_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FormId { get; set; } 

    [JsonProperty("update_user_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UpdateUserNumber { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("displayname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Displayname { get; set; } 

    [JsonProperty("existingticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Existingticketid { get; set; } 

    [JsonProperty("call_direction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CallDirection { get; set; } 

    [JsonProperty("call_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CallType { get; set; } 

    [JsonProperty("call_transcript", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CallTranscript { get; set; } 

    [JsonProperty("calllog_attachment_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CallLogAttachmentCount { get; set; } 

    [JsonProperty("transferred_agentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TransferredAgentId { get; set; } 

    [JsonProperty("transferred_teamid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TransferredTeamId { get; set; } 

    [JsonProperty("call_category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CallCategory { get; set; } 

    [JsonProperty("transferred_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TransferredTeamName { get; set; } 

    [JsonProperty("category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category1 { get; set; } 

    [JsonProperty("category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category2 { get; set; } 

    [JsonProperty("category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category3 { get; set; } 

    [JsonProperty("category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category4 { get; set; } 

}