using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PagerDutyMapping
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("serviceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Serviceid { get; set; } 

    [JsonProperty("service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Service_name { get; set; } 

    [JsonProperty("default_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_tickettype { get; set; } 

    [JsonProperty("tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tickettype_name { get; set; } 

    [JsonProperty("default_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_agent { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Agent_name { get; set; } 

    [JsonProperty("dontsyncusertickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontsyncusertickets { get; set; } 

    [JsonProperty("new_webhook_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_webhook_signature { get; set; } 

    [JsonProperty("default_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_user { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? User_name { get; set; } 

    [JsonProperty("default_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_description { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}