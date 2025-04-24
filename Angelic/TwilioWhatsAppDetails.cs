using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TwilioWhatsAppDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("twilio_sid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Twilio_sid { get; set; } 

    [JsonProperty("phone_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Phone_number { get; set; } 

    [JsonProperty("sender_configured", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sender_configured { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site_id { get; set; } 

    [JsonProperty("ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_type { get; set; } 

    [JsonProperty("reopen_existing_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Reopen_existing_tickets { get; set; } 

    [JsonProperty("allow_inbound", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allow_inbound { get; set; } 

    [JsonProperty("new_auth_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_auth_token { get; set; } 

    [JsonProperty("ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ticket_type_name { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site_name { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}