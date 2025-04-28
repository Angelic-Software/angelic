using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Twilio;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TwilioWhatsAppDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("twilio_sid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TwilioSid { get; set; } 

    [JsonProperty("phone_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PhoneNumber { get; set; } 

    [JsonProperty("sender_configured", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SenderConfigured { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

    [JsonProperty("ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketType { get; set; } 

    [JsonProperty("reopen_existing_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReopenExistingTickets { get; set; } 

    [JsonProperty("allow_inbound", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowInbound { get; set; } 

    [JsonProperty("new_auth_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAuthToken { get; set; } 

    [JsonProperty("ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketTypeName { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}