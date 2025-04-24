using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Ticket;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TicketVectorScore
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Use { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("matched_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MatchedId { get; set; } 

    [JsonProperty("search_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? SearchScore { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } 

    [JsonProperty("date_occurred", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateOccurred { get; set; } 

    [JsonProperty("date_closed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateClosed { get; set; } 

    [JsonProperty("article_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ArticleDescription { get; set; } 

    [JsonProperty("article_resolution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ArticleResolution { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}