using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TimesheetEvent
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("event_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Event_type { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Start_date { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? End_date { get; set; } 

    [JsonProperty("timetaken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Timetaken { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Agent_id { get; set; } 

    [JsonProperty("break_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Break_type { get; set; } 

    [JsonProperty("break_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Break_note { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("action_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Action_number { get; set; } 

    [JsonProperty("action_invoice_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Action_invoice_number { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("customer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Customer { get; set; } 

    [JsonProperty("holiday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Holiday_id { get; set; } 

    [JsonProperty("charge_type_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Charge_type_colour { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site_id { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? User_name { get; set; } 

    [JsonProperty("charge_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Charge_rate { get; set; } 

    [JsonProperty("mileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mileage { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tickettype_id { get; set; } 

    [JsonProperty("lognewticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Lognewticket { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_id { get; set; } 

    [JsonProperty("category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category1 { get; set; } 

    [JsonProperty("category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category2 { get; set; } 

    [JsonProperty("category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category3 { get; set; } 

    [JsonProperty("category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category4 { get; set; } 

    [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Contract_id { get; set; } 

    [JsonProperty("agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? Agents { get; set; } 

    [JsonProperty("clear_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Clear_end { get; set; } 

    [JsonProperty("traveltime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Traveltime { get; set; } 

    [JsonProperty("originalstartdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Originalstartdate { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("charge_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Charge_type_name { get; set; } 

}