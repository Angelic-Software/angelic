using System.CodeDom.Compiler;
using Angelic.Agent;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Tree
{
    [JsonProperty("toplevel_mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Toplevel_mailbox_override { get; set; } 

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

    [JsonProperty("parentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Parentid { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes { get; set; } 

    [JsonProperty("kashflowurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kashflowurl { get; set; } 

    [JsonProperty("kashflowusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kashflowusername { get; set; } 

    [JsonProperty("kashflowpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kashflowpassword { get; set; } 

    [JsonProperty("mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mailbox_override { get; set; } 

    [JsonProperty("agent_department", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Agent_department { get; set; } 

    [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Messagegroup_id { get; set; } 

    [JsonProperty("agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentDepartment>? Agents { get; set; } 

    [JsonProperty("users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UserDepartment>? Users { get; set; } 

    [JsonProperty("cannedtext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CannedText>? Cannedtext { get; set; } 

    [JsonProperty("templates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StdRequest_List>? Templates { get; set; } 

    [JsonProperty("announcement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Announcement { get; set; } 

    [JsonProperty("invoice_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Invoice_class { get; set; } 

    [JsonProperty("quote_profit_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Quote_profit_currency { get; set; } 

    [JsonProperty("quote_profit_currency_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Quote_profit_currency_name { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _canupdate { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

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