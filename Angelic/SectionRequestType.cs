using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SectionRequestType
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tickettype_id { get; set; } 

    [JsonProperty("section_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Section_id { get; set; } 

    [JsonProperty("section_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Section_name { get; set; } 

    [JsonProperty("allowedteamsrestriction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowedteamsrestriction { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}