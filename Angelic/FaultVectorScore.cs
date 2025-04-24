using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FaultVectorScore
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Use { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("matched_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Matched_id { get; set; } 

    [JsonProperty("search_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Search_score { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_name { get; set; } 

    [JsonProperty("date_occurred", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date_occurred { get; set; } 

    [JsonProperty("date_closed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date_closed { get; set; } 

    [JsonProperty("article_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Article_description { get; set; } 

    [JsonProperty("article_resolution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Article_resolution { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}