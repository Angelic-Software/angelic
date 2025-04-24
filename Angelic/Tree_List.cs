using System.CodeDom.Compiler;
using Angelic.Agent;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Tree_List
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("accounts_override_mailbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Accounts_override_mailbox { get; set; } 

    [JsonProperty("concurrent_lic_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Concurrent_lic_limit { get; set; } 

    [JsonProperty("organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Organisation_id { get; set; } 

    [JsonProperty("organisation_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Organisation_guid { get; set; } 

    [JsonProperty("organisation_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Organisation_name { get; set; } 

    [JsonProperty("org_department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Org_department_name { get; set; } 

    [JsonProperty("long_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Long_name { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SectionDetail_List>? Teams { get; set; } 

    [JsonProperty("agent_members", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentList>? Agent_members { get; set; } 

    [JsonProperty("managers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Manager>? Managers { get; set; } 

    [JsonProperty("user_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? User_count { get; set; } 

    [JsonProperty("open_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Open_ticket_count { get; set; } 

    [JsonProperty("onhold_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Onhold_ticket_count { get; set; } 

    [JsonProperty("total_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Total_ticket_count { get; set; } 

    [JsonProperty("opened_thismonth_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Opened_thismonth_count { get; set; } 

}