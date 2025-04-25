using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CategoryRestriction
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketTypeId { get; set; } 

    [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TeamId { get; set; } 

    [JsonProperty("team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? TeamGuid { get; set; } 

    [JsonProperty("service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceId { get; set; } 

    [JsonProperty("category_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CategoryId { get; set; } 

    [JsonProperty("category_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? CategoryGuid { get; set; } 

    [JsonProperty("category_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CategoryValue { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("partial_match_category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PartialMatchCategory { get; set; } 

    [JsonProperty("category_name_partial", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CategoryNamePartial { get; set; } 

    [JsonProperty("is_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsIntegration { get; set; } 

}