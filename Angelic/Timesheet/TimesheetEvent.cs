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
    public int? EventType { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

    [JsonProperty("timetaken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Timetaken { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("break_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BreakType { get; set; } 

    [JsonProperty("break_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BreakNote { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("action_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ActionNumber { get; set; } 

    [JsonProperty("action_invoice_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ActionInvoiceNumber { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("customer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Customer { get; set; } 

    [JsonProperty("holiday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HolidayId { get; set; } 

    [JsonProperty("charge_type_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChargeTypeColour { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserName { get; set; } 

    [JsonProperty("charge_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChargeRate { get; set; } 

    [JsonProperty("mileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mileage { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TickettypeId { get; set; } 

    [JsonProperty("lognewticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Lognewticket { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category1 { get; set; } 

    [JsonProperty("category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category2 { get; set; } 

    [JsonProperty("category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category3 { get; set; } 

    [JsonProperty("category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category4 { get; set; } 

    [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractId { get; set; } 

    [JsonProperty("agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? Agents { get; set; } 

    [JsonProperty("clear_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ClearEnd { get; set; } 

    [JsonProperty("traveltime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Traveltime { get; set; } 

    [JsonProperty("originalstartdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Originalstartdate { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("charge_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChargeTypeName { get; set; } 

}