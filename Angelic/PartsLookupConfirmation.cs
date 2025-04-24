using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PartsLookupConfirmation
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("database_lookup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Database_lookup_id { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("form_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Form_id { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Value { get; set; } 

    [JsonProperty("lookup_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lookup_values { get; set; } 

}