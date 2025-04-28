using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SectionRequestType
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketTypeId { get; set; } 

    [JsonProperty("section_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SectionId { get; set; } 

    [JsonProperty("section_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SectionName { get; set; } 

    [JsonProperty("allowedteamsrestriction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowedteamsrestriction { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}